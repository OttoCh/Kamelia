using UnityEngine;
using System.Collections;

public class Button_Petunjuk : MonoBehaviour {

    public _GameManager Gamemanager;
    public Dialog_1 DialogCall;
    public TextAsset TeksPetunjuk;

    public void TriggerDialog()
    {
        Debug.Log("CALLED");
        int Startline;
        int FinishLine;
        if(!Gamemanager.BookFound)
        {
            Startline = 1;
            FinishLine = 3;
        }
        else
        {
            Startline = 3;
            FinishLine = 6;
        }
        DialogCall.Atrigger(TeksPetunjuk, null, Startline, FinishLine);
    }

}
