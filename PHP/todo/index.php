<?php 

$page_title = 'Your Tasks';
include ('includes/header.html');

echo '<h1>Tasks to be completed</h1>';

require ('../../connect_task.php'); // Connect to the db.

//number of records to show
$display = 10;

//determine amount of pages
if (isset($_GET['p']) && is_numeric($_GET['p']))
{//Already been determined
	$pages = $_GET['p'];

}else 
{ //Need to determine
	$q ="select count(task_id) from todo";
	$r = mysqli_query($dbc, $q);
	$row = mysqli_fetch_array ($r, MYSQLI_NUM);
	$records = $row[0];
	//calc number of pages
	if ($records > $display)
	{//more than one page
		$pages = ceil($records/$display);
	}else
	{
		$pages = 1;
	}
}//end of p if

//determine where the db is to start
if (isset($_GET['s']) && is_numeric($_GET['s'])) {
	$start =$_GET['s'];
}else 
{
	$start = 0;
}

// Define the query:
$q = "SELECT description, DATE_FORMAT(date_added, '%M %d, %Y') as da, DATE_FORMAT(date_completed, '%M %d, %Y') as dc, task_id  FROM todo ORDER BY priority ASC LIMIT $start, $display";

$r = @mysqli_query ($dbc, $q); // Run the query.

// Count the number of returned rows:
$num = mysqli_num_rows($r);

if ($num > 0) { // if it ran OK, display the records

	// Table header.
	echo '<table align="center" cellspacing="3" cellpadding="3" width="75%">
	<tr>
		<td align="left"><b>Task</b></td>
		<td align="left"><b>Date Added</b></td>
		<td align="left"><b>Date Completed</b></td>
		<td align="left"><b>Mark Completed</b></td>
	</tr>';
	
	// Fetch and print all the records:
	$bg = '#eeeeee'; // set initial bg color

	while ($row = mysqli_fetch_array($r, MYSQLI_ASSOC)) {

		$bg =($bg=='#eeeeee' ? '#ffffff' :'#eeeeee'); // switch the bg color

		echo '<tr bgcolor="' . $bg . '">
			<td align="left">' . $row['description'] . '</td>
			<td align="left">' . $row['da'] . '</td>
			<td align="left">' . $row['dc'] . '</td>
			<td align="left"><a href="edit_task.php?id=' . $row['task_id'] . '">Completed</a></td>
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
			echo '<a href="index.php?s=' . ($start - $display) . '&p=' . $pages . '">Previous</a> ';
		}

		//make all the numbered pages:
		for($i = 1; $i<= $pages; $i++) {
			if($i != $current_page){
				echo '<a href=index.php?s=' . (($display * ($i-1))) . '&p=' . $pages . '">' . $i . '</a> ';
			}else {
				echo $i . '';
			}
		}//end of for

		//if thats not the last page

		if($current_page != $pages){
			echo '<a href="index.php?s=' . ($start + $display) . '&p=' . $pages . '">Next</a> ';
		}
		echo '</p>'; //end of p tag

	}//end of links
	
} else { // If no records were returned.

	echo '<p class="error">There is currently no task assigned.</p>';
	
}




include ('includes/footer.html');
?>