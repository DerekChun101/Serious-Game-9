using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventChoice : MonoBehaviour
{
    public int eventVal;
    public EventManager eventManager;

    public void Choice()
    {
        switch (eventVal)
        {
            case 0:
                eventManager.healthUp();
                break;
            case 1:
                eventManager.strengthUp();
                break;
            case 2:
                eventManager.armorUp();
                break;
        }

    }
}
