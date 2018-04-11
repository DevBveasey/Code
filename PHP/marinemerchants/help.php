
<?php 
/*
Marine Merchants
AUTHOR:Brandon Veasey
PROJECT: Final
DATE: 11/15/2017
SCRIPT:email.php
Description: the Help page allows user to email the store for help/questions
*/
$page_title = 'HELP';
include ('includes/header.html');

// Check for form submission:
if ($_SERVER['REQUEST_METHOD'] == 'POST') 
{
	/* The function takes one argument: a string.
	* The function returns a clean version of the string.
	* The clean version may be either an empty string or
	* just the removal of all newline characters.
	*/
	function spam_scrubber($value) {

		// List of very bad values:
		$very_bad = array('to:', 'cc:', 'bcc:', 'content-type:', 'mime-version:', 'multipart-mixed:', 'content-transfer-encoding:');
	
		// If any of the very bad strings are in 
		// the submitted value, return an empty string:
		foreach ($very_bad as $v) {
			if (stripos($value, $v) !== false) return '';
		}
	
		// Replace any newline characters with spaces:
		$value = str_replace(array( "\r", "\n", "%0a", "%0d"), ' ', $value);
	
		// Return the value:
		return trim($value);

	} // End of spam_scrubber() function.

	// Clean the form data:
	$scrubbed = array_map('spam_scrubber', $_POST);

	// Check for a first name:
	if (empty($scrubbed['fname'])) 
	{
		$errors[] = 'You forgot to enter your first name.';
	} else {
		$fn = trim($scrubbed['fname']);
	}
	
	// Check for a last name:
	if (empty($scrubbed['lname'])) 
	{
		$errors[] = 'You forgot to enter your last name.';
	} else 
	{
		$ln = trim($scrubbed['lname']);
		$name = $fn . ' ' . $ln;
	}

	// Check for an email address:
	if (empty($scrubbed['email'])) 
	{
		$errors[] = 'You forgot to enter your email address.';
	} else {
		$e = trim($scrubbed['email']);
	}

	if (empty($scrubbed['msg'])) 
	{
		$errors[] = 'You forgot to enter you comments.';
	} else {
		$msg = trim($scrubbed['msg']);
	}


	/* ---------- end validation of form ---------- */

	if (empty($errors)) 
	{ // If everything's OK.
		// Create the body:
		$body = "Name: {$name}\n\nComments: {$msg}";
		
		// make it no longer than 70 characters long:
		$body = wordwrap($body, 70);
		
		// Send the mail:)
		mail('your_email@example.com', 'Contact Form Submission', $body, "From: {$e}");
		
		// Print a message:
		echo '<p><em>Thank you for contacting me. I will reply some day.</em></p>';
			
		// Clear $_POST (so that the form's not sticky):
		$_POST = array();
	}else
	{
		echo '<p class="error">The following error(s) occurred:</p>';
		foreach ($errors as $msg) 
		{ // Print each error.
			echo "<p class=\"error\"> - $msg</p>";
		}
		echo '<p class="error">Please try again.</p><p><br /></p>';
	}
		
} // end of main  IF post.

// Create the HTML form:
?>
<form action="help.php" method="post">
	<fieldset>
		<legend>Please fill out this form to contact <strong>Marine Merchants</strong>.</legend>
	<p><label for="fname">First Name:</label> <input autofocus id="fname" type="text" name="fname" size="30" maxlength="60" value="<?php if (isset($_POST['fname'])) echo $_POST['fname']; ?>" /></p>

	<p><label for="lname">Last Name:</label> <input id="lname"  type="text" name="lname" size="30" maxlength="60" value="<?php if (isset($_POST['lname'])) echo $_POST['lname']; ?>" /></p>

	<p><label for="email">Email Address:</label> <input id="email"  type="email" name="email" size="30" maxlength="80" value="<?php if (isset($_POST['email'])) echo $_POST['email']; ?>" /></p>

	<p><label for="msg">Comments:</label> <textarea id="msg"  name="msg" rows="5" cols="30"><?php if (isset($_POST['msg'])) echo $_POST['msg']; ?></textarea></p>

	<p><input type="submit" name="submit" value="Send!" /></p>
	</fieldset>
</form>
<?php include ('includes/footer.html'); ?>

