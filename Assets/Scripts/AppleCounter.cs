using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(TextWriter))]
public class AppleCounter : MonoBehaviour
{
    private int applesDestroyed = 0;
    private TextWriter textWriter;
    void Start()
    {
        textWriter = GetComponent<TextWriter>();
        BasketDestroyApples.onAppleCatched += AppleWasDestroyed;
    }

    void AppleWasDestroyed()
    {
        applesDestroyed++;
        textWriter.Write(applesDestroyed.ToString());
    }
}
