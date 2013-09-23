using System;
using System.Text.RegularExpressions;
using regexdownloader.Annotations;

namespace regexdownloader
{
    class DownloadSettings
    {
        [UsedImplicitly]
        internal bool AutoRename = false;

        [UsedImplicitly]
        internal string Url = "";

        [UsedImplicitly]
        internal ConflictAction ConflictAction = ConflictAction.Autorename;

        [UsedImplicitly]
        internal int CounterEnd = 0;

        [UsedImplicitly]
        internal int CounterStart = 0;

        [UsedImplicitly]
        internal DownloadType DwnType = DownloadType.Mathces;

        [UsedImplicitly]
        internal string OutputDir;

        [UsedImplicitly]
        internal bool Relative = false;

        [UsedImplicitly]
        internal bool RghostPatch = false;

        [UsedImplicitly]
        internal bool SkipExisting = true;

        [UsedImplicitly]
        internal bool SleepBetween = false;

        [UsedImplicitly]
        internal int SleepTime = 0;

        [UsedImplicitly]
        internal Regex UrlRegex = null;

        [UsedImplicitly]
        internal bool UseCounter = false;

        [UsedImplicitly]
        internal bool VocarooPatch = false;

        internal Action<ProgressInfo> ReportProgres;
    }
}