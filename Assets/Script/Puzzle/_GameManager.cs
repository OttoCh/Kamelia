using UnityEngine;
using System.Collections;

public class _GameManager : MonoBehaviour {


    //Important var
    public bool BookFound;
    public GameObject Clock;
    //

    public string ObjName;
    public bool CurrentlyFound = false;



    //untuk menghilangkan object yang baru ditemukan
    public void Obj_Destroy()
    {
        if (CurrentlyFound)
        {
            GameObject FoundObj;
            GameObject Background;
            FoundObj = GameObject.Find(ObjName);
            Background = GameObject.Find("BlackBG(Clone)");
            FoundObj.GetComponent<StartOpacity>().BeginFade();
            Background.GetComponent<StartOpacity>().BeginFade();
            
            //Jika buku ditemukan
            if (FoundObj.name == "BigAlbum(Clone)")
            {
                BookFound = true;
                Debug.Log("BIG ALBUM");
            }
            //Jika buku sudah ditemukan dan interaksi dengan telepon
            //hal yang sama terjadi sampai muncul, lalu menunggu suatu bool berubah, jika sudah berubah tutup segera dengan disabletext() dan mulai mainkan animasi jam dinding. 
            if(BookFound && FoundObj.name == "BigTelp(Clone)")
            {
                Debug.Log("FOUND TELP");
            }
            CurrentlyFound = false;
        }
    }

}
