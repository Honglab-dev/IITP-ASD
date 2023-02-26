using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public Text TimerText;
    public Image Fill;
    public float Max;

    void Update()
    {

        time -= Time.deltaTime; //���ɿ� ���� �� �����ӿ� ������ ��� ���� ������
        //Debug.Log(time);
        //TimerText.text = (int)time; -> error: Cannot implicitly convert type 'int' to 'string'
        TimerText.text = ""+(int)time;
        Fill.fillAmount = 1-(time / Max);
        
        //time�� 0�� �ƴϸ� ���. 0�̵Ǹ� ���������� ��.
        if(time<0)
            time = 0;
    }
}
