using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _allyPrefab;


    void Start()
    {
        SpawnFirstAlly();
    }


    void SpawnFirstAlly()
    {
        var movement = Instantiate(_allyPrefab, transform.position, Quaternion.identity).GetComponent<AllyMovement>();

        movement.BecomeColumnAlly();
    }
}
