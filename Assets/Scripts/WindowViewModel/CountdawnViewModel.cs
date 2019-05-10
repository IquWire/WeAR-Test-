
public class CountdawnViewModel : BaseViewModel
{
    private CountdawnView CountdawnView;
    public CountDawnModel CountDawnModel;

    public override void Init()
    {
        base.Init();
        CountDawnModel = new CountDawnModel();        
    }

    public override void LoadView()
    {
        CountdawnView = WindowsViewHolder.Instance.CountdawnView;
    }

    public override void OpenWindow()
    {
        CountDawnModel.Setup(4, 1);
        CountdawnView.gameObject.SetActive(true);
    }

    public override void SetupWindow()
    {
        CountDawnModel.ObservableCountString.SetEvent += SetupCountDawnText;
        CountDawnModel.EndCountAction = EndCountAction;
    }

    public void SetupCountDawnText(string text)
    {
        CountdawnView.CountdawnText.text = text;
    }

    public override void CloseWindow()
    {
        CountdawnView.gameObject.SetActive(false);
    }

    public void GoToNextWindow()
    {
        CloseWindow();
        WindowsViewHolder.Instance.GameplayViewModel.OpenWindow();
    }

    private void EndCountAction(int time)
    {
        GoToNextWindow();
    }
}
