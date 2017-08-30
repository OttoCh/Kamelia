using UnityEngine;
using System.Collections;

public class StartOpacity : MonoBehaviour {

    private _GameManager GameManager;

    SpriteRenderer spRend;
    Color col;
    int CanDestroy = 0;

	// Use this for initialization
	void Awake () {
        // store a reference to the SpriteRenderer on the current GameObject
        spRend = gameObject.transform.GetComponent<SpriteRenderer>();
        // copy the SpriteRenderer's color property
        col = spRend.color;
        //  change col's alpha value (0 = invisible, 1 = fully opaque)
        col.a = 0.0f; // 0.5f = half transparent
        // change the SpriteRenderer's color property to match the copy with the altered alpha value
        spRend.color = col;
        StartCoroutine(IncreaseOpacity(col, spRend));
        GameManager = FindObjectOfType<_GameManager>();
    }

    public void BeginFade()
    {
        StartCoroutine(DecreaseCapacity(col, spRend));
    }

    public void BeginShow()
    {
        StartCoroutine(IncreaseOpacity(col, spRend));
    }

    public IEnumerator IncreaseOpacity(Color col, SpriteRenderer spRend)
    {
        float m = 0;
        for(int i = 0; i <= 10; i++)
        {
            m = m + 0.1f;
            col.a = m;
            spRend.color = col;
            yield return new WaitForSeconds(0.01f);
        }
        GameManager.ObjName = this.name;
    }
    

    public IEnumerator DecreaseCapacity(Color col, SpriteRenderer spRend)
    {
        float m = 1;
        for (int i = 0; i <= 10; i++)
        {
            m = m - 0.1f;
            col.a = m;
            spRend.color = col;
            yield return new WaitForSeconds(0.01f);
        }
        Destroy(gameObject);
    }



}
