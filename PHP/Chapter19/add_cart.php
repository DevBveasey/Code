<?php #Script 19.9 - add_cart.php
// This page adds prints to the shopping cart.

// Set the page title and include the HTML header:
$page_title = 'Add to Cart';
include ('includes/header.html');

if (isset ($_GET['pid']) && filter_var($_GET['pid'], FILTER_VALIDATE_INT, array('min_range' => 1)) ) { // Check for a print id.
	$pid = $_GET['pid'];
	
	// Check if the cart already contains one of these prints;
	// if so, increment the quantity:
	if (isset($_SESSION['cart'][$pid])) {
		
		$_SESSION['cart'][$pid]['quantity']++; // add another
		
		// Display a message:
		echo '<p>Another copy of the print has been added to your shopping cart.</p>';
		
	} else { // New Product added
		
		// Get the print's price from the database.
		require ('../../mysqli_connect19.php'); // connect to the database.
		$q = "SELECT price FROM prints WHERE print_id=$pid";
		$r = mysqli_query ($dbc, $q);
		if (mysqli_num_rows($r) == 1) { // Valid print id.
		
			// Fetch the information.
			list($price) = mysqli_fetch_array ($r, MYSQLI_NUM);
			
			// Add to the cart:
			$_SESSION['cart'][$pid] = array('quantity' => 1, 'price' => $price);
			
			// Display a message:
			echo '<p>The print has been added to your shopping cart.</p>';
			
		} else { // Not a valid print ID.
			echo '<div align="center">This page has been accessed in error!</div>';
		}
		
		mysqli_close($dbc);
	
	}  // end of isset($_SESSION['cart'][$pid] conditional
		
} else { // No print id.
	echo '<div align="center">This page has been accessed in error!</div>';
}

include ('includes/footer.html');
?>
			