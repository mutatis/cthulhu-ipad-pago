using UnityEngine;
using System.Collections;

public class UI_ManagerFlappy : MonoBehaviour {

	public int value;
	public GameObject valor;
	public GameObject cash;
	
	void Start ()
	{
		if (PlayerPrefs.GetInt("hasFlappy") == 1)
		{
			valor.SetActive(false);
			cash.SetActive(false);
		}
	}
}
