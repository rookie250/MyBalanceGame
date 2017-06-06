using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    private Animator animator;
    public Text text;
    public Button button;

    // Use this for initialization
    private void Awake() // 适合加载资源的时候使用
    {
        animator = GetComponent<Animator>();
       
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowOver() {
        animator.SetTrigger("GameOver");
    }

    public void ShowWin() {
        Debug.Log("Show Win");
        animator.SetTrigger("Win");  
    }
}
