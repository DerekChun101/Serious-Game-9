using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChoiceScript : MonoBehaviour
{

    public void nodeChoice()
    {
        nodeCombat();
    }
    public void nodeCombat()
    {
        SceneManager.LoadScene("Combat");
    }
}
