﻿/****************************************************************************
**					      SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				 BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					      2019-2020 YAZ DÖNEMİ 
**	
**				PROJE NUMARASI.........: 01
**				ÖĞRENCİ ADI............: YASER BİN HUMAİDAH 
**				ÖĞRENCİ NUMARASI.......: B171200560
**              DERSİN ALINDIĞI GRUP...: A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakıt_Otomasyon
{
    class AutoGas : Benzin
    {

        

        public AutoGas(string ad, string marka, string model, string ozellik, int hamFiyat, int secilenadet)

            : base(ad, marka, model, ozellik, hamFiyat, secilenadet)
        {
            

        }

    }

}
