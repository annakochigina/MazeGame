using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2 : MonoBehaviour {
	public GameObject doorr;
	
	void OnTriggerEnter(Collider me)
{
		if(me.tag == "Player")
			SceneManager.LoadScene("level2");
}
}
