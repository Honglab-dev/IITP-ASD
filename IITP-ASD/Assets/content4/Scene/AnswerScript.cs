using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QuizMgrUtil;
//using CharacterUtil;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    //public Color startColor;

    public void Answer()
    {
        if(isCorrect)
        {
            //GetComponent<Iage>().color = color.green;
            Debug.Log("맞았습니다.");
            quizManager.correct();
        }
        else
        {
            //GetComponent<Image>().color = color.red;
            Debug.Log("틀렸습니다.");
            quizManager.wrong();
        }
    }
}
