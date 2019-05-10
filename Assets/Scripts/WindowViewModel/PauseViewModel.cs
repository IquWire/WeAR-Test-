using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseViewModel : BaseViewModel
{
    private PauseView PauseView;
    private PauseService PauseService;
    private CustomTrackableEvents CustomTrackableEvents;

    public override void Init()
    {
        base.Init();
        PauseService = ServicesHolder.Instance.PauseService;
        CustomTrackableEvents = ServicesHolder.Instance.CustomTrackableEvents;
    }

    public override void LoadView()
    {
        PauseView = WindowsViewHolder.Instance.PauseView;
    }

    public override void OpenWindow()
    {
        PauseService.Pause();
        CustomTrackableEvents.OnTrackingFoundEvent += CloseWindow;
        PauseView.gameObject.SetActive(true);
    }

    public override void SetupWindow()
    {

    }

    public override void CloseWindow()
    {
        PauseService.UnPause();
        CustomTrackableEvents.OnTrackingFoundEvent -= CloseWindow;
        PauseView.gameObject.SetActive(false);
    }
}
