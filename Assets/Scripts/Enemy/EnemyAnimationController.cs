using UnityEngine;

public class EnemyAnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator _enemyAnimator;


    void Start()
    {
        _enemyAnimator.SetTrigger("StartIdle");    
    }
}
