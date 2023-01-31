using System.Collections;
using System.Collections.Generic;
using TextSpeech;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

namespace VoiceUtil
{
    public class Voice : MonoBehaviour
    {
        const string LANG_CODE = "ko-KR";

        [SerializeField] private Text uiText;

        void Start()
        {
            DontDestroyOnLoad(this.gameObject); // ���ο� Scene �ε� �� �ش� ������Ʈ �ı�X
            Setup(LANG_CODE);

#if UNITY_ANDROID
            SpeechToText.Instance.onPartialResultsCallback = OnPartialSpeechResult;
#endif

            SpeechToText.Instance.onResultCallback = OnFinalSpeechResult;
            Debug.Log(SpeechToText.Instance.onResultCallback);
            TextToSpeech.Instance.onStartCallBack = OnSpeakStart;
            TextToSpeech.Instance.onDoneCallback = OnSpeakStop;

            CheckPermission();
        }

        void CheckPermission()
        {
#if UNITY_ANDROID
                if(!Permission.HasUserAuthorizedPermission(Permission.Microphone)){
                    Permission.RequestUserPermission(Permission.Microphone);
                }
#endif
        }


        #region Text to Speech
        public void StartSpeaking(string text)
        {
            TextToSpeech.Instance.StartSpeak(text);
        }

        public void StopSpeaking()
        {
            TextToSpeech.Instance.StopSpeak();
        }

        public void OnSpeakStart()
        {
            Debug.Log("���ϱ� ����");
        }

        public void OnSpeakStop()
        {
            Debug.Log("���ϱ� ����");
        }
        #endregion

        #region Speech to Text
        public void StartListening()
        {
            SpeechToText.Instance.StartRecording();
        }

        public void StopListening()
        {
            SpeechToText.Instance.StopRecording();
        }

        public void OnFinalSpeechResult(string result)
        {
            uiText.text = result;
        }

        public void OnPartialSpeechResult(string result)
        {
            uiText.text = result;
        }

        #endregion

        void Setup(string code)
        {
            TextToSpeech.Instance.Setting(code, 1, 1);
            SpeechToText.Instance.Setting(code);
        }
    }
}