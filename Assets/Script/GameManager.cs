using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TMP_Text gameOverText;
    // [SerializeField] PlayerController player;
    [SerializeField] Hole hole;
    private void Start()
    {
        gameOverPanel.SetActive(false);
    }

    private void Update()
    {
        if (hole.Entered && gameOverPanel.activeInHierarchy == false)
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = "CONGRATULATIONS";
        }
    }

    public void BactToMainMenu()
    {
        SceneLoader.Load("MainMenu");
    }

    public void NextLevel(string name){
        SceneLoader.Load(name);
    }

    public void Replay()
    {
        SceneLoader.ReloadLevel();
    }

    public void PlayNext()
    {
        SceneLoader.LoadNextLevel();
    }
}
