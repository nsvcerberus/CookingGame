using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using Newtonsoft.Json;

namespace Cooking.Editor.LevelsData
{
    [CreateAssetMenu(fileName = "LevelsEditor", menuName = "Editor/Levels"), Serializable]
    public class LevelsEditor : SerializedScriptableObject
    {
        #region CONFIGURATION
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings()
        {
            PreserveReferencesHandling = PreserveReferencesHandling.None,
            ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            TypeNameHandling = TypeNameHandling.All
        };

        private string directory => Application.dataPath + "/Resources/Json/";
        private string filePath => directory + jsonFileName + ".json";
        #endregion

        #region LOAD - LEVEL DATA
        [HorizontalGroup("Load")] public TextAsset fileWithData;

        [Button, DisableIf("@this.fileWithData == null"), HorizontalGroup("Load")]
        private void Load()
        {
            levels = Deserialize(fileWithData.text);
        }

        public List<LevelData> Deserialize(string jsonData)
        {
            return (List<LevelData>)JsonConvert.DeserializeObject(jsonData, typeof(List<LevelData>), serializerSettings);
        }
        #endregion

        #region LEVEL DATA
        [ListDrawerSettings(CustomAddFunction = "AddNewLevel"), OdinSerialize, NonSerialized] public List<LevelData> levels;

        private LevelData AddNewLevel()
        {
            var level = new LevelData();
            level.number = levels.Count + 1;
            level.clients = new List<ClientData>();
            return level;
        }
        #endregion

        #region SAVE - LEVEL DATA
        [HorizontalGroup("Save")] public string jsonFileName;

        [Button, DisableIf("@string.IsNullOrWhiteSpace(this.jsonFileName)"), HorizontalGroup("Save")]
        private void Save()
        {
            var data = JsonConvert.SerializeObject(levels, Formatting.Indented, serializerSettings);

            if (Directory.Exists(directory) == false)
                Directory.CreateDirectory(directory);

            File.WriteAllText(filePath, data);
            AssetDatabase.Refresh();
        }
        #endregion
    }
}