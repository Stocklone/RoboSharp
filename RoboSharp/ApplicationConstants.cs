﻿using System.Collections.Generic;

namespace RoboSharp
{
    internal class ApplicationConstants
    {
        internal static Dictionary<string, string> ErrorCodes = new Dictionary<string, string>()
        {
            { "ERROR 33 (0x00000021)", "The process cannot access the file because another process has locked a portion of the file." },
            { "ERROR 32 (0x00000020)", "The process cannot access the file because it is being used by another process." },
            { "ERROR 5 (0x00000005)", "Access is denied." }
        };
    }
}
