using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    // Start is called before the first frame update
	
	
	void OnCollisionEnter2D(Collision2D col)
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
	}
	
	public void loseGame()
	{
		
	}
}