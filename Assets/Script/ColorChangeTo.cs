using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChangeTo : MonoBehaviour
{
    [SerializeField] private Color _endColor;
    [SerializeField] private float _timeToPoint;
    [SerializeField] private int _loopsCount;

    private Transform _transform;
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _transform = transform;
        _meshRenderer = _transform.GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        _meshRenderer.material.DOColor(_endColor, _timeToPoint).SetLoops(_loopsCount,LoopType.Yoyo);
    }
}
