using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [field: SerializeField]
    public CinemachineVirtualCamera PlayerCam { get; private set; }

    private static CameraManager instance;
    public static CameraManager Instance { get => instance ??= FindObjectOfType<CameraManager>();}
}
