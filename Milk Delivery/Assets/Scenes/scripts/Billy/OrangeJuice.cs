using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeJuice : MonoBehaviour
{
    GameObject player;
    Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        playerPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, 30 * Time.deltaTime);   
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            print("Player hurt");

            //Destroy(gameObject);
        }
    }
}
