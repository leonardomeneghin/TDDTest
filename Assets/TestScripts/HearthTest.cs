
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

//Classe que verifica se a classe está se comportamento corretamente
public class HearthTest
{
    public  Image _image;
    public  Heart _hearth;
    public int integridadePivo;
    
    [SetUp]
    public void BeforeTest()
    {
        _hearth = new Heart();


    }
    [Test]
    [TestCase(0, 1)]
    [TestCase(1, 0.75f)]
    [TestCase(2, 0.5f)]
    [TestCase(3, 0.25f)]
    [TestCase(4,0)]
    [TestCase(5,0)]
    [TestCase(6,0)]
    [TestCase(7,0)]
    [TestCase(8,0)]
    [TestCase(-1, 1)]
    [TestCase(-2, 1)]

    public void gotHitedTest(
        int timesGotHit,
        float expectedFill
        )
    {
        var damageForce = timesGotHit * 0.25f;

        _hearth.ReceiveDamage(damageForce);
        
        Assert.That(_hearth.GetImageFill(), Is.EqualTo(expectedFill));



    }

}

