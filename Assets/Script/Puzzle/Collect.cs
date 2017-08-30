using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collect : MonoBehaviour {

    public ShowItem_Inven InvenItem;
    //private ShowItem_Hint ShowHint;
    public Level_Score LevelScore;

    _GameManager GameManager;
    private Dialog_1 DialogTrigger;
    public GameObject BigItem;
    public GameObject Player;
    public GameObject InsPos;
    public GameObject BlackBG;
    private bool Show = true;

    public TextAsset ObjText;
    public GameObject ItemToGive;
    public int StartLine;
    public int FinishLine;

    void Start()
    {
        //ShowHint = FindObjectOfType<ShowItem_Hint>();
        DialogTrigger = FindObjectOfType<Dialog_1>();
        GameManager = FindObjectOfType<_GameManager>();
        InvenItem = FindObjectOfType<ShowItem_Inven>();
        LevelScore = FindObjectOfType<Level_Score>();
        Physics2D.queriesHitTriggers = true;
    }

    public IEnumerator ShowBigItem(GameObject GivenItem)
    {
        Vector3 BGPos = new Vector3(InsPos.transform.position.x, InsPos.transform.position.y, -1);
        Instantiate(BlackBG, BGPos, Quaternion.identity);
        Instantiate(GivenItem, InsPos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        Show = true;
    }

    /* void Detect(Collider2D other)
     {
         if(other.tag == "Player")
         {
                 if (Input.GetKey(KeyCode.Mouse1) && Show == true)
                 {
                 */
    void OnMouseDown()
    {
        Show = false;
        LevelScore.ScorePuzzle += 300;
        StartCoroutine(ShowBigItem(BigItem));

        DialogTrigger.Atrigger(ObjText, ItemToGive, StartLine, FinishLine);
        GameManager.CurrentlyFound = true;
        Destroy(gameObject);
        //kirim pesan nama object ke game manager
        //insatntiate gambar di tengah kamera, blackout backgroundya
        //Instantiate(Key, gameObject.transform.position, Quaternion.identity);

        //         }
        //     }
    }
    /*void Update()
    {
        float Pos = Vector2.Distance(Player.transform.position, gameObject.transform.position);
        if (Pos < 1)
        {
            Detect(Player.GetComponent<Collider2D>());
        }
    }*/

    public void CoroutineBegin(GameObject givenItem)
    {
        StartCoroutine(ShowBigItem(givenItem));
    }



}
