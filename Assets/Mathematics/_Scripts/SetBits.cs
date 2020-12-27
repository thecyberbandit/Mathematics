using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SetBits : MonoBehaviour
{
    int bitSequence = 8 + 2 + 1;

    void Start()
    {
        Debug.Log(Convert.ToString(bitSequence, 2));
    }

    void Update()
    {
        
    }
}
