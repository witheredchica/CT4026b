using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JaggedArray : MonoBehaviour {
    private int[][] jaggedArray = new int[10][];
    [SerializeField] TextMeshProUGUI text;

    private void Start() {
        for (int i = 0; i < 10; i++) {
            jaggedArray[i] = new int[Random.Range(0, 10)];
        }

        for (int i = 0; i < jaggedArray.Length; i++) {
            for (int j = 0; j < jaggedArray[i].Length; j++) {
                jaggedArray[i][j] = Random.Range(0, 100);
            }
            System.Array.Sort(jaggedArray[i]);
        }

        string output = "";

        for (int i = 0; i < jaggedArray.Length; i++) {
            for (int j = 0; j < jaggedArray[i].Length; j++) {
                output += "[" + jaggedArray[i][j] + "]";
                output = (j != jaggedArray[i].Length - 1) ? output + ", " : output + "\n";
            }
        }

        text.text = output;
    }
}