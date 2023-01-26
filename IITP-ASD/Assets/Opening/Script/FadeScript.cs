using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    public Image Panel;
    float time = 0f;//0부터1까지 deltatime을 계속더함.
    float F_time = 1.5f;

    public void Start()
    {
        StartCoroutine(FadeFlow());//Corutine
    }

    IEnumerator FadeFlow()
    {
        Panel.gameObject.SetActive(true);//루틴이 시작할때 이미지를 활성화
        Color alpha = Panel.color;
       
        while (alpha.a > 0f)  //이미지의 알파값이 변하게 만듦
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1,0, time);//Mathf.Lerp 0부터 1까지 부드럽게 변하게 만들어줌.
            Panel.color = alpha; //매 프레임 이미지의 컬러값에 대입.
            yield return null;

        }
        Panel.gameObject.SetActive(false);
        yield return null;
    }

}
