<?php 
// This script performs an INSERT query to add a record to the todo table.

$page_title = 'Add Task';
include ('includes/header.html');

// Check for form submission:
if ($_SERVER['REQUEST_METHOD'] == 'POST') 
{

	require ('../../connect_work.php'); // Connect to the db.

	$errors = array(); // initialize an error array.

	/* ---------- begine validation of form ---------- */

	// Check for a tag:
	if (empty($_POST['tag'])) 
	{
		$errors[] = 'You forgot to enter asset tag.';
	} else {
		$tag = mysqli_real_escape_string($dbc, trim($_POST['tag']));
	}

	// Check for a location:
	if (empty($_POST['location'])) 
	{
		$errors[] = 'You forgot to enter a asset location.';
	} else {
		$location = mysqli_real_escape_string($dbc, trim($_POST['location']));
	}

	// Check for a first name:
	if (empty($_POST['fname'])) 
	{
		$errors[] = 'You forgot to enter your first name.';
	} else {
		$fn = mysqli_real_escape_string($dbc, trim($_POST['fname']));
	}
	
	// Check for a last name:
	if (empty($_POST['lname'])) 
	{
		$errors[] = 'You forgot to enter your last name.';
	} else 
	{
		$ln = mysqli_real_escape_string($dbc, trim($_POST['lname']));
	}

	// Check for an phone:
	if (empty($_POST['area']) or empty($_POST['phone1']) or empty($_POST['phone2']) 
		or !is_numeric($_POST['area']) or !is_numeric($_POST['phone1']) or !is_numeric($_POST['phone2'])) 
	{
		$errors[] = 'You forgot to enter your Phone number.';
	}else 
	{
		$tel= '('. $_POST['area'] . ') ' . $_POST['phone1'] . '-' . $_POST['phone1'];
		$phone = mysqli_real_escape_string($dbc, trim($tel));
	}

	// Check for an email address:
	if (empty($_POST['email'])) 
	{
		$errors[] = 'You forgot to enter your email address.';
	} else {
		$e = mysqli_real_escape_string($dbc, trim($_POST['email']));
	}

	if (empty($_POST['desc'])) 
	{
		$errors[] = 'You forgot to enter the Task description.';
	} else 
	{
		$desc = mysqli_real_escape_string($dbc, trim($_POST['desc']));
	}

	
	/* ---------- end validation of form ---------- */

	if (empty($errors)) 
	{ // If everything's OK.
		
		// add task in the database...
		
		// Make the query:
		$q = "INSERT INTO `work`.`orders` (`order_id`, `tag`, `location`, `desc`, `fname`, `lname`, `email`, `phone`, `status`, `complete_date`, `notes`, `start_date`) VALUES (NULL, '$tag', '$location', '$desc', '$fn', '$ln', '$e', '$phone', 'started', NULL, NULL, now());";

		$r = @mysqli_query ($dbc, $q); // Run the query.
		if ($r) { // If it ran OK.
			
			// Print a message:
			echo '<h1>Thank you!</h1>
			<p>You have added another order to complete.</p><p><br /></p>';
			
		} else 
		{ // If it did not run OK.
			
			// Public message:
			echo '<h1>System Error</h>
			<p class="error">The task was not added due to a system error!</p>';
			
			// Debugging message:
			echo '<p>' . mysqli_error($dbc) . '<br /><br />Query: ' . $q . '</p>';
			
		} // End of if ($r) IF.
		
		mysqli_close($dbc); // Close the database connection.
		
		// Include the footer and quit the script:
		include ('includes/footer.html');
		exit();
	
	} else 
	{ // Report the errors.
	
		echo '<h1>Error!</h1>
		<p class="error">The following error(s) occurred:<br />';
		foreach ($errors as $msg) 
		{ // Print each error.
			echo " - $msg<br />\n";
		}
		echo '</p><p>Please try again.</p><p><br /></p>';
		
	} // End of if (empty($errors)) IF.
	
	mysqli_close($dbc); // Close the database connection.
	
} // End of the main Submit conditional.
?>
<h1>Add Work Order</h1>
<form action="add_work.php" method="post">
	<p><label for="tag">Asset Tag</label> 
		<input autofocus required type="text" id="tag" name="tag" maxlength="10">
		<label for="location">Location</label> 
		<input required type="text" id="location" name="location"> </p>
	<p><label for="fname">First Name</label> 
		<input  required type="text" id="fname" name="fname"> 
	<label for="lname">Last Name</label> 
		<input required type="text" id="lname" name="lname"> </p>
	<p><label for="email">Email</label> 
		<input required type="email" id="email" name="email"> 
	<label for="phone">Phone</label> 
		<input required type="text" id="phone" name="area" maxlength="3" style="width: 22px;">
		<input required type="text" name="phone1" maxlength="3" style="width: 22px;">
		<input required type="text" name="phone2" maxlength="4" style="width: 30px;"> </p>
	<p><label for="desc">Order Description</label></p>
	<p><textarea id="desc" name="desc" rows="10" cols="3" style="margin: 0px; height: 25px; width: 234px;"></textarea></p>

	<p><input type="submit" name="submit" value="ADD Work Order" /></p>
</form>
<?php include ('includes/footer.html'); ?>