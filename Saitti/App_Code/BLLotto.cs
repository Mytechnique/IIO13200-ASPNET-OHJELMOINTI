using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Luokka sisältää kaksi lottotyyppiä, VIkingLoton jossa arvotaan 6 numeroa 48:sta
/// ja SuomiLoton jossa arvotaan 7 numeroa 39:stä.
/// </summary>
public class BLLotto
    {
        private int pieninNumero;
        private int suurinNumero;
        private int lkmNumero;
        private int tyyppi;
        private List<int> result;
        private Random rand;

        public int LotonTyyppi
        {
            get
            {
                return tyyppi;
            }
            set
            {
                tyyppi = value;
            }
        }

        public List<int> Arvonta()
        {
            try
            {
                rand = new Random();
                result = new List<int>();
                switch (tyyppi)
                {
                    case 1:
                        for (int i = 0; i < 7; i++)
                        {
                            result.Add(rand.Next(1, 39));
                        }
                        break;
                    case 2:
                        for (int i = 0; i < 6; i++)
                        {
                            result.Add(rand.Next(1, 48));
                        }
                        break;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
