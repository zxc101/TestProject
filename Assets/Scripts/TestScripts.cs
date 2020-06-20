using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class TestScripts : SerializedMonoBehaviour
{
    public Dictionary<string, int> list;

    void Start()
    {
        foreach(var pair in list)
        {
            Debug.Log(pair.Key + ": " + pair.Value);
        }
    }
}
