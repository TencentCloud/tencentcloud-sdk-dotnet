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

namespace TencentCloud.Ccc.V20200210
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ccc.V20200210.Models;

   public class CccClient : AbstractClient{

       private const string endpoint = "ccc.tencentcloudapi.com";
       private const string version = "2020-02-10";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CccClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CccClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建 SDK 登录 Token。
        /// </summary>
        /// <param name="req"><see cref="CreateSDKLoginTokenRequest"/></param>
        /// <returns><see cref="CreateSDKLoginTokenResponse"/></returns>
        public async Task<CreateSDKLoginTokenResponse> CreateSDKLoginToken(CreateSDKLoginTokenRequest req)
        {
             JsonResponseModel<CreateSDKLoginTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSDKLoginToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSDKLoginTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 SDK 登录 Token。
        /// </summary>
        /// <param name="req"><see cref="CreateSDKLoginTokenRequest"/></param>
        /// <returns><see cref="CreateSDKLoginTokenResponse"/></returns>
        public CreateSDKLoginTokenResponse CreateSDKLoginTokenSync(CreateSDKLoginTokenRequest req)
        {
             JsonResponseModel<CreateSDKLoginTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSDKLoginToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSDKLoginTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取电话服务记录与录音
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCdrRequest"/></param>
        /// <returns><see cref="DescribeTelCdrResponse"/></returns>
        public async Task<DescribeTelCdrResponse> DescribeTelCdr(DescribeTelCdrRequest req)
        {
             JsonResponseModel<DescribeTelCdrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTelCdr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTelCdrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取电话服务记录与录音
        /// </summary>
        /// <param name="req"><see cref="DescribeTelCdrRequest"/></param>
        /// <returns><see cref="DescribeTelCdrResponse"/></returns>
        public DescribeTelCdrResponse DescribeTelCdrSync(DescribeTelCdrRequest req)
        {
             JsonResponseModel<DescribeTelCdrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTelCdr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTelCdrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
