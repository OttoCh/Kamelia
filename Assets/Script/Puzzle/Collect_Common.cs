using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collect_Common : MonoBehaviour {

    private ShowItem_Inven InvenItem;
    private UpdateScore ScoreUpdate;
    private Dialog_text dialogtext;

    _GameManager GameManager;
	public GameObject InputfielTelp;
	public GameObject InputfielAlfabet;

    public Dialog_1 DialogTrigger;
    public Player_move Playermove;
    public GameObject AUdio;
    public GameObject BigItem;
    public GameObject Player;
    public GameObject InsPos;
    public GameObject BlackBG;
    private bool Show = true;
    public Play_Clock PlayClock;

    private Level_Score LevelScore;

    public TextAsset ObjText;
    public GameObject ItemToGive;
    public int StartLine;
    public int FinishLine;

    public bool showTextBox;

    private bool FoundAlbum = false;
    private bool FoundTelp = false;
    private bool FoundAlphabet = false;


    void Start()
    {
        PlayClock = FindObjectOfType<Play_Clock>();
        DialogTrigger = FindObjectOfType<Dialog_1>();
        GameManager = FindObjectOfType<_GameManager>();
        InvenItem = FindObjectOfType<ShowItem_Inven>();
        LevelScore = FindObjectOfType<Level_Score>();
        ScoreUpdate = FindObjectOfType<UpdateScore>();
        Playermove = FindObjectOfType<Player_move>();
        dialogtext = FindObjectOfType<Dialog_text>();
        showTextBox = dialogtext.appear;
        Physics2D.queriesHitTriggers = true;
    }

    public IEnumerator ShowBigItem(GameObject GivenItem)
    {
        Vector3 BGPos = new Vector3(InsPos.transform.position.x, InsPos.transform.position.y, -1);
        Instantiate(BlackBG, BGPos, Quaternion.identity);
        Instantiate(GivenItem, InsPos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        Show = false;
    }

    //void Detect(Collider2D other)
    void OnMouseDown() {
        /*{
            if (other.tag == "Player")
            {
                if (Input.GetKey(KeyCode.Mouse0) && Show == true)
                {*/
        
        if (Playermove.EnableMove && !showTextBox)
        {
            AUdio.GetComponent<AudioSource>().Play();
            if (gameObject.name == "SmallTelp")
            {
                FoundTelp = true;
                Debug.Log(FoundTelp);
				InputfielTelp.SetActive (true);
                //PlayClock.StartClockAnim();
            }
            else if (gameObject.name == "alphabet")
            //else if(gameObject.name == "alphabet")
            {
                Debug.Log("EndGame");
                FoundAlphabet = true;
                //trigger end of level
                //Instantiate(BlackBG, InsPos.transform.position, Quaternion.identity);
				InputfielAlfabet.SetActive (true);
                //LevelScore.ActiveSet();
            }

            else {
                Show = false;
                GameManager.CurrentlyFound = true;
                StartCoroutine(ShowBigItem(BigItem));
                DialogTrigger.Atrigger(ObjText, ItemToGive, StartLine, FinishLine);
                //Instantiate(BlackBG, InsPos.transform.position, Quaternion.identity);
                if (gameObject.tag == "Barang")
                {
                    //munculkan ikonnya bila ini memang suatu benda yang penting
                    LevelScore.ScoreBarang += 200;
                    ScoreUpdate.NewScore(200);
                    InvenItem.GetNewItem(ItemToGive);
                    gameObject.SetActive(false);
                }
                else if (gameObject.tag == "Perkakas")
                {
                    //munculkan ikonnya bila ini memang suatu benda yang penting
                    LevelScore.ScorePerkakas += 200;
                    ScoreUpdate.NewScore(200);
                    InvenItem.GetNewItem(ItemToGive);
                    gameObject.SetActive(false);
                }


                //Destroy(gameObject);
                //kirim pesan nama object ke game manager
                //insatntiate gambar di tengah kamera, blackout backgroundya
                //Instantiate(Key, gameObject.transform.position, Quaternion.identity);
                    }
                }

            }
        
    //}



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
