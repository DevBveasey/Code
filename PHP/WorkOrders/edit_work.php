<?php # Script 10.3 - edit_user.php
// This page is for editing a user record.
// This page is accessed through view_users.php.

$page_title = 'Edit a Order';
include ('includes/header.html');
echo '<h1>Edit a Order</h1>';

// Check for a valid user ID, through GET or POST:
if ((isset($_GET['id'])) && (is_numeric($_GET['id'])) ) { // From view_users.php
	$id = $_GET['id'];
} elseif ((isset($_POST['id'])) && (is_numeric($_POST['id'])) ) { // Form submission
	$id = $_POST['id'];
} else { // No valid ID, kill the script.
	echo '<p class="error">This page has been accessed in error.</p>';
	include ('includes/footer.html');
	exit();
}

require_once ('../../connect_work.php'); // Connect to the db.

// Check if the form has been submitted:
if ($_SERVER['REQUEST_METHOD'] == 'POST') 
{

	$errors = array(); // initialize an error array.

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

	//check if a note was made:
	if (empty($_POST['note'])) 
	{
		$errors[] = 'You forgot to enter service notes.';
	} else 
	{
		$notes = mysqli_real_escape_string($dbc, trim($_POST['note']));
	}

	if (empty($_POST['status'])) 
	{
		$errors[] = 'You did not set task priority.';
	} else //set enum value
	{
		switch ($_POST['status']) 
		{
			case 'started':
				$status = 'started';
				break;

			case 'hold':
				$status = 'hold';
				break;

			case 'complete':
				$status = 'complete';
				break;
		}//end of switch
	}//end of else

	/* ---------- end validation of form ---------- */

	if (empty($errors)) 
	{ // If everything's OK.
		
		if ($status == 'complete') 
		{
			// Make the query:
			$q = "UPDATE orders set status ='$status', complete_date= now() ,notes='$notes' WHERE order_id = '8' limit 1;";
			echo "test1";

			$r = mysqli_query ($dbc, $q); // Run the query.
			if ($r) 
			{ // If it ran OK.
				
				// Print a message:
				echo '<h1>Thank you!</h1>
				<p>Your changes have been made</p><p><br /></p>';
				
			} else 
			{ // If it did not run OK.
				
				// Public message:
				echo '<h1>System Error</h>
				<p class="error">The change was not made due to a system error!</p>';
				
				// Debugging message:
				echo '<p>' . mysqli_error($dbc) . '<br /><br />Query: ' . $q . '</p>';
				
			} // End of if ($r) IF.
			
			mysqli_close($dbc); // Close the database connection.
			
			// Include the footer and quit the script:
			include ('includes/footer.html');
			exit();
		
		} else // order is not complete
		{
			// Make the query:
			$q = "UPDATE orders set status ='$status', complete_date= NULL ,notes='$notes' WHERE order_id = '$id' limit 1;";
			echo "test2";

			$r = mysqli_query ($dbc, $q); // Run the query.
			if ($r) 
			{ // If it ran OK.
				
				// Print a message:
				echo '<h1>Thank you!</h1>
				<p>Your changes have been made</p><p><br /></p>';
				
			} else 
			{ // If it did not run OK.
				
				// Public message:
				echo '<h1>System Error</h>
				<p class="error">The change was not made due to a system error!</p>';
				
				// Debugging message:
				echo '<p>' . mysqli_error($dbc) . '<br /><br />Query: ' . $q . '</p>';
				
			} // End of if ($r) IF.
			
			mysqli_close($dbc); // Close the database connection.
			
			// Include the footer and quit the script:
			include ('includes/footer.html');
			exit();
		
		
			mysqli_close($dbc); // Close the database connection.
		}
	}else //else $errors not empty
	{ // Report the errors.
		
		echo '<h1>Error!</h1>
		<p class="error">The following error(s) occurred:<br />';
		foreach ($errors as $msg) 
		{ // Print each error.
			echo " - $msg<br />\n";
		}
		echo '</p><p>Please try again.</p><p><br /></p>';
				
	} // End of if (empty($errors)) IF.
		
		
		
		
} // End of submit conditional.

// Always show the form...	
		
// Retrieve the user's information:
$q = "SELECT `order_id`, `tag`, `start_date`, `location`, `desc`, `fname`, `lname`, `email`, `phone`, `status`, `complete_date` FROM orders WHERE order_id=$id";
$r = mysqli_query ($dbc, $q);

if (mysqli_num_rows($r) == 1) { // Valid user ID, show the form.

	// Get the user's information:
	$row = mysqli_fetch_array ($r, MYSQLI_NUM);
	
	// Create the form:
	echo '<form action="edit_work.php" method="post">
		<p><label for="fname">First Name</label> 
		<input  required type="text" id="fname" name="fname"> 
		<label for="lname">Last Name</label> 
		<input required type="text" id="lname" name="lname"> </p>
		<p><label for="note">Order Notes</label></p>
		<p><textarea id="note" name="note" rows="10" cols="3" width="100%"></textarea></p>
		<p><label>Order Status</label></p>
		<p><select  required name="status">
		    <option value="started">Started</option>
		    <option value="hold">On-Hold</option>
		    <option value="complete">Completed</option>
		</select></p> 
		<p><input type="submit" name="submit" value="Submit" /></p>
		<input type="hidden" name="id" value="' . $id . '" />
		</form>';

} else { // Not a valid user ID.
	echo '<p class="error">This page has been accessed in error.</p>';
}

mysqli_close($dbc);

include ('includes/footer.html'); 
?>