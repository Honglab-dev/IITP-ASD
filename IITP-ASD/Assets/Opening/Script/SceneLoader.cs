using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Slider progressbar;
    public Text loadtext;
    public static string loadScene;
    public static int loadType;

    void Start()
    {
        StartCoroutine(LoadScene()); //�ڷ�ƾ
    }

    public static void LoadSceneHandle(string _name)
    {
        loadScene = _name;
        SceneManager.LoadScene("Loading");
    }

    IEnumerator LoadScene() //�ڷ�ƾ
    {
        yield return null;
        AsyncOperation operation = SceneManager.LoadSceneAsync(loadScene);
        if(operation != null){
            operation.allowSceneActivation = false;
        }
        

        while (!operation.isDone)
        {
            //loadtype�� ����
            yield return null;
            /*
            if (loadType == 0)
            {
                Debug.Log("activity4_1");
            }
            else if (loadType == 1)
                Debug.Log("activity4_2");
            else if (loadType == 2)
                Debug.Log("activity4_3");
            */

            //�ε���
            if (progressbar.value < 0.9f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 0.9f, Time.deltaTime);
            }
            else if (operation.progress >= 0.9f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 1f, Time.deltaTime);
            }


            if (progressbar.value >= 1f && operation.progress >= 0.9f) //��ġ �̺�Ʈ�� ����
            {
                operation.allowSceneActivation = true;
            }
        }
    }
}
