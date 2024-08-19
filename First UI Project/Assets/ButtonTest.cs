using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public Slider slider;

    public void DoSomething() {
        Debug.Log(slider.value.ToString());
    }

    public void DoSomethingWithASlider(Slider slider) {
        Debug.Log(slider.value.ToString());
    }
}
