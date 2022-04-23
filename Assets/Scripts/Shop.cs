using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private GameObject _coinsPanel;

	public void ShopButtonDown()
	{
		GameManager.instance.OnShopButton();
	}

	public void BuyButtonShop1()
	{
		GameManager.instance.OnBuyButton1Down ();
	}

	public void BuyButtonShop2()
	{
		GameManager.instance.OnBuyButton2Down ();
	}


	public void ByButtonShop3()
	{
		GameManager.instance.OnBuyButton3Down ();
	}
}
