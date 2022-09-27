using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTakToe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Prep();
    }

    private void Prep()
    {
        int squares = transform.childCount;
        for (int i = 0; i < squares; ++i)
            print("for loop:" + transform.GetChild(i));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
