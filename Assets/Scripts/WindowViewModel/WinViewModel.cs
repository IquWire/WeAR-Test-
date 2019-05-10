using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinViewModel : BaseViewModel
{
    private WinView WinView;

    public override void Init()
    {
        base.Init();
    }

    public override void LoadView()
    {
        WinView = WindowsViewHolder.Instance.WinView;
    }

    public override void OpenWindow()
    {
        WinView.gameObject.SetActive(true);
    }

    public override void SetupWindow()
    {

    }

    public override void CloseWindow()
    {
        WinView.gameObject.SetActive(false);
    }
}
