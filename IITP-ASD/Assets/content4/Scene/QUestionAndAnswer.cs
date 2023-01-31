
using UnityEngine;

[System.Serializable]
public class QuestionAndAnswers
{
    public string Question;
    public Sprite[] Answers;
    public int CorrectAnswer;

    public string getQuestion()
    {
        return Question;
    }
}
