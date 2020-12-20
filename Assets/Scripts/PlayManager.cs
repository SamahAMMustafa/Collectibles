using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayManager : MonoBehaviour
{
	//[SerializedField] private string GameScene;
	
	//look for string (scene) named GameScene
	public void PlayButtonMoveScene(string GameScene)
	{
		SceneManager.LoadScene(GameScene);
	}

}
