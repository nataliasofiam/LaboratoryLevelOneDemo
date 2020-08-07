using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class NextChatBubble : MonoBehaviour
{
    
    public GameObject contentUI;
    public GameObject bubblePrefab; 
    public Text chatText; 


    public void SendQuestion(string text)
    {
        chatText = bubblePrefab.GetComponentInChildren<Text>();
        chatText.text = text;
        Instantiate(bubblePrefab, contentUI.transform);
     
    }
}
