using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class Screenshot : MonoBehaviour
{
    Texture2D screenCap;
    Texture2D border;
    bool shot = false;

    // Use this for initialization
    void Start()
    {
        screenCap = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false); // 1
        border = new Texture2D(2, 2, TextureFormat.ARGB32, false); // 2
        border.Apply();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        { // 3
            StartCoroutine("Capture");
            //Capture();
        }
    }

    void OnGUI()
    {
        if (shot)
        {
            StartCoroutine(LabelTimer());
            GUI.Label(new Rect(Screen.width / 2, 10, 200, 40), "Screenshot Captured");
        }
    }
    
    IEnumerator LabelTimer()
    {
        yield return new WaitForSeconds(2);
        shot = false;
    }

    IEnumerator Capture()
    {
        yield return new WaitForEndOfFrame();
        screenCap.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        screenCap.Apply();

        // Encode texture into PNG
        byte[] bytes = screenCap.EncodeToPNG();
        //Object.Destroy(screenCap);

        string filename = fileName();
        string path = Application.dataPath + "/Screenshots/" + filename;
        File.WriteAllBytes(path, bytes);

        shot = true;
    }

    // Return file name
    string fileName()
    {
        return string.Format("screen_{0}.png", System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
    }
}