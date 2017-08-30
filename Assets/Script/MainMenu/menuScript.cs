using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuScript : MonoBehaviour {
	public AudioSource sound;
	public Canvas quitMenu;
	public Button start, about, exit;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		quitMenu.enabled = false;
		start = start.GetComponent<Button> ();
		about = about.GetComponent<Button> ();
		exit = exit.GetComponent<Button> ();
	}

	public void exitPress() {
		quitMenu.enabled = true;
		start.enabled = false;
		about.enabled = false;
		exit.enabled = false;
	}

	public void noPress() {
		quitMenu.enabled = false;
		start.enabled = true;
		about.enabled = true;
		exit.enabled = true;
	}

	public void startGame() {
		SceneManager.LoadScene ("WelcomeScene");
	}
 
	public void exitGame() {
		Application.Quit();
	}

	public void playSound() {
		sound.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
