using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectHairColors : MonoBehaviour
{
    [Header("Color Values")]
    public float redAmount;
    public float greenAmount;
    public float blueAmount;
    public float alphaAmount;

    [Header("Color Sliders")]
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlide;

    private Color currentHairColor;


   

    public List<SkinnedMeshRenderer> rendererList = new List<SkinnedMeshRenderer>();

    public void UpdeteSliders()
    {
        redAmount = redSlider.value;
        greenAmount = greenSlider.value;
        blueAmount = blueSlide.value;
        SetHairColor();
    }

    public void SetHairColor()
    {
        currentHairColor = new Color(redAmount,greenAmount,blueAmount,alphaAmount);

        for (int i = 0; i < rendererList.Count; i++)
        {
            //rendererList[i].material.SetColor("_Color_Hair", currentHairColor);
            rendererList[i].material.SetColor("_Color", currentHairColor);
        }
    }
}
