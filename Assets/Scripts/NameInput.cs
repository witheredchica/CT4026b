using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameInput : MonoBehaviour {
    [SerializeField] private TMP_InputField textIn;
    private string input = "";

    public void Enter() {
        input = textIn.text;
        SayHi();
    }

    private void SayHi() {
        GetComponent<TextMeshProUGUI>().text = "Hello " + input + "!!!";
    }
}
