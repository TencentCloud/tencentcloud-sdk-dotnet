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

namespace TencentCloud.Tdid.V20210519
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tdid.V20210519.Models;

   public class TdidClient : AbstractClient{

       private const string endpoint = "tdid.tencentcloudapi.com";
       private const string version = "2021-05-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TdidClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建凭证
        /// </summary>
        /// <param name="req"><see cref="CreateCredentialRequest"/></param>
        /// <returns><see cref="CreateCredentialResponse"/></returns>
        public async Task<CreateCredentialResponse> CreateCredential(CreateCredentialRequest req)
        {
             JsonResponseModel<CreateCredentialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建凭证
        /// </summary>
        /// <param name="req"><see cref="CreateCredentialRequest"/></param>
        /// <returns><see cref="CreateCredentialResponse"/></returns>
        public CreateCredentialResponse CreateCredentialSync(CreateCredentialRequest req)
        {
             JsonResponseModel<CreateCredentialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建选择性批露凭证
        /// </summary>
        /// <param name="req"><see cref="CreateSelectiveCredentialRequest"/></param>
        /// <returns><see cref="CreateSelectiveCredentialResponse"/></returns>
        public async Task<CreateSelectiveCredentialResponse> CreateSelectiveCredential(CreateSelectiveCredentialRequest req)
        {
             JsonResponseModel<CreateSelectiveCredentialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSelectiveCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSelectiveCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建选择性批露凭证
        /// </summary>
        /// <param name="req"><see cref="CreateSelectiveCredentialRequest"/></param>
        /// <returns><see cref="CreateSelectiveCredentialResponse"/></returns>
        public CreateSelectiveCredentialResponse CreateSelectiveCredentialSync(CreateSelectiveCredentialRequest req)
        {
             JsonResponseModel<CreateSelectiveCredentialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSelectiveCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSelectiveCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建机构DID
        /// </summary>
        /// <param name="req"><see cref="CreateTDidRequest"/></param>
        /// <returns><see cref="CreateTDidResponse"/></returns>
        public async Task<CreateTDidResponse> CreateTDid(CreateTDidRequest req)
        {
             JsonResponseModel<CreateTDidResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTDid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTDidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建机构DID
        /// </summary>
        /// <param name="req"><see cref="CreateTDidRequest"/></param>
        /// <returns><see cref="CreateTDidResponse"/></returns>
        public CreateTDidResponse CreateTDidSync(CreateTDidRequest req)
        {
             JsonResponseModel<CreateTDidResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTDid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTDidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证凭证
        /// </summary>
        /// <param name="req"><see cref="VerifyCredentialRequest"/></param>
        /// <returns><see cref="VerifyCredentialResponse"/></returns>
        public async Task<VerifyCredentialResponse> VerifyCredential(VerifyCredentialRequest req)
        {
             JsonResponseModel<VerifyCredentialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证凭证
        /// </summary>
        /// <param name="req"><see cref="VerifyCredentialRequest"/></param>
        /// <returns><see cref="VerifyCredentialResponse"/></returns>
        public VerifyCredentialResponse VerifyCredentialSync(VerifyCredentialRequest req)
        {
             JsonResponseModel<VerifyCredentialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
