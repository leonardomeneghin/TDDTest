
using Assets.Scripts;
using Assets.Scripts.BaseBehavior.EventHelper;
using NUnit.Framework;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.TestTools;
using UnityEngine.UI;

//Classe que verifica se a classe está se comportamento corretamente
public class ButtonHealTest
{
    ButtonHeal _buttonHeal;

    public HearthBehavior _hearth;

    [Test]
    [TestCase()]
    public void receiveEventCLickFromButton(ButtonHeal heal)
    {
        var wasCalled = false;
        _buttonHeal = heal;
        //Obter a classe
        EventHandler ouvinte = (sender, e) => wasCalled = true;
        EventHandler<NumericEventArgs> ouvinteHearth = (sender, e) => _hearth.SetImageFill(e.getValue());
        //Se inscrever no evento para receber a mensagem
        _buttonHeal.AddListener(ouvinte);

        //Chamar o método que processa algo + envia mensagem de evento
        _buttonHeal.OnClickHeal();

        //Verificar se evento foi recebido
        Assert.That(wasCalled, Is.True);

        //Verifica vida total do coração
        Assert.That(_hearth.GetImageFill(), Is.EqualTo(1));
    }



}