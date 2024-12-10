using UnityEngine;

public class SimulateDamage : ButtonHandler
{
    [SerializeField] private SliderHandler _slider;
    [SerializeField] private SliderHandler _smoothSlider;

    private float _damage = -25;

    public override void ChangeValue()
    {
        _slider.ChangeValue(_damage);
        _smoothSlider.StartCoroutine(_smoothSlider.ChangeValuesmoothly(_damage));
    }
}
