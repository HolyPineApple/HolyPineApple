using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public int ScoreValue;
  
    void Update()
    {
        ScoreText.text = "Box-" + ScoreValue;
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(0);
    }
}
