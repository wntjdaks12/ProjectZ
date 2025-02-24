using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        GameApplication.Instance.EntityController.Spawn<Hero, HeroObject>(10001, Vector3.zero, Quaternion.identity);
    }
}
