<?php 
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: checkout.php
 * - Description: inserts the order information, skipps billing
*/

// Set the page title and include the HTML header
$page_title = 'Confirm Order';
include ('includes/header.html');
include ('includes/config.inc.php');
if (isset($_SESSION['cust_id'])) //varify user is logged in
{

	// set cid to cust_id
	$cid = $_SESSION['cust_id'];

	// get total and shipping cost
	if (isset($_GET['t'])) 
	{
		$total = $_GET['t'];
	}
	if (isset($_GET['s'])) 
	{
		$shippingTotal = $_GET['s'];
	}
	if (isset($_GET['c'])) 
	{
		$carrier = $_GET['c'];
	}

	
	//echo '<p>t= '.$total.'</p><p>s= '.$shippingTotal.'</p><p> c= '.$carrier.'</p>';
	
	if ($_SERVER['REQUEST_METHOD'] == 'POST')//finnal submit befor ordering
	{
		// Trim all the incoming data:
		$trimmed = array_map('trim', $_POST);
		
		// Assume invalid values:
		$add1 = $add2 = $city = $state = $zip =$phone = FALSE;

		// Check for a first address: REQUIRED 
		if (empty($trimmed['add1'])) 
		{
			echo '<p class="error">You must Enter a valid address to place your order.</p>';
		} else 
		{
			$add1 = mysqli_real_escape_string($dbc, trim($trimmed['add1']));
			$shippingAddress = $add1;
		}

		// Check for a second address: NOT REQUIRED 
		if (empty($_POST['add2'])) 
		{
			$add2 = 'NULL';
		} else 
		{
			$add2 = mysqli_real_escape_string($dbc, trim($_POST['add2']));
			$shippingAddress += ' '.$add2;
		}

		// Check for a city:  REQUIRED
		if (empty($_POST['city'])) 
		{
			echo '<p class="error">You must Enter a valid City to place your order.</p>';
		} else 
		{
			$city = mysqli_real_escape_string($dbc, trim($_POST['city']));
			$shippingAddress += ' '.$city;
		}

		// Check for a state: REQUIRED 
		if (empty($_POST['state'])) 
		{
			echo '<p class="error">You must Enter a valid State to place your order.</p>';
		} else 
		{
			$state = mysqli_real_escape_string($dbc, trim($_POST['state']));
			$shippingAddress += ' '.$state;
		}

		// Check for a zip: REQUIRED 
		if (empty($_POST['zip'])) 
		{
			echo '<p class="error">You must Enter a valid Zip code to place your order.</p>';
		} else 
		{
			$zip = mysqli_real_escape_string($dbc, trim($_POST['zip']));
			$shippingAddress += ', '.$zip;
		}
		if (isset($row[5])) 
		{
			$phone=$row[5];
		}else
		{
			// Check for an phone: REQUIRED 
			if (empty($_POST['area']) or empty($_POST['phone1']) or empty($_POST['phone2']) 
				or !is_numeric($_POST['area']) or !is_numeric($_POST['phone1']) or !is_numeric($_POST['phone2'])) 
			{
				echo '<p class="error">You must Enter a valid Phone number to place your order.</p>';
			}else 
			{
				$tel= '('. $_POST['area'] . ') ' . $_POST['phone1'] . '-' . $_POST['phone2'];
				$phone = mysqli_real_escape_string($dbc, trim($tel));
			}
		}
		if (isset($add2) && $add2 !== 'NULL') 
		{
			$shippingAddress = $add1.' '.$add2.' '.$city.', '.$state.' '.$zip;
			echo $shippingAddress;
		}else
		{
			$shippingAddress = $add1.' '.$city.', '.$state.' '.$zip;
		}
		

		if ($shippingAddress && $phone) 
		{
			// Turn autocommit off:
			mysqli_autocommit($dbc, FALSE);

			// Add the order to the orders table...
			$q = "INSERT INTO orders(cust_id, total, order_date, shipping_total, carrier,address, phone) 
			VALUES ('$cid', '$total',NOW(), '$shippingTotal', '$carrier', '$shippingAddress', '$phone' )";
			$r = mysqli_query($dbc, $q);
			if (mysqli_affected_rows($dbc) == 1) 
			{

				// Need the order ID:
				$oid = mysqli_insert_id($dbc);
				
				// insert the specified order contents into the database...
				
				// prepare the query:
				$q = "INSERT INTO order_contents (order_id, item_id, quantity, price) VALUES (?, ?, ?, ?)";
				$stmt = mysqli_prepare($dbc, $q);
				mysqli_stmt_bind_param($stmt, 'iiid', $oid, $pid, $qty, $price);
				// execute each query; count the total affected:
				$affected = 0;
				foreach ($_SESSION['cart'] as $pid => $item) 
				{
					$qty = $item['quantity'];
					$price = $item['price'];
					mysqli_stmt_execute($stmt);
					$affected += mysqli_stmt_affected_rows($stmt);
					
				}
				
				// Close this prepared statement:
				mysqli_stmt_close($stmt);
				// Report on the success...
				if ($affected == count($_SESSION['cart'])) 
				{	
					// Commit the transaction:
					mysqli_commit($dbc);
					
					// Clear the cart:
					unset($_SESSION['cart']);
					
					// redirect user to receipt.php passing order id
					header('location:'.BASE_URL. 'receipt.php?oid='. $oid);
					
					// Send an email:
					$body = "Your order has been proccessed and is now waiting to be shipped! Not sure when this will happen but we will make an attempt... soon I think. ";
					mail ($_SESSION['email'], 'Order '.$oid, $body, 'From: Shipping@MarineMerchants.com');
					
				} else // Rollback and report the problem.
				{ 
				
					mysqli_rollback($dbc);
					
					echo '<p>1Your order could noted be processed due to a system error. You will be contacted in order to have the problem fixed. We apologize for the inconvenience.</p>';

					// Send the order information to the administrator.
					// Send an email:
					$body = $_SESSION['first_name'] .' attempted to place an order that failed!';
					mail ('CustomerServices@MarineMerchants.com' , 'Failed Order '.$oid, $body, 'From: Ordering@MarineMerchants.com');

				}
				
			} else // Rollback an report the problem.
			{ 

				mysqli_rollback($dbc);
					
				echo '<p>2Your order could not be processed due to a system error. You will be contacted in order to have the problem fixed. We apologize for the inconvenience.</p>';
				
				// Send the order information to the administrator.
					// Send an email:
					$body = $_SESSION['first_name'] .' attempted to place an order that failed!';
					mail ('CustomerServices@MarineMerchants.com' , 'Failed Order ', $body, 'From: Ordering@MarineMerchants.com');
				
			}//end add order
		}//end if form data ok
		
	}
	


	//always show form
	$q = "SELECT `address1`, `address2`, `city`, `state`, `zip`, `phone` 
	FROM `customers` WHERE cust_id= $cid";
	$r = @mysqli_query ($dbc, $q);
	if (mysqli_num_rows($r) == 1) 
	{ // Valid user ID, show the form.

		// Get the user's information:
		$row = mysqli_fetch_array ($r, MYSQLI_NUM);

		echo '<h1>Shipping Address</h1>
		<form action="checkout.php?t='.$total.'&s='.$shippingTotal.'&c='.$carrier.'" method="post">
			<fieldset>

			<p><label for="add1">Address 1:</label> <input id="add1" type="text" name="add1" size="15" maxlength="60" value="'. $row[0] .'" /></p>

			<p><label for="add2">Address 2:</label> <input id="add2" type="text" name="add2" size="15" maxlength="60" value="'. $row[1] .'" /></p>

			<p><label for="city">City:</label> <input id="city" type="text" name="city" size="15" maxlength="20" value="'.$row[2].'" /></p>

			<p><label for="state">State:</label> <input id="state" type="text" name="state" size="15" maxlength="20" value="'.$row[3].'" /></p>

			<p><label for="zip">Zip:</label> <input id="zip" type="text" name="zip" size="15" maxlength="6" value="'.$row[4].'" /></p>

			<p><label for="phone">Phone:</label>
				<input type="text" id="phone" name="area" maxlength="3" style="width: 22px;">
				<input type="text" name="phone1" maxlength="3" style="width: 22px;">
				<input type="text" name="phone2" maxlength="4" style="width: 30px;"></p>
			
			</fieldset>
			
			<div align="center"><input type="submit" name="submit" value="Finalize order" /></div>
			
		</form>';
	} else 
	{ // Not a valid user ID.
		echo '<p class="error">This page has been accessed in error.</p>';
	}
	
}else // customer is not logged-in
{
	echo '<p class="error">You must be logged-in to place your order.</p>';
}
mysqli_close($dbc);
include ('includes/footer.html');
?>	
