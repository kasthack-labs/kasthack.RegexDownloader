using regexdownloader.Annotations;

namespace regexdownloader
{
    internal class ProgressInfo
    {
        [UsedImplicitly]
        internal int Total;
        [UsedImplicitly]
        internal int Ready;
        [UsedImplicitly]
        internal int Error;
    }
}