using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postal.AspNetCore
{
    //
    // Summary:
    //     Specifies the Content-Transfer-Encoding header information for an email message
    //     attachment.
    public enum TransferEncoding
    {
        //
        // Summary:
        //     Indicates that the transfer encoding is unknown.
        Unknown = -1,
        //
        // Summary:
        //     Encodes data that consists of printable characters in the US-ASCII character
        //     set. See RFC 2406 Section 6.7.
        QuotedPrintable = 0,
        //
        // Summary:
        //     Encodes stream-based data. See RFC 2406 Section 6.8.
        Base64 = 1,
        //
        // Summary:
        //     Used for data that is not encoded. The data is in 7-bit US-ASCII characters with
        //     a total line length of no longer than 1000 characters. See RFC2406 Section 2.7.
        SevenBit = 2,
        //
        // Summary:
        //     The data is in 8-bit characters that may represent international characters with
        //     a total line length of no longer than 1000 8-bit characters. For more information
        //     about this 8-bit MIME transport extension, see IETF RFC 6152.
        EightBit = 3
    }
}
