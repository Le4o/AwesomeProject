using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {
    
    public int lifeShip { get; set; }
    public GameObject lifeBarFull, lifeBarHalf, lifeBarDying;

    // Use this for initialization
    void Start () {
        lifeShip = 3;
	}
	
	// Update is called once per frame
	void Update () {
        float Horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * 4;
        float Vertical = Input.GetAxis("Vertical") * Time.deltaTime * 0;

        transform.Translate(new Vector3(Horizontal, Vertical, 0));
        if(lifeShip < 1) {
            Destroy(this.gameObject);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("rock")) {
            lifeShip--;
            loseHealth(lifeShip);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("life")) {
            if (lifeShip < 3) { lifeShip++; gainHealth(lifeShip); }
            Destroy(collision.gameObject);
        }
    }

    private void loseHealth(int actualLife)
    {
        switch (actualLife)
        {
            case 1:
                lifeBarHalf.transform.Translate(new Vector3(0 , 0, 10));
                break;
            case 2:
                lifeBarFull.transform.Translate(new Vector3(0, 0, 10));
                break;
            
                
        }
    }

    private void gainHealth(int actualLife){
        switch (actualLife) {
            case 2:
                lifeBarHalf.transform.Translate(new Vector3(0, 0, -10));
                break;
            case 3:
                lifeBarFull.transform.Translate(new Vector3(0, 0, -10));
                print("full");
                break;
        }
    }
}
