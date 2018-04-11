<?php 
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: view_product.php
 * - Description: displays the details for a particular product
*/

require ('includes/config.inc.php');

$row = False;

//get product info and display
if (isset($_GET['pid']) && filter_var($_GET['pid'] && isset($_GET['pname']), FILTER_VALIDATE_INT, array('min_range' => 1)) ) { // make sure there's a product ID!

	//store variables and display header
	$pid = $_GET['pid'];
	$page_title = $_GET['pname'];
	include ('includes/header.html');

	
	// get the product info:
	$q = "SELECT item_id, product_name, description, on_hand, sold, price, image_name
	FROM products
	WHERE item_id = $pid";
	
	$r = mysqli_query ($dbc, $q);
	if (mysqli_num_rows($r) == 1) { // Good to go!
		
		// Fetch the information:
		$row = mysqli_fetch_array ($r, MYSQLI_ASSOC);
		
		// Display a header:
		echo '<div id="product_page" class="border">';//begin wrapper
		echo "<div align=\"center\">
		<h1>{$row['product_name']}</h1>";
		
		echo '<h3>$'.$row['price'].'<h3>';//display price
		if ($row['on_hand'] > 0) //check if the product is in stock
		{
			echo "<a href=\"add_cart.php?pid=$pid\">Add to Cart</a>";
		}else// out of stock
		{
			echo 'Out of Stock';
		}
		
		
		// Get the image information and display the image:
		if ($image = @getimagesize ("../../uploadmm/$pid")) 
		{
			echo "<div align=\"center\"><img id=\"product\" src=\"show_image.php?image=$pid&name=" . urlencode($row['image_name']) . "\" $image[3] alt=\"{$row['product_name']}\" /></div>\n";
		} else { 
			echo "<div align=\"center\">No image available.</div>\n";
		}
		
		// add the description or a default message:
		echo '<p align="center">' . ((is_null($row['description'])) ? '(No description available)' : $row['description']) . '</p>';
		echo '</div>';
		
	} // end of mysqli_num_rows() if
	
	mysqli_close($dbc);
	
} // End of $_GET['pid'] if

if (!$row) { // show error message
	$page_title = 'Error';
	include ('includes/header.html');
	echo '<div align="center">This page has been access in error!</div>';
}

// Complete the page:
include ('includes/footer.html');
?>
