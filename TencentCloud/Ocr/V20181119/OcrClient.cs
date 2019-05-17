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
        /// 本接口支持多场景、任意版面下整图文字的识别，包括中英文、字母、数字和日文、韩文的识别。应用场景包括：印刷文档识别、网络图片识别、广告图文字识别、街景店招识别、菜单识别、视频标题识别、头像文字识别等。
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
