using System;
using System.Text.RegularExpressions;
namespace RegexDownloader {
    public class DownloadSettings {
        public bool AutoRename = false;
        public string Url = "";
        public ConflictAction ConflictAction = ConflictAction.Autorename;
        public int CounterEnd = 0;
        public int CounterStart = 0;
        public DownloadType DwnType = DownloadType.Mathces;
        public string OutputDir;
        public bool Relative = false;
        public bool RghostPatch = false;
        public bool SleepBetween = false;
        public int SleepTime = 0;
        public Regex UrlRegex = null;
        public bool UseCounter = false;
        public bool VocarooPatch = false;
        public Action<ProgressInfo> ReportProgress;
        public Func<string, string> RenameOnConflictFunc;
    }
}