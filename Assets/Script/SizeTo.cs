using DG.Tweening;

public class SizeTo : DimensionalChangeTo
{
    private void Start()
    {
        _transform.DOScale(_endPoint,_duration).SetLoops(_loopsCount,LoopType.Yoyo);
    }
}
