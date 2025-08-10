using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDShared
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }
        public static bool CreateFolderIfDoesNotExist(string folderPath)
        {
            try
            {
                if (!System.IO.Directory.Exists(folderPath))
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                    return true;
                }
                return false; // Folder already exists
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating folder: " + ex.Message);
                return false; // Error occurred
            }
        }
        public static string ReplaceFileNameWithGUID(string SourceFile) { 
        string FileName= SourceFile;
            FileInfo FI = new FileInfo(FileName);
            string extis= FI.Extension;
            return GenerateGUID() + extis;
        }

        public static bool copyImageToProjectImagesFolder(ref string sourceFile)
        {

            string DestinationFolder = @"E:\DVLD\packagesImages\PeopleImagesProject\";
            if (CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }
            string DestinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, DestinationFile, true);
            }
            catch (IOException IOX)
            {

                return false;
            }
            sourceFile = DestinationFile;
            return true;
        }















    }
}
