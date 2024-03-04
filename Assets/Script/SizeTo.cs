using DG.Tweening;
using UnityEngine;

public class SizeTo : MonoBehaviour
{
    [SerializeField] private Vector3 _endScale;
    [SerializeField] private float _duration;
    [SerializeField] private int _loopsCount;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Start()
    {
        _transform.DOScale(_endScale,_duration).SetLoops(_loopsCount,LoopType.Yoyo);
    }
}
