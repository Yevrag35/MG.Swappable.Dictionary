using System;
using System.Collections.Generic;

namespace MG.Swappable
{
    internal class DictionarySwap : ISwappable
    {
        string ISwappable.NewKey { get; set; }
        string ISwappable.OldKey { get; set; }
        object ISwappable.Value { get; set; }

        private DictionarySwap(string newKey, KeyValuePair<string, object> oldKvp)
        {
            ((ISwappable)this).NewKey = newKey;
            ((ISwappable)this).OldKey = oldKvp.Key;
            ((ISwappable)this).Value = oldKvp.Value;
        }

        KeyValuePair<string, object> ISwappable.AsNewPair()
        {
            return new KeyValuePair<string, object>(((ISwappable)this).NewKey, ((ISwappable)this).Value);
        }

        internal static ISwappable New(string newKey, KeyValuePair<string, object> oldKvp) => new DictionarySwap(newKey, oldKvp);
    }
}
