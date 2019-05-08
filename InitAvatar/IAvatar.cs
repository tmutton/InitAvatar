using System.IO;

namespace InitAvatar
{
    interface IAvatar
    {
        Stream Draw(int width, int height);
    }
}
