using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ChessLogic;


namespace UI
{
    internal class Images
    {
        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new();
        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new();
        private static ImageSource LoadImage(string filePath)
        {
            return new BitmapImage(new Uri(filePath, UriKind.Relative));
        }
    }
}
