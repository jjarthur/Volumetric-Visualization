using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Sets the values inside the Visualization Statistics window

public class SetValueText : MonoBehaviour {

    public void SetValue(float value)
    {
        double newValue = Math.Round(Convert.ToDouble(value), 2);

        //If this object is DownscaleValueText
        if (gameObject.name.Equals("DownscaleValueText"))
        {
            //Add multiplier
            gameObject.GetComponent<Text>().text = newValue.ToString() + "X";
        }
        //If this object is OpacityValueText
        else if (gameObject.name.Equals("OpacityValueText"))
        {
            //Convert to percentage
            newValue *= 100;
            gameObject.GetComponent<Text>().text = newValue.ToString() + "%";
        }
        //If this object is DepthBlendValueText
        else if (gameObject.name.Equals("DepthBlendValueText"))
        {
            //Convert to percentage
            newValue *= 50;
            gameObject.GetComponent<Text>().text = newValue.ToString() + "%";
        }
        //If this object is X, Y or Z slice coordinate
        else
        {
            gameObject.GetComponent<Text>().text = newValue.ToString();
        }
    }
}
