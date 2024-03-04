using UnityEngine;

public class DimensionalChangeTo : MonoBehaviour
{
    [SerializeField] protected Vector3 _endPoint;
    [SerializeField] protected float _duration;
    [SerializeField] protected int _loopsCount;

    protected Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }
}
