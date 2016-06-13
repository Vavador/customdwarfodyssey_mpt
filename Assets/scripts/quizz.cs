using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class quizz : MonoBehaviour {

    public Text question1;
    public GameObject reponse1a;
    public GameObject reponse1b;
    public GameObject reponse1c;

    public Text question2;
    public GameObject reponse2a;
    public GameObject reponse2b;
    public GameObject reponse2c;

    public Text question3;
    public GameObject reponse3a;
    public GameObject reponse3b;
    public GameObject reponse3c;

    public GameObject nextToQuestion2;
    public GameObject nextToQuestion3;
    public GameObject nextToFinal;

    public GameObject panelSuccess;
    public GameObject panelFail;
    public float timeLeft = 2.0f;
    public int score;
    public Text scoreText;

    public Text scoreSuccess;

    public int globalScorePassed;

    // Use this for initialization

    void Start()
    {
        globalScorePassed = PlayerPrefs.GetInt("globalScore");
        Debug.Log("Score : " + globalScorePassed);
        panelSuccess.SetActive(false);
        panelFail.SetActive(false);
     
        PremiereQuestion();

    }

    public void PremiereQuestion()
    {
        question1.text = "De quel nain géant vient cette citation : \"You shall not pass !\" ?";
      
    }
    public void BonneReponse()
    {
        panelSuccess.SetActive(true);
        score = score + 1;
        scoreText.text = score.ToString();
    }

    public void MauvaiseReponse()
    {
        panelFail.SetActive(true);
        scoreText.text = score.ToString();
    }

    public void PasserQuestion2()
    {
        panelSuccess.SetActive(false);
        panelFail.SetActive(false);
        nextToQuestion2.SetActive(false);
       

        question1.text = "";
        reponse1a.SetActive(false);
        reponse1b.SetActive(false);
        reponse1c.SetActive(false);

        question2.text = "Qu'est-ce que le 49.3 ?";

        nextToQuestion3.SetActive(true);
      
    }

    public void PasserQuestion3()
    {
        panelSuccess.SetActive(false);
        panelFail.SetActive(false);
        question2.text = "";
        question3.text = "Que ferais-tu si tu étais Miss ?";
        nextToQuestion3.SetActive(false);

        reponse2a.SetActive(false);
        reponse2b.SetActive(false);
        reponse2c.SetActive(false);

    }
    public void PasserToFinal(string sceneName)
    {
        nextToFinal.SetActive(false);

        if (globalScorePassed >= 250)
        {
            PlayerPrefs.SetInt("FINALglobalScore", globalScorePassed);
            SceneManager.LoadScene("successScene");
        }
        if (globalScorePassed < 250)
        {
            PlayerPrefs.SetInt("FINALglobalScore", globalScorePassed);
            SceneManager.LoadScene("failScene");
        }
      
        //PANEL

    }
    // Update is called once per frame
    void Update()
    {

    }
}