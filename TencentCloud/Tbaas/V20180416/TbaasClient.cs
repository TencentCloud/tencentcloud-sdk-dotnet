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

namespace TencentCloud.Tbaas.V20180416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tbaas.V20180416.Models;

   public class TbaasClient : AbstractClient{

       private const string endpoint = "tbaas.tencentcloudapi.com";
       private const string version = "2018-04-16";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TbaasClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TbaasClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 申请用户证书
        /// </summary>
        /// <param name="req"><see cref="ApplyUserCertRequest"/></param>
        /// <returns><see cref="ApplyUserCertResponse"/></returns>
        public async Task<ApplyUserCertResponse> ApplyUserCert(ApplyUserCertRequest req)
        {
             JsonResponseModel<ApplyUserCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyUserCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyUserCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 申请用户证书
        /// </summary>
        /// <param name="req"><see cref="ApplyUserCertRequest"/></param>
        /// <returns><see cref="ApplyUserCertResponse"/></returns>
        public ApplyUserCertResponse ApplyUserCertSync(ApplyUserCertRequest req)
        {
             JsonResponseModel<ApplyUserCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyUserCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyUserCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建并安装合约
        /// </summary>
        /// <param name="req"><see cref="CreateChaincodeAndInstallForUserRequest"/></param>
        /// <returns><see cref="CreateChaincodeAndInstallForUserResponse"/></returns>
        public async Task<CreateChaincodeAndInstallForUserResponse> CreateChaincodeAndInstallForUser(CreateChaincodeAndInstallForUserRequest req)
        {
             JsonResponseModel<CreateChaincodeAndInstallForUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateChaincodeAndInstallForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateChaincodeAndInstallForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建并安装合约
        /// </summary>
        /// <param name="req"><see cref="CreateChaincodeAndInstallForUserRequest"/></param>
        /// <returns><see cref="CreateChaincodeAndInstallForUserResponse"/></returns>
        public CreateChaincodeAndInstallForUserResponse CreateChaincodeAndInstallForUserSync(CreateChaincodeAndInstallForUserRequest req)
        {
             JsonResponseModel<CreateChaincodeAndInstallForUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateChaincodeAndInstallForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateChaincodeAndInstallForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 动态部署并发布Bcos合约
        /// </summary>
        /// <param name="req"><see cref="DeployDynamicBcosContractRequest"/></param>
        /// <returns><see cref="DeployDynamicBcosContractResponse"/></returns>
        public async Task<DeployDynamicBcosContractResponse> DeployDynamicBcosContract(DeployDynamicBcosContractRequest req)
        {
             JsonResponseModel<DeployDynamicBcosContractResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeployDynamicBcosContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployDynamicBcosContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 动态部署并发布Bcos合约
        /// </summary>
        /// <param name="req"><see cref="DeployDynamicBcosContractRequest"/></param>
        /// <returns><see cref="DeployDynamicBcosContractResponse"/></returns>
        public DeployDynamicBcosContractResponse DeployDynamicBcosContractSync(DeployDynamicBcosContractRequest req)
        {
             JsonResponseModel<DeployDynamicBcosContractResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeployDynamicBcosContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployDynamicBcosContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下载用户证书
        /// </summary>
        /// <param name="req"><see cref="DownloadUserCertRequest"/></param>
        /// <returns><see cref="DownloadUserCertResponse"/></returns>
        public async Task<DownloadUserCertResponse> DownloadUserCert(DownloadUserCertRequest req)
        {
             JsonResponseModel<DownloadUserCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadUserCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadUserCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下载用户证书
        /// </summary>
        /// <param name="req"><see cref="DownloadUserCertRequest"/></param>
        /// <returns><see cref="DownloadUserCertResponse"/></returns>
        public DownloadUserCertResponse DownloadUserCertSync(DownloadUserCertRequest req)
        {
             JsonResponseModel<DownloadUserCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadUserCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadUserCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用块高查询Bcos区块信息
        /// </summary>
        /// <param name="req"><see cref="GetBcosBlockByNumberRequest"/></param>
        /// <returns><see cref="GetBcosBlockByNumberResponse"/></returns>
        public async Task<GetBcosBlockByNumberResponse> GetBcosBlockByNumber(GetBcosBlockByNumberRequest req)
        {
             JsonResponseModel<GetBcosBlockByNumberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetBcosBlockByNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBcosBlockByNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用块高查询Bcos区块信息
        /// </summary>
        /// <param name="req"><see cref="GetBcosBlockByNumberRequest"/></param>
        /// <returns><see cref="GetBcosBlockByNumberResponse"/></returns>
        public GetBcosBlockByNumberResponse GetBcosBlockByNumberSync(GetBcosBlockByNumberRequest req)
        {
             JsonResponseModel<GetBcosBlockByNumberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetBcosBlockByNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBcosBlockByNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Bcos分页查询当前群组下的区块列表
        /// </summary>
        /// <param name="req"><see cref="GetBcosBlockListRequest"/></param>
        /// <returns><see cref="GetBcosBlockListResponse"/></returns>
        public async Task<GetBcosBlockListResponse> GetBcosBlockList(GetBcosBlockListRequest req)
        {
             JsonResponseModel<GetBcosBlockListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetBcosBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBcosBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Bcos分页查询当前群组下的区块列表
        /// </summary>
        /// <param name="req"><see cref="GetBcosBlockListRequest"/></param>
        /// <returns><see cref="GetBcosBlockListResponse"/></returns>
        public GetBcosBlockListResponse GetBcosBlockListSync(GetBcosBlockListRequest req)
        {
             JsonResponseModel<GetBcosBlockListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetBcosBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBcosBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Bcos根据交易哈希查看交易详细信息
        /// </summary>
        /// <param name="req"><see cref="GetBcosTransByHashRequest"/></param>
        /// <returns><see cref="GetBcosTransByHashResponse"/></returns>
        public async Task<GetBcosTransByHashResponse> GetBcosTransByHash(GetBcosTransByHashRequest req)
        {
             JsonResponseModel<GetBcosTransByHashResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetBcosTransByHash");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBcosTransByHashResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Bcos根据交易哈希查看交易详细信息
        /// </summary>
        /// <param name="req"><see cref="GetBcosTransByHashRequest"/></param>
        /// <returns><see cref="GetBcosTransByHashResponse"/></returns>
        public GetBcosTransByHashResponse GetBcosTransByHashSync(GetBcosTransByHashRequest req)
        {
             JsonResponseModel<GetBcosTransByHashResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetBcosTransByHash");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBcosTransByHashResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Bcos分页查询当前群组的交易信息列表
        /// </summary>
        /// <param name="req"><see cref="GetBcosTransListRequest"/></param>
        /// <returns><see cref="GetBcosTransListResponse"/></returns>
        public async Task<GetBcosTransListResponse> GetBcosTransList(GetBcosTransListRequest req)
        {
             JsonResponseModel<GetBcosTransListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetBcosTransList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBcosTransListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Bcos分页查询当前群组的交易信息列表
        /// </summary>
        /// <param name="req"><see cref="GetBcosTransListRequest"/></param>
        /// <returns><see cref="GetBcosTransListResponse"/></returns>
        public GetBcosTransListResponse GetBcosTransListSync(GetBcosTransListRequest req)
        {
             JsonResponseModel<GetBcosTransListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetBcosTransList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBcosTransListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看当前网络下的所有区块列表，分页展示
        /// </summary>
        /// <param name="req"><see cref="GetBlockListRequest"/></param>
        /// <returns><see cref="GetBlockListResponse"/></returns>
        public async Task<GetBlockListResponse> GetBlockList(GetBlockListRequest req)
        {
             JsonResponseModel<GetBlockListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看当前网络下的所有区块列表，分页展示
        /// </summary>
        /// <param name="req"><see cref="GetBlockListRequest"/></param>
        /// <returns><see cref="GetBlockListResponse"/></returns>
        public GetBlockListResponse GetBlockListSync(GetBlockListRequest req)
        {
             JsonResponseModel<GetBlockListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取区块内的交易列表
        /// </summary>
        /// <param name="req"><see cref="GetBlockTransactionListForUserRequest"/></param>
        /// <returns><see cref="GetBlockTransactionListForUserResponse"/></returns>
        public async Task<GetBlockTransactionListForUserResponse> GetBlockTransactionListForUser(GetBlockTransactionListForUserRequest req)
        {
             JsonResponseModel<GetBlockTransactionListForUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetBlockTransactionListForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBlockTransactionListForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取区块内的交易列表
        /// </summary>
        /// <param name="req"><see cref="GetBlockTransactionListForUserRequest"/></param>
        /// <returns><see cref="GetBlockTransactionListForUserResponse"/></returns>
        public GetBlockTransactionListForUserResponse GetBlockTransactionListForUserSync(GetBlockTransactionListForUserRequest req)
        {
             JsonResponseModel<GetBlockTransactionListForUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetBlockTransactionListForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBlockTransactionListForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取合约编译日志
        /// </summary>
        /// <param name="req"><see cref="GetChaincodeCompileLogForUserRequest"/></param>
        /// <returns><see cref="GetChaincodeCompileLogForUserResponse"/></returns>
        public async Task<GetChaincodeCompileLogForUserResponse> GetChaincodeCompileLogForUser(GetChaincodeCompileLogForUserRequest req)
        {
             JsonResponseModel<GetChaincodeCompileLogForUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetChaincodeCompileLogForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetChaincodeCompileLogForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取合约编译日志
        /// </summary>
        /// <param name="req"><see cref="GetChaincodeCompileLogForUserRequest"/></param>
        /// <returns><see cref="GetChaincodeCompileLogForUserResponse"/></returns>
        public GetChaincodeCompileLogForUserResponse GetChaincodeCompileLogForUserSync(GetChaincodeCompileLogForUserRequest req)
        {
             JsonResponseModel<GetChaincodeCompileLogForUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetChaincodeCompileLogForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetChaincodeCompileLogForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例化结果查询
        /// </summary>
        /// <param name="req"><see cref="GetChaincodeInitializeResultForUserRequest"/></param>
        /// <returns><see cref="GetChaincodeInitializeResultForUserResponse"/></returns>
        public async Task<GetChaincodeInitializeResultForUserResponse> GetChaincodeInitializeResultForUser(GetChaincodeInitializeResultForUserRequest req)
        {
             JsonResponseModel<GetChaincodeInitializeResultForUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetChaincodeInitializeResultForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetChaincodeInitializeResultForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例化结果查询
        /// </summary>
        /// <param name="req"><see cref="GetChaincodeInitializeResultForUserRequest"/></param>
        /// <returns><see cref="GetChaincodeInitializeResultForUserResponse"/></returns>
        public GetChaincodeInitializeResultForUserResponse GetChaincodeInitializeResultForUserSync(GetChaincodeInitializeResultForUserRequest req)
        {
             JsonResponseModel<GetChaincodeInitializeResultForUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetChaincodeInitializeResultForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetChaincodeInitializeResultForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取合约容器日志
        /// </summary>
        /// <param name="req"><see cref="GetChaincodeLogForUserRequest"/></param>
        /// <returns><see cref="GetChaincodeLogForUserResponse"/></returns>
        public async Task<GetChaincodeLogForUserResponse> GetChaincodeLogForUser(GetChaincodeLogForUserRequest req)
        {
             JsonResponseModel<GetChaincodeLogForUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetChaincodeLogForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetChaincodeLogForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取合约容器日志
        /// </summary>
        /// <param name="req"><see cref="GetChaincodeLogForUserRequest"/></param>
        /// <returns><see cref="GetChaincodeLogForUserResponse"/></returns>
        public GetChaincodeLogForUserResponse GetChaincodeLogForUserSync(GetChaincodeLogForUserRequest req)
        {
             JsonResponseModel<GetChaincodeLogForUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetChaincodeLogForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetChaincodeLogForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取通道列表
        /// </summary>
        /// <param name="req"><see cref="GetChannelListForUserRequest"/></param>
        /// <returns><see cref="GetChannelListForUserResponse"/></returns>
        public async Task<GetChannelListForUserResponse> GetChannelListForUser(GetChannelListForUserRequest req)
        {
             JsonResponseModel<GetChannelListForUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetChannelListForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetChannelListForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取通道列表
        /// </summary>
        /// <param name="req"><see cref="GetChannelListForUserRequest"/></param>
        /// <returns><see cref="GetChannelListForUserResponse"/></returns>
        public GetChannelListForUserResponse GetChannelListForUserSync(GetChannelListForUserRequest req)
        {
             JsonResponseModel<GetChannelListForUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetChannelListForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetChannelListForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取该用户的网络列表。网络信息中包含组织信息，但仅包含该用户所在组织的信息。
        /// </summary>
        /// <param name="req"><see cref="GetClusterListForUserRequest"/></param>
        /// <returns><see cref="GetClusterListForUserResponse"/></returns>
        public async Task<GetClusterListForUserResponse> GetClusterListForUser(GetClusterListForUserRequest req)
        {
             JsonResponseModel<GetClusterListForUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetClusterListForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetClusterListForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取该用户的网络列表。网络信息中包含组织信息，但仅包含该用户所在组织的信息。
        /// </summary>
        /// <param name="req"><see cref="GetClusterListForUserRequest"/></param>
        /// <returns><see cref="GetClusterListForUserResponse"/></returns>
        public GetClusterListForUserResponse GetClusterListForUserSync(GetClusterListForUserRequest req)
        {
             JsonResponseModel<GetClusterListForUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetClusterListForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetClusterListForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取区块链网络概要
        /// </summary>
        /// <param name="req"><see cref="GetClusterSummaryRequest"/></param>
        /// <returns><see cref="GetClusterSummaryResponse"/></returns>
        public async Task<GetClusterSummaryResponse> GetClusterSummary(GetClusterSummaryRequest req)
        {
             JsonResponseModel<GetClusterSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetClusterSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetClusterSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取区块链网络概要
        /// </summary>
        /// <param name="req"><see cref="GetClusterSummaryRequest"/></param>
        /// <returns><see cref="GetClusterSummaryResponse"/></returns>
        public GetClusterSummaryResponse GetClusterSummarySync(GetClusterSummaryRequest req)
        {
             JsonResponseModel<GetClusterSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetClusterSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetClusterSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Invoke异步调用结果查询
        /// </summary>
        /// <param name="req"><see cref="GetInvokeTxRequest"/></param>
        /// <returns><see cref="GetInvokeTxResponse"/></returns>
        public async Task<GetInvokeTxResponse> GetInvokeTx(GetInvokeTxRequest req)
        {
             JsonResponseModel<GetInvokeTxResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetInvokeTx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetInvokeTxResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Invoke异步调用结果查询
        /// </summary>
        /// <param name="req"><see cref="GetInvokeTxRequest"/></param>
        /// <returns><see cref="GetInvokeTxResponse"/></returns>
        public GetInvokeTxResponse GetInvokeTxSync(GetInvokeTxRequest req)
        {
             JsonResponseModel<GetInvokeTxResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetInvokeTx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetInvokeTxResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取最新交易列表
        /// </summary>
        /// <param name="req"><see cref="GetLatesdTransactionListRequest"/></param>
        /// <returns><see cref="GetLatesdTransactionListResponse"/></returns>
        public async Task<GetLatesdTransactionListResponse> GetLatesdTransactionList(GetLatesdTransactionListRequest req)
        {
             JsonResponseModel<GetLatesdTransactionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetLatesdTransactionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLatesdTransactionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取最新交易列表
        /// </summary>
        /// <param name="req"><see cref="GetLatesdTransactionListRequest"/></param>
        /// <returns><see cref="GetLatesdTransactionListResponse"/></returns>
        public GetLatesdTransactionListResponse GetLatesdTransactionListSync(GetLatesdTransactionListRequest req)
        {
             JsonResponseModel<GetLatesdTransactionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetLatesdTransactionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLatesdTransactionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取节点日志
        /// </summary>
        /// <param name="req"><see cref="GetPeerLogForUserRequest"/></param>
        /// <returns><see cref="GetPeerLogForUserResponse"/></returns>
        public async Task<GetPeerLogForUserResponse> GetPeerLogForUser(GetPeerLogForUserRequest req)
        {
             JsonResponseModel<GetPeerLogForUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPeerLogForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPeerLogForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取节点日志
        /// </summary>
        /// <param name="req"><see cref="GetPeerLogForUserRequest"/></param>
        /// <returns><see cref="GetPeerLogForUserResponse"/></returns>
        public GetPeerLogForUserResponse GetPeerLogForUserSync(GetPeerLogForUserRequest req)
        {
             JsonResponseModel<GetPeerLogForUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPeerLogForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPeerLogForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取交易详情
        /// </summary>
        /// <param name="req"><see cref="GetTransactionDetailForUserRequest"/></param>
        /// <returns><see cref="GetTransactionDetailForUserResponse"/></returns>
        public async Task<GetTransactionDetailForUserResponse> GetTransactionDetailForUser(GetTransactionDetailForUserRequest req)
        {
             JsonResponseModel<GetTransactionDetailForUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTransactionDetailForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTransactionDetailForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取交易详情
        /// </summary>
        /// <param name="req"><see cref="GetTransactionDetailForUserRequest"/></param>
        /// <returns><see cref="GetTransactionDetailForUserResponse"/></returns>
        public GetTransactionDetailForUserResponse GetTransactionDetailForUserSync(GetTransactionDetailForUserRequest req)
        {
             JsonResponseModel<GetTransactionDetailForUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTransactionDetailForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTransactionDetailForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例化合约
        /// </summary>
        /// <param name="req"><see cref="InitializeChaincodeForUserRequest"/></param>
        /// <returns><see cref="InitializeChaincodeForUserResponse"/></returns>
        public async Task<InitializeChaincodeForUserResponse> InitializeChaincodeForUser(InitializeChaincodeForUserRequest req)
        {
             JsonResponseModel<InitializeChaincodeForUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InitializeChaincodeForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitializeChaincodeForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例化合约
        /// </summary>
        /// <param name="req"><see cref="InitializeChaincodeForUserRequest"/></param>
        /// <returns><see cref="InitializeChaincodeForUserResponse"/></returns>
        public InitializeChaincodeForUserResponse InitializeChaincodeForUserSync(InitializeChaincodeForUserRequest req)
        {
             JsonResponseModel<InitializeChaincodeForUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InitializeChaincodeForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitializeChaincodeForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增交易
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public async Task<InvokeResponse> Invoke(InvokeRequest req)
        {
             JsonResponseModel<InvokeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Invoke");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增交易
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public InvokeResponse InvokeSync(InvokeRequest req)
        {
             JsonResponseModel<InvokeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Invoke");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 执行Bcos交易，支持动态部署的合约
        /// </summary>
        /// <param name="req"><see cref="InvokeBcosTransRequest"/></param>
        /// <returns><see cref="InvokeBcosTransResponse"/></returns>
        public async Task<InvokeBcosTransResponse> InvokeBcosTrans(InvokeBcosTransRequest req)
        {
             JsonResponseModel<InvokeBcosTransResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InvokeBcosTrans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeBcosTransResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 执行Bcos交易，支持动态部署的合约
        /// </summary>
        /// <param name="req"><see cref="InvokeBcosTransRequest"/></param>
        /// <returns><see cref="InvokeBcosTransResponse"/></returns>
        public InvokeBcosTransResponse InvokeBcosTransSync(InvokeBcosTransRequest req)
        {
             JsonResponseModel<InvokeBcosTransResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InvokeBcosTrans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeBcosTransResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用长安链合约执行交易
        /// </summary>
        /// <param name="req"><see cref="InvokeChainMakerContractRequest"/></param>
        /// <returns><see cref="InvokeChainMakerContractResponse"/></returns>
        public async Task<InvokeChainMakerContractResponse> InvokeChainMakerContract(InvokeChainMakerContractRequest req)
        {
             JsonResponseModel<InvokeChainMakerContractResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InvokeChainMakerContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeChainMakerContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用长安链合约执行交易
        /// </summary>
        /// <param name="req"><see cref="InvokeChainMakerContractRequest"/></param>
        /// <returns><see cref="InvokeChainMakerContractResponse"/></returns>
        public InvokeChainMakerContractResponse InvokeChainMakerContractSync(InvokeChainMakerContractRequest req)
        {
             JsonResponseModel<InvokeChainMakerContractResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InvokeChainMakerContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeChainMakerContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用长安链体验网络合约执行交易
        /// </summary>
        /// <param name="req"><see cref="InvokeChainMakerDemoContractRequest"/></param>
        /// <returns><see cref="InvokeChainMakerDemoContractResponse"/></returns>
        public async Task<InvokeChainMakerDemoContractResponse> InvokeChainMakerDemoContract(InvokeChainMakerDemoContractRequest req)
        {
             JsonResponseModel<InvokeChainMakerDemoContractResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InvokeChainMakerDemoContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeChainMakerDemoContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用长安链体验网络合约执行交易
        /// </summary>
        /// <param name="req"><see cref="InvokeChainMakerDemoContractRequest"/></param>
        /// <returns><see cref="InvokeChainMakerDemoContractResponse"/></returns>
        public InvokeChainMakerDemoContractResponse InvokeChainMakerDemoContractSync(InvokeChainMakerDemoContractRequest req)
        {
             JsonResponseModel<InvokeChainMakerDemoContractResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InvokeChainMakerDemoContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeChainMakerDemoContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询交易
        /// </summary>
        /// <param name="req"><see cref="QueryRequest"/></param>
        /// <returns><see cref="QueryResponse"/></returns>
        public async Task<QueryResponse> Query(QueryRequest req)
        {
             JsonResponseModel<QueryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Query");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询交易
        /// </summary>
        /// <param name="req"><see cref="QueryRequest"/></param>
        /// <returns><see cref="QueryResponse"/></returns>
        public QueryResponse QuerySync(QueryRequest req)
        {
             JsonResponseModel<QueryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Query");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询长安链指定高度区块的交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerBlockTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerBlockTransactionResponse"/></returns>
        public async Task<QueryChainMakerBlockTransactionResponse> QueryChainMakerBlockTransaction(QueryChainMakerBlockTransactionRequest req)
        {
             JsonResponseModel<QueryChainMakerBlockTransactionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryChainMakerBlockTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerBlockTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询长安链指定高度区块的交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerBlockTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerBlockTransactionResponse"/></returns>
        public QueryChainMakerBlockTransactionResponse QueryChainMakerBlockTransactionSync(QueryChainMakerBlockTransactionRequest req)
        {
             JsonResponseModel<QueryChainMakerBlockTransactionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryChainMakerBlockTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerBlockTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用长安链合约查询
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerContractRequest"/></param>
        /// <returns><see cref="QueryChainMakerContractResponse"/></returns>
        public async Task<QueryChainMakerContractResponse> QueryChainMakerContract(QueryChainMakerContractRequest req)
        {
             JsonResponseModel<QueryChainMakerContractResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryChainMakerContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用长安链合约查询
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerContractRequest"/></param>
        /// <returns><see cref="QueryChainMakerContractResponse"/></returns>
        public QueryChainMakerContractResponse QueryChainMakerContractSync(QueryChainMakerContractRequest req)
        {
             JsonResponseModel<QueryChainMakerContractResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryChainMakerContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询长安链体验网络指定高度区块的交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoBlockTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoBlockTransactionResponse"/></returns>
        public async Task<QueryChainMakerDemoBlockTransactionResponse> QueryChainMakerDemoBlockTransaction(QueryChainMakerDemoBlockTransactionRequest req)
        {
             JsonResponseModel<QueryChainMakerDemoBlockTransactionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryChainMakerDemoBlockTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerDemoBlockTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询长安链体验网络指定高度区块的交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoBlockTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoBlockTransactionResponse"/></returns>
        public QueryChainMakerDemoBlockTransactionResponse QueryChainMakerDemoBlockTransactionSync(QueryChainMakerDemoBlockTransactionRequest req)
        {
             JsonResponseModel<QueryChainMakerDemoBlockTransactionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryChainMakerDemoBlockTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerDemoBlockTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用长安链体验网络合约查询
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoContractRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoContractResponse"/></returns>
        public async Task<QueryChainMakerDemoContractResponse> QueryChainMakerDemoContract(QueryChainMakerDemoContractRequest req)
        {
             JsonResponseModel<QueryChainMakerDemoContractResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryChainMakerDemoContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerDemoContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用长安链体验网络合约查询
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoContractRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoContractResponse"/></returns>
        public QueryChainMakerDemoContractResponse QueryChainMakerDemoContractSync(QueryChainMakerDemoContractRequest req)
        {
             JsonResponseModel<QueryChainMakerDemoContractResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryChainMakerDemoContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerDemoContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过交易ID查询长安链体验网络交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoTransactionResponse"/></returns>
        public async Task<QueryChainMakerDemoTransactionResponse> QueryChainMakerDemoTransaction(QueryChainMakerDemoTransactionRequest req)
        {
             JsonResponseModel<QueryChainMakerDemoTransactionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryChainMakerDemoTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerDemoTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过交易ID查询长安链体验网络交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoTransactionResponse"/></returns>
        public QueryChainMakerDemoTransactionResponse QueryChainMakerDemoTransactionSync(QueryChainMakerDemoTransactionRequest req)
        {
             JsonResponseModel<QueryChainMakerDemoTransactionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryChainMakerDemoTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerDemoTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过交易ID查询长安链交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerTransactionResponse"/></returns>
        public async Task<QueryChainMakerTransactionResponse> QueryChainMakerTransaction(QueryChainMakerTransactionRequest req)
        {
             JsonResponseModel<QueryChainMakerTransactionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryChainMakerTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过交易ID查询长安链交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerTransactionResponse"/></returns>
        public QueryChainMakerTransactionResponse QueryChainMakerTransactionSync(QueryChainMakerTransactionRequest req)
        {
             JsonResponseModel<QueryChainMakerTransactionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryChainMakerTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChainMakerTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// trustsql服务统一接口
        /// </summary>
        /// <param name="req"><see cref="SrvInvokeRequest"/></param>
        /// <returns><see cref="SrvInvokeResponse"/></returns>
        public async Task<SrvInvokeResponse> SrvInvoke(SrvInvokeRequest req)
        {
             JsonResponseModel<SrvInvokeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SrvInvoke");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SrvInvokeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// trustsql服务统一接口
        /// </summary>
        /// <param name="req"><see cref="SrvInvokeRequest"/></param>
        /// <returns><see cref="SrvInvokeResponse"/></returns>
        public SrvInvokeResponse SrvInvokeSync(SrvInvokeRequest req)
        {
             JsonResponseModel<SrvInvokeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SrvInvoke");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SrvInvokeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
