<?php 
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: forgot_password.php
 * - Description: allows a user to reset their password
*/

require ('includes/config.inc.php');
$page_title = 'Forgot Your Password';
include ('includes/header.html');

if ($_SERVER['REQUEST_METHOD'] == 'POST') { // Handle the form
	
	// Assume nothing.
	$uid = FALSE;
	
	// Validate the email address:
	if (!empty($_POST['email'])) {
	
		// Check for the existence of that email address ...
		$q = 'SELECT cust_id FROM customers WHERE email="'. mysqli_real_escape_string ($dbc, $_POST['email']) . '"';
		echo $q;
		$r = @mysqli_query ($dbc, $q);
		
		if (mysqli_num_rows($r) == 1) { // Retrieve the customer ID:
			list($cid) = mysqli_fetch_array($r, MYSQLI_NUM);
		} else { // No database match made.
			echo '<p class="error">The submitted email address does not match those on file!</p>';
		}
		
	} else { // No email!
		echo '<p class="error">You forgot to enter your email address!</p>';
	} // End of empty($_POST['email']) IF.
		
	if ($cid) { // if everything is ok.
	
		// create a new, random password:
		$p = substr( md5(uniqid(rand(), true)), 3, 10);
		
		// update the database:
		$q = "UPDATE customers SET password=SHA1('$p') WHERE cust_id=$cid LIMIT 1";
		$r = @mysqli_query ($dbc, $q) or trigger_error("Query: $q\n<br />MySQL Error: " . mysqli_error($dbc));	
		
		if (mysqli_affected_rows($dbc) == 1) { // If it ran OK.
		
			// Send an email:
			$body = "Your New password to log into Marine Merchants has been temporarily changed to '$p'. Please log in using this password and this email address. Then you may change your password to something more familiar.";
			mail ($_POST['email'], 'Your temporary password.', $body, 'From: admin@MarineMerchants.com');
			
			// Print a message and wrap up:
			echo '<h3>Your password has been changed. You will receive the new, temporary password at the email address with which you registered. Once you have logged in with this password, you may change it by clicking on the "Change Password" link under the account tab.</h3>';
			mysqli_close($dbc);
			include ('includes/footer.html');
			exit(); 	// stop the script.
			
		} else { // If it did not run ok.
			echo '<p class="error">Your password could not be changed due to a system error. We apologize for any inconvenience.</p>';
		}
		
	} else { // Failed the validation test.
		echo '<p class="error">Please try again.</p>';
	}
	
	mysqli_close($dbc);
	
} // end of the main submit conditional.
?>

<h1>Reset Your Password</h1>
<p>Enter your email address below and your password will be reset.</p>
<form action="forgot_password.php" method="post">
	<fieldset>

		<p><label for="e">Email Address:</label><input id="e" type="text" name="email" size="30" maxlength="60" value="<?php if (isset($_POST['email'])) echo $_POST['email']; ?>" /></p>
	</fieldset>
	<div align="center"><input type="submit" name="submit" value="Reset My Password" /></div>
</form>

<?php include ('includes/footer.html');?>
				
				
	