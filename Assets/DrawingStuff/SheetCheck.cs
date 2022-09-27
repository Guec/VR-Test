using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheetCheck : MonoBehaviour
{
    private int correct;

    private void OnCollisionEnter(Collision other)
    {
        //if is whiteboard
        if (other.transform.CompareTag("Whiteboard"))
        {
            if (other.gameObject.name == "ContractSheet")
            {
                print("Correct");
                bool _drawn = other.gameObject.GetComponent<Whiteboard>().drawn;

                //if is signed
                if (_drawn)
                {
                    print("signed doc");
                    //play sound
                    Questionaire();
                }
            }

            if (other.gameObject.name == "A1")
            {
                if (other.gameObject.GetComponent<Whiteboard>().drawn)
                { correct++; }
            }
            if (other.gameObject.name == "B2")
            {
                if (other.gameObject.GetComponent<Whiteboard>().drawn)
                { correct++; }
            }
            if (other.gameObject.name == "C1")
            {
                if (other.gameObject.GetComponent<Whiteboard>().drawn)
                { correct++; }
            }
            if (correct == 3)
            { IQTest(); }
        }

        if (!other.transform.CompareTag("Whiteboard"))
        {
            print("Sorry please try again");
        }
    }
        
    private void Questionaire()
    {
        //explain what to do
        print("questionaire");
    }

     private void IQTest()
    {
        //tic tac toe
        print("IQTest");
    }
}
