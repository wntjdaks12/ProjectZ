using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private HUDPanel HUDPanel; // �ӽ�

    private static GameManager instance;
    public static GameManager Instance { get => instance ??= FindObjectOfType<GameManager>(); }

    private void Start()
    {
        var heroObj = GameApplication.Instance.EntityController.Spawn<Hero, HeroObject>(10001, Vector3.zero, Quaternion.identity);

        CameraManager.Instance.PlayerCam.Follow = heroObj.transform; // �÷��̾� ī�޶� ���
        PlayerManager.Instance.CharacterObject = heroObj; // �÷��̾� �Ŵ����� ���

        HUDPanel.ViewModel.CharacterObject = heroObj; // �ӽ�
    }
}
