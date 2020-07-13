using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayClick : MonoBehaviour
{
    public GameObject WhatClicked()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(ray, out hit)) return hit.collider.gameObject;
        return null;
    }
}