using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using System.Globalization;

public class AtomicDetails : MonoBehaviour
{
    public TMP_Text name;
    public TMP_Text atomicNumber;
    public TMP_Text symbol;
    public TMP_Text noOfElectrons;
    public TMP_Text noOfProtons;
    public TMP_Text noOfNeutrons;
    public TMP_Text phase;
    public TMP_Text type;
    public TMP_Text noOfShells;
    public Button backButton;
 
    void Start()
    {

        name.text = StaticVariables.NAME[StaticVariables.SelectedIndex];
        atomicNumber.text = StaticVariables.ATOMIC_NUMBER[StaticVariables.SelectedIndex];
        symbol.text = StaticVariables.SYMBOL[StaticVariables.SelectedIndex];
        noOfElectrons.text = StaticVariables.ELECTRONS[StaticVariables.SelectedIndex];
        noOfProtons.text = StaticVariables.PROTONS[StaticVariables.SelectedIndex];
        noOfNeutrons.text = StaticVariables.NEUTRONS[StaticVariables.SelectedIndex];
        phase.text = StaticVariables.PHASE[StaticVariables.SelectedIndex];
        type.text = StaticVariables.TYPE[StaticVariables.SelectedIndex];
        noOfShells.text = StaticVariables.SHELLS[StaticVariables.SelectedIndex];

        backButton.onClick.AddListener(()=>{
        SceneManager.LoadScene (0);

        });
           Debug.Log("Value in Atomic Details  " + StaticVariables.SelectedElement);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
