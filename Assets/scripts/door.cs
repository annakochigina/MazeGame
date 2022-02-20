using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

internal class door : MonoBehaviour {
   
    public balance balref;
    public GameObject doorr;
	public bool a = false;

    void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			if ((balref.balancee > 200.0f) && (balref.keyPicked == true))
				SceneManager.LoadScene("congr");

		}

	}
}