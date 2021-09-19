using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float baseSpeed;
    public float sprintSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");
        float sprint = Input.GetAxisRaw("Sprint");
        Vector3 movement = Vector3.zero;
        float speed = baseSpeed;

        if (sprint > 0)
        {
            speed = sprintSpeed;
        }

        if(hInput != 0)
        {
            movement.x = Time.deltaTime * speed * Mathf.Sign(hInput);
        }

        if(vInput != 0)
        {
            movement.z = Time.deltaTime * speed * Mathf.Sign(vInput);
        }

        transform.position += movement;
    }
}
