using System;
using System.Runtime.InteropServices;
using System.Security;

namespace PokeCatcher.Core
{
    /// <summary>
    /// Helpers for <see cref="SecureString"/> class
    /// </summary>
    public static class SecureStringHelpers
    {
        /// <summary>
        /// Unswcures a <see cref="SecureString"/> to plain text
        /// </summary>
        /// <param name="secureString">The secure string</param>
        /// <returns></returns>
        public static string Unsecure(this SecureString secureString)
        {
            // make sure we have a secure string
            if (secureString == null)
                return string.Empty;

            // get a pointer for an unsecure string in memory
            var unmanagedString = IntPtr.Zero;

            try
            {
                // unsecures the password
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                // clean up any memory allocation
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
