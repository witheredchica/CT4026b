using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputManagerEntry;

public class BouncingToys : MonoBehaviour
{
    private GameObject[] toys;
    private readonly float force = 50f;

    private void Start() {
        toys = GameObject.FindGameObjectsWithTag("toy");

        for (int i = 0; i < toys.Length; i++) {
            Color col = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            toys[i].GetComponent<Renderer>().material.color = col;
        }

        StartCoroutine(Bounce(1f));
        //StartCoroutine(RotateHue(0.01f));
    }

    private void Update() {
        foreach (GameObject toy in toys) {
            Color.RGBToHSV(toy.GetComponent<Renderer>().material.color, out float h, out float s, out float v);
            h = (h <= 1f) ? h + 0.00005f : 0f;
            toy.GetComponent<Renderer>().material.color = Color.HSVToRGB(h, s, v);
        }
    }

    private IEnumerator Bounce(float waitTime) {
        while (true) {
            foreach (GameObject toy in toys) {
                Rigidbody rb = toy.GetComponent<Rigidbody>();
                if (rb != null) {
                    Vector3 direction = transform.up + new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f));
                    rb.AddForce(direction * force);
                }
            }
            yield return new WaitForSeconds(waitTime);
        }
    }
    /*
    private IEnumerator RotateHue(float waitTime) {
        while (true) {
            foreach (GameObject toy in toys) {
                float h, s, v;
                Color.RGBToHSV(toy.GetComponent<Renderer>().material.color, out h, out s, out v);
                h = (h <= 1f) ? h + 0.001f : 0f;
                toy.GetComponent<Renderer>().material.color = Color.HSVToRGB(h, s, v);
            }
            yield return new WaitForSeconds(waitTime);
        }
    }*/

}
