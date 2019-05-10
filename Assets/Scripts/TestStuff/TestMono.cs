using UnityEngine;


public class TestCl1
{
    public CustomObservableProperty<int> obsMumb = new ObservableInt();

    public void Init()
    {
        obsMumb.Item = 10;
        Debug.Log("Inited1");
    }
}

public class TestCl2
{
    public TestCl1 testCl1;

    public void Init(TestCl1 tc1)
    {
        testCl1 = tc1;
        Setup();
        Debug.Log("Inited2");
    }

    public void Setup()
    {
        testCl1.obsMumb.SetEvent += SetCl;
        testCl1.obsMumb.GetEvent += GetCl;
    }

    public void SetCl(int numb)
    {
        Debug.Log("setted + " + numb);

    }

    public void GetCl(int numb)
    {
        Debug.Log("getted + " + numb);
    }
}

public class TestMono : MonoBehaviour
{
    private TestCl1 tes1;
    private TestCl2 tes2;

    public int numb;

    void Start ()
    {
        tes1 = new TestCl1();	
        tes2 = new TestCl2();

        tes2.Init(tes1);
        tes1.Init();
    }
	
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            tes2.testCl1.obsMumb.Item = numb;
        }
	}
}
