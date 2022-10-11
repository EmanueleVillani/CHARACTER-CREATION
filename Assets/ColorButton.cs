using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{

    public SelectHairColors selectHairColor;


   [Header("Color Values")]

    public float redAmount;
    public float greenAmount;
    public float blueAmount;

    [Header("Color Sliders")]
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlide;

    public Image colorImage;


    private void Awake()
    {
        colorImage = GetComponent<Image>();
        redAmount = colorImage.color.r;
        greenAmount = colorImage.color.g;
        blueAmount = colorImage.color.b;
    }

    public void SetSlideValueImageColor()
    {
        redSlider.value = redAmount;
        greenSlider.value = greenAmount;
        blueSlide.value = blueAmount;

        //redAmount = redSlider.value;
        //greenAmount = greenSlider.value;
        //blueAmount = blueSlide.value;


        selectHairColor.redAmount = redAmount;
        selectHairColor.greenAmount = greenAmount;
        selectHairColor.blueAmount = blueAmount;


        selectHairColor.SetHairColor();
        
    }
}
