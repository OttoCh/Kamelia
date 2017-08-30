using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class optScript : MonoBehaviour {
	public Canvas quitMenu, opt, canvas;
	public Button menu;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		opt = opt.GetComponent<Canvas> ();
		canvas = canvas.GetComponent<Canvas> ();
		quitMenu.enabled = false;
		opt.enabled = false;
		menu = menu.GetComponent<Button> ();
	}

	public void exitPress() {
		quitMenu.enabled = true;
		opt.enabled = false;
	}

	public void noPress() {
		quitMenu.enabled = false;
		opt.enabled = true;
	}

	public void mainMenu() {
		SceneManager.LoadScene ("MainMenu");
	}

	public void menuPress() {
		opt.enabled = true;
		menu.enabled = false;
		canvas.enabled = false;
	}

	public void backPress() {
		opt.enabled = false;
		menu.enabled = true;
		canvas.enabled = true;
	}

	// Update is called once per frame
	void Update () {

	}
}
