<?php 
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: index.php
 * - Description: main page/landing page for the site
*/

// include the HTML header:
include ('includes/header.html');

if (isset($_SESSION['first_name'])) //if a session is set then welcome user by name
{
	echo '<h1> Welcome '. $_SESSION['first_name'] .' your business is appreciated!</h1>';
}else // display required msg to guest
{
	echo '<h1> Welcome, you are required to be logged-in to place an order!</h1>';
}
?>

<p>Welcome to our site....please use the links above...blah, blah, blah.</p>
<p>Welcome to our site....please use the links above...blah, blah, blah.</p>

<?php include ('includes/footer.html'); ?>