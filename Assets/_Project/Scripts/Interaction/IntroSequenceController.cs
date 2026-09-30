using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.Playables;

public sealed class IntroSequenceController : MonoBehaviour
{
    [SerializeField] private PlayableDirector director;
    [SerializeField] private FirstPersonController playerController;
    [SerializeField] private CinemachineCamera introCamera;
    [SerializeField] private RunRecordManager runRecordManager;

    private void Start()
    {
        if (director == null || director.playableAsset == null)
        {
            BeginGameplay();
            return;
        }

        if (playerController != null)
            playerController.SetControlsEnabled(false);

        director.stopped += OnDirectorStopped;
        director.Play();
    }

    private void OnDirectorStopped(PlayableDirector stoppedDirector)
    {
        BeginGameplay();
    }

    private void BeginGameplay()
    {
        if (introCamera != null)
            introCamera.gameObject.SetActive(false);
        if (playerController != null)
            playerController.SetControlsEnabled(true);
        if (runRecordManager != null)
            runRecordManager.BeginRun();
    }

    private void OnDestroy()
    {
        if (director != null)
            director.stopped -= OnDirectorStopped;
    }
}
