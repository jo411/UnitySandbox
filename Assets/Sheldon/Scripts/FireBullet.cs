using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sheldon
{
    public class FireBullet : MonoBehaviour
    {

        public GameObject bullet;
        public Transform bulletSpawnLociation;
        public float force;
        public float fireRate;
        private float fireCoolDown;
        private float maxFireTime;

        // Start is called before the first frame update
        void Start()
        {
            calculateFireRate();
        }

        public void OnValidate()
        {
            calculateFireRate();
            fireCoolDown = 0;
        }

        public void calculateFireRate()
        {
            maxFireTime = 1 / fireRate;
        }

        // Update is called once per frame
        void Update()
        {
            float shoot = Input.GetAxis("Fire1");

            if (fireCoolDown >= 0)
            {
                fireCoolDown -= Time.deltaTime;
            }

            if (fireCoolDown < 0 && shoot > 0)
            {
                shootBullet();
                fireCoolDown = maxFireTime;
            }
        }

        void shootBullet()
        {
            GameObject newBullet = Instantiate(bullet, bulletSpawnLociation.position, bulletSpawnLociation.rotation);
            Rigidbody rb = newBullet.GetComponent<Rigidbody>();
            Vector3 bulletForce = transform.forward * force;
            rb.AddForce(bulletForce);
        }
    }
}

