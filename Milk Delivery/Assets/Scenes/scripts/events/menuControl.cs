using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuControl : MonoBehaviour
{
    public void startButton()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        StartCoroutine(LoadSceneAsync());
    }

    private IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(1);
        asyncOperation.allowSceneActivation = false;  // Prevent auto activation until ready

        // Wait until the scene is loaded
        while (!asyncOperation.isDone)
        {
            if (asyncOperation.progress >= 0.9f) // Scene is almost done loading
            {
                // Optional: You can display loading UI here if needed
                asyncOperation.allowSceneActivation = true;  // Allow the scene to activate when ready
            }
            yield return null;
        }
    }


    public void quitButton()
    {
        Application.Quit();
    }
}
