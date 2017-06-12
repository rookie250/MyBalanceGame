using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    private Animator animator;
    public Text text;
    public Button button;

    // Use this for initialization
    private void Awake() // 适合加载资源的时候使用
    {
        animator = GetComponent<Animator>();
 
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
    }

    private void ButtonDidAction()
    {
        SceneManager.LoadScene("Level2");
        Debug.Log("buttonDidAction");
    }
}
