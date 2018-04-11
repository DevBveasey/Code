<!DOCTYPE html>
<html lang="en">
<head>
	<title>Midterm</title>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link rel="stylesheet" type="text/css" href="style.css">
</head>

<body>

<header>
	
</header>

	<div id="content">
		<?php 
			include ('quiz.php');

			/*Create a new quiz*/
			require_once ('../../connect_quizzes.php'); // Connect to the db.
			$quiz = new Quiz(1, 'testz');

			/*Call the Load questions of that quiz*/
			$quiz->loadQuestions($dbc);

			/*get questions*/
			$questions = $quiz->getQuestions();
			//set counter
			$counter = 1;

			/*display test name*/
			echo '<div id="title">' . $quiz->getTitle() . '</div> ';

			if($_SERVER['REQUEST_METHOD'] == 'POST')// test if user submitted
			{
				$unanswered = array();//stores unanswered questions
				foreach ($questions as $q) // test each question
				{
					if (!isset($_POST[$q->getId()])) //if question is not set
					{
						$unanswered = $q->getId();// adds unanswered question to array
						echo 'you did not answer' . $q->getId();
					}else
					{
					
					}
				}

				if (empty($unanswered)) //if user answered all questions
				{
					//hide questions
					echo '<style type="text/css">.ansform{ display:none; }</style>';

					//echo thank you MSG
					echo '<div id="dspwrap"> <p id="thxmsg"> Thank you ' . $_POST['fname'] . ' ' . $_POST['lname'] . ' your test has been graded and is available below for review.</p>';

					//create variable for the number of right answers.
					$numright = 0;

					//print out all questions and displaying answers and feed back
					foreach ($questions as $q) 
					{
						echo ' <div class="dspsubq" >';
						//display all questions
						echo '<div id =' . $q->getId() . ' style="display: block">';
						echo '<p id="marg"><strong>'. $counter . "</strong>.  " . $q->getText() . '</p>';

						//test each question for correct answer
						if ($_POST[$q->getId()] == $q->getcorrectAnswers()) 
						{
							//echo correct answer msg with img
							echo '<img src="correct.png" alt="correct"><p>You selected the <strong>correct</strong> answer "'. $_POST[$q->getId()] . '"</p>';
							$numright++;//increment the number of correct answers
							
						}else
						{
							//dsp incorrect answer msg with img
							echo '<img src="incorrect.png" alt="incorrect"><p>You selected the <strong>incorrect</strong> answer "'. $_POST[$q->getId()] . '"</p>';
							//dsp correct answer
							echo '<p>The correct answer is "'. $q->getcorrectAnswers() . '"</p>';
							//dsp feedback
							echo '<p>'. $q->getfeedback() . ' </p>';
							
						}
						echo '</div>';



						
						echo '</div>';
						$counter++;
						
					}//end foreach loop
					echo '<div id="end">';
					//calculate percent right
					$percent = (($numright / ($counter - 1)) * 100);
					//dsp grade message 
					echo '<p> You answered ' . $numright . ' out of ' . ($counter - 1) . ' questions correct for a score of ' . $percent . '%. </P>';

					//dsp correct grade msg based on grade
					if ($percent < 70) 
					{
						echo '<p> Online learning is not for you. Please sign up for a traditional course.</p>';
					}elseif ($percent >= 70 && $percent <= 75) 
					{
						echo "<p> You may be fine, but it's best you stick to traitional courses for now. </p>";
					}elseif ($percent >= 80 && $percent <= 85) 
					{
						echo '<p> You seem fairly ready for online learning. </p>';
					}elseif ($percent >= 90 && $percent <= 95) 
					{
						echo '<p> You seem ready for online learning! </p>';
					}elseif ($percent == 100) 
					{
						echo '<p> You are ready for online learning! </p>';
					}else
					{
						echo ' <p> Please check with your advisor before registering for online courses </p>';
					}
					
					echo '</div>';	
				}//end of if statement verifying all questions answered

			}//end server status check*/
			
			/*create top page form*/
			echo '<form  id="dspwrap" class="ansform" action="" method="post"> 
			<label>Please enter the following</label><br>
			<label for="fname">First Name</label><input required type="text" name="fname" id="name"><br> 
			<label for="lname">Last Name</label><input required type="text" name="lname" id="lname"><br> 
			<label for="email">Email Address</label><input required type="Email" name="email" id="email"><br>';


			/*create html form*/
			echo '<table cellspacing="3" cellpadding="3" width="75%">';

			
			
			/* print out all questions and answers*/
			foreach ($questions as $q) 
			{
				echo '<div id =' . $q->getId() . ' style="display: block">';
				echo '<p id="marg" class="q"><strong>'. $counter . "</strong>.  " . $q->getText() . '</p>';
				/*get answers*/
				$answers= $q->getAnswers();
				foreach ($answers as $a) 
				{
					echo '<div id="marg"> <input type ="radio" name='. $q->getId() .' value="'. $a . '" required />' . $a.'</div>';
					
				}
				echo '</div>';
				$counter++;
				//echo $q->getfeedback();//calls getfeedback()
			}
			/*  display notice of completion and submit button */
			echo '<div id="end"> <div class="notice"> <strong>Notice:</strong> all questions and fields <strong> MUST </strong> be answered before submitting.</div>';
			echo ' <div id="btn"> <input type= "submit" name="Submit" value="Submit"></div> </form></div>';

			
		 ?>
		
	</div></body>

</body>

</html>