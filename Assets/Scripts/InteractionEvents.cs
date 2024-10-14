using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractionEvents : MonoBehaviour
{
    public GameObject clone;
    [SerializeField] private TextMeshProUGUI spawnNumText; //The text displayed on the slider handle
    private int spawnNum = 1;
    [SerializeField] private float r = 1f; //Scalar for spawn range
    private float lifespan = 4f;

    public void SpawnClone(Transform position) {
        for (int i = 0; i < spawnNum; i++) {
            //A random Vector3 to spawn cubes around the spawn location
            Vector3 variantPos = new Vector3(Random.Range(-r, r), 0f, Random.Range(-r, r));
            //Add the variant position to the spawnpoint position
            GameObject Instance = Instantiate(clone, position.position + variantPos, position.rotation);
            //Select random colour and assign it to cube
            Color col = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            Instance.GetComponent<Renderer>().material.color = col;
            //Delete cube object after 4 seconds
            Destroy(Instance, lifespan);
        }
    }

    //Called when the sliders value is updated
    public void SliderValueUpdate(Slider slider) {
        //Set the spawn number to the sliders value
        spawnNum = (int)slider.value;
    }

    private void Update() {
        //Update the slider handle to display the correct value
        spawnNumText.text = spawnNum.ToString();
    }
}
