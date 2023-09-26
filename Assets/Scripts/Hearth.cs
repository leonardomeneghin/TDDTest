using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//Classe que define como deve-se comportar
public class Heart : MonoBehaviour
{

    internal Image _image;

    Transform _childTransform;


    public Heart()
    {

    }
    public void Start()
    {
        //Expor para receber a imagem
        _childTransform = transform.Find("Foreground");
        _image = _childTransform.GetComponent<Image>();
    }
    public void ReceiveDamage(float damageForce)
    {
        if (damageForce < 0)
        {
            return;
        }
        _image.fillAmount -= damageForce;
    }

    public float GetImageFill()
    {
        return _image.fillAmount;
    }


}

