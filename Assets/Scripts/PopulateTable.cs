using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateTable : MonoBehaviour
{
    public GameObject myPrefab;
    public AtomPrefabScript myComponent;
    
    // private string path = "./Data/Periodic_Table_of_Elements.csv";
    
    void Start()
    {
        GameObject instance = Instantiate(myPrefab, new Vector3(441, -178, -300), Quaternion.identity);
        myComponent = instance.GetComponent<AtomPrefabScript>();
        string name=  "Hydrogen";
        string symbol =  "H";
        string weight =  "0.1";
        string atomicNumber  =  "1";
        
        myComponent.UpdateValues(name, symbol, weight, atomicNumber);
        
        // myComponent.name_t = "Hello";
        // myComponent.weight_t = "we";
        // myComponent.symbol_t = "s";
        // myComponent.atomicNumber_t = "Hello";

    }

    void Update()
    {
        // Do any updates that need to happen every frame
    }
}
