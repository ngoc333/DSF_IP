using System;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;


namespace IP
{
	/// <summary>
	/// ComVar�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ComVar 
	{
		public ComVar()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}
        public static string Form_Type = "1";

        public static FORM_IP_DEFFECTIVE_STATUS_YEAR DEFECTIVE_YEAR = new FORM_IP_DEFFECTIVE_STATUS_YEAR();

        public static FORM_IP_DEFFECTIVE_STATUS DEFECTIVE = new FORM_IP_DEFFECTIVE_STATUS();

        public static FRM_SMT_IP_OEE IP_OEE = new FRM_SMT_IP_OEE();

        public static FRM_SMT_IP_OEE_YEAR IP_OEE_YEAR = new FRM_SMT_IP_OEE_YEAR();

       
        //public static string This_Action;
        //public static string This_Win_ID;
        //public static string This_PGM = "MOLD";
        //public static string This_Packages;
        //public static string This_REF1 = "";
        //public static string This_REF2 = "";
        //public static string This_REF3 = "";
        ////public static string This_User = "admin";
        //// ������
        //public const string Insert = "I";
        //public const string Update = "U";
        //public const string Delete = "D";
	}
}
