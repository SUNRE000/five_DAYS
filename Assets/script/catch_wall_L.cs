using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class catch_wall_L : MonoBehaviour {

    public Text score;
    public int scoreCount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /*private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindWithTag("left"))
        {
            Destroy(GameObject.FindWithTag("left"));
            scoreCount += 1;
            score.text = "分數" + scoreCount.ToString();
        }
    }*/
   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "left")
        {
            scoreCount += 1;
            score.text = "分數" + scoreCount.ToString();
            Destroy(GameObject.FindWithTag("right"));
        }
    }*/
}
