using System.Collections;

namespace Otus.Archiver.Base
{
    public interface IArchive
    {
        EncodingType Type { get; set; }
        byte[] Data { get; set; }
        object[] Settings { get; set; }
    }
}