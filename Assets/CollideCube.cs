using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideCube : MonoBehaviour {


	void Start () {
		
			
		
	}
	void OnTriggerEnter(Collider col){
		if(col.gameObject.name.Equals("Wall"))
		{
			
			Destroy(this.gameObject);
		}
	}

}
