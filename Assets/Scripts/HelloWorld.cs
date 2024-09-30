using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class HelloWorld : MonoBehaviour {
    private string str = "Hello World";
    private int counter = 0;
    private bool sizeUp = true;
    private bool counterIncreasing = true;
    [SerializeField] TextMeshProUGUI directionButton;

    private void Update() {
        str = "Hello World\nCounter: " + counter;
        GetComponent<TextMeshProUGUI>().text = str;
        counter = GetComponent<Counter>().IncrementCount(counter, counterIncreasing);
        //CycleSize();
    }

    private void CycleSize() {
        float fontSize = GetComponent<TextMeshProUGUI>().fontSize;
        switch (fontSize) {
            case 36f:
                sizeUp = true;
                break;
            case 100f:
                sizeUp = false;
                break;
            default:
                break;
        }
        GetComponent<TextMeshProUGUI>().fontSize = (sizeUp) ? fontSize + 0.125f : fontSize - 0.125f;
    }

    public void SwapDirection() {
        counterIncreasing = !counterIncreasing;
        directionButton.text = (counterIncreasing) ? "Swap Counter Direction: [+]" : "Swap Counter Direction: [-]";
    }
}
