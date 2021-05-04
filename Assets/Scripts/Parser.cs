using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
[RequireComponent(typeof(ParserAssign))]
public class Parser : MonoBehaviour
{
    public Dictionary<string,float> parameters;
    void Start()
    {
        using (StreamReader sr = new StreamReader("Params.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                var tempLine = line.Split(' ');
                if(tempLine.Length == 2)
                {
                    float a;
                    if (float.TryParse(tempLine[1], out a))
                    {
                        parameters.Add(tempLine[0], a);
                    }
                }
            }
        }

    }
}
