using UnityEngine;
using System.Collections;

public class Atirar : MonoBehaviour {

	public GameObject bullet;
	public Transform canoArma;
	public ParticleSystem fireworks;



	// Use this for initialization
	void Start ()
	{

	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButton ("Fire1")) 
		{
			Instantiate(bullet,canoArma.position,canoArma.rotation);

		}


	}
}
