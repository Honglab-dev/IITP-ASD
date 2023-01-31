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

        public void SpeakingAndListening() // 테스트용
        {
            obj = GameObject.Find("Voice");
            Speaking("안녕하세요 테스트입니다");
            Invoke("Listening", 3f); // 3초 이후 Linstening() 실행
        }

        public void SpeakingAndListening(string str)
        {
            Speaking(str);
            Invoke("Listening", 3f); // 3초 이후 Linstening() 실행
        }

        public void Speaking(string str)
        {
            obj.GetComponent<Voice>().StartSpeaking(str);
        }

        public void Listening()
        {
            obj.GetComponent<Voice>().StartListening();
        }

        public void StopSpeaking()
        {
            obj.GetComponent<Voice>().StopSpeaking();
        }
    }
}
