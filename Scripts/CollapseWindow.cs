using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollapseWindow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void VisualizeToggle()
    {
        if (GameObject.Find("VisualizeContentToggle").GetComponent<Toggle>().isOn)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void StatisticsToggle()
    {
        if (GameObject.Find("StatisticsContentToggle").GetComponent<Toggle>().isOn)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
