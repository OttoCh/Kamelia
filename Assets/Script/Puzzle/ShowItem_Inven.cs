using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowItem_Inven : MonoBehaviour {

    private Dialog_1 Dialogtext;
    private _GameManager Gamemanager;
    public string InvenName;
    private Vector3[] InsPos;
    public GameObject[] ButtonList;
    public GameObject BlackBG;
    public GameObject[] GivenItem; //!!!
    public GameObject DumCollect;
    public GameObject[] GameHint;
    public TextAsset ObjText;
    public int FinishLine;
    public int StartLine;

    void Start()
    {
        Gamemanager = FindObjectOfType<_GameManager>();
    }

    public void ShowInven(int SelectedItem)
    {
        if (!Gamemanager.CurrentlyFound)
        {
            Debug.Log(SelectedItem);
            if (GivenItem[SelectedItem] == null)
            {
                return;
            }
            Debug.Log(GivenItem[SelectedItem]);
            string ItemName = GivenItem[SelectedItem].name;
            int idx = ItemName.LastIndexOf("Icon");
            string newStr;

            if (idx > -1)
            {
                newStr = ItemName.Remove(idx);
            }
            else newStr = ItemName;
            GameObject ItemtoGive;

            switch (newStr)
            {
                case ("BigAlbum"): { ItemtoGive = GameHint[0]; break; }
                case ("BigKey"): { ItemtoGive = GameHint[1]; break; }
                default: return;
            }

            Debug.Log(newStr);
            //panggil gambarnya
            DumCollect.GetComponent<Collect>().CoroutineBegin(ItemtoGive);
            //panggil dialognya
            Dialogtext = FindObjectOfType<Dialog_1>();
            Dialogtext.Atrigger(ObjText, null, StartLine, FinishLine);
            Gamemanager.CurrentlyFound = true;
        }
    }

    void InstantiateIcon(GameObject GameIcon)
    {
        //munculkan iconnya di posisi yang seharusnya
        string idx = GameIcon.name;
        for (int i = 0; i < 8; i++)
        {
            if(idx == GivenItem[i].name)
            {
                GameObject FindText = gameObject.transform.Find("Text (" + i + ")").gameObject;
                FindText.GetComponent<Text>().color = Color.grey;
            }
        }
        /*
        //munculkan iconnya di posisi yang seharusnya
        for (int i = 0; i < 4; i++)
        {
            
            if (GivenItem[i] == null)
            {
                GivenItem[i] = GameIcon;
                Vector3 ButtonPos = gameObject.transform.FindChild("Item " + i).FindChild("InsPosInven").position;
                //Vector3 ButtonPos = new Vector3( 0, 0, -1 );
				(Instantiate(GameIcon, ButtonPos, Quaternion.identity) as GameObject).transform.SetParent(ButtonList[i].transform.FindChild("InsPosInven").transform);

                i = 4;
            }
        }*/
    }

    public void GetNewItem(GameObject FoundItem)
    {
        if (FoundItem != null)
        {
            InstantiateIcon(FoundItem);
        }
    }

}
