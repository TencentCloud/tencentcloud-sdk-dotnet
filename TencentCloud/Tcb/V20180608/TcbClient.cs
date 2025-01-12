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

namespace TencentCloud.Tcb.V20180608
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcb.V20180608.Models;

   public class TcbClient : AbstractClient{

       private const string endpoint = "tcb.tencentcloudapi.com";
       private const string version = "2018-06-08";
       private const string sdkVersion = "SDK_NET_3.0.1162";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 绑定另外一个环境下的网关，callContainer请求可以访问到该网关
        /// </summary>
        /// <param name="req"><see cref="BindEnvGatewayRequest"/></param>
        /// <returns><see cref="BindEnvGatewayResponse"/></returns>
        public Task<BindEnvGatewayResponse> BindEnvGateway(BindEnvGatewayRequest req)
        {
            return InternalRequestAsync<BindEnvGatewayResponse>(req, "BindEnvGateway");
        }

        /// <summary>
        /// 绑定另外一个环境下的网关，callContainer请求可以访问到该网关
        /// </summary>
        /// <param name="req"><see cref="BindEnvGatewayRequest"/></param>
        /// <returns><see cref="BindEnvGatewayResponse"/></returns>
        public BindEnvGatewayResponse BindEnvGatewaySync(BindEnvGatewayRequest req)
        {
            return InternalRequestAsync<BindEnvGatewayResponse>(req, "BindEnvGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查是否开通Tcb服务
        /// </summary>
        /// <param name="req"><see cref="CheckTcbServiceRequest"/></param>
        /// <returns><see cref="CheckTcbServiceResponse"/></returns>
        public Task<CheckTcbServiceResponse> CheckTcbService(CheckTcbServiceRequest req)
        {
            return InternalRequestAsync<CheckTcbServiceResponse>(req, "CheckTcbService");
        }

        /// <summary>
        /// 检查是否开通Tcb服务
        /// </summary>
        /// <param name="req"><see cref="CheckTcbServiceRequest"/></param>
        /// <returns><see cref="CheckTcbServiceResponse"/></returns>
        public CheckTcbServiceResponse CheckTcbServiceSync(CheckTcbServiceRequest req)
        {
            return InternalRequestAsync<CheckTcbServiceResponse>(req, "CheckTcbService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// TCB云API统一入口
        /// </summary>
        /// <param name="req"><see cref="CommonServiceAPIRequest"/></param>
        /// <returns><see cref="CommonServiceAPIResponse"/></returns>
        public Task<CommonServiceAPIResponse> CommonServiceAPI(CommonServiceAPIRequest req)
        {
            return InternalRequestAsync<CommonServiceAPIResponse>(req, "CommonServiceAPI");
        }

        /// <summary>
        /// TCB云API统一入口
        /// </summary>
        /// <param name="req"><see cref="CommonServiceAPIRequest"/></param>
        /// <returns><see cref="CommonServiceAPIResponse"/></returns>
        public CommonServiceAPIResponse CommonServiceAPISync(CommonServiceAPIRequest req)
        {
            return InternalRequestAsync<CommonServiceAPIResponse>(req, "CommonServiceAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云开发项目
        /// </summary>
        /// <param name="req"><see cref="CreateAndDeployCloudBaseProjectRequest"/></param>
        /// <returns><see cref="CreateAndDeployCloudBaseProjectResponse"/></returns>
        public Task<CreateAndDeployCloudBaseProjectResponse> CreateAndDeployCloudBaseProject(CreateAndDeployCloudBaseProjectRequest req)
        {
            return InternalRequestAsync<CreateAndDeployCloudBaseProjectResponse>(req, "CreateAndDeployCloudBaseProject");
        }

        /// <summary>
        /// 创建云开发项目
        /// </summary>
        /// <param name="req"><see cref="CreateAndDeployCloudBaseProjectRequest"/></param>
        /// <returns><see cref="CreateAndDeployCloudBaseProjectResponse"/></returns>
        public CreateAndDeployCloudBaseProjectResponse CreateAndDeployCloudBaseProjectSync(CreateAndDeployCloudBaseProjectRequest req)
        {
            return InternalRequestAsync<CreateAndDeployCloudBaseProjectResponse>(req, "CreateAndDeployCloudBaseProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 增加安全域名
        /// </summary>
        /// <param name="req"><see cref="CreateAuthDomainRequest"/></param>
        /// <returns><see cref="CreateAuthDomainResponse"/></returns>
        public Task<CreateAuthDomainResponse> CreateAuthDomain(CreateAuthDomainRequest req)
        {
            return InternalRequestAsync<CreateAuthDomainResponse>(req, "CreateAuthDomain");
        }

        /// <summary>
        /// 增加安全域名
        /// </summary>
        /// <param name="req"><see cref="CreateAuthDomainRequest"/></param>
        /// <returns><see cref="CreateAuthDomainResponse"/></returns>
        public CreateAuthDomainResponse CreateAuthDomainSync(CreateAuthDomainRequest req)
        {
            return InternalRequestAsync<CreateAuthDomainResponse>(req, "CreateAuthDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通容器托管的资源，包括集群创建，VPC配置，异步任务创建，镜像托管，Coding等，查看创建结果需要根据DescribeCloudBaseRunResource接口来查看
        /// </summary>
        /// <param name="req"><see cref="CreateCloudBaseRunResourceRequest"/></param>
        /// <returns><see cref="CreateCloudBaseRunResourceResponse"/></returns>
        public Task<CreateCloudBaseRunResourceResponse> CreateCloudBaseRunResource(CreateCloudBaseRunResourceRequest req)
        {
            return InternalRequestAsync<CreateCloudBaseRunResourceResponse>(req, "CreateCloudBaseRunResource");
        }

        /// <summary>
        /// 开通容器托管的资源，包括集群创建，VPC配置，异步任务创建，镜像托管，Coding等，查看创建结果需要根据DescribeCloudBaseRunResource接口来查看
        /// </summary>
        /// <param name="req"><see cref="CreateCloudBaseRunResourceRequest"/></param>
        /// <returns><see cref="CreateCloudBaseRunResourceResponse"/></returns>
        public CreateCloudBaseRunResourceResponse CreateCloudBaseRunResourceSync(CreateCloudBaseRunResourceRequest req)
        {
            return InternalRequestAsync<CreateCloudBaseRunResourceResponse>(req, "CreateCloudBaseRunResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建服务版本
        /// </summary>
        /// <param name="req"><see cref="CreateCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="CreateCloudBaseRunServerVersionResponse"/></returns>
        public Task<CreateCloudBaseRunServerVersionResponse> CreateCloudBaseRunServerVersion(CreateCloudBaseRunServerVersionRequest req)
        {
            return InternalRequestAsync<CreateCloudBaseRunServerVersionResponse>(req, "CreateCloudBaseRunServerVersion");
        }

        /// <summary>
        /// 创建服务版本
        /// </summary>
        /// <param name="req"><see cref="CreateCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="CreateCloudBaseRunServerVersionResponse"/></returns>
        public CreateCloudBaseRunServerVersionResponse CreateCloudBaseRunServerVersionSync(CreateCloudBaseRunServerVersionRequest req)
        {
            return InternalRequestAsync<CreateCloudBaseRunServerVersionResponse>(req, "CreateCloudBaseRunServerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建托管域名
        /// </summary>
        /// <param name="req"><see cref="CreateHostingDomainRequest"/></param>
        /// <returns><see cref="CreateHostingDomainResponse"/></returns>
        public Task<CreateHostingDomainResponse> CreateHostingDomain(CreateHostingDomainRequest req)
        {
            return InternalRequestAsync<CreateHostingDomainResponse>(req, "CreateHostingDomain");
        }

        /// <summary>
        /// 创建托管域名
        /// </summary>
        /// <param name="req"><see cref="CreateHostingDomainRequest"/></param>
        /// <returns><see cref="CreateHostingDomainResponse"/></returns>
        public CreateHostingDomainResponse CreateHostingDomainSync(CreateHostingDomainRequest req)
        {
            return InternalRequestAsync<CreateHostingDomainResponse>(req, "CreateHostingDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通后付费资源
        /// </summary>
        /// <param name="req"><see cref="CreatePostpayPackageRequest"/></param>
        /// <returns><see cref="CreatePostpayPackageResponse"/></returns>
        public Task<CreatePostpayPackageResponse> CreatePostpayPackage(CreatePostpayPackageRequest req)
        {
            return InternalRequestAsync<CreatePostpayPackageResponse>(req, "CreatePostpayPackage");
        }

        /// <summary>
        /// 开通后付费资源
        /// </summary>
        /// <param name="req"><see cref="CreatePostpayPackageRequest"/></param>
        /// <returns><see cref="CreatePostpayPackageResponse"/></returns>
        public CreatePostpayPackageResponse CreatePostpayPackageSync(CreatePostpayPackageRequest req)
        {
            return InternalRequestAsync<CreatePostpayPackageResponse>(req, "CreatePostpayPackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateStandaloneGateway）用于创建独立网关。
        /// </summary>
        /// <param name="req"><see cref="CreateStandaloneGatewayRequest"/></param>
        /// <returns><see cref="CreateStandaloneGatewayResponse"/></returns>
        public Task<CreateStandaloneGatewayResponse> CreateStandaloneGateway(CreateStandaloneGatewayRequest req)
        {
            return InternalRequestAsync<CreateStandaloneGatewayResponse>(req, "CreateStandaloneGateway");
        }

        /// <summary>
        /// 本接口（CreateStandaloneGateway）用于创建独立网关。
        /// </summary>
        /// <param name="req"><see cref="CreateStandaloneGatewayRequest"/></param>
        /// <returns><see cref="CreateStandaloneGatewayResponse"/></returns>
        public CreateStandaloneGatewayResponse CreateStandaloneGatewaySync(CreateStandaloneGatewayRequest req)
        {
            return InternalRequestAsync<CreateStandaloneGatewayResponse>(req, "CreateStandaloneGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建静态托管资源，包括COS和CDN，异步任务创建，查看创建结果需要根据DescribeStaticStore接口来查看
        /// </summary>
        /// <param name="req"><see cref="CreateStaticStoreRequest"/></param>
        /// <returns><see cref="CreateStaticStoreResponse"/></returns>
        public Task<CreateStaticStoreResponse> CreateStaticStore(CreateStaticStoreRequest req)
        {
            return InternalRequestAsync<CreateStaticStoreResponse>(req, "CreateStaticStore");
        }

        /// <summary>
        /// 创建静态托管资源，包括COS和CDN，异步任务创建，查看创建结果需要根据DescribeStaticStore接口来查看
        /// </summary>
        /// <param name="req"><see cref="CreateStaticStoreRequest"/></param>
        /// <returns><see cref="CreateStaticStoreResponse"/></returns>
        public CreateStaticStoreResponse CreateStaticStoreSync(CreateStaticStoreRequest req)
        {
            return InternalRequestAsync<CreateStaticStoreResponse>(req, "CreateStaticStore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建微信云托管
        /// </summary>
        /// <param name="req"><see cref="CreateWxCloudBaseRunEnvRequest"/></param>
        /// <returns><see cref="CreateWxCloudBaseRunEnvResponse"/></returns>
        public Task<CreateWxCloudBaseRunEnvResponse> CreateWxCloudBaseRunEnv(CreateWxCloudBaseRunEnvRequest req)
        {
            return InternalRequestAsync<CreateWxCloudBaseRunEnvResponse>(req, "CreateWxCloudBaseRunEnv");
        }

        /// <summary>
        /// 创建微信云托管
        /// </summary>
        /// <param name="req"><see cref="CreateWxCloudBaseRunEnvRequest"/></param>
        /// <returns><see cref="CreateWxCloudBaseRunEnvResponse"/></returns>
        public CreateWxCloudBaseRunEnvResponse CreateWxCloudBaseRunEnvSync(CreateWxCloudBaseRunEnvRequest req)
        {
            return InternalRequestAsync<CreateWxCloudBaseRunEnvResponse>(req, "CreateWxCloudBaseRunEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通微信云托管MySQL数据库服务
        /// </summary>
        /// <param name="req"><see cref="CreateWxCloudBaseRunServerDBClusterRequest"/></param>
        /// <returns><see cref="CreateWxCloudBaseRunServerDBClusterResponse"/></returns>
        public Task<CreateWxCloudBaseRunServerDBClusterResponse> CreateWxCloudBaseRunServerDBCluster(CreateWxCloudBaseRunServerDBClusterRequest req)
        {
            return InternalRequestAsync<CreateWxCloudBaseRunServerDBClusterResponse>(req, "CreateWxCloudBaseRunServerDBCluster");
        }

        /// <summary>
        /// 开通微信云托管MySQL数据库服务
        /// </summary>
        /// <param name="req"><see cref="CreateWxCloudBaseRunServerDBClusterRequest"/></param>
        /// <returns><see cref="CreateWxCloudBaseRunServerDBClusterResponse"/></returns>
        public CreateWxCloudBaseRunServerDBClusterResponse CreateWxCloudBaseRunServerDBClusterSync(CreateWxCloudBaseRunServerDBClusterRequest req)
        {
            return InternalRequestAsync<CreateWxCloudBaseRunServerDBClusterResponse>(req, "CreateWxCloudBaseRunServerDBCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除云项目
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseProjectLatestVersionRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseProjectLatestVersionResponse"/></returns>
        public Task<DeleteCloudBaseProjectLatestVersionResponse> DeleteCloudBaseProjectLatestVersion(DeleteCloudBaseProjectLatestVersionRequest req)
        {
            return InternalRequestAsync<DeleteCloudBaseProjectLatestVersionResponse>(req, "DeleteCloudBaseProjectLatestVersion");
        }

        /// <summary>
        /// 删除云项目
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseProjectLatestVersionRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseProjectLatestVersionResponse"/></returns>
        public DeleteCloudBaseProjectLatestVersionResponse DeleteCloudBaseProjectLatestVersionSync(DeleteCloudBaseProjectLatestVersionRequest req)
        {
            return InternalRequestAsync<DeleteCloudBaseProjectLatestVersionResponse>(req, "DeleteCloudBaseProjectLatestVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除服务版本
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseRunServerVersionResponse"/></returns>
        public Task<DeleteCloudBaseRunServerVersionResponse> DeleteCloudBaseRunServerVersion(DeleteCloudBaseRunServerVersionRequest req)
        {
            return InternalRequestAsync<DeleteCloudBaseRunServerVersionResponse>(req, "DeleteCloudBaseRunServerVersion");
        }

        /// <summary>
        /// 删除服务版本
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseRunServerVersionResponse"/></returns>
        public DeleteCloudBaseRunServerVersionResponse DeleteCloudBaseRunServerVersionSync(DeleteCloudBaseRunServerVersionRequest req)
        {
            return InternalRequestAsync<DeleteCloudBaseRunServerVersionResponse>(req, "DeleteCloudBaseRunServerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除终端用户
        /// </summary>
        /// <param name="req"><see cref="DeleteEndUserRequest"/></param>
        /// <returns><see cref="DeleteEndUserResponse"/></returns>
        public Task<DeleteEndUserResponse> DeleteEndUser(DeleteEndUserRequest req)
        {
            return InternalRequestAsync<DeleteEndUserResponse>(req, "DeleteEndUser");
        }

        /// <summary>
        /// 删除终端用户
        /// </summary>
        /// <param name="req"><see cref="DeleteEndUserRequest"/></param>
        /// <returns><see cref="DeleteEndUserResponse"/></returns>
        public DeleteEndUserResponse DeleteEndUserSync(DeleteEndUserRequest req)
        {
            return InternalRequestAsync<DeleteEndUserResponse>(req, "DeleteEndUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除网关某版本
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayVersionRequest"/></param>
        /// <returns><see cref="DeleteGatewayVersionResponse"/></returns>
        public Task<DeleteGatewayVersionResponse> DeleteGatewayVersion(DeleteGatewayVersionRequest req)
        {
            return InternalRequestAsync<DeleteGatewayVersionResponse>(req, "DeleteGatewayVersion");
        }

        /// <summary>
        /// 删除网关某版本
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayVersionRequest"/></param>
        /// <returns><see cref="DeleteGatewayVersionResponse"/></returns>
        public DeleteGatewayVersionResponse DeleteGatewayVersionSync(DeleteGatewayVersionRequest req)
        {
            return InternalRequestAsync<DeleteGatewayVersionResponse>(req, "DeleteGatewayVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除安全网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteWxGatewayRouteRequest"/></param>
        /// <returns><see cref="DeleteWxGatewayRouteResponse"/></returns>
        public Task<DeleteWxGatewayRouteResponse> DeleteWxGatewayRoute(DeleteWxGatewayRouteRequest req)
        {
            return InternalRequestAsync<DeleteWxGatewayRouteResponse>(req, "DeleteWxGatewayRoute");
        }

        /// <summary>
        /// 删除安全网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteWxGatewayRouteRequest"/></param>
        /// <returns><see cref="DeleteWxGatewayRouteResponse"/></returns>
        public DeleteWxGatewayRouteResponse DeleteWxGatewayRouteSync(DeleteWxGatewayRouteRequest req)
        {
            return InternalRequestAsync<DeleteWxGatewayRouteResponse>(req, "DeleteWxGatewayRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询活动信息
        /// </summary>
        /// <param name="req"><see cref="DescribeActivityInfoRequest"/></param>
        /// <returns><see cref="DescribeActivityInfoResponse"/></returns>
        public Task<DescribeActivityInfoResponse> DescribeActivityInfo(DescribeActivityInfoRequest req)
        {
            return InternalRequestAsync<DescribeActivityInfoResponse>(req, "DescribeActivityInfo");
        }

        /// <summary>
        /// 查询活动信息
        /// </summary>
        /// <param name="req"><see cref="DescribeActivityInfoRequest"/></param>
        /// <returns><see cref="DescribeActivityInfoResponse"/></returns>
        public DescribeActivityInfoResponse DescribeActivityInfoSync(DescribeActivityInfoRequest req)
        {
            return InternalRequestAsync<DescribeActivityInfoResponse>(req, "DescribeActivityInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询活动记录信息
        /// </summary>
        /// <param name="req"><see cref="DescribeActivityRecordRequest"/></param>
        /// <returns><see cref="DescribeActivityRecordResponse"/></returns>
        public Task<DescribeActivityRecordResponse> DescribeActivityRecord(DescribeActivityRecordRequest req)
        {
            return InternalRequestAsync<DescribeActivityRecordResponse>(req, "DescribeActivityRecord");
        }

        /// <summary>
        /// 查询活动记录信息
        /// </summary>
        /// <param name="req"><see cref="DescribeActivityRecordRequest"/></param>
        /// <returns><see cref="DescribeActivityRecordResponse"/></returns>
        public DescribeActivityRecordResponse DescribeActivityRecordSync(DescribeActivityRecordRequest req)
        {
            return InternalRequestAsync<DescribeActivityRecordResponse>(req, "DescribeActivityRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取安全域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthDomainsRequest"/></param>
        /// <returns><see cref="DescribeAuthDomainsResponse"/></returns>
        public Task<DescribeAuthDomainsResponse> DescribeAuthDomains(DescribeAuthDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAuthDomainsResponse>(req, "DescribeAuthDomains");
        }

        /// <summary>
        /// 获取安全域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthDomainsRequest"/></param>
        /// <returns><see cref="DescribeAuthDomainsResponse"/></returns>
        public DescribeAuthDomainsResponse DescribeAuthDomainsSync(DescribeAuthDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAuthDomainsResponse>(req, "DescribeAuthDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取新套餐列表，含详情，如果传了PackageId，则只获取指定套餐详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBaasPackageListRequest"/></param>
        /// <returns><see cref="DescribeBaasPackageListResponse"/></returns>
        public Task<DescribeBaasPackageListResponse> DescribeBaasPackageList(DescribeBaasPackageListRequest req)
        {
            return InternalRequestAsync<DescribeBaasPackageListResponse>(req, "DescribeBaasPackageList");
        }

        /// <summary>
        /// 获取新套餐列表，含详情，如果传了PackageId，则只获取指定套餐详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBaasPackageListRequest"/></param>
        /// <returns><see cref="DescribeBaasPackageListResponse"/></returns>
        public DescribeBaasPackageListResponse DescribeBaasPackageListSync(DescribeBaasPackageListRequest req)
        {
            return InternalRequestAsync<DescribeBaasPackageListResponse>(req, "DescribeBaasPackageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取计费相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingInfoRequest"/></param>
        /// <returns><see cref="DescribeBillingInfoResponse"/></returns>
        public Task<DescribeBillingInfoResponse> DescribeBillingInfo(DescribeBillingInfoRequest req)
        {
            return InternalRequestAsync<DescribeBillingInfoResponse>(req, "DescribeBillingInfo");
        }

        /// <summary>
        /// 获取计费相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingInfoRequest"/></param>
        /// <returns><see cref="DescribeBillingInfoResponse"/></returns>
        public DescribeBillingInfoResponse DescribeBillingInfoSync(DescribeBillingInfoRequest req)
        {
            return InternalRequestAsync<DescribeBillingInfoResponse>(req, "DescribeBillingInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务版本的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCbrServerVersionRequest"/></param>
        /// <returns><see cref="DescribeCbrServerVersionResponse"/></returns>
        public Task<DescribeCbrServerVersionResponse> DescribeCbrServerVersion(DescribeCbrServerVersionRequest req)
        {
            return InternalRequestAsync<DescribeCbrServerVersionResponse>(req, "DescribeCbrServerVersion");
        }

        /// <summary>
        /// 查询服务版本的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCbrServerVersionRequest"/></param>
        /// <returns><see cref="DescribeCbrServerVersionResponse"/></returns>
        public DescribeCbrServerVersionResponse DescribeCbrServerVersionSync(DescribeCbrServerVersionRequest req)
        {
            return InternalRequestAsync<DescribeCbrServerVersionResponse>(req, "DescribeCbrServerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云托管代码上传url
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseBuildServiceRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseBuildServiceResponse"/></returns>
        public Task<DescribeCloudBaseBuildServiceResponse> DescribeCloudBaseBuildService(DescribeCloudBaseBuildServiceRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseBuildServiceResponse>(req, "DescribeCloudBaseBuildService");
        }

        /// <summary>
        /// 获取云托管代码上传url
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseBuildServiceRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseBuildServiceResponse"/></returns>
        public DescribeCloudBaseBuildServiceResponse DescribeCloudBaseBuildServiceSync(DescribeCloudBaseBuildServiceRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseBuildServiceResponse>(req, "DescribeCloudBaseBuildService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云开发项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseProjectLatestVersionListRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseProjectLatestVersionListResponse"/></returns>
        public Task<DescribeCloudBaseProjectLatestVersionListResponse> DescribeCloudBaseProjectLatestVersionList(DescribeCloudBaseProjectLatestVersionListRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseProjectLatestVersionListResponse>(req, "DescribeCloudBaseProjectLatestVersionList");
        }

        /// <summary>
        /// 获取云开发项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseProjectLatestVersionListRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseProjectLatestVersionListResponse"/></returns>
        public DescribeCloudBaseProjectLatestVersionListResponse DescribeCloudBaseProjectLatestVersionListSync(DescribeCloudBaseProjectLatestVersionListRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseProjectLatestVersionListResponse>(req, "DescribeCloudBaseProjectLatestVersionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云项目部署列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseProjectVersionListRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseProjectVersionListResponse"/></returns>
        public Task<DescribeCloudBaseProjectVersionListResponse> DescribeCloudBaseProjectVersionList(DescribeCloudBaseProjectVersionListRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseProjectVersionListResponse>(req, "DescribeCloudBaseProjectVersionList");
        }

        /// <summary>
        /// 云项目部署列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseProjectVersionListRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseProjectVersionListResponse"/></returns>
        public DescribeCloudBaseProjectVersionListResponse DescribeCloudBaseProjectVersionListSync(DescribeCloudBaseProjectVersionListRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseProjectVersionListResponse>(req, "DescribeCloudBaseProjectVersionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询环境下所有的vpc列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunAllVpcsRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunAllVpcsResponse"/></returns>
        public Task<DescribeCloudBaseRunAllVpcsResponse> DescribeCloudBaseRunAllVpcs(DescribeCloudBaseRunAllVpcsRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunAllVpcsResponse>(req, "DescribeCloudBaseRunAllVpcs");
        }

        /// <summary>
        /// 查询环境下所有的vpc列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunAllVpcsRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunAllVpcsResponse"/></returns>
        public DescribeCloudBaseRunAllVpcsResponse DescribeCloudBaseRunAllVpcsSync(DescribeCloudBaseRunAllVpcsRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunAllVpcsResponse>(req, "DescribeCloudBaseRunAllVpcs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 独立网关中拉取云托管服务对应的配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunConfForGateWayRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunConfForGateWayResponse"/></returns>
        public Task<DescribeCloudBaseRunConfForGateWayResponse> DescribeCloudBaseRunConfForGateWay(DescribeCloudBaseRunConfForGateWayRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunConfForGateWayResponse>(req, "DescribeCloudBaseRunConfForGateWay");
        }

        /// <summary>
        /// 独立网关中拉取云托管服务对应的配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunConfForGateWayRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunConfForGateWayResponse"/></returns>
        public DescribeCloudBaseRunConfForGateWayResponse DescribeCloudBaseRunConfForGateWaySync(DescribeCloudBaseRunConfForGateWayRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunConfForGateWayResponse>(req, "DescribeCloudBaseRunConfForGateWay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询一键部署任务 （特定接口：外部查询使用）
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunOneClickTaskExternalRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunOneClickTaskExternalResponse"/></returns>
        public Task<DescribeCloudBaseRunOneClickTaskExternalResponse> DescribeCloudBaseRunOneClickTaskExternal(DescribeCloudBaseRunOneClickTaskExternalRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunOneClickTaskExternalResponse>(req, "DescribeCloudBaseRunOneClickTaskExternal");
        }

        /// <summary>
        /// 查询一键部署任务 （特定接口：外部查询使用）
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunOneClickTaskExternalRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunOneClickTaskExternalResponse"/></returns>
        public DescribeCloudBaseRunOneClickTaskExternalResponse DescribeCloudBaseRunOneClickTaskExternalSync(DescribeCloudBaseRunOneClickTaskExternalRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunOneClickTaskExternalResponse>(req, "DescribeCloudBaseRunOneClickTaskExternal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务、版本和操作类型
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunOperationTypesRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunOperationTypesResponse"/></returns>
        public Task<DescribeCloudBaseRunOperationTypesResponse> DescribeCloudBaseRunOperationTypes(DescribeCloudBaseRunOperationTypesRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunOperationTypesResponse>(req, "DescribeCloudBaseRunOperationTypes");
        }

        /// <summary>
        /// 查询服务、版本和操作类型
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunOperationTypesRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunOperationTypesResponse"/></returns>
        public DescribeCloudBaseRunOperationTypesResponse DescribeCloudBaseRunOperationTypesSync(DescribeCloudBaseRunOperationTypesRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunOperationTypesResponse>(req, "DescribeCloudBaseRunOperationTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云托管服务版本容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunPodListRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunPodListResponse"/></returns>
        public Task<DescribeCloudBaseRunPodListResponse> DescribeCloudBaseRunPodList(DescribeCloudBaseRunPodListRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunPodListResponse>(req, "DescribeCloudBaseRunPodList");
        }

        /// <summary>
        /// 查询云托管服务版本容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunPodListRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunPodListResponse"/></returns>
        public DescribeCloudBaseRunPodListResponse DescribeCloudBaseRunPodListSync(DescribeCloudBaseRunPodListRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunPodListResponse>(req, "DescribeCloudBaseRunPodList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看容器托管的集群状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunResourceRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunResourceResponse"/></returns>
        public Task<DescribeCloudBaseRunResourceResponse> DescribeCloudBaseRunResource(DescribeCloudBaseRunResourceRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunResourceResponse>(req, "DescribeCloudBaseRunResource");
        }

        /// <summary>
        /// 查看容器托管的集群状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunResourceRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunResourceResponse"/></returns>
        public DescribeCloudBaseRunResourceResponse DescribeCloudBaseRunResourceSync(DescribeCloudBaseRunResourceRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunResourceResponse>(req, "DescribeCloudBaseRunResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看容器托管的集群状态扩展使用
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunResourceForExtendRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunResourceForExtendResponse"/></returns>
        public Task<DescribeCloudBaseRunResourceForExtendResponse> DescribeCloudBaseRunResourceForExtend(DescribeCloudBaseRunResourceForExtendRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunResourceForExtendResponse>(req, "DescribeCloudBaseRunResourceForExtend");
        }

        /// <summary>
        /// 查看容器托管的集群状态扩展使用
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunResourceForExtendRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunResourceForExtendResponse"/></returns>
        public DescribeCloudBaseRunResourceForExtendResponse DescribeCloudBaseRunResourceForExtendSync(DescribeCloudBaseRunResourceForExtendRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunResourceForExtendResponse>(req, "DescribeCloudBaseRunResourceForExtend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个服务的详情，版本以及详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunServerRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunServerResponse"/></returns>
        public Task<DescribeCloudBaseRunServerResponse> DescribeCloudBaseRunServer(DescribeCloudBaseRunServerRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunServerResponse>(req, "DescribeCloudBaseRunServer");
        }

        /// <summary>
        /// 查询单个服务的详情，版本以及详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunServerRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunServerResponse"/></returns>
        public DescribeCloudBaseRunServerResponse DescribeCloudBaseRunServerSync(DescribeCloudBaseRunServerRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunServerResponse>(req, "DescribeCloudBaseRunServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询微信云托管服务域名
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunServerDomainNameRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunServerDomainNameResponse"/></returns>
        public Task<DescribeCloudBaseRunServerDomainNameResponse> DescribeCloudBaseRunServerDomainName(DescribeCloudBaseRunServerDomainNameRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunServerDomainNameResponse>(req, "DescribeCloudBaseRunServerDomainName");
        }

        /// <summary>
        /// 查询微信云托管服务域名
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunServerDomainNameRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunServerDomainNameResponse"/></returns>
        public DescribeCloudBaseRunServerDomainNameResponse DescribeCloudBaseRunServerDomainNameSync(DescribeCloudBaseRunServerDomainNameRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunServerDomainNameResponse>(req, "DescribeCloudBaseRunServerDomainName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务版本的详情，CPU和MEM  请使用CPUSize和MemSize
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunServerVersionResponse"/></returns>
        public Task<DescribeCloudBaseRunServerVersionResponse> DescribeCloudBaseRunServerVersion(DescribeCloudBaseRunServerVersionRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunServerVersionResponse>(req, "DescribeCloudBaseRunServerVersion");
        }

        /// <summary>
        /// 查询服务版本的详情，CPU和MEM  请使用CPUSize和MemSize
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunServerVersionResponse"/></returns>
        public DescribeCloudBaseRunServerVersionResponse DescribeCloudBaseRunServerVersionSync(DescribeCloudBaseRunServerVersionRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunServerVersionResponse>(req, "DescribeCloudBaseRunServerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务版本详情(新)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunVersionRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunVersionResponse"/></returns>
        public Task<DescribeCloudBaseRunVersionResponse> DescribeCloudBaseRunVersion(DescribeCloudBaseRunVersionRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunVersionResponse>(req, "DescribeCloudBaseRunVersion");
        }

        /// <summary>
        /// 查询服务版本详情(新)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunVersionRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunVersionResponse"/></returns>
        public DescribeCloudBaseRunVersionResponse DescribeCloudBaseRunVersionSync(DescribeCloudBaseRunVersionRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunVersionResponse>(req, "DescribeCloudBaseRunVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeCloudBaseRunVersionRsByCondition 获取云托管详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunVersionRsByConditionRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunVersionRsByConditionResponse"/></returns>
        public Task<DescribeCloudBaseRunVersionRsByConditionResponse> DescribeCloudBaseRunVersionRsByCondition(DescribeCloudBaseRunVersionRsByConditionRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunVersionRsByConditionResponse>(req, "DescribeCloudBaseRunVersionRsByCondition");
        }

        /// <summary>
        /// DescribeCloudBaseRunVersionRsByCondition 获取云托管详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunVersionRsByConditionRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunVersionRsByConditionResponse"/></returns>
        public DescribeCloudBaseRunVersionRsByConditionResponse DescribeCloudBaseRunVersionRsByConditionSync(DescribeCloudBaseRunVersionRsByConditionRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunVersionRsByConditionResponse>(req, "DescribeCloudBaseRunVersionRsByCondition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询版本历史
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunVersionSnapshotRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunVersionSnapshotResponse"/></returns>
        public Task<DescribeCloudBaseRunVersionSnapshotResponse> DescribeCloudBaseRunVersionSnapshot(DescribeCloudBaseRunVersionSnapshotRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunVersionSnapshotResponse>(req, "DescribeCloudBaseRunVersionSnapshot");
        }

        /// <summary>
        /// 查询版本历史
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunVersionSnapshotRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunVersionSnapshotResponse"/></returns>
        public DescribeCloudBaseRunVersionSnapshotResponse DescribeCloudBaseRunVersionSnapshotSync(DescribeCloudBaseRunVersionSnapshotRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseRunVersionSnapshotResponse>(req, "DescribeCloudBaseRunVersionSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据用户传入的指标, 拉取一段时间内的监控数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurveDataRequest"/></param>
        /// <returns><see cref="DescribeCurveDataResponse"/></returns>
        public Task<DescribeCurveDataResponse> DescribeCurveData(DescribeCurveDataRequest req)
        {
            return InternalRequestAsync<DescribeCurveDataResponse>(req, "DescribeCurveData");
        }

        /// <summary>
        /// 根据用户传入的指标, 拉取一段时间内的监控数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurveDataRequest"/></param>
        /// <returns><see cref="DescribeCurveDataResponse"/></returns>
        public DescribeCurveDataResponse DescribeCurveDataSync(DescribeCurveDataRequest req)
        {
            return InternalRequestAsync<DescribeCurveDataResponse>(req, "DescribeCurveData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据库权限
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseACLRequest"/></param>
        /// <returns><see cref="DescribeDatabaseACLResponse"/></returns>
        public Task<DescribeDatabaseACLResponse> DescribeDatabaseACL(DescribeDatabaseACLRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseACLResponse>(req, "DescribeDatabaseACL");
        }

        /// <summary>
        /// 获取数据库权限
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseACLRequest"/></param>
        /// <returns><see cref="DescribeDatabaseACLResponse"/></returns>
        public DescribeDatabaseACLResponse DescribeDatabaseACLSync(DescribeDatabaseACLRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseACLResponse>(req, "DescribeDatabaseACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取下载文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadFileRequest"/></param>
        /// <returns><see cref="DescribeDownloadFileResponse"/></returns>
        public Task<DescribeDownloadFileResponse> DescribeDownloadFile(DescribeDownloadFileRequest req)
        {
            return InternalRequestAsync<DescribeDownloadFileResponse>(req, "DescribeDownloadFile");
        }

        /// <summary>
        /// 获取下载文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadFileRequest"/></param>
        /// <returns><see cref="DescribeDownloadFileResponse"/></returns>
        public DescribeDownloadFileResponse DescribeDownloadFileSync(DescribeDownloadFileRequest req)
        {
            return InternalRequestAsync<DescribeDownloadFileResponse>(req, "DescribeDownloadFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取环境终端用户新增与登录信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUserLoginStatisticRequest"/></param>
        /// <returns><see cref="DescribeEndUserLoginStatisticResponse"/></returns>
        public Task<DescribeEndUserLoginStatisticResponse> DescribeEndUserLoginStatistic(DescribeEndUserLoginStatisticRequest req)
        {
            return InternalRequestAsync<DescribeEndUserLoginStatisticResponse>(req, "DescribeEndUserLoginStatistic");
        }

        /// <summary>
        /// 获取环境终端用户新增与登录信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUserLoginStatisticRequest"/></param>
        /// <returns><see cref="DescribeEndUserLoginStatisticResponse"/></returns>
        public DescribeEndUserLoginStatisticResponse DescribeEndUserLoginStatisticSync(DescribeEndUserLoginStatisticRequest req)
        {
            return InternalRequestAsync<DescribeEndUserLoginStatisticResponse>(req, "DescribeEndUserLoginStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取终端用户总量与平台分布情况
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUserStatisticRequest"/></param>
        /// <returns><see cref="DescribeEndUserStatisticResponse"/></returns>
        public Task<DescribeEndUserStatisticResponse> DescribeEndUserStatistic(DescribeEndUserStatisticRequest req)
        {
            return InternalRequestAsync<DescribeEndUserStatisticResponse>(req, "DescribeEndUserStatistic");
        }

        /// <summary>
        /// 获取终端用户总量与平台分布情况
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUserStatisticRequest"/></param>
        /// <returns><see cref="DescribeEndUserStatisticResponse"/></returns>
        public DescribeEndUserStatisticResponse DescribeEndUserStatisticSync(DescribeEndUserStatisticRequest req)
        {
            return InternalRequestAsync<DescribeEndUserStatisticResponse>(req, "DescribeEndUserStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取终端用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUsersRequest"/></param>
        /// <returns><see cref="DescribeEndUsersResponse"/></returns>
        public Task<DescribeEndUsersResponse> DescribeEndUsers(DescribeEndUsersRequest req)
        {
            return InternalRequestAsync<DescribeEndUsersResponse>(req, "DescribeEndUsers");
        }

        /// <summary>
        /// 获取终端用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUsersRequest"/></param>
        /// <returns><see cref="DescribeEndUsersResponse"/></returns>
        public DescribeEndUsersResponse DescribeEndUsersSync(DescribeEndUsersRequest req)
        {
            return InternalRequestAsync<DescribeEndUsersResponse>(req, "DescribeEndUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取环境下单地域
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvDealRegionRequest"/></param>
        /// <returns><see cref="DescribeEnvDealRegionResponse"/></returns>
        public Task<DescribeEnvDealRegionResponse> DescribeEnvDealRegion(DescribeEnvDealRegionRequest req)
        {
            return InternalRequestAsync<DescribeEnvDealRegionResponse>(req, "DescribeEnvDealRegion");
        }

        /// <summary>
        /// 获取环境下单地域
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvDealRegionRequest"/></param>
        /// <returns><see cref="DescribeEnvDealRegionResponse"/></returns>
        public DescribeEnvDealRegionResponse DescribeEnvDealRegionSync(DescribeEnvDealRegionRequest req)
        {
            return InternalRequestAsync<DescribeEnvDealRegionResponse>(req, "DescribeEnvDealRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询后付费免费配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvFreeQuotaRequest"/></param>
        /// <returns><see cref="DescribeEnvFreeQuotaResponse"/></returns>
        public Task<DescribeEnvFreeQuotaResponse> DescribeEnvFreeQuota(DescribeEnvFreeQuotaRequest req)
        {
            return InternalRequestAsync<DescribeEnvFreeQuotaResponse>(req, "DescribeEnvFreeQuota");
        }

        /// <summary>
        /// 查询后付费免费配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvFreeQuotaRequest"/></param>
        /// <returns><see cref="DescribeEnvFreeQuotaResponse"/></returns>
        public DescribeEnvFreeQuotaResponse DescribeEnvFreeQuotaSync(DescribeEnvFreeQuotaRequest req)
        {
            return InternalRequestAsync<DescribeEnvFreeQuotaResponse>(req, "DescribeEnvFreeQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询环境个数上限
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvLimitRequest"/></param>
        /// <returns><see cref="DescribeEnvLimitResponse"/></returns>
        public Task<DescribeEnvLimitResponse> DescribeEnvLimit(DescribeEnvLimitRequest req)
        {
            return InternalRequestAsync<DescribeEnvLimitResponse>(req, "DescribeEnvLimit");
        }

        /// <summary>
        /// 查询环境个数上限
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvLimitRequest"/></param>
        /// <returns><see cref="DescribeEnvLimitResponse"/></returns>
        public DescribeEnvLimitResponse DescribeEnvLimitSync(DescribeEnvLimitRequest req)
        {
            return InternalRequestAsync<DescribeEnvLimitResponse>(req, "DescribeEnvLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询环境后付费计费详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvPostpaidDeductRequest"/></param>
        /// <returns><see cref="DescribeEnvPostpaidDeductResponse"/></returns>
        public Task<DescribeEnvPostpaidDeductResponse> DescribeEnvPostpaidDeduct(DescribeEnvPostpaidDeductRequest req)
        {
            return InternalRequestAsync<DescribeEnvPostpaidDeductResponse>(req, "DescribeEnvPostpaidDeduct");
        }

        /// <summary>
        /// 查询环境后付费计费详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvPostpaidDeductRequest"/></param>
        /// <returns><see cref="DescribeEnvPostpaidDeductResponse"/></returns>
        public DescribeEnvPostpaidDeductResponse DescribeEnvPostpaidDeductSync(DescribeEnvPostpaidDeductRequest req)
        {
            return InternalRequestAsync<DescribeEnvPostpaidDeductResponse>(req, "DescribeEnvPostpaidDeduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取环境列表，含环境下的各个资源信息。尤其是各资源的唯一标识，是请求各资源的关键参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvsRequest"/></param>
        /// <returns><see cref="DescribeEnvsResponse"/></returns>
        public Task<DescribeEnvsResponse> DescribeEnvs(DescribeEnvsRequest req)
        {
            return InternalRequestAsync<DescribeEnvsResponse>(req, "DescribeEnvs");
        }

        /// <summary>
        /// 获取环境列表，含环境下的各个资源信息。尤其是各资源的唯一标识，是请求各资源的关键参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvsRequest"/></param>
        /// <returns><see cref="DescribeEnvsResponse"/></returns>
        public DescribeEnvsResponse DescribeEnvsSync(DescribeEnvsRequest req)
        {
            return InternalRequestAsync<DescribeEnvsResponse>(req, "DescribeEnvs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 描述扩展上传文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionUploadInfoRequest"/></param>
        /// <returns><see cref="DescribeExtensionUploadInfoResponse"/></returns>
        public Task<DescribeExtensionUploadInfoResponse> DescribeExtensionUploadInfo(DescribeExtensionUploadInfoRequest req)
        {
            return InternalRequestAsync<DescribeExtensionUploadInfoResponse>(req, "DescribeExtensionUploadInfo");
        }

        /// <summary>
        /// 描述扩展上传文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionUploadInfoRequest"/></param>
        /// <returns><see cref="DescribeExtensionUploadInfoResponse"/></returns>
        public DescribeExtensionUploadInfoResponse DescribeExtensionUploadInfoSync(DescribeExtensionUploadInfoRequest req)
        {
            return InternalRequestAsync<DescribeExtensionUploadInfoResponse>(req, "DescribeExtensionUploadInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取增值包计费相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtraPkgBillingInfoRequest"/></param>
        /// <returns><see cref="DescribeExtraPkgBillingInfoResponse"/></returns>
        public Task<DescribeExtraPkgBillingInfoResponse> DescribeExtraPkgBillingInfo(DescribeExtraPkgBillingInfoRequest req)
        {
            return InternalRequestAsync<DescribeExtraPkgBillingInfoResponse>(req, "DescribeExtraPkgBillingInfo");
        }

        /// <summary>
        /// 获取增值包计费相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtraPkgBillingInfoRequest"/></param>
        /// <returns><see cref="DescribeExtraPkgBillingInfoResponse"/></returns>
        public DescribeExtraPkgBillingInfoResponse DescribeExtraPkgBillingInfoSync(DescribeExtraPkgBillingInfoRequest req)
        {
            return InternalRequestAsync<DescribeExtraPkgBillingInfoResponse>(req, "DescribeExtraPkgBillingInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网关监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayCurveDataRequest"/></param>
        /// <returns><see cref="DescribeGatewayCurveDataResponse"/></returns>
        public Task<DescribeGatewayCurveDataResponse> DescribeGatewayCurveData(DescribeGatewayCurveDataRequest req)
        {
            return InternalRequestAsync<DescribeGatewayCurveDataResponse>(req, "DescribeGatewayCurveData");
        }

        /// <summary>
        /// 查询网关监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayCurveDataRequest"/></param>
        /// <returns><see cref="DescribeGatewayCurveDataResponse"/></returns>
        public DescribeGatewayCurveDataResponse DescribeGatewayCurveDataSync(DescribeGatewayCurveDataRequest req)
        {
            return InternalRequestAsync<DescribeGatewayCurveDataResponse>(req, "DescribeGatewayCurveData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网关版本信息
        /// 暂不鉴权
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayVersionsRequest"/></param>
        /// <returns><see cref="DescribeGatewayVersionsResponse"/></returns>
        public Task<DescribeGatewayVersionsResponse> DescribeGatewayVersions(DescribeGatewayVersionsRequest req)
        {
            return InternalRequestAsync<DescribeGatewayVersionsResponse>(req, "DescribeGatewayVersions");
        }

        /// <summary>
        /// 查询网关版本信息
        /// 暂不鉴权
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayVersionsRequest"/></param>
        /// <returns><see cref="DescribeGatewayVersionsResponse"/></returns>
        public DescribeGatewayVersionsResponse DescribeGatewayVersionsSync(DescribeGatewayVersionsRequest req)
        {
            return InternalRequestAsync<DescribeGatewayVersionsResponse>(req, "DescribeGatewayVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据用户传入的指标, 拉取一段时间内的监控数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeGraphDataRequest"/></param>
        /// <returns><see cref="DescribeGraphDataResponse"/></returns>
        public Task<DescribeGraphDataResponse> DescribeGraphData(DescribeGraphDataRequest req)
        {
            return InternalRequestAsync<DescribeGraphDataResponse>(req, "DescribeGraphData");
        }

        /// <summary>
        /// 根据用户传入的指标, 拉取一段时间内的监控数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeGraphDataRequest"/></param>
        /// <returns><see cref="DescribeGraphDataResponse"/></returns>
        public DescribeGraphDataResponse DescribeGraphDataSync(DescribeGraphDataRequest req)
        {
            return InternalRequestAsync<DescribeGraphDataResponse>(req, "DescribeGraphData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询静态托管域名任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeHostingDomainTaskRequest"/></param>
        /// <returns><see cref="DescribeHostingDomainTaskResponse"/></returns>
        public Task<DescribeHostingDomainTaskResponse> DescribeHostingDomainTask(DescribeHostingDomainTaskRequest req)
        {
            return InternalRequestAsync<DescribeHostingDomainTaskResponse>(req, "DescribeHostingDomainTask");
        }

        /// <summary>
        /// 查询静态托管域名任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeHostingDomainTaskRequest"/></param>
        /// <returns><see cref="DescribeHostingDomainTaskResponse"/></returns>
        public DescribeHostingDomainTaskResponse DescribeHostingDomainTaskSync(DescribeHostingDomainTaskRequest req)
        {
            return InternalRequestAsync<DescribeHostingDomainTaskResponse>(req, "DescribeHostingDomainTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询后付费资源免费量
        /// </summary>
        /// <param name="req"><see cref="DescribePostpayFreeQuotasRequest"/></param>
        /// <returns><see cref="DescribePostpayFreeQuotasResponse"/></returns>
        public Task<DescribePostpayFreeQuotasResponse> DescribePostpayFreeQuotas(DescribePostpayFreeQuotasRequest req)
        {
            return InternalRequestAsync<DescribePostpayFreeQuotasResponse>(req, "DescribePostpayFreeQuotas");
        }

        /// <summary>
        /// 查询后付费资源免费量
        /// </summary>
        /// <param name="req"><see cref="DescribePostpayFreeQuotasRequest"/></param>
        /// <returns><see cref="DescribePostpayFreeQuotasResponse"/></returns>
        public DescribePostpayFreeQuotasResponse DescribePostpayFreeQuotasSync(DescribePostpayFreeQuotasRequest req)
        {
            return InternalRequestAsync<DescribePostpayFreeQuotasResponse>(req, "DescribePostpayFreeQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取后付费免费额度
        /// </summary>
        /// <param name="req"><see cref="DescribePostpayPackageFreeQuotasRequest"/></param>
        /// <returns><see cref="DescribePostpayPackageFreeQuotasResponse"/></returns>
        public Task<DescribePostpayPackageFreeQuotasResponse> DescribePostpayPackageFreeQuotas(DescribePostpayPackageFreeQuotasRequest req)
        {
            return InternalRequestAsync<DescribePostpayPackageFreeQuotasResponse>(req, "DescribePostpayPackageFreeQuotas");
        }

        /// <summary>
        /// 获取后付费免费额度
        /// </summary>
        /// <param name="req"><see cref="DescribePostpayPackageFreeQuotasRequest"/></param>
        /// <returns><see cref="DescribePostpayPackageFreeQuotasResponse"/></returns>
        public DescribePostpayPackageFreeQuotasResponse DescribePostpayPackageFreeQuotasSync(DescribePostpayPackageFreeQuotasRequest req)
        {
            return InternalRequestAsync<DescribePostpayPackageFreeQuotasResponse>(req, "DescribePostpayPackageFreeQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定指标的配额使用量
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaDataRequest"/></param>
        /// <returns><see cref="DescribeQuotaDataResponse"/></returns>
        public Task<DescribeQuotaDataResponse> DescribeQuotaData(DescribeQuotaDataRequest req)
        {
            return InternalRequestAsync<DescribeQuotaDataResponse>(req, "DescribeQuotaData");
        }

        /// <summary>
        /// 查询指定指标的配额使用量
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaDataRequest"/></param>
        /// <returns><see cref="DescribeQuotaDataResponse"/></returns>
        public DescribeQuotaDataResponse DescribeQuotaDataSync(DescribeQuotaDataRequest req)
        {
            return InternalRequestAsync<DescribeQuotaDataResponse>(req, "DescribeQuotaData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询后付费短信资源量
        /// 1 有免费包的返回SmsFreeQuota结构所有字段
        /// 2 没有免费包，有付费包，付费返回复用SmsFreeQuota结构，其中只有 TodayUsedQuota 字段有效
        /// 3 都没有返回为空数组
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsQuotasRequest"/></param>
        /// <returns><see cref="DescribeSmsQuotasResponse"/></returns>
        public Task<DescribeSmsQuotasResponse> DescribeSmsQuotas(DescribeSmsQuotasRequest req)
        {
            return InternalRequestAsync<DescribeSmsQuotasResponse>(req, "DescribeSmsQuotas");
        }

        /// <summary>
        /// 查询后付费短信资源量
        /// 1 有免费包的返回SmsFreeQuota结构所有字段
        /// 2 没有免费包，有付费包，付费返回复用SmsFreeQuota结构，其中只有 TodayUsedQuota 字段有效
        /// 3 都没有返回为空数组
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsQuotasRequest"/></param>
        /// <returns><see cref="DescribeSmsQuotasResponse"/></returns>
        public DescribeSmsQuotasResponse DescribeSmsQuotasSync(DescribeSmsQuotasRequest req)
        {
            return InternalRequestAsync<DescribeSmsQuotasResponse>(req, "DescribeSmsQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询环境1分钱抵扣信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecialCostItemsRequest"/></param>
        /// <returns><see cref="DescribeSpecialCostItemsResponse"/></returns>
        public Task<DescribeSpecialCostItemsResponse> DescribeSpecialCostItems(DescribeSpecialCostItemsRequest req)
        {
            return InternalRequestAsync<DescribeSpecialCostItemsResponse>(req, "DescribeSpecialCostItems");
        }

        /// <summary>
        /// 查询环境1分钱抵扣信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecialCostItemsRequest"/></param>
        /// <returns><see cref="DescribeSpecialCostItemsResponse"/></returns>
        public DescribeSpecialCostItemsResponse DescribeSpecialCostItemsSync(DescribeSpecialCostItemsRequest req)
        {
            return InternalRequestAsync<DescribeSpecialCostItemsResponse>(req, "DescribeSpecialCostItems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeStandaloneGateway）查询小租户网关套餐信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStandaloneGatewayRequest"/></param>
        /// <returns><see cref="DescribeStandaloneGatewayResponse"/></returns>
        public Task<DescribeStandaloneGatewayResponse> DescribeStandaloneGateway(DescribeStandaloneGatewayRequest req)
        {
            return InternalRequestAsync<DescribeStandaloneGatewayResponse>(req, "DescribeStandaloneGateway");
        }

        /// <summary>
        /// 本接口（DescribeStandaloneGateway）查询小租户网关套餐信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStandaloneGatewayRequest"/></param>
        /// <returns><see cref="DescribeStandaloneGatewayResponse"/></returns>
        public DescribeStandaloneGatewayResponse DescribeStandaloneGatewaySync(DescribeStandaloneGatewayRequest req)
        {
            return InternalRequestAsync<DescribeStandaloneGatewayResponse>(req, "DescribeStandaloneGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeStandaloneGatewayPackage）用于查询小租户网关套餐信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStandaloneGatewayPackageRequest"/></param>
        /// <returns><see cref="DescribeStandaloneGatewayPackageResponse"/></returns>
        public Task<DescribeStandaloneGatewayPackageResponse> DescribeStandaloneGatewayPackage(DescribeStandaloneGatewayPackageRequest req)
        {
            return InternalRequestAsync<DescribeStandaloneGatewayPackageResponse>(req, "DescribeStandaloneGatewayPackage");
        }

        /// <summary>
        /// 本接口（DescribeStandaloneGatewayPackage）用于查询小租户网关套餐信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStandaloneGatewayPackageRequest"/></param>
        /// <returns><see cref="DescribeStandaloneGatewayPackageResponse"/></returns>
        public DescribeStandaloneGatewayPackageResponse DescribeStandaloneGatewayPackageSync(DescribeStandaloneGatewayPackageRequest req)
        {
            return InternalRequestAsync<DescribeStandaloneGatewayPackageResponse>(req, "DescribeStandaloneGatewayPackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户活动信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserActivityInfoRequest"/></param>
        /// <returns><see cref="DescribeUserActivityInfoResponse"/></returns>
        public Task<DescribeUserActivityInfoResponse> DescribeUserActivityInfo(DescribeUserActivityInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserActivityInfoResponse>(req, "DescribeUserActivityInfo");
        }

        /// <summary>
        /// 查询用户活动信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserActivityInfoRequest"/></param>
        /// <returns><see cref="DescribeUserActivityInfoResponse"/></returns>
        public DescribeUserActivityInfoResponse DescribeUserActivityInfoSync(DescribeUserActivityInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserActivityInfoResponse>(req, "DescribeUserActivityInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询微信云托管环境信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWxCloudBaseRunEnvsRequest"/></param>
        /// <returns><see cref="DescribeWxCloudBaseRunEnvsResponse"/></returns>
        public Task<DescribeWxCloudBaseRunEnvsResponse> DescribeWxCloudBaseRunEnvs(DescribeWxCloudBaseRunEnvsRequest req)
        {
            return InternalRequestAsync<DescribeWxCloudBaseRunEnvsResponse>(req, "DescribeWxCloudBaseRunEnvs");
        }

        /// <summary>
        /// 查询微信云托管环境信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWxCloudBaseRunEnvsRequest"/></param>
        /// <returns><see cref="DescribeWxCloudBaseRunEnvsResponse"/></returns>
        public DescribeWxCloudBaseRunEnvsResponse DescribeWxCloudBaseRunEnvsSync(DescribeWxCloudBaseRunEnvsRequest req)
        {
            return InternalRequestAsync<DescribeWxCloudBaseRunEnvsResponse>(req, "DescribeWxCloudBaseRunEnvs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询微信云托管子网
        /// </summary>
        /// <param name="req"><see cref="DescribeWxCloudBaseRunSubNetsRequest"/></param>
        /// <returns><see cref="DescribeWxCloudBaseRunSubNetsResponse"/></returns>
        public Task<DescribeWxCloudBaseRunSubNetsResponse> DescribeWxCloudBaseRunSubNets(DescribeWxCloudBaseRunSubNetsRequest req)
        {
            return InternalRequestAsync<DescribeWxCloudBaseRunSubNetsResponse>(req, "DescribeWxCloudBaseRunSubNets");
        }

        /// <summary>
        /// 查询微信云托管子网
        /// </summary>
        /// <param name="req"><see cref="DescribeWxCloudBaseRunSubNetsRequest"/></param>
        /// <returns><see cref="DescribeWxCloudBaseRunSubNetsResponse"/></returns>
        public DescribeWxCloudBaseRunSubNetsResponse DescribeWxCloudBaseRunSubNetsSync(DescribeWxCloudBaseRunSubNetsRequest req)
        {
            return InternalRequestAsync<DescribeWxCloudBaseRunSubNetsResponse>(req, "DescribeWxCloudBaseRunSubNets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看安全网关路由
        /// </summary>
        /// <param name="req"><see cref="DescribeWxGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeWxGatewayRoutesResponse"/></returns>
        public Task<DescribeWxGatewayRoutesResponse> DescribeWxGatewayRoutes(DescribeWxGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DescribeWxGatewayRoutesResponse>(req, "DescribeWxGatewayRoutes");
        }

        /// <summary>
        /// 查看安全网关路由
        /// </summary>
        /// <param name="req"><see cref="DescribeWxGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeWxGatewayRoutesResponse"/></returns>
        public DescribeWxGatewayRoutesResponse DescribeWxGatewayRoutesSync(DescribeWxGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DescribeWxGatewayRoutesResponse>(req, "DescribeWxGatewayRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看安全网关
        /// </summary>
        /// <param name="req"><see cref="DescribeWxGatewaysRequest"/></param>
        /// <returns><see cref="DescribeWxGatewaysResponse"/></returns>
        public Task<DescribeWxGatewaysResponse> DescribeWxGateways(DescribeWxGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeWxGatewaysResponse>(req, "DescribeWxGateways");
        }

        /// <summary>
        /// 查看安全网关
        /// </summary>
        /// <param name="req"><see cref="DescribeWxGatewaysRequest"/></param>
        /// <returns><see cref="DescribeWxGatewaysResponse"/></returns>
        public DescribeWxGatewaysResponse DescribeWxGatewaysSync(DescribeWxGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeWxGatewaysResponse>(req, "DescribeWxGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁环境
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvRequest"/></param>
        /// <returns><see cref="DestroyEnvResponse"/></returns>
        public Task<DestroyEnvResponse> DestroyEnv(DestroyEnvRequest req)
        {
            return InternalRequestAsync<DestroyEnvResponse>(req, "DestroyEnv");
        }

        /// <summary>
        /// 销毁环境
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvRequest"/></param>
        /// <returns><see cref="DestroyEnvResponse"/></returns>
        public DestroyEnvResponse DestroyEnvSync(DestroyEnvRequest req)
        {
            return InternalRequestAsync<DestroyEnvResponse>(req, "DestroyEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DestroyStandaloneGateway）用于销毁小租户网关。
        /// </summary>
        /// <param name="req"><see cref="DestroyStandaloneGatewayRequest"/></param>
        /// <returns><see cref="DestroyStandaloneGatewayResponse"/></returns>
        public Task<DestroyStandaloneGatewayResponse> DestroyStandaloneGateway(DestroyStandaloneGatewayRequest req)
        {
            return InternalRequestAsync<DestroyStandaloneGatewayResponse>(req, "DestroyStandaloneGateway");
        }

        /// <summary>
        /// 本接口（DestroyStandaloneGateway）用于销毁小租户网关。
        /// </summary>
        /// <param name="req"><see cref="DestroyStandaloneGatewayRequest"/></param>
        /// <returns><see cref="DestroyStandaloneGatewayResponse"/></returns>
        public DestroyStandaloneGatewayResponse DestroyStandaloneGatewaySync(DestroyStandaloneGatewayRequest req)
        {
            return InternalRequestAsync<DestroyStandaloneGatewayResponse>(req, "DestroyStandaloneGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁静态托管资源，该接口创建异步销毁任务，资源最终状态可从DestroyStaticStore接口查看
        /// </summary>
        /// <param name="req"><see cref="DestroyStaticStoreRequest"/></param>
        /// <returns><see cref="DestroyStaticStoreResponse"/></returns>
        public Task<DestroyStaticStoreResponse> DestroyStaticStore(DestroyStaticStoreRequest req)
        {
            return InternalRequestAsync<DestroyStaticStoreResponse>(req, "DestroyStaticStore");
        }

        /// <summary>
        /// 销毁静态托管资源，该接口创建异步销毁任务，资源最终状态可从DestroyStaticStore接口查看
        /// </summary>
        /// <param name="req"><see cref="DestroyStaticStoreRequest"/></param>
        /// <returns><see cref="DestroyStaticStoreResponse"/></returns>
        public DestroyStaticStoreResponse DestroyStaticStoreSync(DestroyStaticStoreRequest req)
        {
            return InternalRequestAsync<DestroyStaticStoreResponse>(req, "DestroyStaticStore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云应用服务
        /// </summary>
        /// <param name="req"><see cref="EstablishCloudBaseRunServerRequest"/></param>
        /// <returns><see cref="EstablishCloudBaseRunServerResponse"/></returns>
        public Task<EstablishCloudBaseRunServerResponse> EstablishCloudBaseRunServer(EstablishCloudBaseRunServerRequest req)
        {
            return InternalRequestAsync<EstablishCloudBaseRunServerResponse>(req, "EstablishCloudBaseRunServer");
        }

        /// <summary>
        /// 创建云应用服务
        /// </summary>
        /// <param name="req"><see cref="EstablishCloudBaseRunServerRequest"/></param>
        /// <returns><see cref="EstablishCloudBaseRunServerResponse"/></returns>
        public EstablishCloudBaseRunServerResponse EstablishCloudBaseRunServerSync(EstablishCloudBaseRunServerRequest req)
        {
            return InternalRequestAsync<EstablishCloudBaseRunServerResponse>(req, "EstablishCloudBaseRunServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建或修改安全网关路由
        /// </summary>
        /// <param name="req"><see cref="EstablishWxGatewayRouteRequest"/></param>
        /// <returns><see cref="EstablishWxGatewayRouteResponse"/></returns>
        public Task<EstablishWxGatewayRouteResponse> EstablishWxGatewayRoute(EstablishWxGatewayRouteRequest req)
        {
            return InternalRequestAsync<EstablishWxGatewayRouteResponse>(req, "EstablishWxGatewayRoute");
        }

        /// <summary>
        /// 创建或修改安全网关路由
        /// </summary>
        /// <param name="req"><see cref="EstablishWxGatewayRouteRequest"/></param>
        /// <returns><see cref="EstablishWxGatewayRouteResponse"/></returns>
        public EstablishWxGatewayRouteResponse EstablishWxGatewayRouteSync(EstablishWxGatewayRouteRequest req)
        {
            return InternalRequestAsync<EstablishWxGatewayRouteResponse>(req, "EstablishWxGatewayRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量冻结
        /// </summary>
        /// <param name="req"><see cref="FreezeCloudBaseRunServersRequest"/></param>
        /// <returns><see cref="FreezeCloudBaseRunServersResponse"/></returns>
        public Task<FreezeCloudBaseRunServersResponse> FreezeCloudBaseRunServers(FreezeCloudBaseRunServersRequest req)
        {
            return InternalRequestAsync<FreezeCloudBaseRunServersResponse>(req, "FreezeCloudBaseRunServers");
        }

        /// <summary>
        /// 批量冻结
        /// </summary>
        /// <param name="req"><see cref="FreezeCloudBaseRunServersRequest"/></param>
        /// <returns><see cref="FreezeCloudBaseRunServersResponse"/></returns>
        public FreezeCloudBaseRunServersResponse FreezeCloudBaseRunServersSync(FreezeCloudBaseRunServersRequest req)
        {
            return InternalRequestAsync<FreezeCloudBaseRunServersResponse>(req, "FreezeCloudBaseRunServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改容器内的版本流量配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudBaseRunServerFlowConfRequest"/></param>
        /// <returns><see cref="ModifyCloudBaseRunServerFlowConfResponse"/></returns>
        public Task<ModifyCloudBaseRunServerFlowConfResponse> ModifyCloudBaseRunServerFlowConf(ModifyCloudBaseRunServerFlowConfRequest req)
        {
            return InternalRequestAsync<ModifyCloudBaseRunServerFlowConfResponse>(req, "ModifyCloudBaseRunServerFlowConf");
        }

        /// <summary>
        /// 修改容器内的版本流量配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudBaseRunServerFlowConfRequest"/></param>
        /// <returns><see cref="ModifyCloudBaseRunServerFlowConfResponse"/></returns>
        public ModifyCloudBaseRunServerFlowConfResponse ModifyCloudBaseRunServerFlowConfSync(ModifyCloudBaseRunServerFlowConfRequest req)
        {
            return InternalRequestAsync<ModifyCloudBaseRunServerFlowConfResponse>(req, "ModifyCloudBaseRunServerFlowConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改服务版本的副本数，环境变量
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="ModifyCloudBaseRunServerVersionResponse"/></returns>
        public Task<ModifyCloudBaseRunServerVersionResponse> ModifyCloudBaseRunServerVersion(ModifyCloudBaseRunServerVersionRequest req)
        {
            return InternalRequestAsync<ModifyCloudBaseRunServerVersionResponse>(req, "ModifyCloudBaseRunServerVersion");
        }

        /// <summary>
        /// 修改服务版本的副本数，环境变量
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="ModifyCloudBaseRunServerVersionResponse"/></returns>
        public ModifyCloudBaseRunServerVersionResponse ModifyCloudBaseRunServerVersionSync(ModifyCloudBaseRunServerVersionRequest req)
        {
            return InternalRequestAsync<ModifyCloudBaseRunServerVersionResponse>(req, "ModifyCloudBaseRunServerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改日志主题
        /// </summary>
        /// <param name="req"><see cref="ModifyClsTopicRequest"/></param>
        /// <returns><see cref="ModifyClsTopicResponse"/></returns>
        public Task<ModifyClsTopicResponse> ModifyClsTopic(ModifyClsTopicRequest req)
        {
            return InternalRequestAsync<ModifyClsTopicResponse>(req, "ModifyClsTopic");
        }

        /// <summary>
        /// 修改日志主题
        /// </summary>
        /// <param name="req"><see cref="ModifyClsTopicRequest"/></param>
        /// <returns><see cref="ModifyClsTopicResponse"/></returns>
        public ModifyClsTopicResponse ModifyClsTopicSync(ModifyClsTopicRequest req)
        {
            return InternalRequestAsync<ModifyClsTopicResponse>(req, "ModifyClsTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改数据库权限
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseACLRequest"/></param>
        /// <returns><see cref="ModifyDatabaseACLResponse"/></returns>
        public Task<ModifyDatabaseACLResponse> ModifyDatabaseACL(ModifyDatabaseACLRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseACLResponse>(req, "ModifyDatabaseACL");
        }

        /// <summary>
        /// 修改数据库权限
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseACLRequest"/></param>
        /// <returns><see cref="ModifyDatabaseACLResponse"/></returns>
        public ModifyDatabaseACLResponse ModifyDatabaseACLSync(ModifyDatabaseACLRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseACLResponse>(req, "ModifyDatabaseACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 管理终端用户
        /// </summary>
        /// <param name="req"><see cref="ModifyEndUserRequest"/></param>
        /// <returns><see cref="ModifyEndUserResponse"/></returns>
        public Task<ModifyEndUserResponse> ModifyEndUser(ModifyEndUserRequest req)
        {
            return InternalRequestAsync<ModifyEndUserResponse>(req, "ModifyEndUser");
        }

        /// <summary>
        /// 管理终端用户
        /// </summary>
        /// <param name="req"><see cref="ModifyEndUserRequest"/></param>
        /// <returns><see cref="ModifyEndUserResponse"/></returns>
        public ModifyEndUserResponse ModifyEndUserSync(ModifyEndUserRequest req)
        {
            return InternalRequestAsync<ModifyEndUserResponse>(req, "ModifyEndUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新环境信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvRequest"/></param>
        /// <returns><see cref="ModifyEnvResponse"/></returns>
        public Task<ModifyEnvResponse> ModifyEnv(ModifyEnvRequest req)
        {
            return InternalRequestAsync<ModifyEnvResponse>(req, "ModifyEnv");
        }

        /// <summary>
        /// 更新环境信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvRequest"/></param>
        /// <returns><see cref="ModifyEnvResponse"/></returns>
        public ModifyEnvResponse ModifyEnvSync(ModifyEnvRequest req)
        {
            return InternalRequestAsync<ModifyEnvResponse>(req, "ModifyEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置网关版本的流量比例
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayVersionTrafficRequest"/></param>
        /// <returns><see cref="ModifyGatewayVersionTrafficResponse"/></returns>
        public Task<ModifyGatewayVersionTrafficResponse> ModifyGatewayVersionTraffic(ModifyGatewayVersionTrafficRequest req)
        {
            return InternalRequestAsync<ModifyGatewayVersionTrafficResponse>(req, "ModifyGatewayVersionTraffic");
        }

        /// <summary>
        /// 设置网关版本的流量比例
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayVersionTrafficRequest"/></param>
        /// <returns><see cref="ModifyGatewayVersionTrafficResponse"/></returns>
        public ModifyGatewayVersionTrafficResponse ModifyGatewayVersionTrafficSync(ModifyGatewayVersionTrafficRequest req)
        {
            return InternalRequestAsync<ModifyGatewayVersionTrafficResponse>(req, "ModifyGatewayVersionTraffic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 针对已隔离的免费环境，可以通过本接口将其恢复访问。
        /// </summary>
        /// <param name="req"><see cref="ReinstateEnvRequest"/></param>
        /// <returns><see cref="ReinstateEnvResponse"/></returns>
        public Task<ReinstateEnvResponse> ReinstateEnv(ReinstateEnvRequest req)
        {
            return InternalRequestAsync<ReinstateEnvResponse>(req, "ReinstateEnv");
        }

        /// <summary>
        /// 针对已隔离的免费环境，可以通过本接口将其恢复访问。
        /// </summary>
        /// <param name="req"><see cref="ReinstateEnvRequest"/></param>
        /// <returns><see cref="ReinstateEnvResponse"/></returns>
        public ReinstateEnvResponse ReinstateEnvSync(ReinstateEnvRequest req)
        {
            return InternalRequestAsync<ReinstateEnvResponse>(req, "ReinstateEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新活动详情
        /// </summary>
        /// <param name="req"><see cref="ReplaceActivityRecordRequest"/></param>
        /// <returns><see cref="ReplaceActivityRecordResponse"/></returns>
        public Task<ReplaceActivityRecordResponse> ReplaceActivityRecord(ReplaceActivityRecordRequest req)
        {
            return InternalRequestAsync<ReplaceActivityRecordResponse>(req, "ReplaceActivityRecord");
        }

        /// <summary>
        /// 更新活动详情
        /// </summary>
        /// <param name="req"><see cref="ReplaceActivityRecordRequest"/></param>
        /// <returns><see cref="ReplaceActivityRecordResponse"/></returns>
        public ReplaceActivityRecordResponse ReplaceActivityRecordSync(ReplaceActivityRecordRequest req)
        {
            return InternalRequestAsync<ReplaceActivityRecordResponse>(req, "ReplaceActivityRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 针对特定的版本，进行滚动更新
        /// </summary>
        /// <param name="req"><see cref="RollUpdateCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="RollUpdateCloudBaseRunServerVersionResponse"/></returns>
        public Task<RollUpdateCloudBaseRunServerVersionResponse> RollUpdateCloudBaseRunServerVersion(RollUpdateCloudBaseRunServerVersionRequest req)
        {
            return InternalRequestAsync<RollUpdateCloudBaseRunServerVersionResponse>(req, "RollUpdateCloudBaseRunServerVersion");
        }

        /// <summary>
        /// 针对特定的版本，进行滚动更新
        /// </summary>
        /// <param name="req"><see cref="RollUpdateCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="RollUpdateCloudBaseRunServerVersionResponse"/></returns>
        public RollUpdateCloudBaseRunServerVersionResponse RollUpdateCloudBaseRunServerVersionSync(RollUpdateCloudBaseRunServerVersionRequest req)
        {
            return InternalRequestAsync<RollUpdateCloudBaseRunServerVersionResponse>(req, "RollUpdateCloudBaseRunServerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 搜索CLS日志，TCB角色密钥访问
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public Task<SearchClsLogResponse> SearchClsLog(SearchClsLogRequest req)
        {
            return InternalRequestAsync<SearchClsLogResponse>(req, "SearchClsLog");
        }

        /// <summary>
        /// 搜索CLS日志，TCB角色密钥访问
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public SearchClsLogResponse SearchClsLogSync(SearchClsLogRequest req)
        {
            return InternalRequestAsync<SearchClsLogResponse>(req, "SearchClsLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（TurnOffStandaloneGateway）用于关闭小租户网关。
        /// </summary>
        /// <param name="req"><see cref="TurnOffStandaloneGatewayRequest"/></param>
        /// <returns><see cref="TurnOffStandaloneGatewayResponse"/></returns>
        public Task<TurnOffStandaloneGatewayResponse> TurnOffStandaloneGateway(TurnOffStandaloneGatewayRequest req)
        {
            return InternalRequestAsync<TurnOffStandaloneGatewayResponse>(req, "TurnOffStandaloneGateway");
        }

        /// <summary>
        /// 本接口（TurnOffStandaloneGateway）用于关闭小租户网关。
        /// </summary>
        /// <param name="req"><see cref="TurnOffStandaloneGatewayRequest"/></param>
        /// <returns><see cref="TurnOffStandaloneGatewayResponse"/></returns>
        public TurnOffStandaloneGatewayResponse TurnOffStandaloneGatewaySync(TurnOffStandaloneGatewayRequest req)
        {
            return InternalRequestAsync<TurnOffStandaloneGatewayResponse>(req, "TurnOffStandaloneGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（TurnOnStandaloneGateway）用于开启小租户网关。
        /// </summary>
        /// <param name="req"><see cref="TurnOnStandaloneGatewayRequest"/></param>
        /// <returns><see cref="TurnOnStandaloneGatewayResponse"/></returns>
        public Task<TurnOnStandaloneGatewayResponse> TurnOnStandaloneGateway(TurnOnStandaloneGatewayRequest req)
        {
            return InternalRequestAsync<TurnOnStandaloneGatewayResponse>(req, "TurnOnStandaloneGateway");
        }

        /// <summary>
        /// 本接口（TurnOnStandaloneGateway）用于开启小租户网关。
        /// </summary>
        /// <param name="req"><see cref="TurnOnStandaloneGatewayRequest"/></param>
        /// <returns><see cref="TurnOnStandaloneGatewayResponse"/></returns>
        public TurnOnStandaloneGatewayResponse TurnOnStandaloneGatewaySync(TurnOnStandaloneGatewayRequest req)
        {
            return InternalRequestAsync<TurnOnStandaloneGatewayResponse>(req, "TurnOnStandaloneGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量解冻服务
        /// </summary>
        /// <param name="req"><see cref="UnfreezeCloudBaseRunServersRequest"/></param>
        /// <returns><see cref="UnfreezeCloudBaseRunServersResponse"/></returns>
        public Task<UnfreezeCloudBaseRunServersResponse> UnfreezeCloudBaseRunServers(UnfreezeCloudBaseRunServersRequest req)
        {
            return InternalRequestAsync<UnfreezeCloudBaseRunServersResponse>(req, "UnfreezeCloudBaseRunServers");
        }

        /// <summary>
        /// 批量解冻服务
        /// </summary>
        /// <param name="req"><see cref="UnfreezeCloudBaseRunServersRequest"/></param>
        /// <returns><see cref="UnfreezeCloudBaseRunServersResponse"/></returns>
        public UnfreezeCloudBaseRunServersResponse UnfreezeCloudBaseRunServersSync(UnfreezeCloudBaseRunServersRequest req)
        {
            return InternalRequestAsync<UnfreezeCloudBaseRunServersResponse>(req, "UnfreezeCloudBaseRunServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
