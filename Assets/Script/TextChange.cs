using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChange : MonoBehaviour
{
    [SerializeField] private string _textToChange;
    [SerializeField] private string _textToAgg;
    [SerializeField] private string _textTOScramble;
    [SerializeField] private float _duration;
    [SerializeField] private int _loopsCount;

    private Text _text;
    private Sequence _sequence;

    private void Awake()
    {
        _sequence = DOTween.Sequence();
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        _sequence.Append(_text.DOText(_textToChange, _duration));
        _sequence.Append(_text.DOText(_textToAgg, _duration).SetRelative());
        _sequence.Append(_text.DOText(_textTOScramble, _duration, true, ScrambleMode.All));


        //_text.DOText(_textToChange,_duration);
        //_text.DOText(_textToAgg, _duration).SetRelative();
        //_text.DOText(_textTOScramble, _duration, true, ScrambleMode.All);
    }
}
