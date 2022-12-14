using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public List<QAndA> QnA1; // simple math
    public List<QAndA> QnA2; // Algebra
    public List<QAndA> QnA3; // Geometry
    public List<QAndA> QnA4; // Calc
    public GameObject[] options;
    public int currentQuestion;
    public TextMeshProUGUI QuestionTxt;
    public GameObject player;
    public GameObject enemy;
    public int damage;
    public int enemyDamage;
    public int questionSet;
    public Animator animator; //Controlls player animation
    [SerializeField] GameObject swordSlash;
    [SerializeField] AudioSource audio1;

    private void Start()
    {
        questionSet = Random.Range(0, 3);
        makeQuestion();
        if(player == null){
        player = GameObject.FindWithTag("Player");
        }
    }
    
    public void Update()
    {
        enemy = GameObject.FindWithTag("Enemy");
        if(enemy == null) {
            enemy = GameObject.FindWithTag("boss");
        }
    }
    public void correct()
    {
        animator.SetBool("Attack", true);
        doDamage();
        makeQuestion();
        StartCoroutine(setAttackFalse());
        spawnProjectile();
        

    }

    public void wrong()
    {
        enemyDamage = enemy.GetComponent<Enemy>().returnstrength();
        player.GetComponent<Player>().damage(enemyDamage);
        makeQuestion();
    }

    public void doDamage()
    {
        damage = player.GetComponent<Player>().returnstrength();
        enemy.GetComponent<Enemy>().damage(damage);
    }
    void spawnProjectile() {
            float x = player.transform.position.x;
            float y = player.transform.position.y;


            Vector2 position = new Vector2(x + 2, y);
            GameObject new_projectile = Instantiate(swordSlash, position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(audio1.clip, transform.position);
            
    }
    IEnumerator setAttackFalse() {
            yield return new WaitForSeconds(1);
            animator.SetBool("Attack", false);
            
    }

    void setAnswers()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswersScript>().isCorrect = false;
            switch (questionSet)
            {
                case 0:
                    options[i].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = QnA1[currentQuestion].Answers[i];
                    if (QnA1[currentQuestion].CorrectAnswer == i + 1)
                    {
                        options[i].GetComponent<AnswersScript>().isCorrect = true;
                    }
                    break;
                case 1:
                    options[i].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = QnA2[currentQuestion].Answers[i];
                    if (QnA2[currentQuestion].CorrectAnswer == i + 1)
                    {
                        options[i].GetComponent<AnswersScript>().isCorrect = true;
                    }
                    break;
                case 2:
                    options[i].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = QnA3[currentQuestion].Answers[i];
                    if (QnA3[currentQuestion].CorrectAnswer == i + 1)
                    {
                        options[i].GetComponent<AnswersScript>().isCorrect = true;
                    }
                    break;
                case 3:
                    options[i].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = QnA4[currentQuestion].Answers[i];
                    if (QnA4[currentQuestion].CorrectAnswer == i + 1)
                    {
                        options[i].GetComponent<AnswersScript>().isCorrect = true;
                    }
                    break;

            }
        }
    }

    void makeQuestion()
    {
        switch (questionSet)
        {
            case 0:
                currentQuestion = Random.Range(0, QnA1.Count);
                QuestionTxt.text = QnA1[currentQuestion].Question;
                break;
            case 1:
                currentQuestion = Random.Range(0, QnA2.Count);
                QuestionTxt.text = QnA2[currentQuestion].Question;
                break;
            case 2:
                currentQuestion = Random.Range(0, QnA3.Count);
                QuestionTxt.text = QnA3[currentQuestion].Question;
                break;
            case 3:
                currentQuestion = Random.Range(0, QnA4.Count);
                QuestionTxt.text = QnA4[currentQuestion].Question;
                break;

        }
        setAnswers();
        
    }
}
