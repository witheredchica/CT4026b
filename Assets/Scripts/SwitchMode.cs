using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMode : MonoBehaviour
{
    public GameObject HelloWorld;
    public GameObject NameInput;
    public GameObject DebugLog;

    public void ToggleHW() {
        //Disables NameInput and enables HelloWorld
        HelloWorld.SetActive(true);
        NameInput.SetActive(false);
        DebugLog.SetActive(false);
    }

    public void ToggleNI() {
        //Disables HelloWorld and enables NameInput
        HelloWorld.SetActive(false);
        NameInput.SetActive(true);
        DebugLog.SetActive(false);
    }

    public void ToggleDL() {
        //Disables others and enables DebugLog
        HelloWorld.SetActive(false);
        NameInput.SetActive(false);
        DebugLog.SetActive(true);
    }
}
