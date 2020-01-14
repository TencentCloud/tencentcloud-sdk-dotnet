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

namespace TencentCloud.Sts.V20180813
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sts.V20180813.Models;

   public class StsClient : AbstractClient{

       private const string endpoint = "sts.tencentcloudapi.com";
       private const string version = "2018-08-13";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public StsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public StsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 申请扮演角色
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleRequest"/></param>
        /// <returns><see cref="AssumeRoleResponse"/></returns>
        public async Task<AssumeRoleResponse> AssumeRole(AssumeRoleRequest req)
        {
             JsonResponseModel<AssumeRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssumeRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AssumeRole接口的同步版本，申请扮演角色
        /// </summary>
        /// <param name="req">参考<see cref="AssumeRoleRequest"/></param>
        /// <returns>参考<see cref="AssumeRoleResponse"/>实例</returns>
        public AssumeRoleResponse AssumeRoleSync(AssumeRoleRequest req)
        {
             JsonResponseModel<AssumeRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssumeRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssumeRoleWithSAML）用于根据 SAML 断言申请角色临时凭证。
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithSAMLRequest"/></param>
        /// <returns><see cref="AssumeRoleWithSAMLResponse"/></returns>
        public async Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAML(AssumeRoleWithSAMLRequest req)
        {
             JsonResponseModel<AssumeRoleWithSAMLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssumeRoleWithSAML");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleWithSAMLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AssumeRoleWithSAML接口的同步版本，本接口（AssumeRoleWithSAML）用于根据 SAML 断言申请角色临时凭证。
        /// </summary>
        /// <param name="req">参考<see cref="AssumeRoleWithSAMLRequest"/></param>
        /// <returns>参考<see cref="AssumeRoleWithSAMLResponse"/>实例</returns>
        public AssumeRoleWithSAMLResponse AssumeRoleWithSAMLSync(AssumeRoleWithSAMLRequest req)
        {
             JsonResponseModel<AssumeRoleWithSAMLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssumeRoleWithSAML");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleWithSAMLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取联合身份临时访问凭证
        /// </summary>
        /// <param name="req"><see cref="GetFederationTokenRequest"/></param>
        /// <returns><see cref="GetFederationTokenResponse"/></returns>
        public async Task<GetFederationTokenResponse> GetFederationToken(GetFederationTokenRequest req)
        {
             JsonResponseModel<GetFederationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFederationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFederationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetFederationToken接口的同步版本，获取联合身份临时访问凭证
        /// </summary>
        /// <param name="req">参考<see cref="GetFederationTokenRequest"/></param>
        /// <returns>参考<see cref="GetFederationTokenResponse"/>实例</returns>
        public GetFederationTokenResponse GetFederationTokenSync(GetFederationTokenRequest req)
        {
             JsonResponseModel<GetFederationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFederationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFederationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取API密钥列表
        /// </summary>
        /// <param name="req"><see cref="QueryApiKeyRequest"/></param>
        /// <returns><see cref="QueryApiKeyResponse"/></returns>
        public async Task<QueryApiKeyResponse> QueryApiKey(QueryApiKeyRequest req)
        {
             JsonResponseModel<QueryApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// QueryApiKey接口的同步版本，拉取API密钥列表
        /// </summary>
        /// <param name="req">参考<see cref="QueryApiKeyRequest"/></param>
        /// <returns>参考<see cref="QueryApiKeyResponse"/>实例</returns>
        public QueryApiKeyResponse QueryApiKeySync(QueryApiKeyRequest req)
        {
             JsonResponseModel<QueryApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
