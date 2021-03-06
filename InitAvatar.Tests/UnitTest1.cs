using System;
using System.Drawing;
using Xunit;

namespace InitAvatar.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var initials = new char[] { 't', 'm' };

            var avatarSettings = new AvatarSettings()
            {
                BackgroundColour = Color.Green,
                TextColour = Color.White,
                Initials = initials
            };

            using (var drawing = new AvatarInitials(avatarSettings).Draw(500, 500))
            {
                using (var img = Image.FromStream(drawing))
                {
                    img.Save("test.jpg");
                }
            }   
        }
    }
}
