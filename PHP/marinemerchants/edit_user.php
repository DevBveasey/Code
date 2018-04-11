<?php 
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: edit_user.php
 * - Description: allows customer to change their info
*/

$page_title = 'Edit My Account';
include ('includes/header.html');
echo '<h1>Edit My Account</h1>';

// Check for a valid user ID, through GET or POST:
if ((isset($_GET['cid'])) && (is_numeric($_GET['cid'])) ) { // From view_users.php
	$cid = $_GET['cid'];
}else { // No valid ID, kill the script.
	echo '<p class="error">This page has been accessed in error.</p>';
	include ('includes/footer.html');
	exit();
}

if ($_SERVER['REQUEST_METHOD'] == 'POST') { // Handle the form when submited

	// Trim all the incoming data:
	$trimmed = array_map('trim', $_POST);
	
	// Assume invalid values:
	$fn = $ln = $e = $p = $add1 = $add2 = $city = $state = $zip =$phone = FALSE;

	// Check for a first name:
	if (preg_match ('/^[A-Z \'.-]{2,20}$/i',$trimmed['first_name'])) {
		$fn = mysqli_real_escape_string($dbc, $trimmed['first_name']);	
	} else {
		echo '<p class="error">Please enter your first name!</p>';
	}
	
	// Check for a last name:
	if (preg_match ('/^[A-Z \'.-]{2,40}$/i',$trimmed['last_name'])) {
		$ln = mysqli_real_escape_string($dbc, $trimmed['last_name']);	
	} else {
		echo '<p class="error">Please enter your last name!</p>';
	}

	// Check for an email address:
	if (filter_var($trimmed['email'],FILTER_VALIDATE_EMAIL)) 
	{
		$e = mysqli_real_escape_string($dbc, $trimmed['email']);
	} else 
	{
		echo '<p class="error">Please enter a valid email address.';		
	}

	// Check for a first address: NOT REQUIRED 
	if (empty($trimmed['add1'])) 
	{
		$add1 = 'NULL';
	} else 
	{
		$add1 = mysqli_real_escape_string($dbc, trim($trimmed['add1']));
	}

	// Check for a second address: NOT REQUIRED 
	if (empty($_POST['add2'])) 
	{
		$add2 = 'NULL';
	} else 
	{
		$add2 = mysqli_real_escape_string($dbc, trim($_POST['add2']));
	}

	// Check for a city: NOT REQUIRED 
	if (empty($_POST['city'])) 
	{
		$city = 'NULL';
	} else 
	{
		$city = mysqli_real_escape_string($dbc, trim($_POST['city']));
	}

	// Check for a state: NOT REQUIRED 
	if (empty($_POST['state'])) 
	{
		$state = 'NULL';
	} else 
	{
		$state = mysqli_real_escape_string($dbc, trim($_POST['state']));
	}

	// Check for a zip: NOT REQUIRED 
	if (empty($_POST['zip'])) 
	{
		$zip = 'NULL';
	} else 
	{
		$zip = mysqli_real_escape_string($dbc, trim($_POST['zip']));
	}

	// Check for an phone: NOT REQUIRED 
	if (empty($_POST['area']) or empty($_POST['phone1']) or empty($_POST['phone2']) 
		or !is_numeric($_POST['area']) or !is_numeric($_POST['phone1']) or !is_numeric($_POST['phone2'])) 
	{
		$phone = 'NULL';
	}else 
	{
		$tel= '('. $_POST['area'] . ') ' . $_POST['phone1'] . '-' . $_POST['phone2'];
		$phone = mysqli_real_escape_string($dbc, trim($tel));
	}

	if ($fn && $ln && $e && $add1 && $add2 && $city && $state && $zip && $phone) 
	{ // If everything's OK.
		
		// Make sure the email address is available:
		$q = "SELECT cust_id FROM customers WHERE cust_id=$cid";
		$r = @mysqli_query ($dbc, $q);
		
		if (mysqli_num_rows($r) == 1) 
		{
			// Update user info:
			$q = "UPDATE customers 
			SET first_name='$fn', last_name='$ln', email='$e', address1='$add1', address2='$add2', city='$city', state='$state', zip='$zip', phone='$phone' 
			WHERE cust_id=$cid";
			$r = @mysqli_query ($dbc, $q);			
			if (mysqli_affected_rows($dbc) == 1) { // If it ran OK.
				
				// Send the email:
				$body = "Thank you for updating you infomation! If you did not make this change contact is using the help tab immediately";
				mail($trimmed['email'], 'Account info update', $body, 'From: admin@Marinemerchants.com');
				
				// Finish the page:
				echo '<h3>Thank you for updating you infomation!</h3>';
				include ('includes/footer.html'); // Include the HTML footer.
				exit(); // Stop the page.
								
			} else { // If it did not run OK.
				echo '<p class="error">Your information could not be updated due to a system error. We apologize for any inconvenience.</p>';
			}
			
		} else { // The email address is not available.
			echo '<p class="error">This page has been accessed in error.</p>';
		}
		
	} else { // If one of the data tests failed.
		echo '<p class="error">Please try again.</p>';
	}
	
} // End of the main Submit conditional.

// Always show the form...	
		
// Retrieve the customers information:
$q = "SELECT `cust_id`, `first_name`, `last_name`, `email`,`address1`, `address2`, `city`, `state`, `zip`, `phone` FROM `customers` WHERE cust_id= $cid";
$r = @mysqli_query ($dbc, $q);
if (mysqli_num_rows($r) == 1) { // Valid user ID, show the form.

	// Get the user's information:
	$row = mysqli_fetch_array ($r, MYSQLI_NUM);
	
	// Create the form:
	echo '<h1>Update My info</h1>
		<form action="edit_user.php?cid='.$cid . '" method="post">
			<fieldset>
			
			<p><label for="fn">First Name:</label><input id="fn" type="text" name="first_name" size="20" maxlength="20" value="'.$row[1].'" /></p>
			
			<p><label for="ln">Last Name:</label><input id="ln" type="text" name="last_name" size="20" maxlength="40" value="'.$row[2].'" /></p>
			
			<p><label for="e">Email Address:</label><input id="e" type="text" name="email" size="30" maxlength="60" value="'.$row[3].'" /></p>

			<p><label for="add1">Address 1:</label> <input id="add1" type="text" name="add1" size="15" maxlength="60" value="'. $row[4] .'" /></p>

			<p><label for="add2">Address 2:</label> <input id="add2" type="text" name="add2" size="15" maxlength="60" value="'. $row[5] .'" /></p>

			<p><label for="city">City:</label> <input id="city" type="text" name="city" size="15" maxlength="20" value="'.$row[6].'" /></p>

			<p><label for="state">State:</label> <input id="state" type="text" name="state" size="15" maxlength="20" value="'.$row[7].'" /></p>

			<p><label for="zip">Zip:</label> <input id="zip" type="text" name="zip" size="15" maxlength="6" value="'.$row[8].'" /></p>

			<p><label for="phone">Phone: ' . $row[9] . '</label>
				<input type="text" id="phone" name="area" maxlength="3" style="width: 22px;">
				<input type="text" name="phone1" maxlength="3" style="width: 22px;">
				<input type="text" name="phone2" maxlength="4" style="width: 30px;"></p>
			
			</fieldset>
			
			<div align="center"><input type="submit" name="submit" value="Update" /></div>
			
		</form>';

} else { // Not a valid user ID.
	echo '<p class="error">This page has been accessed in error.</p>';
}

mysqli_close($dbc);

include ('includes/footer.html'); 
?>