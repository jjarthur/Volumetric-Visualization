using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollapseWindow : MonoBehaviour {

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

    public void SliceMapToggle()
    {
        if (GameObject.Find("SliceMapContentToggle").GetComponent<Toggle>().isOn)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
