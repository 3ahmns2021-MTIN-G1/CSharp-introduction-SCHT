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

    public int ganzeZahlVariable = 6; //Ganze Zahlen - Integer - Instantzvariable (innerhalb der ganzen Klasse gültig)
    public float gleitKommaVariable = 4.2f; //Gleitkommazahlen
    public string textVariable = "Text"; //Text
    public bool boolscheEntscheidung; //Binäre Entscheidung

    // Variablentypen mit Referenzen
    // public GameObject gameObjectVariable
    public Rigidbody rigidBodyVariable;
    public BoxCollider boxColliderVariable;
    public BoxCollider boxColliderVariable2;
    public Transform transformVariable;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
