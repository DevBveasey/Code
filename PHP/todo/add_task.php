<?php 
// This script performs an INSERT query to add a record to the todo table.

$page_title = 'Add Task';
include ('includes/header.html');

// Check for form submission:
if ($_SERVER['REQUEST_METHOD'] == 'POST') {

	require ('../../connect_task.php'); // Connect to the db.

	$errors = array(); // initialize an error array.
	
	// Check for a first name:
	if (empty($_POST['desc'])) 
	{
		$errors[] = 'You forgot to enter the Task description.';
	} else 
	{
		$desc = mysqli_real_escape_string($dbc, trim($_POST['desc']));
	}

	if (empty($_POST['priority'])) 
	{
		$errors[] = 'You did not set task priority.';
	} else //set enum value
	{
		switch ($_POST['priority']) 
		{
			case 'low':
				$priority = 'Low';
				break;

			case 'medium':
				$priority = 'Medium';
				break;

			case 'high':
				$priority = 'High';
				break;
		}//end of switch
		
	}

	if (empty($errors)) { // If everything's OK.
		
		// add task in the database...
		
		// Make the query:
		$q = "INSERT INTO todo (description, priority, date_added) VALUES ('$desc','$priority' , NOW() )";
		$r = @mysqli_query ($dbc, $q); // Run the query.
		if ($r) { // If it ran OK.
			
			// Print a message:
			echo '<h1>Thank you!</h1>
			<p>You have added another task to complete.</p><p><br /></p>';
			
		} else { // If it did not run OK.
			
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
<h1>Add Task</h1>
<form action="add_task.php" method="post">
	<p><label for="desc">Task description</label></p>
	<p><textarea id="desc" name="desc" rows="10" cols="3" style="margin: 0px; height: 25px; width: 234px;"></textarea></p>
	<p><label>Task Priority</label></p>
	<p><select  required name="priority">
    <option  selected value="low">Low</option>
    <option value="medium">Medium</option>
    <option value="high">High</option>
</select></p>

	<p><input type="submit" name="submit" value="ADD Task" /></p>
</form>
<?php include ('includes/footer.html'); ?>