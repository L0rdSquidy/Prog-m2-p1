using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string AnimName;

    public abstract void Move();

    public void eat()
    {
        Debug.Log("Nom Nom");
    }
}

public class Bird : Animal
{
    public override void Move()
    {
        AnimName = "Bird"; 
        Debug.Log("the " + AnimName + " flaps its wings");
    }
}

public class Elephant : Animal
{
    public override void Move()
    {
        AnimName = "Elephant";
        Debug.Log("the " + AnimName + " Stomps away");
    }
}

public class Dog : Animal
{
    public override void Move()
    {
        AnimName = "Dog";
        Debug.Log("the " + AnimName + " Runs away");
    }
}

public class Zoo : MonoBehaviour
{
    Animal[] animals = {new Bird(), new Elephant(), new Dog()};
    private void Start() 
    {
        foreach (Animal Anim in animals)
        {
            Anim.eat();
            Anim.Move();
        }
    }
}