using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    public Image Panel;
    float time = 0f;//0����1���� deltatime�� ��Ӵ���.
    float F_time = 1.5f;

    public void Start()
    {
        StartCoroutine(FadeFlow());//Corutine
    }

    IEnumerator FadeFlow()
    {
        Panel.gameObject.SetActive(true);//��ƾ�� �����Ҷ� �̹����� Ȱ��ȭ
        Color alpha = Panel.color;
       
        while (alpha.a > 0f)  //�̹����� ���İ��� ���ϰ� ����
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1,0, time);//Mathf.Lerp 0���� 1���� �ε巴�� ���ϰ� �������.
            Panel.color = alpha; //�� ������ �̹����� �÷����� ����.
            yield return null;

        }
        Panel.gameObject.SetActive(false);
        yield return null;
    }

}
