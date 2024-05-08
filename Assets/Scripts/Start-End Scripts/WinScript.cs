using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{

	public int boltsCount;

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.transform.CompareTag("Player") && boltsCount >= 3)
		{
			Debug.Log(boltsCount);
			winGame();
		}
	}

	void Start()
	{

	}

	void Update()
	{
		boltsCount = CollectionUI.instance.ReturnScore();
	}

	public void winGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}