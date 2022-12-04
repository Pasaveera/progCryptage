using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeCryptage
{
    class CryptagePerso
    {
        //Encrypt with thai words base on ther resemblance of the alphabet
        //This is a symmetric key - use to encrypt and decrypt
        //Alphabet array ascii 97-122
        //Thai word array 
        /*string[] thaiKey = { "crazy","baimai","kai","dek","yea","fan","chan","nokhuk","animal","choe","khai","ling"
        ,"ma","nu","ok","pla","khwai","rua","suea","tao","stay","fa","waen","ruesi","oyster","sala"};
        */
        string[] thai = { "บ้า", "ใบไม้", "ไก่" , "เด็ก" , "อือ" , "ฟัน" , "จาน", "นกฮูก" , "กิน","จน", "ไข่" , "ลิง", "หมา", "หนู" , "โรงแรม" , "ปลา",
        "ควาย","เรือ","เสือ","เต่า","อยู่","เลีย","แหวน","ฤาษี","เหยียบ","ศาลา"};
        

        #region Constructor
        public CryptagePerso()
        {

        }
        #endregion

        #region Methods
        public List<string> Crypt(string msg)
        {
            List<string> encryptMsg = new List<string>();
            
            int i = 0;
            int j = 97;

            
            foreach(char letter in msg)
            {
                while(i!=27)
                {
                    //Punctuation .
                    if(letter==46)
                    {
                        encryptMsg.Add("๐");
                        break;
                    }
                    if (letter == 32)
                    {
                        encryptMsg.Add("๑");
                        break;
                    }
                    if(letter==33)
                    {
                        encryptMsg.Add("๒");
                        break;
                    }
                    if(letter==63)
                    {
                        encryptMsg.Add("๓");
                        break;
                    }
                    if (letter == j)
                    {
                        encryptMsg.Add(thai[i]);
                    }
                    i++;
                    j++;
                }
                i = 0;
                j = 97;
            }  

            return encryptMsg;
        }

        public string StringBuild(string[] cryptArray)
        {
            return string.Join(string.Empty, cryptArray);
        }

        public List<char> Decrypt(string msg)
        {
            List<char> decryptMsg = new List<char>();
            var builder = new StringBuilder();
            int j = 0;
            
            foreach(char letter in msg)
            {
                builder.Append(letter);
                
                while (j!=26)     
                {
                    if(letter==3664)
                    {
                        decryptMsg.Add('.');
                        builder.Clear();
                        break;
                    }
                    if (letter == 3665) //for ๑
                    {
                        decryptMsg.Add(' ');
                        builder.Clear();
                        break;
                    }
                    if(letter==3666)
                    {
                        decryptMsg.Add('!');
                        builder.Clear();
                        break;
                    }
                    if(letter==3667)
                    {
                        decryptMsg.Add('?');
                        builder.Clear();
                        break;
                    }
                    if (string.Compare(builder.ToString(), thai[j])==0) 
                    {
                        //calculate ascii code for the letter 97-122 is 3585-3630
                        j += 97;
                        char temp = (char)j;
                        decryptMsg.Add(temp);
                        builder.Clear();
                        break;
                    }
                    j++;
                    
                }

                j = 0;

            }




            return decryptMsg;
        }


        #endregion

        
    }
}
