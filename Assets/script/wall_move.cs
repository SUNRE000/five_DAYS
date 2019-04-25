using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_move : MonoBehaviour {


    public GameObject lose_wall;
	// Use this for initialization
	void Start () {
        lose_wall.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -0.1f);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "dead")
        {
            lose_wall.SetActive(true);
            Destroy(GameObject.FindWithTag("right"));
            Destroy(GameObject.FindWithTag("left"));
            Destroy(GameObject.FindWithTag("head"));
        }
    }
}
