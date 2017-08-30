using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Call_alfabet : MonoBehaviour {

	public GameObject CallAlfabet;
	public GameObject InsPos;
	public GameObject InputFied;
	public GameObject BlackBG;


	public void CalltheClock() {
		string Inputstring = InputFied.GetComponent<InputField> ().text;
		if (Inputstring == "alive") {
			Instantiate (BlackBG, InsPos.transform.position, Quaternion.identity);
			CallAlfabet.GetComponent<Level_Score> ().ActiveSet ();
			gameObject.SetActive (false);
			InputFied.SetActive (false);
			InputFied.GetComponent<InputField> ().text = "";
		} else {
			InputFied.SetActive (false);
			InputFied.GetComponent<InputField> ().text = "";
		}
	}
}
