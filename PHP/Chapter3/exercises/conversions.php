<!DOCTYPE>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">

</head>
<body>
<?php
	
	$page_title = 'conversions';//declares pagetitle for use in header
	include ('includes/header.html');//calls header.html document using $page_title displaying header

	//links functions.ini to allow use of its functions
	include('/includes/functions.inc');

	if($_SERVER['REQUEST_METHOD']=='POST')
	{
		//--- Beagin testing for inputs and displaying calculated outputs ---//
		if (isset($_POST['f2c']) && $_POST['f2c'] >=0 && is_numeric($_POST['f2c'])) //test for input from converter
		{
			$fahrenheit = $_POST['f2c'];//declare variable and set it equal to user input
			echo "Fahrenheit to Celsius: " . $fahrenheit . "° Fahrenheit = " . Tempf2c($fahrenheit) . "° Celsius<br>";
			
		}else// tells user that no data was entered
		{
			echo "Fahrenheit to Celsius: No conversion Entered<br>";
		}//end of if-else

		if (isset($_POST['c2f']) && $_POST['c2f'] >=0 && is_numeric($_POST['c2f']))//test for input from converter
		{
			$celsius = $_POST['c2f'];//declare variable and set it equal to user input
			echo "Celsius to Fahrenheit: " . $celsius . "° Celsius = " . Tempc2f($celsius) . "° Fahrenheit<br>";
			
		}else// tells user that no data was entered
		{
			echo "Celsius to Fahrenheit: No conversion Entered<br>";
		}//end of if-else

		if (isset($_POST['i2cm']) && $_POST['i2cm'] >= 1) //test for input from converter
		{
			$inches = $_POST['i2cm'];//declare variable and set it equal to user input
			echo "Inches to Centimeters: " . $inches . "\" = " . Leni2cm($inches) . " cm<br>";
			
		}else// tells user that no data was entered
		{
			echo "Inches to Centimeters: No conversion Entered<br>";
		}//end of if-else
	}//end of if statment testing for submitted data
?><!--end of PHP-->

<div><!-- form for data input -->
	<form action="conversions.php" method="post">
		<hr>
		<br><label for="f2c">Fahrenheit to Celsius  (°F to °C)</label><br><br>
		<input type="number" name="f2c" ><br><br>

		<label for="c2f">Celsius to Fahrenheit (°C to °F)</label><br><br>
		<input type="number" name="c2f" ><br><br>

		<label for="i2cm">Inches to Centimeters</label><br><br>
		<input type="number" name="i2cm"><br><br>

		<input type="submit" name="submit" value="Calculate!"/>
		
	</form>
</div>
<?php include ('includes/footer.html'); ?><!-- calls footer.html document importing html for footer -->
</body>
</html>