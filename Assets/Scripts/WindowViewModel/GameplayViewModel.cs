using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayViewModel : BaseViewModel
{
    private GameplayView GameplayView;
    
    public override void Init()
    {
        base.Init();
    }

    public override void LoadView()
    {
        GameplayView = WindowsViewHolder.Instance.GameplayView;
    }

    public override void OpenWindow()
    {
        GameplayView.gameObject.SetActive(true);

        GameController.Instance.ObservableScore.SetEvent += BindScoreText;
        GameController.Instance.Player.CurrentHealth.SetEvent += BindLivesText;        

        ServicesHolder.Instance.CustomTrackableEvents.OnTrackingLostEvent += OpenPauseWindow;

        GameController.Instance.WinEvent += OpenWinWindow;
        GameController.Instance.LoseEvent += OpenLoseWindow;

        GameController.Instance.Setup();
    }

    public override void SetupWindow()
    {

    }

    public override void CloseWindow()
    {
        GameController.Instance.ObservableScore.SetEvent -= BindScoreText;
        GameController.Instance.Player.CurrentHealth.SetEvent -= BindLivesText;

        GameController.Instance.WinEvent -= OpenWinWindow;
        GameController.Instance.LoseEvent -= OpenLoseWindow;

        ServicesHolder.Instance.CustomTrackableEvents.OnTrackingLostEvent -= OpenPauseWindow;

        GameplayView.gameObject.SetActive(false);
    }
    

    private void BindScoreText(int numb)
    {
        GameplayView.ScoreText.text = numb.ToString();
    }

    private void BindLivesText(int numb)
    {
        GameplayView.HealthText.text = numb.ToString();
    }

    private void OpenPauseWindow()
    {
        ServicesHolder.Instance.CustomTrackableEvents.OnTrackingLostEvent -= OpenPauseWindow;
        WindowsViewHolder.Instance.PauseViewModel.OpenWindow();
    }

    public void OpenWinWindow()
    {
        WindowsViewHolder.Instance.WinViewModel.OpenWindow();
    }

    public void OpenLoseWindow()
    {
        WindowsViewHolder.Instance.LoseViewModel.OpenWindow();
    }
}
