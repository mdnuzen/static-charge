using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
	public static WinScript status;
	public int boltsCount;
	public int neededBoltCount;

	public bool move;
	public GameObject water;
	public GameObject PActive;
	public GameObject P1;
	public GameObject P2;

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.transform.CompareTag("Player") && boltsCount >= neededBoltCount)
		{
			
			Debug.Log(boltsCount);

			if (boltsCount >=1)
			{
				PActive.SetActive(true);
				Debug.Log("Acivated platform");
			}

			if (boltsCount >= 2)
			{
				DeactivateWater();
				Debug.Log("Destroyed water");
			}
			
			if (boltsCount == 3)
			{
				nextScene();
				Debug.Log("Next scene");
			}
			
		}
	}

	void Start()
	{

		P1.SetActive(true);
		P2.SetActive(true);
		PActive.SetActive(false);

		if(status == null)
        {
            status = this;
        }
	}

	void Update()
	{
		boltsCount = CollectionUI.instance.ReturnScore();
	}

	public bool returnMove()
		{
			return move;
		}


	public void DeactivateWater()
	{
		Destroy(water);
	}

	public void nextScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}


}