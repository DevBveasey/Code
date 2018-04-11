<?php 

$page_title = 'Your Work Orders';
include ('includes/header.html');

echo '<h1>Orders to be completed</h1>';

require ('../../connect_work.php'); // Connect to the db.

//number of records to show
$display = 10;

//determine amount of pages
if (isset($_GET['p']) && is_numeric($_GET['p']))
{//Already been determined
	$pages = $_GET['p'];

}else 
{ //Need to determine
	$q ="select count(order_id) from orders";
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
$q = "SELECT `order_id`, `tag`, `start_date`, `location`, `desc`, `fname`, `lname`, `email`, `phone`, `status`, `complete_date`FROM `orders`order by start_date ASC LIMIT $start, $display";

$r = @mysqli_query ($dbc, $q); // Run the query.

// Count the number of returned rows:
$num = mysqli_num_rows($r);

if ($num > 0) 
{ // if it ran OK, display the records

	// Table header.
	echo '<table align="center" cellspacing="2" cellpadding="3" width="100%">
	<tr>
		<td align="left" width="4.6%""><b>Tag #</b></td>
		<td align="left" width="10%"><b>Date Started</b></td>
		<td align="left" width="8%"><b>Location</b></td>
		<td align="left" ><b>Description</b></td>
		<td align="left" width="10%"><b>Tech\'s Name</b></td>
		<td align="left" width="3%"><b>Status</b></td>
		<td align="left" width="3%"><b>Date Completed</b></td>
		<td align="left" width="1%"><b></b></td>
	</tr>';
	
	// Fetch and print all the records:
	$bg = '#eeeeee'; // set initial bg color

	while ($row = mysqli_fetch_array($r, MYSQLI_ASSOC)) {

		$bg =($bg=='#eeeeee' ? '#ffffff' :'#eeeeee'); // switch the bg color

		echo '<tr bgcolor="' . $bg . '">
			<td align="left" ><b>' . $row['tag'] . '</b></td>
			<td align="left" ><b>' . $row['start_date'] . '</b></td>
			<td align="left" ><b>' . $row['location'] . '</b></td>
			<td align="left" ><b>' . $row['desc'] . '</b></td>
			<td align="left" ><b>' . $row['fname'] .' ' . $row['lname'] . '</b></td>
			<td align="left" ><b>' . $row['status'] . '</b></td>
			<td align="left" ><b>' . $row['complete_date'] . '</b></td>
			<td align="left" ><a href="edit_work.php?id=' . $row['order_id'] . '">Edit</a></td>
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