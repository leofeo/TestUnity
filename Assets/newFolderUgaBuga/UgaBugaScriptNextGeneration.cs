using System.Collections.Generic;
using UnityEngine;

public class UgaBugaScriptNextGeneration : MonoBehaviour
{
    private string gmo;
    private List<int> _arr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _arr = new List<int>();
        for(int i =0; i < 10; i++)
            _arr.Add(i);

        foreach(int arr in _arr)
            gmo += $"- это цифра {arr}";

        Debug.Log(gmo);
    }

    // Update is called once per frame
    void Update()
    {       
        
    }
}
