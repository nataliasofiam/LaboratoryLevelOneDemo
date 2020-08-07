using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TypeOnAwake : MonoBehaviour
{
    public Text textObject;
    public string newSentence; 

    public void Start()
    {
        Type(newSentence); 
    }
    public void Type(string sentence)
    {
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        textObject.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            textObject.text += letter;
            yield return null;
        }

    }
}
