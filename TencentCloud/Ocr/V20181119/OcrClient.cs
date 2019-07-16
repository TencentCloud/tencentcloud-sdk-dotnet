/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ocr.V20181119
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ocr.V20181119.Models;

   public class OcrClient : AbstractClient{

       private const string endpoint = "ocr.tencentcloudapi.com";
       private const string version = "2018-11-19";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public OcrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public OcrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口支持作业算式题目的自动识别，目前覆盖 K12 学力范围内的 14 种题型，包括加减乘除四则运算、分数四则运算、竖式四则运算、脱式计算等。
        /// </summary>
        /// <param name="req">参考<see cref="ArithmeticOCRRequest"/></param>
        /// <returns>参考<see cref="ArithmeticOCRResponse"/>实例</returns>
        public async Task<ArithmeticOCRResponse> ArithmeticOCR(ArithmeticOCRRequest req)
        {
             JsonResponseModel<ArithmeticOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ArithmeticOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ArithmeticOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对中国大陆主流银行卡的卡号、银行信息、有效期等关键字段的检测与识别。
        /// </summary>
        /// <param name="req">参考<see cref="BankCardOCRRequest"/></param>
        /// <returns>参考<see cref="BankCardOCRResponse"/>实例</returns>
        public async Task<BankCardOCRResponse> BankCardOCR(BankCardOCRRequest req)
        {
             JsonResponseModel<BankCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BankCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持快速精准识别营业执照上的字段，包括注册号、公司名称、经营场所、主体类型、法定代表人、注册资金、组成形式、成立日期、营业期限和经营范围等字段。
        /// </summary>
        /// <param name="req">参考<see cref="BizLicenseOCRRequest"/></param>
        /// <returns>参考<see cref="BizLicenseOCRResponse"/>实例</returns>
        public async Task<BizLicenseOCRResponse> BizLicenseOCR(BizLicenseOCRRequest req)
        {
             JsonResponseModel<BizLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BizLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BizLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持名片各字段的自动定位与识别，包含姓名、电话、手机号、邮箱、公司、部门、职位、网址、地址、QQ、微信、MSN等。
        /// </summary>
        /// <param name="req">参考<see cref="BusinessCardOCRRequest"/></param>
        /// <returns>参考<see cref="BusinessCardOCRResponse"/>实例</returns>
        public async Task<BusinessCardOCRResponse> BusinessCardOCR(BusinessCardOCRRequest req)
        {
             JsonResponseModel<BusinessCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BusinessCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BusinessCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对驾驶证主页所有字段的自动定位与识别，包含证号、姓名、性别、国籍、住址、出生日期、初次领证日期、准驾车型、有效期限等。
        /// </summary>
        /// <param name="req">参考<see cref="DriverLicenseOCRRequest"/></param>
        /// <returns>参考<see cref="DriverLicenseOCRResponse"/>实例</returns>
        public async Task<DriverLicenseOCRResponse> DriverLicenseOCR(DriverLicenseOCRRequest req)
        {
             JsonResponseModel<DriverLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DriverLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DriverLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图像英文文字的检测和识别，返回文字框位置与文字内容。支持多场景、任意版面下的英文、字母、数字和常见字符的识别，同时覆盖英文印刷体和英文手写体识别。
        /// </summary>
        /// <param name="req">参考<see cref="EnglishOCRRequest"/></param>
        /// <returns>参考<see cref="EnglishOCRResponse"/>实例</returns>
        public async Task<EnglishOCRResponse> EnglishOCR(EnglishOCRRequest req)
        {
             JsonResponseModel<EnglishOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnglishOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnglishOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图像整体文字的检测和识别，返回文字框位置与文字内容。相比通用印刷体识别接口，准确率和召回率更高。
        /// </summary>
        /// <param name="req">参考<see cref="GeneralAccurateOCRRequest"/></param>
        /// <returns>参考<see cref="GeneralAccurateOCRResponse"/>实例</returns>
        public async Task<GeneralAccurateOCRResponse> GeneralAccurateOCR(GeneralAccurateOCRRequest req)
        {
             JsonResponseModel<GeneralAccurateOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GeneralAccurateOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralAccurateOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持多场景、任意版面下整图文字的识别。支持自动识别语言类型，同时支持自选语言种类（推荐），除中英文外，支持日语、韩语、西班牙语、法语、德语、葡萄牙语、越南语、马来语、俄语、意大利语、荷兰语、瑞典语、芬兰语、丹麦语、挪威语、匈牙利语、泰语等多种语言。应用场景包括：印刷文档识别、网络图片识别、广告图文字识别、街景店招识别、菜单识别、视频标题识别、头像文字识别等。
        /// </summary>
        /// <param name="req">参考<see cref="GeneralBasicOCRRequest"/></param>
        /// <returns>参考<see cref="GeneralBasicOCRResponse"/>实例</returns>
        public async Task<GeneralBasicOCRResponse> GeneralBasicOCR(GeneralBasicOCRRequest req)
        {
             JsonResponseModel<GeneralBasicOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GeneralBasicOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralBasicOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图片中整体文字的检测和识别，返回文字框位置与文字内容。相比通用印刷体识别接口，识别速度更快、支持的 QPS 更高。
        /// </summary>
        /// <param name="req">参考<see cref="GeneralFastOCRRequest"/></param>
        /// <returns>参考<see cref="GeneralFastOCRResponse"/>实例</returns>
        public async Task<GeneralFastOCRResponse> GeneralFastOCR(GeneralFastOCRRequest req)
        {
             JsonResponseModel<GeneralFastOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GeneralFastOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralFastOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图片内手写体文字的检测和识别，针对手写字体无规则、字迹潦草、模糊等特点进行了识别能力的增强。
        /// </summary>
        /// <param name="req">参考<see cref="GeneralHandwritingOCRRequest"/></param>
        /// <returns>参考<see cref="GeneralHandwritingOCRResponse"/>实例</returns>
        public async Task<GeneralHandwritingOCRResponse> GeneralHandwritingOCR(GeneralHandwritingOCRRequest req)
        {
             JsonResponseModel<GeneralHandwritingOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GeneralHandwritingOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralHandwritingOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持二代身份证正反面所有字段的识别，包括姓名、性别、民族、出生日期、住址、公民身份证号、签发机关、有效期限；具备身份证照片、人像照片的裁剪功能和翻拍件、复印件的识别告警功能。
        /// </summary>
        /// <param name="req">参考<see cref="IDCardOCRRequest"/></param>
        /// <returns>参考<see cref="IDCardOCRResponse"/>实例</returns>
        public async Task<IDCardOCRResponse> IDCardOCR(IDCardOCRRequest req)
        {
             JsonResponseModel<IDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持对中国大陆机动车车牌的自动定位和识别，返回地域编号和车牌号信息。
        /// </summary>
        /// <param name="req">参考<see cref="LicensePlateOCRRequest"/></param>
        /// <returns>参考<see cref="LicensePlateOCRResponse"/>实例</returns>
        public async Task<LicensePlateOCRResponse> LicensePlateOCR(LicensePlateOCRRequest req)
        {
             JsonResponseModel<LicensePlateOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LicensePlateOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LicensePlateOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图片内表格文档的检测和识别，返回每个单元格的文字内容，支持将识别结果保存为 Excel 格式。
        /// </summary>
        /// <param name="req">参考<see cref="TableOCRRequest"/></param>
        /// <returns>参考<see cref="TableOCRResponse"/>实例</returns>
        public async Task<TableOCRResponse> TableOCR(TableOCRRequest req)
        {
             JsonResponseModel<TableOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TableOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TableOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持增值税专用发票、增值税普通发票、增值税电子发票全字段的内容检测和识别，包括发票代码、发票号码、开票日期、合计金额、校验码、税率、合计税额、价税合计、购买方识别号、复核、销售方识别号、开票人、密码区1、密码区2、密码区3、密码区4、发票名称、购买方名称、销售方名称、服务名称、备注、规格型号、数量、单价、金额、税额、收款人等字段。
        /// </summary>
        /// <param name="req">参考<see cref="VatInvoiceOCRRequest"/></param>
        /// <returns>参考<see cref="VatInvoiceOCRResponse"/>实例</returns>
        public async Task<VatInvoiceOCRResponse> VatInvoiceOCR(VatInvoiceOCRRequest req)
        {
             JsonResponseModel<VatInvoiceOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VatInvoiceOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VatInvoiceOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持行驶证主页和副页所有字段的自动定位与识别，包含车牌号码、车辆类型、所有人、住址、使用性质、品牌型号、车辆识别代码、发动机号、注册日期、发证日期等。
        /// </summary>
        /// <param name="req">参考<see cref="VehicleLicenseOCRRequest"/></param>
        /// <returns>参考<see cref="VehicleLicenseOCRResponse"/>实例</returns>
        public async Task<VehicleLicenseOCRResponse> VehicleLicenseOCR(VehicleLicenseOCRRequest req)
        {
             JsonResponseModel<VehicleLicenseOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VehicleLicenseOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VehicleLicenseOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持图片内车辆识别代号（VIN）的检测和识别。
        /// </summary>
        /// <param name="req">参考<see cref="VinOCRRequest"/></param>
        /// <returns>参考<see cref="VinOCRResponse"/>实例</returns>
        public async Task<VinOCRResponse> VinOCR(VinOCRRequest req)
        {
             JsonResponseModel<VinOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VinOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VinOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口支持市面上主流版式电子运单的识别，包括收件人和寄件人的姓名、电话、地址以及运单号等字段。
        /// </summary>
        /// <param name="req">参考<see cref="WaybillOCRRequest"/></param>
        /// <returns>参考<see cref="WaybillOCRResponse"/>实例</returns>
        public async Task<WaybillOCRResponse> WaybillOCR(WaybillOCRRequest req)
        {
             JsonResponseModel<WaybillOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "WaybillOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WaybillOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
