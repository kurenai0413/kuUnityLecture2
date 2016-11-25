using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float jump_speed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody>().velocity = Vector3.up * this.jump_speed;

            // this.gameObject;
            // 說明表示: the game object this componenet is attached to.
        }
	}
}
