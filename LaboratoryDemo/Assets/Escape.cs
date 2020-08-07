using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{
    public GameObject button;
    private Animator anim; 

    public void Start()
    {
        anim = Camera.main.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (button != null)
            {
                button.SetActive(true);
            }
            
            this.gameObject.SetActive(false);
            anim.ResetTrigger("isUsing"); 
        }
    }
}
