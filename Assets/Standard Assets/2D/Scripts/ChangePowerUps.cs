using UnityEngine;
using System.Collections;

public class ChangePowerUps : MonoBehaviour {

    public int powerUpMode = 0;
    public float sniperSpeed;
    public float bombLifeLength;
    public float bombExplosionPower;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

	// Use this for initialization
	void Start () {
        changeSpriteImage();
    }
	
	// Update is called once per frame
	void Update () {
        
	}
        
    void changeSpriteImage()
    {
        switch (powerUpMode)
        {
            case 1:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
                break;
            case 2:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
                break;
            case 3:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite3;
                break;
        }
    }
}
