using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;


public class ProfileScrollList : MonoBehaviour {

	public Button PrefabButton;
    private string[] itemList;
    public Transform ContentPanel;
    public Text SelectionDisplay;


    // Use this for initialization
    void Start () 
    {

        //The names of the profiles are defined by the directories created in the logging folder
        string path = Application.persistentDataPath;
        List<string> foos = new List<string>();
#if UNITY_ANDROID && !UNITY_EDITOR
        itemList = Directory.GetDirectories(path);
        foos = new List<string>(itemList);
#endif
#if UNITY_EDITOR_WIN
        // not the best way but trying to not to change android unless necessary
        DirectoryInfo dataDir = new DirectoryInfo(path);
        DirectoryInfo[] dirInfo = dataDir.GetDirectories();
        
        for (int i = 0; i < dirInfo.Length; i++)
            foos.Add(dirInfo[i].Name);

        itemList = foos.ToArray(); 
#endif
        
        //Remove the first item of the list (created by Unity by default)
        int iToRemove = -1;
        int extFolderToRemove = -1;
		for (int i = 0; i < itemList.Length; i++) {
            foos[i] = foos[i].Replace(path + "/", "");

            if (foos[i].Equals("Unity"))
                iToRemove =i;
            if (foos[i].Equals("ExternalAssets"))
                extFolderToRemove = i;
        }

        if (iToRemove != -1)
            foos.RemoveAt(iToRemove);

        if (extFolderToRemove != -1)
            foos.RemoveAt(extFolderToRemove);

        itemList = foos.ToArray();
		
		//Create the buttons for each profile
		AddButtons();
		PrefabButton.gameObject.SetActive(false);
        
        //The selection display will contain the name of the profile selected by the user. It is initially empty.
        SelectionDisplay.text = "";
	
    }

    //This function adds button to the List
    private void AddButtons()
    {
        for (int i = 0; i < itemList.Length; i++) 
        {
            string name = itemList[i];
            
            Button newButton = GameObject.Instantiate(PrefabButton);
            newButton.transform.SetParent(ContentPanel, false);

            ButtonProfile sampleButton = newButton.GetComponent<ButtonProfile>();
            sampleButton.Setup(name);
        }
    }

	//this function writes the name of the button in the "selected name" field.
    public void TransferSelectedName(string name)
    {
	    SelectionDisplay.text=name;
    }

    
}
