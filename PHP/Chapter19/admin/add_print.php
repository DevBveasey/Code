<!DOCTYPE html>
<html lang="en">

<head>
	<meta charset="utf-8">
	<title><Add a Print></title>
</head>
<body>
<?php # Script 19.2 - add_print.php
// This page allows the administrator to add an print (product).

require ('../../../mysqli_connect19.php');

if ($_SERVER['REQUEST_METHOD'] == 'POST') { // Handle the form

	// Validate the incoming data...
	$errors = array();
	
	// check for a print name
	if (!empty($_POST['print_name'])) {
		$pn = trim($_POST['print_name']);
	} else {
		$errors[] = 'Please enter the print\'s name!';
	}
	
	// check for an image:
	if (is_uploaded_file ($_FILES['image']['tmp_name'])) {
	
		// Create a temporary file name:
		$temp = '../../../upload19/' . md5($_FILES['image']['name']);
		
		// move the file over
		if (move_uploaded_file($_FILES['image']['tmp_name'], $temp)) {
		
			echo '<p>The file has been uploaded!</p>';
			
			// set the $i variable to the image's name:
			$i = $_FILES['image']['tmp_name'];
			
		} else { // Couldn't move the file over.
			$errors[] = 'The file could not be moved.';
			$temp = $_FILES['image']['tmp_name'];
		}
		
	} else { // No uploaded file.
		$errors[] = 'No file was uploaded.';
		$temp = NULL;
	}
	
	// check for a size (not required):
	$s = (!empty($_POST['size'])) ? trim($_POST['size']) : NULL;
	
	// check for a price
	if (!empty($_POST['price']) && ($_POST['price'] > 0)) {
		$p = (float) $_POST['price'];
	} else {
		$errors[] = 'Please enter the print\'s price!';
	}
	
	// Check for a description (not required)
	$d = (!empty($_POST['description'])) ? trim($_POST['description']) : NULL;
	
	// validate the artist...
	if ( isset($_POST['artist']) && filter_var($_POST['artist'], FILTER_VALIDATE_INT, array('min_range' => 1)) ) {
		$a = $_POST['artist'];
	} else { // No artist selected.
		$errors[] = 'Please select the print\'s artist!';
	}
	
	if (empty($errors)) { // everything is ok
				
		// add the print to the database:
		$q = 'INSERT INTO prints (artist_id, print_name, price, size, description, image_name) VALUES (?, ?, ?, ?, ?, ?)';
		$stmt = mysqli_prepare($dbc, $q);
		mysqli_stmt_bind_param($stmt, 'isdsss', $a, $pn, $p, $s, $d, $i);
		mysqli_stmt_execute($stmt);
		
		// Check the results....
		if (mysqli_stmt_affected_rows($stmt) == 1) {
		
			// print a message
			echo '<p>The print has been added.</p>';
			
			// rename the image:
			$id = mysqli_stmt_insert_id($stmt); // Get the print ID.
			rename ($temp, "../../../upload19/$id");
			
			// Clear $_POST
			$_POST = array();
			
		} else { // Error!
			echo '<p style="font-weight: bold, color: #C00">Your submission could not be processed due to a system error.</p>';
		}
		
		mysqli_stmt_close($stmt);
		
	}	// End of $errors IF.
	
	// Delete the uploaded file if it still exists:
	if (isset($temp) && file_exists ($temp) && is_file($temp) ) {
		unlink ($temp);
	}
	
} // End of submission IF.

// Check for an errors and print it:
if ( !empty($errors) && is_array($errors) ) {
	echo '<h1>Error!</h1>
	<p style="font-weight: bold; color: #C00">The following error(s) occurred:<br />';
	foreach ($errors as $msg) {
		echo " - $msg<br />\n";
	}
	echo 'Please reselect the print image and try again.</p>';
}

// Display the form...
?>
<h1>Add a Print</h1>
<form enctype="multipart/form-data" action="add_print.php" method="post">

	<input type="hidden" name="MAX_FILE_SIZE" value="524288" />

	<fieldset><legend>Fill out the form to add a print to the catalog:</legend>
	
	<p><b>Print Name:</b> <input type="text" name="print_name" size="30" maxlength="60" value="<?php if (isset($_POST['print_name'])) echo htmlspecialchars($_POST['print_name']); ?>" /></p>
	
	<p><b>Image:</b> <input type="file" name="image" /></p>
	
	<p><b>Artist:</b>
	<select name="artist"><option>Select One</option>
	<?php // Retrieve all the artists and add to the pull-down menu.
	$q = "SELECT artist_id, CONCAT_WS(' ',first_name, middle_name, last_name) FROM artists ORDER BY last_name, first_name ASC";
	$r = mysqli_query ($dbc, $q);
	if (mysqli_num_rows($r) > 0) {
		while ($row = mysqli_fetch_array ($r, MYSQLI_NUM)) {
			echo "<option value=\"$row[0]\"";
			// check for stickyness:
			if (isset($_POST['artist']) && ($_POST['artist'] == $row[0]) ) echo ' selected="selected"';
			echo ">$row[1]</option>\n";
		}
	} else {
		echo '<option>Please add a new artist first.</option>';
	}
	mysqli_close($dbc);	// Close the database connection.
	?>
	</select></p>
	
	<p>Price:</b> <input type="text" name="price" size="10" maxlength="10" value="<?php if (isset($_POST['price'])) echo $_POST['price']; ?>" /><small> Do not include the dollar sign or commas.</small></p>
	
	<p><b>Size:</b> <input type="text" name="size" size="30" maxlength="60" value="<?php if (isset($_POST['size'])) echo htmlspecialchars($_POST['size']); ?>" /> (optional)</p>
	
	<p><b>Description:</b> <textarea name="description" cols="40" rows="5"><?php if (isset($_POST['description'])) echo $_POST['description']; ?></textarea> (optional)</p>

	</fieldset>
	
	<div align="center"><input type="submit" name="submit" value="Submit" /></div>
	
</form>

</body>
</html>
