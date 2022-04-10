using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance; // 1

    [HideInInspector]
    public int sheepSaved; // 2

    [HideInInspector]
    public int sheepDropped; // 3

    public int sheepDroppedBeforeGameOver; // 4
    public SheepSpawn sheepSpawner; // 5

    void awake()
    {
        Instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title");
        }

    }
    public void SavedSheep()
    {
        UIManager.Instance.UpdateSheepSaved();
        sheepSaved++;
    }
    private void GameOver()
    {
        sheepSpawner.canSpawn = false; // 1
        sheepSpawner.DestroyAllSheep(); // 2
        UIManager.Instance.ShowGameOverWindow();
    }
    public void DroppedSheep()
    {
        sheepDropped++; // 1
        UIManager.Instance.UpdateSheepDropped();
        if (sheepDropped == sheepDroppedBeforeGameOver) // 2
        {
            GameOver();
        }
    }

}
