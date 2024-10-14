using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloorButtonScript : MonoBehaviour
{
    const string PLAYER_TAG = "Player";
    public UnityEvent ButtonPressed;
    public UnityEvent ButtonReleased;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag(PLAYER_TAG)) {
            Debug.Log("Button Pressed");
            ButtonPressed.Invoke();
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag(PLAYER_TAG)) {
            Debug.Log("Button Released");
            ButtonReleased.Invoke();
        }
    }
}
