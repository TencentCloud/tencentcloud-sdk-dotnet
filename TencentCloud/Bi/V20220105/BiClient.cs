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

namespace TencentCloud.Bi.V20220105
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bi.V20220105.Models;

   public class BiClient : AbstractClient{

       private const string endpoint = "bi.tencentcloudapi.com";
       private const string version = "2022-01-05";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 申请延长Token可用时间接口-强鉴权
        /// </summary>
        /// <param name="req"><see cref="ApplyEmbedIntervalRequest"/></param>
        /// <returns><see cref="ApplyEmbedIntervalResponse"/></returns>
        public async Task<ApplyEmbedIntervalResponse> ApplyEmbedInterval(ApplyEmbedIntervalRequest req)
        {
             JsonResponseModel<ApplyEmbedIntervalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyEmbedInterval");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyEmbedIntervalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 申请延长Token可用时间接口-强鉴权
        /// </summary>
        /// <param name="req"><see cref="ApplyEmbedIntervalRequest"/></param>
        /// <returns><see cref="ApplyEmbedIntervalResponse"/></returns>
        public ApplyEmbedIntervalResponse ApplyEmbedIntervalSync(ApplyEmbedIntervalRequest req)
        {
             JsonResponseModel<ApplyEmbedIntervalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyEmbedInterval");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyEmbedIntervalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建嵌出报表-强鉴权
        /// </summary>
        /// <param name="req"><see cref="CreateEmbedTokenRequest"/></param>
        /// <returns><see cref="CreateEmbedTokenResponse"/></returns>
        public async Task<CreateEmbedTokenResponse> CreateEmbedToken(CreateEmbedTokenRequest req)
        {
             JsonResponseModel<CreateEmbedTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEmbedToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmbedTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建嵌出报表-强鉴权
        /// </summary>
        /// <param name="req"><see cref="CreateEmbedTokenRequest"/></param>
        /// <returns><see cref="CreateEmbedTokenResponse"/></returns>
        public CreateEmbedTokenResponse CreateEmbedTokenSync(CreateEmbedTokenRequest req)
        {
             JsonResponseModel<CreateEmbedTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEmbedToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmbedTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
