using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    string String = "Hello";
    int var = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string Stringtwo = "World";
        Debug.Log(String + Stringtwo);
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(var);
        var++;
    }
}
