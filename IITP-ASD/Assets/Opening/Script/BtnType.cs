using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //���ӽ����̽� �߰�
using UnityEngine.SceneManagement;

//�������̽��߰�
public class BtnType : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public BTNType currentType;

    //���콺�� ��ư���� ������ Ŀ�����ϴ� �Լ�
    public Transform buttonScale;
    Vector3 defaultScale;

    //content�޴��� main�޴��� �ٲٵ���
    public CanvasGroup mainGroup;
    public CanvasGroup contentGroup;
    public CanvasGroup content4Group;
    private void Start()
    {
        //defaultScale�� buttonScale�� �ʱ�ȭ
        defaultScale = buttonScale.localScale;
    }
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.START:
                Debug.Log("�����ϱ�");
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
                Debug.Log("�ڷΰ���");
                CanvasGroupOn(contentGroup);
                CanvasGroupOff(content4Group);
                break;
            case BTNType.QUIT:
                Application.Quit();
                Debug.Log("����");
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
        //��ư�� �ʱ�ũ�� * 1.2 ��
        buttonScale.localScale = defaultScale * 1.2f;
    }

    //������Ʈ�� ����� �ٽ� �ǵ��ƿ�����
    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
