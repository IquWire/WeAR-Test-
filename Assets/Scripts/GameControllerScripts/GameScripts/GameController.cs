using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public event Action WinEvent;
    public event Action LoseEvent;

    public PlayerController Player;

    public EnemySpawner EnemySpawner;

    public GameConfig Config;

    public ObservableFloat ObservableCurrentSpeed = new ObservableFloat();
    public ObservableInt ObservableScore = new ObservableInt();

    public void Awake ()
    {
        CreateInstance();
        gameObject.SetActive(false);
    }

    private void CreateInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else { Destroy(gameObject);}
    }

    public void Setup()
    {
        gameObject.SetActive(true);

        Config.Init(this);

        ObservableCurrentSpeed.Item = Config.StartSpeed;
        Player.Setup();

        ServicesHolder.Instance.TimeService.StartCount(null, Config.FreqIncreaseSpeed, SpeedIncreaser, Int32.MaxValue, null, TimeService.EndlesTime.Endless);

        EnemySpawner.ActiveSpawner();
        ObservableScore.Item = 0;
    }

    public void IncreaseScore(int amount)
    {
        ObservableScore.Item += amount;
    }

	void Update ()
    {
        if (Config.WinCondition.CheckWin())
        {
            OnWin();
        }

        if (Config.LoseCondition.CheckLose())
        {
            OnLose();
        }
	}

    private void OnWin()
    {
        if (WinEvent != null)
        {
            WinEvent.Invoke();
        }
    }

    private void OnLose()
    {
        if (LoseEvent != null)
        {
            LoseEvent.Invoke();
        }
    }

    public void SpeedIncreaser(int time)
    {
        ObservableCurrentSpeed.Item *= Config.SpeedMultiplier;
    }
}
