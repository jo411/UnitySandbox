using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{    
    public float moveSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxisRaw("Horizontal");
        float vAxis = Input.GetAxisRaw("Vertical");
        Vector3 movement = Vector3.zero;

        if(hAxis!=0)
        {
            movement.x = Time.deltaTime * moveSpeed * Mathf.Sign(hAxis);
        }
        
        if(vAxis!=0)
        {
            movement.z = Time.deltaTime * moveSpeed * Mathf.Sign(vAxis);
        }
       

        transform.position += movement;

    }
}
