using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuWindow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    void  OnGui() {
        GUI.Label(new Rect(10, 10, 100, 20), "Hello World!");
        GUI.Button(new Rect(20, 20, 150, 30), "button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
