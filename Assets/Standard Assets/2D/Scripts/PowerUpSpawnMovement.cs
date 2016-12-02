using UnityEngine;
using System.Collections;

public class PowerUpSpawnMovement : MonoBehaviour {

    public float leftBound;
    public float rightBound;
    public float speed = 5.0f;
    private float fixedSpeed;
    Rigidbody2D rigidbody;

    // Use this for initialization
    void Start()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        fixedSpeed = speed;
        rigidbody.velocity = new Vector2(speed, 0);
    }
	// Update is called once per frame
	void Update () {
	    
        if (this.gameObject.transform.position.x < leftBound)
        {
            speed = fixedSpeed;
            rigidbody.velocity = new Vector2(speed, 0);
        }   
        if (this.gameObject.transform.position.x > rightBound)
        {
            speed = fixedSpeed * -1;
            rigidbody.velocity = new Vector2(speed, 0);
        }
	}
}
