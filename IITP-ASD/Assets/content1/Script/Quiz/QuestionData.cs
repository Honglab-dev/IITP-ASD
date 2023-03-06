using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class QuestionData
{
    public string questionText;
    //public AudioClip[] Sound = new AudioClip[2];
    public AudioClip Sound;
    public AnswerData[] answers; //�̰ɷ� ����

    private AudioSource AS;

}
