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

namespace TencentCloud.Tem.V20210701
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tem.V20210701.Models;

   public class TemClient : AbstractClient{

       private const string endpoint = "tem.tencentcloudapi.com";
       private const string version = "2021-07-01";
       private const string sdkVersion = "SDK_NET_3.0.1038";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TemClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TemClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication");
        }

        /// <summary>
        /// 创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public CreateApplicationResponse CreateApplicationSync(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建弹性伸缩策略组合
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="CreateApplicationAutoscalerResponse"/></returns>
        public Task<CreateApplicationAutoscalerResponse> CreateApplicationAutoscaler(CreateApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<CreateApplicationAutoscalerResponse>(req, "CreateApplicationAutoscaler");
        }

        /// <summary>
        /// 创建弹性伸缩策略组合
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="CreateApplicationAutoscalerResponse"/></returns>
        public CreateApplicationAutoscalerResponse CreateApplicationAutoscalerSync(CreateApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<CreateApplicationAutoscalerResponse>(req, "CreateApplicationAutoscaler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增访问方式
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationServiceRequest"/></param>
        /// <returns><see cref="CreateApplicationServiceResponse"/></returns>
        public Task<CreateApplicationServiceResponse> CreateApplicationService(CreateApplicationServiceRequest req)
        {
            return InternalRequestAsync<CreateApplicationServiceResponse>(req, "CreateApplicationService");
        }

        /// <summary>
        /// 新增访问方式
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationServiceRequest"/></param>
        /// <returns><see cref="CreateApplicationServiceResponse"/></returns>
        public CreateApplicationServiceResponse CreateApplicationServiceSync(CreateApplicationServiceRequest req)
        {
            return InternalRequestAsync<CreateApplicationServiceResponse>(req, "CreateApplicationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建配置
        /// </summary>
        /// <param name="req"><see cref="CreateConfigDataRequest"/></param>
        /// <returns><see cref="CreateConfigDataResponse"/></returns>
        public Task<CreateConfigDataResponse> CreateConfigData(CreateConfigDataRequest req)
        {
            return InternalRequestAsync<CreateConfigDataResponse>(req, "CreateConfigData");
        }

        /// <summary>
        /// 创建配置
        /// </summary>
        /// <param name="req"><see cref="CreateConfigDataRequest"/></param>
        /// <returns><see cref="CreateConfigDataResponse"/></returns>
        public CreateConfigDataResponse CreateConfigDataSync(CreateConfigDataRequest req)
        {
            return InternalRequestAsync<CreateConfigDataResponse>(req, "CreateConfigData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成Cos临时密钥
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenRequest"/></param>
        /// <returns><see cref="CreateCosTokenResponse"/></returns>
        public Task<CreateCosTokenResponse> CreateCosToken(CreateCosTokenRequest req)
        {
            return InternalRequestAsync<CreateCosTokenResponse>(req, "CreateCosToken");
        }

        /// <summary>
        /// 生成Cos临时密钥
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenRequest"/></param>
        /// <returns><see cref="CreateCosTokenResponse"/></returns>
        public CreateCosTokenResponse CreateCosTokenSync(CreateCosTokenRequest req)
        {
            return InternalRequestAsync<CreateCosTokenResponse>(req, "CreateCosToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建环境
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public Task<CreateEnvironmentResponse> CreateEnvironment(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment");
        }

        /// <summary>
        /// 创建环境
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public CreateEnvironmentResponse CreateEnvironmentSync(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建日志收集配置
        /// </summary>
        /// <param name="req"><see cref="CreateLogConfigRequest"/></param>
        /// <returns><see cref="CreateLogConfigResponse"/></returns>
        public Task<CreateLogConfigResponse> CreateLogConfig(CreateLogConfigRequest req)
        {
            return InternalRequestAsync<CreateLogConfigResponse>(req, "CreateLogConfig");
        }

        /// <summary>
        /// 创建日志收集配置
        /// </summary>
        /// <param name="req"><see cref="CreateLogConfigRequest"/></param>
        /// <returns><see cref="CreateLogConfigResponse"/></returns>
        public CreateLogConfigResponse CreateLogConfigSync(CreateLogConfigRequest req)
        {
            return InternalRequestAsync<CreateLogConfigResponse>(req, "CreateLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定云资源
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public Task<CreateResourceResponse> CreateResource(CreateResourceRequest req)
        {
            return InternalRequestAsync<CreateResourceResponse>(req, "CreateResource");
        }

        /// <summary>
        /// 绑定云资源
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public CreateResourceResponse CreateResourceSync(CreateResourceRequest req)
        {
            return InternalRequestAsync<CreateResourceResponse>(req, "CreateResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 服务删除
        ///   - 停止当前运行服务
        ///   - 删除服务相关资源
        ///   - 删除服务
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public Task<DeleteApplicationResponse> DeleteApplication(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication");
        }

        /// <summary>
        /// 服务删除
        ///   - 停止当前运行服务
        ///   - 删除服务相关资源
        ///   - 删除服务
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public DeleteApplicationResponse DeleteApplicationSync(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除应用弹性策略组合
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DeleteApplicationAutoscalerResponse"/></returns>
        public Task<DeleteApplicationAutoscalerResponse> DeleteApplicationAutoscaler(DeleteApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<DeleteApplicationAutoscalerResponse>(req, "DeleteApplicationAutoscaler");
        }

        /// <summary>
        /// 删除应用弹性策略组合
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DeleteApplicationAutoscalerResponse"/></returns>
        public DeleteApplicationAutoscalerResponse DeleteApplicationAutoscalerSync(DeleteApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<DeleteApplicationAutoscalerResponse>(req, "DeleteApplicationAutoscaler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除一条访问方式
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationServiceRequest"/></param>
        /// <returns><see cref="DeleteApplicationServiceResponse"/></returns>
        public Task<DeleteApplicationServiceResponse> DeleteApplicationService(DeleteApplicationServiceRequest req)
        {
            return InternalRequestAsync<DeleteApplicationServiceResponse>(req, "DeleteApplicationService");
        }

        /// <summary>
        /// 删除一条访问方式
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationServiceRequest"/></param>
        /// <returns><see cref="DeleteApplicationServiceResponse"/></returns>
        public DeleteApplicationServiceResponse DeleteApplicationServiceSync(DeleteApplicationServiceRequest req)
        {
            return InternalRequestAsync<DeleteApplicationServiceResponse>(req, "DeleteApplicationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="DeleteIngressRequest"/></param>
        /// <returns><see cref="DeleteIngressResponse"/></returns>
        public Task<DeleteIngressResponse> DeleteIngress(DeleteIngressRequest req)
        {
            return InternalRequestAsync<DeleteIngressResponse>(req, "DeleteIngress");
        }

        /// <summary>
        /// 删除 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="DeleteIngressRequest"/></param>
        /// <returns><see cref="DeleteIngressResponse"/></returns>
        public DeleteIngressResponse DeleteIngressSync(DeleteIngressRequest req)
        {
            return InternalRequestAsync<DeleteIngressResponse>(req, "DeleteIngress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 应用部署
        /// </summary>
        /// <param name="req"><see cref="DeployApplicationRequest"/></param>
        /// <returns><see cref="DeployApplicationResponse"/></returns>
        public Task<DeployApplicationResponse> DeployApplication(DeployApplicationRequest req)
        {
            return InternalRequestAsync<DeployApplicationResponse>(req, "DeployApplication");
        }

        /// <summary>
        /// 应用部署
        /// </summary>
        /// <param name="req"><see cref="DeployApplicationRequest"/></param>
        /// <returns><see cref="DeployApplicationResponse"/></returns>
        public DeployApplicationResponse DeployApplicationSync(DeployApplicationRequest req)
        {
            return InternalRequestAsync<DeployApplicationResponse>(req, "DeployApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用弹性策略组合
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationAutoscalerListRequest"/></param>
        /// <returns><see cref="DescribeApplicationAutoscalerListResponse"/></returns>
        public Task<DescribeApplicationAutoscalerListResponse> DescribeApplicationAutoscalerList(DescribeApplicationAutoscalerListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationAutoscalerListResponse>(req, "DescribeApplicationAutoscalerList");
        }

        /// <summary>
        /// 获取应用弹性策略组合
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationAutoscalerListRequest"/></param>
        /// <returns><see cref="DescribeApplicationAutoscalerListResponse"/></returns>
        public DescribeApplicationAutoscalerListResponse DescribeApplicationAutoscalerListSync(DescribeApplicationAutoscalerListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationAutoscalerListResponse>(req, "DescribeApplicationAutoscalerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 服务基本信息查看
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfoRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfoResponse"/></returns>
        public Task<DescribeApplicationInfoResponse> DescribeApplicationInfo(DescribeApplicationInfoRequest req)
        {
            return InternalRequestAsync<DescribeApplicationInfoResponse>(req, "DescribeApplicationInfo");
        }

        /// <summary>
        /// 服务基本信息查看
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfoRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfoResponse"/></returns>
        public DescribeApplicationInfoResponse DescribeApplicationInfoSync(DescribeApplicationInfoRequest req)
        {
            return InternalRequestAsync<DescribeApplicationInfoResponse>(req, "DescribeApplicationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationPodsRequest"/></param>
        /// <returns><see cref="DescribeApplicationPodsResponse"/></returns>
        public Task<DescribeApplicationPodsResponse> DescribeApplicationPods(DescribeApplicationPodsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationPodsResponse>(req, "DescribeApplicationPods");
        }

        /// <summary>
        /// 获取应用实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationPodsRequest"/></param>
        /// <returns><see cref="DescribeApplicationPodsResponse"/></returns>
        public DescribeApplicationPodsResponse DescribeApplicationPodsSync(DescribeApplicationPodsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationPodsResponse>(req, "DescribeApplicationPods")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用访问方式列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationServiceListRequest"/></param>
        /// <returns><see cref="DescribeApplicationServiceListResponse"/></returns>
        public Task<DescribeApplicationServiceListResponse> DescribeApplicationServiceList(DescribeApplicationServiceListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationServiceListResponse>(req, "DescribeApplicationServiceList");
        }

        /// <summary>
        /// 查询应用访问方式列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationServiceListRequest"/></param>
        /// <returns><see cref="DescribeApplicationServiceListResponse"/></returns>
        public DescribeApplicationServiceListResponse DescribeApplicationServiceListSync(DescribeApplicationServiceListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationServiceListResponse>(req, "DescribeApplicationServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取运行服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public Task<DescribeApplicationsResponse> DescribeApplications(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications");
        }

        /// <summary>
        /// 获取运行服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public DescribeApplicationsResponse DescribeApplicationsSync(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 单环境下所有应用状态查看
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsStatusRequest"/></param>
        /// <returns><see cref="DescribeApplicationsStatusResponse"/></returns>
        public Task<DescribeApplicationsStatusResponse> DescribeApplicationsStatus(DescribeApplicationsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsStatusResponse>(req, "DescribeApplicationsStatus");
        }

        /// <summary>
        /// 单环境下所有应用状态查看
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsStatusRequest"/></param>
        /// <returns><see cref="DescribeApplicationsStatusResponse"/></returns>
        public DescribeApplicationsStatusResponse DescribeApplicationsStatusSync(DescribeApplicationsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsStatusResponse>(req, "DescribeApplicationsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataRequest"/></param>
        /// <returns><see cref="DescribeConfigDataResponse"/></returns>
        public Task<DescribeConfigDataResponse> DescribeConfigData(DescribeConfigDataRequest req)
        {
            return InternalRequestAsync<DescribeConfigDataResponse>(req, "DescribeConfigData");
        }

        /// <summary>
        /// 查询配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataRequest"/></param>
        /// <returns><see cref="DescribeConfigDataResponse"/></returns>
        public DescribeConfigDataResponse DescribeConfigDataSync(DescribeConfigDataRequest req)
        {
            return InternalRequestAsync<DescribeConfigDataResponse>(req, "DescribeConfigData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataListRequest"/></param>
        /// <returns><see cref="DescribeConfigDataListResponse"/></returns>
        public Task<DescribeConfigDataListResponse> DescribeConfigDataList(DescribeConfigDataListRequest req)
        {
            return InternalRequestAsync<DescribeConfigDataListResponse>(req, "DescribeConfigDataList");
        }

        /// <summary>
        /// 查询配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataListRequest"/></param>
        /// <returns><see cref="DescribeConfigDataListResponse"/></returns>
        public DescribeConfigDataListResponse DescribeConfigDataListSync(DescribeConfigDataListRequest req)
        {
            return InternalRequestAsync<DescribeConfigDataListResponse>(req, "DescribeConfigDataList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分批发布详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployApplicationDetailRequest"/></param>
        /// <returns><see cref="DescribeDeployApplicationDetailResponse"/></returns>
        public Task<DescribeDeployApplicationDetailResponse> DescribeDeployApplicationDetail(DescribeDeployApplicationDetailRequest req)
        {
            return InternalRequestAsync<DescribeDeployApplicationDetailResponse>(req, "DescribeDeployApplicationDetail");
        }

        /// <summary>
        /// 获取分批发布详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployApplicationDetailRequest"/></param>
        /// <returns><see cref="DescribeDeployApplicationDetailResponse"/></returns>
        public DescribeDeployApplicationDetailResponse DescribeDeployApplicationDetailSync(DescribeDeployApplicationDetailRequest req)
        {
            return InternalRequestAsync<DescribeDeployApplicationDetailResponse>(req, "DescribeDeployApplicationDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取环境基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentResponse"/></returns>
        public Task<DescribeEnvironmentResponse> DescribeEnvironment(DescribeEnvironmentRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentResponse>(req, "DescribeEnvironment");
        }

        /// <summary>
        /// 获取环境基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentResponse"/></returns>
        public DescribeEnvironmentResponse DescribeEnvironmentSync(DescribeEnvironmentRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentResponse>(req, "DescribeEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取环境状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentStatusRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentStatusResponse"/></returns>
        public Task<DescribeEnvironmentStatusResponse> DescribeEnvironmentStatus(DescribeEnvironmentStatusRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentStatusResponse>(req, "DescribeEnvironmentStatus");
        }

        /// <summary>
        /// 获取环境状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentStatusRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentStatusResponse"/></returns>
        public DescribeEnvironmentStatusResponse DescribeEnvironmentStatusSync(DescribeEnvironmentStatusRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentStatusResponse>(req, "DescribeEnvironmentStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取环境列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// 获取环境列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressRequest"/></param>
        /// <returns><see cref="DescribeIngressResponse"/></returns>
        public Task<DescribeIngressResponse> DescribeIngress(DescribeIngressRequest req)
        {
            return InternalRequestAsync<DescribeIngressResponse>(req, "DescribeIngress");
        }

        /// <summary>
        /// 查询 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressRequest"/></param>
        /// <returns><see cref="DescribeIngressResponse"/></returns>
        public DescribeIngressResponse DescribeIngressSync(DescribeIngressRequest req)
        {
            return InternalRequestAsync<DescribeIngressResponse>(req, "DescribeIngress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Ingress 规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressesRequest"/></param>
        /// <returns><see cref="DescribeIngressesResponse"/></returns>
        public Task<DescribeIngressesResponse> DescribeIngresses(DescribeIngressesRequest req)
        {
            return InternalRequestAsync<DescribeIngressesResponse>(req, "DescribeIngresses");
        }

        /// <summary>
        /// 查询 Ingress 规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressesRequest"/></param>
        /// <returns><see cref="DescribeIngressesResponse"/></returns>
        public DescribeIngressesResponse DescribeIngressesSync(DescribeIngressesRequest req)
        {
            return InternalRequestAsync<DescribeIngressesResponse>(req, "DescribeIngresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询日志收集配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeLogConfigRequest"/></param>
        /// <returns><see cref="DescribeLogConfigResponse"/></returns>
        public Task<DescribeLogConfigResponse> DescribeLogConfig(DescribeLogConfigRequest req)
        {
            return InternalRequestAsync<DescribeLogConfigResponse>(req, "DescribeLogConfig");
        }

        /// <summary>
        /// 查询日志收集配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeLogConfigRequest"/></param>
        /// <returns><see cref="DescribeLogConfigResponse"/></returns>
        public DescribeLogConfigResponse DescribeLogConfigSync(DescribeLogConfigRequest req)
        {
            return InternalRequestAsync<DescribeLogConfigResponse>(req, "DescribeLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分页的日志收集配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribePagedLogConfigListRequest"/></param>
        /// <returns><see cref="DescribePagedLogConfigListResponse"/></returns>
        public Task<DescribePagedLogConfigListResponse> DescribePagedLogConfigList(DescribePagedLogConfigListRequest req)
        {
            return InternalRequestAsync<DescribePagedLogConfigListResponse>(req, "DescribePagedLogConfigList");
        }

        /// <summary>
        /// 查询分页的日志收集配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribePagedLogConfigListRequest"/></param>
        /// <returns><see cref="DescribePagedLogConfigListResponse"/></returns>
        public DescribePagedLogConfigListResponse DescribePagedLogConfigListSync(DescribePagedLogConfigListRequest req)
        {
            return InternalRequestAsync<DescribePagedLogConfigListResponse>(req, "DescribePagedLogConfigList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用关联的 Ingress 规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedIngressesRequest"/></param>
        /// <returns><see cref="DescribeRelatedIngressesResponse"/></returns>
        public Task<DescribeRelatedIngressesResponse> DescribeRelatedIngresses(DescribeRelatedIngressesRequest req)
        {
            return InternalRequestAsync<DescribeRelatedIngressesResponse>(req, "DescribeRelatedIngresses");
        }

        /// <summary>
        /// 查询应用关联的 Ingress 规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedIngressesRequest"/></param>
        /// <returns><see cref="DescribeRelatedIngressesResponse"/></returns>
        public DescribeRelatedIngressesResponse DescribeRelatedIngressesSync(DescribeRelatedIngressesRequest req)
        {
            return InternalRequestAsync<DescribeRelatedIngressesResponse>(req, "DescribeRelatedIngresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁配置
        /// </summary>
        /// <param name="req"><see cref="DestroyConfigDataRequest"/></param>
        /// <returns><see cref="DestroyConfigDataResponse"/></returns>
        public Task<DestroyConfigDataResponse> DestroyConfigData(DestroyConfigDataRequest req)
        {
            return InternalRequestAsync<DestroyConfigDataResponse>(req, "DestroyConfigData");
        }

        /// <summary>
        /// 销毁配置
        /// </summary>
        /// <param name="req"><see cref="DestroyConfigDataRequest"/></param>
        /// <returns><see cref="DestroyConfigDataResponse"/></returns>
        public DestroyConfigDataResponse DestroyConfigDataSync(DestroyConfigDataRequest req)
        {
            return InternalRequestAsync<DestroyConfigDataResponse>(req, "DestroyConfigData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁环境
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvironmentRequest"/></param>
        /// <returns><see cref="DestroyEnvironmentResponse"/></returns>
        public Task<DestroyEnvironmentResponse> DestroyEnvironment(DestroyEnvironmentRequest req)
        {
            return InternalRequestAsync<DestroyEnvironmentResponse>(req, "DestroyEnvironment");
        }

        /// <summary>
        /// 销毁环境
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvironmentRequest"/></param>
        /// <returns><see cref="DestroyEnvironmentResponse"/></returns>
        public DestroyEnvironmentResponse DestroyEnvironmentSync(DestroyEnvironmentRequest req)
        {
            return InternalRequestAsync<DestroyEnvironmentResponse>(req, "DestroyEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁日志收集配置
        /// </summary>
        /// <param name="req"><see cref="DestroyLogConfigRequest"/></param>
        /// <returns><see cref="DestroyLogConfigResponse"/></returns>
        public Task<DestroyLogConfigResponse> DestroyLogConfig(DestroyLogConfigRequest req)
        {
            return InternalRequestAsync<DestroyLogConfigResponse>(req, "DestroyLogConfig");
        }

        /// <summary>
        /// 销毁日志收集配置
        /// </summary>
        /// <param name="req"><see cref="DestroyLogConfigRequest"/></param>
        /// <returns><see cref="DestroyLogConfigResponse"/></returns>
        public DestroyLogConfigResponse DestroyLogConfigSync(DestroyLogConfigRequest req)
        {
            return InternalRequestAsync<DestroyLogConfigResponse>(req, "DestroyLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭应用弹性策略组合
        /// </summary>
        /// <param name="req"><see cref="DisableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DisableApplicationAutoscalerResponse"/></returns>
        public Task<DisableApplicationAutoscalerResponse> DisableApplicationAutoscaler(DisableApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<DisableApplicationAutoscalerResponse>(req, "DisableApplicationAutoscaler");
        }

        /// <summary>
        /// 关闭应用弹性策略组合
        /// </summary>
        /// <param name="req"><see cref="DisableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DisableApplicationAutoscalerResponse"/></returns>
        public DisableApplicationAutoscalerResponse DisableApplicationAutoscalerSync(DisableApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<DisableApplicationAutoscalerResponse>(req, "DisableApplicationAutoscaler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用应用弹性策略组合
        /// </summary>
        /// <param name="req"><see cref="EnableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="EnableApplicationAutoscalerResponse"/></returns>
        public Task<EnableApplicationAutoscalerResponse> EnableApplicationAutoscaler(EnableApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<EnableApplicationAutoscalerResponse>(req, "EnableApplicationAutoscaler");
        }

        /// <summary>
        /// 启用应用弹性策略组合
        /// </summary>
        /// <param name="req"><see cref="EnableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="EnableApplicationAutoscalerResponse"/></returns>
        public EnableApplicationAutoscalerResponse EnableApplicationAutoscalerSync(EnableApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<EnableApplicationAutoscalerResponse>(req, "EnableApplicationAutoscaler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成应用程序包预签名下载链接
        /// </summary>
        /// <param name="req"><see cref="GenerateApplicationPackageDownloadUrlRequest"/></param>
        /// <returns><see cref="GenerateApplicationPackageDownloadUrlResponse"/></returns>
        public Task<GenerateApplicationPackageDownloadUrlResponse> GenerateApplicationPackageDownloadUrl(GenerateApplicationPackageDownloadUrlRequest req)
        {
            return InternalRequestAsync<GenerateApplicationPackageDownloadUrlResponse>(req, "GenerateApplicationPackageDownloadUrl");
        }

        /// <summary>
        /// 生成应用程序包预签名下载链接
        /// </summary>
        /// <param name="req"><see cref="GenerateApplicationPackageDownloadUrlRequest"/></param>
        /// <returns><see cref="GenerateApplicationPackageDownloadUrlResponse"/></returns>
        public GenerateApplicationPackageDownloadUrlResponse GenerateApplicationPackageDownloadUrlSync(GenerateApplicationPackageDownloadUrlRequest req)
        {
            return InternalRequestAsync<GenerateApplicationPackageDownloadUrlResponse>(req, "GenerateApplicationPackageDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改弹性伸缩策略组合
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="ModifyApplicationAutoscalerResponse"/></returns>
        public Task<ModifyApplicationAutoscalerResponse> ModifyApplicationAutoscaler(ModifyApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<ModifyApplicationAutoscalerResponse>(req, "ModifyApplicationAutoscaler");
        }

        /// <summary>
        /// 修改弹性伸缩策略组合
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="ModifyApplicationAutoscalerResponse"/></returns>
        public ModifyApplicationAutoscalerResponse ModifyApplicationAutoscalerSync(ModifyApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<ModifyApplicationAutoscalerResponse>(req, "ModifyApplicationAutoscaler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改应用基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationInfoResponse"/></returns>
        public Task<ModifyApplicationInfoResponse> ModifyApplicationInfo(ModifyApplicationInfoRequest req)
        {
            return InternalRequestAsync<ModifyApplicationInfoResponse>(req, "ModifyApplicationInfo");
        }

        /// <summary>
        /// 修改应用基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationInfoResponse"/></returns>
        public ModifyApplicationInfoResponse ModifyApplicationInfoSync(ModifyApplicationInfoRequest req)
        {
            return InternalRequestAsync<ModifyApplicationInfoResponse>(req, "ModifyApplicationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改应用实例数量
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationReplicasRequest"/></param>
        /// <returns><see cref="ModifyApplicationReplicasResponse"/></returns>
        public Task<ModifyApplicationReplicasResponse> ModifyApplicationReplicas(ModifyApplicationReplicasRequest req)
        {
            return InternalRequestAsync<ModifyApplicationReplicasResponse>(req, "ModifyApplicationReplicas");
        }

        /// <summary>
        /// 修改应用实例数量
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationReplicasRequest"/></param>
        /// <returns><see cref="ModifyApplicationReplicasResponse"/></returns>
        public ModifyApplicationReplicasResponse ModifyApplicationReplicasSync(ModifyApplicationReplicasRequest req)
        {
            return InternalRequestAsync<ModifyApplicationReplicasResponse>(req, "ModifyApplicationReplicas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改服务访问方式列表
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationServiceRequest"/></param>
        /// <returns><see cref="ModifyApplicationServiceResponse"/></returns>
        public Task<ModifyApplicationServiceResponse> ModifyApplicationService(ModifyApplicationServiceRequest req)
        {
            return InternalRequestAsync<ModifyApplicationServiceResponse>(req, "ModifyApplicationService");
        }

        /// <summary>
        /// 修改服务访问方式列表
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationServiceRequest"/></param>
        /// <returns><see cref="ModifyApplicationServiceResponse"/></returns>
        public ModifyApplicationServiceResponse ModifyApplicationServiceSync(ModifyApplicationServiceRequest req)
        {
            return InternalRequestAsync<ModifyApplicationServiceResponse>(req, "ModifyApplicationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑配置
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigDataRequest"/></param>
        /// <returns><see cref="ModifyConfigDataResponse"/></returns>
        public Task<ModifyConfigDataResponse> ModifyConfigData(ModifyConfigDataRequest req)
        {
            return InternalRequestAsync<ModifyConfigDataResponse>(req, "ModifyConfigData");
        }

        /// <summary>
        /// 编辑配置
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigDataRequest"/></param>
        /// <returns><see cref="ModifyConfigDataResponse"/></returns>
        public ModifyConfigDataResponse ModifyConfigDataSync(ModifyConfigDataRequest req)
        {
            return InternalRequestAsync<ModifyConfigDataResponse>(req, "ModifyConfigData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑环境
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentResponse"/></returns>
        public Task<ModifyEnvironmentResponse> ModifyEnvironment(ModifyEnvironmentRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentResponse>(req, "ModifyEnvironment");
        }

        /// <summary>
        /// 编辑环境
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentResponse"/></returns>
        public ModifyEnvironmentResponse ModifyEnvironmentSync(ModifyEnvironmentRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentResponse>(req, "ModifyEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建或者更新 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="ModifyIngressRequest"/></param>
        /// <returns><see cref="ModifyIngressResponse"/></returns>
        public Task<ModifyIngressResponse> ModifyIngress(ModifyIngressRequest req)
        {
            return InternalRequestAsync<ModifyIngressResponse>(req, "ModifyIngress");
        }

        /// <summary>
        /// 创建或者更新 Ingress 规则
        /// </summary>
        /// <param name="req"><see cref="ModifyIngressRequest"/></param>
        /// <returns><see cref="ModifyIngressResponse"/></returns>
        public ModifyIngressResponse ModifyIngressSync(ModifyIngressRequest req)
        {
            return InternalRequestAsync<ModifyIngressResponse>(req, "ModifyIngress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑日志收集配置
        /// </summary>
        /// <param name="req"><see cref="ModifyLogConfigRequest"/></param>
        /// <returns><see cref="ModifyLogConfigResponse"/></returns>
        public Task<ModifyLogConfigResponse> ModifyLogConfig(ModifyLogConfigRequest req)
        {
            return InternalRequestAsync<ModifyLogConfigResponse>(req, "ModifyLogConfig");
        }

        /// <summary>
        /// 编辑日志收集配置
        /// </summary>
        /// <param name="req"><see cref="ModifyLogConfigRequest"/></param>
        /// <returns><see cref="ModifyLogConfigResponse"/></returns>
        public ModifyLogConfigResponse ModifyLogConfigSync(ModifyLogConfigRequest req)
        {
            return InternalRequestAsync<ModifyLogConfigResponse>(req, "ModifyLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 服务重启
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationRequest"/></param>
        /// <returns><see cref="RestartApplicationResponse"/></returns>
        public Task<RestartApplicationResponse> RestartApplication(RestartApplicationRequest req)
        {
            return InternalRequestAsync<RestartApplicationResponse>(req, "RestartApplication");
        }

        /// <summary>
        /// 服务重启
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationRequest"/></param>
        /// <returns><see cref="RestartApplicationResponse"/></returns>
        public RestartApplicationResponse RestartApplicationSync(RestartApplicationRequest req)
        {
            return InternalRequestAsync<RestartApplicationResponse>(req, "RestartApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启应用实例
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationPodRequest"/></param>
        /// <returns><see cref="RestartApplicationPodResponse"/></returns>
        public Task<RestartApplicationPodResponse> RestartApplicationPod(RestartApplicationPodRequest req)
        {
            return InternalRequestAsync<RestartApplicationPodResponse>(req, "RestartApplicationPod");
        }

        /// <summary>
        /// 重启应用实例
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationPodRequest"/></param>
        /// <returns><see cref="RestartApplicationPodResponse"/></returns>
        public RestartApplicationPodResponse RestartApplicationPodSync(RestartApplicationPodRequest req)
        {
            return InternalRequestAsync<RestartApplicationPodResponse>(req, "RestartApplicationPod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开始下一批次发布
        /// </summary>
        /// <param name="req"><see cref="ResumeDeployApplicationRequest"/></param>
        /// <returns><see cref="ResumeDeployApplicationResponse"/></returns>
        public Task<ResumeDeployApplicationResponse> ResumeDeployApplication(ResumeDeployApplicationRequest req)
        {
            return InternalRequestAsync<ResumeDeployApplicationResponse>(req, "ResumeDeployApplication");
        }

        /// <summary>
        /// 开始下一批次发布
        /// </summary>
        /// <param name="req"><see cref="ResumeDeployApplicationRequest"/></param>
        /// <returns><see cref="ResumeDeployApplicationResponse"/></returns>
        public ResumeDeployApplicationResponse ResumeDeployApplicationSync(ResumeDeployApplicationRequest req)
        {
            return InternalRequestAsync<ResumeDeployApplicationResponse>(req, "ResumeDeployApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回滚分批发布
        /// </summary>
        /// <param name="req"><see cref="RevertDeployApplicationRequest"/></param>
        /// <returns><see cref="RevertDeployApplicationResponse"/></returns>
        public Task<RevertDeployApplicationResponse> RevertDeployApplication(RevertDeployApplicationRequest req)
        {
            return InternalRequestAsync<RevertDeployApplicationResponse>(req, "RevertDeployApplication");
        }

        /// <summary>
        /// 回滚分批发布
        /// </summary>
        /// <param name="req"><see cref="RevertDeployApplicationRequest"/></param>
        /// <returns><see cref="RevertDeployApplicationResponse"/></returns>
        public RevertDeployApplicationResponse RevertDeployApplicationSync(RevertDeployApplicationRequest req)
        {
            return InternalRequestAsync<RevertDeployApplicationResponse>(req, "RevertDeployApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新应用部署版本
        /// </summary>
        /// <param name="req"><see cref="RollingUpdateApplicationByVersionRequest"/></param>
        /// <returns><see cref="RollingUpdateApplicationByVersionResponse"/></returns>
        public Task<RollingUpdateApplicationByVersionResponse> RollingUpdateApplicationByVersion(RollingUpdateApplicationByVersionRequest req)
        {
            return InternalRequestAsync<RollingUpdateApplicationByVersionResponse>(req, "RollingUpdateApplicationByVersion");
        }

        /// <summary>
        /// 更新应用部署版本
        /// </summary>
        /// <param name="req"><see cref="RollingUpdateApplicationByVersionRequest"/></param>
        /// <returns><see cref="RollingUpdateApplicationByVersionResponse"/></returns>
        public RollingUpdateApplicationByVersionResponse RollingUpdateApplicationByVersionSync(RollingUpdateApplicationByVersionRequest req)
        {
            return InternalRequestAsync<RollingUpdateApplicationByVersionResponse>(req, "RollingUpdateApplicationByVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 服务停止
        /// </summary>
        /// <param name="req"><see cref="StopApplicationRequest"/></param>
        /// <returns><see cref="StopApplicationResponse"/></returns>
        public Task<StopApplicationResponse> StopApplication(StopApplicationRequest req)
        {
            return InternalRequestAsync<StopApplicationResponse>(req, "StopApplication");
        }

        /// <summary>
        /// 服务停止
        /// </summary>
        /// <param name="req"><see cref="StopApplicationRequest"/></param>
        /// <returns><see cref="StopApplicationResponse"/></returns>
        public StopApplicationResponse StopApplicationSync(StopApplicationRequest req)
        {
            return InternalRequestAsync<StopApplicationResponse>(req, "StopApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
