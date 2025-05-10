using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillyFacing : MonoBehaviour
{
    [SerializeField] GameObject lookObj;
    [SerializeField] GameObject player;
    [SerializeField] GameObject billy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = lookObj.transform.rotation;    
        lookObj.transform.LookAt(player.transform.position);
    }
}
