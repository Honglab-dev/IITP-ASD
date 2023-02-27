using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RandomSound : MonoBehaviour
{

    public AudioClip[] Sound = new AudioClip[5]; //sound
    public AudioClip[] Sound2 = new AudioClip[2]; //correct,incorrect
    private AudioSource AS; //public�� ������ ���� ������ �� ����
    int count = 0; //-> �پ��� �������ϳ�?
    string target;

    public float time;
    public Text TimerText;
    public Image Fill;
    public float Max;


    void Start()
    {
        AS = GetComponent<AudioSource>();
        //AS= FindObjectOfType<AudioSource>();

        RandomPlay();
        /*
        if (!AS.isPlaying)
        {
            RandomPlay();
        }
        */

    }

    void Update()
    {
        time -= Time.deltaTime;
        TimerText.text = "" + (int)time;
        Fill.fillAmount = 1 - (time / Max);

        if (time < 0)
            time = 0;
    }

    void RandomPlay()
    {
        AS.clip = Sound[Random.Range(0, Sound.Length)];
        AS.Play();
        Debug.Log(AS.clip.name);
        target= AS.clip.name;
        Debug.Log("target:"+target);
        //Debug.Log(AS.clip.ToString()); //--> name + (UnityEngine.AudioClip)
        //Debug.Log(AS.ToString()); --> MainCamera(UnityEngine.AudioSource)
    }


    public void ClickBtn() //��ư ������ ȣ��
    {
        if (time > 0)
        {
            //��� Ŭ���� ���ӿ�����Ʈ
            GameObject click = EventSystem.current.currentSelectedGameObject;
            Debug.Log(time);
            if (target == click.name)
            {
                count++;
                Debug.Log("�����Դϴ�.");
                AS.clip = Sound2[1];
                AS.Play();
                Debug.Log("count:" + count);
            }
            else
            {
                count++;
                Debug.Log("Ʋ�Ƚ��ϴ�.");
                AS.clip = Sound2[0]; //--> �ڹ�����: ������ ����ϸ� AS.clip�� �̸��� �ٲ��. ���� �ش� �������δ� ���䵵 �������� ó��
                AS.Play();
                Debug.Log("count:" + count);

            }
        }
        else
            Debug.Log("�ð��ʰ�");
    }
}