<?php 
include('question.php');
class Quiz
{
	
	/*create variables*/
	private $_qid;
	private $_title;
	private $_questions;

	public function __construct( $qid, $title)
	{
		$this->_qid = $qid;
		$this->_title = $title;
		$this->_numCorrect = 0;
		$this->_questions = array();
		
	}

	public function getQid()
	{
		
		return $this->_qid;
	}
	
	public function getTitle()
	{
		return $this->_title;
	}

	public function getnumCorrect()
	{
		
		return $this->_numCorrect;
	}

	public function getQuestions()
	{
		return $this->_questions;
	}

	public function loadQuestions($dbc)
	{
		
		//create query to retive answers for question
		$query = "SELECT questions.question_id as id, question, feedback, answers.answer as answer
			FROM questions
			join answers on questions.answer_id = answers.answer_id
			where quiz_id =" . $this->getQid();

		//exicute query
		$r = mysqli_query($dbc, $query);

		//parse through result set and add the answer to answers array
		while ($row = mysqli_fetch_array($r, MYSQLI_ASSOC)) 
		{
			$question = new Question($dbc, $row["id"],  $row["question"], $row["feedback"], $row["answer"]);

			//add question to _question_array
			$this-> _questions[] = $question;
		}

	} 

	public function calcGrade()
	{
		return $this->numCorrect/numQuestions() * 100;
	}
	public function numQuestions()
	{
		count($this->_questions);
	}

	public function checkAnswer($answer)
	{
		return ($answer == $this->_numCorrect);
	}

}/* end of class */




 ?>