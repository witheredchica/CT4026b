using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private int destination = 0;
    private Vector3[] tpLocations = { new Vector3 (5.2f, 0.17f, 2.55f), new Vector3(4.83f, 6.11f, 9.36f) };
    public float timeSinceTP = 5f;

    private void Update() {
        timeSinceTP += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) {

        switch (other.name[other.name.Length - 1]) {
            case '1':
                destination = 1;
                break;
            case '2':
                destination = 0;
                break;
            default:
                break;
        }

        if (timeSinceTP >= 0.1f) {
            Debug.Log("Teleported");
            GetComponent<CharacterController>().enabled = false;
            transform.position = tpLocations[destination];
            GetComponent<CharacterController>().enabled = true;
            timeSinceTP = 0f;
        }
    }
}
