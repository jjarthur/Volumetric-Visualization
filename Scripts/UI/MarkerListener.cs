using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkerListener : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void SetMarker(float value)
    {

        print(GameObject.Find("ZSlider").GetComponent<Slider>().value);
        float newY = GameObject.Find("ZSlider").GetComponent<Slider>().value*4;

        Vector3 markerPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + newY, gameObject.transform.position.z);

        gameObject.transform.position = markerPos;
    }
}
