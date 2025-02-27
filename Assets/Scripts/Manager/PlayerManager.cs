using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager instance;
    public static PlayerManager Instance { get => instance ??= FindAnyObjectByType<PlayerManager>(); }

    public CharacterObject CharacterObject { get; set; }

}
