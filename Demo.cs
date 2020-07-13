using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> names = new List<string>();
        names.Add("青木");
        names.Add("井上");
        Debug.Log(" 1番目は" + names[0]);
        Debug.Log(" 2番目は" + names[1]);
        string a = names.Find(n => n == "青木");
        names.Remove(names.Find(n => n == "青木"));
        Debug.Log(names[0]);
        names.Find(n => n == "");
        bool hhh = names.Contains("");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
