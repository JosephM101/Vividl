﻿
namespace Vividl.Model
{
    public interface IDownloadOption
    {
        string FormatSelection { get; }
        string Description { get; }
        bool IsAudio { get; }
    }
}
