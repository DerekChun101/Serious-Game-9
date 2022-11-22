using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    public GameObject[] option;
    public List<EventOption> eventTypes;
    int x;
    // Start is called before the first frame update
    void Start()
    {
        makeEvent();
    }

    // Update is called once per frame
    public void makeEvent()
    {
        for(int i = 0; i < option.Length; i++)
        {
            x = Random.Range(0, eventTypes.Count);
            option[i].GetComponent<EventChoice>().eventVal = x;
            option[i].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = eventTypes[x].eventText;
        }
    }

    public void healthUp()
    {
        PlayerData.Instance.setHealth(PlayerData.Instance.getHealth() + 1);
        SceneManager.LoadScene("Map");
    }

    public void strengthUp()
    {
        PlayerData.Instance.setStrength(PlayerData.Instance.getStrength() + 1);
        SceneManager.LoadScene("Map");
    }

    public void armorUp()
    {
        PlayerData.Instance.setArmor(PlayerData.Instance.getArmor() + 1);
        SceneManager.LoadScene("Map");
    }
}
