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
    public GameObject enemy;
    public int damage;

    private void Start()
    {
        makeQuestion();
        
    }
    
    public void Update()
    {
        enemy = GameObject.FindWithTag("Enemy");
    }
    public void correct()
    {
        doDamage();
        makeQuestion();
    }

    public void wrong()
    {
        player.damage(3);
        makeQuestion();
    }

    public void doDamage()
    {
        damage = player.strength;
        enemy.GetComponent<Enemy>().damage(damage);
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
