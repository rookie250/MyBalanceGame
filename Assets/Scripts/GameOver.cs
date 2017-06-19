using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets._2D;

public class GameOver : MonoBehaviour {
    private Animator animator;
    public Text text;
    public Button button;
    public string lvlName = "Level2";
    public Platformer2DUserControl player;
    public GameObject menu;

    // Use this for initialization
    private void Awake() // 适合加载资源的时候使用
    {
        animator = GetComponent<Animator>();
        menu.active = false;
        button.onClick.AddListener(ButtonDidAction);
    }

    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void ShowOver() {
        animator.SetTrigger("GameOver");
    }

    public void ShowWin() {
        animator.SetTrigger("Win");
        player.enabled = false;
    }

    private void ButtonDidAction()
    {
        SceneManager.LoadScene(lvlName);
        Debug.Log("buttonDidAction");
    }
}
