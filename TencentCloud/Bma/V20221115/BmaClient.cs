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

namespace TencentCloud.Bma.V20221115
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bma.V20221115.Models;

   public class BmaClient : AbstractClient{

       private const string endpoint = "bma.tencentcloudapi.com";
       private const string version = "2022-11-15";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BmaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPResponse"/></returns>
        public async Task<CreateBPFakeAPPResponse> CreateBPFakeAPP(CreateBPFakeAPPRequest req)
        {
             JsonResponseModel<CreateBPFakeAPPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPFakeAPP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeAPPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPResponse"/></returns>
        public CreateBPFakeAPPResponse CreateBPFakeAPPSync(CreateBPFakeAPPRequest req)
        {
             JsonResponseModel<CreateBPFakeAPPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPFakeAPP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeAPPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPListRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPListResponse"/></returns>
        public async Task<CreateBPFakeAPPListResponse> CreateBPFakeAPPList(CreateBPFakeAPPListRequest req)
        {
             JsonResponseModel<CreateBPFakeAPPListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPFakeAPPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeAPPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量仿冒应用举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeAPPListRequest"/></param>
        /// <returns><see cref="CreateBPFakeAPPListResponse"/></returns>
        public CreateBPFakeAPPListResponse CreateBPFakeAPPListSync(CreateBPFakeAPPListRequest req)
        {
             JsonResponseModel<CreateBPFakeAPPListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPFakeAPPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeAPPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLResponse"/></returns>
        public async Task<CreateBPFakeURLResponse> CreateBPFakeURL(CreateBPFakeURLRequest req)
        {
             JsonResponseModel<CreateBPFakeURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPFakeURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLResponse"/></returns>
        public CreateBPFakeURLResponse CreateBPFakeURLSync(CreateBPFakeURLRequest req)
        {
             JsonResponseModel<CreateBPFakeURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPFakeURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLsRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLsResponse"/></returns>
        public async Task<CreateBPFakeURLsResponse> CreateBPFakeURLs(CreateBPFakeURLsRequest req)
        {
             JsonResponseModel<CreateBPFakeURLsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPFakeURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量仿冒网址举报
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLsRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLsResponse"/></returns>
        public CreateBPFakeURLsResponse CreateBPFakeURLsSync(CreateBPFakeURLsRequest req)
        {
             JsonResponseModel<CreateBPFakeURLsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPFakeURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
