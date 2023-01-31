using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VoiceMgrUtil; // using namespace VoiceMgrUtil

namespace CharacterUtil
{
    public class Character : MonoBehaviour
    {
        GameObject voiceMgr;

        void Start()
        {
            voiceMgr = GameObject.Find("VoiceMgr");
        }

        public void CharacterSpeaking(string str)
        {
            voiceMgr.GetComponent<VoiceMgr>().Speaking(str);
        }
        
        public void CharacterStopSpeaking()
        {
            voiceMgr.GetComponent<VoiceMgr>().StopSpeaking();
        }
    }
}