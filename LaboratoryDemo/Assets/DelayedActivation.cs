using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedActivation : MonoBehaviour
{
    public GameObject gameobject;
    public int waitTime; 

    public void Start()
    {
        DelayNextActivation(gameobject); 
    }
    public void DelayNextActivation(GameObject gameobject)
    {
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(waitTime);
        gameobject.SetActive(true);
    }
}
