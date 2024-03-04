using DG.Tweening;

public class TurnTo : DimensionalChangeTo
{
    private void Start()
    {
        _transform.DORotate(_endPoint, _duration).SetLoops(_loopsCount,LoopType.Yoyo);
    }
}
