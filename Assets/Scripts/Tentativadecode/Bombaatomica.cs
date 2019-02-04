using UnityEngine;
using System.Collections;

public class Bombaatomica : MonoBehaviour {
	
	bool isSpawning = false;
	public GameObject atomic;
	public Vector3 ff;
	public GameObject particula;
	// Use this for initialization
	void Start () 
	{
		ff = new Vector3 (32.3f, 461.47f, 33.8f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.Q)) 
		{
			Instantiate(atomic,ff , transform.rotation);
		}
	
	}

	IEnumerator tempoateexplosao(int index, float seconds)
	{
		seconds = 9;

		Debug.Log ("Waiting for " + seconds + " seconds");


		yield return new WaitForSeconds(seconds);
		Instantiate(particula,ff , transform.rotation);
		

	}

	 
	

}
