using UnityEngine;
using System.Collections;

public class Colisaobolasbolas : MonoBehaviour {

	public GameObject[] lindo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnCollisionEnter(Collision hue)
	{
		if (hue.collider.tag != "Vermelha")
		{

				

		}
	}
}
