using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;

namespace Cooking.Editor.LevelsData
{
    [Serializable]
    public class ClientData
    {
        [ValueDropdown("GetClientsNames")] public string name;
        public List<Sweetness> sweets;

        public IEnumerable<string> GetClientsNames() => new List<string>() {
            "boy1", "boy2", "boy3", "boy4",
            "girl1", "girl2", "girl3",
            "man1", "man2", "man3"
        };
    }
}