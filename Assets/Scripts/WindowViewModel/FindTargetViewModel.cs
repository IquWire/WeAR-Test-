using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTargetViewModel : BaseViewModel
{
    private FindTargetView FindTargetView;
    private CustomTrackableEvents CustomTrackableEvents;

    public override void Init()
    {
        base.Init();
        CustomTrackableEvents = ServicesHolder.Instance.CustomTrackableEvents;
    }

    public override void LoadView()
    {
        FindTargetView = WindowsViewHolder.Instance.FindTargetView;
    }

    public override void OpenWindow()
    {
        FindTargetView.gameObject.SetActive(true);
        CustomTrackableEvents.OnTrackingFoundEvent += GoToNextWindow;
    }

    public override void SetupWindow()
    {

    }

    public override void CloseWindow()
    {
        FindTargetView.gameObject.SetActive(false);
    }
    
    public void GoToNextWindow()
    {
        CloseWindow();
        WindowsViewHolder.Instance.CountdawnViewModel.OpenWindow();
        CustomTrackableEvents.OnTrackingFoundEvent -= GoToNextWindow;
    }
}
