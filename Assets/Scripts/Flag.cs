using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour {
    public GameObject hud;
    // Use this for initialization
    private void Awake()
    {
    }

    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameOver gameOver = hud.GetComponent<GameOver>();
            gameOver.ShowWin();

        }
    }

      

}
