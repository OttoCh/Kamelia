using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Call_clock : MonoBehaviour {

	public GameObject CallClock;
	public GameObject InputFied;


	public void CalltheClock() {
		string Inputstring = InputFied.GetComponent<InputField> ().text;
		if (Inputstring == "31122001") {
			CallClock.GetComponent<Play_Clock> ().StartClockAnim ();
			InputFied.SetActive (false);
			InputFied.GetComponent<InputField> ().text = "";
		} else {
			InputFied.SetActive (false);
			InputFied.GetComponent<InputField> ().text = "";
		}
	}
}
