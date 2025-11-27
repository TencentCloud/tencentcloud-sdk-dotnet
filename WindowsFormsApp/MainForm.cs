using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async Task<string> GetZonesAsync()
        {
            try
            {
                // 必要步骤：
                // 实例化一个认证对象，入参需要传入腾讯云账户密钥对secretId，secretKey。
                // 这里采用的是从环境变量读取的方式，需要在环境变量中先设置这两个值。
                // 你也可以直接在代码中写死密钥对，但是小心不要将代码复制、上传或者分享给他人，
                // 以免泄露密钥对危及你的财产安全。
                Credential cred = new Credential
                {
                    SecretId = this.secretIdText.Text,
                    SecretKey = this.secretKeyText.Text
                };

                // 实例化一个client选项，可选的，没有特殊需求可以跳过
                ClientProfile clientProfile = new ClientProfile();
                // 非必要步骤
                // 实例化一个客户端配置对象，可以指定超时时间等配置
                HttpProfile httpProfile = new HttpProfile();
                // 代理服务器，当你的环境下有代理服务器时设定
                httpProfile.WebProxy = this.httpProxyText.Text;

                clientProfile.HttpProfile = httpProfile;

                // 实例化要请求产品(以cvm为例)的client对象
                // 第二个参数是地域信息，可以直接填写字符串ap-guangzhou，或者引用预设的常量，clientProfile是可选的
                CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

                // 实例化一个请求对象，根据调用的接口和实际情况，可以进一步设置请求参数
                // 你可以直接查询SDK源码确定DescribeZonesRequest有哪些属性可以设置，
                // 属性可能是基本类型，也可能引用了另一个数据结构。
                // 推荐使用IDE进行开发，可以方便的跳转查阅各个接口和数据结构的文档说明。
                DescribeZonesRequest req = new DescribeZonesRequest();

                // 通过client对象调用DescribeInstances方法发起请求。注意请求方法名与请求对象是对应的
                // 返回的resp是一个DescribeInstancesResponse类的实例，与请求对象对应
                DescribeZonesResponse resp = await client.DescribeZones(req);
                // Thread.Sleep(60000);
                // 输出json格式的字符串回包
                return AbstractModel.ToJsonString(resp);

            } catch (Exception e)
            {
                return e.ToString();
            }
        }

        private string GetZonesSync()
        {
            try
            {
                // 必要步骤：
                // 实例化一个认证对象，入参需要传入腾讯云账户密钥对secretId，secretKey。
                // 这里采用的是从环境变量读取的方式，需要在环境变量中先设置这两个值。
                // 你也可以直接在代码中写死密钥对，但是小心不要将代码复制、上传或者分享给他人，
                // 以免泄露密钥对危及你的财产安全。
                Credential cred = new Credential
                {
                    SecretId = this.secretIdText.Text,
                    SecretKey = this.secretKeyText.Text
                };

                // 实例化一个client选项，可选的，没有特殊需求可以跳过
                ClientProfile clientProfile = new ClientProfile();
                // 非必要步骤
                // 实例化一个客户端配置对象，可以指定超时时间等配置
                HttpProfile httpProfile = new HttpProfile();
                // 代理服务器，当你的环境下有代理服务器时设定
                httpProfile.WebProxy = this.httpProxyText.Text;

                clientProfile.HttpProfile = httpProfile;

                // 实例化要请求产品(以cvm为例)的client对象
                // 第二个参数是地域信息，可以直接填写字符串ap-guangzhou，或者引用预设的常量，clientProfile是可选的
                CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

                // 实例化一个请求对象，根据调用的接口和实际情况，可以进一步设置请求参数
                // 你可以直接查询SDK源码确定DescribeZonesRequest有哪些属性可以设置，
                // 属性可能是基本类型，也可能引用了另一个数据结构。
                // 推荐使用IDE进行开发，可以方便的跳转查阅各个接口和数据结构的文档说明。
                DescribeZonesRequest req = new DescribeZonesRequest();

                // 通过client对象调用DescribeInstances方法发起请求。注意请求方法名与请求对象是对应的
                // 返回的resp是一个DescribeInstancesResponse类的实例，与请求对象对应
                DescribeZonesResponse resp = client.DescribeZonesSync(req);
                // Thread.Sleep(60000);
                // 输出json格式的字符串回包
                return AbstractModel.ToJsonString(resp);

            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        private void getZonesSyncButton_Click(object sender, EventArgs e)
        {
            string result = GetZonesSync();
            getZonesSyncText.Text = result;
        }

        private async void getZonesAsyncButton_Click(object sender, EventArgs e)
        {
            // 进行界面逻辑控制，防止在处理过程中用户进行了不合适的并行操作
            // 此处禁用此Button并不是必须的，只是提供禁止用户进行不合适操作的代码样例
            // 例如：防止用户多次点击，导致进行了多个不期望的修改操作
            this.getZonesAsyncButton.Enabled = false;
            try
            {
                SynchronizationContext uiContext = SynchronizationContext.Current;
                string result = "";
                Task t = Task.Run(() =>
                {
                // 同步方式调用，会卡住直到请求返回
                result = GetZonesAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                });
                await t;
                await uiContext;

                getZonesAsyncText.Text = result;
            }
            finally
            {
                this.getZonesAsyncButton.Enabled = true;
            }
        }
    }
}
