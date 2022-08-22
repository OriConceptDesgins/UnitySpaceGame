
using UnityEngine;

public class CloudRotation : MonoBehaviour
{
    [SerializeField] private float rotation;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotation, 0, Space.Self);
    }
}
