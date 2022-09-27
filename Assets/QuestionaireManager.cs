using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionaireManager : MonoBehaviour
{
    public GameObject A1;
    public GameObject B2;
    public GameObject C1;
    public int correct;


    // Update is called once per frame
    public void Check()
    {
        if (A1.gameObject.GetComponent<Whiteboard>().drawn)
        {
            correct++;
        }

        if (B2.gameObject.GetComponent<Whiteboard>().drawn)
        {
            correct++;
        }
           
        if (C1.gameObject.GetComponent<Whiteboard>().drawn)
        {
            correct++;
        }
    }   
}
