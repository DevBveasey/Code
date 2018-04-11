<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="utf-8" />
		<title>Order Confirmation</title>
		<style type="text/css" title="text/css" media="all">
			.error {
				font-weight: bold;
				color: #C00;
			}
		</style>
		<script src="modernizr-1.5.js"></script>
		
		<link href="redball.css" rel="stylesheet" />
		<link href="pizza.css" rel="stylesheet" />
	</head>
	<body>
		<header>
			<img src="redball.png" alt="Red Ball Pizza" />
			<article>
				<h1>Online Ordering</h1>
				<p>Thank you for using our <em>online ordering</em>
				   form for quick and easy orders, delivered free, fast, and 
				   hot to your door. If you need to talk to us directly,
				   call Red Ball Pizza at (386) 555 - 7499.
				</p>
			 </article>
		 </header>
		<?php # handle_order.php
			# Created on <fill the date in here>
			# Created by <fill your name in here>
			# Calculate the price of the pizza
			# Display the customer information
			# Display a recap of the customer order with the calculated price
			
			// todo: gather information into variables
			/*
			$name = "";
			$address = "";
			$phone = "";
			$time = "";
			$size = "";
			$crust = "";
			$quantity = "";
			$instructions = "";
			// use an array for the toppings
			$toppings = array ();
			$cheese = "regular Cheese";
			$sauce = "regular Sauce";
			*/
			
			// todo: calculate the price
			

			echo "<h1>Thank you for your order!</h1>";

			// display delivery information inside this fieldset
			echo '<fieldset id="custOrder">';
				echo "<legend>Customer Information</legend>";
				echo "Your pizza will be delivered to:";
				// todo: display the deliver information
				
			echo "</fieldset>";
			
			// display order details inside this fieldset
			echo '<fieldset id="orderDetail">';
				echo "<legend>Order Detail</legend>";
				echo "You ordered:";
				// todo: display the order details
				
			echo "</fieldset>";		


		?>

	</body>
</html>
