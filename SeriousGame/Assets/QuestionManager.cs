using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public List<QAndA> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public TextMeshProUGUI QuestionTxt;
    public Player player;

    private void Start()
    {
        makeQuestion();
    }
    
    public void correct()
    {
        makeQuestion();
    }

    public void wrong()
    {
        player.damage(3);
        makeQuestion();
    }

    void setAnswers()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswersScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];
            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswersScript>().isCorrect = true;
            }
        }
    }

    void makeQuestion()
    {
        currentQuestion = Random.Range(0, QnA.Count);
        QuestionTxt.text = QnA[currentQuestion].Question;
        setAnswers();
        
    }
}
