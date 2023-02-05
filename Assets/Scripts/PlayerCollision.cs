using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;     // A reference to our PlayerMovement script

	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter (Collision collisionInfo)
	{
		//SoundPlayer player = new SoundPlayer(@"C:\Users\N's Smart\Downloads\how-to-make-a-video-game\HowToMakeAVideoGame\mixkit-medieval-show-fanfare-announcement-226.wav");

		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;   //Disable the players movement.
			FindObjectOfType<GameManager>().EndGame();
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
			//player.Play();
		}
	}

}
