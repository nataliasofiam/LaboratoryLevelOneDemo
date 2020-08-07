using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAwake : MonoBehaviour
{
    public GameObject[] toActivate; 
    void Start()
    {
        foreach (GameObject gameobj in toActivate)
        {
            gameobj.SetActive(true); 
        }
    }

}
