using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private HUDPanel HUDPanel; // 임시

    private static GameManager instance;
    public static GameManager Instance { get => instance ??= FindObjectOfType<GameManager>(); }

    private void Start()
    {
        var heroObj = GameApplication.Instance.EntityController.Spawn<Hero, HeroObject>(10001, Vector3.zero, Quaternion.identity);

        CameraManager.Instance.PlayerCam.Follow = heroObj.transform; // 플레이어 카메라에 등록
        PlayerManager.Instance.CharacterObject = heroObj; // 플레이어 매니저에 등록

        HUDPanel.ViewModel.CharacterObject = heroObj; // 임시
    }
}
