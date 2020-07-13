using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SE : MonoBehaviour
{
    public AudioClip SE1;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            GetComponent<AudioSource>().PlayOneShot(SE1);
    }
}
