<?php # Script 15.9 - login_ajax.php
// This script is called via Ajax from login.php
// The script expects to receive two values in the URL: an email address and a password.
// The script returns a string indicating the results.

// need two pieces of information:
if (isset($_GET['email'], $_GET['password'])) {
	
	// need a valid email address:
	if (filter_var($_GET['email'], FILTER_VALIDATE_EMAIL)) {
		
		// must match specific values:
		if ( ($_GET['email'] == 'email@me.com') && ($_GET['password'] == 'test') ) {
		
			// Set a cookie, if you want, or start a session.
			
			// Indicate success:
			echo 'CORRECT';
			
		} else {
			echo 'INCORRECT';
		}
	
	} else { // invalid email address!
		echo 'INVALID_EMAIL';
	}
	
} else { // missing one of the two variables!
	echo 'INCOMPLETE';
}

?>