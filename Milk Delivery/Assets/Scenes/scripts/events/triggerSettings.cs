using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerSettings : MonoBehaviour
{
    

    public void resetScene()
    {
        SceneManager.LoadScene(1);
    }

    public void nextScene()
    {
        SceneManager.LoadScene(2);
    }
}
