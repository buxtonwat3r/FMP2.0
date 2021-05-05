//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public static class SaveSystem
//{
//    public static void SavePlayer(ScoreManager player)
//    {
//        BinaryFormatter formatter = new BinaryFormatter();
//        string path = Application.persistentDataPath + "/PTGameManager.dat";
//        FileStream stream = new FileStream(path, FileMode.Create);

//        PlayerData data = new PlayerData(player);

//        formatter.Serialize(stream, data);
//        stream.Close();
//        Debug.Log("Successful Save In " + path);
//    }

//    public static ScoreManager LoadPlayer()
//    {
//        string path = Application.persistentDataPath + "/PTGameManager.dat";
//        if (File.Exists(path))
//        {
//            BinaryFormatter formatter = new BinaryFormatter();
//            FileStream stream = new FileStream(path, FileMode.Open);

//            PlayerData data = formatter.Deserialize(stream) as PlayerData;
//            stream.Close();

//            Debug.Log("Successful Load In " + path);

//            return data;
//        }
//        else
//        {
//            Debug.LogError("No Save Found In " + path);
//            return null;
//        }
//    }
//}
