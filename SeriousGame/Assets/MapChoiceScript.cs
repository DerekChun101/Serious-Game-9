using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MapChoiceScript : MonoBehaviour
{
    string node;
    char subNode;
    int nodePos;
    public void nodeChoice()
    {
        node = EventSystem.current.currentSelectedGameObject.name;
        subNode = node[node.Length - 2];
        nodePos = subNode - '0';
        if (nodePos == PlayerData.Instance.getDepth())
        {
            subNode = node[node.Length - 1];
            nodePos = subNode - '0';
            if (nodePos == PlayerData.Instance.getOpen1() || nodePos == PlayerData.Instance.getOpen2() || node[node.Length - 2] == '5')
            {
                nodeType();
            }
        }
        
    }
    public void nodeCombat()
    {
        SceneManager.LoadScene("Combat");
    }

    public void nodeEvent()
    {
        SceneManager.LoadScene("Event");
    }

    public void nodeType()
    { 
        switch (PlayerData.Instance.getDepth())
        {
            case 0:
                PlayerData.Instance.setVisited(13);
                PlayerData.Instance.setOpen1(1);
                PlayerData.Instance.setOpen2(2);
                break;
            case 1:
                if (subNode == '1')
                {
                    PlayerData.Instance.setVisited(0);
                    PlayerData.Instance.setOpen1(1);
                    PlayerData.Instance.setOpen2(2);
                }
                else
                {
                    PlayerData.Instance.setVisited(1);
                    PlayerData.Instance.setOpen1(2);
                    PlayerData.Instance.setOpen2(3);
                }
                break;
            case 2:
                if (subNode == '1')
                {
                    PlayerData.Instance.setVisited(2);
                    PlayerData.Instance.setOpen1(1);
                    PlayerData.Instance.setOpen2(-1);
                }
                else if (subNode == '3')
                {
                    PlayerData.Instance.setVisited(4);
                    PlayerData.Instance.setOpen1(-1);
                    PlayerData.Instance.setOpen2(2);
                }
                else
                {
                    PlayerData.Instance.setVisited(3);
                    PlayerData.Instance.setOpen1(1);
                    PlayerData.Instance.setOpen2(2);
                }
                break;
            case 3:
                PlayerData.Instance.setOpen1(1);
                PlayerData.Instance.setOpen2(-1);
                if(subNode == '1')
                {
                    PlayerData.Instance.setVisited(5);
                } else
                {
                    PlayerData.Instance.setVisited(6);
                }
                break;
            case 4:
                PlayerData.Instance.setVisited(14);
                PlayerData.Instance.setOpen1(nodePos);
                break;
            case 5:
                if(subNode == '1')
                {
                    PlayerData.Instance.setVisited(7);
                } else if (subNode == '2')
                {
                    PlayerData.Instance.setVisited(8);
                } else
                {
                    PlayerData.Instance.setVisited(9);
                }
                PlayerData.Instance.setOpen1(nodePos);
                break;
            case 6:
                if (subNode == '1')
                {
                    PlayerData.Instance.setVisited(10);
                }
                else if (subNode == '2')
                {
                    PlayerData.Instance.setVisited(11);
                }
                else
                {
                    PlayerData.Instance.setVisited(12);
                }
                PlayerData.Instance.setOpen1(1);
                break;
            default:
                break;
        }
        PlayerData.Instance.setDepth();
        switch (GetComponent<NodeTypeScript>().typeOfNode)
        {
            case 0:
                nodeCombat();
                break;
            case 4:
            case 2:
                nodeEvent();
                break;
            default:
                nodeCombat();
                break;
        }
        //nodeCombat();
    }
}
