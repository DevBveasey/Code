<!DOCTYPE html>
<html>
<head>
	<title>ADD BOOK</title>
</head>
<body>
	

	<?php 
		echo '<form>
				<p><label>ISBN-10</label>
				<input type="numeric" name="isbn"></p>

				<p><label>Book Title</label>
				<input type="text" name="title"></p>

				<p><label>Number of copys</label>
				<input type="numeric" name="numbook"></p>

				<p><label>Author name</label>
				<input type="text" name="author"></p>

				<p><label>Subject</label>
				<input type="text" name="subject"></p>

				<p><input type="button" name="submit" value="Submit"></p>
			</form>'

	 ?>	

</body>
</html>