<?php
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: change_password.php
 * - Description: allows a user to change their password
*/

require ('includes/config.inc.php');
$page_title = 'Change Your Password';
include ('includes/header.html');

// If no first_name session variable exists, redirect the user:
if (!isset($_SESSION['cust_id'])) {
	
	$url = BASE_URL . 'index.php'; // define the URL.
	ob_end_clean(); // Delete the buffer.
	header("Location: $url");
	exit();	// Quit the script.
	
} 

if ($_SERVER['REQUEST_METHOD'] == 'POST') { // Handle the form
	
	// Check for a new password and match against the confirmed password:
	$p = FALSE;
	if (preg_match ('/^\w{4,20}$/', $_POST['password1'])) {
		if ($_POST['password1'] == $_POST['password2']){
			$p = mysqli_real_escape_string($dbc, $_POST['password1']);	
		} else {
			echo '<p class="error">Your password did not match the confirmed password</p>';
		}
	} else {
		echo '<p class="error">Please enter a valid password!</p>';
	}
	
	if ($p) { // everything is ok.
	
		// Make the query:
		$q = "UPDATE customers SET password=SHA1('$p') WHERE cust_id={$_SESSION['cust_id']} LIMIT 1";
		$r = @mysqli_query ($dbc, $q);
		if (mysqli_affected_rows($dbc) == 1) { // If it ran OK.
		
			// Send an email:
			$body = "Your New password to log into Marine Merchants has been Successfully changed to '$p'. If you did not make this change contact Marine Merchants using our Awesome help page.";
			mail ($_POST['email'], 'Password update', $body, 'From: admin@MarineMerchants.com');
			echo '<h3>Your password has been changed.</h3>';
			mysqli_close($dbc);
			include ('includes/footer.html');
			exit(); 	// stop the script.
			
		} else { // If it did not run ok.
			echo '<p class="error">Your password was not changed. Make sure your new password is different than the current password. Contact the system administrator if you think an error occurred.</p>';
		
		}
		
	} else { // Failed the validation test.
		echo '<p class="error">Please try again.</p>';
	}
	
	mysqli_close($dbc);
	
} // end of the main submit conditional.
?>

<h1>Change Your Password</h1>
<form action="change_password.php" method="post">
	<fieldset>
	<p><label for="npw" >New Password:</label><input id="npw" autofocus type="password" name="password1" size="20" maxlength="20" /> <small>Use only letters, numbers, and the underscore. Must be between 4 and 20 characters long.</small></p>
	<p><label for="cnpw" >Confirm New Password:</label><input id="npw" type="password" name="password2" size="20" maxlength="20" /></p>
	</fieldset>
	<div align="center"><input type="submit" name="submit" value="Change My Password" /></div>
</form>

<?php include ('includes/footer.html');?>
				
				
	