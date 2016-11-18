using UnityEngine;
using System.Collections;

public class BombExplosion2 : MonoBehaviour {

    private float knockBackSpeed = 50;
    private float xdirection = 1;
    private float ydirection = 1;
    private GameObject bulletOwner;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        {
            bulletOwner = GameObject.Find("Player2");
            knockBackSpeed = bulletOwner.GetComponent<PlayerKnockBack>().knockBack;
            float gameObjectPosx = trigger.gameObject.transform.position.x;
            float gameObjectPosy = trigger.gameObject.transform.position.y;
            Vector3 directionVector;
            directionVector = (new Vector3((gameObjectPosx - this.gameObject.transform.position.x), (gameObjectPosy - this.gameObject.transform.position.y), 0).normalized);
            //trigger.gameObject.GetComponent<Rigidbody2D>().velocity = directionVector * knockBackSpeed;  
            trigger.gameObject.GetComponent<Rigidbody2D>().AddForce(directionVector * knockBackSpeed, ForceMode2D.Impulse);
            Destroy(this.gameObject);
        }

    }

    void OnTriggerStay2D(Collider2D trigger)
    {

        Vector3 directionVector;
        if (trigger.gameObject.tag == "Player")
        {
            bulletOwner = GameObject.Find("Player2");
            float gameObjectPosx = trigger.gameObject.transform.position.x;
            float gameObjectPosy = trigger.gameObject.transform.position.y;
            knockBackSpeed = bulletOwner.GetComponent<PlayerKnockBack>().knockBack;
            directionVector = (new Vector3((gameObjectPosx - this.gameObject.transform.position.x), (gameObjectPosy - this.gameObject.transform.position.y), 0).normalized);
            //trigger.gameObject.GetComponent<Rigidbody2D>().velocity = directionVector * knockBackSpeed;  
            trigger.gameObject.GetComponent<Rigidbody2D>().AddForce(directionVector * knockBackSpeed, ForceMode2D.Impulse);
        }
    }
}
