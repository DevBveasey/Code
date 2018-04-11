<?php 

class question
{
	/*create variables*/
	private $_id;
	private $_text;
	private $_feedback;
	private $_correctAnswer;
	private $_answers;
	private $_conn;

	public function __construct($dbc, $id, $text, $feedback, $correctAnswer)
	{
		$this->_conn = $dbc;
		$this->_id = $id;
		$this->_text = $text;
		$this->_feedback = $feedback;
		$this->_correctAnswer = $correctAnswer;
		$this->_answers = array();
		$this->loadAnswers();
		
	}

	public function getId()
	{
		return $this->_id;
	}

	public function getText()
	{
		return $this->_text;
	}

	public function getfeedback()
	{
		return $this->_feedback;
	}

	public function getcorrectAnswers()
	{
		return $this->_correctAnswer;
	}

	public function getAnswers()
	{
		return $this->_answers;
	}

	public function checkAnswer($answer)
	{
		return ($answer == $this->_correctAnswer);
	}

	private function loadAnswers()
	{
		// Make the connection:
		require_once ('../../connect_quizzes.php'); // Connect to the db.
		
		//create query to retive answers for question
		$query = "SELECT answer from answers where question_id =". $this->_id;

		//exicute query
		$r = mysqli_query($this->_conn, $query);

		//parse through result set and add the answer to answers array
		while ($row = mysqli_fetch_array($r, MYSQLI_ASSOC)) 
		{

			//add question to _question_array
			$this-> _answers[] = $row["answer"];
		}
		//parse through result set and add the answer to answers array
	}

}/* end of class */

 ?><!-- end of php -->