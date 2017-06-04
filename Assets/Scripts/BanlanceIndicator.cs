using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BanlanceIndicator : MonoBehaviour {

    public Slider slider;
    private float mVio = 0.0f;
    public float mySmoothTime = 0.2f;

    private void Update()
    {
        float balance = Player.balance;
        float rate = balance / 100;
        float smooth = Mathf.SmoothDamp(slider.value, rate, ref mVio, mySmoothTime);
        slider.value = smooth;
    }


}
