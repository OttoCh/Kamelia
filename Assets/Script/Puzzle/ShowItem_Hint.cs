using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowItem_Hint : MonoBehaviour {

    public GameObject PanelActive;

    public void ActiveSet()
    {
        
        //instantiate
        //ganti text

    }

    public IEnumerator Show()
    {
        PanelActive.SetActive(true);
        yield return new WaitForSeconds(3);
        PanelActive.SetActive(false);
    }

}
