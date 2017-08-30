using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateScore : MonoBehaviour {

    int CurrentScore = 0;

    public void NewScore(int Score)
    {
        CurrentScore += Score;
        gameObject.GetComponent<Text>().text = CurrentScore.ToString();
    }



}
