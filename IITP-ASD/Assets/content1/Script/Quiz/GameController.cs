using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text questionDisplayText;
    public Text scoreDisplayText;
    public Text timeRemainingDisplayText;
    public SimpleObjcetPool answerButtonObjectPool;
    public GameObject questionDisplay;
    public GameObject roundEndDisplay;

    private DataController dataController;
    private RoundData currentRoundData;
    private QuestionData[] questionPool;

    private bool isRoundActive;
    private float timeRemaining;
    private int questionIndex;

    void Start()
    {
        dataController = FindObjectOfType<DataController>(); //오브젝트를 찾는방법. -> find script?

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
