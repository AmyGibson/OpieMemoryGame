using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class WordsStats {

    private static System.Random rnd = new System.Random();
    // frequency based
	private static Dictionary<int, int> GetWordsOrder(Dictionary<string, int> seenWordsStats, string[] words)
    {
        
        int[] wordIds = Enumerable.Range(0, words.Length).ToArray();

        int[] frequency = new int[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            int value = 0;
            seenWordsStats.TryGetValue(words[i], out value);
            frequency[i] = value;
        }

        Dictionary<int, int> wordFrequencies = 
            Enumerable.Range(0, wordIds.Length).ToDictionary(i => wordIds[i], i => frequency[i]);


        /*
        string tempb = "/////////////////Before sorting";
        foreach (KeyValuePair<int, int> e in wordFrequencies)
        {
            tempb = tempb + words[e.Key] + " " + e.Value.ToString() + "\n";
        }
        Debug.Log(tempb);
        */

        // randomise the dictionary so user wont get the same order of words of 
        // same values
        System.Random rand = new System.Random();
        wordFrequencies = wordFrequencies.OrderBy(x => rand.Next())
            .ToDictionary(item => item.Key, item => item.Value);

        /*
        string tempr = "/////////////////after random";
        foreach(KeyValuePair<int, int> e in wordFrequencies)
        {
            tempr = tempr + words[e.Key] + " " + e.Value.ToString() + "\n";
        }
        Debug.Log(tempr);
        */

        // sort
        wordFrequencies = wordFrequencies.OrderBy(i => i.Value).ToDictionary(i => i.Key, i => i.Value);

        /*
        string temps = "////////////////////after sorting\n";
        foreach(KeyValuePair<int, int> e in wordFrequencies)
        {
            temps = temps + words[e.Key] + " " + e.Value.ToString() + "\n";
        }
        Debug.Log(temps);
        */

        return wordFrequencies;
        //return wordFrequencies.Keys.ToArray();
    }


    // the parameter takes in a sorted dictory of <id, performance> pairs in accending order
    private static int[] ChooseWordsPerformanceBased(Dictionary<int, int> performance, 
        int noOfWordsNeeded, string[] words)
    {
        int[] wordsPicked = new int[noOfWordsNeeded];

        List<int> wordsCanadaite = performance.Keys.ToList();

        //string temp = "";

        for (int i = 0; i < noOfWordsNeeded; i++)
        {
            
            foreach (int e in wordsCanadaite)
            {
                //temp = temp + "current e " + words[e] + "\n";
                if (e.Equals(wordsCanadaite.Last()))
                {
                   // temp = temp + "equal last " + words[wordsCanadaite.Last()] + "\n";
                    wordsPicked[i] = e;
                    wordsCanadaite.Remove(e);

                  //  temp = temp + "remaining canadaite \n";
                  //  foreach (int a in wordsCanadaite)
                  //  {
                  //      temp = temp + words[a] + "\n";
                  //  }
                  //  Debug.Log(temp);
                  //  temp = "";

                    break;
                }

                //System.Random rnd = new System.Random();
                double chance = rnd.NextDouble();
               // temp = temp + "chance " + chance.ToString() + "\n";
                if (chance <= 0.5) //50% chance
                {
                 //   temp = temp + "picked " + words[e] + "\n";
                    wordsPicked[i] = e;
                    wordsCanadaite.Remove(e);

                  //  temp = temp + "remaining canadaite \n";
                  //  foreach (int a in wordsCanadaite)
                  //  {
                  //      temp = temp + words[a] + "\n";
                  //  }
                  //  Debug.Log(temp);
                  //  temp = "";

                    break;
                }
            }
        }



        return wordsPicked;
    }

   
    // the seen Words stats should be read from memory game
    public static int[] GetOrderingFrequencyBased(Dictionary<string, int> seenWordsStats, 
        string[] words, int noOfWordsNeeded)
    {
        Dictionary<int, int> wordsFrequencies = GetWordsOrder(seenWordsStats, words);
        int[] allKeys = wordsFrequencies.Keys.ToArray();
        return allKeys.Take(noOfWordsNeeded).ToArray();
    }

    // the seen Words stats should be read from recall game 
    public static int[] GetOrderingPerformanceBased(Dictionary<string, int> seenWordsStats, 
        string[] words, int noOfWordsNeeded)
    {
        Dictionary<int, int> wordsPerformances = GetWordsOrder(seenWordsStats, words);
        return ChooseWordsPerformanceBased(wordsPerformances, noOfWordsNeeded, words);
    }
}
