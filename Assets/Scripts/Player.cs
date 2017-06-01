using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int balance = 50;
    public int limit = 100;
    public float updateRate = 2f; // 每隔2秒调用一次
    public float lastTime = 0f;

    public BanlanceIndicator indicator;
    public GameOver gameOver;

    // Use this for initialization

    void Start () {
        Random.InitState(System.Guid.NewGuid().GetHashCode());
	}
	
	// Update is called once per frame
	void Update () {

        float time = Time.time;
        if (time - lastTime > updateRate)  // 每隔2秒 加一个随机的力，判断
        {
            lastTime = time;
            ForceAdd();
        }

        if (balance > limit || balance < 0)
        {
            Debug.Log("game over");
            gameOver.ShowOver();
            enabled = false;

        }

        if (Input.GetKeyDown("z"))
        {
            balance -= 5;
        }

        if (Input.GetKeyDown("x"))
        {
            balance += 5;
        }
        //Debug.Log(balance);

        indicator.SetText(balance);

    }

    private void ForceAdd() {
        int random = Random.Range(-20, 20);
        balance += random;
        //Debug.Log(balance);
    }

    private void OnBecameInvisible()
    {
        gameOver.ShowOver();
        enabled = false;
    }
}
