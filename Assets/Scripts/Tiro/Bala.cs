using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {

	public float bulletSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		bulletSpeed = 100 * Time.deltaTime;
		transform.Translate(0,0,bulletSpeed);
		Destroy(this.gameObject, 1);
	}
}
