using UnityEngine;
using System.Collections;

public class Dialog_2 : MonoBehaviour {

	//public TextAsset theText;

	public Dialog_texttutor dialogtext;
	
	// Use this for initialization
	void Start () {
		dialogtext = FindObjectOfType<Dialog_texttutor>();
	}

	//Adakan trigger sesuatu di update agar Atrigger() bisa dipanggil

	public void Atrigger(TextAsset theText, GameObject GivenItem, int StartLine, int FinishLine) {
		Debug.Log ("Receive");
		dialogtext.ReloadText(theText);
		dialogtext.ItemtoGive = GivenItem;
		dialogtext.CurrentLine = StartLine;
		dialogtext.EndLine = FinishLine;
		dialogtext.EnableText();
	}
}
