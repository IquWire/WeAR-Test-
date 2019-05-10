using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowsViewHolder : MonoBehaviour
{
    public static WindowsViewHolder Instance;

    #region ViewsReference  
    public FindTargetView FindTargetView;
    public CountdawnView CountdawnView;
    public GameplayView GameplayView;
    public WinView WinView;
    public LoseView LoseView;
    public PauseView PauseView;
    #endregion

    #region ViewModelsReference 
    public FindTargetViewModel FindTargetViewModel;
    public CountdawnViewModel CountdawnViewModel;
    public GameplayViewModel GameplayViewModel;
    public WinViewModel WinViewModel;
    public LoseViewModel LoseViewModel;
    public PauseViewModel PauseViewModel;
    #endregion


    public void Start()
    {
        CreateSingleton();
        
        CreateViewModels();
    }

    private void CreateSingleton()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void CreateViewModels()
    {
        FindTargetViewModel = new FindTargetViewModel();
        CountdawnViewModel = new CountdawnViewModel();
        GameplayViewModel = new GameplayViewModel();
        WinViewModel = new WinViewModel();
        LoseViewModel = new LoseViewModel();
        PauseViewModel = new PauseViewModel();

        FindTargetViewModel.Init();
        CountdawnViewModel.Init();
        GameplayViewModel.Init();
          WinViewModel.Init(); 
         LoseViewModel.Init();
        PauseViewModel.Init();

        FindTargetViewModel.SetupWindow();
        CountdawnViewModel.SetupWindow();
        GameplayViewModel.SetupWindow();
          WinViewModel.SetupWindow();
         LoseViewModel.SetupWindow();
        PauseViewModel.SetupWindow();

        FindTargetViewModel.OpenWindow();
        //CountdawnViewModel.OpenWindow();
    }
}
