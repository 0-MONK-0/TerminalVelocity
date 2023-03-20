using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderText : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Slider>().value = gameObject.GetComponent<Slider>().value; //change this to get the value from saved values
    }
    public void showSliderValue(Text textObj)
    {
        textObj.text = gameObject.GetComponent<Slider>().value.ToString();
    }
}
