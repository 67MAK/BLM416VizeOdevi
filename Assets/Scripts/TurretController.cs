using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    
    public GameObject turretHead;
    public GameObject turretMuzzle;
    public GameObject bullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    public void LeftButton()
    {
        turretHead.gameObject.transform.Rotate(0f, -3.65f, 0f, Space.Self);
    }
    public void RightButton()
    {
        turretHead.gameObject.transform.Rotate(0f, 3.65f, 0f, Space.Self);
    }
    void Fire()
    {
        Transform temp;
        temp = Instantiate(bullet.transform, turretMuzzle.transform.position, Quaternion.identity);
        temp.GetComponent<Rigidbody>().AddForce(turretMuzzle.transform.forward * 2000f);
    }
}
