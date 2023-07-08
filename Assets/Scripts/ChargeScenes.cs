using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChargeScenes : MonoBehaviour
{
    public void LoadSceneString(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
