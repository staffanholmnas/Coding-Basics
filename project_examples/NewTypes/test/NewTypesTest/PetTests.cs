using System;
using NUnit.Framework;
using Pets;
using WildAnimals;

public class PetTests
{
  [Test]
  public void DogTalkToOwnerReturnsWoof()
  {
    string expected = "Woof!";
    string actual = new Dog().TalkToOwner();

    Assert.AreEqual(expected, actual);
  }

  [Test]
  public void CatTalkToOwnerReturnsMeow()
  {
    string expected = "Meow!";
    string actual = new Cat().TalkToOwner();

    Assert.AreEqual(expected, actual);
  }

   [Test]
  public void BirdTalkToOwnerReturnsTweet()
  {
    string expected = "Tweet!";
    string actual = new Bird().TalkToOwner();

    Assert.AreEqual(expected, actual);
  }

  [Test]
  public void SquirrelWhatDoIEatReturnsPines()
  {
    string expected = "Pines!";
    string actual = new Squirrel().WhatDoIEat();

    Assert.AreEqual(expected, actual);
  }

  [Test]
  public void RabbitWhatDoIEatReturnsCarrots()
  {
    string expected = "Carrots!";
    string actual = new Rabbit().WhatDoIEat();

    Assert.AreEqual(expected, actual);
  }
}