using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CheatSheet
{
    internal class C22_Polymorphism
    {
        // Polymorphism and Overriding Methods

        // Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
        // Like we specified in the previous chapter; Inheritance lets us inherit fields and methods from another class.
        // Polymorphism uses those methods to perform different tasks.This allows us to perform a single action in different ways.

        // For example, think of a base class called Animal that has a method called animalSound().
        // Derived classes of Animals could be Pigs, Cats, Dogs, Birds - And they also have their own implementation of an animal sound (the pig oinks, and the cat meows, etc.) :

        class Animal  // Base class (parent) 
        {
            public void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

        // Now we can create Pig and Dog objects and call the animalSound() method on both of them:

        class Program
        {
            static void Main(string[] args)
            {
                Animal myAnimal = new Animal();  // Create a Animal object
                Animal myPig = new Pig();  // Create a Pig object
                Animal myDog = new Dog();  // Create a Dog object

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();

                // The output will be:
                // The animal makes a sound
                // The animal makes a sound
                // The animal makes a sound
            }
        }

        // It is still the same Output because the methods we did not override the method
        // Now we are going to do the same thing and OVERRIDE the methods in the Derived Classes

        class Animal2  // Base class (parent) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig2 : Animal2  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog2 : Animal2  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

        class Program2
        {
            static void Class()
            {
                Animal2 myAnimal = new Animal2();  // Create a Animal object
                Animal2 myPig = new Pig2();  // Create a Pig object
                Animal2 myDog = new Dog2();  // Create a Dog object

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();
            }
        }


        // The output will be:
        //The animal makes a sound
        //The pig says: wee wee
        //The dog says: bow wow
    }
}
