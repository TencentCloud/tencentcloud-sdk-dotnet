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
       private const string sdkVersion = "SDK_NET_3.0.1144";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
        /// 根据披露策略创建选择性披露凭证
        /// </summary>
        /// <param name="req"><see cref="CreateDisclosedCredentialRequest"/></param>
        /// <returns><see cref="CreateDisclosedCredentialResponse"/></returns>
        public Task<CreateDisclosedCredentialResponse> CreateDisclosedCredential(CreateDisclosedCredentialRequest req)
        {
            return InternalRequestAsync<CreateDisclosedCredentialResponse>(req, "CreateDisclosedCredential");
        }

        /// <summary>
        /// 根据披露策略创建选择性披露凭证
        /// </summary>
        /// <param name="req"><see cref="CreateDisclosedCredentialRequest"/></param>
        /// <returns><see cref="CreateDisclosedCredentialResponse"/></returns>
        public CreateDisclosedCredentialResponse CreateDisclosedCredentialSync(CreateDisclosedCredentialRequest req)
        {
            return InternalRequestAsync<CreateDisclosedCredentialResponse>(req, "CreateDisclosedCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建凭证持有人的可验证表达
        /// </summary>
        /// <param name="req"><see cref="CreatePresentationRequest"/></param>
        /// <returns><see cref="CreatePresentationResponse"/></returns>
        public Task<CreatePresentationResponse> CreatePresentation(CreatePresentationRequest req)
        {
            return InternalRequestAsync<CreatePresentationResponse>(req, "CreatePresentation");
        }

        /// <summary>
        /// 创建凭证持有人的可验证表达
        /// </summary>
        /// <param name="req"><see cref="CreatePresentationRequest"/></param>
        /// <returns><see cref="CreatePresentationResponse"/></returns>
        public CreatePresentationResponse CreatePresentationSync(CreatePresentationRequest req)
        {
            return InternalRequestAsync<CreatePresentationResponse>(req, "CreatePresentation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自动生成公私钥对托管在DID平台，并注册DID标识
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByHostRequest"/></param>
        /// <returns><see cref="CreateTDidByHostResponse"/></returns>
        public Task<CreateTDidByHostResponse> CreateTDidByHost(CreateTDidByHostRequest req)
        {
            return InternalRequestAsync<CreateTDidByHostResponse>(req, "CreateTDidByHost");
        }

        /// <summary>
        /// 自动生成公私钥对托管在DID平台，并注册DID标识
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByHostRequest"/></param>
        /// <returns><see cref="CreateTDidByHostResponse"/></returns>
        public CreateTDidByHostResponse CreateTDidByHostSync(CreateTDidByHostRequest req)
        {
            return InternalRequestAsync<CreateTDidByHostResponse>(req, "CreateTDidByHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用导入的公钥文件注册DID标识
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPubKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPubKeyResponse"/></returns>
        public Task<CreateTDidByPubKeyResponse> CreateTDidByPubKey(CreateTDidByPubKeyRequest req)
        {
            return InternalRequestAsync<CreateTDidByPubKeyResponse>(req, "CreateTDidByPubKey");
        }

        /// <summary>
        /// 使用导入的公钥文件注册DID标识
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPubKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPubKeyResponse"/></returns>
        public CreateTDidByPubKeyResponse CreateTDidByPubKeySync(CreateTDidByPubKeyRequest req)
        {
            return InternalRequestAsync<CreateTDidByPubKeyResponse>(req, "CreateTDidByPubKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新DID标识的禁用状态
        /// </summary>
        /// <param name="req"><see cref="DeactivateTDidRequest"/></param>
        /// <returns><see cref="DeactivateTDidResponse"/></returns>
        public Task<DeactivateTDidResponse> DeactivateTDid(DeactivateTDidRequest req)
        {
            return InternalRequestAsync<DeactivateTDidResponse>(req, "DeactivateTDid");
        }

        /// <summary>
        /// 更新DID标识的禁用状态
        /// </summary>
        /// <param name="req"><see cref="DeactivateTDidRequest"/></param>
        /// <returns><see cref="DeactivateTDidResponse"/></returns>
        public DeactivateTDidResponse DeactivateTDidSync(DeactivateTDidRequest req)
        {
            return InternalRequestAsync<DeactivateTDidResponse>(req, "DeactivateTDid")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取某个应用关键指标统计数据
        /// </summary>
        /// <param name="req"><see cref="GetAppSummaryRequest"/></param>
        /// <returns><see cref="GetAppSummaryResponse"/></returns>
        public Task<GetAppSummaryResponse> GetAppSummary(GetAppSummaryRequest req)
        {
            return InternalRequestAsync<GetAppSummaryResponse>(req, "GetAppSummary");
        }

        /// <summary>
        /// 获取某个应用关键指标统计数据
        /// </summary>
        /// <param name="req"><see cref="GetAppSummaryRequest"/></param>
        /// <returns><see cref="GetAppSummaryResponse"/></returns>
        public GetAppSummaryResponse GetAppSummarySync(GetAppSummaryRequest req)
        {
            return InternalRequestAsync<GetAppSummaryResponse>(req, "GetAppSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取凭证链上状态信息
        /// </summary>
        /// <param name="req"><see cref="GetCredentialStateRequest"/></param>
        /// <returns><see cref="GetCredentialStateResponse"/></returns>
        public Task<GetCredentialStateResponse> GetCredentialState(GetCredentialStateRequest req)
        {
            return InternalRequestAsync<GetCredentialStateResponse>(req, "GetCredentialState");
        }

        /// <summary>
        /// 获取凭证链上状态信息
        /// </summary>
        /// <param name="req"><see cref="GetCredentialStateRequest"/></param>
        /// <returns><see cref="GetCredentialStateResponse"/></returns>
        public GetCredentialStateResponse GetCredentialStateSync(GetCredentialStateRequest req)
        {
            return InternalRequestAsync<GetCredentialStateResponse>(req, "GetCredentialState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取某个应用关键指标统计数据
        /// </summary>
        /// <param name="req"><see cref="GetOverSummaryRequest"/></param>
        /// <returns><see cref="GetOverSummaryResponse"/></returns>
        public Task<GetOverSummaryResponse> GetOverSummary(GetOverSummaryRequest req)
        {
            return InternalRequestAsync<GetOverSummaryResponse>(req, "GetOverSummary");
        }

        /// <summary>
        /// 获取某个应用关键指标统计数据
        /// </summary>
        /// <param name="req"><see cref="GetOverSummaryRequest"/></param>
        /// <returns><see cref="GetOverSummaryResponse"/></returns>
        public GetOverSummaryResponse GetOverSummarySync(GetOverSummaryRequest req)
        {
            return InternalRequestAsync<GetOverSummaryResponse>(req, "GetOverSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过业务层绑定的对象ID获取DID标识
        /// </summary>
        /// <param name="req"><see cref="GetTDidByObjectIdRequest"/></param>
        /// <returns><see cref="GetTDidByObjectIdResponse"/></returns>
        public Task<GetTDidByObjectIdResponse> GetTDidByObjectId(GetTDidByObjectIdRequest req)
        {
            return InternalRequestAsync<GetTDidByObjectIdResponse>(req, "GetTDidByObjectId");
        }

        /// <summary>
        /// 通过业务层绑定的对象ID获取DID标识
        /// </summary>
        /// <param name="req"><see cref="GetTDidByObjectIdRequest"/></param>
        /// <returns><see cref="GetTDidByObjectIdResponse"/></returns>
        public GetTDidByObjectIdResponse GetTDidByObjectIdSync(GetTDidByObjectIdRequest req)
        {
            return InternalRequestAsync<GetTDidByObjectIdResponse>(req, "GetTDidByObjectId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DID标识的文档
        /// </summary>
        /// <param name="req"><see cref="GetTDidDocumentRequest"/></param>
        /// <returns><see cref="GetTDidDocumentResponse"/></returns>
        public Task<GetTDidDocumentResponse> GetTDidDocument(GetTDidDocumentRequest req)
        {
            return InternalRequestAsync<GetTDidDocumentResponse>(req, "GetTDidDocument");
        }

        /// <summary>
        /// 获取DID标识的文档
        /// </summary>
        /// <param name="req"><see cref="GetTDidDocumentRequest"/></param>
        /// <returns><see cref="GetTDidDocumentResponse"/></returns>
        public GetTDidDocumentResponse GetTDidDocumentSync(GetTDidDocumentRequest req)
        {
            return InternalRequestAsync<GetTDidDocumentResponse>(req, "GetTDidDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询DID标识的认证公钥
        /// </summary>
        /// <param name="req"><see cref="GetTDidPubKeyRequest"/></param>
        /// <returns><see cref="GetTDidPubKeyResponse"/></returns>
        public Task<GetTDidPubKeyResponse> GetTDidPubKey(GetTDidPubKeyRequest req)
        {
            return InternalRequestAsync<GetTDidPubKeyResponse>(req, "GetTDidPubKey");
        }

        /// <summary>
        /// 查询DID标识的认证公钥
        /// </summary>
        /// <param name="req"><see cref="GetTDidPubKeyRequest"/></param>
        /// <returns><see cref="GetTDidPubKeyResponse"/></returns>
        public GetTDidPubKeyResponse GetTDidPubKeySync(GetTDidPubKeyRequest req)
        {
            return InternalRequestAsync<GetTDidPubKeyResponse>(req, "GetTDidPubKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 颁发可验证凭证
        /// </summary>
        /// <param name="req"><see cref="IssueCredentialRequest"/></param>
        /// <returns><see cref="IssueCredentialResponse"/></returns>
        public Task<IssueCredentialResponse> IssueCredential(IssueCredentialRequest req)
        {
            return InternalRequestAsync<IssueCredentialResponse>(req, "IssueCredential");
        }

        /// <summary>
        /// 颁发可验证凭证
        /// </summary>
        /// <param name="req"><see cref="IssueCredentialRequest"/></param>
        /// <returns><see cref="IssueCredentialResponse"/></returns>
        public IssueCredentialResponse IssueCredentialSync(IssueCredentialRequest req)
        {
            return InternalRequestAsync<IssueCredentialResponse>(req, "IssueCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询权威机构信息
        /// </summary>
        /// <param name="req"><see cref="QueryAuthorityInfoRequest"/></param>
        /// <returns><see cref="QueryAuthorityInfoResponse"/></returns>
        public Task<QueryAuthorityInfoResponse> QueryAuthorityInfo(QueryAuthorityInfoRequest req)
        {
            return InternalRequestAsync<QueryAuthorityInfoResponse>(req, "QueryAuthorityInfo");
        }

        /// <summary>
        /// 查询权威机构信息
        /// </summary>
        /// <param name="req"><see cref="QueryAuthorityInfoRequest"/></param>
        /// <returns><see cref="QueryAuthorityInfoResponse"/></returns>
        public QueryAuthorityInfoResponse QueryAuthorityInfoSync(QueryAuthorityInfoRequest req)
        {
            return InternalRequestAsync<QueryAuthorityInfoResponse>(req, "QueryAuthorityInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询凭证模板内容
        /// </summary>
        /// <param name="req"><see cref="QueryCPTRequest"/></param>
        /// <returns><see cref="QueryCPTResponse"/></returns>
        public Task<QueryCPTResponse> QueryCPT(QueryCPTRequest req)
        {
            return InternalRequestAsync<QueryCPTResponse>(req, "QueryCPT");
        }

        /// <summary>
        /// 查询凭证模板内容
        /// </summary>
        /// <param name="req"><see cref="QueryCPTRequest"/></param>
        /// <returns><see cref="QueryCPTResponse"/></returns>
        public QueryCPTResponse QueryCPTSync(QueryCPTRequest req)
        {
            return InternalRequestAsync<QueryCPTResponse>(req, "QueryCPT")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置DID文档的自定义属性
        /// </summary>
        /// <param name="req"><see cref="SetTDidAttributeRequest"/></param>
        /// <returns><see cref="SetTDidAttributeResponse"/></returns>
        public Task<SetTDidAttributeResponse> SetTDidAttribute(SetTDidAttributeRequest req)
        {
            return InternalRequestAsync<SetTDidAttributeResponse>(req, "SetTDidAttribute");
        }

        /// <summary>
        /// 设置DID文档的自定义属性
        /// </summary>
        /// <param name="req"><see cref="SetTDidAttributeRequest"/></param>
        /// <returns><see cref="SetTDidAttributeResponse"/></returns>
        public SetTDidAttributeResponse SetTDidAttributeSync(SetTDidAttributeRequest req)
        {
            return InternalRequestAsync<SetTDidAttributeResponse>(req, "SetTDidAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新凭证的链上状态
        /// </summary>
        /// <param name="req"><see cref="UpdateCredentialStateRequest"/></param>
        /// <returns><see cref="UpdateCredentialStateResponse"/></returns>
        public Task<UpdateCredentialStateResponse> UpdateCredentialState(UpdateCredentialStateRequest req)
        {
            return InternalRequestAsync<UpdateCredentialStateResponse>(req, "UpdateCredentialState");
        }

        /// <summary>
        /// 更新凭证的链上状态
        /// </summary>
        /// <param name="req"><see cref="UpdateCredentialStateRequest"/></param>
        /// <returns><see cref="UpdateCredentialStateResponse"/></returns>
        public UpdateCredentialStateResponse UpdateCredentialStateSync(UpdateCredentialStateRequest req)
        {
            return InternalRequestAsync<UpdateCredentialStateResponse>(req, "UpdateCredentialState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 验证已签名的可验证凭证
        /// </summary>
        /// <param name="req"><see cref="VerifyCredentialsRequest"/></param>
        /// <returns><see cref="VerifyCredentialsResponse"/></returns>
        public Task<VerifyCredentialsResponse> VerifyCredentials(VerifyCredentialsRequest req)
        {
            return InternalRequestAsync<VerifyCredentialsResponse>(req, "VerifyCredentials");
        }

        /// <summary>
        /// 验证已签名的可验证凭证
        /// </summary>
        /// <param name="req"><see cref="VerifyCredentialsRequest"/></param>
        /// <returns><see cref="VerifyCredentialsResponse"/></returns>
        public VerifyCredentialsResponse VerifyCredentialsSync(VerifyCredentialsRequest req)
        {
            return InternalRequestAsync<VerifyCredentialsResponse>(req, "VerifyCredentials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 验证可验证表达的内容
        /// </summary>
        /// <param name="req"><see cref="VerifyPresentationRequest"/></param>
        /// <returns><see cref="VerifyPresentationResponse"/></returns>
        public Task<VerifyPresentationResponse> VerifyPresentation(VerifyPresentationRequest req)
        {
            return InternalRequestAsync<VerifyPresentationResponse>(req, "VerifyPresentation");
        }

        /// <summary>
        /// 验证可验证表达的内容
        /// </summary>
        /// <param name="req"><see cref="VerifyPresentationRequest"/></param>
        /// <returns><see cref="VerifyPresentationResponse"/></returns>
        public VerifyPresentationResponse VerifyPresentationSync(VerifyPresentationRequest req)
        {
            return InternalRequestAsync<VerifyPresentationResponse>(req, "VerifyPresentation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
