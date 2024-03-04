using DG.Tweening;

public class MoveTo : DimensionalChangeTo
{
    private void Start()
    {
        _transform.DOMove(_endPoint, _duration).SetLoops(_loopsCount,LoopType.Yoyo);
    }
}
