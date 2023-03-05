using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestionData
{
    public string questionText;
    public AnswerData[] answers; //이걸로 연결
}
