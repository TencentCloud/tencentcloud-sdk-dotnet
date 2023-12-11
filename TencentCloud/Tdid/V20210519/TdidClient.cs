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
       private const string sdkVersion = "3.0.914";

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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 检查区块链信息
        /// </summary>
        /// <param name="req"><see cref="CheckChainRequest"/></param>
        /// <returns><see cref="CheckChainResponse"/></returns>
        public Task<CheckChainResponse> CheckChain(CheckChainRequest req)
        {
            return InternalRequestAsync<CheckChainResponse>(req, "CheckChain");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 检查区块链信息
        /// </summary>
        /// <param name="req"><see cref="CheckChainRequest"/></param>
        /// <returns><see cref="CheckChainResponse"/></returns>
        public CheckChainResponse CheckChainSync(CheckChainRequest req)
        {
            return InternalRequestAsync<CheckChainResponse>(req, "CheckChain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 创建凭证
        /// </summary>
        /// <param name="req"><see cref="CreateCredentialRequest"/></param>
        /// <returns><see cref="CreateCredentialResponse"/></returns>
        public Task<CreateCredentialResponse> CreateCredential(CreateCredentialRequest req)
        {
            return InternalRequestAsync<CreateCredentialResponse>(req, "CreateCredential");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 创建凭证
        /// </summary>
        /// <param name="req"><see cref="CreateCredentialRequest"/></param>
        /// <returns><see cref="CreateCredentialResponse"/></returns>
        public CreateCredentialResponse CreateCredentialSync(CreateCredentialRequest req)
        {
            return InternalRequestAsync<CreateCredentialResponse>(req, "CreateCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 创建选择性批露凭证
        /// </summary>
        /// <param name="req"><see cref="CreateSelectiveCredentialRequest"/></param>
        /// <returns><see cref="CreateSelectiveCredentialResponse"/></returns>
        public Task<CreateSelectiveCredentialResponse> CreateSelectiveCredential(CreateSelectiveCredentialRequest req)
        {
            return InternalRequestAsync<CreateSelectiveCredentialResponse>(req, "CreateSelectiveCredential");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 创建选择性批露凭证
        /// </summary>
        /// <param name="req"><see cref="CreateSelectiveCredentialRequest"/></param>
        /// <returns><see cref="CreateSelectiveCredentialResponse"/></returns>
        public CreateSelectiveCredentialResponse CreateSelectiveCredentialSync(CreateSelectiveCredentialRequest req)
        {
            return InternalRequestAsync<CreateSelectiveCredentialResponse>(req, "CreateSelectiveCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 创建机构DID
        /// </summary>
        /// <param name="req"><see cref="CreateTDidRequest"/></param>
        /// <returns><see cref="CreateTDidResponse"/></returns>
        public Task<CreateTDidResponse> CreateTDid(CreateTDidRequest req)
        {
            return InternalRequestAsync<CreateTDidResponse>(req, "CreateTDid");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 创建机构DID
        /// </summary>
        /// <param name="req"><see cref="CreateTDidRequest"/></param>
        /// <returns><see cref="CreateTDidResponse"/></returns>
        public CreateTDidResponse CreateTDidSync(CreateTDidRequest req)
        {
            return InternalRequestAsync<CreateTDidResponse>(req, "CreateTDid")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 新建DID根据私钥生成Tdid
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPrivateKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPrivateKeyResponse"/></returns>
        public Task<CreateTDidByPrivateKeyResponse> CreateTDidByPrivateKey(CreateTDidByPrivateKeyRequest req)
        {
            return InternalRequestAsync<CreateTDidByPrivateKeyResponse>(req, "CreateTDidByPrivateKey");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 新建DID根据私钥生成Tdid
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPrivateKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPrivateKeyResponse"/></returns>
        public CreateTDidByPrivateKeyResponse CreateTDidByPrivateKeySync(CreateTDidByPrivateKeyRequest req)
        {
            return InternalRequestAsync<CreateTDidByPrivateKeyResponse>(req, "CreateTDidByPrivateKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        ///  新建DID根据公钥生成Tdid
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPublicKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPublicKeyResponse"/></returns>
        public Task<CreateTDidByPublicKeyResponse> CreateTDidByPublicKey(CreateTDidByPublicKeyRequest req)
        {
            return InternalRequestAsync<CreateTDidByPublicKeyResponse>(req, "CreateTDidByPublicKey");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        ///  新建DID根据公钥生成Tdid
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPublicKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPublicKeyResponse"/></returns>
        public CreateTDidByPublicKeyResponse CreateTDidByPublicKeySync(CreateTDidByPublicKeyRequest req)
        {
            return InternalRequestAsync<CreateTDidByPublicKeyResponse>(req, "CreateTDidByPublicKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 获取权威机构信息
        /// </summary>
        /// <param name="req"><see cref="GetAuthorityIssuerRequest"/></param>
        /// <returns><see cref="GetAuthorityIssuerResponse"/></returns>
        public Task<GetAuthorityIssuerResponse> GetAuthorityIssuer(GetAuthorityIssuerRequest req)
        {
            return InternalRequestAsync<GetAuthorityIssuerResponse>(req, "GetAuthorityIssuer");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 获取权威机构信息
        /// </summary>
        /// <param name="req"><see cref="GetAuthorityIssuerRequest"/></param>
        /// <returns><see cref="GetAuthorityIssuerResponse"/></returns>
        public GetAuthorityIssuerResponse GetAuthorityIssuerSync(GetAuthorityIssuerRequest req)
        {
            return InternalRequestAsync<GetAuthorityIssuerResponse>(req, "GetAuthorityIssuer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 凭证模版详情
        /// </summary>
        /// <param name="req"><see cref="GetCptInfoRequest"/></param>
        /// <returns><see cref="GetCptInfoResponse"/></returns>
        public Task<GetCptInfoResponse> GetCptInfo(GetCptInfoRequest req)
        {
            return InternalRequestAsync<GetCptInfoResponse>(req, "GetCptInfo");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 凭证模版详情
        /// </summary>
        /// <param name="req"><see cref="GetCptInfoRequest"/></param>
        /// <returns><see cref="GetCptInfoResponse"/></returns>
        public GetCptInfoResponse GetCptInfoSync(GetCptInfoRequest req)
        {
            return InternalRequestAsync<GetCptInfoResponse>(req, "GetCptInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 获取凭证链上状态信息
        /// </summary>
        /// <param name="req"><see cref="GetCredentialStatusRequest"/></param>
        /// <returns><see cref="GetCredentialStatusResponse"/></returns>
        public Task<GetCredentialStatusResponse> GetCredentialStatus(GetCredentialStatusRequest req)
        {
            return InternalRequestAsync<GetCredentialStatusResponse>(req, "GetCredentialStatus");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 获取凭证链上状态信息
        /// </summary>
        /// <param name="req"><see cref="GetCredentialStatusRequest"/></param>
        /// <returns><see cref="GetCredentialStatusResponse"/></returns>
        public GetCredentialStatusResponse GetCredentialStatusSync(GetCredentialStatusRequest req)
        {
            return InternalRequestAsync<GetCredentialStatusResponse>(req, "GetCredentialStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 查看DID文档
        /// </summary>
        /// <param name="req"><see cref="GetDidDocumentRequest"/></param>
        /// <returns><see cref="GetDidDocumentResponse"/></returns>
        public Task<GetDidDocumentResponse> GetDidDocument(GetDidDocumentRequest req)
        {
            return InternalRequestAsync<GetDidDocumentResponse>(req, "GetDidDocument");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 查看DID文档
        /// </summary>
        /// <param name="req"><see cref="GetDidDocumentRequest"/></param>
        /// <returns><see cref="GetDidDocumentResponse"/></returns>
        public GetDidDocumentResponse GetDidDocumentSync(GetDidDocumentRequest req)
        {
            return InternalRequestAsync<GetDidDocumentResponse>(req, "GetDidDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 凭证模版新建
        /// </summary>
        /// <param name="req"><see cref="RegisterCptRequest"/></param>
        /// <returns><see cref="RegisterCptResponse"/></returns>
        public Task<RegisterCptResponse> RegisterCpt(RegisterCptRequest req)
        {
            return InternalRequestAsync<RegisterCptResponse>(req, "RegisterCpt");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 凭证模版新建
        /// </summary>
        /// <param name="req"><see cref="RegisterCptRequest"/></param>
        /// <returns><see cref="RegisterCptResponse"/></returns>
        public RegisterCptResponse RegisterCptSync(RegisterCptRequest req)
        {
            return InternalRequestAsync<RegisterCptResponse>(req, "RegisterCpt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 设置凭证链上状态
        /// </summary>
        /// <param name="req"><see cref="SetCredentialStatusRequest"/></param>
        /// <returns><see cref="SetCredentialStatusResponse"/></returns>
        public Task<SetCredentialStatusResponse> SetCredentialStatus(SetCredentialStatusRequest req)
        {
            return InternalRequestAsync<SetCredentialStatusResponse>(req, "SetCredentialStatus");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 设置凭证链上状态
        /// </summary>
        /// <param name="req"><see cref="SetCredentialStatusRequest"/></param>
        /// <returns><see cref="SetCredentialStatusResponse"/></returns>
        public SetCredentialStatusResponse SetCredentialStatusSync(SetCredentialStatusRequest req)
        {
            return InternalRequestAsync<SetCredentialStatusResponse>(req, "SetCredentialStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 验证凭证
        /// </summary>
        /// <param name="req"><see cref="VerifyCredentialRequest"/></param>
        /// <returns><see cref="VerifyCredentialResponse"/></returns>
        public Task<VerifyCredentialResponse> VerifyCredential(VerifyCredentialRequest req)
        {
            return InternalRequestAsync<VerifyCredentialResponse>(req, "VerifyCredential");
        }

        /// <summary>
        /// 该接口不再使用
        /// 
        /// 验证凭证
        /// </summary>
        /// <param name="req"><see cref="VerifyCredentialRequest"/></param>
        /// <returns><see cref="VerifyCredentialResponse"/></returns>
        public VerifyCredentialResponse VerifyCredentialSync(VerifyCredentialRequest req)
        {
            return InternalRequestAsync<VerifyCredentialResponse>(req, "VerifyCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
