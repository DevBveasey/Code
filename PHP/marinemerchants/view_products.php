<?php
/*
 * - Marine Merchants
 * - AUTHOR:Brandon Veasey
 * - PROJECT: Final
 * - DATE: 11/15/2017
 * - SCRIPT: view_products.php
 * - Description: displays the available products
*/

// Set the page title and include the HTML header:
require ('includes/config.inc.php');
$page_title = 'Shop all Products';
include ('includes/header.html');

//number of records to show
$display = 5;

//determine amount of pages
if (isset($_GET['p']) && is_numeric($_GET['p'])){//Already been determined
	$pages = $_GET['p'];

}else 
{ //Need to determine
//defult query
$q ="select count(item_id) from products";
// are we looking at a particular catagory?
if (isset($_GET['cid']) && filter_var($_GET['cid'], FILTER_VALIDATE_INT, array('min_range' => 1 )) ) 
{
	$cid =$_GET['cid'];
	// Overwrite the query:
	$q = "SELECT count(p.item_id), category_id
		FROM products p
		LEFT JOIN productincategory pc ON p.item_id = pc.item_id
		WHERE category_id = $cid
		ORDER BY p.item_id ASC , category_id ASC";
}
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
if (isset($_GET['s']) && is_numeric($_GET['s'])) 
{
	$start =$_GET['s'];
}else 
{
	$start = 0;
}

// Default query for this page:
$q = "SELECT item_id, product_name, description, on_hand, sold, price, image_name
	FROM products
	ORDER BY item_id ASC 
	LIMIT $start, $display";

// are we looking at a particular catagory?
if (isset($_GET['cid']) && filter_var($_GET['cid'], FILTER_VALIDATE_INT, array('min_range' => 1 )) ) 
{
	$cid =$_GET['cid'];
	// Overwrite the query:
	$q = "SELECT p.item_id, product_name, description, on_hand, sold, price, image_name, category_id
		FROM products p
		LEFT JOIN productincategory pc ON p.item_id = pc.item_id
		WHERE category_id = $cid
		ORDER BY p.item_id ASC , category_id ASC 
		LIMIT $start, $display";
}

// create the table head:
echo '<table id="products" width="90%" cellspacing="3" cellpadding="3" align="center" >
	<tr>
		<td align="left" width="20%"><b>image</b></td>
		<td align="left" width="20%"><b>Product</b></td>
		<td align="left" width="20%"><b>Price</b></td>
	</tr>';
	
// Display all the products, linked to URLs:
$r = mysqli_query ($dbc, $q);
while ($row = mysqli_fetch_array ($r, MYSQLI_ASSOC)) 
{
	$image = @getimagesize ('../../uploadmm/'.$row['item_id']);
	// Display each record:
	echo '<tr>
		<td align="left"><img id="products" src="show_image.php?image='.$row['item_id'].'&name="'. urlencode($row['image_name']) . '" '.$image[3] .'alt="{'.htmlentities($row['product_name']).'}" /></a></td>
		<td align="left"><a href="view_product.php?pname='.htmlentities($row["product_name"]).'&pid='.$row['item_id'].'">'.$row['product_name'].'</a></td>
		<td align="right">'.$row['price'].'</td>
	</tr>';
	
} // End of while loop

echo '</table>';
mysqli_close($dbc);

//make links to other pages if nessary
	if($pages > 1){
		//add spacing
		echo '<br /><p>';

		//determine what page the script is
		$current_page =($start/$display) +1;

		//if its not the first page make previus link
		if($current_page != 1)
		{
			if (isset($_GET['cid']) && filter_var($_GET['cid'], FILTER_VALIDATE_INT, array('min_range' => 1 )) )
			{
				echo '<a href="view_products.php?cid=' . $cid . '&s=' . ($start - $display) . '&p=' . $pages . '">Previous</a> ';
			}else
			{
				echo '<a href="view_products.php?cid=E&s=' . ($start - $display) . '&p=' . $pages . '">Previous</a> ';
			}
			
		}

		//make all the numbered pages:
		for($i = 1; $i<= $pages; $i++) 
		{
			if($i != $current_page)
			{
				if (isset($_GET['cid']) && filter_var($_GET['cid'], FILTER_VALIDATE_INT, array('min_range' => 1 )) )
				{
					echo '<a href=view_products.php?cid=' . $cid . '&s=' . (($display * ($i-1))) . '&p=' . $pages . '">' . $i . '</a> ';
				}else
				{
					echo '<a href=view_products.php?cid=E&s=' . (($display * ($i-1))) . '&p=' . $pages . '">' . $i . '</a> ';
				}
				
			}else 
			{
				echo $i . '';
			}
		}//end of for

		//if thats not the last page

		if($current_page != $pages)
		{
			if (isset($_GET['cid']) && filter_var($_GET['cid'], FILTER_VALIDATE_INT, array('min_range' => 1 )) )
			{
				echo '<a href="view_products.php?cid=' . $cid . '&s=' . ($start + $display) . '&p=' . $pages . '">Next</a> ';
			}else
			{
				echo '<a href="view_products.php?cid=E&s=' . ($start + $display) . '&p=' . $pages . '">Next</a> ';
			}
			
		}
		echo '</p>'; //end of p tag

	}//end of links
include ('includes/footer.html');
?>
