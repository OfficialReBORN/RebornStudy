using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Click _click;
    void Start()
    {
        _click = GameObject.Find("Scripts").GetComponent<Click>();
    }

    void Update()
    {
        // クリックされたら色を変更
        if (Input.GetMouseButtonDown(0) && _click.WhatClicked() == gameObject)
        {
            byte r = (byte)Random.Range(0, 256);
            byte g = (byte)Random.Range(0, 256);
            byte b = (byte)Random.Range(0, 256);
            GetComponent<Renderer>().material.color = new Color32(r,g,b,255);
        }
    }
}