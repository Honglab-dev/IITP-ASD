using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //네임스페이스 추가
using UnityEngine.SceneManagement;

//인터페이스추가
public class BtnType : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public BTNType currentType;

    //마우스가 버튼위에 있으면 커지게하는 함수
    public Transform buttonScale;
    Vector3 defaultScale;

    //content메뉴와 main메뉴를 바꾸도록
    public CanvasGroup mainGroup;
    public CanvasGroup contentGroup;
    public CanvasGroup content4Group;
    private void Start()
    {
        //defaultScale을 buttonScale로 초기화
        defaultScale = buttonScale.localScale;
    }
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.START:
                Debug.Log("시작하기");
                CanvasGroupOn(contentGroup);
                CanvasGroupOff(mainGroup);
                break;
            case BTNType.CONTENT1:
                Debug.Log("CONTENT1");
                break;
            case BTNType.CONTENT2:
                Debug.Log("CONTENT2");
                break;
            case BTNType.CONTENT4:
                Debug.Log("CONTENT4");
                CanvasGroupOn(content4Group);
                CanvasGroupOff(contentGroup);
                break;
            case BTNType.ACTIVITY4_1:
                Debug.Log("ACTIVITY4_1");
                SceneLoader.LoadSceneHandle("activity1");
                //SceneManager.LoadScene("activity1");
                break;
            case BTNType.ACTIVITY4_2:
                Debug.Log("ACTIVITY4_2");
                SceneLoader.LoadSceneHandle("activity1_ending");
                break;
            case BTNType.ACTIVITY4_3:
                Debug.Log("ACTIVITY4_3");
                break;
            case BTNType.BACK:
                Debug.Log("뒤로가기");
                CanvasGroupOn(contentGroup);
                CanvasGroupOff(content4Group);
                break;
            case BTNType.QUIT:
                Application.Quit();
                Debug.Log("종료");
                break;
        }
    }

    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }

    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //버튼의 초기크기 * 1.2 배
        buttonScale.localScale = defaultScale * 1.2f;
    }

    //오브젝트가 벗어나면 다시 되돌아오도록
    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
