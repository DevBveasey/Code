<?php
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: view_cart.php
 * - Description: displays the contents of the shopping cart allowes updates of its contents
*/

// set the page title and include the html header:
$page_title = 'Shopping Cart';
include ('includes/header.html');
$shippingTotal = 49.99;// shipping not set yet
$carrier = 'UPS'; //declare carrier

// Check if the form has been submitted (to update the cart):
if ($_SERVER['REQUEST_METHOD'] == 'POST') 
{
	if (isset($_POST['carrier'])) 
	{
		switch ($_POST['carrier']) 
		{
			case 'USPS':
				$shippingTotal = 29.99;
				$carrier = 'USPS';
				break;

			case 'UPS':
				$shippingTotal = 49.99;
				$carrier = 'UPS';
				break;

			case 'FedEx':
				$shippingTotal = 19.99;
				$carrier = 'FedEx';
				break;
		}
	}else
	{

	}
	
	

	// change the quantities:
	foreach ($_POST['qty'] as $k => $v) 
	{
	
		// Must be integers!
		$pid = (int) $k;
		$qty = (int) $v;
		
		if ($qty == 0) // remove item
		{ 
			unset ($_SESSION['cart'][$pid]);
		} elseif ( $qty > 0 ) // change the quantity.
		{ 
			// prepare the query:
			$q = "SELECT Product_name, on_hand FROM products WHERE item_id=$pid";
			$r = mysqli_query($dbc, $q);
			$row = mysqli_fetch_array ($r, MYSQLI_NUM);
			if ($qty<= $row['1']) //do we have enough in stock
			{
				$_SESSION['cart'][$pid]['quantity'] = $qty;
			}else
			{
				echo '<p class="error">Our apologies, we dont have that many '.$row['0'].'\'s in stock at the moment. If you would like to bulk order please contact us using our help tab.</p>';
			}

			
		}
		
	} // End of FOREACH.
	
} // End of SUBMITTED IF

// Display the cart if it's not empty...
if (!empty($_SESSION['cart'])) 
{

	// Retrieve all of the information for the products in the cart:
	$q = "SELECT item_id, product_name FROM products WHERE item_id IN (";
	foreach ($_SESSION['cart'] as $pid => $value) 
	{
		$q .= $pid . ',';
	}
	$q = substr($q, 0, -1) . ') ORDER BY item_id ASC';
	$r = mysqli_query ($dbc, $q);
	
	// Create a form and a table:
	echo '<form action="view_cart.php" method="post">
	<table border="1|0" width="50%" cellspacing="3" align="center">
	<tr>
		<td align="left" width="30%"><b>Product Name</b></td>
		<td align="right" width="20%"><b>Price</b></td>
		<td align="center" width="20%"><b>Qty</b></td>
		<td align="right" width="10%"><b>Total Price</b></td>
	</tr>
	';
	
	// Print each item
	$itemTotal = 0;	// Total cost of the order.
	while ($row = mysqli_fetch_array ($r, MYSQLI_ASSOC)) {
		
		// Calculate the total and sub-totals.
		$subtotal = $_SESSION['cart'][$row['item_id']]['quantity'] * $_SESSION['cart'][$row['item_id']]['price'];
		$itemTotal += $subtotal;
		
		// Print the row:
		echo "\t<tr>
		<td align=\"left\">{$row['product_name']}</td>
		<td align=\"right\">\${$_SESSION['cart'][$row['item_id']]['price']}</td>
		<td align=\"center\"><input type=\"text\" size=\"3\" name=\"qty[{$row['item_id']}]\" value=\"{$_SESSION['cart'][$row['item_id']]['quantity']}\" /></td>
		<td align=\"right\">$" . number_format ($subtotal, 2) . "</td>
		</tr>\n";
		
	} // end of while loop
	$total = $itemTotal + $shippingTotal;
	
	mysqli_close($dbc); // close the database connection.
	
	// Print the subtotal, close the table, and the form:
	echo '<tr>
		<td colspan="4" align="right"><b>Subtotal:</b></td>
		<td align="right">$' . number_format ($itemTotal, 2) . '</td>
	</tr>
	<tr>
		<td colspan="2" align="center">Choose shipping</td>
		<td colspan="1" align="center">
			<select name="carrier">
				<option value="USPS" '.(($carrier=='USPS')?"selected":"").'>USPS</option>
				<option value="UPS" '.(($carrier=='UPS')?"selected":"").'>UPS</option>
				<option value="FedEx" '.(($carrier=='FedEx')?"selected":"").'>FedEx</option></td>
			</select>
		<td align="right"><b>Shipping:</b></td>
		<td align="right">$' . number_format ($shippingTotal, 2) . '</td>
	</tr>
	<tr>
		<td colspan="4" align="right"><b>Total:</b></td>
		<td align="right">$' . number_format ($total, 2) . '</td>
	</tr>
	</table>
	<div align="center"><input type="submit" name="submit" value="Update My Cart" /></div>

	<table>

	</table>



	</form><p align="center">Enter a quantity of 0 to remove an item.
	<br /><br /><a href="checkout.php?t='.$total.'&s='.$shippingTotal.'&c='.$carrier.'">Checkout</a></p>';
	
} else {
	echo '<div class="center"><h2>Your cart is currently empty.</h2></div>';
}

include ('includes/footer.html');
?>
		

		