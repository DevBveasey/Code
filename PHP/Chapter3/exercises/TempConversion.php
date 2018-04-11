<!DOCTYPE>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title></title>
</head>
<body>
	<?php
	function Tempf2c ($temp)
	{
	$celsius = ($temp - 32)*5/9;
	return $celsius;
	}
	for ($temp=0; $temp < 101 ; $temp++) 
	{ 
		
		$cel = round(Tempf2c($temp),1);
		echo "<p>$temp ° fahrenheit = $cel ° celsius</P>";
		
	}
	?>



</body>
</html>