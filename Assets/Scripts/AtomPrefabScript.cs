using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using System.Globalization;


public class AtomPrefabScript : MonoBehaviour
{

    public TMP_Text weight;
    public TMP_Text symbol;
    public TMP_Text name;
    public TMP_Text atomicNumber;
    public Button shiftScene;
    // private StaticVariables staticVariables = StaticVariables.Instance;


    void Start (){
    
        
        shiftScene.onClick.AddListener(()=>{
            StaticVariables.SelectedIndex = Int32.Parse(atomicNumber.text)-1;

            StaticVariables.SelectedElement = name.text;
            // staticVariables.SelectedElement = name.text;
            SceneManager.LoadScene (sceneName:"AtomicDetailScene");

        });

    }

    public void UpdateValues(string nameValue,string symbolValue,string weightValue,string aotmicNumberValue){

        // Debug.Log("Name= "+nameValue);
        name.text = nameValue;
        symbol.text = symbolValue;
        weight.text = weightValue;
        atomicNumber.text = aotmicNumberValue;
        // this.weight.text = weightValue;
    }

    // void Update(){
    //     name.text = name_t;
    // }


}