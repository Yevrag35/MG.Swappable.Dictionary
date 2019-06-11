using System;
using System.Collections.Generic;

namespace MG.Swappable
{
    public interface ISwappable
    {
        string NewKey { get; set; }
        string OldKey { get; set; }
        object Value { get; set; }

        KeyValuePair<string, object> AsNewPair();
    }

    public interface ISwappableDictionary
    {
        bool ContainsKey(string key, StringComparison comparison);
        bool TryGetKey(string key, StringComparison comparison, out string outKey);
        bool TryGetKvp(string key, StringComparison comparison, out KeyValuePair<string, object> outKvp);

        ISwappable NewSwappable(string newKey, string oldKey, StringComparison comparison);
        void Swap(string newKey, StringComparison comparison);
        void Swap(ISwappable swapWith);
    }
}
