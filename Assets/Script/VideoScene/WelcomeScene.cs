using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class WelcomeScene : MonoBehaviour {

	public MovieTexture movie;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play ();
		Screen.fullScreen = true;
		GetComponent<AudioSource>().Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!movie.isPlaying) {
			SceneManager.LoadScene ("puzzle_room");
		}
	}

	void OnMouseDown() {
		movie.Stop ();
		SceneManager.LoadScene ("puzzle_room");
	}
}
