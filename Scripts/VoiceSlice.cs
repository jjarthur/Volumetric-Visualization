using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoiceSlice : MonoBehaviour {

    public void Down()
    {
        gameObject.GetComponent<Slider>().value -= 5;
    }

    public void Up()
    {
        gameObject.GetComponent<Slider>().value += 5;
    }
}
