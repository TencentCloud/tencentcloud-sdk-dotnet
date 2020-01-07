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
        /// DescribeCaptchaAppIdInfo接口的同步版本，查询安全验证码应用APPId信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCaptchaAppIdInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeCaptchaAppIdInfoResponse"/>实例</returns>
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
        /// 安全验证码分类查询数据接口，请求量type=0、验证量type=1、通过量type=2、拦截量type=3  分钟级查询
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
        /// DescribeCaptchaData接口的同步版本，安全验证码分类查询数据接口，请求量type=0、验证量type=1、通过量type=2、拦截量type=3  分钟级查询
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCaptchaDataRequest"/></param>
        /// <returns>参考<see cref="DescribeCaptchaDataResponse"/>实例</returns>
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
        /// DescribeCaptchaDataSum接口的同步版本，安全验证码查询请求数据概况，例如：按照时间段查询数据  昨日请求量、昨日恶意比例、昨日验证量、昨日通过量、昨日恶意拦截量……
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCaptchaDataSumRequest"/></param>
        /// <returns>参考<see cref="DescribeCaptchaDataSumResponse"/>实例</returns>
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
        /// DescribeCaptchaOperData接口的同步版本，安全验证码用户操作数据查询，验证码加载耗时type = 1 、拦截情况type = 2、 一周通过平均尝试次数 type = 3、尝试次数分布 type = 4
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCaptchaOperDataRequest"/></param>
        /// <returns>参考<see cref="DescribeCaptchaOperDataResponse"/>实例</returns>
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
        /// 核查验证码票据结果
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
        /// DescribeCaptchaResult接口的同步版本，核查验证码票据结果
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCaptchaResultRequest"/></param>
        /// <returns>参考<see cref="DescribeCaptchaResultResponse"/>实例</returns>
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
        /// DescribeCaptchaUserAllAppId接口的同步版本，安全验证码获取用户注册所有APPId和应用名称
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCaptchaUserAllAppIdRequest"/></param>
        /// <returns>参考<see cref="DescribeCaptchaUserAllAppIdResponse"/>实例</returns>
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
        /// UpdateCaptchaAppIdInfo接口的同步版本，更新验证码应用APPId信息
        /// </summary>
        /// <param name="req">参考<see cref="UpdateCaptchaAppIdInfoRequest"/></param>
        /// <returns>参考<see cref="UpdateCaptchaAppIdInfoResponse"/>实例</returns>
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
