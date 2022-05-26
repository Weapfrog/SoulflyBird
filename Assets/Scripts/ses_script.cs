using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses_script : MonoBehaviour
{
    AudioSource aSource;
    public bird_script bird;
    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && bird.dead == false)
        {
            aSource.Play();
        }
    }
}
