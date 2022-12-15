using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswersScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuestionManager questionManager;
    

    public void Answer()
    {
        if (isCorrect)
        {
            //Debug.Log("Correct");
            questionManager.correct();
            
        } else
        {
            //Debug.Log("Wrong");
            questionManager.wrong();
        }
    }
}
