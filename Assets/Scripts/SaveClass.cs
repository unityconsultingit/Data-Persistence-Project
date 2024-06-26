using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveClass : MonoBehaviour
{

    //design pattern Singleton
    public static SaveClass Instance;


    public Color TeamColor;

    public int HighScore=0;

    public string PlayerName; // new variable declared
    public string HighScorePlayerName; // new variable declared



    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
    }

    [System.Serializable]
    class SaveData
    {
        public Color TeamColor;
        public int HighScore;
        public string HighScorePlayerName;
    }

     public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.TeamColor = TeamColor;
        data.HighScore = HighScore;
        data.HighScorePlayerName = HighScorePlayerName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            TeamColor = data.TeamColor;
            HighScore = data.HighScore;
            HighScorePlayerName = data.HighScorePlayerName;
        }
    }

}


