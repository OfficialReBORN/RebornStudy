using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject WhatClicked()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(ray, out hit)) return hit.collider.gameObject;
        return null;
    }
}
