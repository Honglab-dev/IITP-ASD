using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VoiceMgrUtil; // using namespace VoiceMgrUtil

public class Character : MonoBehaviour
{
    GameObject mgr;

    void Start()
    {
        Debug.Log("ĳ���� Script Start");
        mgr = GameObject.Find("VoiceMgr");
        mgr.GetComponent<VoiceMgr>().SpeakingAndListening();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
