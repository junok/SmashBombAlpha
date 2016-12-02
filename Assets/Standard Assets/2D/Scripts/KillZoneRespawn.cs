using UnityEngine;
using System.Collections;

public class KillZoneRespawn : MonoBehaviour {


    public Vector3 respawnPosition = new Vector3(0, 0, 0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            Debug.Log("Killzone Enter");
            player.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            player.gameObject.transform.position = respawnPosition;
            setDefault(player);
        }
    }

    void setDefault(Collider2D player)
    {
        player.gameObject.GetComponentInChildren<Weapon>().bulletSpeed = 50;
        player.gameObject.GetComponentInChildren<Weapon>().bulletLifeTime = 1.5f;
        player.gameObject.GetComponentInChildren<PlayerKnockBack>().knockBack = 30;
    }
}
