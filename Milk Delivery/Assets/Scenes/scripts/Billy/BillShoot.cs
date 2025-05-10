using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillShoot : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Animator anim;

    [SerializeField] GameObject orange;
    public float spawnRate = 0.5f;
    private float timer = 0f;

    bool isShoot;
    [SerializeField] Transform fieldVision;
    // Start is called before the first frame update
    void Start()
    {
        isShoot = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isShoot)
        {
            isShoot = false;
            anim.SetBool("shoot", false);
        }

        if(isShoot)
        {
            timer += Time.deltaTime;
            if (timer >= spawnRate)
            {
                GameObject or = Instantiate(orange, fieldVision.position, Quaternion.identity,transform.GetChild(3));

                timer = 0f;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isShoot = true;
            anim.SetBool("shoot", true);
        }
    }

 

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(5);
    }
}
