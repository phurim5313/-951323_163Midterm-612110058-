﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ch08_nonPBR")
        {
            Destroy(gameObject);
            Debug.Log("coli");
            Score.score += 1000;

        }
    }
}
