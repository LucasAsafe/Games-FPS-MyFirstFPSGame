using UnityEngine;
using System.Collections;

public class Pontuacao : MonoBehaviour {

	public GUIText pontuaçao; 
	public int pontos;
	public string Cena;
	public int ganhei;

	void Start () 
	{
		//audio.clip = somum;
		pontos = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		pontuaçao.text = "totalvidas" + pontos;
	}

}
