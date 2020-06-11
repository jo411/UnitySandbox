using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnLocation;
    public float force;
    public float fireRate;
    private float fireCooldown;
    private float maxFireTime;
    private bool canFire = false;
    


    // Start is called before the first frame update
    void Start()
    {
        calculateFireRate();        
    }

    public void calculateFireRate()
    {
        maxFireTime = 1 / fireRate;
    }
    public void OnValidate()
    {
        calculateFireRate();
    }
    // Update is called once per frame
    void Update()
    {   

        if(fireCooldown>0)
        {
            fireCooldown -= Time.deltaTime;
            canFire = false;
        }else
        {
            canFire = true;
        }

        if(Input.GetKey(KeyCode.Space) && canFire)
        {
            fireBullet();
        }
    }

    void fireBullet()
    {
        GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnLocation.position, bulletSpawnLocation.rotation);
        Rigidbody rb = newBullet.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force);

        fireCooldown = maxFireTime;
    }

}
