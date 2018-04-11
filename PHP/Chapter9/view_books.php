<?php 
// This script retrieves all the records from the book table.


// Page header:
echo '<h1>Current in-stock Books</h1>';

//include the connection strings
require ('../../mysqli_connect.php');

		
//create query
$q = "select concat(last_name, ', ', first_name) as name, DATE_FORMAT(registration_date, '%M %d, %Y') as dr from users order by registration_date asc";
$r = @mysqli_query ($dbc, $q);

if ($r) { // If it ran OK, display the records.

	// Table header.
	echo '<table align="center" cellspacing="3" cellpadding="3" width="75%">
	<tr><td align="left"><b>Name</b></td><td align="left"><b>Date Registered</b></td></tr>
';
	
	// ToDo - add the loop to display the query results
while ($row = mysqli_fetch_array($r, MYSQLI_ASSOC)) {
	echo '<tr><td align="left">' . $row['name'] . '</td><td align="left">' . $row['dr'] . '</td></tr>';
}


	echo '</table>'; // Close the table.
	
	mysqli_free_result ($r); // Free up the resources.	

} else { // If it did not run OK.

	// Public message:
	echo '<p class="error">The current users could not be retrieved. We apologize for any inconvenience.</p>';
	
	// Debugging message:
	echo '<p>' . mysqli_error($dbc) . '<br /><br />Query: ' . $q . '</p>';
	
} // End of if ($r) IF.

mysqli_close($dbc); // Close the database connection.

include ('includes/footer.html');
?>