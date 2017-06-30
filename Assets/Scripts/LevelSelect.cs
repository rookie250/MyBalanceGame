using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour {

    public Button[] buttons;
    private string levelReach = "levelReach";

    // Use this for initialization
    void Start () {
        int lvReach = PlayerPrefs.GetInt(levelReach, 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = lvReach - 1;
            if (i <= index )
            {
                buttons[i].interactable = true;
            }
            else {
                buttons[i].interactable = false;
            }
        }
        
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetLevelReach() {
        int lvReach = PlayerPrefs.GetInt(levelReach);
        PlayerPrefs.SetInt(levelReach, 2);
    }
}
