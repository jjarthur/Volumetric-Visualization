using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkerListener : MonoBehaviour {

    public void SetMarker(float value)
    {
        const int WorldPos = 200; //Accounts for relative position in world space
        
        //Get value of Z Slider from visualization window
        float newY = GameObject.Find("ZSlider").GetComponent<Slider>().value*4;
        //Set marker transform to a new vector with adjusted depth value
        gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, newY - WorldPos, gameObject.transform.localPosition.z);
    }
}
