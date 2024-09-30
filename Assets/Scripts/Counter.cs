using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {
    public int IncrementCount(int count, bool increasing) {
        //Adds one if increasing is true, subtracts one if false
        count = (increasing) ? count + 1 : count - 1;
        return count;
    }
}
