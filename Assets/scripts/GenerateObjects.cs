using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObjects : MonoBehaviour {

    public GameObject rock, tool;
    GameObject clone;

	// Use this for initialization
	void Start () {
        //cloneRock = Instantiate(rock, transform.position, Quaternion.identity) as GameObject;
    }
	
	// Update is called once per frame
	void Update () {
        float x = Random.Range(-14f, 14f);
        float isRockAlive = Random.Range( 0f, 100f);

        if (isRockAlive < 2) {
            clone = Instantiate(tool, transform.position, Quaternion.identity) as GameObject;
            clone.transform.Translate(new Vector3(x, 15f, -0.8f));
        }else if(isRockAlive < 17) {
            clone = Instantiate(rock, transform.position, Quaternion.identity) as GameObject;
            clone.transform.Translate(new Vector3(x, 15f, -0.8f));
        }


    }
}
