using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimOnce : MonoBehaviour
{
   // public Animator animator;
    public WrapMode wrapMode; //add component

    void Start()
    {
        //Debug.Log(animator.name);
        gameObject.GetComponent<Animation>()["FriutIn"].wrapMode = WrapMode.Once;
    }

}
