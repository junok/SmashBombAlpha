using UnityEngine;
using System.Collections;

public class PowerUp2 : MonoBehaviour
{

    private int mode;
    private float sniperPower;
    private float longerBombPower;
    private float strongerPower;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "PowerUp")
        {
            sniperPower = trigger.GetComponent<ChangePowerUps>().sniperSpeed;
            longerBombPower = trigger.GetComponent<ChangePowerUps>().bombLifeLength;
            strongerPower = trigger.GetComponent<ChangePowerUps>().bombExplosionPower;
            mode = trigger.GetComponent<ChangePowerUps>().powerUpMode;

            if (mode == 0)
            {
                this.GetComponentInChildren<Weapon2>().bulletSpeed = 50;
                this.GetComponentInChildren<Weapon2>().bulletLifeTime = 1.5f;
                this.GetComponentInChildren<PlayerKnockBack>().knockBack = 30;
            }
            else if (mode == 1)
                this.GetComponentInChildren<Weapon2>().bulletSpeed = sniperPower;
            else if (mode == 2)
                this.GetComponentInChildren<Weapon2>().bulletLifeTime = longerBombPower;
            else if (mode == 3)
                this.GetComponentInChildren<PlayerKnockBack>().knockBack = strongerPower;
            Destroy(trigger.gameObject);
        }
    }
}
