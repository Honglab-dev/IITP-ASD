using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RandomSound : MonoBehaviour
{
    public AudioClip[] Sound = new AudioClip[5]; //sound
    public AudioClip[] Sound2 = new AudioClip[2]; //correct,incorrect
    private AudioSource AS; //public가 붙으면 내가 지정할 수 있음
    int count = 0; //-> 다쓰면 지워야하나?
    string target;

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


    public void ClickBtn() //버튼 누를때 호출
    {
        //방금 클릭한 게임오브젝트
        GameObject click = EventSystem.current.currentSelectedGameObject;

        if (target == click.name)
        {
            count++;
            Debug.Log("정답입니다.");
            AS.clip = Sound2[1];
            AS.Play();
            Debug.Log("count:" + count);
        }
        else
        {
            count++;
            Debug.Log("틀렸습니다.");
            AS.clip = Sound2[0]; //--> ★문제점: 음성을 출력하면 AS.clip의 이름이 바뀐다. 따라서 해당 과정으로는 정답도 오답으로 처리
            AS.Play();
            Debug.Log("count:" + count);

        }
    }
}