using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        print("witaj u liczbowego Czarodzieja");

        print("Pomyśl o liczbie ale jej nie mów");

        int min = 1; //jd
        int max = 1000;

        print("Najwieksza liczba jaką mozesz wybrac to " + max);
        print("A najmniejsza liczba jaką mozesz wybrac to " + min);
        print("Czy twoja liczba jest wieksza czy mniejsza od 500?");
        print("Aby odp na pytanie nacisnij: szczalka w ↓ = mniejsza  szczalka w ↑ = wieksza");
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            print("Gorna strzalka zostala nacisnieta");

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Dolna strzalka zostala nacisnieta");

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
