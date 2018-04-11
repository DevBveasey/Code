<?php # Script 10.1 - view_users.php
// This script retrieves all the records from the users table.
// This new version links to edit and delete pages.

$page_title = 'View the Current Users';
include('includes/header.html');
echo '<h1>Registered Users</h1>';

require ('../../connect_sitename.php'); // Connect to the db.

// Define the query:
$q = "SELECT CONCAT(last_name, ', ', first_name) as name, DATE_FORMAT(registration_date, '%M %d, %Y') as dr FROM users ORDER BY registration_date ASC";
$r = @mysqli_query ($dbc, $q); // Run the query.

// Count the number of returned rows:
$num = mysqli_num_rows($r);

if ($num > 0) { // if it ran OK, display the records

	// Print how many users there are:
	echo "<p>There are currently $num registered users.</p>\n";

	// Table header.
	echo '<table align="center" cellspacing="3" cellpadding="3" width="75%">
	<tr><td align="left"><b>Name</b></td>
	<td align="left"><b>Date Registered</b></td></tr>';
	
	// Fetch and print all the records:
	while ($row = mysqli_fetch_array($r, MYSQLI_ASSOC)) {
		echo '<tr><td align="left">' . $row['name'] . '</td><td align="left">' . $row['dr'] . '</td></tr>';
	}
	
	echo '</table>'; // close the table.
	
	mysqli_free_result ($r); // free up the resources.
	
} else { // If no records were returned.

	echo '<p class="error">There are currently no registered users.</p>';
	
}

mysqli_close($dbc); // Close the database connection.

include ('includes/footer.html');
?>