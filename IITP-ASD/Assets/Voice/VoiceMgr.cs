using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VoiceUtil; // using namespace VoiceUtil

namespace VoiceMgrUtil
{
    public class VoiceMgr : MonoBehaviour
    {
        GameObject obj;

        void Start()
        {
            DontDestroyOnLoad(this.gameObject);
            obj = GameObject.Find("Voice");
        }

        public void SpeakingAndListening() // �׽�Ʈ��
        {
            obj = GameObject.Find("Voice");
            Speaking("�ȳ��ϼ��� �׽�Ʈ�Դϴ�");
            Invoke("Listening", 3f); // 3�� ���� Linstening() ����
        }

        public void SpeakingAndListening(string str)
        {
            Speaking(str);
            Invoke("Listening", 3f); // 3�� ���� Linstening() ����
        }

        public void Speaking(string str)
        {
            obj.GetComponent<Voice>().StartSpeaking(str);
        }

        public void Listening()
        {
            obj.GetComponent<Voice>().StartListening();
        }
    }
}
