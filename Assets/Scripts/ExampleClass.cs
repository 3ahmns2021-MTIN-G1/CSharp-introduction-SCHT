//Bibliotheken / Asembly Referenz / Namespaces
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Deklaration einer Klasse

// public 		-> access modifier (Zugriffsrechte) | keyword (vorreservierte Schlüsselwörter)
// class		-> keyword zur Deklaration einer Klasse
// ExampleClass		-> identifier (Name der Klasse)
// : MonoBehaviour	-> Erstellen einer Unterklasse
// {}			-> Scope/Wirkungsbereich

public class ExampleClass : MonoBehaviour
{
    //Deklaration von variablen
    //Variablen sind Container für Value (Werte) oder References (Verweise)

    // Variablentypen mit Werten
    // public      -> access modifier (wer darf von außen auf die Variable zugreifen)
    // int         -> identifier (Name der Variable)
    // ;           -> Ende des Statements

    public int ganzeZahlVariable; //Ganze Zahlen - Integer - Instantzvariable (innerhalb der ganzen Klasse gültig)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
