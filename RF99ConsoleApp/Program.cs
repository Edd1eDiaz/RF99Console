using System;

namespace RF99ConsoleApp
{
    class Program
    {
        private string Weir_Input;
        private string Material_Input;
        private string RacewayType_Input;
        private string OrificeLoc_Input;
        private string FlowSymbol_Input;
        private string TankShape_Input;
        private string TankDia_Input;
        private string RacewayLG_Input;
        private string HDLS_Input;
        private string CMC_Input;
        private string CX_Input;
        private string RacewayWD_Input;
        private string Velocity_Input;
        private string EfflMin_Input;
        private string EfflAvg_Input;
        private string EfflMax_Input;
        private string EfflPeak_Input;
        private string InflMin_Input;
        private string InflAvg_Input;
        private string InflMax_Input;
        private string InflPeak_Input;
        private string weir;
        private double TankDia;
        private string Material;
        private string TankShape;
        private string FlowSymbol;
        private string OrificeLoc;
        private double HDLS;
        private string racewaytype;
        private double RacewayLG;
        private double RacewayWD;
        private double Velocity;
        private double CX;
        private double EfflMin;
        private double CMC;
        private double EfflAvg;
        private double EfflMax;
        private double EfflPeak;
        private double InflMin;
        private double InflAvg;
        private double InflMax;
        private double InflPeak;
        private double Y1;
        private double EfflMin1;
        private double EfflAvg1;
        private double EfflMax1;
        private double EfflPeak1;
        private double InflMin1;
        private double InflAvg1;
        private double InflMax1;
        private double InflPeak1;
        private double W6;
        private double S9;
        private double Y3;
        private double W3;
        private double AT5;
        private double AT6;
        private double W2;
        private double Z9;
        private double N8;
        private double Y2;
        private double W8;
        private double W7;
        private double G4;
        private double G3;
        private double W9;
        private double T1;
        private double S6;
        private double T5;
        private double T2;
        private int O9;
        private double Num7;
        private double O1;
        private double Dol5;
        private double T4;
        private double R;
        private double S7;
        private double Num8;
        private double O3;
        private double Z8;
        private double W;
        private double AT3;
        private double AT4;
        private double Num9;
        private double O6;
        private double N7;
        private double Num2;
        private double W4;
        private double G1;
        private double S5;
        private double G2;
        private double T7;
        private double W5;
        private double T9;
        private double T6;
        private double S3;
        private double T8;


        private double[] E = new double[20];
        private double[] F = new double[20];
        private double[] AT = new double[20];
        private double[] A = new double[20];
        private double[] B = new double[20];
        private int G9;
        private int G6;
        private double Q6;
        private double X1;
        private double J3;
        private double X4;
        private double X2;
        private double N9;
        private double O4;
        private double O7;
        private double O5;
        private double P1;
        private double P5;
        private double Dol4;
        private double P2;
        private double P3;
        private double AT2;
        private double P6;
        private double J2;
        private double Y7;
        private double Y8;
        private int Z5;
        private double C;
        private double AT1;
        private double DOL3;
        private double Z3;
        private double Z4;
        private double Y5;
        private double Y6;
        private double S1;
        private double S2;
        private double NUM5;
        private double NUM6;
        private double NUM4;
        private double Z;
        private double G7;
        private double X7;
        private double L;
        private double J1;
        private int AA;
        private double G8;
        private double i;
        private double G5;
        private double X8;

        public double Z6;
        public double J;
        public double X9;

        private int Q9;
        private int Dol2;
        private double D;
        double[,] OutputData = new double[20, 20];
        private double J6;
        private double AT7;
        private double J5;
        private double AT8;

        double[,] FlowData = new double[20, 20];
        private double x;


        double[,] StdWeirData = new double[20, 20];

        double[,] StdFlowData = new double[20, 20];

        double[,] VelocityData = new double[20, 20];




        static void Main(string[] args)
        {
            //Set the inputs here
            Program p = new Program();
            p.Calc_PB_Click();
            
        }

        public void Calc_PB_Click()
        {
            Weir_Input = "Peripheral";
            Material_Input = "Concrete";
            RacewayType_Input = "Inboard";
            OrificeLoc_Input = "Floor";
            FlowSymbol_Input = "Unidirectional Flow";
            TankShape_Input = "Circular";
            TankDia_Input = "100.0";
            RacewayLG_Input = "305.665";
            HDLS_Input = ".107";
            CMC_Input = ".015";
            CX_Input = "2.5";
            RacewayWD_Input = "3";
            Velocity_Input = "1.85";

            EfflMin_Input = "6";
            EfflAvg_Input = "6";
            EfflMax_Input = "9.4";
            EfflPeak_Input = "22";

            InflMin_Input = "9";
            InflAvg_Input = "9";
            InflMax_Input = "14.1";
            InflPeak_Input = "27.5";

            //** Check for Input Data, (not neccessarily the correct data, just data)
            if ((Weir_Input == "") || (Material_Input == "") || (RacewayType_Input == "") || (OrificeLoc_Input == "") || (FlowSymbol_Input == "") || (TankShape_Input == "") || (TankDia_Input == ""))
            {
                //        MsgBox ("Please Enter All Data.")
                //        Weir_Input.SetFocus
                return;
            }
            if ((RacewayLG_Input == "") || (HDLS_Input == "") || (CMC_Input == "") || (CX_Input == "") || (RacewayWD_Input == "") || (Velocity_Input == ""))
            {
                //        MsgBox ("Please Enter All Data.")
                //        RacewayType_Input.SetFocus
                return;
            }
            if ((EfflMin_Input == "") || (EfflAvg_Input == "") || (EfflMax_Input == "") || (EfflPeak_Input == ""))
            {
                //        MsgBox ("Please Enter All Data.")
                //        EfflMin_Input.SetFocus
                return;
            }
            if ((InflMin_Input == "") || (InflAvg_Input == "") || (InflMax_Input == "") || (InflPeak_Input == ""))
            {
                //        MsgBox ("Please Enter All Data.")
                //        InflMin_Input.SetFocus
                return;
            }




            //** Data Conversion
            weir = Weir_Input;
            TankDia = double.Parse(TankDia_Input);
            Material = Material_Input;
            TankShape = TankShape_Input;
            FlowSymbol = FlowSymbol_Input;
            OrificeLoc = OrificeLoc_Input;
            HDLS = double.Parse(HDLS_Input);
            racewaytype = RacewayType_Input;
            RacewayLG = double.Parse(RacewayLG_Input);
            RacewayWD = double.Parse(RacewayWD_Input);
            Velocity = double.Parse(Velocity_Input);
            CX = double.Parse(CX_Input);
            EfflMin = double.Parse(EfflMin_Input);
            CMC = double.Parse(CMC_Input);
            EfflAvg = double.Parse(EfflAvg_Input);
            EfflMax = double.Parse(EfflMax_Input);
            EfflPeak = double.Parse(EfflPeak_Input);
            InflMin = double.Parse(InflMin_Input);
            InflAvg = double.Parse(InflAvg_Input);
            InflMax = double.Parse(InflMax_Input);
            InflPeak = double.Parse(InflPeak_Input);



            //*********************************************** CALCULATIONS ******************************************
            // Notches per foot
            Y1 = 2.4;

            // Change from MGD to Cu.Ft./Sec.
            EfflMin1 = 1.547 * EfflMin;
            EfflAvg1 = 1.547 * EfflAvg;
            EfflMax1 = 1.547 * EfflMax;
            EfflPeak1 = 1.547 * EfflPeak;
            InflMin1 = 1.547 * InflMin;
            InflAvg1 = 1.547 * InflAvg;
            InflMax1 = 1.547 * InflMax;
            InflPeak1 = 1.547 * InflPeak;

            if (Weir_Input == "Square Center Take-Off Launders")
            {
                //** Standard Effluent Weir
                W6 = CX * TankDia;
                Y3 = Math.Pow(EfflPeak, 0.4) / 1.272;// Trough Width
                Y2 = 2 * Y3 / 3;// Trough Depth
                W8 = 4 * (W6 + Y3);// Total Outside Length
                W7 = 4 * (W6 - Y3);// Total Inside Length (Weir Length)
                do
                {
                    G4 = Math.Floor(Y1 * W8);// Total Inner Notches
                    G3 = Math.Floor(Y1 * W7);// Total Outer Notches - Weir
                    T1 = Math.Pow(W, 2);
                    S6 = 2.52 * G4;
                    T5 = 2.52 * G3;
                    if (TankShape_Input == "Circular")
                    {
                        T2 = (3.1416 * TankDia * TankDia / 4) - T1;
                    }
                    if (TankShape_Input == "Non-Circular")
                    {
                        T2 = TankDia * TankDia - T1;
                    }
                    O9 = 0;
                    Num7 = Math.Pow(EfflAvg1 / (T5 * (1 + (T2 / T1))), 0.405);
                    O1 = Num7 * Math.Pow((T2 * G3) / (T1 * G4), 0.405);
                    Dol5 = 0;

                    bool breakFor = false;
                    for (int J = 1; J != 5 && !breakFor; J++)
                    {
                        T4 = J;
                        R = 10 / Math.Pow(1, T4);
                        do
                        {
                            Dol5 = Dol5 + R;
                            if ((Num7 - Dol5) <= 0)
                            {
                                break;
                            }
                            if ((O1 - Dol5) <= 0)
                            {
                                break;
                            }
                            S7 = S6 * Math.Pow(O1 - Dol5, 2.47) + T5 * Math.Pow(Num7 - Dol5, 2.47);
                            if ((S7 - EfflMin1) < 0)
                            {
                                break;
                            }
                            if ((S7 - EfflMin1) == 0)
                            {
                                breakFor = true;
                                goto forBreak1;//Exit For;
                            }
                        } while ((S7 - EfflMin1) > 0);
                        Dol5 = Dol5 - R;
                    forBreak1:;
                    }

                    Num8 = Num7 - Dol5;
                    O3 = O1 - Dol5;

                    if ((Num8 - 0.042) < 0)
                    {
                        Num8 = Math.Pow(EfflMin1 / (T5 * (1 + (T2 / T1))), 0.405);
                        O3 = Num8 * Math.Pow((T2 * G3) / (T1 * G4), 0.405);
                        Z8 = EfflMin;
                        Dol5 = -1;
                        breakFor = false;
                        for (int J = 1; J != 5 && !breakFor; J++)
                        {
                            T4 = J;
                            R = 10 / Math.Pow(1, T4);
                            do
                            {
                                Dol5 = Dol5 + R;
                                S7 = S6 * Math.Pow(O3 + Dol5, 2.47) + T5 * Math.Pow(Num8 + Dol5, 2.47);
                            } while ((S7 - EfflAvg1) < 0);
                            if ((S7 - EfflAvg1) == 0)
                            {
                                breakFor = true;
                                goto breakFor2;//Exit For;

                            }
                            Dol5 = Dol5 - R;
                        breakFor2:;
                        }
                        Num7 = Num8 + Dol5;
                        O1 = O3 + Dol5;
                    }
                    else
                    {
                        Z8 = EfflAvg;
                    }


                    do
                    {
                        Dol5 = -1;
                        breakFor = false;
                        for (int J = 1; J != 5 && !breakFor; J++)
                        {
                            T4 = J;
                            R = 10 / Math.Pow(1, T4);
                            do
                            {
                                Dol5 = Dol5 + R;
                                S7 = S6 * Math.Pow(O1 + Dol5, 2.47) + T5 * Math.Pow(Num7 + Dol5, 2.47);
                                if (O9 == 0)
                                {
                                    if ((S7 - EfflMax1) == 0)
                                    {
                                        breakFor = true;//Exit For;
                                        goto ForBreak2;
                                    }
                                    if ((S7 - EfflMax1) > 0)
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if ((S7 - EfflPeak1) == 0)
                                    {
                                        breakFor = true;//Exit For;
                                        goto ForBreak2;
                                    }
                                }
                            } while (((S7 - EfflPeak1) < 0) || (O9 == 0 && ((S7 - EfflMax1) < 0)));
                            Dol5 = Dol5 - R;
                        ForBreak2:;
                        }
                        if (O9 != 0)
                        {
                            break;
                        }
                        AT3 = Num7 + Dol5;
                        AT4 = O1 + Dol5;
                        O9 = 1;
                    } while (true);
                    Num9 = Num7 + Dol5;
                    O6 = O1 + Dol5;
                    if (((O6 - 0.208) <= 0) || (Y1 - 1.5) == 0)
                    {
                        break;
                    }
                    Y1 = 1.5;
                } while ((Y1 - 1.5) >= 0);
            }

            if (Weir_Input == "Peripheral")
            {
                //** Peripheral Weir
                S9 = CX;
                Y3 = 0.504 * Math.Pow(EfflPeak, 0.4);
                W3 = 1.58 * Y3;
                W2 = 0.91 * Y3;
                Z9 = Y3 + 2 * Y3 / Math.Pow(3, 0.5);
                N8 = Math.Pow((TankDia * TankDia / 4) - 6 * EfflPeak1 / 3.1416, 0.5);
                if ((TankDia / 2 - N8 - 0.667) < 0)
                {
                    N8 = TankDia / 2 - 0.667;
                }
                N7 = N8 - Y3;
                Num2 = TankDia / 2 - N8;
                W4 = 2 * Math.Atan(5 / Math.Pow(N8 * N8 - 25, 0.5));
                G1 = Math.Floor(3.1416 / W4);
                S5 = G1;
                G2 = Math.Floor(S5);
                T7 = N7 * 10 / N8;
                W5 = 3.1416 - S5 * W4;
                T9 = 10 * W5 / W4;
                T6 = T7 * W5 / W4;
                W7 = T7 * S5 + T6;
                if ((T9 - (S9 + 1) / 2) <= 0)
                {
                    S3 = ((S9 + 1) / 2 - T9) / Math.Cos(W4);
                    T8 = 10 - S3;
                    G2 = Math.Floor(G1 - 1);
                }
                else
                {
                    T8 = T9 - (S9 + 1) / 2;
                }
                do
                {
                    G3 = Math.Floor(Y1 * W7);
                    W9 = G3;
                    O3 = Math.Pow(EfflMin1 / (5.04 * W9), 0.405);
                    O1 = Math.Pow(EfflAvg1 / (5.04 * W9), 0.405);
                    AT4 = Math.Pow(EfflMax1 / (5.04 * W9), 0.405);
                    O6 = Math.Pow(EfflPeak1 / (5.04 * W9), 0.405);
                    if ((O6 - 0.208) <= 0 || (Y1 - 1.5) == 0)
                    {
                        break;//Exit Do;
                    }
                    Y1 = 1.5;
                } while ((Y1 - 1.5) > 0);
            }

            for (int i = 1; i != 11; i++)
            {
                E[i] = 0;
                F[i] = 0;
                AT[i] = 0;
                A[i] = 0;
                B[i] = 0;
            }
            G9 = 1;
            G6 = 0;
            Q6 = Math.Floor(RacewayLG);

            if (RacewayLG > 0)
            {
                Console.WriteLine($"Shape: {TankShape_Input}  RacewayType: {RacewayType_Input}");
                if (TankShape_Input == "Circular" && RacewayType_Input == "Inboard")
                {
                    X1 = RacewayLG * ((TankDia - RacewayWD) / TankDia);
                }
                else if (TankShape_Input == "Circular" && RacewayType_Input == "Outboard" && Material_Input == "Steel")
                {
                    X1 = RacewayLG * ((TankDia + RacewayWD) / TankDia);
                }

                else if (TankShape_Input == "Circular" && RacewayType_Input == "Outboard" && Material_Input == "Concrete")
                {
                    X1 = RacewayLG * ((TankDia + RacewayWD + 1.67) / TankDia);
                }
                else if (TankShape_Input == "Non-Circular")
                {
                    X1 = RacewayLG;
                }
            }
            else if (RacewayLG == 0)
            {
                if (RacewayType_Input == "Outboard" && Material_Input == "Concrete")
                {
                    X1 = 3.1416 * (TankDia + RacewayWD + 1.67) / 2;
                }
                else if (RacewayType_Input == "Outboard" && Material_Input == "Steel")
                {
                    X1 = 3.1416 * (TankDia + RacewayWD) / 2;
                }
                else if (RacewayType_Input == "Inboard")
                {
                    X1 = 3.1416 * (TankDia - RacewayWD) / 2;
                }
            }

            if (FlowSymbol_Input == "Unidirectional Flow")
            {
                if (RacewayLG == 0)
                {
                    X1 = 2 * X1;
                }
                InflMin1 = 3.094 * InflMin;
                InflAvg1 = 3.094 * InflAvg;
                InflMax1 = 3.094 * InflMax;
                InflPeak1 = 3.094 * InflPeak;
            }
            else if (FlowSymbol_Input == "Split Flow" && Material_Input == "Steel")
            {
                J3 = InflPeak1 * 30 / (X1 * RacewayWD);
            }
            else if (FlowSymbol_Input == "Split Flow" && Material_Input == "Concrete")
            {
                J3 = InflPeak1 * 30 / (X1 * (RacewayWD + 0.5));
            }

            if ((J3 - 5) > 0)
            {
                Console.WriteLine("Velocity Too High in Skirt Area, Change Raceway Width");//MsgBox("Velocity Too High in Skirt Area, Change Raceway Width")
                Console.WriteLine("Change the RacewayWD_Input");//RF99.RacewayWD_Input.SetFocus
                return;
            }
            Console.WriteLine($"X1: {X1}");
            X4 = X1 / 3.0;
            X2 = X1 - X4;
            N9 = InflAvg1 / (2 * Velocity * RacewayWD);
            O4 = HDLS * InflMax1 * InflMax1 / (InflAvg1 * InflAvg1);
            O7 = HDLS * InflPeak1 * InflPeak1 / (InflAvg1 * InflAvg1);
            O5 = HDLS * InflMin1 * InflMin1 / (InflAvg1 * InflAvg1);
            P1 = N9 / 3.0;
            P5 = N9 + O7 + O6 - O1 - HDLS;
            if (P5 - 5 > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Depth > 5 Ft.Peak Flow");
                Console.WriteLine("You May Change Raceway Width or Velocity or Continue Calculations As Is.");
                Console.WriteLine("Do You Wish To Change Raceway Width or Velocity?");
                Console.WriteLine("Enter \"y\" for yes and \"n\" for no");
                string userinput = Console.ReadLine();

                if (userinput == "y")//if (MsgBox(Space(40) & "Depth > 5 Ft. Peak Flow" & NL & "You May Change Raceway Width or Velocity or Continue Calculations As Is." & NL & NL & Space(20) & "Do You Wish To Change Raceway Width or Velocity?", vbYesNo) == vbYes)
                {
                    Console.WriteLine("Change the RacewayWD_Input");//RF99.RacewayWD_Input.SetFocus;
                    return;
                }

            }
            Dol4 = P5 - O7 - O6 + AT4 + O4;
            P2 = P5 - O7 - O6 + O3 + O5;
            P3 = P1 - (N9 - P2);

            if (TankDia <= 30 && P3 - 0.1036 <= 0)
            {
                Console.WriteLine("Vortex At Minimum Flow." + "\n" + "Change Raceway Width or Velocity.");// MsgBox("Vortex At Minimum Flow." & NL & "Change Raceway Width or Velocity.")
                //RF99.RacewayWD_Input.SetFocus
                return;
            }

            AT2 = N9 / 3 + (Dol4 - N9);
            P6 = N9 / 3 + (P5 - N9);
            J2 = InflPeak1 / (2 * P5 * RacewayWD);
            Y7 = InflMax1 / (2 * Dol4 * RacewayWD);
            Y8 = InflMin1 / (2 * P2 * RacewayWD);


            if (G6 == 0)
            {
                if (G9 == 0)
                {
                    return;
                }
                G6 = 1;
                if (OrificeLoc_Input == "Floor")
                {
                    Z5 = 2;
                }
                if (OrificeLoc_Input == "Wall")
                {
                    Z5 = 3;
                }
                if (Material_Input == "Steel")
                {
                    C = 0.61;
                }
                if (Material_Input == "Concrete")
                {
                    C = 0.8;
                }


                if (Material_Input == "Concrete")
                {
                    if (TankDia > 30)
                    {
                        B[1] = 0.01414;
                        B[2] = 0.0233;
                        B[3] = 0.0332;
                        B[4] = 0.0513;
                        B[5] = 0.0687;
                        B[6] = 0.0884;
                        B[7] = 0.139;
                        B[8] = 0.2006;
                        B[9] = 0.2673;
                        B[10] = 0.3474;
                        AT1 = 2;
                        DOL3 = 0.0833;
                    }
                    else if (TankDia <= 30)
                    {
                        B[1] = 0.00211;
                        B[2] = 0.00371;
                        B[3] = 0.006;
                        B[4] = 0.0104;
                        B[5] = 0.01414;
                        B[6] = 0.0233;
                        B[7] = 0.03322;
                        B[8] = 0.0513;
                        B[9] = 0.0687;
                        B[10] = 0.0884;
                        AT1 = 0.5;
                        DOL3 = 0;
                    }
                }
            }

            Z3 = ((N9 + P1) * RacewayWD) / (2 * (N9 + P1 + RacewayWD));
            Z4 = (RacewayWD * P1) / (RacewayWD + (2 * P1));
            Y5 = 0.5 * ((InflAvg1 / (2 * RacewayWD * N9)) + (InflAvg1 / (6 * RacewayWD * P1)));
            Y6 = InflAvg1 / (12 * RacewayWD * P1);
            Console.WriteLine($"CMC: {CMC}  Y5: {Y5}  Z: {Z3}");
            S1 = (CMC * Y5) / (1.486 * Math.Pow(Z3, 0.667));
            S2 = (CMC * Y6) / (1.486 * Math.Pow(Z4, 0.667));
            Console.WriteLine("X2: " + X2 + "  S1: " + S1 );
            NUM5 = X2 * S1 * S1;
            Console.WriteLine("X4: " + X4 + "  S2: " + S2);
            NUM6 = X4 * S2 * S2;
            Console.WriteLine($"NUM5: {NUM5}  NUM6: {NUM6}");
            NUM4 = NUM5 + NUM6;

            if ((HDLS - (NUM5 + NUM6 / 2)) <= 0)
            {
                Console.WriteLine("Channel Loss Too Large");//MsgBox(Space(10) & "Channel Loss Too Large" & NL & "Change Raceway Width or Velocity.")
                Console.WriteLine("Change Raceway Width or Velocity.");
                //RF99.RacewayWD_Input.SetFocus
                return;
            }
            Console.WriteLine($"HDLS: {HDLS}  NUM4: {NUM4}");
            if ((HDLS - 10 * NUM4) >= 0)
            {
                G7 = 1;
                X7 = 1;
                E[1] = X2;
            }
            else
            {
                Console.WriteLine("Num5: " + NUM5 + "  HDLS: " + HDLS);
                X7 = 10 * NUM5 / HDLS;
                Console.WriteLine("X7: " + X7);
                G7 = Math.Floor(X7 + 1);
                X7 = G7;
                if ((X7 - 30) > 0)
                {
                    Console.WriteLine("Greater Than 30 Reaches.");//MsgBox("Greater Than 30 Reaches." & NL & "Change Raceway Width or Velocity.")
                    Console.WriteLine("Change Raceway Width or Velocity.");
                    //RF99.RacewayWD_Input.SetFocus
                    return;
                }
                for (int i = 1; i != G7; i++)
                {
                    Console.WriteLine("i: " + i + "  G7: " + G7);
                    E[i] = X2 / X7;
                }
            }
            Console.WriteLine($"G7: {G7}");
            L = Math.Floor(G7 + 1);
            E[(int)L] = X4;
            J1 = InflMin1 / (12 * P3 * RacewayWD);
            for (int i = 1; i != (int)Math.Floor(G7); i++)
            {
                F[i] = InflAvg1 / (3 * X7);
            }


            F[(int)L] = InflAvg1 / 6;
            AT[1] = HDLS - (NUM5 / (2 * X7));
            if (G7 - 1 > 0)
            {
                for (int i = 2; i < G7; i++)
                {
                    J = Math.Floor((double)(i - 1));
                    AT[i] = AT[(int)J] - (NUM5 / X7);
                }
            }


            AT[(int)L] = HDLS - NUM5 - NUM6 / 2;
            Console.WriteLine($"L {L}");
            for (int i = 1; i != (int)L; i++)
            {
                A[i] = F[i] / (8.025 * C * Math.Pow(AT[i], 0.5));
                Console.WriteLine($"A[i]: {A[i]}");
            }

            AA = 1;
            if (Material_Input == "Concrete")
            {
                G8 = 0;
                i = Math.Floor(L - 1);
                do
                {
                    i = Math.Floor(i + 1);
                    bool breakFor = false;
                    for (int J = 1; J != 11 && !breakFor; J++)
                    {
                        Console.WriteLine($"A[i]: {A[(int)i]}  B[J]: {B[J]}");
                        G5 = Math.Floor((A[(int)i] / B[J]) + 0.5);
                        Console.WriteLine($"G5: {G5}");
                        if (G5 > 0)
                        {
                            X8 = G5;
                            Z6 = E[(int)i] / X8;
                            if (Z6 - AT1 >= 0)
                            {
                                if (Z6 - 6 <= 0)
                                {
                                    X9 = X8 * B[J];
                                    Q9 = 0;
                                    D = 24 * (Math.Pow(B[J] / 3.1416, 0.5));
                                    if ((P3 - (D / 6)) > 0)
                                    {
                                        if ((P3 - (Z5 * D / 12)) <= 0)
                                        {
                                            Q9 = 1;
                                            Dol2 = 1;
                                        }
                                        if (((D / 12) + DOL3 - RacewayWD) <= 0)
                                        {
                                            if (Math.Floor((double)G8) == 0)
                                            {
                                                breakFor = true;//Exit For;
                                                goto ForBreak4;
                                            }
                                            Console.WriteLine($"i: {i}");
                                            OutputData[0, AA] = i;
                                            OutputData[1, AA] = Format(E[(int)i], "#0.000");
                                            OutputData[2, AA] = G5;
                                            OutputData[3, AA] = Format(Z6, "#0.000");
                                            OutputData[4, AA] = Format(D, "#0.000");
                                            OutputData[5, AA] = Format(B[J], "#0.000");
                                            OutputData[6, AA] = Format(X9, "#0.000");
                                            OutputData[7, AA] = Format(A[(int)i], "#0.000");
                                            //ReDim Preserve OutputData(8, AA + 1)
                                            AA = AA + 1;
                                        }
                                    }
                                }
                            }
                        }
                    ForBreak4:;
                    }
                    if (Math.Floor((double)G8) == 0)
                    {
                        VelDataOutput();
                        Q9 = 0;
                        Dol2 = 0;
                        G9 = 1;
                        i = 0;
                        G8 = 1;
                    }
                } while (!(i - L >= 0));
            }


            if (Material_Input == "Steel")
            {
                J = 1;
                G9 = 0;
                T4 = 0.5;

                bool skipLine = false;
            L6230:

                do
                {
                    if (!skipLine)
                    {
                        G8 = 0;
                        i = Math.Floor(L - 2);
                        J = Math.Floor(J + 1);
                        T4 = T4 + 0.5;
                    }

                    //L6270:
                    i = Math.Floor(i + 1);
                    if (i - L < 0)
                    {
                        if (TankDia <= 30)
                        {
                            Z6 = T4;
                        }
                        else
                        {
                            Z6 = J;
                        }
                        G5 = Math.Floor(E[(int)i] / Z6 + 0.5);
                        X8 = G5;
                        Z6 = E[(int)i] / X8;
                    }
                    else
                    {
                        G5 = Math.Floor(E[(int)i] / Z6 + 0.5);
                        X8 = G5;
                    }
                    B[(int)J] = A[(int)i] / X8;
                } while (Z6 - AT1 < 0);

                if (Z6 - 6 <= 0)
                {
                    X9 = X8 * B[(int)J];
                    Q9 = 0;
                    D = 24 * (Math.Pow(B[(int)J] / 3.1416, 0.5));
                    if (P3 - (D / 6) > 0)
                    {
                        if (P3 - (Z5 * D / 12) <= 0)
                        {
                            Q9 = 1;
                            Dol2 = 1;
                        }
                        if ((D / 12) + DOL3 - RacewayWD <= 0)
                        {
                            G8 = Math.Floor((double)(G8 + 1));
                            if (G8 - 2 < 0)
                            {
                                skipLine = true;
                                goto L6230;
                            }
                            if (G8 - 2 == 0)
                            {
                                i = 0;
                                if (G9 == 0)
                                {
                                    VelDataOutput();
                                }
                                else
                                {
                                    skipLine = true;
                                    goto L6230;
                                }
                            }
                            else
                            {
                                OutputData[0, AA] = i;
                                OutputData[1, AA] = Format(E[(int)i], "#0.000");
                                OutputData[2, AA] = G5;
                                OutputData[3, AA] = Format(Z6, "#0.000");
                                OutputData[4, AA] = Format(D, "#0.000");
                                OutputData[5, AA] = Format(B[(int)J], "#0.000");
                                OutputData[6, AA] = Format(X9, "#0.000");
                                OutputData[7, AA] = Format(A[(int)i], "#0.000");
                                //ReDim Preserve OutputData(8, AA + 1)
                                AA = AA + 1;
                            }
                            if (i - L < 0)
                            {
                                skipLine = true;
                                goto L6230;
                            }
                            else
                            {
                                goto L6230;
                            }
                        }
                    }
                }
            }


            //** Flow Data
            J6 = EfflMin * 5 * Math.Pow(1, 5) * (1 / W7);
            AT7 = (EfflMax * 5 * Math.Pow(1, 5)) / W7;
            J5 = EfflAvg * 500000 / W7;
            AT8 = (EfflPeak * Math.Pow(1, 6)) / (W7 * 2);
            FlowData[0, 0] = Format(EfflMin, "#0.000");
            FlowData[0, 1] = Format(O3, "#0.000000");
            FlowData[0, 2] = Format(J6, "##");
            FlowData[1, 0] = Format(EfflAvg, "#0.000");
            FlowData[1, 1] = Format(O1, "#0.000000");
            FlowData[1, 2] = Format(J5, "##");
            FlowData[2, 0] = Format(EfflMax, "#0.000");
            FlowData[2, 1] = Format(AT4, "#0.000000");
            FlowData[2, 2] = Format(AT7, "##");
            FlowData[3, 0] = Format(EfflPeak, "#0.000");
            FlowData[3, 1] = Format(O6, "#0.000000");
            FlowData[3, 2] = Format(AT8, "##");



            if (Weir_Input == "Square Center Take-Off Launders")
            {
                W2 = Math.Pow((EfflPeak1 * EfflPeak1) / (128.8 * Y3 * Y3), 0.333);
                for (int i = 4; i > 16; i++)
                {
                    x = i;
                    x = x / 4.0;
                    W3 = W2 * Math.Pow(x * x + (2 / x), 0.5);
                    AT5 = x * W2;
                    AT6 = W3 - AT5;
                    StdWeirData[0, i - 4] = Format(W3, "#0.0000");
                    StdWeirData[1, i - 4] = Format(AT5, "#0.0000");
                    StdWeirData[2, i - 4] = Format(AT6, "#0.0000");
                    //ReDim Preserve StdWeirData(3, UBound(StdWeirData, 2) + 1)
                }
                StdFlowData[0, 0] = Format(EfflMin, "#0.000000");
                StdFlowData[0, 1] = Format(Num8, "#0.000000");
                StdFlowData[0, 2] = Format(O3, "#0.000000");
                StdFlowData[1, 0] = Format(EfflAvg, "#0.000000");
                StdFlowData[1, 1] = Format(Num7, "#0.000000");
                StdFlowData[1, 2] = Format(O1, "#0.000000");
                StdFlowData[2, 0] = Format(EfflMax, "#0.000000");
                StdFlowData[2, 1] = Format(AT3, "#0.000000");
                StdFlowData[2, 2] = Format(AT4, "#0.000000");
                StdFlowData[3, 0] = Format(EfflPeak, "#0.000000");
                StdFlowData[3, 1] = Format(Num9, "#0.000000");
                StdFlowData[3, 2] = Format(O6, "#0.000000");
            }

            if (Dol2 - 1 >= 0)
            {
                Console.WriteLine("Indicates Possible Vortex At Minimum Flow");//MsgBox("Indicates Possible Vortex At Minimum Flow");
            }

            //** Screen Appearance
            //Calc_PB.Visible = False;
            //Prev_PB.Visible = True;
            //Next_PB.Visible = True;
            //Print_PB.Visible = True;

            Output();

            //RF99P2.Show
            if (Weir_Input == "Peripheral")
            {
                //RF99P2A.Hide
            }
            else if (Weir_Input == "Square Center Take-Off Launders")
            {
                //RF99P2A.Show
            }


        }//Calc_Button_Clicked

        public void Output()
        {
            // Prints all the attributes to the screen
            Console.WriteLine("Orifice Reaches");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{OutputData[0,i]}  {OutputData[1, i]}  {OutputData[2, i]}  {OutputData[3, i]}  {OutputData[4, i]}  {OutputData[5, i]}  {OutputData[6, i]}  {OutputData[7, i]}");
            }
        }

        public void VelDataOutput()
        {
            VelocityData[0, 0] = Format(InflMin, "#0.0000");
            VelocityData[0, 1] = Format(P2, "#0.0000");
            VelocityData[0, 2] = Format(P3, "#0.0000");
            VelocityData[0, 3] = Format(O5, "#0.000");
            VelocityData[0, 4] = Format(Y8, "#0.00000");
            VelocityData[0, 5] = Format(J1, "#0.00000");
            VelocityData[1, 0] = Format(InflAvg, "#0.0000");
            VelocityData[1, 1] = Format(N9, "#0.0000");
            VelocityData[1, 2] = Format(P1, "#0.0000");
            VelocityData[1, 3] = Format(HDLS, "#0.000");
            VelocityData[1, 4] = Format(Velocity, "#0.00000");
            VelocityData[2, 0] = Format(InflMax, "#0.0000");
            VelocityData[2, 1] = Format(Dol4, "#0.0000");
            VelocityData[2, 2] = Format(AT2, "#0.0000");
            VelocityData[2, 3] = Format(O4, "#0.000");
            VelocityData[2, 4] = Format(Y7, "#0.00000");
            VelocityData[3, 0] = Format(InflPeak, "#0.0000");
            VelocityData[3, 1] = Format(P5, "#0.0000");
            VelocityData[3, 2] = Format(P6, "#0.0000");
            VelocityData[3, 3] = Format(O7, "#0.000");
            VelocityData[3, 4] = Format(J2, "#0.00000");


        }

        //Used to format a decimal value
        public double Format(double value, string length)
        {
            return value;
        }

    }//Class
}//Namespace



