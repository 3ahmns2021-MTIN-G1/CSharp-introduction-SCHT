using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Deklaration einer Klasse

    // public           -> access modifier 
    // class            -> keyword zur Deklaration einer Klasse
    // ExampleClass     -> identifier/Name
    // : MonoBehaviour  -> Erstellen eine Unterklasse von MonoBehaviour
    // {}               -> Scope/Wirkungsbereich 
public class ExampleClass : UnityEngine.MonoBehaviour
{
    // Deklaration von Variablen
    // Variablen sind Container für Value  oder References 
        
        // Variablentypen mit Werten
        // public           -> access modifier 
        // int              -> Variablentyp 
        // ganzeZahlVariable-> identifier 
        // ;                -> Ende des Statements / Deklaration

        // Zuweisungsoperator/assignment operator ->   =   
    public int ganzeZahlVariable = 6;   // Ganze Zahlen - Integer - Instanzvariable 
    public float gleitKommaVariable = 4.2f; // Gleitkommazahlen
    public string textVariable = "Hier kommt mein Text rein";             // Text
    public bool boolVariable = true;               // Binäre Entscheidung true/false bool


        // Variablentypen mit Referenzen
    public UnityEngine.Rigidbody rigidBodyVariable;
    public UnityEngine.BoxCollider boxColliderVariable;
    public UnityEngine.Transform transformVariable;
    public UnityEngine.GameObject x;
    public ExampleClass ec;
    public UnityEngine.UI.Button btnVariable;


        // Deklaration von Funktionen   

    // public                       -> access modifier 
        // void / int / float / GameObject / Button   
        //                              -> return type (Gitb die Funktion einen Wert zurück)
        // TestFunktion                 -> Identifier 
        // ()                           -> Parameterliste 
        // {}                           -> Geltungsbereich 
    public void TestFunktion()
    {
        // Aufruf einer Funktion 
        // print            -> Name der Funktion
        // ()               -> Parameterliste 
        // ;                -> Ende des Aufrufes

        print("Meine Nachricht an die Konsole");
        print("1");
        print("2");
        print("3");
        print("4");
    }

    // Von Unity im ersten Frame aufgerufen.
    public void Start()
    {
        TestFunktion();

        print("x");
        print("y");
        print("z");
    }

    public void Update()
    {
 
    }
}