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

namespace TencentCloud.Sms.V20210111
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sms.V20210111.Models;

   public class SmsClient : AbstractClient{

       private const string endpoint = "sms.tencentcloudapi.com";
       private const string version = "2021-01-11";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 1. 添加短信签名，申请之前请先认真参阅 [腾讯云短信签名审核标准](https://cloud.tencent.com/document/product/382/39022)。
        /// 2. ⚠️注意：个人认证用户不支持使用 API 申请短信签名，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)，如果为个人认证请登录控制台申请短信签名。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="AddSmsSignRequest"/></param>
        /// <returns><see cref="AddSmsSignResponse"/></returns>
        public async Task<AddSmsSignResponse> AddSmsSign(AddSmsSignRequest req)
        {
             JsonResponseModel<AddSmsSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddSmsSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSmsSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 添加短信签名，申请之前请先认真参阅 [腾讯云短信签名审核标准](https://cloud.tencent.com/document/product/382/39022)。
        /// 2. ⚠️注意：个人认证用户不支持使用 API 申请短信签名，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)，如果为个人认证请登录控制台申请短信签名。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="AddSmsSignRequest"/></param>
        /// <returns><see cref="AddSmsSignResponse"/></returns>
        public AddSmsSignResponse AddSmsSignSync(AddSmsSignRequest req)
        {
             JsonResponseModel<AddSmsSignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddSmsSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSmsSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 添加短信模板，申请之前请先认真参阅 [腾讯云短信正文模板审核标准](https://cloud.tencent.com/document/product/382/39023)。
        /// 2. ⚠️注意：个人认证用户不支持使用 API 申请短信正文模板，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)，如果为个人认证请登录 [控制台](https://console.cloud.tencent.com/smsv2) 申请短信正文模板。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="AddSmsTemplateRequest"/></param>
        /// <returns><see cref="AddSmsTemplateResponse"/></returns>
        public async Task<AddSmsTemplateResponse> AddSmsTemplate(AddSmsTemplateRequest req)
        {
             JsonResponseModel<AddSmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddSmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 添加短信模板，申请之前请先认真参阅 [腾讯云短信正文模板审核标准](https://cloud.tencent.com/document/product/382/39023)。
        /// 2. ⚠️注意：个人认证用户不支持使用 API 申请短信正文模板，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)，如果为个人认证请登录 [控制台](https://console.cloud.tencent.com/smsv2) 申请短信正文模板。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="AddSmsTemplateRequest"/></param>
        /// <returns><see cref="AddSmsTemplateResponse"/></returns>
        public AddSmsTemplateResponse AddSmsTemplateSync(AddSmsTemplateRequest req)
        {
             JsonResponseModel<AddSmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddSmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计用户回执的数据。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="CallbackStatusStatisticsRequest"/></param>
        /// <returns><see cref="CallbackStatusStatisticsResponse"/></returns>
        public async Task<CallbackStatusStatisticsResponse> CallbackStatusStatistics(CallbackStatusStatisticsRequest req)
        {
             JsonResponseModel<CallbackStatusStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CallbackStatusStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallbackStatusStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计用户回执的数据。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="CallbackStatusStatisticsRequest"/></param>
        /// <returns><see cref="CallbackStatusStatisticsResponse"/></returns>
        public CallbackStatusStatisticsResponse CallbackStatusStatisticsSync(CallbackStatusStatisticsRequest req)
        {
             JsonResponseModel<CallbackStatusStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CallbackStatusStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallbackStatusStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ⚠️注意：个人认证用户不支持使用 API 删除短信签名，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)，请登录 [控制台](https://console.cloud.tencent.com/smsv2) 删除短信签名。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsSignRequest"/></param>
        /// <returns><see cref="DeleteSmsSignResponse"/></returns>
        public async Task<DeleteSmsSignResponse> DeleteSmsSign(DeleteSmsSignRequest req)
        {
             JsonResponseModel<DeleteSmsSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSmsSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSmsSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ⚠️注意：个人认证用户不支持使用 API 删除短信签名，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)，请登录 [控制台](https://console.cloud.tencent.com/smsv2) 删除短信签名。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsSignRequest"/></param>
        /// <returns><see cref="DeleteSmsSignResponse"/></returns>
        public DeleteSmsSignResponse DeleteSmsSignSync(DeleteSmsSignRequest req)
        {
             JsonResponseModel<DeleteSmsSignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSmsSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSmsSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ⚠️注意：个人认证用户不支持使用 API 删除短信正文模板，请登录 [控制台](https://console.cloud.tencent.com/smsv2) 删除短信正文模板，如需了解请参阅 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsTemplateRequest"/></param>
        /// <returns><see cref="DeleteSmsTemplateResponse"/></returns>
        public async Task<DeleteSmsTemplateResponse> DeleteSmsTemplate(DeleteSmsTemplateRequest req)
        {
             JsonResponseModel<DeleteSmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ⚠️注意：个人认证用户不支持使用 API 删除短信正文模板，请登录 [控制台](https://console.cloud.tencent.com/smsv2) 删除短信正文模板，如需了解请参阅 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsTemplateRequest"/></param>
        /// <returns><see cref="DeleteSmsTemplateResponse"/></returns>
        public DeleteSmsTemplateResponse DeleteSmsTemplateSync(DeleteSmsTemplateRequest req)
        {
             JsonResponseModel<DeleteSmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供电话号码的信息查询，包括国家（或地区）码、规范的 E.164 格式号码等。
        /// >- 例如：查询号码 +86018845720123，可以得到国家码 86、规范的 E.164 号码 +8618845720123 等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePhoneNumberInfoRequest"/></param>
        /// <returns><see cref="DescribePhoneNumberInfoResponse"/></returns>
        public async Task<DescribePhoneNumberInfoResponse> DescribePhoneNumberInfo(DescribePhoneNumberInfoRequest req)
        {
             JsonResponseModel<DescribePhoneNumberInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePhoneNumberInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePhoneNumberInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供电话号码的信息查询，包括国家（或地区）码、规范的 E.164 格式号码等。
        /// >- 例如：查询号码 +86018845720123，可以得到国家码 86、规范的 E.164 号码 +8618845720123 等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePhoneNumberInfoRequest"/></param>
        /// <returns><see cref="DescribePhoneNumberInfoResponse"/></returns>
        public DescribePhoneNumberInfoResponse DescribePhoneNumberInfoSync(DescribePhoneNumberInfoRequest req)
        {
             JsonResponseModel<DescribePhoneNumberInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePhoneNumberInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePhoneNumberInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ⚠️注意：个人认证用户不支持使用 API 查询短信签名，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629),如果为个人认证请登录 [控制台](https://console.cloud.tencent.com/smsv2) 查询短信签名。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsSignListRequest"/></param>
        /// <returns><see cref="DescribeSmsSignListResponse"/></returns>
        public async Task<DescribeSmsSignListResponse> DescribeSmsSignList(DescribeSmsSignListRequest req)
        {
             JsonResponseModel<DescribeSmsSignListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmsSignList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsSignListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ⚠️注意：个人认证用户不支持使用 API 查询短信签名，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629),如果为个人认证请登录 [控制台](https://console.cloud.tencent.com/smsv2) 查询短信签名。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsSignListRequest"/></param>
        /// <returns><see cref="DescribeSmsSignListResponse"/></returns>
        public DescribeSmsSignListResponse DescribeSmsSignListSync(DescribeSmsSignListRequest req)
        {
             JsonResponseModel<DescribeSmsSignListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSmsSignList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsSignListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ⚠️注意：个人认证用户不支持使用 API 查询短信正文模板，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeSmsTemplateListResponse"/></returns>
        public async Task<DescribeSmsTemplateListResponse> DescribeSmsTemplateList(DescribeSmsTemplateListRequest req)
        {
             JsonResponseModel<DescribeSmsTemplateListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmsTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ⚠️注意：个人认证用户不支持使用 API 查询短信正文模板，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeSmsTemplateListResponse"/></returns>
        public DescribeSmsTemplateListResponse DescribeSmsTemplateListSync(DescribeSmsTemplateListRequest req)
        {
             JsonResponseModel<DescribeSmsTemplateListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSmsTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 修改短信签名，修改之前请先认真参阅 [腾讯云短信签名审核标准](https://cloud.tencent.com/document/product/382/39022)。
        /// 2. ⚠️注意：个人认证用户不支持使用 API 修改短信签名，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)，如果为个人认证请登录 [控制台](https://console.cloud.tencent.com/smsv2) 修改短信签名。
        /// 3. 修改短信签名，仅当签名为**待审核**或**已拒绝**状态时，才能进行修改，**已审核通过**的签名不支持修改。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="ModifySmsSignRequest"/></param>
        /// <returns><see cref="ModifySmsSignResponse"/></returns>
        public async Task<ModifySmsSignResponse> ModifySmsSign(ModifySmsSignRequest req)
        {
             JsonResponseModel<ModifySmsSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySmsSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySmsSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 修改短信签名，修改之前请先认真参阅 [腾讯云短信签名审核标准](https://cloud.tencent.com/document/product/382/39022)。
        /// 2. ⚠️注意：个人认证用户不支持使用 API 修改短信签名，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)，如果为个人认证请登录 [控制台](https://console.cloud.tencent.com/smsv2) 修改短信签名。
        /// 3. 修改短信签名，仅当签名为**待审核**或**已拒绝**状态时，才能进行修改，**已审核通过**的签名不支持修改。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="ModifySmsSignRequest"/></param>
        /// <returns><see cref="ModifySmsSignResponse"/></returns>
        public ModifySmsSignResponse ModifySmsSignSync(ModifySmsSignRequest req)
        {
             JsonResponseModel<ModifySmsSignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySmsSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySmsSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 修改短信正文模板，修改之前请先认真参阅 [腾讯云短信正文模板审核标准](https://cloud.tencent.com/document/product/382/39023)。
        /// 2. ⚠️注意：个人认证用户不支持使用 API 修改短信正文模板，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)，如果为个人认证请登录 [控制台](https://console.cloud.tencent.com/smsv2) 修改短信正文模板。
        /// 3. 修改短信模板，仅当正文模板为**待审核**或**已拒绝**状态时，才能进行修改，**已审核通过**的正文模板不支持修改。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2019-07-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="ModifySmsTemplateRequest"/></param>
        /// <returns><see cref="ModifySmsTemplateResponse"/></returns>
        public async Task<ModifySmsTemplateResponse> ModifySmsTemplate(ModifySmsTemplateRequest req)
        {
             JsonResponseModel<ModifySmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 修改短信正文模板，修改之前请先认真参阅 [腾讯云短信正文模板审核标准](https://cloud.tencent.com/document/product/382/39023)。
        /// 2. ⚠️注意：个人认证用户不支持使用 API 修改短信正文模板，请参阅了解 [实名认证基本介绍](https://cloud.tencent.com/document/product/378/3629)，如果为个人认证请登录 [控制台](https://console.cloud.tencent.com/smsv2) 修改短信正文模板。
        /// 3. 修改短信模板，仅当正文模板为**待审核**或**已拒绝**状态时，才能进行修改，**已审核通过**的正文模板不支持修改。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2019-07-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="ModifySmsTemplateRequest"/></param>
        /// <returns><see cref="ModifySmsTemplateResponse"/></returns>
        public ModifySmsTemplateResponse ModifySmsTemplateSync(ModifySmsTemplateRequest req)
        {
             JsonResponseModel<ModifySmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取短信回复状态。
        /// 目前也支持 [配置回复回调](https://cloud.tencent.com/document/product/382/42907) 的方式来获取上行回复。
        /// >- 注：此接口需要联系 [腾讯云短信小助手](https://cloud.tencent.com/document/product/382/3773#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81) 开通。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusResponse"/></returns>
        public async Task<PullSmsReplyStatusResponse> PullSmsReplyStatus(PullSmsReplyStatusRequest req)
        {
             JsonResponseModel<PullSmsReplyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsReplyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsReplyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取短信回复状态。
        /// 目前也支持 [配置回复回调](https://cloud.tencent.com/document/product/382/42907) 的方式来获取上行回复。
        /// >- 注：此接口需要联系 [腾讯云短信小助手](https://cloud.tencent.com/document/product/382/3773#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81) 开通。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusResponse"/></returns>
        public PullSmsReplyStatusResponse PullSmsReplyStatusSync(PullSmsReplyStatusRequest req)
        {
             JsonResponseModel<PullSmsReplyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PullSmsReplyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsReplyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取单个号码短信回复状态。
        /// 目前也支持 [配置回复回调](https://cloud.tencent.com/document/product/382/42907) 的方式来获取上行回复。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusByPhoneNumberResponse"/></returns>
        public async Task<PullSmsReplyStatusByPhoneNumberResponse> PullSmsReplyStatusByPhoneNumber(PullSmsReplyStatusByPhoneNumberRequest req)
        {
             JsonResponseModel<PullSmsReplyStatusByPhoneNumberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsReplyStatusByPhoneNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsReplyStatusByPhoneNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取单个号码短信回复状态。
        /// 目前也支持 [配置回复回调](https://cloud.tencent.com/document/product/382/42907) 的方式来获取上行回复。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusByPhoneNumberResponse"/></returns>
        public PullSmsReplyStatusByPhoneNumberResponse PullSmsReplyStatusByPhoneNumberSync(PullSmsReplyStatusByPhoneNumberRequest req)
        {
             JsonResponseModel<PullSmsReplyStatusByPhoneNumberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PullSmsReplyStatusByPhoneNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsReplyStatusByPhoneNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取短信下发状态。
        /// 目前也支持 [配置回调](https://cloud.tencent.com/document/product/382/37809#.E8.AE.BE.E7.BD.AE.E4.BA.8B.E4.BB.B6.E5.9B.9E.E8.B0.83.E9.85.8D.E7.BD.AE) 的方式来获取下发状态。
        /// >- 注：此接口需要联系 [腾讯云短信小助手](https://cloud.tencent.com/document/product/382/3773#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81) 开通。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusResponse"/></returns>
        public async Task<PullSmsSendStatusResponse> PullSmsSendStatus(PullSmsSendStatusRequest req)
        {
             JsonResponseModel<PullSmsSendStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsSendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsSendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取短信下发状态。
        /// 目前也支持 [配置回调](https://cloud.tencent.com/document/product/382/37809#.E8.AE.BE.E7.BD.AE.E4.BA.8B.E4.BB.B6.E5.9B.9E.E8.B0.83.E9.85.8D.E7.BD.AE) 的方式来获取下发状态。
        /// >- 注：此接口需要联系 [腾讯云短信小助手](https://cloud.tencent.com/document/product/382/3773#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81) 开通。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusResponse"/></returns>
        public PullSmsSendStatusResponse PullSmsSendStatusSync(PullSmsSendStatusRequest req)
        {
             JsonResponseModel<PullSmsSendStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PullSmsSendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsSendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取单个号码短信下发状态。
        /// 目前也支持 [配置回调](https://cloud.tencent.com/document/product/382/37809#.E8.AE.BE.E7.BD.AE.E4.BA.8B.E4.BB.B6.E5.9B.9E.E8.B0.83.E9.85.8D.E7.BD.AE) 的方式来获取下发状态。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusByPhoneNumberResponse"/></returns>
        public async Task<PullSmsSendStatusByPhoneNumberResponse> PullSmsSendStatusByPhoneNumber(PullSmsSendStatusByPhoneNumberRequest req)
        {
             JsonResponseModel<PullSmsSendStatusByPhoneNumberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsSendStatusByPhoneNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsSendStatusByPhoneNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取单个号码短信下发状态。
        /// 目前也支持 [配置回调](https://cloud.tencent.com/document/product/382/37809#.E8.AE.BE.E7.BD.AE.E4.BA.8B.E4.BB.B6.E5.9B.9E.E8.B0.83.E9.85.8D.E7.BD.AE) 的方式来获取下发状态。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusByPhoneNumberResponse"/></returns>
        public PullSmsSendStatusByPhoneNumberResponse PullSmsSendStatusByPhoneNumberSync(PullSmsSendStatusByPhoneNumberRequest req)
        {
             JsonResponseModel<PullSmsSendStatusByPhoneNumberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PullSmsSendStatusByPhoneNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsSendStatusByPhoneNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 短信转化率上报。将已接收到短信的流水号上报到腾讯云短信服务。
        /// >- 注：当前接口以白名单方式对外开放，如有需要请联系 [腾讯云短信小助手](https://cloud.tencent.com/document/product/382/3773#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81) 开通。
        /// </summary>
        /// <param name="req"><see cref="ReportConversionRequest"/></param>
        /// <returns><see cref="ReportConversionResponse"/></returns>
        public async Task<ReportConversionResponse> ReportConversion(ReportConversionRequest req)
        {
             JsonResponseModel<ReportConversionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReportConversion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportConversionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 短信转化率上报。将已接收到短信的流水号上报到腾讯云短信服务。
        /// >- 注：当前接口以白名单方式对外开放，如有需要请联系 [腾讯云短信小助手](https://cloud.tencent.com/document/product/382/3773#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81) 开通。
        /// </summary>
        /// <param name="req"><see cref="ReportConversionRequest"/></param>
        /// <returns><see cref="ReportConversionResponse"/></returns>
        public ReportConversionResponse ReportConversionSync(ReportConversionRequest req)
        {
             JsonResponseModel<ReportConversionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReportConversion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportConversionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 短信发送接口，用于给用户发短信验证码、通知类短信或营销短信。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 [SDK](https://cloud.tencent.com/document/product/382/43193) 来使用云短信服务。
        /// >- 注：您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// >- 注：当前接口属于 2021-01-11 版本，如果您仍在使用 [2019-07-11 版本](https://cloud.tencent.com/document/product/382/38778)，建议您使用当前最新版本的接口，版本差异可参考[版本描述](https://cloud.tencent.com/document/product/382/63195#.E7.89.88.E6.9C.AC.E6.8F.8F.E8.BF.B0)。
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public async Task<SendSmsResponse> SendSms(SendSmsRequest req)
        {
             JsonResponseModel<SendSmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 短信发送接口，用于给用户发短信验证码、通知类短信或营销短信。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 [SDK](https://cloud.tencent.com/document/product/382/43193) 来使用云短信服务。
        /// >- 注：您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// >- 注：当前接口属于 2021-01-11 版本，如果您仍在使用 [2019-07-11 版本](https://cloud.tencent.com/document/product/382/38778)，建议您使用当前最新版本的接口，版本差异可参考[版本描述](https://cloud.tencent.com/document/product/382/63195#.E7.89.88.E6.9C.AC.E6.8F.8F.E8.BF.B0)。
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public SendSmsResponse SendSmsSync(SendSmsRequest req)
        {
             JsonResponseModel<SendSmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计用户发送短信的数据。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="SendStatusStatisticsRequest"/></param>
        /// <returns><see cref="SendStatusStatisticsResponse"/></returns>
        public async Task<SendStatusStatisticsResponse> SendStatusStatistics(SendStatusStatisticsRequest req)
        {
             JsonResponseModel<SendStatusStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendStatusStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendStatusStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计用户发送短信的数据。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="SendStatusStatisticsRequest"/></param>
        /// <returns><see cref="SendStatusStatisticsResponse"/></returns>
        public SendStatusStatisticsResponse SendStatusStatisticsSync(SendStatusStatisticsRequest req)
        {
             JsonResponseModel<SendStatusStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendStatusStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendStatusStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户套餐包信息统计。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="SmsPackagesStatisticsRequest"/></param>
        /// <returns><see cref="SmsPackagesStatisticsResponse"/></returns>
        public async Task<SmsPackagesStatisticsResponse> SmsPackagesStatistics(SmsPackagesStatisticsRequest req)
        {
             JsonResponseModel<SmsPackagesStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SmsPackagesStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SmsPackagesStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户套餐包信息统计。
        /// >- 注：由于云 **API3.0 安全性**有所提升，所以**接口鉴权**较为复杂，建议使用 SDK 来使用云短信服务。
        /// >- 您可以在 [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) 中直接运行该接口，可以先免去签名计算步骤。运行成功后，API Explorer可以**自动生成**SDK代码示例。
        /// </summary>
        /// <param name="req"><see cref="SmsPackagesStatisticsRequest"/></param>
        /// <returns><see cref="SmsPackagesStatisticsResponse"/></returns>
        public SmsPackagesStatisticsResponse SmsPackagesStatisticsSync(SmsPackagesStatisticsRequest req)
        {
             JsonResponseModel<SmsPackagesStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SmsPackagesStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SmsPackagesStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
