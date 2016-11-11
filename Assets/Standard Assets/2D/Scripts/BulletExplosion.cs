using UnityEngine;
using System.Collections;

public class BulletExplosion : MonoBehaviour {

    public float knockBackStunTime = 5;
    public float knockBackSpeed = 50;

    private float xdirection = 1;
    private float ydirection = 1;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter2D (Collision2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        {
            float gameObjectPosx = trigger.gameObject.transform.position.x;
            float gameObjectPosy = trigger.gameObject.transform.position.y;
            Vector3 directionVector;
            directionVector = (new Vector3((gameObjectPosx - this.gameObject.transform.position.x), (gameObjectPosy - this.gameObject.transform.position.y), 0).normalized);
            //trigger.gameObject.GetComponent<Rigidbody2D>().velocity = directionVector * knockBackSpeed;  
            trigger.gameObject.GetComponent<Rigidbody2D>().AddForce(directionVector * knockBackSpeed, ForceMode2D.Impulse);
            Destroy(this.gameObject);
        }
        
    }

    void OnTriggerStay2D (Collider2D trigger)
    {
        float gameObjectPosx = trigger.gameObject.transform.position.x;
        float gameObjectPosy = trigger.gameObject.transform.position.y;
        Vector3 directionVector;
        if (trigger.gameObject.tag == "Player")
        {
            directionVector = (new Vector3((gameObjectPosx - this.gameObject.transform.position.x), (gameObjectPosy - this.gameObject.transform.position.y), 0).normalized);
            //trigger.gameObject.GetComponent<Rigidbody2D>().velocity = directionVector * knockBackSpeed;  
            trigger.gameObject.GetComponent<Rigidbody2D>().AddForce(directionVector * knockBackSpeed, ForceMode2D.Impulse);  
        }        
    }   
}
