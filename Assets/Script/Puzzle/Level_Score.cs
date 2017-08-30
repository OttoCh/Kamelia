using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level_Score : MonoBehaviour {

    public GameObject ClearPanel;
    public GameObject ItemPanel;
    public GameObject opt;
    public GameObject ScorePanel;
    public Text TotalBarang;
    public Text Puzzle;
    public Text Perkakas;
    public Text TotalSkor;
    public Text Ranking;
    public Text SuccessFail;

    public float ScoreBarang;
    public float ScorePuzzle;
    public float ScorePerkakas;
    public float ScoreTotal;
    public string ScoreRanking;
    public string Fail = "FAIL";

    public void ActiveSet()
    {
        ScoreTotal = ScoreBarang + ScorePerkakas + ScorePuzzle;
        if(ScoreTotal <= 200)
        {
            ScoreRanking = "C";
            SuccessFail.text = Fail;
            SuccessFail.color = Color.red;
        }
        else if(ScoreTotal > 200 && ScoreTotal <= 600)
        {
            ScoreRanking = "B";
        }
        else if(ScoreTotal > 600 && ScoreTotal <= 1000)
        {
            ScoreRanking = "A";
        }
        TotalBarang.text = ScoreBarang.ToString();
        Puzzle.text = ScorePuzzle.ToString();
        Perkakas.text = ScorePerkakas.ToString();
        TotalSkor.text = ScoreTotal.ToString();
        Ranking.text = ScoreRanking;

        ItemPanel.SetActive(false);
        opt.SetActive(false);
        ClearPanel.SetActive(true);
        ScorePanel.SetActive(false);
    }

}
