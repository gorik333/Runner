using UnityEngine;

public class EnemyCollisionController : MonoBehaviour
{
    private bool _isDestroyed;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<AllyCollisionController>() != null && !_isDestroyed)
        {
            DestroyPlayerAlly(collision);   
        }
    }


    private void DestroyPlayerAlly(Collision collision)
    {
        CrowdCount.Instance.DecreaseCrowdAmount();

        _isDestroyed = true;

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
