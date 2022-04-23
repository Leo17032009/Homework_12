using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	[SerializeField] private int _coins;
	[SerializeField] private Text _coinsText;
	[SerializeField] private GameObject _shop, _shopButton1, _shopButton2, _shopButton3;
	private int _score;
	private int _coinsCount = 1;
	private bool _check = true;
	[SerializeField]private GameObject _coinsPanel;
	public static GameManager instance;

	public void Awake()
	{
		if (instance == null)
		{
			instance = this;

			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
		_coins = PlayerPrefs.HasKey ("Coins") ? PlayerPrefs.GetInt ("Coins") : 0;
		_coinsCount = PlayerPrefs.HasKey ("CoinsCount") ? PlayerPrefs.GetInt ("CoinsCount") : 1;

		if (_coinsCount == 2) 
		{
			Destroy (_shopButton1);
		}
		if (_coinsCount == 3) 
		{
			Destroy (_shopButton2);
		}
		if (_coinsCount == 4) 
		{
			Destroy (_shopButton3);
		}
		_coinsText.text = _coins + "$";

	}

	private void Update()
	{
		_coinsText.text = _coins + "$";
	}

	public void CoinsUpdate()
	{
		_coins += _coinsCount;
		PlayerPrefs.SetInt ("Coins", _coins);
	}

	public void OnShopButton()
	{
		if (_check == true) {
			_shop.SetActive (true);
			_check = false;
		} else {
			_shop.SetActive (false);
			_check = true;
		}
	}

	public void OnBuyButton1Down()
	{
		if (_coins >= 100) 
		{
			_coinsCount = 1;
			_coins -= 300;
			_coinsCount *= 3;
			PlayerPrefs.SetInt ("CoinsCount", _coinsCount);
			PlayerPrefs.SetInt ("Coins", _coins);
			Destroy (_shopButton2);
		}
	}

	public void OnBuyButton2Down()
	{
		if (_coins >= 450) 
		{
			_coinsCount = 1;
			_coins -= 450;
			_coinsCount *= 4;
			PlayerPrefs.SetInt ("CoinsCount", _coinsCount);
			PlayerPrefs.SetInt("Coins", _coins);
			Destroy (_shopButton2);
		}
	}

	public void OnBuyButton3Down()
	{
		if (_coins >= 900) 
		{
			_coinsCount = 1;
			_coins -= 900;
			_coinsCount *= 9;
			PlayerPrefs.SetInt ("CoinsCount", _coinsCount);
			PlayerPrefs.SetInt ("Coins", _coins);
			Destroy (_shopButton3);
		}
	}
}
