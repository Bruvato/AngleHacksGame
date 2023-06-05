using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    private Slider slider;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    public void UpdateHealthBar(float current, float max)
    {
        slider.value = current / max;
    }

    private void Update()
    {
        // slider.value
    }

}
