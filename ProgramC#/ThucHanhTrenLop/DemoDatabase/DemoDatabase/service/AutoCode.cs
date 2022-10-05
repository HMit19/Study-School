using System;

public class functions
{
    public functions()
    {
    }
    public static string autoCode(string maNV)
    {
        string idCode = "MHD";
        idCode += GetMD5(maNV + DataTime.now().toString());
        return idCode;
    }
    public string GetMD5(string str)
    {
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] bHash = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));
        StringBuilder sbHash = new StringBuilder();
        foreach (byte b in bHash)
        {
            sbHash.Append(String.Format("{0:x2}", b));
        }
        return sbHash.ToString();
    }
}
