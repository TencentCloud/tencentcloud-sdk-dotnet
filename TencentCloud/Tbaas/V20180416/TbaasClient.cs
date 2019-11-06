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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TbaasClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TbaasClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 申请用户证书
        /// </summary>
        /// <param name="req">参考<see cref="ApplyUserCertRequest"/></param>
        /// <returns>参考<see cref="ApplyUserCertResponse"/>实例</returns>
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
        /// Bcos根据块高查询区块信息
        /// </summary>
        /// <param name="req">参考<see cref="BlockByNumberHandlerRequest"/></param>
        /// <returns>参考<see cref="BlockByNumberHandlerResponse"/>实例</returns>
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
        /// 下载用户证书
        /// </summary>
        /// <param name="req">参考<see cref="DownloadUserCertRequest"/></param>
        /// <returns>参考<see cref="DownloadUserCertResponse"/>实例</returns>
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
        /// 查看当前网络下的所有区块列表，分页展示
        /// </summary>
        /// <param name="req">参考<see cref="GetBlockListRequest"/></param>
        /// <returns>参考<see cref="GetBlockListResponse"/>实例</returns>
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
        /// bcos分页查询当前群组下的区块列表
        /// </summary>
        /// <param name="req">参考<see cref="GetBlockListHandlerRequest"/></param>
        /// <returns>参考<see cref="GetBlockListHandlerResponse"/>实例</returns>
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
        /// 获取区块链网络概要
        /// </summary>
        /// <param name="req">参考<see cref="GetClusterSummaryRequest"/></param>
        /// <returns>参考<see cref="GetClusterSummaryResponse"/>实例</returns>
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
        /// Invoke异步调用结果查询
        /// </summary>
        /// <param name="req">参考<see cref="GetInvokeTxRequest"/></param>
        /// <returns>参考<see cref="GetInvokeTxResponse"/>实例</returns>
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
        /// 获取最新交易列表
        /// </summary>
        /// <param name="req">参考<see cref="GetLatesdTransactionListRequest"/></param>
        /// <returns>参考<see cref="GetLatesdTransactionListResponse"/>实例</returns>
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
        /// Bcos根据交易哈希查看交易详细信息
        /// </summary>
        /// <param name="req">参考<see cref="GetTransByHashHandlerRequest"/></param>
        /// <returns>参考<see cref="GetTransByHashHandlerResponse"/>实例</returns>
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
        /// Bcos分页查询当前群组的交易信息列表
        /// </summary>
        /// <param name="req">参考<see cref="GetTransListHandlerRequest"/></param>
        /// <returns>参考<see cref="GetTransListHandlerResponse"/>实例</returns>
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
        /// 新增交易
        /// </summary>
        /// <param name="req">参考<see cref="InvokeRequest"/></param>
        /// <returns>参考<see cref="InvokeResponse"/>实例</returns>
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
        /// 查询交易
        /// </summary>
        /// <param name="req">参考<see cref="QueryRequest"/></param>
        /// <returns>参考<see cref="QueryResponse"/>实例</returns>
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
        /// Bcos发送交易
        /// </summary>
        /// <param name="req">参考<see cref="SendTransactionHandlerRequest"/></param>
        /// <returns>参考<see cref="SendTransactionHandlerResponse"/>实例</returns>
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
        /// trustsql服务统一接口
        /// </summary>
        /// <param name="req">参考<see cref="SrvInvokeRequest"/></param>
        /// <returns>参考<see cref="SrvInvokeResponse"/>实例</returns>
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

    }
}
