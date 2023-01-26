using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    //비동기 로드: 씬을 불러올때 멈추지않고 다른작업을 할 수 있음 -> 코루틴사용
    //LoadSceneAsync가 AsycnOperation을 반환하니 담아준다
    //asycnoperation :
    //isDone: 작업의 완료 유무를 boolean 형으로 반환한다
    // progress : 진행정도를 0,1로 반환한다. (0:진행중 1: 진행완료)
    // allowSceneActivation : true면 로딩이 완료되어 바로 씬을 넘김. false면 progress가 0.9f에서 멈춤. 로딩이 끝나고 멈추게만듦.

    public Object SceneToLoad;
    SceneLoad CurrentScene;

    public Slider progressbar;
    public Text loadtext;

    private void Start()
    {
        //CurrentScene = gameObjcet.scene;
        //Debug.Log(CurrentScene.name);

        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return null;
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneToLoad.name);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            yield return null;
            //slider의 value값을 올린다.
            if (progressbar.value < 0.9f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 0.9f, Time.deltaTime);
            }
            else if (operation.progress >= 0.9f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 1f, Time.deltaTime);
            }

           if(progressbar.value >=1f)
            {
                loadtext.text = "Press SpaceBar";
            }

 
            if (Input.GetKeyDown(KeyCode.Space)&&progressbar.value >= 1f && operation.progress >= 0.9f) //터치 이벤트로 변경
            {
                operation.allowSceneActivation = true;
            }
        }
    }
}

