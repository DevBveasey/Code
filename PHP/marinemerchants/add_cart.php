<?php
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: add_cart.php
 * - Description: adds products to the shopping cart
*/

// Set the page title and include the HTML header:
$page_title = 'Add to Cart';
include ('includes/header.html');

// Check for a product id.
if (isset ($_GET['pid']) && filter_var($_GET['pid'], FILTER_VALIDATE_INT, array('min_range' => 1)) ) 
{ 
	//store product id
	$pid = $_GET['pid'];

		// Check if the cart already contains one of these products;
		// if so, increment the quantity:
		if (isset($_SESSION['cart'][$pid])) 
		{
			
			$_SESSION['cart'][$pid]['quantity']++; // add another
			
			// Display a message:
			echo '<p>You now have more than one of these in your cart!</p>';
			
		}else 
		{ // New Product added
		
			// Get the products's price from the database.
			$q = "SELECT price FROM products WHERE item_id=$pid";
			$r = mysqli_query ($dbc, $q);
			if (mysqli_num_rows($r) == 1) 
			{ // Valid product id.
			
				// Fetch the information.
				list($price) = mysqli_fetch_array ($r, MYSQLI_NUM);
				
				// Add to the cart:
				$_SESSION['cart'][$pid] = array('quantity' => 1, 'price' => $price);
				
				// Display a message:
				echo '<p>The product has been added to your shopping cart.</p>';
				
			} else 
			{ // Not a valid product ID.
				echo '<div align="center">This page has been accessed in error!</div>';
			}
		
		mysqli_close($dbc);
	
	}  // end of isset($_SESSION['cart'][$pid] conditional
		
} else { // No product id.
	echo '<div align="center">This page has been accessed in error!</div>';
}

include ('includes/footer.html');
?>
			