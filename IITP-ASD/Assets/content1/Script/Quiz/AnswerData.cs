using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MonoBehaviour�� ��� ���� �ʴ� �Ϲ� C# Ŭ������ �������
//����Ƽ�� Inspector �������� ���� �ʹٸ�
//�ش� Ŭ������ [System.Serializable]�� �ٿ��ָ� �ȴ�.
//�ٸ� Ŭ�������� �� Ŭ������ ������ �� private ����� �����Ѵٸ�
//[SerializeField]�� �Բ� �ٿ��־�� �Ѵ�.

[System.Serializable]
public class AnswerData {
    public string answerText;
    public bool isCorrect;

}
