using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public void SwitchScene(int index) {
        SceneManager.LoadScene(index);
    }

    public void Kill() {
        Application.Quit();
    }
}
