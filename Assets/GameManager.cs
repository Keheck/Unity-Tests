using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool HasEnded { get; private set; } = false;
    public GameObject lvlComplUI;

    public void GameOver()
    {
        if(!HasEnded)
        {
            Time.timeScale = 0.25f;
            Time.fixedDeltaTime *= 0.25f;

            Debug.Log("Game Over :(");
            HasEnded = true;
            Invoke(nameof(Restart), .5f);
        }
    }

    public void NextLevel()
    {
        lvlComplUI.SetActive(true);
    }

    void Restart()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime *= 4f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
