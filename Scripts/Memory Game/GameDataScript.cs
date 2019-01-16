using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GameDataScript : MonoBehaviour {

    public int NRows { get; private set; } 
    public int NCols { get; private set; } 
    public int Iteration { get; private set; }
    public static GameDataScript Instance;

    //These variables contain the number of rows and columns needed to arrange the cards at each level.
    private int[] nRowsList = {2,2,2,2,2,3,4,4,4,4};
	private int[] nColsList = {1,2,3,4,5,4,4,5,5,5};

    public int TotalLevel { get; private set; }
    public int[] Ordering { get; private set; }
    public int MemRepeatID { get; private set; }
    private static System.Random rng = new System.Random();
    private MainLogging mainLog;
    private LoadExternalResources extRes;
    
    
    // Use this for initialization
    void Start () {

        TotalLevel = 10;
	
	    //LogInfo logInfo = GameObject.Find("ProfileInfo").GetComponent<LogInfo>();
       // string language = logInfo.LanguageName;
            
	
    }
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	
	//Prepare for new level : increase iteration (the number of cards) by one and prepare the grid
	public void LevelPassed(){
        Iteration++;
        if (Iteration <= TotalLevel)
        {
            ArrangeGrid(Iteration);
            MemRepeatID = Ordering[rng.Next(0, Ordering.Length)];
            GetNewOrdering();
        }
    }
	
	//Prepare the grid for arranging the cards, using the pre-set rows and columns number for each level.
	void ArrangeGrid(int iteration){
		NRows = nRowsList[iteration - 1];
		NCols = nColsList[iteration - 1];
	}
	
	public void Reset(){
	    Iteration = 1;
	    ArrangeGrid(Iteration);
        GetNewOrdering();
    }

    public void GetNewOrdering()
    {
        Ordering = WordsStats.GetOrderingPerformanceBased(mainLog.GetRecallSeenWordsStats(),
                    extRes.MemoryWords, NRows * NCols / 2);
    }

	
	//This function ensures that the object is not destructed in between scenes
	void Awake() {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }


        //When creating the game data, set the iteration to one (one card)
        // initialise this here is to make sure this get set
        // before it is being used in the start of moveAvatar.cs
        mainLog = GameObject.Find("MainLogging").GetComponent<MainLogging>();
        Iteration = mainLog.GetLastSavedLevel() + 1;

        extRes = GameObject.Find("LoadExternalResources").GetComponent<LoadExternalResources>();

        // loading the question randomly
        //Ordering = Enumerable.Range(0, extRes.MemoryImages.Length).ToArray();
        //Shuffle(Ordering); //Shuffle the cards

        ArrangeGrid(Iteration);
        // load the question based on the stats
        //Ordering = GetNewOrdering();

    }
	
	//Shuffling array function
	public static void Shuffle<T>(IList<T> list)  
	{  
		int n = list.Count;
        
		while (n > 1) {  
			n--;
			int k = rng.Next(n + 1);  
			T value = list[k];
			list[k] = list[n];
			list[n] = value;
		}  
	}
}
