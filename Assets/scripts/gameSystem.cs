using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameSystem : MonoBehaviour {
    public Button startButton;
    public Button creditButton;

    // Ne pas oublier de rajouter la fenêtre de sélection des nains.
    public Canvas chooseDwarf;

    // Use this for initialization
    void Start () {


        
      
    }

	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
