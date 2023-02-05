using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	public Text highScore;
	void Start()
	{
		Debug.Log("Update");
		highScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString("0");
	}
	// Update is called once per frame
	public void Update () 
	{
		Debug.Log("Update");
		scoreText.text = player.position.z.ToString("0");
		int num = Convert.ToInt32(player.position.z);
		if (player.position.z > PlayerPrefs.GetInt("Highscore",0))
		{
			PlayerPrefs.SetInt("Highscore", num);
			highScore.text = num.ToString("0");
		}
	}
	
	
}
