using UnityEngine;
using System.Collections;
using DG.Tweening;

public class LookAtPlayer2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly);
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.DOLookAt(GameObject.Find("Player2").transform.position, 0, AxisConstraint.None, Vector3.up);
	}
}
