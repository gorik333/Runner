using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private RaycastHit hit;


    void Update()
    {
        GetTouchPosition();
    }


    public Vector3 GetTouchPosition()
    {
        if (Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray, out hit))
            {
                return hit.point;
            }
        }

        return Vector3.zero;
    }
}
