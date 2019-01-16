using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonProfile : MonoBehaviour {
    
    public Button buttonComponent;
    public Text nameLabel;
    
    
    private string profileName;
    public ProfileScrollList scrollList;
    
    // Use this for initialization
    void Start () 
    {
        buttonComponent.onClick.AddListener (HandleClick);
    }
    
    public void Setup(string currentname)
    {
        profileName = currentname;
        nameLabel.text = currentname;
        
        
    }
    
    public void HandleClick()
    {
        scrollList.TransferSelectedName(profileName);
    }
}