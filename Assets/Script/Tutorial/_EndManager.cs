using UnityEngine;
using System.Collections;

public class _EndManager : MonoBehaviour
{
    public Dialog_3 dialog;
    public bool cont;
    public TextAsset Text;

    public GameObject HantuPos;
    public GameObject Player;
    public GameObject Poshantu;
    public GameObject BlackBG;
    public GameObject ToBeContinued;


    public GameObject Kamelia;
    public GameObject Aska;
    public GameObject HantuKk;
    public GameObject HantuKkgelap;

    public IEnumerator EndDialog()
    {
        KameliaDialog(21, 22);
        while (!cont) yield return null;
        AskaDialog(22, 24);
        while (!cont) yield return null;
        KameliaDialog(24, 25);
        Kamelia.SetActive(false);
        while (!cont) yield return null;
        Instantiate(HantuKkgelap, HantuPos.transform.position, Quaternion.identity);
        //HantuKkgelap.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        Hantu();
    }

    public IEnumerator Jumpscare()
    {
        yield return new WaitForSeconds(0.5f);
        //closeup
        Player.transform.position = Poshantu.transform.position;
        float ZoomCamera = 0.25f;
        float DefaultSize = Player.GetComponent<Camera>().orthographicSize;
        Player.GetComponent<Camera>().orthographicSize = ZoomCamera;
        yield return new WaitForSeconds(1.0f);  
        Player.GetComponent<Camera>().orthographicSize = DefaultSize;
        ToBeContinued.SetActive(true);
        BlackBG.SetActive(true);
        yield return new WaitForSeconds(5);
        Application.LoadLevel("MainMenu");
    }

    public void Hantu()
    {
        //HantuKk.SetActive(true);
        Instantiate(HantuKk, HantuPos.transform.position, Quaternion.identity);
        StartCoroutine(Jumpscare());
  
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
    void Start()
    {
        StartCoroutine(EndDialog());

    }



}
