using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject[] particles = new GameObject[3];

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "RedWall")
        {
            MakeParticles();
        }
    }

    void MakeParticles()
    {
        Transform temp;
        temp = Instantiate(particles[0].transform, transform.position, Quaternion.identity);
        temp.GetComponent<Rigidbody>().AddExplosionForce(300f, transform.position + new Vector3(0f, 0f, 1f), 2f);
        Destroy(temp.gameObject, 3f);

        temp = Instantiate(particles[1].transform, transform.position, Quaternion.identity);
        temp.GetComponent<Rigidbody>().AddExplosionForce(300f, transform.position + new Vector3(0f, 0f, 1f), 2f);
        Destroy(temp.gameObject, 3f);

        temp = Instantiate(particles[2].transform, transform.position, Quaternion.identity);
        temp.GetComponent<Rigidbody>().AddExplosionForce(300f, transform.position + new Vector3(0f, 0f, 1f), 2f);
        Destroy(temp.gameObject, 3f);

        Destroy(gameObject);
    }
}
