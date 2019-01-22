using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

    //public function for changing scenes to use from buttons
    public void ChangeToScene(string sceneName)
    {
        if (sceneName != null)
            SceneManager.LoadScene(sceneName);
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }
}
