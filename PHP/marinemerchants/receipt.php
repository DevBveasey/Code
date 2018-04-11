<?php 
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: receipt.php
 * - Description: displays the receipt and emails the customer a copy
*/

// Set the page title and include the HTML header
$page_title = 'Order Receipt';
include ('includes/header.html');


if (isset($_GET['oid'])) //get order ID
{

	// Message to the customer:
	echo '<h2>Thank you for placing an order. You will be notifed when the items ship.</h2>';
	
	// Retrieve the total order date carrier and address
	$q = 'SELECT  total, order_date, carrier , address
	FROM orders o
	where order_id = '. $_GET['oid'];
	$r = mysqli_query ($dbc, $q);
	if (mysqli_num_rows($r) == 1) 
	{
		$row = mysqli_fetch_array ($r, MYSQLI_NUM);
		echo '<table border="1|0" width="90%" cellspacing="3" align="center">
			<tr>
				<td span="3" align="left" width="54%"><b>Order '.$_GET['oid'].'</b></td>
				<td span="2" align="right" width="36%"><b>'.$row[1].'</b></td>
				
			</tr>
			<tr>
				<td align="left" width="18%"><b>Shipped To: </b></td>
				<td align="right" width="18%"><b>'.$row[3].'</b></td>
				<td align="center" width="36%"><b>Shipped By: </b></td>
				<td align="right" width="18%"><b>'.$row[2].'</b></td>
			</tr>';

			$body = "Your order has been proccessed and is now waiting to be shipped! Not sure when this will happen but we will make an attempt... soon I think. \r\n";
			$body .= "Shipped to:$row[3] \r\n";
			$body .= "Shipped by:$row[2] \r\n";


		// Retrieve all items quantitys prices product names and descriptions.
		$q = 'SELECT c.item_id, c.quantity, c.price, p.product_name, p.description
		FROM order_contents c
		LEFT JOIN products p ON c.item_id = p.item_id
		where order_id = '.$_GET['oid'];
		$r = mysqli_query ($dbc, $q);
		if (mysqli_num_rows($r) > 0) 
		{
			while ($items = mysqli_fetch_array ($r))
			{
				echo '<tr>
						<td align="left" ><b>'.$items['product_name'].'</b></td>
						<td align="right" ><b>'.$items['price'].'</b></td>
						<td align="center" ><b>'.$items['quantity'].'</b></td>
						<td align="right" ><b>'.$items['description'].'</b></td>
					</tr>';
				$body .= "You Ordered $items[3] at $items[2]/each. X $items[1]\r\n";
				$body .= "Description: $items[4] \r\n";

			}
		}else //no items found
		{
			echo 'An issue occured getting your receipt. please contact us for a copy!';
		}
		echo '
			<tr>
				<td span="3" align="right" ><b>Order Total: </b></td>
				<td span="2" align="right"><b>'.$row[0].'</b></td>
			</tr>
			</table>';
		$body .= "Order Total:$ $row[0] \r\n";
		
	} else 
	{
		echo 'An issue occured getting your receipt. please contact us for a copy!';
	}

	
	// Send an email:
	mail ($_SESSION['email'], 'Order '.$_GET['oid'], $body, 'From: Orders@MarineMerchants.com');



}else//no order set
{
	echo '<p class="error">This page has been accessed in error.</p>';
}







 ?>