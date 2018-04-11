<?php
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT:login.php
 * - Description: login page for the site
*/
require ('includes/config.inc.php');
$page_title = 'Login';
include ('includes/header.html');

if ($_SERVER['REQUEST_METHOD'] == 'POST') { // Handle the form
		
	// Validate the email address:
	if (!empty($_POST['email'])) {
		$e = mysqli_real_escape_string($dbc, $_POST['email']);
	} else {
		$e = FALSE;
		echo '<p class="error">You forgot to enter your email address!</p>';
	}
	
	// Validate the password:
	if (!empty($_POST['pass'])) {
		$p = mysqli_real_escape_string($dbc, $_POST['pass']);
	} else {
		$p = FALSE;
		echo '<p class="error">You forgot to enter your password!</p>';
	}
	
	if ($e && $p) { // If everything is ok.
	
		// Query the database:
		$q = "SELECT cust_id, first_name, email FROM customers WHERE (email='$e' AND password=SHA1('$p')) AND activation IS NULL";
		$r = mysqli_query ($dbc, $q) or trigger_error("Query: $q\n<br />MySQL Error: " . mysqli_error($dbc));
		
		if (@mysqli_num_rows($r) == 1) { // A match was made.
		
			// Register the values:
			$_SESSION = mysqli_fetch_array($r, MYSQLI_ASSOC);
			mysqli_free_result($r);
			mysqli_close($dbc);
			
			// Redirect the user:
			$url = BASE_URL . 'index.php';	// Define the url
			ob_end_clean(); // Delete the buffer.
			header("Location: $url");
			exit();	// Quit the script.
			
		} else { // No match was made.
			echo '<p class="error">Either the email address and password entered do not match those on file or you have not yet activated your account.</p>';
		}
		
	} else { // If everything wasn't OK.
		echo '<p class="error">Please try again.</p>';
	}
		
	mysqli_close($dbc);

} // End of SUBMIT conditional.
?>
<!-- login form HTML -->
<div id="login_form">
<h1>Login</h1>
<form action="login.php" method="post">
	<p><label for="email">Email Address:</label><input autofocus id="email" type="text" name="email" size="20" maxlength="60" /></p>
	<p><label for="pass">Password:</label><input id="pass" type="password" name="pass" size="20" maxlength="20" /></p>
	<div align="center"><input type="submit" name="submit" value="Login" /></div>
</form>
<a href="register.php">Register Now!</a>
<a class="floatr" href="forgot_password.php">Forgot Password</a>
</div>

<?php include ('includes/footer.html');?>
		