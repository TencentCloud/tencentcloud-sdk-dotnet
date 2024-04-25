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

namespace TencentCloud.Ssl.V20191205
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ssl.V20191205.Models;

   public class SslClient : AbstractClient{

       private const string endpoint = "ssl.tencentcloudapi.com";
       private const string version = "2019-12-05";
       private const string sdkVersion = "SDK_NET_3.0.994";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SslClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SslClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（ApplyCertificate）用于免费证书申请。
        /// </summary>
        /// <param name="req"><see cref="ApplyCertificateRequest"/></param>
        /// <returns><see cref="ApplyCertificateResponse"/></returns>
        public Task<ApplyCertificateResponse> ApplyCertificate(ApplyCertificateRequest req)
        {
            return InternalRequestAsync<ApplyCertificateResponse>(req, "ApplyCertificate");
        }

        /// <summary>
        /// 本接口（ApplyCertificate）用于免费证书申请。
        /// </summary>
        /// <param name="req"><see cref="ApplyCertificateRequest"/></param>
        /// <returns><see cref="ApplyCertificateResponse"/></returns>
        public ApplyCertificateResponse ApplyCertificateSync(ApplyCertificateRequest req)
        {
            return InternalRequestAsync<ApplyCertificateResponse>(req, "ApplyCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消证书审核
        /// </summary>
        /// <param name="req"><see cref="CancelAuditCertificateRequest"/></param>
        /// <returns><see cref="CancelAuditCertificateResponse"/></returns>
        public Task<CancelAuditCertificateResponse> CancelAuditCertificate(CancelAuditCertificateRequest req)
        {
            return InternalRequestAsync<CancelAuditCertificateResponse>(req, "CancelAuditCertificate");
        }

        /// <summary>
        /// 取消证书审核
        /// </summary>
        /// <param name="req"><see cref="CancelAuditCertificateRequest"/></param>
        /// <returns><see cref="CancelAuditCertificateResponse"/></returns>
        public CancelAuditCertificateResponse CancelAuditCertificateSync(CancelAuditCertificateRequest req)
        {
            return InternalRequestAsync<CancelAuditCertificateResponse>(req, "CancelAuditCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消证书订单。
        /// </summary>
        /// <param name="req"><see cref="CancelCertificateOrderRequest"/></param>
        /// <returns><see cref="CancelCertificateOrderResponse"/></returns>
        public Task<CancelCertificateOrderResponse> CancelCertificateOrder(CancelCertificateOrderRequest req)
        {
            return InternalRequestAsync<CancelCertificateOrderResponse>(req, "CancelCertificateOrder");
        }

        /// <summary>
        /// 取消证书订单。
        /// </summary>
        /// <param name="req"><see cref="CancelCertificateOrderRequest"/></param>
        /// <returns><see cref="CancelCertificateOrderResponse"/></returns>
        public CancelCertificateOrderResponse CancelCertificateOrderSync(CancelCertificateOrderRequest req)
        {
            return InternalRequestAsync<CancelCertificateOrderResponse>(req, "CancelCertificateOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CheckCertificateChain）用于检查证书链是否完整。
        /// </summary>
        /// <param name="req"><see cref="CheckCertificateChainRequest"/></param>
        /// <returns><see cref="CheckCertificateChainResponse"/></returns>
        public Task<CheckCertificateChainResponse> CheckCertificateChain(CheckCertificateChainRequest req)
        {
            return InternalRequestAsync<CheckCertificateChainResponse>(req, "CheckCertificateChain");
        }

        /// <summary>
        /// 本接口（CheckCertificateChain）用于检查证书链是否完整。
        /// </summary>
        /// <param name="req"><see cref="CheckCertificateChainRequest"/></param>
        /// <returns><see cref="CheckCertificateChainResponse"/></returns>
        public CheckCertificateChainResponse CheckCertificateChainSync(CheckCertificateChainRequest req)
        {
            return InternalRequestAsync<CheckCertificateChainResponse>(req, "CheckCertificateChain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交证书订单。
        /// </summary>
        /// <param name="req"><see cref="CommitCertificateInformationRequest"/></param>
        /// <returns><see cref="CommitCertificateInformationResponse"/></returns>
        public Task<CommitCertificateInformationResponse> CommitCertificateInformation(CommitCertificateInformationRequest req)
        {
            return InternalRequestAsync<CommitCertificateInformationResponse>(req, "CommitCertificateInformation");
        }

        /// <summary>
        /// 提交证书订单。
        /// </summary>
        /// <param name="req"><see cref="CommitCertificateInformationRequest"/></param>
        /// <returns><see cref="CommitCertificateInformationResponse"/></returns>
        public CommitCertificateInformationResponse CommitCertificateInformationSync(CommitCertificateInformationRequest req)
        {
            return InternalRequestAsync<CommitCertificateInformationResponse>(req, "CommitCertificateInformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CompleteCertificate）用于主动触发证书验证。仅非DNSPod和Wotrus品牌证书支持使用此接口。
        /// </summary>
        /// <param name="req"><see cref="CompleteCertificateRequest"/></param>
        /// <returns><see cref="CompleteCertificateResponse"/></returns>
        public Task<CompleteCertificateResponse> CompleteCertificate(CompleteCertificateRequest req)
        {
            return InternalRequestAsync<CompleteCertificateResponse>(req, "CompleteCertificate");
        }

        /// <summary>
        /// 本接口（CompleteCertificate）用于主动触发证书验证。仅非DNSPod和Wotrus品牌证书支持使用此接口。
        /// </summary>
        /// <param name="req"><see cref="CompleteCertificateRequest"/></param>
        /// <returns><see cref="CompleteCertificateResponse"/></returns>
        public CompleteCertificateResponse CompleteCertificateSync(CompleteCertificateRequest req)
        {
            return InternalRequestAsync<CompleteCertificateResponse>(req, "CompleteCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateCertificate）用于创建付费证书。
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public Task<CreateCertificateResponse> CreateCertificate(CreateCertificateRequest req)
        {
            return InternalRequestAsync<CreateCertificateResponse>(req, "CreateCertificate");
        }

        /// <summary>
        /// 本接口（CreateCertificate）用于创建付费证书。
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public CreateCertificateResponse CreateCertificateSync(CreateCertificateRequest req)
        {
            return InternalRequestAsync<CreateCertificateResponse>(req, "CreateCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建证书绑定关联云资源异步任务， 该接口用于查询证书关联云资源。 若证书ID已存在查询云资源任务，则结果返回该任务ID。关联云资源类型，支持以下云资源：clb、cdn、waf、live、vod、ddos、tke、apigateway、tcb、teo（edgeOne）。查询关联云资源结果使用DescribeCertificateBindResourceTaskResult接口
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateBindResourceSyncTaskRequest"/></param>
        /// <returns><see cref="CreateCertificateBindResourceSyncTaskResponse"/></returns>
        public Task<CreateCertificateBindResourceSyncTaskResponse> CreateCertificateBindResourceSyncTask(CreateCertificateBindResourceSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateCertificateBindResourceSyncTaskResponse>(req, "CreateCertificateBindResourceSyncTask");
        }

        /// <summary>
        /// 创建证书绑定关联云资源异步任务， 该接口用于查询证书关联云资源。 若证书ID已存在查询云资源任务，则结果返回该任务ID。关联云资源类型，支持以下云资源：clb、cdn、waf、live、vod、ddos、tke、apigateway、tcb、teo（edgeOne）。查询关联云资源结果使用DescribeCertificateBindResourceTaskResult接口
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateBindResourceSyncTaskRequest"/></param>
        /// <returns><see cref="CreateCertificateBindResourceSyncTaskResponse"/></returns>
        public CreateCertificateBindResourceSyncTaskResponse CreateCertificateBindResourceSyncTaskSync(CreateCertificateBindResourceSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateCertificateBindResourceSyncTaskResponse>(req, "CreateCertificateBindResourceSyncTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用权益点创建证书
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateByPackageRequest"/></param>
        /// <returns><see cref="CreateCertificateByPackageResponse"/></returns>
        public Task<CreateCertificateByPackageResponse> CreateCertificateByPackage(CreateCertificateByPackageRequest req)
        {
            return InternalRequestAsync<CreateCertificateByPackageResponse>(req, "CreateCertificateByPackage");
        }

        /// <summary>
        /// 使用权益点创建证书
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateByPackageRequest"/></param>
        /// <returns><see cref="CreateCertificateByPackageResponse"/></returns>
        public CreateCertificateByPackageResponse CreateCertificateByPackageSync(CreateCertificateByPackageRequest req)
        {
            return InternalRequestAsync<CreateCertificateByPackageResponse>(req, "CreateCertificateByPackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteCertificate）用于删除证书。
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public Task<DeleteCertificateResponse> DeleteCertificate(DeleteCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCertificateResponse>(req, "DeleteCertificate");
        }

        /// <summary>
        /// 本接口（DeleteCertificate）用于删除证书。
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public DeleteCertificateResponse DeleteCertificateSync(DeleteCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCertificateResponse>(req, "DeleteCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除管理人
        /// </summary>
        /// <param name="req"><see cref="DeleteManagerRequest"/></param>
        /// <returns><see cref="DeleteManagerResponse"/></returns>
        public Task<DeleteManagerResponse> DeleteManager(DeleteManagerRequest req)
        {
            return InternalRequestAsync<DeleteManagerResponse>(req, "DeleteManager");
        }

        /// <summary>
        /// 删除管理人
        /// </summary>
        /// <param name="req"><see cref="DeleteManagerRequest"/></param>
        /// <returns><see cref="DeleteManagerResponse"/></returns>
        public DeleteManagerResponse DeleteManagerSync(DeleteManagerRequest req)
        {
            return InternalRequestAsync<DeleteManagerResponse>(req, "DeleteManager")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 证书部署到云资源实例列表
        /// </summary>
        /// <param name="req"><see cref="DeployCertificateInstanceRequest"/></param>
        /// <returns><see cref="DeployCertificateInstanceResponse"/></returns>
        public Task<DeployCertificateInstanceResponse> DeployCertificateInstance(DeployCertificateInstanceRequest req)
        {
            return InternalRequestAsync<DeployCertificateInstanceResponse>(req, "DeployCertificateInstance");
        }

        /// <summary>
        /// 证书部署到云资源实例列表
        /// </summary>
        /// <param name="req"><see cref="DeployCertificateInstanceRequest"/></param>
        /// <returns><see cref="DeployCertificateInstanceResponse"/></returns>
        public DeployCertificateInstanceResponse DeployCertificateInstanceSync(DeployCertificateInstanceRequest req)
        {
            return InternalRequestAsync<DeployCertificateInstanceResponse>(req, "DeployCertificateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云资源部署重试部署记录
        /// </summary>
        /// <param name="req"><see cref="DeployCertificateRecordRetryRequest"/></param>
        /// <returns><see cref="DeployCertificateRecordRetryResponse"/></returns>
        public Task<DeployCertificateRecordRetryResponse> DeployCertificateRecordRetry(DeployCertificateRecordRetryRequest req)
        {
            return InternalRequestAsync<DeployCertificateRecordRetryResponse>(req, "DeployCertificateRecordRetry");
        }

        /// <summary>
        /// 云资源部署重试部署记录
        /// </summary>
        /// <param name="req"><see cref="DeployCertificateRecordRetryRequest"/></param>
        /// <returns><see cref="DeployCertificateRecordRetryResponse"/></returns>
        public DeployCertificateRecordRetryResponse DeployCertificateRecordRetrySync(DeployCertificateRecordRetryRequest req)
        {
            return InternalRequestAsync<DeployCertificateRecordRetryResponse>(req, "DeployCertificateRecordRetry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云资源部署一键回滚
        /// </summary>
        /// <param name="req"><see cref="DeployCertificateRecordRollbackRequest"/></param>
        /// <returns><see cref="DeployCertificateRecordRollbackResponse"/></returns>
        public Task<DeployCertificateRecordRollbackResponse> DeployCertificateRecordRollback(DeployCertificateRecordRollbackRequest req)
        {
            return InternalRequestAsync<DeployCertificateRecordRollbackResponse>(req, "DeployCertificateRecordRollback");
        }

        /// <summary>
        /// 云资源部署一键回滚
        /// </summary>
        /// <param name="req"><see cref="DeployCertificateRecordRollbackRequest"/></param>
        /// <returns><see cref="DeployCertificateRecordRollbackResponse"/></returns>
        public DeployCertificateRecordRollbackResponse DeployCertificateRecordRollbackSync(DeployCertificateRecordRollbackRequest req)
        {
            return InternalRequestAsync<DeployCertificateRecordRollbackResponse>(req, "DeployCertificateRecordRollback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCertificate）用于获取证书信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateRequest"/></param>
        /// <returns><see cref="DescribeCertificateResponse"/></returns>
        public Task<DescribeCertificateResponse> DescribeCertificate(DescribeCertificateRequest req)
        {
            return InternalRequestAsync<DescribeCertificateResponse>(req, "DescribeCertificate");
        }

        /// <summary>
        /// 本接口（DescribeCertificate）用于获取证书信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateRequest"/></param>
        /// <returns><see cref="DescribeCertificateResponse"/></returns>
        public DescribeCertificateResponse DescribeCertificateSync(DescribeCertificateRequest req)
        {
            return InternalRequestAsync<DescribeCertificateResponse>(req, "DescribeCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询CreateCertificateBindResourceSyncTask任务结果， 返回证书关联云资源异步任务结果， 支持以下云资源：clb、cdn、waf、live、vod、ddos、tke、apigateway、tcb、teo（edgeOne）
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskDetailResponse"/></returns>
        public Task<DescribeCertificateBindResourceTaskDetailResponse> DescribeCertificateBindResourceTaskDetail(DescribeCertificateBindResourceTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateBindResourceTaskDetailResponse>(req, "DescribeCertificateBindResourceTaskDetail");
        }

        /// <summary>
        /// 查询CreateCertificateBindResourceSyncTask任务结果， 返回证书关联云资源异步任务结果， 支持以下云资源：clb、cdn、waf、live、vod、ddos、tke、apigateway、tcb、teo（edgeOne）
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskDetailResponse"/></returns>
        public DescribeCertificateBindResourceTaskDetailResponse DescribeCertificateBindResourceTaskDetailSync(DescribeCertificateBindResourceTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateBindResourceTaskDetailResponse>(req, "DescribeCertificateBindResourceTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询CreateCertificateBindResourceSyncTask任务结果， 返回证书关联云资源异步任务结果， 支持以下云资源：clb、cdn、waf、live、vod、ddos、tke、apigateway、tcb、teo（edgeOne）
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskResultResponse"/></returns>
        public Task<DescribeCertificateBindResourceTaskResultResponse> DescribeCertificateBindResourceTaskResult(DescribeCertificateBindResourceTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeCertificateBindResourceTaskResultResponse>(req, "DescribeCertificateBindResourceTaskResult");
        }

        /// <summary>
        /// 查询CreateCertificateBindResourceSyncTask任务结果， 返回证书关联云资源异步任务结果， 支持以下云资源：clb、cdn、waf、live、vod、ddos、tke、apigateway、tcb、teo（edgeOne）
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskResultResponse"/></returns>
        public DescribeCertificateBindResourceTaskResultResponse DescribeCertificateBindResourceTaskResultSync(DescribeCertificateBindResourceTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeCertificateBindResourceTaskResultResponse>(req, "DescribeCertificateBindResourceTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取证书详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public Task<DescribeCertificateDetailResponse> DescribeCertificateDetail(DescribeCertificateDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateDetailResponse>(req, "DescribeCertificateDetail");
        }

        /// <summary>
        /// 获取证书详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public DescribeCertificateDetailResponse DescribeCertificateDetailSync(DescribeCertificateDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateDetailResponse>(req, "DescribeCertificateDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户账号下有关证书的操作日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateOperateLogsRequest"/></param>
        /// <returns><see cref="DescribeCertificateOperateLogsResponse"/></returns>
        public Task<DescribeCertificateOperateLogsResponse> DescribeCertificateOperateLogs(DescribeCertificateOperateLogsRequest req)
        {
            return InternalRequestAsync<DescribeCertificateOperateLogsResponse>(req, "DescribeCertificateOperateLogs");
        }

        /// <summary>
        /// 获取用户账号下有关证书的操作日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateOperateLogsRequest"/></param>
        /// <returns><see cref="DescribeCertificateOperateLogsResponse"/></returns>
        public DescribeCertificateOperateLogsResponse DescribeCertificateOperateLogsSync(DescribeCertificateOperateLogsRequest req)
        {
            return InternalRequestAsync<DescribeCertificateOperateLogsResponse>(req, "DescribeCertificateOperateLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCertificates）用于获取证书列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public Task<DescribeCertificatesResponse> DescribeCertificates(DescribeCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCertificatesResponse>(req, "DescribeCertificates");
        }

        /// <summary>
        /// 本接口（DescribeCertificates）用于获取证书列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public DescribeCertificatesResponse DescribeCertificatesSync(DescribeCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCertificatesResponse>(req, "DescribeCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询公司列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCompaniesRequest"/></param>
        /// <returns><see cref="DescribeCompaniesResponse"/></returns>
        public Task<DescribeCompaniesResponse> DescribeCompanies(DescribeCompaniesRequest req)
        {
            return InternalRequestAsync<DescribeCompaniesResponse>(req, "DescribeCompanies");
        }

        /// <summary>
        /// 查询公司列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCompaniesRequest"/></param>
        /// <returns><see cref="DescribeCompaniesResponse"/></returns>
        public DescribeCompaniesResponse DescribeCompaniesSync(DescribeCompaniesRequest req)
        {
            return InternalRequestAsync<DescribeCompaniesResponse>(req, "DescribeCompanies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询批量删除任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeDeleteCertificatesTaskResultRequest"/></param>
        /// <returns><see cref="DescribeDeleteCertificatesTaskResultResponse"/></returns>
        public Task<DescribeDeleteCertificatesTaskResultResponse> DescribeDeleteCertificatesTaskResult(DescribeDeleteCertificatesTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeDeleteCertificatesTaskResultResponse>(req, "DescribeDeleteCertificatesTaskResult");
        }

        /// <summary>
        /// 查询批量删除任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeDeleteCertificatesTaskResultRequest"/></param>
        /// <returns><see cref="DescribeDeleteCertificatesTaskResultResponse"/></returns>
        public DescribeDeleteCertificatesTaskResultResponse DescribeDeleteCertificatesTaskResultSync(DescribeDeleteCertificatesTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeDeleteCertificatesTaskResultResponse>(req, "DescribeDeleteCertificatesTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 证书查询关联资源， 最新查询接口请使用CreateCertificateBindResourceSyncTask， 可以查询更多支持的云资源
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployedResourcesRequest"/></param>
        /// <returns><see cref="DescribeDeployedResourcesResponse"/></returns>
        public Task<DescribeDeployedResourcesResponse> DescribeDeployedResources(DescribeDeployedResourcesRequest req)
        {
            return InternalRequestAsync<DescribeDeployedResourcesResponse>(req, "DescribeDeployedResources");
        }

        /// <summary>
        /// 证书查询关联资源， 最新查询接口请使用CreateCertificateBindResourceSyncTask， 可以查询更多支持的云资源
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployedResourcesRequest"/></param>
        /// <returns><see cref="DescribeDeployedResourcesResponse"/></returns>
        public DescribeDeployedResourcesResponse DescribeDeployedResourcesSync(DescribeDeployedResourcesRequest req)
        {
            return InternalRequestAsync<DescribeDeployedResourcesResponse>(req, "DescribeDeployedResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书apiGateway云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostApiGatewayInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostApiGatewayInstanceListResponse"/></returns>
        public Task<DescribeHostApiGatewayInstanceListResponse> DescribeHostApiGatewayInstanceList(DescribeHostApiGatewayInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostApiGatewayInstanceListResponse>(req, "DescribeHostApiGatewayInstanceList");
        }

        /// <summary>
        /// 查询证书apiGateway云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostApiGatewayInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostApiGatewayInstanceListResponse"/></returns>
        public DescribeHostApiGatewayInstanceListResponse DescribeHostApiGatewayInstanceListSync(DescribeHostApiGatewayInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostApiGatewayInstanceListResponse>(req, "DescribeHostApiGatewayInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书cdn云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostCdnInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostCdnInstanceListResponse"/></returns>
        public Task<DescribeHostCdnInstanceListResponse> DescribeHostCdnInstanceList(DescribeHostCdnInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostCdnInstanceListResponse>(req, "DescribeHostCdnInstanceList");
        }

        /// <summary>
        /// 查询证书cdn云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostCdnInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostCdnInstanceListResponse"/></returns>
        public DescribeHostCdnInstanceListResponse DescribeHostCdnInstanceListSync(DescribeHostCdnInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostCdnInstanceListResponse>(req, "DescribeHostCdnInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书clb云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostClbInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostClbInstanceListResponse"/></returns>
        public Task<DescribeHostClbInstanceListResponse> DescribeHostClbInstanceList(DescribeHostClbInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostClbInstanceListResponse>(req, "DescribeHostClbInstanceList");
        }

        /// <summary>
        /// 查询证书clb云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostClbInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostClbInstanceListResponse"/></returns>
        public DescribeHostClbInstanceListResponse DescribeHostClbInstanceListSync(DescribeHostClbInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostClbInstanceListResponse>(req, "DescribeHostClbInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书cos云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostCosInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostCosInstanceListResponse"/></returns>
        public Task<DescribeHostCosInstanceListResponse> DescribeHostCosInstanceList(DescribeHostCosInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostCosInstanceListResponse>(req, "DescribeHostCosInstanceList");
        }

        /// <summary>
        /// 查询证书cos云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostCosInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostCosInstanceListResponse"/></returns>
        public DescribeHostCosInstanceListResponse DescribeHostCosInstanceListSync(DescribeHostCosInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostCosInstanceListResponse>(req, "DescribeHostCosInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书ddos云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostDdosInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostDdosInstanceListResponse"/></returns>
        public Task<DescribeHostDdosInstanceListResponse> DescribeHostDdosInstanceList(DescribeHostDdosInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostDdosInstanceListResponse>(req, "DescribeHostDdosInstanceList");
        }

        /// <summary>
        /// 查询证书ddos云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostDdosInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostDdosInstanceListResponse"/></returns>
        public DescribeHostDdosInstanceListResponse DescribeHostDdosInstanceListSync(DescribeHostDdosInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostDdosInstanceListResponse>(req, "DescribeHostDdosInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书云资源部署记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostDeployRecordRequest"/></param>
        /// <returns><see cref="DescribeHostDeployRecordResponse"/></returns>
        public Task<DescribeHostDeployRecordResponse> DescribeHostDeployRecord(DescribeHostDeployRecordRequest req)
        {
            return InternalRequestAsync<DescribeHostDeployRecordResponse>(req, "DescribeHostDeployRecord");
        }

        /// <summary>
        /// 查询证书云资源部署记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostDeployRecordRequest"/></param>
        /// <returns><see cref="DescribeHostDeployRecordResponse"/></returns>
        public DescribeHostDeployRecordResponse DescribeHostDeployRecordSync(DescribeHostDeployRecordRequest req)
        {
            return InternalRequestAsync<DescribeHostDeployRecordResponse>(req, "DescribeHostDeployRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书云资源部署记录详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostDeployRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeHostDeployRecordDetailResponse"/></returns>
        public Task<DescribeHostDeployRecordDetailResponse> DescribeHostDeployRecordDetail(DescribeHostDeployRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeHostDeployRecordDetailResponse>(req, "DescribeHostDeployRecordDetail");
        }

        /// <summary>
        /// 查询证书云资源部署记录详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostDeployRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeHostDeployRecordDetailResponse"/></returns>
        public DescribeHostDeployRecordDetailResponse DescribeHostDeployRecordDetailSync(DescribeHostDeployRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeHostDeployRecordDetailResponse>(req, "DescribeHostDeployRecordDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书Lighthouse云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLighthouseInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostLighthouseInstanceListResponse"/></returns>
        public Task<DescribeHostLighthouseInstanceListResponse> DescribeHostLighthouseInstanceList(DescribeHostLighthouseInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostLighthouseInstanceListResponse>(req, "DescribeHostLighthouseInstanceList");
        }

        /// <summary>
        /// 查询证书Lighthouse云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLighthouseInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostLighthouseInstanceListResponse"/></returns>
        public DescribeHostLighthouseInstanceListResponse DescribeHostLighthouseInstanceListSync(DescribeHostLighthouseInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostLighthouseInstanceListResponse>(req, "DescribeHostLighthouseInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书live云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLiveInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostLiveInstanceListResponse"/></returns>
        public Task<DescribeHostLiveInstanceListResponse> DescribeHostLiveInstanceList(DescribeHostLiveInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostLiveInstanceListResponse>(req, "DescribeHostLiveInstanceList");
        }

        /// <summary>
        /// 查询证书live云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLiveInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostLiveInstanceListResponse"/></returns>
        public DescribeHostLiveInstanceListResponse DescribeHostLiveInstanceListSync(DescribeHostLiveInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostLiveInstanceListResponse>(req, "DescribeHostLiveInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书EdgeOne云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostTeoInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostTeoInstanceListResponse"/></returns>
        public Task<DescribeHostTeoInstanceListResponse> DescribeHostTeoInstanceList(DescribeHostTeoInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostTeoInstanceListResponse>(req, "DescribeHostTeoInstanceList");
        }

        /// <summary>
        /// 查询证书EdgeOne云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostTeoInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostTeoInstanceListResponse"/></returns>
        public DescribeHostTeoInstanceListResponse DescribeHostTeoInstanceListSync(DescribeHostTeoInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostTeoInstanceListResponse>(req, "DescribeHostTeoInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书tke云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostTkeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostTkeInstanceListResponse"/></returns>
        public Task<DescribeHostTkeInstanceListResponse> DescribeHostTkeInstanceList(DescribeHostTkeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostTkeInstanceListResponse>(req, "DescribeHostTkeInstanceList");
        }

        /// <summary>
        /// 查询证书tke云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostTkeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostTkeInstanceListResponse"/></returns>
        public DescribeHostTkeInstanceListResponse DescribeHostTkeInstanceListSync(DescribeHostTkeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostTkeInstanceListResponse>(req, "DescribeHostTkeInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书云资源更新记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordResponse"/></returns>
        public Task<DescribeHostUpdateRecordResponse> DescribeHostUpdateRecord(DescribeHostUpdateRecordRequest req)
        {
            return InternalRequestAsync<DescribeHostUpdateRecordResponse>(req, "DescribeHostUpdateRecord");
        }

        /// <summary>
        /// 查询证书云资源更新记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordResponse"/></returns>
        public DescribeHostUpdateRecordResponse DescribeHostUpdateRecordSync(DescribeHostUpdateRecordRequest req)
        {
            return InternalRequestAsync<DescribeHostUpdateRecordResponse>(req, "DescribeHostUpdateRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书云资源更新记录详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordDetailResponse"/></returns>
        public Task<DescribeHostUpdateRecordDetailResponse> DescribeHostUpdateRecordDetail(DescribeHostUpdateRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeHostUpdateRecordDetailResponse>(req, "DescribeHostUpdateRecordDetail");
        }

        /// <summary>
        /// 查询证书云资源更新记录详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordDetailResponse"/></returns>
        public DescribeHostUpdateRecordDetailResponse DescribeHostUpdateRecordDetailSync(DescribeHostUpdateRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeHostUpdateRecordDetailResponse>(req, "DescribeHostUpdateRecordDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书Vod云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVodInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostVodInstanceListResponse"/></returns>
        public Task<DescribeHostVodInstanceListResponse> DescribeHostVodInstanceList(DescribeHostVodInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostVodInstanceListResponse>(req, "DescribeHostVodInstanceList");
        }

        /// <summary>
        /// 查询证书Vod云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVodInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostVodInstanceListResponse"/></returns>
        public DescribeHostVodInstanceListResponse DescribeHostVodInstanceListSync(DescribeHostVodInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostVodInstanceListResponse>(req, "DescribeHostVodInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询证书waf云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostWafInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostWafInstanceListResponse"/></returns>
        public Task<DescribeHostWafInstanceListResponse> DescribeHostWafInstanceList(DescribeHostWafInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostWafInstanceListResponse>(req, "DescribeHostWafInstanceList");
        }

        /// <summary>
        /// 查询证书waf云资源部署实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostWafInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostWafInstanceListResponse"/></returns>
        public DescribeHostWafInstanceListResponse DescribeHostWafInstanceListSync(DescribeHostWafInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostWafInstanceListResponse>(req, "DescribeHostWafInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询管理人详情
        /// </summary>
        /// <param name="req"><see cref="DescribeManagerDetailRequest"/></param>
        /// <returns><see cref="DescribeManagerDetailResponse"/></returns>
        public Task<DescribeManagerDetailResponse> DescribeManagerDetail(DescribeManagerDetailRequest req)
        {
            return InternalRequestAsync<DescribeManagerDetailResponse>(req, "DescribeManagerDetail");
        }

        /// <summary>
        /// 查询管理人详情
        /// </summary>
        /// <param name="req"><see cref="DescribeManagerDetailRequest"/></param>
        /// <returns><see cref="DescribeManagerDetailResponse"/></returns>
        public DescribeManagerDetailResponse DescribeManagerDetailSync(DescribeManagerDetailRequest req)
        {
            return InternalRequestAsync<DescribeManagerDetailResponse>(req, "DescribeManagerDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询管理人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeManagersRequest"/></param>
        /// <returns><see cref="DescribeManagersResponse"/></returns>
        public Task<DescribeManagersResponse> DescribeManagers(DescribeManagersRequest req)
        {
            return InternalRequestAsync<DescribeManagersResponse>(req, "DescribeManagers");
        }

        /// <summary>
        /// 查询管理人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeManagersRequest"/></param>
        /// <returns><see cref="DescribeManagersResponse"/></returns>
        public DescribeManagersResponse DescribeManagersSync(DescribeManagersRequest req)
        {
            return InternalRequestAsync<DescribeManagersResponse>(req, "DescribeManagers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获得权益包列表
        /// </summary>
        /// <param name="req"><see cref="DescribePackagesRequest"/></param>
        /// <returns><see cref="DescribePackagesResponse"/></returns>
        public Task<DescribePackagesResponse> DescribePackages(DescribePackagesRequest req)
        {
            return InternalRequestAsync<DescribePackagesResponse>(req, "DescribePackages");
        }

        /// <summary>
        /// 获得权益包列表
        /// </summary>
        /// <param name="req"><see cref="DescribePackagesRequest"/></param>
        /// <returns><see cref="DescribePackagesResponse"/></returns>
        public DescribePackagesResponse DescribePackagesSync(DescribePackagesRequest req)
        {
            return InternalRequestAsync<DescribePackagesResponse>(req, "DescribePackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DownloadCertificate）用于下载证书。
        /// </summary>
        /// <param name="req"><see cref="DownloadCertificateRequest"/></param>
        /// <returns><see cref="DownloadCertificateResponse"/></returns>
        public Task<DownloadCertificateResponse> DownloadCertificate(DownloadCertificateRequest req)
        {
            return InternalRequestAsync<DownloadCertificateResponse>(req, "DownloadCertificate");
        }

        /// <summary>
        /// 本接口（DownloadCertificate）用于下载证书。
        /// </summary>
        /// <param name="req"><see cref="DownloadCertificateRequest"/></param>
        /// <returns><see cref="DownloadCertificateResponse"/></returns>
        public DownloadCertificateResponse DownloadCertificateSync(DownloadCertificateRequest req)
        {
            return InternalRequestAsync<DownloadCertificateResponse>(req, "DownloadCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户传入证书id和备注来修改证书备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAliasRequest"/></param>
        /// <returns><see cref="ModifyCertificateAliasResponse"/></returns>
        public Task<ModifyCertificateAliasResponse> ModifyCertificateAlias(ModifyCertificateAliasRequest req)
        {
            return InternalRequestAsync<ModifyCertificateAliasResponse>(req, "ModifyCertificateAlias");
        }

        /// <summary>
        /// 用户传入证书id和备注来修改证书备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAliasRequest"/></param>
        /// <returns><see cref="ModifyCertificateAliasResponse"/></returns>
        public ModifyCertificateAliasResponse ModifyCertificateAliasSync(ModifyCertificateAliasRequest req)
        {
            return InternalRequestAsync<ModifyCertificateAliasResponse>(req, "ModifyCertificateAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改证书所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateProjectRequest"/></param>
        /// <returns><see cref="ModifyCertificateProjectResponse"/></returns>
        public Task<ModifyCertificateProjectResponse> ModifyCertificateProject(ModifyCertificateProjectRequest req)
        {
            return InternalRequestAsync<ModifyCertificateProjectResponse>(req, "ModifyCertificateProject");
        }

        /// <summary>
        /// 批量修改证书所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateProjectRequest"/></param>
        /// <returns><see cref="ModifyCertificateProjectResponse"/></returns>
        public ModifyCertificateProjectResponse ModifyCertificateProjectSync(ModifyCertificateProjectRequest req)
        {
            return InternalRequestAsync<ModifyCertificateProjectResponse>(req, "ModifyCertificateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 针对审核失败或审核取消的付费证书，重新发起审核
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateResubmitRequest"/></param>
        /// <returns><see cref="ModifyCertificateResubmitResponse"/></returns>
        public Task<ModifyCertificateResubmitResponse> ModifyCertificateResubmit(ModifyCertificateResubmitRequest req)
        {
            return InternalRequestAsync<ModifyCertificateResubmitResponse>(req, "ModifyCertificateResubmit");
        }

        /// <summary>
        /// 针对审核失败或审核取消的付费证书，重新发起审核
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateResubmitRequest"/></param>
        /// <returns><see cref="ModifyCertificateResubmitResponse"/></returns>
        public ModifyCertificateResubmitResponse ModifyCertificateResubmitSync(ModifyCertificateResubmitRequest req)
        {
            return InternalRequestAsync<ModifyCertificateResubmitResponse>(req, "ModifyCertificateResubmit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改忽略证书到期通知。打开或关闭证书到期通知。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificatesExpiringNotificationSwitchRequest"/></param>
        /// <returns><see cref="ModifyCertificatesExpiringNotificationSwitchResponse"/></returns>
        public Task<ModifyCertificatesExpiringNotificationSwitchResponse> ModifyCertificatesExpiringNotificationSwitch(ModifyCertificatesExpiringNotificationSwitchRequest req)
        {
            return InternalRequestAsync<ModifyCertificatesExpiringNotificationSwitchResponse>(req, "ModifyCertificatesExpiringNotificationSwitch");
        }

        /// <summary>
        /// 修改忽略证书到期通知。打开或关闭证书到期通知。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificatesExpiringNotificationSwitchRequest"/></param>
        /// <returns><see cref="ModifyCertificatesExpiringNotificationSwitchResponse"/></returns>
        public ModifyCertificatesExpiringNotificationSwitchResponse ModifyCertificatesExpiringNotificationSwitchSync(ModifyCertificatesExpiringNotificationSwitchRequest req)
        {
            return InternalRequestAsync<ModifyCertificatesExpiringNotificationSwitchResponse>(req, "ModifyCertificatesExpiringNotificationSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ReplaceCertificate）用于重颁发证书。已申请的免费证书仅支持 RSA 算法、密钥对参数为2048的证书重颁发，并且目前仅支持1次重颁发。
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertificateRequest"/></param>
        /// <returns><see cref="ReplaceCertificateResponse"/></returns>
        public Task<ReplaceCertificateResponse> ReplaceCertificate(ReplaceCertificateRequest req)
        {
            return InternalRequestAsync<ReplaceCertificateResponse>(req, "ReplaceCertificate");
        }

        /// <summary>
        /// 本接口（ReplaceCertificate）用于重颁发证书。已申请的免费证书仅支持 RSA 算法、密钥对参数为2048的证书重颁发，并且目前仅支持1次重颁发。
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertificateRequest"/></param>
        /// <returns><see cref="ReplaceCertificateResponse"/></returns>
        public ReplaceCertificateResponse ReplaceCertificateSync(ReplaceCertificateRequest req)
        {
            return InternalRequestAsync<ReplaceCertificateResponse>(req, "ReplaceCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RevokeCertificate）用于吊销证书。
        /// </summary>
        /// <param name="req"><see cref="RevokeCertificateRequest"/></param>
        /// <returns><see cref="RevokeCertificateResponse"/></returns>
        public Task<RevokeCertificateResponse> RevokeCertificate(RevokeCertificateRequest req)
        {
            return InternalRequestAsync<RevokeCertificateResponse>(req, "RevokeCertificate");
        }

        /// <summary>
        /// 本接口（RevokeCertificate）用于吊销证书。
        /// </summary>
        /// <param name="req"><see cref="RevokeCertificateRequest"/></param>
        /// <returns><see cref="RevokeCertificateResponse"/></returns>
        public RevokeCertificateResponse RevokeCertificateSync(RevokeCertificateRequest req)
        {
            return InternalRequestAsync<RevokeCertificateResponse>(req, "RevokeCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新提交审核管理人
        /// </summary>
        /// <param name="req"><see cref="SubmitAuditManagerRequest"/></param>
        /// <returns><see cref="SubmitAuditManagerResponse"/></returns>
        public Task<SubmitAuditManagerResponse> SubmitAuditManager(SubmitAuditManagerRequest req)
        {
            return InternalRequestAsync<SubmitAuditManagerResponse>(req, "SubmitAuditManager");
        }

        /// <summary>
        /// 重新提交审核管理人
        /// </summary>
        /// <param name="req"><see cref="SubmitAuditManagerRequest"/></param>
        /// <returns><see cref="SubmitAuditManagerResponse"/></returns>
        public SubmitAuditManagerResponse SubmitAuditManagerSync(SubmitAuditManagerRequest req)
        {
            return InternalRequestAsync<SubmitAuditManagerResponse>(req, "SubmitAuditManager")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交证书资料。输入参数信息可以分多次提交，但提交的证书资料应最低限度保持完整。
        /// </summary>
        /// <param name="req"><see cref="SubmitCertificateInformationRequest"/></param>
        /// <returns><see cref="SubmitCertificateInformationResponse"/></returns>
        public Task<SubmitCertificateInformationResponse> SubmitCertificateInformation(SubmitCertificateInformationRequest req)
        {
            return InternalRequestAsync<SubmitCertificateInformationResponse>(req, "SubmitCertificateInformation");
        }

        /// <summary>
        /// 提交证书资料。输入参数信息可以分多次提交，但提交的证书资料应最低限度保持完整。
        /// </summary>
        /// <param name="req"><see cref="SubmitCertificateInformationRequest"/></param>
        /// <returns><see cref="SubmitCertificateInformationResponse"/></returns>
        public SubmitCertificateInformationResponse SubmitCertificateInformationSync(SubmitCertificateInformationRequest req)
        {
            return InternalRequestAsync<SubmitCertificateInformationResponse>(req, "SubmitCertificateInformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 一键更新旧证书资源，本接口为异步接口， 调用之后DeployRecordId为0表示任务进行中， 当返回DeployRecordId大于0则表示任务创建成功。 未创建成功则会抛出异常
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateInstanceRequest"/></param>
        /// <returns><see cref="UpdateCertificateInstanceResponse"/></returns>
        public Task<UpdateCertificateInstanceResponse> UpdateCertificateInstance(UpdateCertificateInstanceRequest req)
        {
            return InternalRequestAsync<UpdateCertificateInstanceResponse>(req, "UpdateCertificateInstance");
        }

        /// <summary>
        /// 一键更新旧证书资源，本接口为异步接口， 调用之后DeployRecordId为0表示任务进行中， 当返回DeployRecordId大于0则表示任务创建成功。 未创建成功则会抛出异常
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateInstanceRequest"/></param>
        /// <returns><see cref="UpdateCertificateInstanceResponse"/></returns>
        public UpdateCertificateInstanceResponse UpdateCertificateInstanceSync(UpdateCertificateInstanceRequest req)
        {
            return InternalRequestAsync<UpdateCertificateInstanceResponse>(req, "UpdateCertificateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云资源更新重试部署记录
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRetryRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRetryResponse"/></returns>
        public Task<UpdateCertificateRecordRetryResponse> UpdateCertificateRecordRetry(UpdateCertificateRecordRetryRequest req)
        {
            return InternalRequestAsync<UpdateCertificateRecordRetryResponse>(req, "UpdateCertificateRecordRetry");
        }

        /// <summary>
        /// 云资源更新重试部署记录
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRetryRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRetryResponse"/></returns>
        public UpdateCertificateRecordRetryResponse UpdateCertificateRecordRetrySync(UpdateCertificateRecordRetryRequest req)
        {
            return InternalRequestAsync<UpdateCertificateRecordRetryResponse>(req, "UpdateCertificateRecordRetry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云资源更新一键回滚
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRollbackRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRollbackResponse"/></returns>
        public Task<UpdateCertificateRecordRollbackResponse> UpdateCertificateRecordRollback(UpdateCertificateRecordRollbackRequest req)
        {
            return InternalRequestAsync<UpdateCertificateRecordRollbackResponse>(req, "UpdateCertificateRecordRollback");
        }

        /// <summary>
        /// 云资源更新一键回滚
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRollbackRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRollbackResponse"/></returns>
        public UpdateCertificateRecordRollbackResponse UpdateCertificateRecordRollbackSync(UpdateCertificateRecordRollbackRequest req)
        {
            return InternalRequestAsync<UpdateCertificateRecordRollbackResponse>(req, "UpdateCertificateRecordRollback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UploadCertificate）用于上传证书。
        /// </summary>
        /// <param name="req"><see cref="UploadCertificateRequest"/></param>
        /// <returns><see cref="UploadCertificateResponse"/></returns>
        public Task<UploadCertificateResponse> UploadCertificate(UploadCertificateRequest req)
        {
            return InternalRequestAsync<UploadCertificateResponse>(req, "UploadCertificate");
        }

        /// <summary>
        /// 本接口（UploadCertificate）用于上传证书。
        /// </summary>
        /// <param name="req"><see cref="UploadCertificateRequest"/></param>
        /// <returns><see cref="UploadCertificateResponse"/></returns>
        public UploadCertificateResponse UploadCertificateSync(UploadCertificateRequest req)
        {
            return InternalRequestAsync<UploadCertificateResponse>(req, "UploadCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UploadConfirmLetter）用于上传证书确认函。
        /// </summary>
        /// <param name="req"><see cref="UploadConfirmLetterRequest"/></param>
        /// <returns><see cref="UploadConfirmLetterResponse"/></returns>
        public Task<UploadConfirmLetterResponse> UploadConfirmLetter(UploadConfirmLetterRequest req)
        {
            return InternalRequestAsync<UploadConfirmLetterResponse>(req, "UploadConfirmLetter");
        }

        /// <summary>
        /// 本接口（UploadConfirmLetter）用于上传证书确认函。
        /// </summary>
        /// <param name="req"><see cref="UploadConfirmLetterRequest"/></param>
        /// <returns><see cref="UploadConfirmLetterResponse"/></returns>
        public UploadConfirmLetterResponse UploadConfirmLetterSync(UploadConfirmLetterRequest req)
        {
            return InternalRequestAsync<UploadConfirmLetterResponse>(req, "UploadConfirmLetter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UploadRevokeLetter）用于上传证书吊销确认函。
        /// </summary>
        /// <param name="req"><see cref="UploadRevokeLetterRequest"/></param>
        /// <returns><see cref="UploadRevokeLetterResponse"/></returns>
        public Task<UploadRevokeLetterResponse> UploadRevokeLetter(UploadRevokeLetterRequest req)
        {
            return InternalRequestAsync<UploadRevokeLetterResponse>(req, "UploadRevokeLetter");
        }

        /// <summary>
        /// 本接口（UploadRevokeLetter）用于上传证书吊销确认函。
        /// </summary>
        /// <param name="req"><see cref="UploadRevokeLetterRequest"/></param>
        /// <returns><see cref="UploadRevokeLetterResponse"/></returns>
        public UploadRevokeLetterResponse UploadRevokeLetterSync(UploadRevokeLetterRequest req)
        {
            return InternalRequestAsync<UploadRevokeLetterResponse>(req, "UploadRevokeLetter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新核验管理人
        /// </summary>
        /// <param name="req"><see cref="VerifyManagerRequest"/></param>
        /// <returns><see cref="VerifyManagerResponse"/></returns>
        public Task<VerifyManagerResponse> VerifyManager(VerifyManagerRequest req)
        {
            return InternalRequestAsync<VerifyManagerResponse>(req, "VerifyManager");
        }

        /// <summary>
        /// 重新核验管理人
        /// </summary>
        /// <param name="req"><see cref="VerifyManagerRequest"/></param>
        /// <returns><see cref="VerifyManagerResponse"/></returns>
        public VerifyManagerResponse VerifyManagerSync(VerifyManagerRequest req)
        {
            return InternalRequestAsync<VerifyManagerResponse>(req, "VerifyManager")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
