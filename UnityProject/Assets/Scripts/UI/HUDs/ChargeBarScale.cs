using UnityEngine;
using System.Collections;

public class ChargeBarScale : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		this.transform.localScale = new Vector3(Screen.width - 160, 1);
		//this.transform.position = new Vector3(Screen.width / 2, 5);
	}
}
