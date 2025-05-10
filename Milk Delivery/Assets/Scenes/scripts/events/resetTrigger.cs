using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetTrigger : MonoBehaviour
{
    [SerializeField] GameObject triggerEvent;
    triggerSettings trigger;

    private void Start()
    {
        trigger = triggerEvent.GetComponent<triggerSettings>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            trigger.resetScene();
        }
    }
}
