<?php 
// This page is for editing a task record.
// This page is accessed through index.php.


// Check for a valid task ID, through GET or POST:
if ((isset($_GET['id'])) && (is_numeric($_GET['id'])) ) { // From index.php
	$id = $_GET['id'];
} elseif ((isset($_POST['id'])) && (is_numeric($_POST['id'])) ) { // Form submission
	$id = $_POST['id'];
} else { // No valid ID, kill the script.
	echo '<p class="error">This page has been accessed in error.</p>';
	exit();
}
echo $id;

// update completion date
$q = "UPDATE todo SET date_completed = NOW() WHERE task_id=$id";
$r = @mysqli_query ($dbc, $q);
echo 'updated'. mysql_affected_rows();

include ('index.php');
?>