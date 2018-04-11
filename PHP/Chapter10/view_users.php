<?php # Script 10.1 - view_users.php
// This script retrieves all the records from the users table.
// This new version links to edit and delete pages.

$page_title = 'View the Current Users';
include('includes/header.html');
echo '<h1>Registered Users</h1>';

require ('../../connect_sitename.php'); // Connect to the db.

//number of records to show
$display = 10;

//determine amount of pages
if (isset($_GET['p']) && is_numeric($_GET['p'])){//Already been determined
	$pages = $_GET['p'];

}else { //Need to determine
$q ="select count(user_id) from users";
$r = mysqli_query($dbc, $q);
$row = mysqli_fetch_array ($r, MYSQLI_NUM);
$records = $row[0];
//calc number of pages
if ($records > $display){//more than one page
$pages = ceil($records/$display);
}else{
	$pages = 1;
}
}//end of p if

//determine where the db is to start
if (isset($_GET['s']) && is_numeric($_GET['s'])) {
	$start =$_GET['s'];
}else {
	$start = 0;
}

// Define the query:
$q = "SELECT last_name, first_name, DATE_FORMAT(registration_date, '%M %d, %Y') as dr, user_id  FROM users ORDER BY registration_date ASC LIMIT $start, $display";
$r = @mysqli_query ($dbc, $q); // Run the query.

// Count the number of returned rows:
$num = mysqli_num_rows($r);

if ($num > 0) { // if it ran OK, display the records

	// Print how many users there are:
	echo "<p>There are currently $num registered users.</p>\n";

	// Table header.
	echo '<table align="center" cellspacing="3" cellpadding="3" width="75%">
	<tr>
		<td align="left"><b>Edit</b></td>
		<td align="left"><b>Delete</b></td>
		<td align="left"><b>Last Name</b></td>
		<td align="left"><b>First Name</b></td>
		<td align="left"><b>Date Registered</b></td>
	</tr>';
	
	// Fetch and print all the records:
	$bg = '#eeeeee'; // set initial bg color

	while ($row = mysqli_fetch_array($r, MYSQLI_ASSOC)) {

		$bg =($bg=='#eeeeee' ? '#ffffff' :'#eeeeee'); // switch the bg color

		echo '<tr bgcolor="' . $bg . '">
			<td align="left"><a href="edit_user.php?id=' . $row['user_id'] . '">Edit</a></td>
			<td align="left"><a href="delete_user.php?id=' . $row['user_id'] . '">Delete</a></td>
			<td align="left">' . $row['last_name'] . '</td>
			<td align="left">' . $row['first_name'] . '</td>
			<td align="left">' . $row['dr'] . '</td>
		</tr>';
	}
	
	echo '</table>'; // close the table.
	
	mysqli_free_result ($r); // free up the resources.
	mysqli_close($dbc); // Close the database connection.

	//make links to other pages if nessary
	if($pages > 1){
		//add spacing
		echo '<br /><p>';

		//determine what page the script is

		$current_page =($start/$display) +1;

		//if its not the first page make previus link
		if($current_page != 1){
			echo '<a href="view_users.php?s=' . ($start - $display) . '&p=' . $pages . '">Previous</a> ';
		}

		//make all the numbered pages:
		for($i = 1; $i<= $pages; $i++) {
			if($i != $current_page){
				echo '<a href=view_users.php?s=' . (($display * ($i-1))) . '&p=' . $pages . '">' . $i . '</a> ';
			}else {
				echo $i . '';
			}
		}//end of for

		//if thats not the last page

		if($current_page != $pages){
			echo '<a href="view_users.php?s=' . ($start + $display) . '&p=' . $pages . '">Next</a> ';
		}
		echo '</p>'; //end of p tag

	}//end of links
	
} else { // If no records were returned.

	echo '<p class="error">There are currently no registered users.</p>';
	
}



include ('includes/footer.html');
?>