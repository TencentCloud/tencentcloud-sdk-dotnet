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
       private const string sdkVersion = "SDK_NET_3.0.1013";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TbaasClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 批量申请长安链用户签名证书
        /// </summary>
        /// <param name="req"><see cref="ApplyChainMakerBatchUserCertRequest"/></param>
        /// <returns><see cref="ApplyChainMakerBatchUserCertResponse"/></returns>
        public Task<ApplyChainMakerBatchUserCertResponse> ApplyChainMakerBatchUserCert(ApplyChainMakerBatchUserCertRequest req)
        {
            return InternalRequestAsync<ApplyChainMakerBatchUserCertResponse>(req, "ApplyChainMakerBatchUserCert");
        }

        /// <summary>
        /// 批量申请长安链用户签名证书
        /// </summary>
        /// <param name="req"><see cref="ApplyChainMakerBatchUserCertRequest"/></param>
        /// <returns><see cref="ApplyChainMakerBatchUserCertResponse"/></returns>
        public ApplyChainMakerBatchUserCertResponse ApplyChainMakerBatchUserCertSync(ApplyChainMakerBatchUserCertRequest req)
        {
            return InternalRequestAsync<ApplyChainMakerBatchUserCertResponse>(req, "ApplyChainMakerBatchUserCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 申请用户证书
        /// </summary>
        /// <param name="req"><see cref="ApplyUserCertRequest"/></param>
        /// <returns><see cref="ApplyUserCertResponse"/></returns>
        public Task<ApplyUserCertResponse> ApplyUserCert(ApplyUserCertRequest req)
        {
            return InternalRequestAsync<ApplyUserCertResponse>(req, "ApplyUserCert");
        }

        /// <summary>
        /// 申请用户证书
        /// </summary>
        /// <param name="req"><see cref="ApplyUserCertRequest"/></param>
        /// <returns><see cref="ApplyUserCertResponse"/></returns>
        public ApplyUserCertResponse ApplyUserCertSync(ApplyUserCertRequest req)
        {
            return InternalRequestAsync<ApplyUserCertResponse>(req, "ApplyUserCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Fabric某区块的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFabricBlockRequest"/></param>
        /// <returns><see cref="DescribeFabricBlockResponse"/></returns>
        public Task<DescribeFabricBlockResponse> DescribeFabricBlock(DescribeFabricBlockRequest req)
        {
            return InternalRequestAsync<DescribeFabricBlockResponse>(req, "DescribeFabricBlock");
        }

        /// <summary>
        /// 获取Fabric某区块的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFabricBlockRequest"/></param>
        /// <returns><see cref="DescribeFabricBlockResponse"/></returns>
        public DescribeFabricBlockResponse DescribeFabricBlockSync(DescribeFabricBlockRequest req)
        {
            return InternalRequestAsync<DescribeFabricBlockResponse>(req, "DescribeFabricBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Fabric交易的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFabricTransactionRequest"/></param>
        /// <returns><see cref="DescribeFabricTransactionResponse"/></returns>
        public Task<DescribeFabricTransactionResponse> DescribeFabricTransaction(DescribeFabricTransactionRequest req)
        {
            return InternalRequestAsync<DescribeFabricTransactionResponse>(req, "DescribeFabricTransaction");
        }

        /// <summary>
        /// 获取Fabric交易的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFabricTransactionRequest"/></param>
        /// <returns><see cref="DescribeFabricTransactionResponse"/></returns>
        public DescribeFabricTransactionResponse DescribeFabricTransactionSync(DescribeFabricTransactionRequest req)
        {
            return InternalRequestAsync<DescribeFabricTransactionResponse>(req, "DescribeFabricTransaction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载用户证书
        /// </summary>
        /// <param name="req"><see cref="DownloadUserCertRequest"/></param>
        /// <returns><see cref="DownloadUserCertResponse"/></returns>
        public Task<DownloadUserCertResponse> DownloadUserCert(DownloadUserCertRequest req)
        {
            return InternalRequestAsync<DownloadUserCertResponse>(req, "DownloadUserCert");
        }

        /// <summary>
        /// 下载用户证书
        /// </summary>
        /// <param name="req"><see cref="DownloadUserCertRequest"/></param>
        /// <returns><see cref="DownloadUserCertResponse"/></returns>
        public DownloadUserCertResponse DownloadUserCertSync(DownloadUserCertRequest req)
        {
            return InternalRequestAsync<DownloadUserCertResponse>(req, "DownloadUserCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看当前网络下的所有区块列表，分页展示
        /// </summary>
        /// <param name="req"><see cref="GetBlockListRequest"/></param>
        /// <returns><see cref="GetBlockListResponse"/></returns>
        public Task<GetBlockListResponse> GetBlockList(GetBlockListRequest req)
        {
            return InternalRequestAsync<GetBlockListResponse>(req, "GetBlockList");
        }

        /// <summary>
        /// 查看当前网络下的所有区块列表，分页展示
        /// </summary>
        /// <param name="req"><see cref="GetBlockListRequest"/></param>
        /// <returns><see cref="GetBlockListResponse"/></returns>
        public GetBlockListResponse GetBlockListSync(GetBlockListRequest req)
        {
            return InternalRequestAsync<GetBlockListResponse>(req, "GetBlockList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取区块内的交易列表
        /// </summary>
        /// <param name="req"><see cref="GetBlockTransactionListForUserRequest"/></param>
        /// <returns><see cref="GetBlockTransactionListForUserResponse"/></returns>
        public Task<GetBlockTransactionListForUserResponse> GetBlockTransactionListForUser(GetBlockTransactionListForUserRequest req)
        {
            return InternalRequestAsync<GetBlockTransactionListForUserResponse>(req, "GetBlockTransactionListForUser");
        }

        /// <summary>
        /// 获取区块内的交易列表
        /// </summary>
        /// <param name="req"><see cref="GetBlockTransactionListForUserRequest"/></param>
        /// <returns><see cref="GetBlockTransactionListForUserResponse"/></returns>
        public GetBlockTransactionListForUserResponse GetBlockTransactionListForUserSync(GetBlockTransactionListForUserRequest req)
        {
            return InternalRequestAsync<GetBlockTransactionListForUserResponse>(req, "GetBlockTransactionListForUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取区块链网络概要
        /// </summary>
        /// <param name="req"><see cref="GetClusterSummaryRequest"/></param>
        /// <returns><see cref="GetClusterSummaryResponse"/></returns>
        public Task<GetClusterSummaryResponse> GetClusterSummary(GetClusterSummaryRequest req)
        {
            return InternalRequestAsync<GetClusterSummaryResponse>(req, "GetClusterSummary");
        }

        /// <summary>
        /// 获取区块链网络概要
        /// </summary>
        /// <param name="req"><see cref="GetClusterSummaryRequest"/></param>
        /// <returns><see cref="GetClusterSummaryResponse"/></returns>
        public GetClusterSummaryResponse GetClusterSummarySync(GetClusterSummaryRequest req)
        {
            return InternalRequestAsync<GetClusterSummaryResponse>(req, "GetClusterSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Invoke异步调用结果查询
        /// </summary>
        /// <param name="req"><see cref="GetInvokeTxRequest"/></param>
        /// <returns><see cref="GetInvokeTxResponse"/></returns>
        public Task<GetInvokeTxResponse> GetInvokeTx(GetInvokeTxRequest req)
        {
            return InternalRequestAsync<GetInvokeTxResponse>(req, "GetInvokeTx");
        }

        /// <summary>
        /// Invoke异步调用结果查询
        /// </summary>
        /// <param name="req"><see cref="GetInvokeTxRequest"/></param>
        /// <returns><see cref="GetInvokeTxResponse"/></returns>
        public GetInvokeTxResponse GetInvokeTxSync(GetInvokeTxRequest req)
        {
            return InternalRequestAsync<GetInvokeTxResponse>(req, "GetInvokeTx")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取最新交易列表（已废弃）
        /// </summary>
        /// <param name="req"><see cref="GetLatesdTransactionListRequest"/></param>
        /// <returns><see cref="GetLatesdTransactionListResponse"/></returns>
        public Task<GetLatesdTransactionListResponse> GetLatesdTransactionList(GetLatesdTransactionListRequest req)
        {
            return InternalRequestAsync<GetLatesdTransactionListResponse>(req, "GetLatesdTransactionList");
        }

        /// <summary>
        /// 获取最新交易列表（已废弃）
        /// </summary>
        /// <param name="req"><see cref="GetLatesdTransactionListRequest"/></param>
        /// <returns><see cref="GetLatesdTransactionListResponse"/></returns>
        public GetLatesdTransactionListResponse GetLatesdTransactionListSync(GetLatesdTransactionListRequest req)
        {
            return InternalRequestAsync<GetLatesdTransactionListResponse>(req, "GetLatesdTransactionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取fabric最新交易列表
        /// </summary>
        /// <param name="req"><see cref="GetLatestTransactionListRequest"/></param>
        /// <returns><see cref="GetLatestTransactionListResponse"/></returns>
        public Task<GetLatestTransactionListResponse> GetLatestTransactionList(GetLatestTransactionListRequest req)
        {
            return InternalRequestAsync<GetLatestTransactionListResponse>(req, "GetLatestTransactionList");
        }

        /// <summary>
        /// 获取fabric最新交易列表
        /// </summary>
        /// <param name="req"><see cref="GetLatestTransactionListRequest"/></param>
        /// <returns><see cref="GetLatestTransactionListResponse"/></returns>
        public GetLatestTransactionListResponse GetLatestTransactionListSync(GetLatestTransactionListRequest req)
        {
            return InternalRequestAsync<GetLatestTransactionListResponse>(req, "GetLatestTransactionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取交易详情
        /// </summary>
        /// <param name="req"><see cref="GetTransactionDetailForUserRequest"/></param>
        /// <returns><see cref="GetTransactionDetailForUserResponse"/></returns>
        public Task<GetTransactionDetailForUserResponse> GetTransactionDetailForUser(GetTransactionDetailForUserRequest req)
        {
            return InternalRequestAsync<GetTransactionDetailForUserResponse>(req, "GetTransactionDetailForUser");
        }

        /// <summary>
        /// 获取交易详情
        /// </summary>
        /// <param name="req"><see cref="GetTransactionDetailForUserRequest"/></param>
        /// <returns><see cref="GetTransactionDetailForUserResponse"/></returns>
        public GetTransactionDetailForUserResponse GetTransactionDetailForUserSync(GetTransactionDetailForUserRequest req)
        {
            return InternalRequestAsync<GetTransactionDetailForUserResponse>(req, "GetTransactionDetailForUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增交易
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public Task<InvokeResponse> Invoke(InvokeRequest req)
        {
            return InternalRequestAsync<InvokeResponse>(req, "Invoke");
        }

        /// <summary>
        /// 新增交易
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public InvokeResponse InvokeSync(InvokeRequest req)
        {
            return InternalRequestAsync<InvokeResponse>(req, "Invoke")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用长安链合约执行交易
        /// </summary>
        /// <param name="req"><see cref="InvokeChainMakerContractRequest"/></param>
        /// <returns><see cref="InvokeChainMakerContractResponse"/></returns>
        public Task<InvokeChainMakerContractResponse> InvokeChainMakerContract(InvokeChainMakerContractRequest req)
        {
            return InternalRequestAsync<InvokeChainMakerContractResponse>(req, "InvokeChainMakerContract");
        }

        /// <summary>
        /// 调用长安链合约执行交易
        /// </summary>
        /// <param name="req"><see cref="InvokeChainMakerContractRequest"/></param>
        /// <returns><see cref="InvokeChainMakerContractResponse"/></returns>
        public InvokeChainMakerContractResponse InvokeChainMakerContractSync(InvokeChainMakerContractRequest req)
        {
            return InternalRequestAsync<InvokeChainMakerContractResponse>(req, "InvokeChainMakerContract")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用长安链体验网络合约执行交易
        /// </summary>
        /// <param name="req"><see cref="InvokeChainMakerDemoContractRequest"/></param>
        /// <returns><see cref="InvokeChainMakerDemoContractResponse"/></returns>
        public Task<InvokeChainMakerDemoContractResponse> InvokeChainMakerDemoContract(InvokeChainMakerDemoContractRequest req)
        {
            return InternalRequestAsync<InvokeChainMakerDemoContractResponse>(req, "InvokeChainMakerDemoContract");
        }

        /// <summary>
        /// 调用长安链体验网络合约执行交易
        /// </summary>
        /// <param name="req"><see cref="InvokeChainMakerDemoContractRequest"/></param>
        /// <returns><see cref="InvokeChainMakerDemoContractResponse"/></returns>
        public InvokeChainMakerDemoContractResponse InvokeChainMakerDemoContractSync(InvokeChainMakerDemoContractRequest req)
        {
            return InternalRequestAsync<InvokeChainMakerDemoContractResponse>(req, "InvokeChainMakerDemoContract")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用Fabric用户合约执行交易
        /// </summary>
        /// <param name="req"><see cref="InvokeFabricChaincodeRequest"/></param>
        /// <returns><see cref="InvokeFabricChaincodeResponse"/></returns>
        public Task<InvokeFabricChaincodeResponse> InvokeFabricChaincode(InvokeFabricChaincodeRequest req)
        {
            return InternalRequestAsync<InvokeFabricChaincodeResponse>(req, "InvokeFabricChaincode");
        }

        /// <summary>
        /// 调用Fabric用户合约执行交易
        /// </summary>
        /// <param name="req"><see cref="InvokeFabricChaincodeRequest"/></param>
        /// <returns><see cref="InvokeFabricChaincodeResponse"/></returns>
        public InvokeFabricChaincodeResponse InvokeFabricChaincodeSync(InvokeFabricChaincodeRequest req)
        {
            return InternalRequestAsync<InvokeFabricChaincodeResponse>(req, "InvokeFabricChaincode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询交易
        /// </summary>
        /// <param name="req"><see cref="QueryRequest"/></param>
        /// <returns><see cref="QueryResponse"/></returns>
        public Task<QueryResponse> Query(QueryRequest req)
        {
            return InternalRequestAsync<QueryResponse>(req, "Query");
        }

        /// <summary>
        /// 查询交易
        /// </summary>
        /// <param name="req"><see cref="QueryRequest"/></param>
        /// <returns><see cref="QueryResponse"/></returns>
        public QueryResponse QuerySync(QueryRequest req)
        {
            return InternalRequestAsync<QueryResponse>(req, "Query")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询长安链指定高度区块的交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerBlockTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerBlockTransactionResponse"/></returns>
        public Task<QueryChainMakerBlockTransactionResponse> QueryChainMakerBlockTransaction(QueryChainMakerBlockTransactionRequest req)
        {
            return InternalRequestAsync<QueryChainMakerBlockTransactionResponse>(req, "QueryChainMakerBlockTransaction");
        }

        /// <summary>
        /// 查询长安链指定高度区块的交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerBlockTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerBlockTransactionResponse"/></returns>
        public QueryChainMakerBlockTransactionResponse QueryChainMakerBlockTransactionSync(QueryChainMakerBlockTransactionRequest req)
        {
            return InternalRequestAsync<QueryChainMakerBlockTransactionResponse>(req, "QueryChainMakerBlockTransaction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用长安链合约查询
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerContractRequest"/></param>
        /// <returns><see cref="QueryChainMakerContractResponse"/></returns>
        public Task<QueryChainMakerContractResponse> QueryChainMakerContract(QueryChainMakerContractRequest req)
        {
            return InternalRequestAsync<QueryChainMakerContractResponse>(req, "QueryChainMakerContract");
        }

        /// <summary>
        /// 调用长安链合约查询
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerContractRequest"/></param>
        /// <returns><see cref="QueryChainMakerContractResponse"/></returns>
        public QueryChainMakerContractResponse QueryChainMakerContractSync(QueryChainMakerContractRequest req)
        {
            return InternalRequestAsync<QueryChainMakerContractResponse>(req, "QueryChainMakerContract")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询长安链体验网络指定高度区块的交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoBlockTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoBlockTransactionResponse"/></returns>
        public Task<QueryChainMakerDemoBlockTransactionResponse> QueryChainMakerDemoBlockTransaction(QueryChainMakerDemoBlockTransactionRequest req)
        {
            return InternalRequestAsync<QueryChainMakerDemoBlockTransactionResponse>(req, "QueryChainMakerDemoBlockTransaction");
        }

        /// <summary>
        /// 查询长安链体验网络指定高度区块的交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoBlockTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoBlockTransactionResponse"/></returns>
        public QueryChainMakerDemoBlockTransactionResponse QueryChainMakerDemoBlockTransactionSync(QueryChainMakerDemoBlockTransactionRequest req)
        {
            return InternalRequestAsync<QueryChainMakerDemoBlockTransactionResponse>(req, "QueryChainMakerDemoBlockTransaction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用长安链体验网络合约查询
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoContractRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoContractResponse"/></returns>
        public Task<QueryChainMakerDemoContractResponse> QueryChainMakerDemoContract(QueryChainMakerDemoContractRequest req)
        {
            return InternalRequestAsync<QueryChainMakerDemoContractResponse>(req, "QueryChainMakerDemoContract");
        }

        /// <summary>
        /// 调用长安链体验网络合约查询
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoContractRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoContractResponse"/></returns>
        public QueryChainMakerDemoContractResponse QueryChainMakerDemoContractSync(QueryChainMakerDemoContractRequest req)
        {
            return InternalRequestAsync<QueryChainMakerDemoContractResponse>(req, "QueryChainMakerDemoContract")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过交易ID查询长安链体验网络交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoTransactionResponse"/></returns>
        public Task<QueryChainMakerDemoTransactionResponse> QueryChainMakerDemoTransaction(QueryChainMakerDemoTransactionRequest req)
        {
            return InternalRequestAsync<QueryChainMakerDemoTransactionResponse>(req, "QueryChainMakerDemoTransaction");
        }

        /// <summary>
        /// 通过交易ID查询长安链体验网络交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerDemoTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerDemoTransactionResponse"/></returns>
        public QueryChainMakerDemoTransactionResponse QueryChainMakerDemoTransactionSync(QueryChainMakerDemoTransactionRequest req)
        {
            return InternalRequestAsync<QueryChainMakerDemoTransactionResponse>(req, "QueryChainMakerDemoTransaction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过交易ID查询长安链交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerTransactionResponse"/></returns>
        public Task<QueryChainMakerTransactionResponse> QueryChainMakerTransaction(QueryChainMakerTransactionRequest req)
        {
            return InternalRequestAsync<QueryChainMakerTransactionResponse>(req, "QueryChainMakerTransaction");
        }

        /// <summary>
        /// 通过交易ID查询长安链交易
        /// </summary>
        /// <param name="req"><see cref="QueryChainMakerTransactionRequest"/></param>
        /// <returns><see cref="QueryChainMakerTransactionResponse"/></returns>
        public QueryChainMakerTransactionResponse QueryChainMakerTransactionSync(QueryChainMakerTransactionRequest req)
        {
            return InternalRequestAsync<QueryChainMakerTransactionResponse>(req, "QueryChainMakerTransaction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用Fabric用户合约查询
        /// </summary>
        /// <param name="req"><see cref="QueryFabricChaincodeRequest"/></param>
        /// <returns><see cref="QueryFabricChaincodeResponse"/></returns>
        public Task<QueryFabricChaincodeResponse> QueryFabricChaincode(QueryFabricChaincodeRequest req)
        {
            return InternalRequestAsync<QueryFabricChaincodeResponse>(req, "QueryFabricChaincode");
        }

        /// <summary>
        /// 调用Fabric用户合约查询
        /// </summary>
        /// <param name="req"><see cref="QueryFabricChaincodeRequest"/></param>
        /// <returns><see cref="QueryFabricChaincodeResponse"/></returns>
        public QueryFabricChaincodeResponse QueryFabricChaincodeSync(QueryFabricChaincodeRequest req)
        {
            return InternalRequestAsync<QueryFabricChaincodeResponse>(req, "QueryFabricChaincode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// trustsql服务统一接口
        /// </summary>
        /// <param name="req"><see cref="SrvInvokeRequest"/></param>
        /// <returns><see cref="SrvInvokeResponse"/></returns>
        public Task<SrvInvokeResponse> SrvInvoke(SrvInvokeRequest req)
        {
            return InternalRequestAsync<SrvInvokeResponse>(req, "SrvInvoke");
        }

        /// <summary>
        /// trustsql服务统一接口
        /// </summary>
        /// <param name="req"><see cref="SrvInvokeRequest"/></param>
        /// <returns><see cref="SrvInvokeResponse"/></returns>
        public SrvInvokeResponse SrvInvokeSync(SrvInvokeRequest req)
        {
            return InternalRequestAsync<SrvInvokeResponse>(req, "SrvInvoke")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
