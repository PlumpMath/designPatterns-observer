using System;
using System.Collections.Generic;

namespace observer
{
    class Doer
    {
        public MulticastNotifier<string> AfterDoSomethingWith;
        public MulticastNotifier<Tuple<string, string>> AfterDoMore;

        private string _data = string.Empty;

        public void DoSomethingWith(string data)
        {
            _data = data;
            onAfterDoSomethingWith(_data);
        }

        public void DoMore(string appendData)
        {
            _data += appendData;
            onAfterDoMore(_data, appendData);
        }

        private void onAfterDoSomethingWith(string data)
        {
            if (AfterDoSomethingWith != null)
            {
                AfterDoSomethingWith.Notify(this, data);
            }
        }
        private void onAfterDoMore(string completeData, string appendedData)
        {
            if (AfterDoMore != null)
            {
                AfterDoMore.Notify(this, Tuple.Create(completeData, appendedData));
            }
        }
    }
}