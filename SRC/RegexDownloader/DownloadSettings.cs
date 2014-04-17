using System;
using System.Text.RegularExpressions;
namespace RegexDownloader {
    public class DownloadSettings {
        public Action<ProgressInfo> ReportProgress;
        public Func<bool> CancelFunc;  
        public bool AutoRename = false;
        public bool Relative = false;
        public bool RghostPatch = false;
        public bool ZeroChanPatch = false;
        public bool SleepBetween = false;
        public bool UseCounter = false;
        public bool VocarooPatch = false;
        public ConflictAction ConflictAction = ConflictAction.Autorename;
        public DownloadType DwnType = DownloadType.Mathces;
        public Func<string, string> RenameOnConflictFunc;
        public int CounterEnd = 0;
        public int CounterStart = 0;
        public int SleepTime = 0;
        public int ThreadCount = 1;
        public Regex UrlRegex = null;
        public string OutputDir;
        public string Url = "";
        public bool PadLeft = false;
        public int PadLength;
        public bool CreateDir = true;
    }
}