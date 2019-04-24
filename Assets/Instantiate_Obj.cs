using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Obj : MonoBehaviour {
	public GameObject Instantiate_Position; //物件的生成點。

	public GameObject Box; //要生成的物件。
	// Use this for initialization

	void Start () {

			Instantiate (Box, Instantiate_Position.transform.position,

				Instantiate_Position.transform.rotation);
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}
