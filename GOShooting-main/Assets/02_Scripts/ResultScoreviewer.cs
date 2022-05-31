using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultScoreviewer : MonoBehaviour
{
  TextMeshProUGUI textscore;
  private void Start()
  {
    textscore = GetComponent<TextMeshProUGUI>();
    int score = PlayerPrefs.GetInt("Score");
    textscore.text="Result Score"+score;
  }
}
