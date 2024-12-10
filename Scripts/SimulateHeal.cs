using UnityEngine;

public class SimulateHeal : ButtonHandler
{
    [SerializeField] private SliderHandler _slider;
    [SerializeField] private SliderHandler _smoothSlider;

    private float _heal = 25;

    public override void ChangeValue()
    {
        _slider.ChangeValue(_heal);
        _smoothSlider.StartCoroutine(_smoothSlider.ChangeValuesmoothly(_heal));
    }
}
