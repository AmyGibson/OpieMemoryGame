using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

public class LanguageScrollList : MonoBehaviour {

    public Button PrefabButton;
    private string[] itemList;
    public Transform ContentPanel;


    // Use this for initialization
    void Start()
    {
        List<string> foos = new List<string>();

#if UNITY_ANDROID  && !UNITY_EDITOR
        //The names of the languages are defined by the existing directories 
        itemList = Directory.GetDirectories(Application.persistentDataPath + "/ExternalAssets");
        foos = new List<string>(itemList);
#endif
#if UNITY_EDITOR_WIN
        // not the best way but trying to not to change android unless necessary
        DirectoryInfo dataDir = new DirectoryInfo(Application.persistentDataPath + "/ExternalAssets");
        DirectoryInfo[] dirInfo = dataDir.GetDirectories();

        for (int i = 0; i < dirInfo.Length; i++)
            foos.Add(dirInfo[i].Name);

        itemList = foos.ToArray();
#endif


        //Remove the instruction folder
        int i_to_remove = -1;
        for (int i = 0; i < itemList.Length; i++)
        {
            foos[i] = foos[i].Replace(Application.persistentDataPath + "/ExternalAssets/", "");
            if (foos[i].Equals("Instructions"))
                i_to_remove = i;
            
        }

        if (i_to_remove != -1)
            foos.RemoveAt(i_to_remove);

        itemList = foos.ToArray();

        //Create the buttons for each profile
        AddButtons();
        PrefabButton.gameObject.SetActive(false);
    }

    //This function adds button to the List
    private void AddButtons()
    {
        for (int i = 0; i < itemList.Length; i++)
        {
            string language = itemList[i];

            Button newButton = Instantiate(PrefabButton);
            newButton.transform.SetParent(ContentPanel, false); 

            ButtonLanguage sampleButton = newButton.GetComponent<ButtonLanguage>();
            sampleButton.Setup(language);
        }
    }

}
