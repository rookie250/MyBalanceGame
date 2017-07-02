﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets._2D;
using UnityEngine.Advertisements;

public class GameOver : MonoBehaviour {
    private Animator animator;
    public Text text;
    public Button button;
    public string lvlName = "Level2";
    public Platformer2DUserControl player;
    public Button menuButton;
    public GameObject menu;
    public Button confirmButton;
    public Toggle muteToggle;
    public Slider slider;

    // Use this for initialization
    private void Awake() // 适合加载资源的时候使用
    {
        animator = GetComponent<Animator>();
        menu.SetActive(false);
      
        button.onClick.AddListener(ButtonDidAction);
        menuButton.onClick.AddListener(MenuButtonDidAction);
        confirmButton.onClick.AddListener(ConfirmButtonDidAction);
    }

    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (muteToggle.isOn == false) // 如果没有勾选，说明不是静音
        {                            
            AudioListener.volume = 1f; // 设置为最大音量
            AudioListener.volume = slider.value; // 设置slider的值
        }
        else
        {
            AudioListener.volume = 0f;
        }
    }

    public void ShowOver() {
        animator.SetTrigger("GameOver");
    }

    public void ShowWin() {
        animator.SetTrigger("Win");
        //player.enabled = false;
        //menuButton.enabled = false;
        ShowAds();

        
    }

    private void ButtonDidAction()
    {
        SceneManager.LoadScene(lvlName);
        Debug.Log("buttonDidAction");
    }

    private void MenuButtonDidAction() {
        menu.SetActive(true);
        Time.timeScale = 0;

    }

    private void ConfirmButtonDidAction() {
        menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void ShowAds() {
        ShowOptions options = new ShowOptions { resultCallback = AdsResult };
        Advertisement.Show("video", options);
    }

    private void AdsResult(ShowResult  result) {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                //
                // YOUR CODE TO REWARD THE GAMER
                // Give coins etc.
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }

}
