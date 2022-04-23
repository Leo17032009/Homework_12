using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {

	private void MainButton()
	{
		GameManager.instance.CoinsUpdate ();
	}
}
