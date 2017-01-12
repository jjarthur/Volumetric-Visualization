using UnityEngine;
using System.Collections.Generic;

public class VolumeSlicer : MonoBehaviour
{
    // create a Dictionary with a key of type int and a value of type Ray Marching script
    public Dictionary<int, RayMarching> rayMarchingDictionary = new Dictionary<int, RayMarching>();

    void Start()
    {
        // Get all the RayMarching scripts on this GameObject
        RayMarching[] rayMarchingScripts = GetComponent<Camera>().GetComponents<RayMarching>();
        // Loop through all RayMarching scripts and add an entry into the Dictionary
        // which allows us to store each Ray Marching script for each unique ScriptId
        foreach (RayMarching script in rayMarchingScripts)
        {
            rayMarchingDictionary.Add(script.ScriptId, script);
        }
    }

    public void SetClipDimensionsX(float x)
    {
        foreach (KeyValuePair<int, RayMarching> script in rayMarchingDictionary)
        {
            script.Value.SetClipDimensionsX(x);
            print("test test");
        }
    }

    public void SetClipDimensionsY(float y)
    {
        foreach (KeyValuePair<int, RayMarching> script in rayMarchingDictionary)
        {
            script.Value.SetClipDimensionsY(y);
        }
    }

    public void SetClipDimensionsZ(float z)
    {
        foreach (KeyValuePair<int, RayMarching> script in rayMarchingDictionary)
        {
            script.Value.SetClipDimensionsZ(z);
        }
    }
}
