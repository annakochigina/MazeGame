using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class coin1 : MonoBehaviour {
    public balance balref;

    public GameObject coinee;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            balref.balancee += 100.0f;
        Destroy(coinee);
    }
}
