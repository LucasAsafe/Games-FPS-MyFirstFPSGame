using UnityEngine;
using System.Collections;

public class Colisaotirobolas : MonoBehaviour {


	public GameObject particulas;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision hue)
	{
		if (hue.gameObject.tag == "Verde")
		{
			Destroy(hue.gameObject);

				

		}
		if (hue.gameObject.tag == "Vermelha") 
		{
			Destroy(hue.gameObject);

		}
		if (hue.gameObject.tag == "Preta") 
		{
			Destroy(hue.gameObject);
			Instantiate(particulas,transform.position,Quaternion.identity);
		}
		if (hue.gameObject.tag == "Azul")
		{
			Destroy(hue.gameObject);		
		}
		
	}
}
