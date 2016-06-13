using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class coroutineScript : MonoBehaviour {

    public float timeLeft = 10.0f;
    public GameObject gameOverPanel;
    public Text gameOverText;

    // Use this for initialization
    void Start ()
    {
        gameOverPanel.SetActive(false); 
    }
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            GameOver();
        }
    }

   
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        gameOverText.text = "Game Over!";
    }
}
