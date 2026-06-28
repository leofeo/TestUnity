using System.Collections.Generic;
using UnityEngine;

public class UgaBugaScriptNextGeneration : MonoBehaviour
{
    private string gmo2;
    private List<int> _arr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _arr = new List<int>();
        for(int i =0; i < 10; i++)
            _arr.Add(i);

        foreach(int arr in _arr)
            gmo2 += $"- это цифра {arr}";

        Debug.Log(gmo2);
    }

    // Update is called once per frame
    void Update()
    {       
        
    }
}
