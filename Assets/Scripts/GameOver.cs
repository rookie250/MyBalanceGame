using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    private Animator animator;

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
}
