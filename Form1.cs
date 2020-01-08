using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Configuration;
using System.IO;
//using System.Security.Cryptography;
//using HsIOCommon;
//using HsIOCommon.Log;

namespace EC_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
       

        //企业信息接口调用按钮
        private void buttonSkuPluEx_Click(object sender, EventArgs e)
        {
            try
            {
                //初始化参数
                HSIOEC_EtpEnterpriseSoapClient sClient = new HSIOEC_EtpEnterpriseSoapClient("HSIOEC_EtpEnterpriseSoap");

                //调用接口
                string Rtn = sClient.GetEnterprise(textBox1.Text);

                //展示返回值和返回信息
                textBox2.Text = Rtn;  
            }
            catch (Exception E)
            {
                //展示错误信息
                textBox2.Text = E.Message.ToString();
            }
        }


        //商品档案接口调用按钮
        private void buttonSkuPlu_Click(object sender, EventArgs e)
        {
            try
            {
                //初始化参数
                HSIOEC_SkuPluSoapClient sClient = new HSIOEC_SkuPluSoapClient("HSIOEC_SkuPluSoap");

                //调用接口
                string Rtn = sClient.GetSkuPlu(textBox1.Text);

                //展示返回值和返回信息
                textBox2.Text = Rtn;
            }
            catch (Exception E)
            {
                //展示错误信息
                textBox2.Text = E.Message.ToString();
            }
        }


        //商品辅助属性接口调用按钮
        private void buttonEtp_Click(object sender, EventArgs e)
        {
            try
            {
                //初始化参数
                HSIOEC_SkuPluExSoapClient sClient = new HSIOEC_SkuPluExSoapClient("HSIOEC_SkuPluExSoap");

                //调用接口
                string Rtn = sClient.GetSkuPluEx(textBox1.Text);

                //展示返回值和返回信息
                textBox2.Text = Rtn;
            }
            catch (Exception E)
            {
                //展示错误信息
                textBox2.Text = E.Message.ToString();
            }
        }
    }
}
