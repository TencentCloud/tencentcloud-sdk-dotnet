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

namespace TencentCloud.Smpn.V20190822
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Smpn.V20190822.Models;

   public class SmpnClient : AbstractClient{

       private const string endpoint = "smpn.tencentcloudapi.com";
       private const string version = "2019-08-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SmpnClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SmpnClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 企业号码认证
        /// </summary>
        /// <param name="req"><see cref="CreateSmpnEpaRequest"/></param>
        /// <returns><see cref="CreateSmpnEpaResponse"/></returns>
        public async Task<CreateSmpnEpaResponse> CreateSmpnEpa(CreateSmpnEpaRequest req)
        {
             JsonResponseModel<CreateSmpnEpaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSmpnEpa");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSmpnEpaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateSmpnEpa接口的同步版本，企业号码认证
        /// </summary>
        /// <param name="req">参考<see cref="CreateSmpnEpaRequest"/></param>
        /// <returns>参考<see cref="CreateSmpnEpaResponse"/>实例</returns>
        public CreateSmpnEpaResponse CreateSmpnEpaSync(CreateSmpnEpaRequest req)
        {
             JsonResponseModel<CreateSmpnEpaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSmpnEpa");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSmpnEpaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询号码的标记和标记次数
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnChpRequest"/></param>
        /// <returns><see cref="DescribeSmpnChpResponse"/></returns>
        public async Task<DescribeSmpnChpResponse> DescribeSmpnChp(DescribeSmpnChpRequest req)
        {
             JsonResponseModel<DescribeSmpnChpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmpnChp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmpnChpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSmpnChp接口的同步版本，查询号码的标记和标记次数
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSmpnChpRequest"/></param>
        /// <returns>参考<see cref="DescribeSmpnChpResponse"/>实例</returns>
        public DescribeSmpnChpResponse DescribeSmpnChpSync(DescribeSmpnChpRequest req)
        {
             JsonResponseModel<DescribeSmpnChpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSmpnChp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmpnChpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 虚假号码识别
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnFnrRequest"/></param>
        /// <returns><see cref="DescribeSmpnFnrResponse"/></returns>
        public async Task<DescribeSmpnFnrResponse> DescribeSmpnFnr(DescribeSmpnFnrRequest req)
        {
             JsonResponseModel<DescribeSmpnFnrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmpnFnr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmpnFnrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSmpnFnr接口的同步版本，虚假号码识别
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSmpnFnrRequest"/></param>
        /// <returns>参考<see cref="DescribeSmpnFnrResponse"/>实例</returns>
        public DescribeSmpnFnrResponse DescribeSmpnFnrSync(DescribeSmpnFnrRequest req)
        {
             JsonResponseModel<DescribeSmpnFnrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSmpnFnr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmpnFnrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 号码营销监控
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnMhmRequest"/></param>
        /// <returns><see cref="DescribeSmpnMhmResponse"/></returns>
        public async Task<DescribeSmpnMhmResponse> DescribeSmpnMhm(DescribeSmpnMhmRequest req)
        {
             JsonResponseModel<DescribeSmpnMhmResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmpnMhm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmpnMhmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSmpnMhm接口的同步版本，号码营销监控
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSmpnMhmRequest"/></param>
        /// <returns>参考<see cref="DescribeSmpnMhmResponse"/>实例</returns>
        public DescribeSmpnMhmResponse DescribeSmpnMhmSync(DescribeSmpnMhmRequest req)
        {
             JsonResponseModel<DescribeSmpnMhmResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSmpnMhm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmpnMhmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询号码恶意标记等级
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnMrlRequest"/></param>
        /// <returns><see cref="DescribeSmpnMrlResponse"/></returns>
        public async Task<DescribeSmpnMrlResponse> DescribeSmpnMrl(DescribeSmpnMrlRequest req)
        {
             JsonResponseModel<DescribeSmpnMrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmpnMrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmpnMrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSmpnMrl接口的同步版本，查询号码恶意标记等级
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSmpnMrlRequest"/></param>
        /// <returns>参考<see cref="DescribeSmpnMrlResponse"/>实例</returns>
        public DescribeSmpnMrlResponse DescribeSmpnMrlSync(DescribeSmpnMrlRequest req)
        {
             JsonResponseModel<DescribeSmpnMrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSmpnMrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmpnMrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
