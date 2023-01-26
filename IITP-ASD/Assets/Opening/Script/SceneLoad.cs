using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    //�񵿱� �ε�: ���� �ҷ��ö� �������ʰ� �ٸ��۾��� �� �� ���� -> �ڷ�ƾ���
    //LoadSceneAsync�� AsycnOperation�� ��ȯ�ϴ� ����ش�
    //asycnoperation :
    //isDone: �۾��� �Ϸ� ������ boolean ������ ��ȯ�Ѵ�
    // progress : ���������� 0,1�� ��ȯ�Ѵ�. (0:������ 1: ����Ϸ�)
    // allowSceneActivation : true�� �ε��� �Ϸ�Ǿ� �ٷ� ���� �ѱ�. false�� progress�� 0.9f���� ����. �ε��� ������ ���߰Ը���.

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
            //slider�� value���� �ø���.
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

 
            if (Input.GetKeyDown(KeyCode.Space)&&progressbar.value >= 1f && operation.progress >= 0.9f) //��ġ �̺�Ʈ�� ����
            {
                operation.allowSceneActivation = true;
            }
        }
    }
}

