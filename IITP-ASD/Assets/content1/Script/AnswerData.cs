using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MonoBehaviour을 상속 받지 않는 일반 C# 클래스의 멤버들을
//유니티의 Inspector 슬롯으로 띄우고 싶다면
//해당 클래스에 [System.Serializable]을 붙여주면 된다.
//다른 클래스에서 이 클래스를 참조할 때 private 멤버로 참조한다면
//[SerializeField]도 함께 붙여주어야 한다.

[System.Serializable]
public class AnswerData {
    public string answerText;
    public bool isCorrect;

}
