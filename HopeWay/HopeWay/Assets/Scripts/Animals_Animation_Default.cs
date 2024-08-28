using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class Animals_Animation_Default : MonoBehaviour
{
    public float duration = 5f;
    public Ease ease = Ease.Linear;


    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveX((float)0.7, duration).SetEase(ease);
        transform.DOMoveZ((float)3.5, duration).SetEase(ease);
        transform.DOMoveY((float)1.1, duration).SetEase(ease);

    }
}
