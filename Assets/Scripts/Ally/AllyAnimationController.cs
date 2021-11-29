using UnityEngine;

public class AllyAnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator _allyAnimator;


    public void StartRunningAnim()
    {
        _allyAnimator.SetTrigger("StartRunning");
    }
}
