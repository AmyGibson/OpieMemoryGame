using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class MainLogging : MonoBehaviour {

    public static MainLogging Instance;
    //private string mainLogFilename;
    private FileInfo mainLogFileInfo;
    private LogInfo logInfo;
    //public string MainLogFilename { get; private set; }
    public enum ActivityType
    {
        Memory, Recall, Repetition, Story
    }
    public string[] ActivityNames { get; private set; }

    //This function ensures that the object is not destructed between scenes (so that the logging information can be accessed at any time)
    void Awake()
    {
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
    }


    // prepare log file on loading the scene, doesnt add to it till after an activity is clicked
    // what if the user quit straight after, still count?
    void Start() {
        logInfo = GameObject.Find("ProfileInfo").GetComponent<LogInfo>();
        // make sure the order here is the same as the enum above, this is the only place
        // the activity names are set, if they are to be changed just change here
        ActivityNames = new string[] { "Memory Game", "Recall", "Word Repetition", "Story" };

        // this game object should be destroy when the user returns to the 
        // profile scene, so one fileinfo only last for one user per activity;
        // if in the future the user can change activity without going through profile 
        // again, this needs to be changed.

        PrepareMainLogFileInfo();
    }

    // Update is called once per frame
    void Update() {

    }

    private void PrepareMainLogFileInfo()
    {
        string mainLogDir = Application.persistentDataPath + "/" + logInfo.PlayerName + "/";
#if UNITY_EDITOR_WIN
        DirectoryInfo dataDir = new DirectoryInfo(Application.persistentDataPath);
        mainLogDir = dataDir.FullName + "/" + logInfo.PlayerName + "/";
#endif
        // just to make sure that the file appears at the top of the folder
        string mainLogFullPath = mainLogDir + "00_" + logInfo.PlayerName + "_main_log.txt";
        mainLogFileInfo = new FileInfo(mainLogFullPath);

        if (!File.Exists(mainLogFullPath))
        {
            Debug.Log("Creating main log file");
            CreateTemplateFile();
        }
    }

    // creat the main log
    private void CreateTemplateFile()
    {
        using (StreamWriter w = mainLogFileInfo.CreateText())
        {
            w.Write("Student Name: " + logInfo.PlayerName + "\r\n");
            w.Write("\r\n");
            w.Write("Languages used: " + "\r\n");
            w.Write("\r\n");
            w.Write("Games played: " + "\r\n");
            w.Write(ActivityNames[(int)ActivityType.Memory] + "\t0 \r\n");
            w.Write(ActivityNames[(int)ActivityType.Story] + "\t0 \r\n");
            w.Write(ActivityNames[(int)ActivityType.Repetition] + "\t0 \r\n");
            w.Write("\r\n");
            w.Write("--------------------------------------------------------------\r\n");
            w.Write("\r\n");
            w.Write("[" + ActivityNames[(int)ActivityType.Memory] + "]\r\n");
            w.Write("[/" + ActivityNames[(int)ActivityType.Memory] + "]\r\n");
            w.Write("\r\n");
            w.Write("[" + ActivityNames[(int)ActivityType.Recall] + "]\r\n");
            w.Write("[/" + ActivityNames[(int)ActivityType.Recall] + "]\r\n");
            w.Write("\r\n");
            w.Write("[" + ActivityNames[(int)ActivityType.Repetition] + "]\r\n");
            w.Write("[/" + ActivityNames[(int)ActivityType.Repetition] + "]\r\n");
            /*
            w.WriteLine("Student Name: " + logInfo.PlayerName);
            w.WriteLine("");
            w.WriteLine("Languages used: ");
            w.WriteLine("");
            w.WriteLine("Games played: ");
            w.WriteLine(ActivityNames[(int)ActivityType.Memory] + "\t0 ");
            w.WriteLine(ActivityNames[(int)ActivityType.Story] + "\t0 ");
            w.WriteLine(ActivityNames[(int)ActivityType.Repetition] + "\t0 ");
            w.WriteLine("");
            w.WriteLine("--------------------------------------------------------------");
            w.WriteLine("");
            w.WriteLine("[" + ActivityNames[(int)ActivityType.Memory] + "]");
            w.WriteLine("[/" + ActivityNames[(int)ActivityType.Memory] + "]");
            w.WriteLine("");
            w.WriteLine("[" + ActivityNames[(int)ActivityType.Repetition] + "]");
            w.WriteLine("[/" + ActivityNames[(int)ActivityType.Repetition] + "]");
            */
        }
    }

    // this happens after playing the recall game, it is possible that the player
    // clicked the memory game then quit straight away then the stat of the player
    // playing the game and the word count wont match up

    public void UpdateMemoryLog(int curLevel, List<string> wordsToAdd)
    {
        UpdateMemoryAndRepetitionLog(ActivityNames[(int)ActivityType.Memory], curLevel, wordsToAdd);
    }

    public void UpdateRecallLog(List<string> wordsToAdd)
    {
        UpdateMemoryAndRepetitionLog(ActivityNames[(int)ActivityType.Recall], -1, wordsToAdd);
    }

    public void UpdateRepetitionLog(List<string> wordsToAdd)
    {
        UpdateMemoryAndRepetitionLog(ActivityNames[(int)ActivityType.Repetition], -1, wordsToAdd);
    }


    private void UpdateMemoryAndRepetitionLog(string activityName, int curLevel, List<string> wordsToAdd)
    {
        string[] lines = File.ReadAllLines(mainLogFileInfo.FullName);
        bool targetSection = false;
        bool updateDone = false;
        bool targetLanguage = false;
        int curLineIndex = 0;
        string targetLanguageTag = "Language:\t" + logInfo.LanguageName;
        string[] separators = { "\t" };

        using (StreamWriter sw = new StreamWriter(mainLogFileInfo.FullName))
        {

            while (curLineIndex < lines.Length)
            {

                // finished all the update, just write the text as is
                if (updateDone)
                {
                    sw.Write(lines[curLineIndex] + "\r\n");
                    curLineIndex++;
                    continue;
                }

                ///////////// look for the right game 
                // make sure we are in the right section, coz repetition would also 
                // requires finding the correct words to update
                if (lines[curLineIndex] == ("[" + activityName + "]"))
                {
                    targetSection = true;
                    sw.Write(lines[curLineIndex] + "\r\n");
                    curLineIndex++;
                    continue;
                }

                // the above give a chance for previous lines to be identified
                // if we are in the right section
                // if a line hit here but not the section flag is not set it is irrevlant
                if (!targetSection)
                {
                    sw.Write(lines[curLineIndex] + "\r\n");
                    curLineIndex++;
                    continue;
                }


                ///////// lines that reach here are in the right section 
                ///////// and have update to be done


                // if reaching the end tag of the section and nothing has been done
                // -> this is the first time this languge has been played
                // add the corresponding entries

                if (lines[curLineIndex] == ("[/" + activityName + "]"))
                {
                    sw.Write(targetLanguageTag + "\r\n");
                    if (curLevel != -1)
                        sw.Write("Last level played:\t" + curLevel.ToString() + "\r\n");
                    foreach (string w in wordsToAdd)
                    {
                        sw.Write(w + "\t1\r\n");
                    }

                    sw.Write("\r\n");
                    sw.Write(lines[curLineIndex] + "\r\n");
                    updateDone = true;
                    curLineIndex++;
                    continue;
                }


                ///////////// look for the right language
                // we need to find the section for the current language
                if (lines[curLineIndex] == targetLanguageTag)
                {
                    targetLanguage = true;
                    sw.Write(lines[curLineIndex] + "\r\n");
                    curLineIndex++;
                    continue;
                }

                // right section wrong language, continue
                if (!targetLanguage)
                {
                    sw.Write(lines[curLineIndex] + "\r\n");
                    curLineIndex++;
                    continue;
                }

                //////// everything below is in the right section
                //////// and language

                // first update the level, word rep should auto skip this
                if (lines[curLineIndex] != "" && lines[curLineIndex].StartsWith("Last level played"))
                {
                    sw.Write("Last level played:\t" + curLevel.ToString() + "\r\n");
                    curLineIndex++;
                    continue;
                }

                //////// updating the frequency of words seen


                // there are 2 situition this update can end up 
                // 1. adding a new word
                // 2. updating an existing stat

                // we need to check every line against the list of words
                // complexity is O(n) as max we have 10 x n check with n
                // being the total number of word in a language


                // if we see a blank line, the area for this language is finished
                // we need to add the remaining words to this area
                if (lines[curLineIndex] == "")
                {
                    foreach (string w in wordsToAdd)
                    {
                        sw.Write(w + "\t1\r\n");
                    }
                    sw.Write(lines[curLineIndex] + "\r\n");
                    updateDone = true;
                    curLineIndex++;
                    continue;
                }



                // Updaing an existing word, we need to loop through
                // if this word in log is one to be updated
                int indexToRemove = -1;
                for (int i = 0; i < wordsToAdd.Count; i++)
                {
                    if (lines[curLineIndex].StartsWith(wordsToAdd[i]))
                    {
                        string[] words = lines[curLineIndex].Split(separators,
                            StringSplitOptions.RemoveEmptyEntries);
                        string newLine = words[0] + "\t" + (Int32.Parse(words[1]) + 1).ToString();
                        sw.Write(newLine + "\r\n");
                        curLineIndex++;
                        indexToRemove = i;
                        break;
                    }
                }

                // here means a line with a word not in the list of word to add
                // just write the existing info
                if (indexToRemove == -1)
                {
                    sw.Write(lines[curLineIndex] + "\r\n");
                    curLineIndex++;
                }
                else
                {
                    wordsToAdd.RemoveAt(indexToRemove);
                    if (wordsToAdd.Count == 0)
                    {
                        updateDone = true;
                    }
                }

            }// end while loop through each line

        } //end using stream writer
    }

    // currently only for memory game
    public int GetLastSavedLevel()
    {

        bool targetSection = false;
        bool targetLanguage = false;
        string targetLanguageTag = "Language:\t" + logInfo.LanguageName;
        int lastLevel = 0;
        using (StreamReader sr = new StreamReader(mainLogFileInfo.FullName))
        {
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();
                if (line == ("[" + ActivityNames[(int)ActivityType.Memory] + "]"))
                {
                    targetSection = true;
                    continue;
                }

                // if the previous line has not triggered the section to be flagged
                // this line is irrevalant
                if (!targetSection)
                    continue;


                // if we read the end tag and still hasnt break out of the
                // while loop, that means this game has never been played with this 
                // language, leave the level as 1            
                if (line == ("[/" + ActivityNames[(int)ActivityType.Memory] + "]"))
                {
                    break;
                }

                if (line == targetLanguageTag)
                {
                    targetLanguage = true;
                    continue;
                }


                // if the previous line has not triggered the language to be flagged
                // this line is irrevalant
                if (!targetLanguage)
                {
                    continue;
                }

                if (line != "" && line.StartsWith("Last level played"))
                {
                    string[] separators = { "\t" };
                    string[] words = line.Split(separators,
                            StringSplitOptions.RemoveEmptyEntries);
                    lastLevel = Int32.Parse(words[1]);
                    break;
                }
            }
        }

        return lastLevel;

    }

    public Dictionary<string, int> GetMemorySeenWordsStats()
    {
        return GetSeenWordsStats(ActivityNames[(int)ActivityType.Memory]);
    }

    public Dictionary<string, int> GetRecallSeenWordsStats()
    {
        return GetSeenWordsStats(ActivityNames[(int)ActivityType.Recall]);
    }


    public Dictionary<string, int> GetRepetitionSeenWordsStats()
    {
        return GetSeenWordsStats(ActivityNames[(int)ActivityType.Repetition]);
    }


    private Dictionary<string, int> GetSeenWordsStats(string activity)
    {
        Dictionary<string, int> seenWords = new Dictionary<string, int>();

        bool targetSection = false;
        bool targetLanguage = false;
        string targetLanguageTag = "Language:\t" + logInfo.LanguageName;
        
        using (StreamReader sr = new StreamReader(mainLogFileInfo.FullName))
        {
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();
                if (line == ("[" + activity + "]"))
                {
                    targetSection = true;
                    continue;
                }

                // if the previous line has not triggered the section to be flagged
                // this line is irrevalant
                if (!targetSection)
                    continue;

                if (line == ("[/" + activity + "]"))
                    break;

                if (line == targetLanguageTag)
                {
                    targetLanguage = true;
                    continue;
                }


                // if the previous line has not triggered the language to be flagged
                // this line is irrevalant
                if (!targetLanguage)
                    continue;

                // a blank line at this stage means all info finish for this
                // language for this activity
                if (line == "")
                    break;

                // if exist ignore this line
                if (line.StartsWith("Last level played"))
                    continue;


                // if after all the filtering the line reaches here
                // it contains the info we need

                string[] separators = { "\t" };
                string[] words = line.Split(separators,
                        StringSplitOptions.RemoveEmptyEntries);
                seenWords.Add(words[0], Int32.Parse(words[1]));
            }
        }

        return seenWords;

    }




    // do these together to minimise read/write
    public void UpdateLanguageAndActivity()
    {
        
        string[] lines = File.ReadAllLines(mainLogFileInfo.FullName);

        // just want to make sure the log update is in the right section in 
        // case there are the same content in other section
        bool targetSection = false;
        bool languageDone = false;
        bool activityDone = false;
        int curLineIndex = 0;

        using (StreamWriter sw = new StreamWriter(mainLogFileInfo.FullName))
        {
            
            while (curLineIndex < lines.Length)
            {
                
                // finished all the update, just write the text as is
                if (languageDone && activityDone)
                {
                    sw.Write(lines[curLineIndex] + "\r\n");
                    curLineIndex++;
                    continue;
                }

                /////////// Language /////////
                if (lines[curLineIndex] == "Languages used: ")
                {
                    targetSection = true;
                    sw.Write(lines[curLineIndex] + "\r\n");
                    curLineIndex++;
                    continue;
                }

                // make sure we are in the right section 
                if (targetSection && !languageDone)
                {
                    // there are 2 situition this update can end up be
                    // 1. adding a new language
                    // 2. updating an existing stat
                   
                    // Updaing an existing line, the only case is:
                    // 1. "Languages used: " followed by some languages with 
                    // one of them being the current one
                    //
                    // the line is not a blank so not end of section yet
                    if (lines[curLineIndex] != "")
                    {
                        // find if this is the language needed
                        if (lines[curLineIndex].StartsWith(logInfo.LanguageName))
                        {
                            //found it
                            string[] separators = { "\t" };
                            string[] words = lines[curLineIndex].Split(separators,
                                StringSplitOptions.RemoveEmptyEntries);

                            // since we know the format below is direct manipulation
                            string newLine = words[0] + "\t" + (Int32.Parse(words[1]) + 1).ToString();
                            sw.Write(newLine + "\r\n");
                            languageDone = true;
                            targetSection = false;
                            curLineIndex++;
                            continue;
                        }
                        else {
                            // not what we need, write and continue searching
                            sw.Write(lines[curLineIndex] + "\r\n");
                            curLineIndex++;
                            continue;
                        }
                    }

                    // Adding a new language, possible cases are 
                    // 1. "Languages used: " followed by a blank line (new file)
                    // 2. "Languages used: " followed by some language but not the current one
                    // both cases can be concluded when a blankline is hit and nothing 
                    // has been done
                    if (lines[curLineIndex] == "")
                    {
                        string newLine = logInfo.LanguageName + "\t" + (1).ToString();
                        sw.Write(newLine + "\r\n");
                        sw.Write(lines[curLineIndex] + "\r\n"); // write back the blank line
                        languageDone = true;
                        targetSection = false;
                        curLineIndex++;
                        continue;
                    }

                }



                /////////// activity /////////
                if (lines[curLineIndex] == "Games played: ")
                {
                    targetSection = true;
                    sw.Write(lines[curLineIndex] + "\r\n");
                    curLineIndex++;
                    continue;
                }

                if (targetSection && !activityDone)
                {
                    // Updaing an existing line, the only case is:
                    // 1. "Games played: " followed by the activities with 
                    // one of them being the current one
                    if (lines[curLineIndex] != "")
                    {
                        if (lines[curLineIndex].StartsWith(logInfo.ActivityName))
                        {
                            string[] separators = { "\t" };
                            string[] words = lines[curLineIndex].Split(separators, 
                                StringSplitOptions.RemoveEmptyEntries);
                            // since we know the format below is direct manipulation
                            string newLine = words[0] + "\t" + (Int32.Parse(words[1]) + 1).ToString();
                            sw.Write(newLine + "\r\n");
                            languageDone = true;
                            targetSection = false;
                            curLineIndex++;
                            continue;
                        }
                        else
                        {
                            // not what we need, write and continue searching
                            sw.Write(lines[curLineIndex] + "\r\n");
                            curLineIndex++;
                            continue;
                        }
                    }
                    // else end of activity section
                    // the writing of the blank line should be covered
                    // in the next few lines
                }


                // everything else, this is for before hitting the
                // language section
                sw.Write(lines[curLineIndex] + "\r\n");
                curLineIndex++;



            }
               
        }

       

    }

   
}
