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

namespace TencentCloud.Partners.V20180321
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Partners.V20180321.Models;

   public class PartnersClient : AbstractClient{

       private const string endpoint = "partners.tencentcloudapi.com";
       private const string version = "2018-03-21";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PartnersClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public PartnersClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 代理商支付订单接口，支持自付/代付
        /// </summary>
        /// <param name="req"><see cref="AgentPayDealsRequest"/></param>
        /// <returns><see cref="AgentPayDealsResponse"/></returns>
        public async Task<AgentPayDealsResponse> AgentPayDeals(AgentPayDealsRequest req)
        {
             JsonResponseModel<AgentPayDealsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AgentPayDeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AgentPayDealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AgentPayDeals接口的同步版本，代理商支付订单接口，支持自付/代付
        /// </summary>
        /// <param name="req">参考<see cref="AgentPayDealsRequest"/></param>
        /// <returns>参考<see cref="AgentPayDealsResponse"/>实例</returns>
        public AgentPayDealsResponse AgentPayDealsSync(AgentPayDealsRequest req)
        {
             JsonResponseModel<AgentPayDealsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AgentPayDeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AgentPayDealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为合作伙伴提供转账给客户能力。仅支持合作伙伴为自己名下客户转账。
        /// </summary>
        /// <param name="req"><see cref="AgentTransferMoneyRequest"/></param>
        /// <returns><see cref="AgentTransferMoneyResponse"/></returns>
        public async Task<AgentTransferMoneyResponse> AgentTransferMoney(AgentTransferMoneyRequest req)
        {
             JsonResponseModel<AgentTransferMoneyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AgentTransferMoney");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AgentTransferMoneyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AgentTransferMoney接口的同步版本，为合作伙伴提供转账给客户能力。仅支持合作伙伴为自己名下客户转账。
        /// </summary>
        /// <param name="req">参考<see cref="AgentTransferMoneyRequest"/></param>
        /// <returns>参考<see cref="AgentTransferMoneyResponse"/>实例</returns>
        public AgentTransferMoneyResponse AgentTransferMoneySync(AgentTransferMoneyRequest req)
        {
             JsonResponseModel<AgentTransferMoneyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AgentTransferMoney");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AgentTransferMoneyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 代理商可以审核其名下申请中代客
        /// </summary>
        /// <param name="req"><see cref="AuditApplyClientRequest"/></param>
        /// <returns><see cref="AuditApplyClientResponse"/></returns>
        public async Task<AuditApplyClientResponse> AuditApplyClient(AuditApplyClientRequest req)
        {
             JsonResponseModel<AuditApplyClientResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AuditApplyClient");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuditApplyClientResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AuditApplyClient接口的同步版本，代理商可以审核其名下申请中代客
        /// </summary>
        /// <param name="req">参考<see cref="AuditApplyClientRequest"/></param>
        /// <returns>参考<see cref="AuditApplyClientResponse"/>实例</returns>
        public AuditApplyClientResponse AuditApplyClientSync(AuditApplyClientRequest req)
        {
             JsonResponseModel<AuditApplyClientResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AuditApplyClient");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuditApplyClientResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合作伙伴为客户创建强代付关系
        /// </summary>
        /// <param name="req"><see cref="CreatePayRelationForClientRequest"/></param>
        /// <returns><see cref="CreatePayRelationForClientResponse"/></returns>
        public async Task<CreatePayRelationForClientResponse> CreatePayRelationForClient(CreatePayRelationForClientRequest req)
        {
             JsonResponseModel<CreatePayRelationForClientResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePayRelationForClient");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePayRelationForClientResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreatePayRelationForClient接口的同步版本，合作伙伴为客户创建强代付关系
        /// </summary>
        /// <param name="req">参考<see cref="CreatePayRelationForClientRequest"/></param>
        /// <returns>参考<see cref="CreatePayRelationForClientResponse"/>实例</returns>
        public CreatePayRelationForClientResponse CreatePayRelationForClientSync(CreatePayRelationForClientRequest req)
        {
             JsonResponseModel<CreatePayRelationForClientResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePayRelationForClient");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePayRelationForClientResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询已审核客户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentAuditedClientsRequest"/></param>
        /// <returns><see cref="DescribeAgentAuditedClientsResponse"/></returns>
        public async Task<DescribeAgentAuditedClientsResponse> DescribeAgentAuditedClients(DescribeAgentAuditedClientsRequest req)
        {
             JsonResponseModel<DescribeAgentAuditedClientsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentAuditedClients");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentAuditedClientsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeAgentAuditedClients接口的同步版本，查询已审核客户列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAgentAuditedClientsRequest"/></param>
        /// <returns>参考<see cref="DescribeAgentAuditedClientsResponse"/>实例</returns>
        public DescribeAgentAuditedClientsResponse DescribeAgentAuditedClientsSync(DescribeAgentAuditedClientsRequest req)
        {
             JsonResponseModel<DescribeAgentAuditedClientsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgentAuditedClients");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentAuditedClientsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 代理商可查询自己及名下代客所有业务明细
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentBillsRequest"/></param>
        /// <returns><see cref="DescribeAgentBillsResponse"/></returns>
        public async Task<DescribeAgentBillsResponse> DescribeAgentBills(DescribeAgentBillsRequest req)
        {
             JsonResponseModel<DescribeAgentBillsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentBills");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentBillsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeAgentBills接口的同步版本，代理商可查询自己及名下代客所有业务明细
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAgentBillsRequest"/></param>
        /// <returns>参考<see cref="DescribeAgentBillsResponse"/>实例</returns>
        public DescribeAgentBillsResponse DescribeAgentBillsSync(DescribeAgentBillsRequest req)
        {
             JsonResponseModel<DescribeAgentBillsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgentBills");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentBillsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 代理商可查询自己名下待审核客户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentClientsRequest"/></param>
        /// <returns><see cref="DescribeAgentClientsResponse"/></returns>
        public async Task<DescribeAgentClientsResponse> DescribeAgentClients(DescribeAgentClientsRequest req)
        {
             JsonResponseModel<DescribeAgentClientsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentClients");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentClientsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeAgentClients接口的同步版本，代理商可查询自己名下待审核客户列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAgentClientsRequest"/></param>
        /// <returns>参考<see cref="DescribeAgentClientsResponse"/>实例</returns>
        public DescribeAgentClientsResponse DescribeAgentClientsSync(DescribeAgentClientsRequest req)
        {
             JsonResponseModel<DescribeAgentClientsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgentClients");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentClientsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 供超大型代理商（代客数量>=3000 ）拉取缓存的全量客户订单。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDealsCacheRequest"/></param>
        /// <returns><see cref="DescribeAgentDealsCacheResponse"/></returns>
        public async Task<DescribeAgentDealsCacheResponse> DescribeAgentDealsCache(DescribeAgentDealsCacheRequest req)
        {
             JsonResponseModel<DescribeAgentDealsCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentDealsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentDealsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeAgentDealsCache接口的同步版本，供超大型代理商（代客数量>=3000 ）拉取缓存的全量客户订单。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAgentDealsCacheRequest"/></param>
        /// <returns>参考<see cref="DescribeAgentDealsCacheResponse"/>实例</returns>
        public DescribeAgentDealsCacheResponse DescribeAgentDealsCacheSync(DescribeAgentDealsCacheRequest req)
        {
             JsonResponseModel<DescribeAgentDealsCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgentDealsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentDealsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可以查询代理商代付的所有订单
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentPayDealsRequest"/></param>
        /// <returns><see cref="DescribeAgentPayDealsResponse"/></returns>
        public async Task<DescribeAgentPayDealsResponse> DescribeAgentPayDeals(DescribeAgentPayDealsRequest req)
        {
             JsonResponseModel<DescribeAgentPayDealsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentPayDeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentPayDealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeAgentPayDeals接口的同步版本，可以查询代理商代付的所有订单
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAgentPayDealsRequest"/></param>
        /// <returns>参考<see cref="DescribeAgentPayDealsResponse"/>实例</returns>
        public DescribeAgentPayDealsResponse DescribeAgentPayDealsSync(DescribeAgentPayDealsRequest req)
        {
             JsonResponseModel<DescribeAgentPayDealsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgentPayDeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentPayDealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为合作伙伴提供查询客户余额能力。调用者必须是合作伙伴，只能查询自己名下客户余额
        /// </summary>
        /// <param name="req"><see cref="DescribeClientBalanceRequest"/></param>
        /// <returns><see cref="DescribeClientBalanceResponse"/></returns>
        public async Task<DescribeClientBalanceResponse> DescribeClientBalance(DescribeClientBalanceRequest req)
        {
             JsonResponseModel<DescribeClientBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClientBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClientBalance接口的同步版本，为合作伙伴提供查询客户余额能力。调用者必须是合作伙伴，只能查询自己名下客户余额
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClientBalanceRequest"/></param>
        /// <returns>参考<see cref="DescribeClientBalanceResponse"/>实例</returns>
        public DescribeClientBalanceResponse DescribeClientBalanceSync(DescribeClientBalanceRequest req)
        {
             JsonResponseModel<DescribeClientBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClientBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 代理商可查询自己名下全部返佣信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRebateInfosRequest"/></param>
        /// <returns><see cref="DescribeRebateInfosResponse"/></returns>
        public async Task<DescribeRebateInfosResponse> DescribeRebateInfos(DescribeRebateInfosRequest req)
        {
             JsonResponseModel<DescribeRebateInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRebateInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRebateInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRebateInfos接口的同步版本，代理商可查询自己名下全部返佣信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRebateInfosRequest"/></param>
        /// <returns>参考<see cref="DescribeRebateInfosResponse"/>实例</returns>
        public DescribeRebateInfosResponse DescribeRebateInfosSync(DescribeRebateInfosRequest req)
        {
             JsonResponseModel<DescribeRebateInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRebateInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRebateInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 代理商查询名下业务员列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSalesmansRequest"/></param>
        /// <returns><see cref="DescribeSalesmansResponse"/></returns>
        public async Task<DescribeSalesmansResponse> DescribeSalesmans(DescribeSalesmansRequest req)
        {
             JsonResponseModel<DescribeSalesmansResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSalesmans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSalesmansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSalesmans接口的同步版本，代理商查询名下业务员列表信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSalesmansRequest"/></param>
        /// <returns>参考<see cref="DescribeSalesmansResponse"/>实例</returns>
        public DescribeSalesmansResponse DescribeSalesmansSync(DescribeSalesmansRequest req)
        {
             JsonResponseModel<DescribeSalesmansResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSalesmans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSalesmansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 代理商可以对名下客户添加备注、修改备注
        /// </summary>
        /// <param name="req"><see cref="ModifyClientRemarkRequest"/></param>
        /// <returns><see cref="ModifyClientRemarkResponse"/></returns>
        public async Task<ModifyClientRemarkResponse> ModifyClientRemark(ModifyClientRemarkRequest req)
        {
             JsonResponseModel<ModifyClientRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClientRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClientRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyClientRemark接口的同步版本，代理商可以对名下客户添加备注、修改备注
        /// </summary>
        /// <param name="req">参考<see cref="ModifyClientRemarkRequest"/></param>
        /// <returns>参考<see cref="ModifyClientRemarkResponse"/>实例</returns>
        public ModifyClientRemarkResponse ModifyClientRemarkSync(ModifyClientRemarkRequest req)
        {
             JsonResponseModel<ModifyClientRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClientRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClientRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合作伙伴为客户消除强代付关系
        /// </summary>
        /// <param name="req"><see cref="RemovePayRelationForClientRequest"/></param>
        /// <returns><see cref="RemovePayRelationForClientResponse"/></returns>
        public async Task<RemovePayRelationForClientResponse> RemovePayRelationForClient(RemovePayRelationForClientRequest req)
        {
             JsonResponseModel<RemovePayRelationForClientResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemovePayRelationForClient");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemovePayRelationForClientResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RemovePayRelationForClient接口的同步版本，合作伙伴为客户消除强代付关系
        /// </summary>
        /// <param name="req">参考<see cref="RemovePayRelationForClientRequest"/></param>
        /// <returns>参考<see cref="RemovePayRelationForClientResponse"/>实例</returns>
        public RemovePayRelationForClientResponse RemovePayRelationForClientSync(RemovePayRelationForClientRequest req)
        {
             JsonResponseModel<RemovePayRelationForClientResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemovePayRelationForClient");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemovePayRelationForClientResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
