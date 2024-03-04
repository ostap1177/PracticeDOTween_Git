using UnityEngine;
using DG.Tweening;

public class TurnTo : MonoBehaviour
{
    [SerializeField] private Vector3 _endPoint;
    [SerializeField] private float _duration;
    [SerializeField] private int _loopsCount;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Start()
    {
        _transform.DORotate(_endPoint, _duration).SetLoops(_loopsCount,LoopType.Yoyo);
    }
}
