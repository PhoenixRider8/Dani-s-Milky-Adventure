using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karlonVibe : MonoBehaviour
{
    [SerializeField] List<GameObject> lights;
    int index;

    int timeInterval = 30;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        index = 0;
        foreach (GameObject light in lights)
        {
            light.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        time+= Time.deltaTime;
        if (time > timeInterval)
        {
            index=Random.Range(0, 4);
            turnOnLights();
        }
    }

    void turnOnLights()
    {
        foreach (GameObject light in lights)
        {
            light.SetActive(false);
        }
        lights[index].SetActive(true);
    }
}
