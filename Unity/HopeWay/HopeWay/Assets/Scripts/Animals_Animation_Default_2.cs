using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class Animals_Animation_Default_2 : MonoBehaviour
{
    public float duration = 5f;
    public Ease ease = Ease.Linear;
    public float location = 2.1f; 

    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveX((float)location, duration).SetEase(ease);
        transform.DOMoveZ((float)location, duration).SetEase(ease);
        

    }
}
