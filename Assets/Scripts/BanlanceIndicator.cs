using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BanlanceIndicator : MonoBehaviour {

    public Text text;

    public void SetText(int balance)
    {
        text.text = "Balance:" + balance;

    }


}
