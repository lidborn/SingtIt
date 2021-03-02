using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public enum decades : int
{
    y1910 = 0,
    y1920 = 1,
    y1930 = 2,
    y1940 = 3,
    y1950 = 4,
    y1960 = 5,
    y1970 = 6,
    y1980 = 7,
    y1990 = 8,
    y2000 = 9,
    y2010 = 10,
    y2020 = 11
};
public class WordTwist
{
    public string question;
    public int difficulty;
    public int decade;
    public WordTwist(string question, int difficulty, int decade)
    {
        this.question = question;
        this.difficulty = difficulty;
        this.decade = decade;
    }

}

public class DataForPlayers : MonoBehaviour
{
    // Start is called before the first frame update
    public int difficulty = 5;
    public List<int> decadesList = new List<int>(12);
    public List<WordTwist> wtQuestions;
    // 1 = 1910s and before
    //12 = 2020s and later
    void Start()
    {
        readTextFile("Assets/TextFiles/wordtwist_grotto.txt");

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnEnable()
    {
        for (int i = 0; i < 12; i++)
        {
            decadesList.Add(i);
            // Debug.Log(i);
        }
    }
    void readTextFile(string file_path)
    {
        StreamReader inp_stm = new StreamReader(file_path);

        int diff = 0;
        int decade = 0;
        string question = "";

        while (!inp_stm.EndOfStream)
        {
            //WT READ//
            string line = inp_stm.ReadLine();
            if(line == "wordtwist")
            {
                diff = int.Parse(inp_stm.ReadLine());
                if (diff > difficulty)
                    break;                   

                decade = int.Parse(inp_stm.ReadLine());

                for (int i = 0; i < decadesList.Count; i++)
                {

                }
                if (true)
                {
                    WordTwist temp = new WordTwist(question, diff, decade);

                    wtQuestions.Add(temp);
                }


            }
            ///////////////////////
        }

        inp_stm.Close();
    }
}

