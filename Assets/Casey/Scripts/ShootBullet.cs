using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnLocation;
    public float force;
    public float fireRate;
    private float fireCoolDown;
    private float maxFireTime;
    private bool canfire = false;

    // Start is called before the first frame update
    void Start()
    {

        calculateFireRate();

    }

    public void calculateFireRate()
    {

        maxFireTime = 1 / fireRate;

    }

    // Update is called once per frame
    void Update()
    {

        if(fireCoolDown > 0)
        {

            fireCoolDown -= Time.deltaTime;

            canfire = false;

        }
        else
        {
            canfire = true;
        }

        if (Input.GetKey(KeyCode.Space) && canfire)
        {

            fireBullet();

        }

        void fireBullet()
        {

            GameObject newBullet = Instantiate(bulletPrefab, spawnLocation.position, spawnLocation.rotation);
            Rigidbody rb = newBullet.GetComponent<Rigidbody>();

            rb.AddForce(transform.forward * force);

            fireCoolDown = maxFireTime;

        }

    }
}
