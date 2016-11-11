using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
    public int lives;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "KillZone")
        {
            lives -= 1;
            Debug.Log(lives);
            if (lives == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
