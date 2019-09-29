using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
	//A reference to the game manager
	public GameManager gameManager;

    public Transform spawnPoint;

	// Triggers when the player enters the water
	void OnTriggerEnter(Collider other)
	{
		// Moves the player to the spawn point
		PositionPlayer();
	}

    void PositionPlayer()
    {
        gameManager.player.transform.position = spawnPoint.position;
        gameManager.player.transform.rotation = spawnPoint.rotation;
    }
}
