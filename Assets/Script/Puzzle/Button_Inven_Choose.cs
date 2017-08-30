using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button_Inven_Choose : MonoBehaviour {
//Ini script untuk kasi item ke player	
	//public Image Eifel;
	public GameObject Eifel;
	public GameObject[] ButtonList;		//list semua button yang ada (inven kosong)

	private GameObject InventoryDummy;
	//public Transform Eifel;
	private int OccupiedInven = 0;
	private bool AddItemAgain = true;
	private int TotalButton;
	public GameObject EmptyInven;

	public void AddItem(GameObject ItemtoAdd) {
		TotalButton = ButtonList.Length;
		Eifel = ItemtoAdd;
		Debug.Log("Eifel =" + Eifel);
		for(int i = 0; i < TotalButton; i++) {
			if(ButtonList[i].transform.Find("Inventory(Clone)") == null) {
				EmptyInven = ButtonList[i].gameObject;
				i = TotalButton;		//breakloop
			}
			//UnityEngine.Object Eifel = Resources.Load("Image.prefab") as Image;
			//UnityEngine.Object pPrefab = Resources.Load("Assets/Prefab/Items/Key_yellow"); // note: not .prefab!
		}

		//masih bisa ditambah item?

		if(AddItemAgain) {
		InventoryDummy = new GameObject("Inventory");
		(Instantiate(InventoryDummy, EmptyInven.transform.position, EmptyInven.transform.rotation) as GameObject).transform.parent = EmptyInven.transform;
		(Instantiate(ItemtoAdd, EmptyInven.transform.position, EmptyInven.transform.rotation) as GameObject).transform.parent = EmptyInven.transform;
		//(Instantiate(Eifel, EmptyInven.transform.position, EmptyInven.transform.rotation) as  GameObject).transform.parent = EmptyInven.transform; //memunculkan Eifel sebagai child dari EmptyInven
		//(Instantiate(Eifel, EmptyInven.transform.position, EmptyInven.transform.rotation) as Image).transform.SetParent(EmptyInven.transform, true); //sama persis efeknya dengan yg diatas, tapi sekarang bisa diatur orientasi koordinatnya. pakai ini kalo mau instantiate image
			OccupiedInven += 1;
			if(OccupiedInven >= TotalButton) {
				OccupiedInven = TotalButton;
				AddItemAgain = false;}
			else {
				AddItemAgain = true;
			}
		}
		else if(!AddItemAgain) {
			//add some text
			Debug.Log ("Inventory Full");
		}
	}


	//Add item  [v]
	//hover item info	[]
	//use item			[]
	//remove item		[]

}
