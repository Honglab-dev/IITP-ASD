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

        time -= Time.deltaTime; //성능에 따라 한 프레임에 나오는 결과 값을 보장함
        //Debug.Log(time);
        //TimerText.text = (int)time; -> error: Cannot implicitly convert type 'int' to 'string'
        TimerText.text = ""+(int)time;
        Fill.fillAmount = 1-(time / Max);
        
        //time이 0이 아니면 통과. 0이되면 오반응으로 들어감.
        if(time<0)
            time = 0;
    }
}
