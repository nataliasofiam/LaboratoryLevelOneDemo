using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class NoteTaking : MonoBehaviour
{
    public Text patientNotes;
    public Text researchNotes; 

    public void AddPatientNote(string note)
    {
        patientNotes.text += "\n" + note; 
    }

    public void AddResearchNotes(string note)
    {
        researchNotes.text += "\n" + note; 
    }
}
