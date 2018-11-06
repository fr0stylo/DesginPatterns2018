using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game {
    class DebugLogSingleton {
        private static DebugLogSingleton _instance;

        public List<DebugLog> DebugLogs { get; set; }
        public event EntryHandler OnEntry;
        public EventArgs e = null;

        public delegate void EntryHandler(EventArgs e);

        private DebugLogSingleton() {
            DebugLogs = new List<DebugLog>();
        }

        public void Log<T>(string pattern, string ex) {
            DebugLogs.Add(new DebugLog {Pattern = pattern, Class = typeof(T).ToString(), Execution = ex});
            OnEntry?.Invoke(e);
        }

        public override string ToString() {
            var sb = new StringBuilder();

            DebugLogs.ForEach(x => sb.Append(x.ToString()));

            return sb.ToString();
        }

        public string Filter(string filter) {
            var sb = new StringBuilder();
            DebugLogs.Where(x => x.Pattern == filter).ToList().ForEach(x => sb.Append(x.ToString()));

            return sb.ToString();
        }

        public static DebugLogSingleton GetInstance() {
            return _instance ?? (_instance = new DebugLogSingleton());
        }
    }
}