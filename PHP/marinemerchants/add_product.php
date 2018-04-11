<?php 
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: add_product.php
 * - Description: llows the administrator to add an product
*/

// Set the page title and include the HTML header:
require ('includes/config.inc.php');
$page_title = 'Products';
include ('includes/header.html');

//create array for categorys
$categorys = array();

 	// Retrieve all the catagorys and add the check-box.
	$q = "SELECT catagory_id, catagory_name FROM catagorys ORDER BY catagory_id ASC";
	$r = mysqli_query ($dbc, $q);
	if (mysqli_num_rows($r) > 0) 
	{
		while ($cat = mysqli_fetch_array ($r, MYSQLI_NUM))
		{
			$categorys[]= $cat;
		}
	} else 
	{
		echo 'No catagorys found, Please add a catagory!';
	}
	
	

if ($_SERVER['REQUEST_METHOD'] == 'POST') { // Handle the form

	// Validate the incoming data...
	$errors = array();
	
	// check for a product name
	if (!empty($_POST['pname'])) 
	{
		$pn = mysqli_real_escape_string( $dbc, trim($_POST['pname']));
	} else 
	{
		$errors[] = 'Please enter the products\'s name!';
	}
	
	// check for an image:
	if (is_uploaded_file ($_FILES['image']['tmp_name'])) 
	{
	
		// Create a temporary file name:
		$temp = '../../uploadmm/' . md5($_FILES['image']['name']);
		
		// move the file over
		if (move_uploaded_file($_FILES['image']['tmp_name'], $temp)) 
		{
		
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
	
	
	// check for a price
	if (!empty($_POST['price']) && ($_POST['price'] > 0)) {
		$p = (float) $_POST['price'];
	} else {
		$errors[] = 'Please enter the product\'s price!';
	}

	// Check for a on-hand value (not required)
	$oh = (!empty($_POST['onHand'])) ? trim($_POST['onHand']) : '0';

	//create array fro the selected catagorys
	$selected = array();
	
	//get selected catagory
	foreach($categorys as $c) 
	{
    	if (array_key_exists($c[0], $_POST) )//IF CHECKBOX CHECKED
		{
			$selected[] = $c;//ADD TO SELECTED ARRAY
		}
    
	}
	
	// Check for a description (not required)
	$d = (!empty($_POST['description'])) ? mysqli_real_escape_string($dbc, trim($_POST['description'])) : NULL;

	if (empty($errors)) { // everything is ok
				
		// add the product to the database:
		$q = 'INSERT INTO products (product_name, description, on_hand, price, image_name) VALUES (?, ?, ?, ?, ?)';
		$stmt = mysqli_prepare($dbc, $q);
		mysqli_stmt_bind_param($stmt, 'ssids', $pn, $d, $oh, $p, $i);
		mysqli_stmt_execute($stmt);
		$newId = mysqli_insert_id($dbc);
		// Check the results....
		if (mysqli_stmt_affected_rows($stmt) == 1) 
		{
		
			// print a message
			echo '<p>The product has been added.</p>';
			
			// rename the image:
			$id = mysqli_stmt_insert_id($stmt); // Get the product ID.
			rename ($temp, "../../uploadmm/$id");
			
			// Clear $_POST
			$_POST = array();
			
		} else { // Error!
			echo '<p style="font-weight: bold, color: #C00">Your submission could not be processed due to a system error.</p>';
		}
		
		mysqli_stmt_close($stmt);

		foreach ($selected as $s) 
		{
		$q = "INSERT INTO `productincategory`(`item_id`, `category_id`) VALUES ($newId,$s[0])";
		$r = @mysqli_query ($dbc, $q);
		/*if (mysqli_affected_rows($dbc) == 1)  // If it ran OK.
		{
			echo "catagory set";
		}else
		{
			rollback
		}*/
		}
		
	}	// End of $errors IF.
	
	// Delete the uploaded file if it still exists:
	if (isset($temp) && file_exists ($temp) && is_file($temp) ) {
		unlink ($temp);
	}
	
} // End of submission IF.

// Check for an errors and print it:
if ( !empty($errors) && is_array($errors) ) 
{
	echo '<h1>Error!</h1>
	<p style="font-weight: bold; color: #C00">The following error(s) occurred:<br />';
	foreach ($errors as $msg) 
	{
		echo " - $msg<br />\n";
	}
	echo 'Please reselect the print image and try again.</p>';
}

// Display the form...
?>
<h1>Add a Product</h1>
<form enctype="multipart/form-data" action="add_product.php" method="post">

	<input type="hidden" name="MAX_FILE_SIZE" value="524288" />

	<fieldset><legend>Fill out the form to add a Product to the catalog:</legend>
	
	<p><label for="pname">Product Name:</label><input autofocus id="pname" type="text" name="pname" size="30" maxlength="60" value="<?php if (isset($_POST['pname'])) echo htmlspecialchars($_POST['pname']); ?>" /></p>
	
	<p><label for="img">Image:</label><input id="img" type="file" name="image" /></p>

	<p><label for="price"> Price:</label> <input id='price' type="number" name="price" size="10" min="0.01" step=".01" value="<?php if (isset($_POST['price'])) echo $_POST['price']; ?>" /><small> Do not include the dollar sign or commas.</small></p>

	<p><label for="onHand"> Quantity on hand:</label> <input id='onHand' type="number" name="onHand" size="10" min="0" step="1" value="<?php if (isset($_POST['onHand'])) echo $_POST['onHand']; ?>" /></p>
	
	<p><label>Catagory:</label>
	<?php // Retrieve all the catagorys and add the check-box.
	if (count($categorys) > 0) 
	{
		foreach ($categorys as $c) 
		{
			echo '<p><input type="checkbox" name="'.$c[0].'" value="'.$c[1].'"';
			// check for stickyness:
			if (isset($_POST['$c[0]']) )
			{
				echo ' checked=checked"';
			} 
			echo ">$c[1]</p>\n";
		}
		
	} else 
	{
		echo 'No catagorys found, Please add a catagory!';
	}
	mysqli_close($dbc);	// Close the database connection.
	?>
	</p>
	
	<p><label for="desc"> Description:</label></p>
	<p><textarea id="desc" name="description" cols="40" rows="5"><?php if (isset($_POST['description'])) echo $_POST['description']; ?></textarea> (optional)</p>

	</fieldset>
	
	<div align="center"><input type="submit" name="submit" value="Submit" /></div>
	
</form>

<?php include ('includes/footer.html'); ?>
