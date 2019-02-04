 using UnityEngine;
using System.Collections;

public class SpawningBlack : MonoBehaviour
{
	public GameObject prefab1;
	
	public GameObject prefab2;
	
	public GameObject prefab3;
	
	public GameObject prefab4;

	
	public int platform;
	
	// Use this for initialization
	void Start () {
		
		InvokeRepeating("CreateObstacle", 1f, 2.85f); 
		
	}
	
	
	
	void CreateObstacle()
	{
		platform = Random.Range (1, 4);             //radom number generator b/w 1 and 7
		float RandomX = Random.Range(28.9f, 19.17f);
		float RandomY = Random.Range (6.21f, 6.50f);
		float RandomZ = Random.Range (-8.57f, -8.7f);// appear b/w -5 and 5 in y-axis
		               // spawn this much right of the screen
		
		switch (platform)
		{
		case 1: 
			Instantiate(prefab1, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity); 
			break;
		case 2:
			Instantiate(prefab2, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity);
			break;
		case 3: 
			Instantiate(prefab3, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity);
			break;
		case 4: 
			Instantiate(prefab4, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity);
			break;
		
		}
		
	}
}