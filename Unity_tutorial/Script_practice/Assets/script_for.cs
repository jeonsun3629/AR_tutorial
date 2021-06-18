using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_for : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i+=2)
        {
            Debug.Log(i);
        }

        for (int i = 3; i >= 0 ; i--)
        {
            Debug.Log(i);
        }
    }

}
