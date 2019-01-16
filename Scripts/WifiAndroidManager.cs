using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.IO;

public class WifiAndroidManager : MonoBehaviour {

    // original: "\"NgukurrOpie\"","\"21157233\""
    //private const string wifi_ssid = "\"NgukurrOpie2\"";
    //private const string wifi_pwd = "\"22232113\"";

    private const string wifi_ssid = "\"Ngopie_4\"";
    private const string wifi_pwd = "\"88494807\"";

    private InstructionSound instr_sound;
    // Use this for initialization

    void Start () {

        instr_sound = GameObject.Find("InstructionSound").GetComponent<InstructionSound>();
#if UNITY_ANDROID && !UNITY_EDITOR
        Debug.Log("Started Wifi manager");
        //ConnectWifi(wifi_ssid, wifi_pwd);

        string config_ssid = ReadConfigSSID();
        string config_pwd = "";
        if (config_ssid == "\"NgukurrOpie\"")
        {
            config_pwd = "\"21157233\"";
        }
        else if (config_ssid == "\"NgukurrOpie2\"")
        {
            config_pwd = "\"22232113\"";
        }
        else if (config_ssid == "\"Ngopie_4\"")
        {
            config_pwd = "\"88494807\"";
        }
        ConnectWifi(config_ssid, config_pwd);
#endif

    }

    // Update is called once per frame
    void Update () {
#if UNITY_EDITOR_WIN
        //Debug.Log("win editor test");
        if (instr_sound.CheckIfAllSoundsLoaded())
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("profiles_scene");
        }
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        if (!IsWifiEnabled())
            Debug.Log("wifi not enable");

        // make sure there is a valid ip before proceeding
        if (WifiInfo().Call<int>("getIpAddress") != 0)
        {   
            //Check if wifi is connected to "Ngukurr Opie", and switch to Root scene if it is
            if ((WifiInfo().Call<String>("getSSID") == wifi_ssid) && IsWifiEnabled())
            {   
                if (instr_sound.CheckIfAllSoundsLoaded())
                    UnityEngine.SceneManagement.SceneManager.LoadScene("RootScene");
            }
        }
#endif
    
    }

    private string ReadConfigSSID()
    {
        string configPath = Application.persistentDataPath + "/Config.txt";
        Debug.Log(configPath);
        if (!File.Exists(configPath))
        {
            Debug.Log("Missing Config File");
            return "\"NgukurrOpie\"";
        }
        string configSSID = "";
        using (StreamReader sr = new StreamReader(configPath))
        {
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();

                if (line != "" && line.StartsWith("SSID:"))
                {
                    string[] separators = { "\t", " " };
                    string[] words = line.Split(separators,
                            StringSplitOptions.RemoveEmptyEntries);
                    configSSID = words[1];
                    break;
                }
            }
        }
        if (configSSID == "")
        {
            Debug.Log("SSID not found in Config File");
            return "\"NgukurrOpie\"";
        }

        return configSSID;

    }



    public void ReattemptConnexion(){
		//Name and password of the connection
		ConnectWifi(wifi_ssid, wifi_pwd);
	}
	
	private bool SetWifiEnabled(bool enabled)
	{
        using (AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity"))
        {
            try
            {
                using (var wifiManager = activity.Call<AndroidJavaObject>("getSystemService", "wifi"))
                {
                    return wifiManager.Call<bool>("setWifiEnabled", enabled);
                }
            }
            catch (Exception e)
            {
            }
        }
        return false;
    }

    private bool IsWifiEnabled()
    {
        using (AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity"))
        {
            try
            {
                using (var wifiManager = activity.Call<AndroidJavaObject>("getSystemService", "wifi"))
                {
                    return wifiManager.Call<bool>("isWifiEnabled");
                }
            }
            catch (Exception e)
            {

            }
        }
        return false;
    }

    private AndroidJavaObject WifiInfo()
	    {
        using (AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity"))
        {
            try
            {
                using (var wifiManager = activity.Call<AndroidJavaObject>("getSystemService", "wifi"))
                {
                    return wifiManager.Call<AndroidJavaObject>("getConnectionInfo");
                }
            }
            catch (Exception e)
            {
            }
        }
        return null;
    }


    //This function looks for the wifi network called NAME, and tries to connect to it using the password.
    private void ConnectWifi(string name, string password)
	    {
        using (AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity"))
        {
            try
            {
			    //Define the wifi config object containing network information (incl. password)
			    AndroidJavaObject wifiConfig = new AndroidJavaObject("android.net.wifi.WifiConfiguration");
			    wifiConfig.Set<String>("SSID", name);
			    wifiConfig.Set<String>("preSharedKey", password);
			
                using (var wifiManager = activity.Call<AndroidJavaObject>("getSystemService", "wifi"))
                {
				    int netId = wifiManager.Call<int>("addNetwork",wifiConfig);
				    Debug.Log(netId.ToString());
				    //Disconnect from current network
				    wifiManager.Call<bool>("disconnect");
				    //Set new network to the wificonfig object
				    wifiManager.Call<bool>("enableNetwork",netId,true);
				    //Activate wifi connection again
				    wifiManager.Call<bool>("reconnect");
				    Debug.Log("connection done");
                    //return wifiManager.Call<AndroidJavaObject>("getConnectionInfo");
                }
            }
            catch (Exception e)
            {
            }
        }
    }
    public void QuitApp()
    {
        Application.Quit();
    }
}
