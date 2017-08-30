using UnityEngine;
using System.Collections;

public class _TutorialManager : MonoBehaviour {

    //public StartOpacity ObjOpacity;
    public Dialog_2 dialog;
    public bool cont;
    public TextAsset Text;
    

    public GameObject Kamelia;
    public GameObject Aska;

    public IEnumerator TutorDialog()
    {
        KameliaDialog(0, 2);
        while (!cont) yield return null;
        AskaDialog(1, 3);
        while (!cont) yield return null;
        KameliaDialog(2, 4);
        while (!cont) yield return null;
        AskaDialog(3, 5);
        while (!cont) yield return null;
        KameliaDialog(4, 6);
        while (!cont) yield return null;
        AskaDialog(5, 7);
        while (!cont) yield return null;
        KameliaDialog(6, 8);
        while (!cont) yield return null;
        AskaDialog(7, 9);
        while (!cont) yield return null;
        KameliaDialog(8, 10);
        while (!cont) yield return null;
        AskaDialog(9, 12);
        while (!cont) yield return null;
        KameliaDialog(11,13);
        while (!cont) yield return null;
        AskaDialog(12, 14);
        while (!cont) yield return null;
        KameliaDialog(13, 15);
        while (!cont) yield return null;
        AskaDialog(14, 16);
        while (!cont) yield return null;
        AskaDialog(15, 17);
        while (!cont) yield return null;
        KameliaDialog(16, 18);
        while (!cont) yield return null;
        AskaDialog(17, 21);
        while (!cont) yield return null;
        Application.LoadLevel("puzzle_room"); 
    }

    public void KameliaDialog(int startLine, int finishLine)
    {
        cont = false;
        Aska.SetActive(false);
        Kamelia.SetActive(true);
        dialog.Atrigger(Text, null, startLine, finishLine);
    }

    public void AskaDialog(int startLine, int finishLine)
    {
        cont = false;
        Kamelia.SetActive(false);
        Aska.SetActive(true);
        dialog.Atrigger(Text, null, startLine, finishLine);
    }

    // Use this for initialization
    void Start () {
        StartCoroutine(TutorDialog());

    }
	


}
