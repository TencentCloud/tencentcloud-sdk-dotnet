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
        /// Bcos根据块高查询区块信息
        /// </summary>
        /// <param name="req"><see cref="BlockByNumberHandlerRequest"/></param>
        /// <returns><see cref="BlockByNumberHandlerResponse"/></returns>
        public async Task<BlockByNumberHandlerResponse> BlockByNumberHandler(BlockByNumberHandlerRequest req)
        {
             JsonResponseModel<BlockByNumberHandlerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BlockByNumberHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BlockByNumberHandlerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Bcos根据块高查询区块信息
        /// </summary>
        /// <param name="req"><see cref="BlockByNumberHandlerRequest"/></param>
        /// <returns><see cref="BlockByNumberHandlerResponse"/></returns>
        public BlockByNumberHandlerResponse BlockByNumberHandlerSync(BlockByNumberHandlerRequest req)
        {
             JsonResponseModel<BlockByNumberHandlerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BlockByNumberHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BlockByNumberHandlerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 动态部署合约
        /// </summary>
        /// <param name="req"><see cref="DeployDynamicContractHandlerRequest"/></param>
        /// <returns><see cref="DeployDynamicContractHandlerResponse"/></returns>
        public async Task<DeployDynamicContractHandlerResponse> DeployDynamicContractHandler(DeployDynamicContractHandlerRequest req)
        {
             JsonResponseModel<DeployDynamicContractHandlerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeployDynamicContractHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployDynamicContractHandlerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 动态部署合约
        /// </summary>
        /// <param name="req"><see cref="DeployDynamicContractHandlerRequest"/></param>
        /// <returns><see cref="DeployDynamicContractHandlerResponse"/></returns>
        public DeployDynamicContractHandlerResponse DeployDynamicContractHandlerSync(DeployDynamicContractHandlerRequest req)
        {
             JsonResponseModel<DeployDynamicContractHandlerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeployDynamicContractHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployDynamicContractHandlerResponse>>(strResp);
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
        /// Bcos分页查询当前群组下的区块列表
        /// </summary>
        /// <param name="req"><see cref="GetBlockListHandlerRequest"/></param>
        /// <returns><see cref="GetBlockListHandlerResponse"/></returns>
        public async Task<GetBlockListHandlerResponse> GetBlockListHandler(GetBlockListHandlerRequest req)
        {
             JsonResponseModel<GetBlockListHandlerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetBlockListHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBlockListHandlerResponse>>(strResp);
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
        /// <param name="req"><see cref="GetBlockListHandlerRequest"/></param>
        /// <returns><see cref="GetBlockListHandlerResponse"/></returns>
        public GetBlockListHandlerResponse GetBlockListHandlerSync(GetBlockListHandlerRequest req)
        {
             JsonResponseModel<GetBlockListHandlerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetBlockListHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBlockListHandlerResponse>>(strResp);
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
        /// Bcos根据交易哈希查看交易详细信息
        /// </summary>
        /// <param name="req"><see cref="GetTransByHashHandlerRequest"/></param>
        /// <returns><see cref="GetTransByHashHandlerResponse"/></returns>
        public async Task<GetTransByHashHandlerResponse> GetTransByHashHandler(GetTransByHashHandlerRequest req)
        {
             JsonResponseModel<GetTransByHashHandlerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTransByHashHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTransByHashHandlerResponse>>(strResp);
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
        /// <param name="req"><see cref="GetTransByHashHandlerRequest"/></param>
        /// <returns><see cref="GetTransByHashHandlerResponse"/></returns>
        public GetTransByHashHandlerResponse GetTransByHashHandlerSync(GetTransByHashHandlerRequest req)
        {
             JsonResponseModel<GetTransByHashHandlerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTransByHashHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTransByHashHandlerResponse>>(strResp);
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
        /// <param name="req"><see cref="GetTransListHandlerRequest"/></param>
        /// <returns><see cref="GetTransListHandlerResponse"/></returns>
        public async Task<GetTransListHandlerResponse> GetTransListHandler(GetTransListHandlerRequest req)
        {
             JsonResponseModel<GetTransListHandlerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTransListHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTransListHandlerResponse>>(strResp);
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
        /// <param name="req"><see cref="GetTransListHandlerRequest"/></param>
        /// <returns><see cref="GetTransListHandlerResponse"/></returns>
        public GetTransListHandlerResponse GetTransListHandlerSync(GetTransListHandlerRequest req)
        {
             JsonResponseModel<GetTransListHandlerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTransListHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTransListHandlerResponse>>(strResp);
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
        /// Bcos发送交易
        /// </summary>
        /// <param name="req"><see cref="SendTransactionHandlerRequest"/></param>
        /// <returns><see cref="SendTransactionHandlerResponse"/></returns>
        public async Task<SendTransactionHandlerResponse> SendTransactionHandler(SendTransactionHandlerRequest req)
        {
             JsonResponseModel<SendTransactionHandlerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendTransactionHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendTransactionHandlerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Bcos发送交易
        /// </summary>
        /// <param name="req"><see cref="SendTransactionHandlerRequest"/></param>
        /// <returns><see cref="SendTransactionHandlerResponse"/></returns>
        public SendTransactionHandlerResponse SendTransactionHandlerSync(SendTransactionHandlerRequest req)
        {
             JsonResponseModel<SendTransactionHandlerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendTransactionHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendTransactionHandlerResponse>>(strResp);
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

        /// <summary>
        /// 根据动态部署的合约发送交易
        /// </summary>
        /// <param name="req"><see cref="TransByDynamicContractHandlerRequest"/></param>
        /// <returns><see cref="TransByDynamicContractHandlerResponse"/></returns>
        public async Task<TransByDynamicContractHandlerResponse> TransByDynamicContractHandler(TransByDynamicContractHandlerRequest req)
        {
             JsonResponseModel<TransByDynamicContractHandlerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransByDynamicContractHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransByDynamicContractHandlerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据动态部署的合约发送交易
        /// </summary>
        /// <param name="req"><see cref="TransByDynamicContractHandlerRequest"/></param>
        /// <returns><see cref="TransByDynamicContractHandlerResponse"/></returns>
        public TransByDynamicContractHandlerResponse TransByDynamicContractHandlerSync(TransByDynamicContractHandlerRequest req)
        {
             JsonResponseModel<TransByDynamicContractHandlerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TransByDynamicContractHandler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransByDynamicContractHandlerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
