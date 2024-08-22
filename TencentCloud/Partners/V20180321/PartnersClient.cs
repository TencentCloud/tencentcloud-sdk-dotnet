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
       private const string sdkVersion = "SDK_NET_3.0.1075";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PartnersClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 代理商支付订单接口，支持自付/代付
        /// </summary>
        /// <param name="req"><see cref="AgentPayDealsRequest"/></param>
        /// <returns><see cref="AgentPayDealsResponse"/></returns>
        public Task<AgentPayDealsResponse> AgentPayDeals(AgentPayDealsRequest req)
        {
            return InternalRequestAsync<AgentPayDealsResponse>(req, "AgentPayDeals");
        }

        /// <summary>
        /// 代理商支付订单接口，支持自付/代付
        /// </summary>
        /// <param name="req"><see cref="AgentPayDealsRequest"/></param>
        /// <returns><see cref="AgentPayDealsResponse"/></returns>
        public AgentPayDealsResponse AgentPayDealsSync(AgentPayDealsRequest req)
        {
            return InternalRequestAsync<AgentPayDealsResponse>(req, "AgentPayDeals")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为合作伙伴提供转账给客户能力。仅支持合作伙伴为自己名下客户转账。
        /// </summary>
        /// <param name="req"><see cref="AgentTransferMoneyRequest"/></param>
        /// <returns><see cref="AgentTransferMoneyResponse"/></returns>
        public Task<AgentTransferMoneyResponse> AgentTransferMoney(AgentTransferMoneyRequest req)
        {
            return InternalRequestAsync<AgentTransferMoneyResponse>(req, "AgentTransferMoney");
        }

        /// <summary>
        /// 为合作伙伴提供转账给客户能力。仅支持合作伙伴为自己名下客户转账。
        /// </summary>
        /// <param name="req"><see cref="AgentTransferMoneyRequest"/></param>
        /// <returns><see cref="AgentTransferMoneyResponse"/></returns>
        public AgentTransferMoneyResponse AgentTransferMoneySync(AgentTransferMoneyRequest req)
        {
            return InternalRequestAsync<AgentTransferMoneyResponse>(req, "AgentTransferMoney")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为代客or申请中代客分派跟进人（业务员），入参可从以下API获取
        /// - 代客列表获取API： [DescribeAgentAuditedClients](https://cloud.tencent.com/document/product/563/19184)
        /// - 申请中代客列表获取API：[DescribeAgentClients](https://cloud.tencent.com/document/product/563/16046)
        /// - 业务员列表获取API：[DescribeSalesmans](https://cloud.tencent.com/document/product/563/35196) <br><br>
        /// </summary>
        /// <param name="req"><see cref="AssignClientsToSalesRequest"/></param>
        /// <returns><see cref="AssignClientsToSalesResponse"/></returns>
        public Task<AssignClientsToSalesResponse> AssignClientsToSales(AssignClientsToSalesRequest req)
        {
            return InternalRequestAsync<AssignClientsToSalesResponse>(req, "AssignClientsToSales");
        }

        /// <summary>
        /// 为代客or申请中代客分派跟进人（业务员），入参可从以下API获取
        /// - 代客列表获取API： [DescribeAgentAuditedClients](https://cloud.tencent.com/document/product/563/19184)
        /// - 申请中代客列表获取API：[DescribeAgentClients](https://cloud.tencent.com/document/product/563/16046)
        /// - 业务员列表获取API：[DescribeSalesmans](https://cloud.tencent.com/document/product/563/35196) <br><br>
        /// </summary>
        /// <param name="req"><see cref="AssignClientsToSalesRequest"/></param>
        /// <returns><see cref="AssignClientsToSalesResponse"/></returns>
        public AssignClientsToSalesResponse AssignClientsToSalesSync(AssignClientsToSalesRequest req)
        {
            return InternalRequestAsync<AssignClientsToSalesResponse>(req, "AssignClientsToSales")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 代理商可以审核其名下申请中代客
        /// </summary>
        /// <param name="req"><see cref="AuditApplyClientRequest"/></param>
        /// <returns><see cref="AuditApplyClientResponse"/></returns>
        public Task<AuditApplyClientResponse> AuditApplyClient(AuditApplyClientRequest req)
        {
            return InternalRequestAsync<AuditApplyClientResponse>(req, "AuditApplyClient");
        }

        /// <summary>
        /// 代理商可以审核其名下申请中代客
        /// </summary>
        /// <param name="req"><see cref="AuditApplyClientRequest"/></param>
        /// <returns><see cref="AuditApplyClientResponse"/></returns>
        public AuditApplyClientResponse AuditApplyClientSync(AuditApplyClientRequest req)
        {
            return InternalRequestAsync<AuditApplyClientResponse>(req, "AuditApplyClient")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 合作伙伴为客户创建强代付关系
        /// </summary>
        /// <param name="req"><see cref="CreatePayRelationForClientRequest"/></param>
        /// <returns><see cref="CreatePayRelationForClientResponse"/></returns>
        public Task<CreatePayRelationForClientResponse> CreatePayRelationForClient(CreatePayRelationForClientRequest req)
        {
            return InternalRequestAsync<CreatePayRelationForClientResponse>(req, "CreatePayRelationForClient");
        }

        /// <summary>
        /// 合作伙伴为客户创建强代付关系
        /// </summary>
        /// <param name="req"><see cref="CreatePayRelationForClientRequest"/></param>
        /// <returns><see cref="CreatePayRelationForClientResponse"/></returns>
        public CreatePayRelationForClientResponse CreatePayRelationForClientSync(CreatePayRelationForClientRequest req)
        {
            return InternalRequestAsync<CreatePayRelationForClientResponse>(req, "CreatePayRelationForClient")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询已审核客户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentAuditedClientsRequest"/></param>
        /// <returns><see cref="DescribeAgentAuditedClientsResponse"/></returns>
        public Task<DescribeAgentAuditedClientsResponse> DescribeAgentAuditedClients(DescribeAgentAuditedClientsRequest req)
        {
            return InternalRequestAsync<DescribeAgentAuditedClientsResponse>(req, "DescribeAgentAuditedClients");
        }

        /// <summary>
        /// 查询已审核客户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentAuditedClientsRequest"/></param>
        /// <returns><see cref="DescribeAgentAuditedClientsResponse"/></returns>
        public DescribeAgentAuditedClientsResponse DescribeAgentAuditedClientsSync(DescribeAgentAuditedClientsRequest req)
        {
            return InternalRequestAsync<DescribeAgentAuditedClientsResponse>(req, "DescribeAgentAuditedClients")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 代理商可查询自己及名下代客所有业务明细
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentBillsRequest"/></param>
        /// <returns><see cref="DescribeAgentBillsResponse"/></returns>
        public Task<DescribeAgentBillsResponse> DescribeAgentBills(DescribeAgentBillsRequest req)
        {
            return InternalRequestAsync<DescribeAgentBillsResponse>(req, "DescribeAgentBills");
        }

        /// <summary>
        /// 代理商可查询自己及名下代客所有业务明细
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentBillsRequest"/></param>
        /// <returns><see cref="DescribeAgentBillsResponse"/></returns>
        public DescribeAgentBillsResponse DescribeAgentBillsSync(DescribeAgentBillsRequest req)
        {
            return InternalRequestAsync<DescribeAgentBillsResponse>(req, "DescribeAgentBills")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 传入代客uin，查客户级别，客户审核状态，客户实名认证状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentClientGradeRequest"/></param>
        /// <returns><see cref="DescribeAgentClientGradeResponse"/></returns>
        public Task<DescribeAgentClientGradeResponse> DescribeAgentClientGrade(DescribeAgentClientGradeRequest req)
        {
            return InternalRequestAsync<DescribeAgentClientGradeResponse>(req, "DescribeAgentClientGrade");
        }

        /// <summary>
        /// 传入代客uin，查客户级别，客户审核状态，客户实名认证状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentClientGradeRequest"/></param>
        /// <returns><see cref="DescribeAgentClientGradeResponse"/></returns>
        public DescribeAgentClientGradeResponse DescribeAgentClientGradeSync(DescribeAgentClientGradeRequest req)
        {
            return InternalRequestAsync<DescribeAgentClientGradeResponse>(req, "DescribeAgentClientGrade")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 代理商可查询自己名下待审核客户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentClientsRequest"/></param>
        /// <returns><see cref="DescribeAgentClientsResponse"/></returns>
        public Task<DescribeAgentClientsResponse> DescribeAgentClients(DescribeAgentClientsRequest req)
        {
            return InternalRequestAsync<DescribeAgentClientsResponse>(req, "DescribeAgentClients");
        }

        /// <summary>
        /// 代理商可查询自己名下待审核客户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentClientsRequest"/></param>
        /// <returns><see cref="DescribeAgentClientsResponse"/></returns>
        public DescribeAgentClientsResponse DescribeAgentClientsSync(DescribeAgentClientsRequest req)
        {
            return InternalRequestAsync<DescribeAgentClientsResponse>(req, "DescribeAgentClients")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 供代理商拉取缓存的全量预付费客户订单
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDealsByCacheRequest"/></param>
        /// <returns><see cref="DescribeAgentDealsByCacheResponse"/></returns>
        public Task<DescribeAgentDealsByCacheResponse> DescribeAgentDealsByCache(DescribeAgentDealsByCacheRequest req)
        {
            return InternalRequestAsync<DescribeAgentDealsByCacheResponse>(req, "DescribeAgentDealsByCache");
        }

        /// <summary>
        /// 供代理商拉取缓存的全量预付费客户订单
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDealsByCacheRequest"/></param>
        /// <returns><see cref="DescribeAgentDealsByCacheResponse"/></returns>
        public DescribeAgentDealsByCacheResponse DescribeAgentDealsByCacheSync(DescribeAgentDealsByCacheRequest req)
        {
            return InternalRequestAsync<DescribeAgentDealsByCacheResponse>(req, "DescribeAgentDealsByCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可以查询代理商代付的预付费订单
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentPayDealsV2Request"/></param>
        /// <returns><see cref="DescribeAgentPayDealsV2Response"/></returns>
        public Task<DescribeAgentPayDealsV2Response> DescribeAgentPayDealsV2(DescribeAgentPayDealsV2Request req)
        {
            return InternalRequestAsync<DescribeAgentPayDealsV2Response>(req, "DescribeAgentPayDealsV2");
        }

        /// <summary>
        /// 可以查询代理商代付的预付费订单
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentPayDealsV2Request"/></param>
        /// <returns><see cref="DescribeAgentPayDealsV2Response"/></returns>
        public DescribeAgentPayDealsV2Response DescribeAgentPayDealsV2Sync(DescribeAgentPayDealsV2Request req)
        {
            return InternalRequestAsync<DescribeAgentPayDealsV2Response>(req, "DescribeAgentPayDealsV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询代理商名下指定代客的自付订单（预付费）
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentSelfPayDealsV2Request"/></param>
        /// <returns><see cref="DescribeAgentSelfPayDealsV2Response"/></returns>
        public Task<DescribeAgentSelfPayDealsV2Response> DescribeAgentSelfPayDealsV2(DescribeAgentSelfPayDealsV2Request req)
        {
            return InternalRequestAsync<DescribeAgentSelfPayDealsV2Response>(req, "DescribeAgentSelfPayDealsV2");
        }

        /// <summary>
        /// 查询代理商名下指定代客的自付订单（预付费）
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentSelfPayDealsV2Request"/></param>
        /// <returns><see cref="DescribeAgentSelfPayDealsV2Response"/></returns>
        public DescribeAgentSelfPayDealsV2Response DescribeAgentSelfPayDealsV2Sync(DescribeAgentSelfPayDealsV2Request req)
        {
            return InternalRequestAsync<DescribeAgentSelfPayDealsV2Response>(req, "DescribeAgentSelfPayDealsV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为合作伙伴提供查询客户余额能力。调用者必须是合作伙伴，只能查询自己名下客户余额
        /// </summary>
        /// <param name="req"><see cref="DescribeClientBalanceNewRequest"/></param>
        /// <returns><see cref="DescribeClientBalanceNewResponse"/></returns>
        public Task<DescribeClientBalanceNewResponse> DescribeClientBalanceNew(DescribeClientBalanceNewRequest req)
        {
            return InternalRequestAsync<DescribeClientBalanceNewResponse>(req, "DescribeClientBalanceNew");
        }

        /// <summary>
        /// 为合作伙伴提供查询客户余额能力。调用者必须是合作伙伴，只能查询自己名下客户余额
        /// </summary>
        /// <param name="req"><see cref="DescribeClientBalanceNewRequest"/></param>
        /// <returns><see cref="DescribeClientBalanceNewResponse"/></returns>
        public DescribeClientBalanceNewResponse DescribeClientBalanceNewSync(DescribeClientBalanceNewRequest req)
        {
            return InternalRequestAsync<DescribeClientBalanceNewResponse>(req, "DescribeClientBalanceNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 【该接口已下线，请切换使用升级版本DescribeRebateInfosNew】代理商可查询自己名下全部返佣信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRebateInfosRequest"/></param>
        /// <returns><see cref="DescribeRebateInfosResponse"/></returns>
        public Task<DescribeRebateInfosResponse> DescribeRebateInfos(DescribeRebateInfosRequest req)
        {
            return InternalRequestAsync<DescribeRebateInfosResponse>(req, "DescribeRebateInfos");
        }

        /// <summary>
        /// 【该接口已下线，请切换使用升级版本DescribeRebateInfosNew】代理商可查询自己名下全部返佣信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRebateInfosRequest"/></param>
        /// <returns><see cref="DescribeRebateInfosResponse"/></returns>
        public DescribeRebateInfosResponse DescribeRebateInfosSync(DescribeRebateInfosRequest req)
        {
            return InternalRequestAsync<DescribeRebateInfosResponse>(req, "DescribeRebateInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 代理商可查询自己名下全部返佣信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRebateInfosNewRequest"/></param>
        /// <returns><see cref="DescribeRebateInfosNewResponse"/></returns>
        public Task<DescribeRebateInfosNewResponse> DescribeRebateInfosNew(DescribeRebateInfosNewRequest req)
        {
            return InternalRequestAsync<DescribeRebateInfosNewResponse>(req, "DescribeRebateInfosNew");
        }

        /// <summary>
        /// 代理商可查询自己名下全部返佣信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRebateInfosNewRequest"/></param>
        /// <returns><see cref="DescribeRebateInfosNewResponse"/></returns>
        public DescribeRebateInfosNewResponse DescribeRebateInfosNewSync(DescribeRebateInfosNewRequest req)
        {
            return InternalRequestAsync<DescribeRebateInfosNewResponse>(req, "DescribeRebateInfosNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 代理商查询名下业务员列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSalesmansRequest"/></param>
        /// <returns><see cref="DescribeSalesmansResponse"/></returns>
        public Task<DescribeSalesmansResponse> DescribeSalesmans(DescribeSalesmansRequest req)
        {
            return InternalRequestAsync<DescribeSalesmansResponse>(req, "DescribeSalesmans");
        }

        /// <summary>
        /// 代理商查询名下业务员列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSalesmansRequest"/></param>
        /// <returns><see cref="DescribeSalesmansResponse"/></returns>
        public DescribeSalesmansResponse DescribeSalesmansSync(DescribeSalesmansRequest req)
        {
            return InternalRequestAsync<DescribeSalesmansResponse>(req, "DescribeSalesmans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 代理商名下客户解绑记录查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUnbindClientListRequest"/></param>
        /// <returns><see cref="DescribeUnbindClientListResponse"/></returns>
        public Task<DescribeUnbindClientListResponse> DescribeUnbindClientList(DescribeUnbindClientListRequest req)
        {
            return InternalRequestAsync<DescribeUnbindClientListResponse>(req, "DescribeUnbindClientList");
        }

        /// <summary>
        /// 代理商名下客户解绑记录查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUnbindClientListRequest"/></param>
        /// <returns><see cref="DescribeUnbindClientListResponse"/></returns>
        public DescribeUnbindClientListResponse DescribeUnbindClientListSync(DescribeUnbindClientListRequest req)
        {
            return InternalRequestAsync<DescribeUnbindClientListResponse>(req, "DescribeUnbindClientList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 代理商可以对名下客户添加备注、修改备注
        /// </summary>
        /// <param name="req"><see cref="ModifyClientRemarkRequest"/></param>
        /// <returns><see cref="ModifyClientRemarkResponse"/></returns>
        public Task<ModifyClientRemarkResponse> ModifyClientRemark(ModifyClientRemarkRequest req)
        {
            return InternalRequestAsync<ModifyClientRemarkResponse>(req, "ModifyClientRemark");
        }

        /// <summary>
        /// 代理商可以对名下客户添加备注、修改备注
        /// </summary>
        /// <param name="req"><see cref="ModifyClientRemarkRequest"/></param>
        /// <returns><see cref="ModifyClientRemarkResponse"/></returns>
        public ModifyClientRemarkResponse ModifyClientRemarkSync(ModifyClientRemarkRequest req)
        {
            return InternalRequestAsync<ModifyClientRemarkResponse>(req, "ModifyClientRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 合作伙伴为客户消除强代付关系
        /// </summary>
        /// <param name="req"><see cref="RemovePayRelationForClientRequest"/></param>
        /// <returns><see cref="RemovePayRelationForClientResponse"/></returns>
        public Task<RemovePayRelationForClientResponse> RemovePayRelationForClient(RemovePayRelationForClientRequest req)
        {
            return InternalRequestAsync<RemovePayRelationForClientResponse>(req, "RemovePayRelationForClient");
        }

        /// <summary>
        /// 合作伙伴为客户消除强代付关系
        /// </summary>
        /// <param name="req"><see cref="RemovePayRelationForClientRequest"/></param>
        /// <returns><see cref="RemovePayRelationForClientResponse"/></returns>
        public RemovePayRelationForClientResponse RemovePayRelationForClientSync(RemovePayRelationForClientRequest req)
        {
            return InternalRequestAsync<RemovePayRelationForClientResponse>(req, "RemovePayRelationForClient")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
