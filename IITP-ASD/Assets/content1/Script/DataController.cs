using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour
{
    public RoundData[] allRoundData;


    void Start()
    {
        DontDestroyOnLoad(gameobject);

        //SceneManager.LoadScene("");
        
    }

    public RoundData GetCurrentRoundData()
    {
        return allRoundData[0];
    }

    void Update()
    {
        
    }
}
