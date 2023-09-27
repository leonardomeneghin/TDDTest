using log4net.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//Classe que define como deve-se comportar
public class HeartMock
{
    private GameObject gameObject;
    internal Image _image;


    public HeartMock()
    {
        gameObject = GameObject.Find("Foreground");
        _image = gameObject.GetComponent<Image>();
    }

    public void ReceiveDamage(float damageForce)
    {
        var fillAmountRestante = _image.fillAmount;
        if (damageForce <= 0)
        {
            return;
        }
        _image.fillAmount = fillAmountRestante - damageForce;
    }

    public float GetImageFill()
    {
        return _image.fillAmount;
    }


}

