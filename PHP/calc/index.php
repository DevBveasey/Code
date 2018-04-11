<?php 

$page_title = 'Calculator';
include ('includes/header.html');

echo '<div class="pwraper">';

echo '<div class="fwraper">';
//display form for user to enter data
echo '<form action="" method="post">
		<label for="bill">Enter Bill</label><br>
		<input id="bill" step=".01" type="number" min="0.00" name="bill" value="00.00" autofocus required><br>
		<label for="adult">Number of adults</label><br>
		<input id="adult" type="number" min="1" step="1"  name="adult" value="1" required><br>
		<label for="tip">Select Tip</label><br>
		<select id="tip" name="tip" required><br>
		  <option value="10">10%</option>
		  <option value="15">15%</option>
		  <option value="20">20%</option>
		  <option selected value="25">25%</option>
		</select><br>
		<input type="submit" name="submit" value="Calculated Total" /><br>
	</form>';

echo '</div>';//end fwraper

echo '<div class="cwraper">';
//check if user submitted data
if ($_SERVER['REQUEST_METHOD'] == 'POST')
{
	switch ($_POST['tip']) // gets correct percent and calculates tip
	{
		case '10':
			$calcTip = $_POST['bill'] * .10;
			break;
		case '15':
			$calcTip = $_POST['bill'] * .15;
			break;
		case '20':
			$calcTip = $_POST['bill'] * .20;
			break;
		case '25':
			$calcTip = $_POST['bill'] * .25;
			break;
	}//end switch
	// calculate total and format it
	$calcTotal = $_POST['bill'] + $calcTip;
	//test if only one person is paying or mutiple 
	if ($_POST['adult'] == '1') 
	{//only one paying display original bill, tip and total
		echo ' 
		<table>
			<tr>
				<td>Your original Bill</td>
			    <td>$' . number_format($_POST['bill'], 2) . '</td>
		  	</tr>
		  	<tr>
				<td>Selected Tip Percent</td>
			    <td>' . $_POST['tip'] . '%</td>
		  	</tr>
		  	<tr>
				<td>Selected Tip Amount</td>
			    <td>$' . number_format($calcTip, 2) . '</td>
		  	</tr>
		  	<tr>
				<td>Total Bill</td>
			    <td>$' . number_format($calcTotal, 2) . '</td>
		  	</tr>

		</table>';
	} else 
	{// more than one paying , displays original bill, tip, total and total split
		$per = $calcTotal / $_POST['adult'];
		echo ' 
		<table>
			<tr>
				<td>Your original Bill</td>
			    <td>$' . number_format($_POST['bill'], 2) . '</td>
		  	</tr>
		  	<tr>
				<td>Selected Tip Percent</td>
			    <td>' . $_POST['tip'] . '%</td>
		  	</tr>
		  	<tr>
				<td>Selected Tip Amount</td>
			    <td>' . $calcTip . '</td>
		  	</tr>
		  	<tr>
				<td>Total Bill</td>
			    <td>$' . number_format($calcTotal, 2) . '</td>
		  	</tr>
		  	<tr>
				<td>Split ' . $_POST['adult'] . ' ways</td>
			    <td>$' . number_format($per, 2) . '</td>
		  	</tr>

		</table>';
	}

	echo '</div>';//end cwraper

	echo '</div>';//end pwraper
}

include ('includes/footer.html');
?>