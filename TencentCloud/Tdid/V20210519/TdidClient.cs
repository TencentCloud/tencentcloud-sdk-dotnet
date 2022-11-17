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
        /// DID添加标签
        /// </summary>
        /// <param name="req"><see cref="AddLabelRequest"/></param>
        /// <returns><see cref="AddLabelResponse"/></returns>
        public async Task<AddLabelResponse> AddLabel(AddLabelRequest req)
        {
             JsonResponseModel<AddLabelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddLabel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLabelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DID添加标签
        /// </summary>
        /// <param name="req"><see cref="AddLabelRequest"/></param>
        /// <returns><see cref="AddLabelResponse"/></returns>
        public AddLabelResponse AddLabelSync(AddLabelRequest req)
        {
             JsonResponseModel<AddLabelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddLabel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLabelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤消权威机构认证
        /// </summary>
        /// <param name="req"><see cref="CancelAuthorityIssuerRequest"/></param>
        /// <returns><see cref="CancelAuthorityIssuerResponse"/></returns>
        public async Task<CancelAuthorityIssuerResponse> CancelAuthorityIssuer(CancelAuthorityIssuerRequest req)
        {
             JsonResponseModel<CancelAuthorityIssuerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelAuthorityIssuer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelAuthorityIssuerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤消权威机构认证
        /// </summary>
        /// <param name="req"><see cref="CancelAuthorityIssuerRequest"/></param>
        /// <returns><see cref="CancelAuthorityIssuerResponse"/></returns>
        public CancelAuthorityIssuerResponse CancelAuthorityIssuerSync(CancelAuthorityIssuerRequest req)
        {
             JsonResponseModel<CancelAuthorityIssuerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelAuthorityIssuer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelAuthorityIssuerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查区块链信息
        /// </summary>
        /// <param name="req"><see cref="CheckChainRequest"/></param>
        /// <returns><see cref="CheckChainResponse"/></returns>
        public async Task<CheckChainResponse> CheckChain(CheckChainRequest req)
        {
             JsonResponseModel<CheckChainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckChain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckChainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查区块链信息
        /// </summary>
        /// <param name="req"><see cref="CheckChainRequest"/></param>
        /// <returns><see cref="CheckChainResponse"/></returns>
        public CheckChainResponse CheckChainSync(CheckChainRequest req)
        {
             JsonResponseModel<CheckChainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckChain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckChainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查部署情况
        /// </summary>
        /// <param name="req"><see cref="CheckDidDeployRequest"/></param>
        /// <returns><see cref="CheckDidDeployResponse"/></returns>
        public async Task<CheckDidDeployResponse> CheckDidDeploy(CheckDidDeployRequest req)
        {
             JsonResponseModel<CheckDidDeployResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckDidDeploy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDidDeployResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查部署情况
        /// </summary>
        /// <param name="req"><see cref="CheckDidDeployRequest"/></param>
        /// <returns><see cref="CheckDidDeployResponse"/></returns>
        public CheckDidDeployResponse CheckDidDeploySync(CheckDidDeployRequest req)
        {
             JsonResponseModel<CheckDidDeployResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckDidDeploy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDidDeployResponse>>(strResp);
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
        /// 创建DID服务
        /// </summary>
        /// <param name="req"><see cref="CreateDidServiceRequest"/></param>
        /// <returns><see cref="CreateDidServiceResponse"/></returns>
        public async Task<CreateDidServiceResponse> CreateDidService(CreateDidServiceRequest req)
        {
             JsonResponseModel<CreateDidServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDidService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDidServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建DID服务
        /// </summary>
        /// <param name="req"><see cref="CreateDidServiceRequest"/></param>
        /// <returns><see cref="CreateDidServiceResponse"/></returns>
        public CreateDidServiceResponse CreateDidServiceSync(CreateDidServiceRequest req)
        {
             JsonResponseModel<CreateDidServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDidService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDidServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建标签
        /// </summary>
        /// <param name="req"><see cref="CreateLabelRequest"/></param>
        /// <returns><see cref="CreateLabelResponse"/></returns>
        public async Task<CreateLabelResponse> CreateLabel(CreateLabelRequest req)
        {
             JsonResponseModel<CreateLabelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLabel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLabelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建标签
        /// </summary>
        /// <param name="req"><see cref="CreateLabelRequest"/></param>
        /// <returns><see cref="CreateLabelResponse"/></returns>
        public CreateLabelResponse CreateLabelSync(CreateLabelRequest req)
        {
             JsonResponseModel<CreateLabelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLabel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLabelResponse>>(strResp);
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
        /// 新建DID根据私钥生成Tdid
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPrivateKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPrivateKeyResponse"/></returns>
        public async Task<CreateTDidByPrivateKeyResponse> CreateTDidByPrivateKey(CreateTDidByPrivateKeyRequest req)
        {
             JsonResponseModel<CreateTDidByPrivateKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTDidByPrivateKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTDidByPrivateKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建DID根据私钥生成Tdid
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPrivateKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPrivateKeyResponse"/></returns>
        public CreateTDidByPrivateKeyResponse CreateTDidByPrivateKeySync(CreateTDidByPrivateKeyRequest req)
        {
             JsonResponseModel<CreateTDidByPrivateKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTDidByPrivateKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTDidByPrivateKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  新建DID根据公钥生成Tdid
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPublicKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPublicKeyResponse"/></returns>
        public async Task<CreateTDidByPublicKeyResponse> CreateTDidByPublicKey(CreateTDidByPublicKeyRequest req)
        {
             JsonResponseModel<CreateTDidByPublicKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTDidByPublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTDidByPublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  新建DID根据公钥生成Tdid
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPublicKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPublicKeyResponse"/></returns>
        public CreateTDidByPublicKeyResponse CreateTDidByPublicKeySync(CreateTDidByPublicKeyRequest req)
        {
             JsonResponseModel<CreateTDidByPublicKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTDidByPublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTDidByPublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过Name部署TDID合约
        /// </summary>
        /// <param name="req"><see cref="DeployByNameRequest"/></param>
        /// <returns><see cref="DeployByNameResponse"/></returns>
        public async Task<DeployByNameResponse> DeployByName(DeployByNameRequest req)
        {
             JsonResponseModel<DeployByNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeployByName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployByNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过Name部署TDID合约
        /// </summary>
        /// <param name="req"><see cref="DeployByNameRequest"/></param>
        /// <returns><see cref="DeployByNameResponse"/></returns>
        public DeployByNameResponse DeployByNameSync(DeployByNameRequest req)
        {
             JsonResponseModel<DeployByNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeployByName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployByNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证模版下载
        /// </summary>
        /// <param name="req"><see cref="DownCptRequest"/></param>
        /// <returns><see cref="DownCptResponse"/></returns>
        public async Task<DownCptResponse> DownCpt(DownCptRequest req)
        {
             JsonResponseModel<DownCptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownCpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownCptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证模版下载
        /// </summary>
        /// <param name="req"><see cref="DownCptRequest"/></param>
        /// <returns><see cref="DownCptResponse"/></returns>
        public DownCptResponse DownCptSync(DownCptRequest req)
        {
             JsonResponseModel<DownCptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownCpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownCptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用合约
        /// </summary>
        /// <param name="req"><see cref="EnableHashRequest"/></param>
        /// <returns><see cref="EnableHashResponse"/></returns>
        public async Task<EnableHashResponse> EnableHash(EnableHashRequest req)
        {
             JsonResponseModel<EnableHashResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableHash");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableHashResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用合约
        /// </summary>
        /// <param name="req"><see cref="EnableHashRequest"/></param>
        /// <returns><see cref="EnableHashResponse"/></returns>
        public EnableHashResponse EnableHashSync(EnableHashRequest req)
        {
             JsonResponseModel<EnableHashResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableHash");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableHashResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本机构DID详情
        /// </summary>
        /// <param name="req"><see cref="GetAgencyTDidRequest"/></param>
        /// <returns><see cref="GetAgencyTDidResponse"/></returns>
        public async Task<GetAgencyTDidResponse> GetAgencyTDid(GetAgencyTDidRequest req)
        {
             JsonResponseModel<GetAgencyTDidResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAgencyTDid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAgencyTDidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本机构DID详情
        /// </summary>
        /// <param name="req"><see cref="GetAgencyTDidRequest"/></param>
        /// <returns><see cref="GetAgencyTDidResponse"/></returns>
        public GetAgencyTDidResponse GetAgencyTDidSync(GetAgencyTDidRequest req)
        {
             JsonResponseModel<GetAgencyTDidResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAgencyTDid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAgencyTDidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 权威机构列表
        /// </summary>
        /// <param name="req"><see cref="GetAuthoritiesListRequest"/></param>
        /// <returns><see cref="GetAuthoritiesListResponse"/></returns>
        public async Task<GetAuthoritiesListResponse> GetAuthoritiesList(GetAuthoritiesListRequest req)
        {
             JsonResponseModel<GetAuthoritiesListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAuthoritiesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAuthoritiesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 权威机构列表
        /// </summary>
        /// <param name="req"><see cref="GetAuthoritiesListRequest"/></param>
        /// <returns><see cref="GetAuthoritiesListResponse"/></returns>
        public GetAuthoritiesListResponse GetAuthoritiesListSync(GetAuthoritiesListRequest req)
        {
             JsonResponseModel<GetAuthoritiesListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAuthoritiesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAuthoritiesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取权威机构信息
        /// </summary>
        /// <param name="req"><see cref="GetAuthorityIssuerRequest"/></param>
        /// <returns><see cref="GetAuthorityIssuerResponse"/></returns>
        public async Task<GetAuthorityIssuerResponse> GetAuthorityIssuer(GetAuthorityIssuerRequest req)
        {
             JsonResponseModel<GetAuthorityIssuerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAuthorityIssuer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAuthorityIssuerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取权威机构信息
        /// </summary>
        /// <param name="req"><see cref="GetAuthorityIssuerRequest"/></param>
        /// <returns><see cref="GetAuthorityIssuerResponse"/></returns>
        public GetAuthorityIssuerResponse GetAuthorityIssuerSync(GetAuthorityIssuerRequest req)
        {
             JsonResponseModel<GetAuthorityIssuerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAuthorityIssuer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAuthorityIssuerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取联盟bcos网络列表
        /// </summary>
        /// <param name="req"><see cref="GetConsortiumClusterListRequest"/></param>
        /// <returns><see cref="GetConsortiumClusterListResponse"/></returns>
        public async Task<GetConsortiumClusterListResponse> GetConsortiumClusterList(GetConsortiumClusterListRequest req)
        {
             JsonResponseModel<GetConsortiumClusterListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetConsortiumClusterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetConsortiumClusterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取联盟bcos网络列表
        /// </summary>
        /// <param name="req"><see cref="GetConsortiumClusterListRequest"/></param>
        /// <returns><see cref="GetConsortiumClusterListResponse"/></returns>
        public GetConsortiumClusterListResponse GetConsortiumClusterListSync(GetConsortiumClusterListRequest req)
        {
             JsonResponseModel<GetConsortiumClusterListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetConsortiumClusterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetConsortiumClusterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取联盟列表
        /// </summary>
        /// <param name="req"><see cref="GetConsortiumListRequest"/></param>
        /// <returns><see cref="GetConsortiumListResponse"/></returns>
        public async Task<GetConsortiumListResponse> GetConsortiumList(GetConsortiumListRequest req)
        {
             JsonResponseModel<GetConsortiumListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetConsortiumList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetConsortiumListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取联盟列表
        /// </summary>
        /// <param name="req"><see cref="GetConsortiumListRequest"/></param>
        /// <returns><see cref="GetConsortiumListResponse"/></returns>
        public GetConsortiumListResponse GetConsortiumListSync(GetConsortiumListRequest req)
        {
             JsonResponseModel<GetConsortiumListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetConsortiumList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetConsortiumListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证模版详情
        /// </summary>
        /// <param name="req"><see cref="GetCptInfoRequest"/></param>
        /// <returns><see cref="GetCptInfoResponse"/></returns>
        public async Task<GetCptInfoResponse> GetCptInfo(GetCptInfoRequest req)
        {
             JsonResponseModel<GetCptInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCptInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCptInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证模版详情
        /// </summary>
        /// <param name="req"><see cref="GetCptInfoRequest"/></param>
        /// <returns><see cref="GetCptInfoResponse"/></returns>
        public GetCptInfoResponse GetCptInfoSync(GetCptInfoRequest req)
        {
             JsonResponseModel<GetCptInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCptInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCptInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证模版列表
        /// </summary>
        /// <param name="req"><see cref="GetCptListRequest"/></param>
        /// <returns><see cref="GetCptListResponse"/></returns>
        public async Task<GetCptListResponse> GetCptList(GetCptListRequest req)
        {
             JsonResponseModel<GetCptListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCptList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCptListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证模版列表
        /// </summary>
        /// <param name="req"><see cref="GetCptListRequest"/></param>
        /// <returns><see cref="GetCptListResponse"/></returns>
        public GetCptListResponse GetCptListSync(GetCptListRequest req)
        {
             JsonResponseModel<GetCptListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCptList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCptListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证颁发按机构排行
        /// </summary>
        /// <param name="req"><see cref="GetCredentialCptRankRequest"/></param>
        /// <returns><see cref="GetCredentialCptRankResponse"/></returns>
        public async Task<GetCredentialCptRankResponse> GetCredentialCptRank(GetCredentialCptRankRequest req)
        {
             JsonResponseModel<GetCredentialCptRankResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCredentialCptRank");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCredentialCptRankResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证颁发按机构排行
        /// </summary>
        /// <param name="req"><see cref="GetCredentialCptRankRequest"/></param>
        /// <returns><see cref="GetCredentialCptRankResponse"/></returns>
        public GetCredentialCptRankResponse GetCredentialCptRankSync(GetCredentialCptRankRequest req)
        {
             JsonResponseModel<GetCredentialCptRankResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCredentialCptRank");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCredentialCptRankResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证颁发按机构排行
        /// </summary>
        /// <param name="req"><see cref="GetCredentialIssueRankRequest"/></param>
        /// <returns><see cref="GetCredentialIssueRankResponse"/></returns>
        public async Task<GetCredentialIssueRankResponse> GetCredentialIssueRank(GetCredentialIssueRankRequest req)
        {
             JsonResponseModel<GetCredentialIssueRankResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCredentialIssueRank");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCredentialIssueRankResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证颁发按机构排行
        /// </summary>
        /// <param name="req"><see cref="GetCredentialIssueRankRequest"/></param>
        /// <returns><see cref="GetCredentialIssueRankResponse"/></returns>
        public GetCredentialIssueRankResponse GetCredentialIssueRankSync(GetCredentialIssueRankRequest req)
        {
             JsonResponseModel<GetCredentialIssueRankResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCredentialIssueRank");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCredentialIssueRankResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证颁发趋势
        /// </summary>
        /// <param name="req"><see cref="GetCredentialIssueTrendRequest"/></param>
        /// <returns><see cref="GetCredentialIssueTrendResponse"/></returns>
        public async Task<GetCredentialIssueTrendResponse> GetCredentialIssueTrend(GetCredentialIssueTrendRequest req)
        {
             JsonResponseModel<GetCredentialIssueTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCredentialIssueTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCredentialIssueTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证颁发趋势
        /// </summary>
        /// <param name="req"><see cref="GetCredentialIssueTrendRequest"/></param>
        /// <returns><see cref="GetCredentialIssueTrendResponse"/></returns>
        public GetCredentialIssueTrendResponse GetCredentialIssueTrendSync(GetCredentialIssueTrendRequest req)
        {
             JsonResponseModel<GetCredentialIssueTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCredentialIssueTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCredentialIssueTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取凭证链上状态信息
        /// </summary>
        /// <param name="req"><see cref="GetCredentialStatusRequest"/></param>
        /// <returns><see cref="GetCredentialStatusResponse"/></returns>
        public async Task<GetCredentialStatusResponse> GetCredentialStatus(GetCredentialStatusRequest req)
        {
             JsonResponseModel<GetCredentialStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCredentialStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCredentialStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取凭证链上状态信息
        /// </summary>
        /// <param name="req"><see cref="GetCredentialStatusRequest"/></param>
        /// <returns><see cref="GetCredentialStatusResponse"/></returns>
        public GetCredentialStatusResponse GetCredentialStatusSync(GetCredentialStatusRequest req)
        {
             JsonResponseModel<GetCredentialStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCredentialStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCredentialStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 概览
        /// </summary>
        /// <param name="req"><see cref="GetDataPanelRequest"/></param>
        /// <returns><see cref="GetDataPanelResponse"/></returns>
        public async Task<GetDataPanelResponse> GetDataPanel(GetDataPanelRequest req)
        {
             JsonResponseModel<GetDataPanelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDataPanel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDataPanelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 概览
        /// </summary>
        /// <param name="req"><see cref="GetDataPanelRequest"/></param>
        /// <returns><see cref="GetDataPanelResponse"/></returns>
        public GetDataPanelResponse GetDataPanelSync(GetDataPanelRequest req)
        {
             JsonResponseModel<GetDataPanelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDataPanel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDataPanelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合约部署详情
        /// </summary>
        /// <param name="req"><see cref="GetDeployInfoRequest"/></param>
        /// <returns><see cref="GetDeployInfoResponse"/></returns>
        public async Task<GetDeployInfoResponse> GetDeployInfo(GetDeployInfoRequest req)
        {
             JsonResponseModel<GetDeployInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDeployInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeployInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合约部署详情
        /// </summary>
        /// <param name="req"><see cref="GetDeployInfoRequest"/></param>
        /// <returns><see cref="GetDeployInfoResponse"/></returns>
        public GetDeployInfoResponse GetDeployInfoSync(GetDeployInfoRequest req)
        {
             JsonResponseModel<GetDeployInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDeployInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeployInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合约部署列表
        /// </summary>
        /// <param name="req"><see cref="GetDeployListRequest"/></param>
        /// <returns><see cref="GetDeployListResponse"/></returns>
        public async Task<GetDeployListResponse> GetDeployList(GetDeployListRequest req)
        {
             JsonResponseModel<GetDeployListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDeployList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeployListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合约部署列表
        /// </summary>
        /// <param name="req"><see cref="GetDeployListRequest"/></param>
        /// <returns><see cref="GetDeployListResponse"/></returns>
        public GetDeployListResponse GetDeployListSync(GetDeployListRequest req)
        {
             JsonResponseModel<GetDeployListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDeployList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeployListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DID区块链网络详情
        /// </summary>
        /// <param name="req"><see cref="GetDidClusterDetailRequest"/></param>
        /// <returns><see cref="GetDidClusterDetailResponse"/></returns>
        public async Task<GetDidClusterDetailResponse> GetDidClusterDetail(GetDidClusterDetailRequest req)
        {
             JsonResponseModel<GetDidClusterDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDidClusterDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidClusterDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DID区块链网络详情
        /// </summary>
        /// <param name="req"><see cref="GetDidClusterDetailRequest"/></param>
        /// <returns><see cref="GetDidClusterDetailResponse"/></returns>
        public GetDidClusterDetailResponse GetDidClusterDetailSync(GetDidClusterDetailRequest req)
        {
             JsonResponseModel<GetDidClusterDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDidClusterDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidClusterDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户的DID网络列表
        /// </summary>
        /// <param name="req"><see cref="GetDidClusterListRequest"/></param>
        /// <returns><see cref="GetDidClusterListResponse"/></returns>
        public async Task<GetDidClusterListResponse> GetDidClusterList(GetDidClusterListRequest req)
        {
             JsonResponseModel<GetDidClusterListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDidClusterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidClusterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户的DID网络列表
        /// </summary>
        /// <param name="req"><see cref="GetDidClusterListRequest"/></param>
        /// <returns><see cref="GetDidClusterListResponse"/></returns>
        public GetDidClusterListResponse GetDidClusterListSync(GetDidClusterListRequest req)
        {
             JsonResponseModel<GetDidClusterListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDidClusterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidClusterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DID详情
        /// </summary>
        /// <param name="req"><see cref="GetDidDetailRequest"/></param>
        /// <returns><see cref="GetDidDetailResponse"/></returns>
        public async Task<GetDidDetailResponse> GetDidDetail(GetDidDetailRequest req)
        {
             JsonResponseModel<GetDidDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDidDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DID详情
        /// </summary>
        /// <param name="req"><see cref="GetDidDetailRequest"/></param>
        /// <returns><see cref="GetDidDetailResponse"/></returns>
        public GetDidDetailResponse GetDidDetailSync(GetDidDetailRequest req)
        {
             JsonResponseModel<GetDidDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDidDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看DID文档
        /// </summary>
        /// <param name="req"><see cref="GetDidDocumentRequest"/></param>
        /// <returns><see cref="GetDidDocumentResponse"/></returns>
        public async Task<GetDidDocumentResponse> GetDidDocument(GetDidDocumentRequest req)
        {
             JsonResponseModel<GetDidDocumentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDidDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看DID文档
        /// </summary>
        /// <param name="req"><see cref="GetDidDocumentRequest"/></param>
        /// <returns><see cref="GetDidDocumentResponse"/></returns>
        public GetDidDocumentResponse GetDidDocumentSync(GetDidDocumentRequest req)
        {
             JsonResponseModel<GetDidDocumentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDidDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DID列表
        /// </summary>
        /// <param name="req"><see cref="GetDidListRequest"/></param>
        /// <returns><see cref="GetDidListResponse"/></returns>
        public async Task<GetDidListResponse> GetDidList(GetDidListRequest req)
        {
             JsonResponseModel<GetDidListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDidList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DID列表
        /// </summary>
        /// <param name="req"><see cref="GetDidListRequest"/></param>
        /// <returns><see cref="GetDidListResponse"/></returns>
        public GetDidListResponse GetDidListSync(GetDidListRequest req)
        {
             JsonResponseModel<GetDidListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDidList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DID注册趋势
        /// </summary>
        /// <param name="req"><see cref="GetDidRegisterTrendRequest"/></param>
        /// <returns><see cref="GetDidRegisterTrendResponse"/></returns>
        public async Task<GetDidRegisterTrendResponse> GetDidRegisterTrend(GetDidRegisterTrendRequest req)
        {
             JsonResponseModel<GetDidRegisterTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDidRegisterTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidRegisterTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DID注册趋势
        /// </summary>
        /// <param name="req"><see cref="GetDidRegisterTrendRequest"/></param>
        /// <returns><see cref="GetDidRegisterTrendResponse"/></returns>
        public GetDidRegisterTrendResponse GetDidRegisterTrendSync(GetDidRegisterTrendRequest req)
        {
             JsonResponseModel<GetDidRegisterTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDidRegisterTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidRegisterTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DID服务详情
        /// </summary>
        /// <param name="req"><see cref="GetDidServiceDetailRequest"/></param>
        /// <returns><see cref="GetDidServiceDetailResponse"/></returns>
        public async Task<GetDidServiceDetailResponse> GetDidServiceDetail(GetDidServiceDetailRequest req)
        {
             JsonResponseModel<GetDidServiceDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDidServiceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidServiceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DID服务详情
        /// </summary>
        /// <param name="req"><see cref="GetDidServiceDetailRequest"/></param>
        /// <returns><see cref="GetDidServiceDetailResponse"/></returns>
        public GetDidServiceDetailResponse GetDidServiceDetailSync(GetDidServiceDetailRequest req)
        {
             JsonResponseModel<GetDidServiceDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDidServiceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidServiceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DID服务列表
        /// </summary>
        /// <param name="req"><see cref="GetDidServiceListRequest"/></param>
        /// <returns><see cref="GetDidServiceListResponse"/></returns>
        public async Task<GetDidServiceListResponse> GetDidServiceList(GetDidServiceListRequest req)
        {
             JsonResponseModel<GetDidServiceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDidServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DID服务列表
        /// </summary>
        /// <param name="req"><see cref="GetDidServiceListRequest"/></param>
        /// <returns><see cref="GetDidServiceListResponse"/></returns>
        public GetDidServiceListResponse GetDidServiceListSync(GetDidServiceListRequest req)
        {
             JsonResponseModel<GetDidServiceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDidServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDidServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 主群组配置列表
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public async Task<GetGroupListResponse> GetGroupList(GetGroupListRequest req)
        {
             JsonResponseModel<GetGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 主群组配置列表
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public GetGroupListResponse GetGroupListSync(GetGroupListRequest req)
        {
             JsonResponseModel<GetGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 标签列表
        /// </summary>
        /// <param name="req"><see cref="GetLabelListRequest"/></param>
        /// <returns><see cref="GetLabelListResponse"/></returns>
        public async Task<GetLabelListResponse> GetLabelList(GetLabelListRequest req)
        {
             JsonResponseModel<GetLabelListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetLabelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLabelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 标签列表
        /// </summary>
        /// <param name="req"><see cref="GetLabelListRequest"/></param>
        /// <returns><see cref="GetLabelListResponse"/></returns>
        public GetLabelListResponse GetLabelListSync(GetLabelListRequest req)
        {
             JsonResponseModel<GetLabelListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetLabelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLabelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 披露策略Policy管理列表
        /// </summary>
        /// <param name="req"><see cref="GetPolicyListRequest"/></param>
        /// <returns><see cref="GetPolicyListResponse"/></returns>
        public async Task<GetPolicyListResponse> GetPolicyList(GetPolicyListRequest req)
        {
             JsonResponseModel<GetPolicyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 披露策略Policy管理列表
        /// </summary>
        /// <param name="req"><see cref="GetPolicyListRequest"/></param>
        /// <returns><see cref="GetPolicyListResponse"/></returns>
        public GetPolicyListResponse GetPolicyListSync(GetPolicyListRequest req)
        {
             JsonResponseModel<GetPolicyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看公钥
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public async Task<GetPublicKeyResponse> GetPublicKey(GetPublicKeyRequest req)
        {
             JsonResponseModel<GetPublicKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看公钥
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public GetPublicKeyResponse GetPublicKeySync(GetPublicKeyRequest req)
        {
             JsonResponseModel<GetPublicKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 披露策略Policy查看
        /// </summary>
        /// <param name="req"><see cref="QueryPolicyRequest"/></param>
        /// <returns><see cref="QueryPolicyResponse"/></returns>
        public async Task<QueryPolicyResponse> QueryPolicy(QueryPolicyRequest req)
        {
             JsonResponseModel<QueryPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 披露策略Policy查看
        /// </summary>
        /// <param name="req"><see cref="QueryPolicyRequest"/></param>
        /// <returns><see cref="QueryPolicyResponse"/></returns>
        public QueryPolicyResponse QueryPolicySync(QueryPolicyRequest req)
        {
             JsonResponseModel<QueryPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 认证权威机构
        /// </summary>
        /// <param name="req"><see cref="RecognizeAuthorityIssuerRequest"/></param>
        /// <returns><see cref="RecognizeAuthorityIssuerResponse"/></returns>
        public async Task<RecognizeAuthorityIssuerResponse> RecognizeAuthorityIssuer(RecognizeAuthorityIssuerRequest req)
        {
             JsonResponseModel<RecognizeAuthorityIssuerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecognizeAuthorityIssuer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeAuthorityIssuerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 认证权威机构
        /// </summary>
        /// <param name="req"><see cref="RecognizeAuthorityIssuerRequest"/></param>
        /// <returns><see cref="RecognizeAuthorityIssuerResponse"/></returns>
        public RecognizeAuthorityIssuerResponse RecognizeAuthorityIssuerSync(RecognizeAuthorityIssuerRequest req)
        {
             JsonResponseModel<RecognizeAuthorityIssuerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecognizeAuthorityIssuer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeAuthorityIssuerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 披露策略Policy注册
        /// </summary>
        /// <param name="req"><see cref="RegisterClaimPolicyRequest"/></param>
        /// <returns><see cref="RegisterClaimPolicyResponse"/></returns>
        public async Task<RegisterClaimPolicyResponse> RegisterClaimPolicy(RegisterClaimPolicyRequest req)
        {
             JsonResponseModel<RegisterClaimPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterClaimPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterClaimPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 披露策略Policy注册
        /// </summary>
        /// <param name="req"><see cref="RegisterClaimPolicyRequest"/></param>
        /// <returns><see cref="RegisterClaimPolicyResponse"/></returns>
        public RegisterClaimPolicyResponse RegisterClaimPolicySync(RegisterClaimPolicyRequest req)
        {
             JsonResponseModel<RegisterClaimPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterClaimPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterClaimPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证模版新建
        /// </summary>
        /// <param name="req"><see cref="RegisterCptRequest"/></param>
        /// <returns><see cref="RegisterCptResponse"/></returns>
        public async Task<RegisterCptResponse> RegisterCpt(RegisterCptRequest req)
        {
             JsonResponseModel<RegisterCptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterCpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterCptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 凭证模版新建
        /// </summary>
        /// <param name="req"><see cref="RegisterCptRequest"/></param>
        /// <returns><see cref="RegisterCptResponse"/></returns>
        public RegisterCptResponse RegisterCptSync(RegisterCptRequest req)
        {
             JsonResponseModel<RegisterCptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterCpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterCptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册为权威机构
        /// </summary>
        /// <param name="req"><see cref="RegisterIssuerRequest"/></param>
        /// <returns><see cref="RegisterIssuerResponse"/></returns>
        public async Task<RegisterIssuerResponse> RegisterIssuer(RegisterIssuerRequest req)
        {
             JsonResponseModel<RegisterIssuerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterIssuer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterIssuerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册为权威机构
        /// </summary>
        /// <param name="req"><see cref="RegisterIssuerRequest"/></param>
        /// <returns><see cref="RegisterIssuerResponse"/></returns>
        public RegisterIssuerResponse RegisterIssuerSync(RegisterIssuerRequest req)
        {
             JsonResponseModel<RegisterIssuerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterIssuer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterIssuerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除合约
        /// </summary>
        /// <param name="req"><see cref="RemoveHashRequest"/></param>
        /// <returns><see cref="RemoveHashResponse"/></returns>
        public async Task<RemoveHashResponse> RemoveHash(RemoveHashRequest req)
        {
             JsonResponseModel<RemoveHashResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveHash");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveHashResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除合约
        /// </summary>
        /// <param name="req"><see cref="RemoveHashRequest"/></param>
        /// <returns><see cref="RemoveHashResponse"/></returns>
        public RemoveHashResponse RemoveHashSync(RemoveHashRequest req)
        {
             JsonResponseModel<RemoveHashResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveHash");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveHashResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置凭证链上状态
        /// </summary>
        /// <param name="req"><see cref="SetCredentialStatusRequest"/></param>
        /// <returns><see cref="SetCredentialStatusResponse"/></returns>
        public async Task<SetCredentialStatusResponse> SetCredentialStatus(SetCredentialStatusRequest req)
        {
             JsonResponseModel<SetCredentialStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetCredentialStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCredentialStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置凭证链上状态
        /// </summary>
        /// <param name="req"><see cref="SetCredentialStatusRequest"/></param>
        /// <returns><see cref="SetCredentialStatusResponse"/></returns>
        public SetCredentialStatusResponse SetCredentialStatusSync(SetCredentialStatusRequest req)
        {
             JsonResponseModel<SetCredentialStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetCredentialStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCredentialStatusResponse>>(strResp);
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

        /// <summary>
        /// 验证购买
        /// </summary>
        /// <param name="req"><see cref="VerifyPurchaseRequest"/></param>
        /// <returns><see cref="VerifyPurchaseResponse"/></returns>
        public async Task<VerifyPurchaseResponse> VerifyPurchase(VerifyPurchaseRequest req)
        {
             JsonResponseModel<VerifyPurchaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyPurchase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyPurchaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证购买
        /// </summary>
        /// <param name="req"><see cref="VerifyPurchaseRequest"/></param>
        /// <returns><see cref="VerifyPurchaseResponse"/></returns>
        public VerifyPurchaseResponse VerifyPurchaseSync(VerifyPurchaseRequest req)
        {
             JsonResponseModel<VerifyPurchaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyPurchase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyPurchaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
