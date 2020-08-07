using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class MoveScoreEnd : MonoBehaviour
{
    public GameObject text;
    public Text score; 
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = Vector3.Lerp(transform.position, text.transform.position + new Vector3(-35.5f, -95.5f, 0), 10);
        score.text += "/225"; 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
