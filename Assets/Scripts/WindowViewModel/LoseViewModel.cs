using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseViewModel : BaseViewModel
{
    private LoseView LoseView;

    public override void Init()
    {
        base.Init();
    }

    public override void LoadView()
    {
        LoseView = WindowsViewHolder.Instance.LoseView;
    }

    public override void OpenWindow()
    {
        LoseView.gameObject.SetActive(true);
    }

    public override void SetupWindow()
    {

    }

    public override void CloseWindow()
    {
        LoseView.gameObject.SetActive(false);
    }

    //vm
    public void GoToNextWindow()
    {
        CloseWindow();
        WindowsViewHolder.Instance.CountdawnViewModel.OpenWindow();
    }
}
