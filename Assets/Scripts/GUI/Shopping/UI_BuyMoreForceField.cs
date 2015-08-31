﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_BuyMoreForceField : MonoBehaviour
{
    public float howMany;
    public int value;
	public Text[] text;
	public GameObject[] button;
	public Text text1;
	public AudioClip[] botao;

    void Start ()
    {
        LoadData ();
		if(howMany > 12.5f)
		{
			howMany = 12.5f;
		}
		if (howMany == 12.5f)
		{
			for(int i = 0; i < button.Length; i++)
			{
				button[i].SetActive(false);
			}
			text1.text = "MAX";
			for(int i = 0; i < 5; i ++)
			{
				text[i].color = new Color(1f,1f,1f,1f);;
			}
		}
		else if(howMany == 2.5f)
		{
			for(int i = 0; i < 1; i ++)
			{
				text[i].color = new Color(1f,1f,1f,1f);;
			}
			value = 2500;
		}
		else if(howMany == 5)
		{
			for(int i = 0; i < 2; i ++)
			{
				text[i].color = new Color(1f,1f,1f,1f);;
			}
			value = 10000;
		}
		else if(howMany == 7.5f)
		{
			for(int i = 0; i < 3; i ++)
			{
				text[i].color = new Color(1f,1f,1f,1f);;
			}
			value = 20000;
		}
		else if(howMany == 10)
		{
			for(int i = 0; i < 4; i ++)
			{
				text[i].color = new Color(1f,1f,1f,1f);;
			}
			value = 40000;
		}
		if(howMany < 12.5f)
		{
			text1.text = value.ToString();
		}
	}

    void LoadData ()
    {
        howMany = PlayerPrefs.GetFloat("ForceField");
    }

    void SaveData ()
    {
        PlayerPrefs.SetFloat("ForceField", howMany);
    }

    public void BuyMoreForceFields ()
    {
		if(GameManager.totalCoins >= value)
		{
	        GameManager.Buy(value);
			howMany += 2.5f;
			AudioSource.PlayClipAtPoint(botao[0], transform.position, 1f);
	        OftenSpawn.broughtProbalitys[0] = howMany * 100;
			if (howMany == 12.5f)
			{
				for(int i = 0; i < button.Length; i++)
				{
					button[i].SetActive(false);
				}
				text1.text = "MAX";
				for(int i = 0; i < 5; i ++)
				{
					text[i].color = new Color(1f,1f,1f,1f);;
				}
			}
			else if(howMany == 2.5f)
			{
				for(int i = 0; i < 1; i ++)
				{
					text[i].color = new Color(1f,1f,1f,1f);;
				}
				value = 2500;
			}
			else if(howMany == 5)
			{
				for(int i = 0; i < 2; i ++)
				{
					text[i].color = new Color(1f,1f,1f,1f);;
				}
				value = 10000;
			}
			else if(howMany == 7.5f)
			{
				for(int i = 0; i < 3; i ++)
				{
					text[i].color = new Color(1f,1f,1f,1f);;
				}
				value = 20000;
			}
			else if(howMany == 10)
			{
				for(int i = 0; i < 4; i ++)
				{
					text[i].color = new Color(1f,1f,1f,1f);;
				}
				value = 40000;
			}
			if(howMany < 12.5f)
			{
				text1.text = value.ToString();
			}
			PlayerPrefs.SetFloat("ForceField", howMany);
			SaveData ();
			if (howMany >= 12.5f)
			{
				text1.text = "MAX";
				for(int i = 0; i < button.Length; i++)
				{
					button[i].SetActive(false);
				}
				howMany = 12.5f;
			}
		}
		else
		{
			AudioSource.PlayClipAtPoint(botao[1], transform.position, 1f);
		}
    }
}
