using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class key : MonoBehaviour {
    public GameObject keyy;
    public balance balreff;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            balreff.keyPicked = true;
        Destroy(keyy);
            
          

    }
}
