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

namespace TencentCloud.Billing.V20180709
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Billing.V20180709.Models;

   public class BillingClient : AbstractClient{

       private const string endpoint = "billing.tencentcloudapi.com";
       private const string version = "2018-07-09";
       private const string sdkVersion = "SDK_NET_3.0.1055";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BillingClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BillingClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 批量设置分账标签
        /// </summary>
        /// <param name="req"><see cref="CreateAllocationTagRequest"/></param>
        /// <returns><see cref="CreateAllocationTagResponse"/></returns>
        public Task<CreateAllocationTagResponse> CreateAllocationTag(CreateAllocationTagRequest req)
        {
            return InternalRequestAsync<CreateAllocationTagResponse>(req, "CreateAllocationTag");
        }

        /// <summary>
        /// 批量设置分账标签
        /// </summary>
        /// <param name="req"><see cref="CreateAllocationTagRequest"/></param>
        /// <returns><see cref="CreateAllocationTagResponse"/></returns>
        public CreateAllocationTagResponse CreateAllocationTagSync(CreateAllocationTagRequest req)
        {
            return InternalRequestAsync<CreateAllocationTagResponse>(req, "CreateAllocationTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建节省计划订单，创建订单完成需调用PayDeals接口完成订单支付
        /// </summary>
        /// <param name="req"><see cref="CreateSavingPlanOrderRequest"/></param>
        /// <returns><see cref="CreateSavingPlanOrderResponse"/></returns>
        public Task<CreateSavingPlanOrderResponse> CreateSavingPlanOrder(CreateSavingPlanOrderRequest req)
        {
            return InternalRequestAsync<CreateSavingPlanOrderResponse>(req, "CreateSavingPlanOrder");
        }

        /// <summary>
        /// 创建节省计划订单，创建订单完成需调用PayDeals接口完成订单支付
        /// </summary>
        /// <param name="req"><see cref="CreateSavingPlanOrderRequest"/></param>
        /// <returns><see cref="CreateSavingPlanOrderResponse"/></returns>
        public CreateSavingPlanOrderResponse CreateSavingPlanOrderSync(CreateSavingPlanOrderRequest req)
        {
            return InternalRequestAsync<CreateSavingPlanOrderResponse>(req, "CreateSavingPlanOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量取消设置分账标签
        /// </summary>
        /// <param name="req"><see cref="DeleteAllocationTagRequest"/></param>
        /// <returns><see cref="DeleteAllocationTagResponse"/></returns>
        public Task<DeleteAllocationTagResponse> DeleteAllocationTag(DeleteAllocationTagRequest req)
        {
            return InternalRequestAsync<DeleteAllocationTagResponse>(req, "DeleteAllocationTag");
        }

        /// <summary>
        /// 批量取消设置分账标签
        /// </summary>
        /// <param name="req"><see cref="DeleteAllocationTagRequest"/></param>
        /// <returns><see cref="DeleteAllocationTagResponse"/></returns>
        public DeleteAllocationTagResponse DeleteAllocationTagSync(DeleteAllocationTagRequest req)
        {
            return InternalRequestAsync<DeleteAllocationTagResponse>(req, "DeleteAllocationTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云账户余额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public Task<DescribeAccountBalanceResponse> DescribeAccountBalance(DescribeAccountBalanceRequest req)
        {
            return InternalRequestAsync<DescribeAccountBalanceResponse>(req, "DescribeAccountBalance");
        }

        /// <summary>
        /// 获取云账户余额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public DescribeAccountBalanceResponse DescribeAccountBalanceSync(DescribeAccountBalanceRequest req)
        {
            return InternalRequestAsync<DescribeAccountBalanceResponse>(req, "DescribeAccountBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源目录筛选条件
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocateConditionsRequest"/></param>
        /// <returns><see cref="DescribeAllocateConditionsResponse"/></returns>
        public Task<DescribeAllocateConditionsResponse> DescribeAllocateConditions(DescribeAllocateConditionsRequest req)
        {
            return InternalRequestAsync<DescribeAllocateConditionsResponse>(req, "DescribeAllocateConditions");
        }

        /// <summary>
        /// 查询资源目录筛选条件
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocateConditionsRequest"/></param>
        /// <returns><see cref="DescribeAllocateConditionsResponse"/></returns>
        public DescribeAllocateConditionsResponse DescribeAllocateConditionsSync(DescribeAllocateConditionsRequest req)
        {
            return InternalRequestAsync<DescribeAllocateConditionsResponse>(req, "DescribeAllocateConditions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分账账单筛选条件
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationBillConditionsRequest"/></param>
        /// <returns><see cref="DescribeAllocationBillConditionsResponse"/></returns>
        public Task<DescribeAllocationBillConditionsResponse> DescribeAllocationBillConditions(DescribeAllocationBillConditionsRequest req)
        {
            return InternalRequestAsync<DescribeAllocationBillConditionsResponse>(req, "DescribeAllocationBillConditions");
        }

        /// <summary>
        /// 查询分账账单筛选条件
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationBillConditionsRequest"/></param>
        /// <returns><see cref="DescribeAllocationBillConditionsResponse"/></returns>
        public DescribeAllocationBillConditionsResponse DescribeAllocationBillConditionsSync(DescribeAllocationBillConditionsRequest req)
        {
            return InternalRequestAsync<DescribeAllocationBillConditionsResponse>(req, "DescribeAllocationBillConditions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分账账单明细
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationBillDetailRequest"/></param>
        /// <returns><see cref="DescribeAllocationBillDetailResponse"/></returns>
        public Task<DescribeAllocationBillDetailResponse> DescribeAllocationBillDetail(DescribeAllocationBillDetailRequest req)
        {
            return InternalRequestAsync<DescribeAllocationBillDetailResponse>(req, "DescribeAllocationBillDetail");
        }

        /// <summary>
        /// 查询分账账单明细
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationBillDetailRequest"/></param>
        /// <returns><see cref="DescribeAllocationBillDetailResponse"/></returns>
        public DescribeAllocationBillDetailResponse DescribeAllocationBillDetailSync(DescribeAllocationBillDetailRequest req)
        {
            return InternalRequestAsync<DescribeAllocationBillDetailResponse>(req, "DescribeAllocationBillDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分账账单月概览
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationMonthOverviewRequest"/></param>
        /// <returns><see cref="DescribeAllocationMonthOverviewResponse"/></returns>
        public Task<DescribeAllocationMonthOverviewResponse> DescribeAllocationMonthOverview(DescribeAllocationMonthOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAllocationMonthOverviewResponse>(req, "DescribeAllocationMonthOverview");
        }

        /// <summary>
        /// 查询分账账单月概览
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationMonthOverviewRequest"/></param>
        /// <returns><see cref="DescribeAllocationMonthOverviewResponse"/></returns>
        public DescribeAllocationMonthOverviewResponse DescribeAllocationMonthOverviewSync(DescribeAllocationMonthOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAllocationMonthOverviewResponse>(req, "DescribeAllocationMonthOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分账账单日概览
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationOverviewRequest"/></param>
        /// <returns><see cref="DescribeAllocationOverviewResponse"/></returns>
        public Task<DescribeAllocationOverviewResponse> DescribeAllocationOverview(DescribeAllocationOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAllocationOverviewResponse>(req, "DescribeAllocationOverview");
        }

        /// <summary>
        /// 查询分账账单日概览
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationOverviewRequest"/></param>
        /// <returns><see cref="DescribeAllocationOverviewResponse"/></returns>
        public DescribeAllocationOverviewResponse DescribeAllocationOverviewSync(DescribeAllocationOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAllocationOverviewResponse>(req, "DescribeAllocationOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分账账单按产品汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationSummaryByBusinessRequest"/></param>
        /// <returns><see cref="DescribeAllocationSummaryByBusinessResponse"/></returns>
        public Task<DescribeAllocationSummaryByBusinessResponse> DescribeAllocationSummaryByBusiness(DescribeAllocationSummaryByBusinessRequest req)
        {
            return InternalRequestAsync<DescribeAllocationSummaryByBusinessResponse>(req, "DescribeAllocationSummaryByBusiness");
        }

        /// <summary>
        /// 查询分账账单按产品汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationSummaryByBusinessRequest"/></param>
        /// <returns><see cref="DescribeAllocationSummaryByBusinessResponse"/></returns>
        public DescribeAllocationSummaryByBusinessResponse DescribeAllocationSummaryByBusinessSync(DescribeAllocationSummaryByBusinessRequest req)
        {
            return InternalRequestAsync<DescribeAllocationSummaryByBusinessResponse>(req, "DescribeAllocationSummaryByBusiness")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分账账单按组件汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationSummaryByItemRequest"/></param>
        /// <returns><see cref="DescribeAllocationSummaryByItemResponse"/></returns>
        public Task<DescribeAllocationSummaryByItemResponse> DescribeAllocationSummaryByItem(DescribeAllocationSummaryByItemRequest req)
        {
            return InternalRequestAsync<DescribeAllocationSummaryByItemResponse>(req, "DescribeAllocationSummaryByItem");
        }

        /// <summary>
        /// 查询分账账单按组件汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationSummaryByItemRequest"/></param>
        /// <returns><see cref="DescribeAllocationSummaryByItemResponse"/></returns>
        public DescribeAllocationSummaryByItemResponse DescribeAllocationSummaryByItemSync(DescribeAllocationSummaryByItemRequest req)
        {
            return InternalRequestAsync<DescribeAllocationSummaryByItemResponse>(req, "DescribeAllocationSummaryByItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分账账单按资源汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationSummaryByResourceRequest"/></param>
        /// <returns><see cref="DescribeAllocationSummaryByResourceResponse"/></returns>
        public Task<DescribeAllocationSummaryByResourceResponse> DescribeAllocationSummaryByResource(DescribeAllocationSummaryByResourceRequest req)
        {
            return InternalRequestAsync<DescribeAllocationSummaryByResourceResponse>(req, "DescribeAllocationSummaryByResource");
        }

        /// <summary>
        /// 查询分账账单按资源汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationSummaryByResourceRequest"/></param>
        /// <returns><see cref="DescribeAllocationSummaryByResourceResponse"/></returns>
        public DescribeAllocationSummaryByResourceResponse DescribeAllocationSummaryByResourceSync(DescribeAllocationSummaryByResourceRequest req)
        {
            return InternalRequestAsync<DescribeAllocationSummaryByResourceResponse>(req, "DescribeAllocationSummaryByResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分账账单费用趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationTrendByMonthRequest"/></param>
        /// <returns><see cref="DescribeAllocationTrendByMonthResponse"/></returns>
        public Task<DescribeAllocationTrendByMonthResponse> DescribeAllocationTrendByMonth(DescribeAllocationTrendByMonthRequest req)
        {
            return InternalRequestAsync<DescribeAllocationTrendByMonthResponse>(req, "DescribeAllocationTrendByMonth");
        }

        /// <summary>
        /// 查询分账账单费用趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationTrendByMonthRequest"/></param>
        /// <returns><see cref="DescribeAllocationTrendByMonthResponse"/></returns>
        public DescribeAllocationTrendByMonthResponse DescribeAllocationTrendByMonthSync(DescribeAllocationTrendByMonthRequest req)
        {
            return InternalRequestAsync<DescribeAllocationTrendByMonthResponse>(req, "DescribeAllocationTrendByMonth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账单明细数据。
        /// 注意事项：
        /// 1.在请求接口时，由于网络不稳定或其它异常，可能会导致请求失败。如果您遇到这种情况，我们建议您在接口请求失败时，手动发起重试操作，这样可以更好地确保您的接口请求能够成功执行。
        /// 2.对于账单明细数据量级很大（例如每月账单明细量级超过20w）的客户，通过 API 调用账单数据效率较低，建议您开通账单数据存储功能，通过存储桶中获取账单文件进行分析。[账单存储至COS桶](https://cloud.tencent.com/document/product/555/61275)
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailRequest"/></param>
        /// <returns><see cref="DescribeBillDetailResponse"/></returns>
        public Task<DescribeBillDetailResponse> DescribeBillDetail(DescribeBillDetailRequest req)
        {
            return InternalRequestAsync<DescribeBillDetailResponse>(req, "DescribeBillDetail");
        }

        /// <summary>
        /// 获取账单明细数据。
        /// 注意事项：
        /// 1.在请求接口时，由于网络不稳定或其它异常，可能会导致请求失败。如果您遇到这种情况，我们建议您在接口请求失败时，手动发起重试操作，这样可以更好地确保您的接口请求能够成功执行。
        /// 2.对于账单明细数据量级很大（例如每月账单明细量级超过20w）的客户，通过 API 调用账单数据效率较低，建议您开通账单数据存储功能，通过存储桶中获取账单文件进行分析。[账单存储至COS桶](https://cloud.tencent.com/document/product/555/61275)
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailRequest"/></param>
        /// <returns><see cref="DescribeBillDetailResponse"/></returns>
        public DescribeBillDetailResponse DescribeBillDetailSync(DescribeBillDetailRequest req)
        {
            return InternalRequestAsync<DescribeBillDetailResponse>(req, "DescribeBillDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成员账号获取管理账号代付账单（费用明细）。
        /// 注意事项：在请求接口时，由于网络不稳定或其它异常，可能会导致请求失败。如果您遇到这种情况，我们建议您在接口请求失败时，手动发起重试操作，这样可以更好地确保您的接口请求能够成功执行。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillDetailForOrganizationResponse"/></returns>
        public Task<DescribeBillDetailForOrganizationResponse> DescribeBillDetailForOrganization(DescribeBillDetailForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillDetailForOrganizationResponse>(req, "DescribeBillDetailForOrganization");
        }

        /// <summary>
        /// 成员账号获取管理账号代付账单（费用明细）。
        /// 注意事项：在请求接口时，由于网络不稳定或其它异常，可能会导致请求失败。如果您遇到这种情况，我们建议您在接口请求失败时，手动发起重试操作，这样可以更好地确保您的接口请求能够成功执行。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillDetailForOrganizationResponse"/></returns>
        public DescribeBillDetailForOrganizationResponse DescribeBillDetailForOrganizationSync(DescribeBillDetailForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillDetailForOrganizationResponse>(req, "DescribeBillDetailForOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口支持通过传参，获取L0-PDF、L1-汇总、L2-资源、L3-明细、账单包、五类账单文件下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBillDownloadUrlResponse"/></returns>
        public Task<DescribeBillDownloadUrlResponse> DescribeBillDownloadUrl(DescribeBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBillDownloadUrlResponse>(req, "DescribeBillDownloadUrl");
        }

        /// <summary>
        /// 该接口支持通过传参，获取L0-PDF、L1-汇总、L2-资源、L3-明细、账单包、五类账单文件下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBillDownloadUrlResponse"/></returns>
        public DescribeBillDownloadUrlResponse DescribeBillDownloadUrlSync(DescribeBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBillDownloadUrlResponse>(req, "DescribeBillDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取收支明细列表，支持翻页和参数过滤
        /// </summary>
        /// <param name="req"><see cref="DescribeBillListRequest"/></param>
        /// <returns><see cref="DescribeBillListResponse"/></returns>
        public Task<DescribeBillListResponse> DescribeBillList(DescribeBillListRequest req)
        {
            return InternalRequestAsync<DescribeBillListResponse>(req, "DescribeBillList");
        }

        /// <summary>
        /// 获取收支明细列表，支持翻页和参数过滤
        /// </summary>
        /// <param name="req"><see cref="DescribeBillListRequest"/></param>
        /// <returns><see cref="DescribeBillListResponse"/></returns>
        public DescribeBillListResponse DescribeBillListSync(DescribeBillListRequest req)
        {
            return InternalRequestAsync<DescribeBillListResponse>(req, "DescribeBillList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账单资源汇总数据
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryResponse"/></returns>
        public Task<DescribeBillResourceSummaryResponse> DescribeBillResourceSummary(DescribeBillResourceSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBillResourceSummaryResponse>(req, "DescribeBillResourceSummary");
        }

        /// <summary>
        /// 获取账单资源汇总数据
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryResponse"/></returns>
        public DescribeBillResourceSummaryResponse DescribeBillResourceSummarySync(DescribeBillResourceSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBillResourceSummaryResponse>(req, "DescribeBillResourceSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成员账号获取管理账号代付账单（按资源汇总）
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryForOrganizationResponse"/></returns>
        public Task<DescribeBillResourceSummaryForOrganizationResponse> DescribeBillResourceSummaryForOrganization(DescribeBillResourceSummaryForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillResourceSummaryForOrganizationResponse>(req, "DescribeBillResourceSummaryForOrganization");
        }

        /// <summary>
        /// 成员账号获取管理账号代付账单（按资源汇总）
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryForOrganizationResponse"/></returns>
        public DescribeBillResourceSummaryForOrganizationResponse DescribeBillResourceSummaryForOrganizationSync(DescribeBillResourceSummaryForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillResourceSummaryForOrganizationResponse>(req, "DescribeBillResourceSummaryForOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口支持通过传参，按照产品、项目、地域、计费模式和标签五个维度获取账单费用明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryResponse"/></returns>
        public Task<DescribeBillSummaryResponse> DescribeBillSummary(DescribeBillSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryResponse>(req, "DescribeBillSummary");
        }

        /// <summary>
        /// 该接口支持通过传参，按照产品、项目、地域、计费模式和标签五个维度获取账单费用明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryResponse"/></returns>
        public DescribeBillSummaryResponse DescribeBillSummarySync(DescribeBillSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryResponse>(req, "DescribeBillSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取按计费模式汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByPayModeRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByPayModeResponse"/></returns>
        public Task<DescribeBillSummaryByPayModeResponse> DescribeBillSummaryByPayMode(DescribeBillSummaryByPayModeRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByPayModeResponse>(req, "DescribeBillSummaryByPayMode");
        }

        /// <summary>
        /// 获取按计费模式汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByPayModeRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByPayModeResponse"/></returns>
        public DescribeBillSummaryByPayModeResponse DescribeBillSummaryByPayModeSync(DescribeBillSummaryByPayModeRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByPayModeResponse>(req, "DescribeBillSummaryByPayMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取产品汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProductResponse"/></returns>
        public Task<DescribeBillSummaryByProductResponse> DescribeBillSummaryByProduct(DescribeBillSummaryByProductRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByProductResponse>(req, "DescribeBillSummaryByProduct");
        }

        /// <summary>
        /// 获取产品汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProductResponse"/></returns>
        public DescribeBillSummaryByProductResponse DescribeBillSummaryByProductSync(DescribeBillSummaryByProductRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByProductResponse>(req, "DescribeBillSummaryByProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取按项目汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProjectResponse"/></returns>
        public Task<DescribeBillSummaryByProjectResponse> DescribeBillSummaryByProject(DescribeBillSummaryByProjectRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByProjectResponse>(req, "DescribeBillSummaryByProject");
        }

        /// <summary>
        /// 获取按项目汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProjectResponse"/></returns>
        public DescribeBillSummaryByProjectResponse DescribeBillSummaryByProjectSync(DescribeBillSummaryByProjectRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByProjectResponse>(req, "DescribeBillSummaryByProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取按地域汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByRegionResponse"/></returns>
        public Task<DescribeBillSummaryByRegionResponse> DescribeBillSummaryByRegion(DescribeBillSummaryByRegionRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByRegionResponse>(req, "DescribeBillSummaryByRegion");
        }

        /// <summary>
        /// 获取按地域汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByRegionResponse"/></returns>
        public DescribeBillSummaryByRegionResponse DescribeBillSummaryByRegionSync(DescribeBillSummaryByRegionRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByRegionResponse>(req, "DescribeBillSummaryByRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取按标签汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByTagRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByTagResponse"/></returns>
        public Task<DescribeBillSummaryByTagResponse> DescribeBillSummaryByTag(DescribeBillSummaryByTagRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByTagResponse>(req, "DescribeBillSummaryByTag");
        }

        /// <summary>
        /// 获取按标签汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByTagRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByTagResponse"/></returns>
        public DescribeBillSummaryByTagResponse DescribeBillSummaryByTagSync(DescribeBillSummaryByTagRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByTagResponse>(req, "DescribeBillSummaryByTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口支持通过传参，按照产品、项目、地域、计费模式和标签五个维度获取账单费用明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryForOrganizationResponse"/></returns>
        public Task<DescribeBillSummaryForOrganizationResponse> DescribeBillSummaryForOrganization(DescribeBillSummaryForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryForOrganizationResponse>(req, "DescribeBillSummaryForOrganization");
        }

        /// <summary>
        /// 该接口支持通过传参，按照产品、项目、地域、计费模式和标签五个维度获取账单费用明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryForOrganizationResponse"/></returns>
        public DescribeBillSummaryForOrganizationResponse DescribeBillSummaryForOrganizationSync(DescribeBillSummaryForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryForOrganizationResponse>(req, "DescribeBillSummaryForOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询消耗明细
        /// 
        /// 注意事项：
        /// 1. 对于消耗明细数据量级很大（例如每月消耗明细量级超过100w）的客户，通过 API 调用明细数据会有超时风险，建议您开通消耗账单数据存储功能，通过存储桶中获取账单文件进行分析。[账单存储至COS桶](https://cloud.tencent.com/document/product/555/61275)
        /// </summary>
        /// <param name="req"><see cref="DescribeCostDetailRequest"/></param>
        /// <returns><see cref="DescribeCostDetailResponse"/></returns>
        public Task<DescribeCostDetailResponse> DescribeCostDetail(DescribeCostDetailRequest req)
        {
            return InternalRequestAsync<DescribeCostDetailResponse>(req, "DescribeCostDetail");
        }

        /// <summary>
        /// 查询消耗明细
        /// 
        /// 注意事项：
        /// 1. 对于消耗明细数据量级很大（例如每月消耗明细量级超过100w）的客户，通过 API 调用明细数据会有超时风险，建议您开通消耗账单数据存储功能，通过存储桶中获取账单文件进行分析。[账单存储至COS桶](https://cloud.tencent.com/document/product/555/61275)
        /// </summary>
        /// <param name="req"><see cref="DescribeCostDetailRequest"/></param>
        /// <returns><see cref="DescribeCostDetailResponse"/></returns>
        public DescribeCostDetailResponse DescribeCostDetailSync(DescribeCostDetailRequest req)
        {
            return InternalRequestAsync<DescribeCostDetailResponse>(req, "DescribeCostDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看成本分析明细
        /// </summary>
        /// <param name="req"><see cref="DescribeCostExplorerSummaryRequest"/></param>
        /// <returns><see cref="DescribeCostExplorerSummaryResponse"/></returns>
        public Task<DescribeCostExplorerSummaryResponse> DescribeCostExplorerSummary(DescribeCostExplorerSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCostExplorerSummaryResponse>(req, "DescribeCostExplorerSummary");
        }

        /// <summary>
        /// 查看成本分析明细
        /// </summary>
        /// <param name="req"><see cref="DescribeCostExplorerSummaryRequest"/></param>
        /// <returns><see cref="DescribeCostExplorerSummaryResponse"/></returns>
        public DescribeCostExplorerSummaryResponse DescribeCostExplorerSummarySync(DescribeCostExplorerSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCostExplorerSummaryResponse>(req, "DescribeCostExplorerSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取按产品汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProductResponse"/></returns>
        public Task<DescribeCostSummaryByProductResponse> DescribeCostSummaryByProduct(DescribeCostSummaryByProductRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByProductResponse>(req, "DescribeCostSummaryByProduct");
        }

        /// <summary>
        /// 获取按产品汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProductResponse"/></returns>
        public DescribeCostSummaryByProductResponse DescribeCostSummaryByProductSync(DescribeCostSummaryByProductRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByProductResponse>(req, "DescribeCostSummaryByProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取按项目汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProjectResponse"/></returns>
        public Task<DescribeCostSummaryByProjectResponse> DescribeCostSummaryByProject(DescribeCostSummaryByProjectRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByProjectResponse>(req, "DescribeCostSummaryByProject");
        }

        /// <summary>
        /// 获取按项目汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProjectResponse"/></returns>
        public DescribeCostSummaryByProjectResponse DescribeCostSummaryByProjectSync(DescribeCostSummaryByProjectRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByProjectResponse>(req, "DescribeCostSummaryByProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取按地域汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByRegionResponse"/></returns>
        public Task<DescribeCostSummaryByRegionResponse> DescribeCostSummaryByRegion(DescribeCostSummaryByRegionRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByRegionResponse>(req, "DescribeCostSummaryByRegion");
        }

        /// <summary>
        /// 获取按地域汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByRegionResponse"/></returns>
        public DescribeCostSummaryByRegionResponse DescribeCostSummaryByRegionSync(DescribeCostSummaryByRegionRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByRegionResponse>(req, "DescribeCostSummaryByRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取按资源汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByResourceRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByResourceResponse"/></returns>
        public Task<DescribeCostSummaryByResourceResponse> DescribeCostSummaryByResource(DescribeCostSummaryByResourceRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByResourceResponse>(req, "DescribeCostSummaryByResource");
        }

        /// <summary>
        /// 获取按资源汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByResourceRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByResourceResponse"/></returns>
        public DescribeCostSummaryByResourceResponse DescribeCostSummaryByResourceSync(DescribeCostSummaryByResourceRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByResourceResponse>(req, "DescribeCostSummaryByResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="req"><see cref="DescribeDealsByCondRequest"/></param>
        /// <returns><see cref="DescribeDealsByCondResponse"/></returns>
        public Task<DescribeDealsByCondResponse> DescribeDealsByCond(DescribeDealsByCondRequest req)
        {
            return InternalRequestAsync<DescribeDealsByCondResponse>(req, "DescribeDealsByCond");
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="req"><see cref="DescribeDealsByCondRequest"/></param>
        /// <returns><see cref="DescribeDealsByCondResponse"/></returns>
        public DescribeDealsByCondResponse DescribeDealsByCondSync(DescribeDealsByCondRequest req)
        {
            return InternalRequestAsync<DescribeDealsByCondResponse>(req, "DescribeDealsByCond")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取COS产品用量明细
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageCosDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageCosDetailByDateResponse"/></returns>
        public Task<DescribeDosageCosDetailByDateResponse> DescribeDosageCosDetailByDate(DescribeDosageCosDetailByDateRequest req)
        {
            return InternalRequestAsync<DescribeDosageCosDetailByDateResponse>(req, "DescribeDosageCosDetailByDate");
        }

        /// <summary>
        /// 获取COS产品用量明细
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageCosDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageCosDetailByDateResponse"/></returns>
        public DescribeDosageCosDetailByDateResponse DescribeDosageCosDetailByDateSync(DescribeDosageCosDetailByDateRequest req)
        {
            return InternalRequestAsync<DescribeDosageCosDetailByDateResponse>(req, "DescribeDosageCosDetailByDate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按日期获取产品用量明细
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageDetailByDateResponse"/></returns>
        public Task<DescribeDosageDetailByDateResponse> DescribeDosageDetailByDate(DescribeDosageDetailByDateRequest req)
        {
            return InternalRequestAsync<DescribeDosageDetailByDateResponse>(req, "DescribeDosageDetailByDate");
        }

        /// <summary>
        /// 按日期获取产品用量明细
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageDetailByDateResponse"/></returns>
        public DescribeDosageDetailByDateResponse DescribeDosageDetailByDateSync(DescribeDosageDetailByDateRequest req)
        {
            return InternalRequestAsync<DescribeDosageDetailByDateResponse>(req, "DescribeDosageDetailByDate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取已接入标准用量明细模板产品的用量明细数据，目前已接入并支持查询的产品包括：云联络中心、实时音视频、实时音视频、智能媒资托管、CODING DevOps、全球IP应用加速
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageDetailListRequest"/></param>
        /// <returns><see cref="DescribeDosageDetailListResponse"/></returns>
        public Task<DescribeDosageDetailListResponse> DescribeDosageDetailList(DescribeDosageDetailListRequest req)
        {
            return InternalRequestAsync<DescribeDosageDetailListResponse>(req, "DescribeDosageDetailList");
        }

        /// <summary>
        /// 获取已接入标准用量明细模板产品的用量明细数据，目前已接入并支持查询的产品包括：云联络中心、实时音视频、实时音视频、智能媒资托管、CODING DevOps、全球IP应用加速
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageDetailListRequest"/></param>
        /// <returns><see cref="DescribeDosageDetailListResponse"/></returns>
        public DescribeDosageDetailListResponse DescribeDosageDetailListSync(DescribeDosageDetailListRequest req)
        {
            return InternalRequestAsync<DescribeDosageDetailListResponse>(req, "DescribeDosageDetailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分账账单资源归集汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeGatherResourceRequest"/></param>
        /// <returns><see cref="DescribeGatherResourceResponse"/></returns>
        public Task<DescribeGatherResourceResponse> DescribeGatherResource(DescribeGatherResourceRequest req)
        {
            return InternalRequestAsync<DescribeGatherResourceResponse>(req, "DescribeGatherResource");
        }

        /// <summary>
        /// 查询分账账单资源归集汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeGatherResourceRequest"/></param>
        /// <returns><see cref="DescribeGatherResourceResponse"/></returns>
        public DescribeGatherResourceResponse DescribeGatherResourceSync(DescribeGatherResourceRequest req)
        {
            return InternalRequestAsync<DescribeGatherResourceResponse>(req, "DescribeGatherResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前用户节省计划覆盖率明细数据，如无特别说明，金额单位均为元（国内站）或者美元（国际站）。
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanCoverageRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanCoverageResponse"/></returns>
        public Task<DescribeSavingPlanCoverageResponse> DescribeSavingPlanCoverage(DescribeSavingPlanCoverageRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanCoverageResponse>(req, "DescribeSavingPlanCoverage");
        }

        /// <summary>
        /// 查询当前用户节省计划覆盖率明细数据，如无特别说明，金额单位均为元（国内站）或者美元（国际站）。
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanCoverageRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanCoverageResponse"/></returns>
        public DescribeSavingPlanCoverageResponse DescribeSavingPlanCoverageSync(DescribeSavingPlanCoverageRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanCoverageResponse>(req, "DescribeSavingPlanCoverage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查用当前用户明细节省计划总览查询时段内的使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanOverviewRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanOverviewResponse"/></returns>
        public Task<DescribeSavingPlanOverviewResponse> DescribeSavingPlanOverview(DescribeSavingPlanOverviewRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanOverviewResponse>(req, "DescribeSavingPlanOverview");
        }

        /// <summary>
        /// 查用当前用户明细节省计划总览查询时段内的使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanOverviewRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanOverviewResponse"/></returns>
        public DescribeSavingPlanOverviewResponse DescribeSavingPlanOverviewSync(DescribeSavingPlanOverviewRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanOverviewResponse>(req, "DescribeSavingPlanOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询节省计划详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanResourceInfoRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanResourceInfoResponse"/></returns>
        public Task<DescribeSavingPlanResourceInfoResponse> DescribeSavingPlanResourceInfo(DescribeSavingPlanResourceInfoRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanResourceInfoResponse>(req, "DescribeSavingPlanResourceInfo");
        }

        /// <summary>
        /// 查询节省计划详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanResourceInfoRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanResourceInfoResponse"/></returns>
        public DescribeSavingPlanResourceInfoResponse DescribeSavingPlanResourceInfoSync(DescribeSavingPlanResourceInfoRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanResourceInfoResponse>(req, "DescribeSavingPlanResourceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查用当前用户明细节省计划查询时段内的使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanUsageRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanUsageResponse"/></returns>
        public Task<DescribeSavingPlanUsageResponse> DescribeSavingPlanUsage(DescribeSavingPlanUsageRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanUsageResponse>(req, "DescribeSavingPlanUsage");
        }

        /// <summary>
        /// 查用当前用户明细节省计划查询时段内的使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeSavingPlanUsageRequest"/></param>
        /// <returns><see cref="DescribeSavingPlanUsageResponse"/></returns>
        public DescribeSavingPlanUsageResponse DescribeSavingPlanUsageSync(DescribeSavingPlanUsageRequest req)
        {
            return InternalRequestAsync<DescribeSavingPlanUsageResponse>(req, "DescribeSavingPlanUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分账标签
        /// </summary>
        /// <param name="req"><see cref="DescribeTagListRequest"/></param>
        /// <returns><see cref="DescribeTagListResponse"/></returns>
        public Task<DescribeTagListResponse> DescribeTagList(DescribeTagListRequest req)
        {
            return InternalRequestAsync<DescribeTagListResponse>(req, "DescribeTagList");
        }

        /// <summary>
        /// 获取分账标签
        /// </summary>
        /// <param name="req"><see cref="DescribeTagListRequest"/></param>
        /// <returns><see cref="DescribeTagListResponse"/></returns>
        public DescribeTagListResponse DescribeTagListSync(DescribeTagListRequest req)
        {
            return InternalRequestAsync<DescribeTagListResponse>(req, "DescribeTagList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取代金券相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherInfoRequest"/></param>
        /// <returns><see cref="DescribeVoucherInfoResponse"/></returns>
        public Task<DescribeVoucherInfoResponse> DescribeVoucherInfo(DescribeVoucherInfoRequest req)
        {
            return InternalRequestAsync<DescribeVoucherInfoResponse>(req, "DescribeVoucherInfo");
        }

        /// <summary>
        /// 获取代金券相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherInfoRequest"/></param>
        /// <returns><see cref="DescribeVoucherInfoResponse"/></returns>
        public DescribeVoucherInfoResponse DescribeVoucherInfoSync(DescribeVoucherInfoRequest req)
        {
            return InternalRequestAsync<DescribeVoucherInfoResponse>(req, "DescribeVoucherInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取代金券使用记录
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherUsageDetailsRequest"/></param>
        /// <returns><see cref="DescribeVoucherUsageDetailsResponse"/></returns>
        public Task<DescribeVoucherUsageDetailsResponse> DescribeVoucherUsageDetails(DescribeVoucherUsageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeVoucherUsageDetailsResponse>(req, "DescribeVoucherUsageDetails");
        }

        /// <summary>
        /// 获取代金券使用记录
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherUsageDetailsRequest"/></param>
        /// <returns><see cref="DescribeVoucherUsageDetailsResponse"/></returns>
        public DescribeVoucherUsageDetailsResponse DescribeVoucherUsageDetailsSync(DescribeVoucherUsageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeVoucherUsageDetailsResponse>(req, "DescribeVoucherUsageDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 支付订单
        /// </summary>
        /// <param name="req"><see cref="PayDealsRequest"/></param>
        /// <returns><see cref="PayDealsResponse"/></returns>
        public Task<PayDealsResponse> PayDeals(PayDealsRequest req)
        {
            return InternalRequestAsync<PayDealsResponse>(req, "PayDeals");
        }

        /// <summary>
        /// 支付订单
        /// </summary>
        /// <param name="req"><see cref="PayDealsRequest"/></param>
        /// <returns><see cref="PayDealsResponse"/></returns>
        public PayDealsResponse PayDealsSync(PayDealsRequest req)
        {
            return InternalRequestAsync<PayDealsResponse>(req, "PayDeals")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
