using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Score : MonoBehaviour
{
    public Text score;

    public void Start()
    {
        score.text = 0.ToString(); 
    }

    //private void Update()
    //{
    //    if (Input.anyKeyDown)
    //    {
    //        AddFiftyPoints();
    //    }
    //}
    public void AddFiftyPoints()
    {
       int scoreInt =  int.Parse(score.text);
        scoreInt += 50; 
        score.text = scoreInt.ToString(); 
    }

    public void AddTwentyFivePoints()
    {
        int scoreInt = int.Parse(score.text);
        scoreInt += 25;
        score.text = scoreInt.ToString();
    }
}
