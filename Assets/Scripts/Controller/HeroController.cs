using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroController : MonoBehaviour
{
    public HeroObject HeroObject;

    private void Update()
    {
        var xAxis = Input.GetAxis("Horizontal");
        var zAxis = Input.GetAxis("Vertical");

        var dirVec3 = new Vector3(xAxis, 0, zAxis);

        if (dirVec3 != Vector3.zero)
        {
            HeroObject.OnRun(dirVec3, 0);
        }
        else
        {
            HeroObject.OnIde();
        }
    }
}
