using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    public List<NodeType> nodeTypes;
    public TextMeshProUGUI nodeTxt;
    public int currentNode;
    public int nodeVal;
    public GameObject[] option;
    public int[] nodes = new int[13];
    public bool[] visited = new bool[15];
    Button myButton;
    // Start is called before the first frame update
    void Start()
    {
        populateNodes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void populateNodes()
    {
        if (!PlayerData.Instance.getSet())
        {
            PlayerData.Instance.setNodeTrue();
            for (int i = 0; i < option.Length - 3; i++)
            {
                currentNode = Random.Range(0, 11);
                if (currentNode <= 4)
                {
                    nodeTxt.text = nodeTypes[1].nodeName;
                    nodeVal = 0;
                }
                else if (currentNode >= 7)
                {
                    nodeTxt.text = nodeTypes[3].nodeName;
                    nodeVal = 2;
                }
                else
                {
                    nodeTxt.text = nodeTypes[2].nodeName;
                    nodeVal = 1;
                }
                PlayerData.Instance.setNode(nodeVal, i);
                setNode(i);
            }
        } else
        {
            nodes = PlayerData.Instance.getNode();
            for(int i = 0; i < option.Length - 3; i++)
            {
                nodeVal = nodes[i];
                setNode(i);
            }
            visited = PlayerData.Instance.getVisited();
            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i])
                {
                    option[i].GetComponent<Button>().interactable = false;
                }
            }
        }
        option[option.Length - 3].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = nodeTypes[0].nodeName; // Start node
        option[option.Length - 2].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = nodeTypes[4].nodeName; // Special event node
        option[option.Length - 1].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = nodeTypes[3].nodeName; // Boss node
        option[option.Length - 3].GetComponent<NodeTypeScript>().typeOfNode = 0;
        option[option.Length - 2].GetComponent<NodeTypeScript>().typeOfNode = 4;
        option[option.Length - 1].GetComponent<NodeTypeScript>().typeOfNode = 3;
    }
    void setNode(int x)
    {
        {
            option[x].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = nodeTypes[nodeVal].nodeName;
            option[x].GetComponent<NodeTypeScript>().typeOfNode = nodeVal;
        }
    }
}
