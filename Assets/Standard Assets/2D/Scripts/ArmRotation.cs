using UnityEngine;
using System.Collections;

public class ArmRotation : MonoBehaviour {


    public int rotation_offset = 90;
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("MouseX");
        float vertical = Input.GetAxis("MouseY");
        float angle = Mathf.Atan2(-horizontal, -vertical) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
