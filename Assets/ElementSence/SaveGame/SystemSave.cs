using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SystemSave
{
    //Hàm lưu game
    public static void SaveGame(Data D_data){
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "savefile.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        SystemData data = new SystemData(D_data);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    //Hàm load Game
    public static SystemData LoadData(){
        string path = Application.persistentDataPath + "/savefile.fun";

        if(File.Exists(path)){//File đã tồn tại
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SystemData data = formatter.Deserialize(stream) as SystemData;
            stream.Close();
            return data;
        }else{//Không tìm thấy file save
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}
