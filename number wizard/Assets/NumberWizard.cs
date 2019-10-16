using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;


    void Start()
    {

        print("Witaj w Liczbowym Czarodzieju");
        print("Wybierz liczbę z przedizału od 1 do 1000");
        print("maksymalna jaką możesz wybraźć to: " + max);
        print("minimalna jaką możesz wybraźć to: " + min);

        print("naciśnij dół strzałkę aby odpowiedziweć, że mniejsza");
        print("naciśnij enter aby potwierdzić, że koputer zgadłliczbę");
        print("naciśnij gorna strzałkę aby odpowiedziweć, że większa");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Uzytkownik nacisnol gorna szczalke");
            min = guess;
            guess = (min + max) / 2;
            print("Czy twoja liczba jest mniejsza lub większa niż" + guess);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Uzytkownik nacisnol dolna szczalke");
            max = guess;
            guess = (min + max) / 2;
            print("Czy twoja liczba jest mniejsza lub większa niż" + guess);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Ha Ha Beczunia zgadłem ");

        }
    }
}
