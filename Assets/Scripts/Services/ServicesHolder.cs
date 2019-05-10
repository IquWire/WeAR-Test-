using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServicesHolder : MonoBehaviour
{
    public static ServicesHolder Instance;

    public TimeService TimeService;
    public PauseService PauseService = new PauseService();
    public CustomTrackableEvents CustomTrackableEvents;
    public ParticleCreator ParticleCreator;

    public void Awake()
    {
        CreateSingleton();

        SetupServices();
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

    private void SetupServices()
    {
        TimeService.StartService();
        CustomTrackableEvents.StartService();
        ParticleCreator.StartService();
    }
}
