using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using CharacterUtil;

namespace QuizMgrUtil
{
    public class QuizManager : MonoBehaviour
    {
        public List<QuestionAndAnswers> QnA;
        public GameObject[] options;
        public int currentQuestion;

        public Text QuestionText;
        public Text ScoreText;

        public GameObject QuizPanel;
        public GameObject GoPanel;

        int totalQuestion = 0;
        public int score;

        GameObject character;

        // 시작하면 makeQuestion() 함수 호출
        private void Start()
        {
            character = GameObject.Find("Character");
            //character.GetComponent<Character>().CharacterStopSpeaking();

            totalQuestion = QnA.Count;
            GoPanel.SetActive(false);
            makeQuestion();
        }

        // 문제 갯수만큼 랜덤 생성
        void makeQuestion()
        {
            if (QnA.Count > 0)
            {
                //character.GetComponent<Character>().CharacterStopSpeaking();
                currentQuestion = Random.Range(0, QnA.Count);
                QuestionText.text = QnA[currentQuestion].Question;
                SetAnswers();
                SpeakingQuestion(QnA[currentQuestion].Question);
                //QnA.RemoveAt(currentQuestion);
            }
            else
            {
                Debug.Log("문제를 다 풀었습니다.");
                GameOver();
            }
        }

        void SetAnswers()
        {
            for (int i = 0; i < options.Length; i++)
            {
                //options[i].GetComponent<Image>().color = options[i].GetComponent<AnswerScript>().startColor;
                options[i].GetComponent<AnswerScript>().isCorrect = false;
                options[i].transform.GetChild(0).GetComponent<Image>().sprite = QnA[currentQuestion].Answers[i];

                if (QnA[currentQuestion].CorrectAnswer == i + 1)
                {
                    options[i].GetComponent<AnswerScript>().isCorrect = true;
                }
            }
        }

        void SpeakingQuestion(string str)
        {
            character.GetComponent<Character>().CharacterSpeaking(str);
        }

        public void SpeakingResult(bool correct)
        {
            //character.GetComponent<Character>().CharacterStopSpeaking();
            if (correct)
                character.GetComponent<Character>().CharacterSpeaking("맞았어");
            else
                character.GetComponent<Character>().CharacterSpeaking("틀렸어 다시 한 번 골라볼래?");
        }

        public void correct()
        {
            score += 1;
            QnA.RemoveAt(currentQuestion);
            makeQuestion();
            //StartCoroutine(waitForNext());
        }

        public void wrong()
        {

            //QnA.RemoveAt(currentQuestion);
            //makeQuestion();
            //StartCoroutine(waitForNext());
        }

        void GameOver()
        {
            QuizPanel.SetActive(false);
            GoPanel.SetActive(true);
            ScoreText.text = score + "개 맞았습니다.";
        }

        public void retry()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


        //IEnuerator waitForNext()
        //{
        //    yield return new waitForNext(1);
        //    makeQuestion();
        //}

    }
}