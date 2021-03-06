﻿namespace MimeDetective
{
    using System.IO;

    /// <summary>
    /// A set of extension methods for use with document formats.
    /// </summary>
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// Determines whether the specified file is zip archive
        /// </summary>
        /// <param name="fileInfo">The file info.</param>
        /// <returns>
        ///   <c>true</c> if the specified file info is zip; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsZip(this FileInfo fileInfo)
			=> fileInfo.IsType(MimeTypes.ZIP);

        /// <summary>
        /// Determines whether the specified file is RAR-archive.
        /// </summary>
        /// <param name="fileInfo">The FileInfo.</param>
        /// <returns>
        ///   <c>true</c> if the specified file info is RAR; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsRar(this FileInfo fileInfo)
			=> fileInfo.IsType(MimeTypes.RAR);
        
    }
}