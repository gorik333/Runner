using UnityEngine;

public class AllyCollisionController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out AllyMovement allyMovement) && !allyMovement.IsColumnAlly)
        {
            allyMovement.BecomeColumnAlly();
        }
    }
}
