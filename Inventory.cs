using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	public RectTransform content;
	public List <GameObject> itens;

	// Use this for initialization
	void addItem()
	{
		while (content.childCount < itens.Count) //com if ele aparece em tempo de jogo, com while ele aparece de uma vez
		{
			GameObject item = Instantiate (itens [content.childCount], content.position, Quaternion.identity) as GameObject;
			item.transform.parent = content.transform;
		}
			
	}


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		addItem ();
	}
}
