using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundController : MonoBehaviour {

    public float velocity = 0.000001f;
    public Renderer quad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 vc2 = new Vector2(0, velocity * Time.deltaTime);
        quad.material.mainTextureOffset += vc2;
	}
}
