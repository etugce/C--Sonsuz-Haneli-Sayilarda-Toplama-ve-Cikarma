using System;
using System.Threading;
using System.Globalization;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Drawing;
using System.Net.Mail;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Net;
using System.Design;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text;
using System.Web.SessionState;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing.Design;
using System.Drawing.Printing;
using System.Windows.Forms;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Buffer = true;
        Response.CacheControl = "no-cache";
        if (Label_kullanici.Text == "")
        {
            Label_kullanici.Text = "Test";
            Label_kullanici.Visible = false;
            T_1.Text = "0";
            T_2.Text = "0";
            T_sonuc.Text = "0";
        }
    }
    protected void B_2_cikar_Click(object sender, EventArgs e)
    {
        string sayi_1 = T_1.Text;
        string sayi_2 = T_2.Text;
        string buyuk_sayi = sayi_1;
        string kucuk_sayi = sayi_2;
        string isaret = "";
        bool sifir_ekle_kontrol = false;
        if (sayi_2.Length > sayi_1.Length)
        {
            buyuk_sayi = sayi_2;
            kucuk_sayi = sayi_1;
            isaret = "-";
            sifir_ekle_kontrol = true;
        }
        else if (sayi_1.Length == sayi_2.Length)
        {
            for (int i = 0; i < sayi_1.Length; i++)
            {
                if (sayi_1[i] != sayi_2[i])
                {
                    if (sayi_1[i] > sayi_2[i])
                    {
                        buyuk_sayi = sayi_1;
                        kucuk_sayi = sayi_2;
                        break;
                    }
                    else
                    {
                        buyuk_sayi = sayi_2;
                        kucuk_sayi = sayi_1;
                        isaret = "-";
                        break;
                    }
                }
            }
        }
        else
        {
            kucuk_sayi = sayi_2;
            buyuk_sayi = sayi_1;
            sifir_ekle_kontrol = true;
        }
        if (sifir_ekle_kontrol == true)
        {
            int fark = buyuk_sayi.Length - kucuk_sayi.Length;
            for (int i = 0; i < fark; i++) //for yerine hazır fonksiyon olabilir
            {
                kucuk_sayi = "0" + kucuk_sayi;
            }
        }
        L_1.Text = buyuk_sayi;
        L_2.Text = kucuk_sayi;
        short elde = 0;
        string sonuc_ters = "";
        for (int i = buyuk_sayi.Length - 1; i >= 0; i--)
        {
            int basamak_islem = (Convert.ToInt32(buyuk_sayi[i].ToString()) - Convert.ToInt32(kucuk_sayi[i].ToString())) + elde;
            if (basamak_islem < 0)
            {
                sonuc_ters += Convert.ToString(10 + basamak_islem);
                elde = -1;
            }
            else
            {
                sonuc_ters += Convert.ToString(basamak_islem);
                elde = 0;
            }
        }
        char[] sonuc_ters_array = sonuc_ters.ToCharArray();
        Array.Reverse(sonuc_ters_array);
        string sonuc_duz = new string(sonuc_ters_array);
        sonuc_duz = "x" + sonuc_duz;
        sonuc_duz = sonuc_duz.Replace("x0", "").Replace("x", "");
        string sonuc = isaret + sonuc_duz;
        T_sonuc.Text = sonuc;
    }
    protected void B_1_Click(object sender, EventArgs e)
    {
        string sayi_1 = T_1.Text;
        char[] sayi_1_array = sayi_1.ToCharArray();
        Array.Reverse(sayi_1_array);
        string ters_sayi_1 = new string(sayi_1_array);
        string sayi_2 = T_2.Text;
        char[] sayi_2_array = sayi_2.ToCharArray();
        Array.Reverse(sayi_2_array);
        string ters_sayi_2 = new string(sayi_2_array);
        int sayi_1_uzunluk = ters_sayi_1.Length;
        int sayi_2_uzunluk = ters_sayi_2.Length;
        if (sayi_1_uzunluk > sayi_2_uzunluk)
        {
            int uzunluk_farki = sayi_1_uzunluk - sayi_2_uzunluk;
            for (int i = 0; i < uzunluk_farki; i++)
            {
                ters_sayi_2 += "0";
            }
        }
        if (sayi_2_uzunluk > sayi_1_uzunluk)
        {
            int uzunluk_farki = sayi_2_uzunluk - sayi_1_uzunluk;
            for (int i = 0; i < uzunluk_farki; i++)
            {
                ters_sayi_1 += "0";
            }
        }
        L_1.Text = ters_sayi_1;
        L_2.Text = ters_sayi_2;
        short elde = 0;
        string sonuc = "";
        for (int i = 0; i < ters_sayi_2.Length; i++)
        {
            int basamak_toplam = Convert.ToInt32(ters_sayi_2[i].ToString()) + Convert.ToInt32(ters_sayi_1[i].ToString()) + elde;
            if (basamak_toplam >= 10)
            {
                sonuc += Convert.ToString(basamak_toplam % 10);
                elde = 1;
            }
            else
            {
                sonuc += Convert.ToString(basamak_toplam);
                elde = 0;
            }
        }
        if (elde == 1)
        {
            sonuc += Convert.ToString(elde);
        }
        char[] sonuc_array = sonuc.ToCharArray();
        Array.Reverse(sonuc_array);
        string sonuc_duz = new string(sonuc_array);
        T_sonuc.Text = sonuc_duz;
    }
    protected void T_1_TextChanged(object sender, EventArgs e)
    {
        string sayi = T_1.Text;
        string araci = "";
        bool bulundu_harf = false;
        bool bulundu_sifir = false;
        for (int i = 0; i < sayi.Length; i++)
        {
            string sayi_karakter = sayi[i].ToString();
            if (sayi_karakter != "0")
            {
                bulundu_sifir = true;
                try
                {
                    int harf_kontrol = Convert.ToInt32(sayi_karakter);
                    bulundu_harf = false;
                }
                catch
                {
                    bulundu_harf = true;
                }
            }
            if (bulundu_sifir == true && bulundu_harf == false)
            {
                araci += sayi_karakter;
            }
        }
        T_1.Text = araci;
    }
    protected void T_2_TextChanged(object sender, EventArgs e)
    {
        string sayi = T_2.Text;
        string araci = "";
        bool bulundu_harf = false;
        bool bulundu_sifir = false;
        for (int i = 0; i < sayi.Length; i++)
        {
            string sayi_karakter = sayi[i].ToString();
            if (sayi_karakter != "0")
            {
                bulundu_sifir = true;
                try
                {
                    int harf_kontrol = Convert.ToInt32(sayi_karakter);
                    bulundu_harf = false;
                }
                catch
                {
                    bulundu_harf = true;
                }
            }
            if (bulundu_sifir == true && bulundu_harf == false)
            {
                araci += sayi_karakter;
            }
        }
        T_2.Text = araci;
    }
}