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

namespace TencentCloud.Captcha.V20190722
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Captcha.V20190722.Models;

   public class CaptchaClient : AbstractClient{

       private const string endpoint = "captcha.tencentcloudapi.com";
       private const string version = "2019-07-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CaptchaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CaptchaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查询安全验证码应用APPId信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaAppIdInfoRequest"/></param>
        /// <returns><see cref="DescribeCaptchaAppIdInfoResponse"/></returns>
        public async Task<DescribeCaptchaAppIdInfoResponse> DescribeCaptchaAppIdInfo(DescribeCaptchaAppIdInfoRequest req)
        {
             JsonResponseModel<DescribeCaptchaAppIdInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaAppIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaAppIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全验证码应用APPId信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaAppIdInfoRequest"/></param>
        /// <returns><see cref="DescribeCaptchaAppIdInfoResponse"/></returns>
        public DescribeCaptchaAppIdInfoResponse DescribeCaptchaAppIdInfoSync(DescribeCaptchaAppIdInfoRequest req)
        {
             JsonResponseModel<DescribeCaptchaAppIdInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaAppIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaAppIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码分类查询数据接口，请求量type=0、通过量type=1、验证量type=2、拦截量type=3  分钟级查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaDataResponse"/></returns>
        public async Task<DescribeCaptchaDataResponse> DescribeCaptchaData(DescribeCaptchaDataRequest req)
        {
             JsonResponseModel<DescribeCaptchaDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码分类查询数据接口，请求量type=0、通过量type=1、验证量type=2、拦截量type=3  分钟级查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaDataResponse"/></returns>
        public DescribeCaptchaDataResponse DescribeCaptchaDataSync(DescribeCaptchaDataRequest req)
        {
             JsonResponseModel<DescribeCaptchaDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码查询请求数据概况，例如：按照时间段查询数据  昨日请求量、昨日恶意比例、昨日验证量、昨日通过量、昨日恶意拦截量……
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaDataSumRequest"/></param>
        /// <returns><see cref="DescribeCaptchaDataSumResponse"/></returns>
        public async Task<DescribeCaptchaDataSumResponse> DescribeCaptchaDataSum(DescribeCaptchaDataSumRequest req)
        {
             JsonResponseModel<DescribeCaptchaDataSumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaDataSum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaDataSumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码查询请求数据概况，例如：按照时间段查询数据  昨日请求量、昨日恶意比例、昨日验证量、昨日通过量、昨日恶意拦截量……
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaDataSumRequest"/></param>
        /// <returns><see cref="DescribeCaptchaDataSumResponse"/></returns>
        public DescribeCaptchaDataSumResponse DescribeCaptchaDataSumSync(DescribeCaptchaDataSumRequest req)
        {
             JsonResponseModel<DescribeCaptchaDataSumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaDataSum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaDataSumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码小程序插件分类查询数据接口，请求量type=0、通过量type=1、验证量type=2、拦截量type=3 小时级查询（五小时左右延迟）
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniDataResponse"/></returns>
        public async Task<DescribeCaptchaMiniDataResponse> DescribeCaptchaMiniData(DescribeCaptchaMiniDataRequest req)
        {
             JsonResponseModel<DescribeCaptchaMiniDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaMiniData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaMiniDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码小程序插件分类查询数据接口，请求量type=0、通过量type=1、验证量type=2、拦截量type=3 小时级查询（五小时左右延迟）
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniDataResponse"/></returns>
        public DescribeCaptchaMiniDataResponse DescribeCaptchaMiniDataSync(DescribeCaptchaMiniDataRequest req)
        {
             JsonResponseModel<DescribeCaptchaMiniDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaMiniData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaMiniDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码小程序插件查询请求数据概况
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniDataSumRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniDataSumResponse"/></returns>
        public async Task<DescribeCaptchaMiniDataSumResponse> DescribeCaptchaMiniDataSum(DescribeCaptchaMiniDataSumRequest req)
        {
             JsonResponseModel<DescribeCaptchaMiniDataSumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaMiniDataSum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaMiniDataSumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码小程序插件查询请求数据概况
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniDataSumRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniDataSumResponse"/></returns>
        public DescribeCaptchaMiniDataSumResponse DescribeCaptchaMiniDataSumSync(DescribeCaptchaMiniDataSumRequest req)
        {
             JsonResponseModel<DescribeCaptchaMiniDataSumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaMiniDataSum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaMiniDataSumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码小程序插件用户操作数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniOperDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniOperDataResponse"/></returns>
        public async Task<DescribeCaptchaMiniOperDataResponse> DescribeCaptchaMiniOperData(DescribeCaptchaMiniOperDataRequest req)
        {
             JsonResponseModel<DescribeCaptchaMiniOperDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaMiniOperData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaMiniOperDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码小程序插件用户操作数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniOperDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniOperDataResponse"/></returns>
        public DescribeCaptchaMiniOperDataResponse DescribeCaptchaMiniOperDataSync(DescribeCaptchaMiniOperDataRequest req)
        {
             JsonResponseModel<DescribeCaptchaMiniOperDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaMiniOperData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaMiniOperDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核查验证码票据结果(小程序插件) 
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniResultResponse"/></returns>
        public async Task<DescribeCaptchaMiniResultResponse> DescribeCaptchaMiniResult(DescribeCaptchaMiniResultRequest req)
        {
             JsonResponseModel<DescribeCaptchaMiniResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaMiniResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaMiniResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核查验证码票据结果(小程序插件) 
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniResultResponse"/></returns>
        public DescribeCaptchaMiniResultResponse DescribeCaptchaMiniResultSync(DescribeCaptchaMiniResultRequest req)
        {
             JsonResponseModel<DescribeCaptchaMiniResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaMiniResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaMiniResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核查验证码小程序插件票据接入风控结果(已停用)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniRiskResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniRiskResultResponse"/></returns>
        public async Task<DescribeCaptchaMiniRiskResultResponse> DescribeCaptchaMiniRiskResult(DescribeCaptchaMiniRiskResultRequest req)
        {
             JsonResponseModel<DescribeCaptchaMiniRiskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaMiniRiskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaMiniRiskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核查验证码小程序插件票据接入风控结果(已停用)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniRiskResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniRiskResultResponse"/></returns>
        public DescribeCaptchaMiniRiskResultResponse DescribeCaptchaMiniRiskResultSync(DescribeCaptchaMiniRiskResultRequest req)
        {
             JsonResponseModel<DescribeCaptchaMiniRiskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaMiniRiskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaMiniRiskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码用户操作数据查询，验证码加载耗时type = 1 、拦截情况type = 2、 一周通过平均尝试次数 type = 3、尝试次数分布 type = 4
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaOperDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaOperDataResponse"/></returns>
        public async Task<DescribeCaptchaOperDataResponse> DescribeCaptchaOperData(DescribeCaptchaOperDataRequest req)
        {
             JsonResponseModel<DescribeCaptchaOperDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaOperData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaOperDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码用户操作数据查询，验证码加载耗时type = 1 、拦截情况type = 2、 一周通过平均尝试次数 type = 3、尝试次数分布 type = 4
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaOperDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaOperDataResponse"/></returns>
        public DescribeCaptchaOperDataResponse DescribeCaptchaOperDataSync(DescribeCaptchaOperDataRequest req)
        {
             JsonResponseModel<DescribeCaptchaOperDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaOperData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaOperDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核查验证码票据结果(Web及APP)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaResultResponse"/></returns>
        public async Task<DescribeCaptchaResultResponse> DescribeCaptchaResult(DescribeCaptchaResultRequest req)
        {
             JsonResponseModel<DescribeCaptchaResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核查验证码票据结果(Web及APP)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaResultResponse"/></returns>
        public DescribeCaptchaResultResponse DescribeCaptchaResultSync(DescribeCaptchaResultRequest req)
        {
             JsonResponseModel<DescribeCaptchaResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码用户操作票据数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaTicketDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaTicketDataResponse"/></returns>
        public async Task<DescribeCaptchaTicketDataResponse> DescribeCaptchaTicketData(DescribeCaptchaTicketDataRequest req)
        {
             JsonResponseModel<DescribeCaptchaTicketDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaTicketData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaTicketDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码用户操作票据数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaTicketDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaTicketDataResponse"/></returns>
        public DescribeCaptchaTicketDataResponse DescribeCaptchaTicketDataSync(DescribeCaptchaTicketDataRequest req)
        {
             JsonResponseModel<DescribeCaptchaTicketDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaTicketData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaTicketDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码获取用户注册所有APPId和应用名称
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaUserAllAppIdRequest"/></param>
        /// <returns><see cref="DescribeCaptchaUserAllAppIdResponse"/></returns>
        public async Task<DescribeCaptchaUserAllAppIdResponse> DescribeCaptchaUserAllAppId(DescribeCaptchaUserAllAppIdRequest req)
        {
             JsonResponseModel<DescribeCaptchaUserAllAppIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCaptchaUserAllAppId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaUserAllAppIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全验证码获取用户注册所有APPId和应用名称
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaUserAllAppIdRequest"/></param>
        /// <returns><see cref="DescribeCaptchaUserAllAppIdResponse"/></returns>
        public DescribeCaptchaUserAllAppIdResponse DescribeCaptchaUserAllAppIdSync(DescribeCaptchaUserAllAppIdRequest req)
        {
             JsonResponseModel<DescribeCaptchaUserAllAppIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCaptchaUserAllAppId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCaptchaUserAllAppIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个CaptchaAppID验证的统计数据，包括：请求量、验证量、验证通过量、验证拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetRequestStatisticsRequest"/></param>
        /// <returns><see cref="GetRequestStatisticsResponse"/></returns>
        public async Task<GetRequestStatisticsResponse> GetRequestStatistics(GetRequestStatisticsRequest req)
        {
             JsonResponseModel<GetRequestStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRequestStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRequestStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个CaptchaAppID验证的统计数据，包括：请求量、验证量、验证通过量、验证拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetRequestStatisticsRequest"/></param>
        /// <returns><see cref="GetRequestStatisticsResponse"/></returns>
        public GetRequestStatisticsResponse GetRequestStatisticsSync(GetRequestStatisticsRequest req)
        {
             JsonResponseModel<GetRequestStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRequestStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRequestStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个CaptchaAppID票据校验数据，包括：票据校验量、票据校验通过量、票据校验拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetTicketStatisticsRequest"/></param>
        /// <returns><see cref="GetTicketStatisticsResponse"/></returns>
        public async Task<GetTicketStatisticsResponse> GetTicketStatistics(GetTicketStatisticsRequest req)
        {
             JsonResponseModel<GetTicketStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTicketStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTicketStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个CaptchaAppID票据校验数据，包括：票据校验量、票据校验通过量、票据校验拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetTicketStatisticsRequest"/></param>
        /// <returns><see cref="GetTicketStatisticsResponse"/></returns>
        public GetTicketStatisticsResponse GetTicketStatisticsSync(GetTicketStatisticsRequest req)
        {
             JsonResponseModel<GetTicketStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTicketStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTicketStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询全部验证的统计数据，包括：总请求量、总验证量、总验证通过量、总验证拦截量等数据。
        /// </summary>
        /// <param name="req"><see cref="GetTotalRequestStatisticsRequest"/></param>
        /// <returns><see cref="GetTotalRequestStatisticsResponse"/></returns>
        public async Task<GetTotalRequestStatisticsResponse> GetTotalRequestStatistics(GetTotalRequestStatisticsRequest req)
        {
             JsonResponseModel<GetTotalRequestStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTotalRequestStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTotalRequestStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询全部验证的统计数据，包括：总请求量、总验证量、总验证通过量、总验证拦截量等数据。
        /// </summary>
        /// <param name="req"><see cref="GetTotalRequestStatisticsRequest"/></param>
        /// <returns><see cref="GetTotalRequestStatisticsResponse"/></returns>
        public GetTotalRequestStatisticsResponse GetTotalRequestStatisticsSync(GetTotalRequestStatisticsRequest req)
        {
             JsonResponseModel<GetTotalRequestStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTotalRequestStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTotalRequestStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询全部票据校验的统计数据，包括：总票据校验量、总票据校验通过量、总票据校验拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetTotalTicketStatisticsRequest"/></param>
        /// <returns><see cref="GetTotalTicketStatisticsResponse"/></returns>
        public async Task<GetTotalTicketStatisticsResponse> GetTotalTicketStatistics(GetTotalTicketStatisticsRequest req)
        {
             JsonResponseModel<GetTotalTicketStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTotalTicketStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTotalTicketStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询全部票据校验的统计数据，包括：总票据校验量、总票据校验通过量、总票据校验拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetTotalTicketStatisticsRequest"/></param>
        /// <returns><see cref="GetTotalTicketStatisticsResponse"/></returns>
        public GetTotalTicketStatisticsResponse GetTotalTicketStatisticsSync(GetTotalTicketStatisticsRequest req)
        {
             JsonResponseModel<GetTotalTicketStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTotalTicketStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTotalTicketStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新验证码应用APPId信息
        /// </summary>
        /// <param name="req"><see cref="UpdateCaptchaAppIdInfoRequest"/></param>
        /// <returns><see cref="UpdateCaptchaAppIdInfoResponse"/></returns>
        public async Task<UpdateCaptchaAppIdInfoResponse> UpdateCaptchaAppIdInfo(UpdateCaptchaAppIdInfoRequest req)
        {
             JsonResponseModel<UpdateCaptchaAppIdInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCaptchaAppIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCaptchaAppIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新验证码应用APPId信息
        /// </summary>
        /// <param name="req"><see cref="UpdateCaptchaAppIdInfoRequest"/></param>
        /// <returns><see cref="UpdateCaptchaAppIdInfoResponse"/></returns>
        public UpdateCaptchaAppIdInfoResponse UpdateCaptchaAppIdInfoSync(UpdateCaptchaAppIdInfoRequest req)
        {
             JsonResponseModel<UpdateCaptchaAppIdInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCaptchaAppIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCaptchaAppIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
