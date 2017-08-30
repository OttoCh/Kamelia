using UnityEngine;
using System.Collections;

public class Play_Clock : MonoBehaviour {
    //public GameObject Clock;
    public Animator Anim;

    public IEnumerator ClockWait(GameObject Player)
    {
        float ZoomCamera = 0.5f;
        float DefaultSize = Player.GetComponent<Camera>().orthographicSize;
        Player.GetComponent<BoxCollider2D>().isTrigger = true;
        Player.GetComponent<Camera>().orthographicSize = ZoomCamera;
        yield return new WaitForSeconds(28);
		Anim.SetInteger("Code", 0);
		Player.GetComponent<Player_move>().EnableMove = true;
        Player.GetComponent<Camera>().orthographicSize = DefaultSize;
        Player.GetComponent<BoxCollider2D>().isTrigger = false;
    }

    public void StartClockAnim()
    {
        GameObject Player;
        Player = GameObject.FindGameObjectWithTag("Player");
        Player.GetComponent<Player_move>().EnableMove = false;
        Anim = GetComponent<Animator>();
        //gameObject.PlayAnimation();
        //gameObject.GetComponent<Animation>().Play("ClockCode");
        Anim.SetInteger("Code", 1);
        Player.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -1);
        StartCoroutine(ClockWait(Player));
        
    }

}
