using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    List<GameObject> bullets;
    List<Vector3> bulletDestinations;

    public GameObject bullet;

    void Start()
    {
        bullets = new List<GameObject>();
        bulletDestinations = new List<Vector3>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit = new RaycastHit();
            Vector3 point = transform.position + 100 * transform.forward;
            if (Physics.Raycast(new Ray(transform.position, transform.forward), out hit))
            {
                point = hit.point;
            }

            bullets.Add(Instantiate(bullet, transform.position, Quaternion.identity));
            bulletDestinations.Add(point);
        }

        for (int i = 0; i < bullets.Count; i++)
        {
            bullets[i].transform.position = Vector3.MoveTowards(bullets[i].transform.position, bulletDestinations[i], .2f);
        }
    }
}
