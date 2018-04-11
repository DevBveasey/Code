<?php 
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: register.php
 * - Description: registration page for the site
*/
require ('includes/config.inc.php');
$page_title = 'Register';
include ('includes/header.html');

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

	// Check for a password and match againt the confirmed password:
	if (preg_match ('/^\w{4,20}$/', $trimmed['password1'])) {
		if ($trimmed['password1'] == $trimmed['password2']){
			$p = mysqli_real_escape_string($dbc, $trimmed['password1']);	
		} else {
			echo '<p class="error">Your password did not match the confirmed password</p>';
		}
	} else {
		echo '<p class="error">Please enter a valid password!</p>';
	}

	if ($fn && $ln && $e && $p && $add1 && $add2 && $city && $state && $zip && $phone) 
	{ // If everything's OK.
		
		// Make sure the email address is available:
		$q = "SELECT cust_id FROM customers WHERE email='$e'";
		$r = @mysqli_query ($dbc, $q) or trigger_error("Query: $q\n<br />MySQL Error: " . mysqli_error($dbc));
		
		if (mysqli_num_rows($r) == 0) { // Available
		
			// Create the activation code:
			$a = md5(uniqid(rand(), true));
				
			// Add the user to the database:
			$q = "INSERT INTO customers (first_name, last_name, email, password, address1, address2, city, state, zip, phone, reg_date, activation) VALUES ('$fn', '$ln', '$e', SHA1('$p'),
				'$add1', '$add2', '$city','$state','$zip','$phone', NOW(), '$a')";
			$r = @mysqli_query ($dbc, $q) or trigger_error("Query: $q\n<br />MySQL Error: " . mysqli_error($dbc));
			
			if (mysqli_affected_rows($dbc) == 1) { // If it ran OK.
				
				// Send the email:
				$body = "Thank you for registering at Marine Merchants. To activate your account, please click on this link:\n\n";
				$body .= BASE_URL . 'activate.php?x=' . urlencode($e) . "&y=$a";
				mail($trimmed['email'], 'Registration Confirmation', $body, 'From: admin@Marinemerchants.com');
				
				// Finish the page:
				echo '<h3>Thank you for registering! A confirmation email has been sent to your address. Please click the link in that email or Paste it in your URL in order to activate your account.</h3>';
				include ('includes/footer.html'); // Include the HTML footer.
				exit(); // Stop the page.
								
			} else { // If it did not run OK.
				echo '<p class="error">You could not be registered due to a system error. We apologize for any inconvenience.</p>';
			}
			
		} else { // The email address is not available.
			echo '<p class="error">That email address has already been registered. If you have forgotten your password, use the link found on the login page to have your  reset and sent to you!</p>';
		}
		
	} else { // If one of the data tests failed.
		echo '<p class="error">Please try again.</p>';
	}
		
	mysqli_close($dbc); // Close the database connection.
	
} // End of the main Submit conditional.
?>
		
<h1>Register</h1>
<h3>Fields marked with <span style="color: red">*</span> are required</h3>
<form action="register.php" method="post">
	<fieldset>
	
	<p><label for="fn">First Name<span style="color: red">*</span>:</label><input autofocus id="fn" type="text" name="first_name" size="20" maxlength="20" value="<?php if (isset($trimmed['first_name'])) echo $trimmed['first_name']; ?>" /></p>
	
	<p><label for="ln">Last Name<span style="color: red">*</span>:</label><input id="ln" type="text" name="last_name" size="20" maxlength="40" value="<?php if (isset($trimmed['last_name'])) echo $trimmed['last_name']; ?>" /></p>
	
	<p><label for="e">Email Address<span style="color: red">*</span>:</label><input id="e" type="text" name="email" size="30" maxlength="60" value="<?php if (isset($trimmed['email'])) echo $trimmed['email']; ?>" /></p>

	<p><label for="add1">Address 1:</label> <input id="add1" type="text" name="add1" size="15" maxlength="60" value="<?php if (isset($trimmed['add1'])) echo $trimmed['add1']; ?>" /></p>

	<p><label for="add2">Address 2:</label> <input id="add2" type="text" name="add2" size="15" maxlength="60" value="<?php if (isset($trimmed['add2'])) echo $trimmed['add2']; ?>" /></p>

	<p><label for="city">City:</label> <input id="city" type="text" name="city" size="15" maxlength="20" value="<?php if (isset($trimmed['city'])) echo $trimmed['city']; ?>" /></p>

	<p><label for="state">State:</label> <input id="state" type="text" name="state" size="15" maxlength="20" value="<?php if (isset($trimmed['state'])) echo $trimmed['state']; ?>" /></p>

	<p><label for="zip">Zip:</label> <input id="zip" type="text" name="zip" size="15" maxlength="6" value="<?php if (isset($trimmed['zip'])) echo $trimmed['zip']; ?>" /></p>

	<label for="phone">Phone</label> 
		<input type="text" id="phone" name="area" maxlength="3" style="width: 22px;"  value="<?php if (isset($trimmed['area'])) echo $trimmed['area']; ?>">
		<input type="text" name="phone1" maxlength="3" style="width: 22px;" value="<?php if (isset($trimmed['phone1'])) echo $trimmed['phone1']; ?>">
		<input type="text" name="phone2" maxlength="4" style="width: 30px;" value="<?php if (isset($trimmed['phone2'])) echo $trimmed['phone2']; ?>"> </p>
	
	<p><label for="p1">Password<span style="color: red">*</span>:</label><input id="p1" type="password" name="password1" size="20" maxlength="20" value="<?php if (isset($trimmed['password1'])) echo $trimmed['password1']; ?>" /> <small>Use only letters, numbers, and the underscore. Must be between 4 and 20 characters long.</small></p>
	
	<p><label for="p2">Confirm Password<span style="color: red">*</span>:</label><input id="p2" type="password" name="password2" size="20" maxlength="20" value="<?php if (isset($trimmed['password2'])) echo $trimmed['password2']; ?>" /></p>
	</fieldset>
	
	<div align="center"><input type="submit" name="submit" value="Register" /></div>
	
</form>

<?php include ('includes/footer.html'); ?>