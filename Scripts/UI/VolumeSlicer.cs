using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

//Handles multiple volume manipulation
public class VolumeSlicer : MonoBehaviour
{
    // create a Dictionary with a key of type int and a value of type Ray Marching script
    private Dictionary<int, RayMarching> rayMarchingDictionary = new Dictionary<int, RayMarching>();
    private Dropdown selected;

    void Start()
    {
        GameObject myObject = GameObject.Find("VolumeDropdown");
        if (myObject != null)
        {
            selected = myObject.GetComponent<Dropdown>();
            selected.onValueChanged.AddListener(delegate {
                SelectedChangedHandler(selected);
            });

            SelectedChangedHandler(selected);
        }
        // When there is no visualization window (HoloLens)
        else 
        {
            // Get all the RayMarching scripts on this GameObject
            RayMarching[] rayMarchingScripts = GetComponent<Camera>().GetComponents<RayMarching>();
            foreach (RayMarching script in rayMarchingScripts)
            {
                rayMarchingDictionary.Add(script.ScriptId, script);
            }
        }
    }

    void Destroy()
    {
        selected.onValueChanged.RemoveAllListeners();
    }

    // Finds the selected volume
    public void SelectedChangedHandler(Dropdown selected)
    {
        rayMarchingDictionary.Clear();

        // Get all the RayMarching scripts on this GameObject
        RayMarching[] rayMarchingScripts = GetComponent<Camera>().GetComponents<RayMarching>();

        // When "All" volumes are selected
        if (selected.value == 0) {
            // Loop through all RayMarching scripts and add an entry into the Dictionary
            // which allows us to store each Ray Marching script for each unique ScriptId
            foreach (RayMarching script in rayMarchingScripts)
            {
                rayMarchingDictionary.Add(script.ScriptId, script);
            }
        }
        else if (rayMarchingScripts.Length >= selected.value)
        {
            rayMarchingDictionary.Add(rayMarchingScripts[selected.value-1].ScriptId, rayMarchingScripts[selected.value-1]);
        }
        else
        {
            print("Volume doesn't exist");
        }
    }

    public void SetClipDimensionsX(float x)
    {
        foreach (KeyValuePair<int, RayMarching> script in rayMarchingDictionary)
        {
            script.Value.SetClipDimensionsX(x);
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

    public void SetOpacity(float o)
    {
        foreach (KeyValuePair<int, RayMarching> script in rayMarchingDictionary)
        {
            script.Value.SetOpacity(o);
        }
    }

    public void SetDepthBlend(float d)
    {
        foreach (KeyValuePair<int, RayMarching> script in rayMarchingDictionary)
        {
            script.Value.SetDepthBlend(d);
        }
    }

    public void SetDownScale(float d)
    {
        foreach (KeyValuePair<int, RayMarching> script in rayMarchingDictionary)
        {
            script.Value.SetDownScale((int) d);
        }
    }
}
