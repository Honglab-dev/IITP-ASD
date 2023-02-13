using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Handler
public class AnimationEvent : MonoBehaviour
{ 
 //#region~#endregion : CodeBlock

    #region Fields
    #endregion Fields

    #region Members
    private Animator m_Animator;
    
    //public Button btn1;
    public GameObject Fruit1;
    public GameObject Fruit2;
    public GameObject Fruit3;
    public GameObject Fruit4;

    #endregion Members

    #region Methods
   
    void Awake()  //Awake()->Start()
    {
        m_Animator = GetComponent<Animator>();
       
        //btn1 = Find("Button1").GetComponent<Button>();
 
        Fruit1.gameObject.SetActive(false);
        Fruit2.gameObject.SetActive(false);
        Fruit3.gameObject.SetActive(false);
        Fruit4.gameObject.SetActive(false);
    }

    public void EnterNextScene()
    {
        //playanimation
        m_Animator.Play("GuestCharcterMove");
    }

    public void OnEnterNextScene() //After animation ends
    {

        //btn1.interactable = false; // inactivation click
        Fruit1.gameObject.SetActive(true);
        Fruit2.gameObject.SetActive(true);
        Fruit3.gameObject.SetActive(true);
        Fruit4.gameObject.SetActive(true);
        
    }

    #endregion Methods
}
