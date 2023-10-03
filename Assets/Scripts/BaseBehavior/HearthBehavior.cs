using log4net.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//Classe que define como deve-se comportar
public class HearthBehavior
{
    private GameObject _gameObject;
    internal Image _image;

    public HearthBehavior()
    {
        _gameObject = GameObject.Find("Foreground");
        _image = _gameObject?.GetComponent<Image>();
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

    public void SetImageFill(float fillAmount)
    {
        _image.fillAmount = fillAmount;
    }


}

