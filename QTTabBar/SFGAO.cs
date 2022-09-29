﻿using System;


namespace QTTabBarLib
{
    [Flags]
    internal enum SFGAO : uint
    {
        CANCOPY = 1,
        CANMOVE = 2,
        CANLINK = 4,
        STORAGE = 8,
        CANRENAME = 16, // 0x00000010
        CANDELETE = 32, // 0x00000020
        HASPROPSHEET = 64, // 0x00000040
        DROPTARGET = 256, // 0x00000100
        SYSTEM = 4096, // 0x00001000
        ENCRYPTED = 8192, // 0x00002000
        ISSLOW = 16384, // 0x00004000
        GHOSTED = 32768, // 0x00008000
        LINK = 65536, // 0x00010000
        SHARE = 131072, // 0x00020000
        READONLY = 262144, // 0x00040000
        HIDDEN = 524288, // 0x00080000
        NONENUMERATED = 1048576, // 0x00100000
        NEWCONTENT = 2097152, // 0x00200000
        STREAM = 4194304, // 0x00400000
        STORAGEANCESTOR = 8388608, // 0x00800000
        VALIDATE = 16777216, // 0x01000000
        REMOVABLE = 33554432, // 0x02000000
        COMPRESSED = 67108864, // 0x04000000
        BROWSABLE = 134217728, // 0x08000000
        FILESYSANCESTOR = 268435456, // 0x10000000
        FOLDER = 536870912, // 0x20000000
        FILESYSTEM = 1073741824, // 0x40000000
        HASSUBFOLDER = 2147483648, // 0x80000000
    }
}
