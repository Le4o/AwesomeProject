using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestructor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("rock")) {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("life")) {
            Destroy(collision.gameObject);
        }
    }
}
