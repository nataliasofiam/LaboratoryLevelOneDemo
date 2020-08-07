using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedInstantiate : MonoBehaviour
{
    public GameObject gameobject;
    public int waitTime;
    public GameObject contentUI;
    public GameObject[] currentButtons;
    public GameObject[] nextButtons; 

    public void Start()
    {
        DelayInstantiate(gameobject);
    }
    public void DelayInstantiate(GameObject gameobject)
    {
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(gameobject, contentUI.transform);

        foreach (GameObject button in currentButtons)
        {
            Destroy(button); 
        }

        foreach (GameObject button in nextButtons)
        {
            button.SetActive(true);
        }
    }
}
