using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointRenderer : MonoBehaviour
{

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 1.0f);
    }
}
