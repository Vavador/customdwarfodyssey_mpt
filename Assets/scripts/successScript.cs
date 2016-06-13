using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class successScript : MonoBehaviour {

    public int globalScoreFINAL;
    public Text scoreTEXT;




    // Use this for initialization
    void Start () {
        globalScoreFINAL = PlayerPrefs.GetInt("FINALglobalScore");
        Debug.Log(globalScoreFINAL);
        scoreTEXT.text = globalScoreFINAL.ToString();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
