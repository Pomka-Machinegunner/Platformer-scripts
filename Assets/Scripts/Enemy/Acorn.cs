using UnityEngine;

public class Acorn : MonoBehaviour
{
    [SerializeField] Vector3 _velocity;
    [SerializeField] float _maxRotationSpeed;
    void Start()
    {
        GetComponent<Rigidbody>().AddRelativeForce(_velocity, ForceMode.VelocityChange);
        GetComponent<Rigidbody>().angularVelocity = new Vector3(
            Random.Range(-_maxRotationSpeed, _maxRotationSpeed),
            Random.Range(-_maxRotationSpeed, _maxRotationSpeed),
            Random.Range(-_maxRotationSpeed, _maxRotationSpeed)
            );
    }
}
