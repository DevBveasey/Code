<!DOCTYPE>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
</head>
<body>
	<?php
	//function that accepts one variable and converts to celsius and returns the value
	function Tempf2c ($temp)
	{
	$celsius = ($temp - 32)*5/9;
	return round($celsius,2);
	}

	//function that accepts one variable and converts to fahrenheit and returns the value
	function Tempc2f ($temp)
	{
	$fahrenheit = ($temp * 9/5) + 32;
	return round($fahrenheit,2);
	}

	//function that accepts one variable and converts to centimeters and returns the value
	function Leni2cm ($length)
	{
	$centimeters = $length * 2.54;
	return round($centimeters,2);
	}
	?>



</body>
</html>