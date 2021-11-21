using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Sessionmanager : MonoBehaviour
{
    // Horse Data
    public HorseData currentHorse;

    // Horse Stats

    [HideInInspector]
    public int horseTrust;
    [HideInInspector]
    public int horseDistanceRespect;



    // Verknüpfungen

    public TMP_Text text;

    public GameObject buttonObject1;
    public GameObject buttonObject2;
    public GameObject buttonObject3;

   
    // Button Components
    [HideInInspector]
    public TMP_Text buttonText1;
    [HideInInspector]
    public TMP_Text buttonText2;
    [HideInInspector]
    public TMP_Text buttonText3;

    [HideInInspector]
    public Button button1;
    [HideInInspector]
    public Button button2;
    [HideInInspector]
    public Button button3;



    //Start Setting
    public Setting startSetting;


    // Start is called before the first frame update
    void Start()
    {

        // Button components zuweisen
        button1 = buttonObject1.GetComponent<Button>();
        button2 = buttonObject2.GetComponent<Button>();
        button3 = buttonObject3.GetComponent<Button>();

        buttonText1 = buttonObject1.GetComponentInChildren<TMP_Text>();
        buttonText2 = buttonObject2.GetComponentInChildren<TMP_Text>();
        buttonText3 = buttonObject3.GetComponentInChildren<TMP_Text>();

        //Horse Values zuweisen
        horseTrust = currentHorse.trust;
        horseDistanceRespect = currentHorse.distanceRespect;


        // Start Game
        SetScene(startSetting);
    }



    private void SetScene(Setting sceneData)
    {

        // Hier greift der Effekt des Settings (Die Konsequent aus der letzten Handlung)
        if(sceneData.valueImpact == true)
        {
            // Wenn der Impact angeschaltet ist, werden die am Setting eingegebenen Werte auf das CurrentHorse raufgerechnet
            currentHorse.trust = sceneData.trustImpact + currentHorse.trust;
        }
        
        
        // HIER MÜSSEN UNBEDINGT ALLE AKTUELLEN LISTENER/EVENTS GELOESCHT WERDEN SONST AUA!!!!!
        button1.onClick.RemoveAllListeners();
        button2.onClick.RemoveAllListeners();
        button3.onClick.RemoveAllListeners();

        // Storytext beschriften
        text.text = sceneData.mainText;

        // Textbutton beschriften ------> Polish: Button ohne text sollten ausgeschaltet werden
        

        buttonText1.text = sceneData.buttonText1;
        buttonText2.text = sceneData.buttonText2;
        buttonText3.text = sceneData.buttonText3;


        // Add a new event to the Button ---- Values an SkillCheck Funktion weitergeben
        button1.onClick.AddListener(delegate { SkillCheck(sceneData.maxTrust1a, sceneData.maxDistanceRespect1a, sceneData.maxTrust1b, sceneData.maxDistanceRespect1b, sceneData.nextSetting1a, sceneData.nextSetting1b, sceneData.nextSetting1c); });
        button2.onClick.AddListener(delegate { SkillCheck(sceneData.maxTrust2a, sceneData.maxDistanceRespect2a, sceneData.maxTrust2b, sceneData.maxDistanceRespect2b, sceneData.nextSetting2a, sceneData.nextSetting2b, sceneData.nextSetting2c); });
        button3.onClick.AddListener(delegate { SkillCheck(sceneData.maxTrust3a, sceneData.maxDistanceRespect3a, sceneData.maxTrust3b, sceneData.maxDistanceRespect3b, sceneData.nextSetting3a, sceneData.nextSetting3b, sceneData.nextSetting3c); });


    }



    private void SkillCheck(int maxTrustA, int maxDistanceRespectA, int maxTrustB, int maxDistanceRespectB, Setting sceneDataA, Setting sceneDataB, Setting sceneDataC)
    {
                
        if(horseTrust >= maxTrustA && horseDistanceRespect >= maxDistanceRespectA)
        {
            SetScene(sceneDataA);
        }
        else if(horseTrust >= maxTrustB && horseDistanceRespect >= maxDistanceRespectB)
        {
            SetScene(sceneDataB);
        }else
        {
            SetScene(sceneDataC);
        }
    }



    private void SetButtonText()
    {

        // Buttons aktiv setzen
        buttonObject1.SetActive(true);
        buttonObject2.SetActive(true);
        buttonObject3.SetActive(true);


        // if(sceneData.buttonText1 != "")
        //{
        //    // setze Text
        //}
        //else
        //{
        //    // Gameobject deaktivieren
        //}
    } // Buttons ohne Text sollen ausgeschaltet werden


    public void DebugText()
    {
        Debug.Log("BlaTest!");
    }
}
