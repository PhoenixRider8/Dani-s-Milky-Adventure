using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class daniHealth : MonoBehaviour
{
    public List<GameObject> heartList;
    int health;
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(health==0)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void updateHealth()
    {
        heartList.Remove(heartList[health]);
        health -= 1;
    }
}
