using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    private void Awake() {
        Debug.Log("Awake for " + gameObject.name);
    }

    private void Start() {
        Debug.Log("Start for " + gameObject.name);
    }

    private void Update() {
        Debug.Log("Update for " + gameObject.name);
    }

    private void FixedUpdate() {
        Debug.Log("Fixed update for " + gameObject.name);
    }

    private void LateUpdate() {
        Debug.Log("Late update for " + gameObject.name);
    }
}
