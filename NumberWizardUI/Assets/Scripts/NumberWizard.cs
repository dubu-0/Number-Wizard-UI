using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
	[SerializeField] TextMeshProUGUI guessingTextComponent;

    int guess;

	public void Start()
	{
		NextGuess();
		PrintGuess();
	}

	public void NextGuess()
	{
		int randomNumber = Random.Range(min, max + 1);
		guess = randomNumber;
	}

	public void PrintGuess()
	{
		guessingTextComponent.text = guess.ToString();
	}

	public void LoadNextScene()
	{
		var currentScene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(currentScene.buildIndex + 1);
	}

	public void OnPressHigher()
	{
		if (guess != max)
		{
			min = guess + 1;
			NextGuess();
			PrintGuess();
		}
	}

	public void OnPressLower()
	{
		if (guess != min)
		{
			max = guess - 1;
			NextGuess();
			PrintGuess();
		}
	}
}
