using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResizer
{
    public class FileOperations
    {
        Bitmap newImage;

        /// <summary>
        /// Opens Dialog for user to select an image
        /// (Filters| jpg; png; bmp;
        /// </summary>
        /// <returns>Bitmap from the file selected</returns>
        public Bitmap OpenFile(object textfield_pathopened)
        {
            //setting up the open file dialog and setting configurations
            OpenFileDialog ofd = new OpenFileDialog();

            //setting default opening directory
            ofd.InitialDirectory = @"S:\GAMESTUDIO\GMS-1.4-Projects\Maze Attack The Beginning of Great Journeies.gmx\EditingImages\To Use\ItemIcons\No background\Characters";
            ofd.Filter = "images| *.jpg; *.png; *.bmp";

            //checking if image is selected
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //setting path_open text field
                ((TextBox)textfield_pathopened).Text = ofd.FileName;

                //setting the selected img into a new bitmap to be returned
                newImage = new Bitmap(ofd.FileName);
            }

            return newImage;

        }
    }
}
