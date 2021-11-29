using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out AllyMovement allyMovement) && allyMovement.IsColumnAlly)
        {
            DestroyOutOfAreaAllies(other);
        }
    }


    private void DestroyOutOfAreaAllies(Collider collider)
    {
        Destroy(collider);

        CrowdCount.Instance.DecreaseCrowdAmount();
    }
}
