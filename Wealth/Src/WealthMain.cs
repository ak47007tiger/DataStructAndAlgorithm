using System;
using System.Reflection;
using System.Text;
using System.ComponentModel;
namespace Wealth
{
    public class WealthMain
    {
        public void StartUp()
        {
            var cfg = new WealthConfig()
            {
                mChanYeZhai = 0.1f,
                mXinYongZhai = 0.11f,
                mChunZhai = 0.15f,
                mHuoBi = 0.14f,
                mHS300 = 0.12f,
                mZZ500 = 0.18f,
                mSZHongLi = 0.05f,
                mNASDAQ = 0.05f,
            };
            var sum = cfg.GetTotalPercentage();
            Console.WriteLine(string.Format($"{sum} valid: {WealthConfig.CheckValid(sum)}"));
            var content = new WealthComputer().GetDetailContent(28 * 10000, cfg);
            Console.WriteLine(content);
        }
    }
    public class WealthConfig
    {
        [DisplayNameAttribute("产业债")]
        public float mChanYeZhai;
        [DisplayNameAttribute("信用债")]
        public float mXinYongZhai;
        [DisplayNameAttribute("纯债")]
        public float mChunZhai;
        [DisplayNameAttribute("货币")]
        public float mHuoBi;
        [DisplayNameAttribute("沪深300")]
        public float mHS300;
        [DisplayNameAttribute("中证500")]
        public float mZZ500;
        [DisplayNameAttribute("深证红利")]
        public float mSZHongLi;
        [DisplayNameAttribute("纳斯达克")]
        public float mNASDAQ;

        public static bool CheckValid(float sum)
        {
            return MathF.Abs(sum - 1) < 0.00000000001;
        }

        public float GetTotalPercentage()
        {
            var fieldInfos = GetType().GetFields();
            var nameAttrType = typeof(DisplayNameAttribute);
            var sum = 0f;
            foreach (var fdInfo in fieldInfos)
            {
                var nameAttr = fdInfo.GetCustomAttribute(nameAttrType) as DisplayNameAttribute;
                if (nameAttr != null)
                {
                    var val = (float)fdInfo.GetValue(this);
                    sum += val;
                }
            }
            return sum;
        }
    }

    public class WealthComputer
    {
        public string GetDetailContent(float total, WealthConfig cfg)
        {
            var fieldInfos = cfg.GetType().GetFields();
            var sbd = new StringBuilder();
            var nameAttrType = typeof(DisplayNameAttribute);
            foreach (var fdInfo in fieldInfos)
            {
                var nameAttr = fdInfo.GetCustomAttribute(nameAttrType) as DisplayNameAttribute;
                if (nameAttr != null)
                {
                    var val = (float)fdInfo.GetValue(cfg);
                    sbd.AppendFormat("{0}({1})：{2}\n", nameAttr.DisplayName, val, val * total);
                }
            }
            return sbd.ToString();
        }

    }

}
