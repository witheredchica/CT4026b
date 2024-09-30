using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputManagerEntry;

public class BouncingToys : MonoBehaviour {
    private GameObject[][] toys = new GameObject[2][];
    private readonly float force = 50f;

    private void Start() {
        toys[0] = GameObject.FindGameObjectsWithTag("balls");
        toys[1] = GameObject.FindGameObjectsWithTag("boxes");

        for (int i = 0; i < toys.Length; i++) {
            for (int j = 0; j < toys[i].Length; j++) {
                Color col = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                toys[i][j].GetComponent<Renderer>().material.color = col;
            }
        }

        StartCoroutine(Bounce(1f));
    }

    private void Update() {
        for (int i = 0; i < toys.Length; i++) {
            foreach (GameObject toy in (toys[i])) {
                Color.RGBToHSV(toy.GetComponent<Renderer>().material.color, out float h, out float s, out float v);
                h = (h <= 1f) ? h + 0.00005f : 0f;
                toy.GetComponent<Renderer>().material.color = Color.HSVToRGB(h, s, v);
            }
        }
    }

    private IEnumerator Bounce(float waitTime) {
        while (true) {
            foreach (GameObject toy in toys[0]) {
                Rigidbody rb = toy.GetComponent<Rigidbody>();
                if (rb != null) {
                    Vector3 direction = transform.up + new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f));
                    rb.AddForce(direction * force);
                }
            }
            yield return new WaitForSeconds(waitTime);
        }
    }
}
