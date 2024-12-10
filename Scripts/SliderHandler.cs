using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    private Slider _slider;

    private float _value;
    private float _minValue = 0;
    private float _maxValue = 100;
    private float _delay = 1;

    private void Awake()
    {
        _slider = GetComponent<Slider>();

        _slider.maxValue = _maxValue;
        _slider.minValue = _minValue;

        _value = _maxValue;
        _slider.value = _maxValue;

        UpdateText();
    }
    
    public void ChangeValue(float value)
    {
        _value += value;

        ValidateValue();

        _slider.value = _value;

        UpdateText();
    }

    private void ValidateValue()
    {
        if (_value > _maxValue)
        {
            _value = _maxValue;
        }

        if (_value < _minValue)
        {
            _value = _minValue;
        }
    }

    private void UpdateText()
    {
        _text.text = _value.ToString() + "/" + _maxValue;
    }

    public IEnumerator ChangeValuesmoothly(float value)
    {
        float elapsedTime = 0;

        _value += value;

        ValidateValue();

        while (elapsedTime < _delay)
        {
            elapsedTime += Time.deltaTime;

            _slider.value = Mathf.MoveTowards(_slider.value, _value , elapsedTime / _delay);            

            yield return null;
            UpdateText();
        }
    }
}
