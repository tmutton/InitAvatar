﻿using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace InitAvatar
{
    public class AvatarInitials: IAvatar
    {
        private AvatarSettings AvatarSettings { get; set; }

        public AvatarInitials(AvatarSettings avatarSettings)
        {
            this.AvatarSettings = avatarSettings;
        }

        public Stream Draw(int width, int height)
        {
            Stream stream = new MemoryStream();

            var bitmap = new Bitmap(width, height);

            var graphic = Graphics.FromImage(bitmap);

            var brush = new SolidBrush(this.AvatarSettings.BackgroundColour);

            var rect = new Rectangle(0, 0, width, height);

            graphic.FillRectangle(brush, rect);

            graphic.Save();

            graphic.Dispose();

            stream.Position = 0;

            bitmap.Save(stream, ImageFormat.Jpeg);

            bitmap.Dispose();

            return stream;
        }
    }
}
