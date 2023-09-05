using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    public GameObject win;
    public GameObject lose;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        lose.SetActive(true);
        Time.timeScale = 0;
    }
    public void IncreaseScore()
    {
        score++;
    }
    public void WinGame()
    {
        win.SetActive(true);
        Time.timeScale = 0;
    }
    public void LoseGame()
    {

    }
    public void BackToMain()
    {
        SceneManager.LoadScene("FAE_Demo1");

    }
    public void ResetScene()
    {
        SceneManager.LoadScene("SwimmingMinigame");
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 10)
        {
            WinGame();
        }
    }

}
