using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

    public float distance;
    public bool vertical = true;
    public float speed;

    private float initialxPosition;
    private float initialyPosition;
    private float fixedSpeed;
    Rigidbody2D gvntrigidbody;


	// Use this for initialization
	void Start () {
        initialxPosition = this.gameObject.transform.position.x;
        initialyPosition = this.gameObject.transform.position.y;
        gvntrigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        fixedSpeed = speed;
        if (vertical)
        {
            gvntrigidbody.velocity = new Vector2(0, speed);
        }

	}
	
	// Update is called once per frame
	void Update () {

        if (this.gameObject.transform.position.y > initialyPosition + distance)
        {
            speed = fixedSpeed * -1;
            gvntrigidbody.velocity = new Vector2(0, speed);
        }
        if (this.gameObject.transform.position.y < initialyPosition)
        {
            speed = fixedSpeed;
            gvntrigidbody.velocity = new Vector2(0, speed);
        }
    }
}
