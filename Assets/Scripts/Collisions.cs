using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    //if this object collides with another collider
    private void OnCollisionEnter(Collision collision) {
        transform.position = new Vector3(0f, 5f, 0f);
    }

    //if this object collides with a trigger collider
    private void OnTriggerEnter(Collider other) {
        transform.position = new Vector3(0f, 2f, 0f);
    }
}
