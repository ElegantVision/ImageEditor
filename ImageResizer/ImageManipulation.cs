using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer
{
    public class ImageEventArgs : EventArgs
    {
        public Bitmap e_bmap { get; set; }
    }

    public class ImageManipulation
    {
        
        /// <summary>
        /// Sets a new color into the bitmap image selected. Fires Event Afterwards
        /// </summary>
        /// <param name="bmimg">The Image You Want To Manipulate</param>
        public void Manipulate(Bitmap bmimg)
        {
            Color theColor = new Color();

            for (int w = 0; w < bmimg.Width; w++)
            {
                for (int h = 0; h < bmimg.Height; h++)
                {
                    //get pixel's color at X and Y
                    theColor = bmimg.GetPixel(w, h);

                    //change the color at pixel
                    Color newColor = Color.FromArgb(theColor.A, theColor.R, theColor.G, 0);

                    //set the new color of that pixel
                    bmimg.SetPixel(w, h, newColor);
                }
            }

            

            //call the method to publish the event
            OnImageFinished(bmimg);
        }

        //define the eventhandler delegate
        public event EventHandler<ImageEventArgs> ImageFinished;

        //add event method
        protected virtual void OnImageFinished(Bitmap bmap)
        {
            //checks if this event has listeners if so create new imageeventargs with new value in property
            ImageFinished?.Invoke(this, new ImageEventArgs { e_bmap = bmap });
        }
    }

    
}
