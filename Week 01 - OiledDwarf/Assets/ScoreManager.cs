using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public static ScoreManager instance;
	public static int Score {get; private set;}

	public Text scoreText;

	void Awake() {
		instance = this;
		Score = 0;
	}

	public void IncreaseScore() {
		Score++;
		UpdateText();
	}

	public void DecreaseScore() {
		Score--;
		UpdateText();
	}

	private void UpdateText() {
		scoreText.text = "" + Score;
	}
}
