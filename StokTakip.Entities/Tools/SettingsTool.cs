using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace StokTakip.Entities.Tools
{
    public static class SettingsTool
    {

        static FileIniDataParser parser = new FileIniDataParser(); // Dosyayı oluşturacak araç
        static IniData data;
        static string dosyaAdi = "Settings.ini";

        static SettingsTool()
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\"+ dosyaAdi)==true)
            {
                data = parser.ReadFile(dosyaAdi);
            }
            else
            {
                using (System.IO.File.Create(Application.StartupPath + "\\" + dosyaAdi))
                {
                    
                };
                data = parser.ReadFile(dosyaAdi);
            }
        }

        public enum Ayarlar
        {
            SmsAyarları_KullanıcıAdı,
            SmsAyarları_Parola,
            SatisAyarlari_VarsayilanDepo,
            SesAyari_Varsayilan,
            VeriTabaniYedekleme_Varsayilan,
            WebSitesi_URL
        }

        public static void AyarDegistir(Ayarlar ayar, string value)
        {
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
            if (data != null)
            {
                if (data.Sections.Count(c=> c.SectionName == gelenAyar[0])==0)
                {
                    data.Sections.AddSection(gelenAyar[0]);
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }
            }
            else
            {
                data[gelenAyar[0]].AddKey(gelenAyar[1]);
            }
            
            data[gelenAyar[0]][gelenAyar[1]] = value;
        }

        public static string AyarOku(Ayarlar ayar)
        {
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
            return data[gelenAyar[0]][gelenAyar[1]];
        }

        public static void Save()
        {
            parser.WriteFile(dosyaAdi,data);
        }

        //////////////////RGB Formatına Ayrıma ////////////////////////////////////////////////
        //string value = textEdit1.Text;
        //string[] lines = Regex.Split(value, ",");
        //List<int> argb = new List<int>();
        //    foreach (string line in lines)
        //{
        //    argb.Add(Convert.ToInt32(line));
        //}
        //simpleButton1.Appearance.BackColor = Color.FromArgb(argb[0], argb[1], argb[2], argb[3]);
        //////////////////RGB Formatına Ayrıma ////////////////////////////////////////////////
    }
}
