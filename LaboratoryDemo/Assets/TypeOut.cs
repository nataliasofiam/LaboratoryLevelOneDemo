using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TypeOut : MonoBehaviour
{
    public Text textObject; 

    public void Type(string sentence)
    {
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        textObject.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            textObject.text += letter;
            yield return null; 
        }

    }
}
