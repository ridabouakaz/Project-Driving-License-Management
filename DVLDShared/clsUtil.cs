using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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
        public static bool HandlePersonImage(ref string personImagePath, string newImagePath)
        {
            if (personImagePath != newImagePath)
            {
                if (!string.IsNullOrEmpty(personImagePath))
                {
                    try
                    {
                        File.Delete(personImagePath);
                    }
                    catch (IOException)
                    {
                        throw;
                    }
                }
            }

            if (personImagePath == newImagePath)
            {
                return true;
            }

            if (!string.IsNullOrEmpty(newImagePath))
            {
                string sourceImageFile = newImagePath;
                if (clsUtil.copyImageToProjectImagesFolder(ref sourceImageFile))
                {
                    personImagePath = sourceImageFile;

                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
        public static string Encrypt(string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encrypted);
        }
        public static string Decrypt(string cipher)
        {
            try
            {
                byte[] data = Convert.FromBase64String(cipher);
                byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
                return Encoding.UTF8.GetString(decrypted);
            }
            catch
            {
                return "";
            }
        }
        public static void SaveLoginInfo(string username, string password, bool rememberMe)
        {
            string path = @"E:\DVLD\Shared\RememberMe.txt";


            if (rememberMe)
            {
                string[] lines =
                {
            Encrypt(username),
            Encrypt(password),
            "true"
        };
                File.WriteAllLines(path, lines);
            }
            else
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
        }
    }
}
