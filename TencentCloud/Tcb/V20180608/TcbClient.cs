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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 检查是否开通Tcb服务
        /// </summary>
        /// <param name="req"><see cref="CheckTcbServiceRequest"/></param>
        /// <returns><see cref="CheckTcbServiceResponse"/></returns>
        public async Task<CheckTcbServiceResponse> CheckTcbService(CheckTcbServiceRequest req)
        {
             JsonResponseModel<CheckTcbServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckTcbService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckTcbServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查是否开通Tcb服务
        /// </summary>
        /// <param name="req"><see cref="CheckTcbServiceRequest"/></param>
        /// <returns><see cref="CheckTcbServiceResponse"/></returns>
        public CheckTcbServiceResponse CheckTcbServiceSync(CheckTcbServiceRequest req)
        {
             JsonResponseModel<CheckTcbServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckTcbService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckTcbServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TCB云API统一入口
        /// </summary>
        /// <param name="req"><see cref="CommonServiceAPIRequest"/></param>
        /// <returns><see cref="CommonServiceAPIResponse"/></returns>
        public async Task<CommonServiceAPIResponse> CommonServiceAPI(CommonServiceAPIRequest req)
        {
             JsonResponseModel<CommonServiceAPIResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CommonServiceAPI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommonServiceAPIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TCB云API统一入口
        /// </summary>
        /// <param name="req"><see cref="CommonServiceAPIRequest"/></param>
        /// <returns><see cref="CommonServiceAPIResponse"/></returns>
        public CommonServiceAPIResponse CommonServiceAPISync(CommonServiceAPIRequest req)
        {
             JsonResponseModel<CommonServiceAPIResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CommonServiceAPI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommonServiceAPIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云开发项目
        /// </summary>
        /// <param name="req"><see cref="CreateAndDeployCloudBaseProjectRequest"/></param>
        /// <returns><see cref="CreateAndDeployCloudBaseProjectResponse"/></returns>
        public async Task<CreateAndDeployCloudBaseProjectResponse> CreateAndDeployCloudBaseProject(CreateAndDeployCloudBaseProjectRequest req)
        {
             JsonResponseModel<CreateAndDeployCloudBaseProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAndDeployCloudBaseProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAndDeployCloudBaseProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云开发项目
        /// </summary>
        /// <param name="req"><see cref="CreateAndDeployCloudBaseProjectRequest"/></param>
        /// <returns><see cref="CreateAndDeployCloudBaseProjectResponse"/></returns>
        public CreateAndDeployCloudBaseProjectResponse CreateAndDeployCloudBaseProjectSync(CreateAndDeployCloudBaseProjectRequest req)
        {
             JsonResponseModel<CreateAndDeployCloudBaseProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAndDeployCloudBaseProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAndDeployCloudBaseProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加安全域名
        /// </summary>
        /// <param name="req"><see cref="CreateAuthDomainRequest"/></param>
        /// <returns><see cref="CreateAuthDomainResponse"/></returns>
        public async Task<CreateAuthDomainResponse> CreateAuthDomain(CreateAuthDomainRequest req)
        {
             JsonResponseModel<CreateAuthDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAuthDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAuthDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加安全域名
        /// </summary>
        /// <param name="req"><see cref="CreateAuthDomainRequest"/></param>
        /// <returns><see cref="CreateAuthDomainResponse"/></returns>
        public CreateAuthDomainResponse CreateAuthDomainSync(CreateAuthDomainRequest req)
        {
             JsonResponseModel<CreateAuthDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAuthDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAuthDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通容器托管的资源，包括集群创建，VPC配置，异步任务创建，镜像托管，Coding等，查看创建结果需要根据DescribeCloudBaseRunResource接口来查看
        /// </summary>
        /// <param name="req"><see cref="CreateCloudBaseRunResourceRequest"/></param>
        /// <returns><see cref="CreateCloudBaseRunResourceResponse"/></returns>
        public async Task<CreateCloudBaseRunResourceResponse> CreateCloudBaseRunResource(CreateCloudBaseRunResourceRequest req)
        {
             JsonResponseModel<CreateCloudBaseRunResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudBaseRunResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudBaseRunResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通容器托管的资源，包括集群创建，VPC配置，异步任务创建，镜像托管，Coding等，查看创建结果需要根据DescribeCloudBaseRunResource接口来查看
        /// </summary>
        /// <param name="req"><see cref="CreateCloudBaseRunResourceRequest"/></param>
        /// <returns><see cref="CreateCloudBaseRunResourceResponse"/></returns>
        public CreateCloudBaseRunResourceResponse CreateCloudBaseRunResourceSync(CreateCloudBaseRunResourceRequest req)
        {
             JsonResponseModel<CreateCloudBaseRunResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudBaseRunResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudBaseRunResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建服务版本
        /// </summary>
        /// <param name="req"><see cref="CreateCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="CreateCloudBaseRunServerVersionResponse"/></returns>
        public async Task<CreateCloudBaseRunServerVersionResponse> CreateCloudBaseRunServerVersion(CreateCloudBaseRunServerVersionRequest req)
        {
             JsonResponseModel<CreateCloudBaseRunServerVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudBaseRunServerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudBaseRunServerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建服务版本
        /// </summary>
        /// <param name="req"><see cref="CreateCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="CreateCloudBaseRunServerVersionResponse"/></returns>
        public CreateCloudBaseRunServerVersionResponse CreateCloudBaseRunServerVersionSync(CreateCloudBaseRunServerVersionRequest req)
        {
             JsonResponseModel<CreateCloudBaseRunServerVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudBaseRunServerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudBaseRunServerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建托管域名
        /// </summary>
        /// <param name="req"><see cref="CreateHostingDomainRequest"/></param>
        /// <returns><see cref="CreateHostingDomainResponse"/></returns>
        public async Task<CreateHostingDomainResponse> CreateHostingDomain(CreateHostingDomainRequest req)
        {
             JsonResponseModel<CreateHostingDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHostingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHostingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建托管域名
        /// </summary>
        /// <param name="req"><see cref="CreateHostingDomainRequest"/></param>
        /// <returns><see cref="CreateHostingDomainResponse"/></returns>
        public CreateHostingDomainResponse CreateHostingDomainSync(CreateHostingDomainRequest req)
        {
             JsonResponseModel<CreateHostingDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHostingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHostingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通后付费资源
        /// </summary>
        /// <param name="req"><see cref="CreatePostpayPackageRequest"/></param>
        /// <returns><see cref="CreatePostpayPackageResponse"/></returns>
        public async Task<CreatePostpayPackageResponse> CreatePostpayPackage(CreatePostpayPackageRequest req)
        {
             JsonResponseModel<CreatePostpayPackageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePostpayPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePostpayPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通后付费资源
        /// </summary>
        /// <param name="req"><see cref="CreatePostpayPackageRequest"/></param>
        /// <returns><see cref="CreatePostpayPackageResponse"/></returns>
        public CreatePostpayPackageResponse CreatePostpayPackageSync(CreatePostpayPackageRequest req)
        {
             JsonResponseModel<CreatePostpayPackageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePostpayPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePostpayPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建静态托管资源，包括COS和CDN，异步任务创建，查看创建结果需要根据DescribeStaticStore接口来查看
        /// </summary>
        /// <param name="req"><see cref="CreateStaticStoreRequest"/></param>
        /// <returns><see cref="CreateStaticStoreResponse"/></returns>
        public async Task<CreateStaticStoreResponse> CreateStaticStore(CreateStaticStoreRequest req)
        {
             JsonResponseModel<CreateStaticStoreResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStaticStore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStaticStoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建静态托管资源，包括COS和CDN，异步任务创建，查看创建结果需要根据DescribeStaticStore接口来查看
        /// </summary>
        /// <param name="req"><see cref="CreateStaticStoreRequest"/></param>
        /// <returns><see cref="CreateStaticStoreResponse"/></returns>
        public CreateStaticStoreResponse CreateStaticStoreSync(CreateStaticStoreRequest req)
        {
             JsonResponseModel<CreateStaticStoreResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStaticStore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStaticStoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建微信云托管
        /// </summary>
        /// <param name="req"><see cref="CreateWxCloudBaseRunEnvRequest"/></param>
        /// <returns><see cref="CreateWxCloudBaseRunEnvResponse"/></returns>
        public async Task<CreateWxCloudBaseRunEnvResponse> CreateWxCloudBaseRunEnv(CreateWxCloudBaseRunEnvRequest req)
        {
             JsonResponseModel<CreateWxCloudBaseRunEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWxCloudBaseRunEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWxCloudBaseRunEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建微信云托管
        /// </summary>
        /// <param name="req"><see cref="CreateWxCloudBaseRunEnvRequest"/></param>
        /// <returns><see cref="CreateWxCloudBaseRunEnvResponse"/></returns>
        public CreateWxCloudBaseRunEnvResponse CreateWxCloudBaseRunEnvSync(CreateWxCloudBaseRunEnvRequest req)
        {
             JsonResponseModel<CreateWxCloudBaseRunEnvResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWxCloudBaseRunEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWxCloudBaseRunEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通微信云托管MySQL数据库服务
        /// </summary>
        /// <param name="req"><see cref="CreateWxCloudBaseRunServerDBClusterRequest"/></param>
        /// <returns><see cref="CreateWxCloudBaseRunServerDBClusterResponse"/></returns>
        public async Task<CreateWxCloudBaseRunServerDBClusterResponse> CreateWxCloudBaseRunServerDBCluster(CreateWxCloudBaseRunServerDBClusterRequest req)
        {
             JsonResponseModel<CreateWxCloudBaseRunServerDBClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWxCloudBaseRunServerDBCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWxCloudBaseRunServerDBClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通微信云托管MySQL数据库服务
        /// </summary>
        /// <param name="req"><see cref="CreateWxCloudBaseRunServerDBClusterRequest"/></param>
        /// <returns><see cref="CreateWxCloudBaseRunServerDBClusterResponse"/></returns>
        public CreateWxCloudBaseRunServerDBClusterResponse CreateWxCloudBaseRunServerDBClusterSync(CreateWxCloudBaseRunServerDBClusterRequest req)
        {
             JsonResponseModel<CreateWxCloudBaseRunServerDBClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWxCloudBaseRunServerDBCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWxCloudBaseRunServerDBClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云项目
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseProjectLatestVersionRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseProjectLatestVersionResponse"/></returns>
        public async Task<DeleteCloudBaseProjectLatestVersionResponse> DeleteCloudBaseProjectLatestVersion(DeleteCloudBaseProjectLatestVersionRequest req)
        {
             JsonResponseModel<DeleteCloudBaseProjectLatestVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCloudBaseProjectLatestVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudBaseProjectLatestVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云项目
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseProjectLatestVersionRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseProjectLatestVersionResponse"/></returns>
        public DeleteCloudBaseProjectLatestVersionResponse DeleteCloudBaseProjectLatestVersionSync(DeleteCloudBaseProjectLatestVersionRequest req)
        {
             JsonResponseModel<DeleteCloudBaseProjectLatestVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCloudBaseProjectLatestVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudBaseProjectLatestVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务版本
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseRunServerVersionResponse"/></returns>
        public async Task<DeleteCloudBaseRunServerVersionResponse> DeleteCloudBaseRunServerVersion(DeleteCloudBaseRunServerVersionRequest req)
        {
             JsonResponseModel<DeleteCloudBaseRunServerVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCloudBaseRunServerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudBaseRunServerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务版本
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseRunServerVersionResponse"/></returns>
        public DeleteCloudBaseRunServerVersionResponse DeleteCloudBaseRunServerVersionSync(DeleteCloudBaseRunServerVersionRequest req)
        {
             JsonResponseModel<DeleteCloudBaseRunServerVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCloudBaseRunServerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudBaseRunServerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除终端用户
        /// </summary>
        /// <param name="req"><see cref="DeleteEndUserRequest"/></param>
        /// <returns><see cref="DeleteEndUserResponse"/></returns>
        public async Task<DeleteEndUserResponse> DeleteEndUser(DeleteEndUserRequest req)
        {
             JsonResponseModel<DeleteEndUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEndUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEndUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除终端用户
        /// </summary>
        /// <param name="req"><see cref="DeleteEndUserRequest"/></param>
        /// <returns><see cref="DeleteEndUserResponse"/></returns>
        public DeleteEndUserResponse DeleteEndUserSync(DeleteEndUserRequest req)
        {
             JsonResponseModel<DeleteEndUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEndUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEndUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除安全网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteWxGatewayRouteRequest"/></param>
        /// <returns><see cref="DeleteWxGatewayRouteResponse"/></returns>
        public async Task<DeleteWxGatewayRouteResponse> DeleteWxGatewayRoute(DeleteWxGatewayRouteRequest req)
        {
             JsonResponseModel<DeleteWxGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWxGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWxGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除安全网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteWxGatewayRouteRequest"/></param>
        /// <returns><see cref="DeleteWxGatewayRouteResponse"/></returns>
        public DeleteWxGatewayRouteResponse DeleteWxGatewayRouteSync(DeleteWxGatewayRouteRequest req)
        {
             JsonResponseModel<DeleteWxGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWxGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWxGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthDomainsRequest"/></param>
        /// <returns><see cref="DescribeAuthDomainsResponse"/></returns>
        public async Task<DescribeAuthDomainsResponse> DescribeAuthDomains(DescribeAuthDomainsRequest req)
        {
             JsonResponseModel<DescribeAuthDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAuthDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuthDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthDomainsRequest"/></param>
        /// <returns><see cref="DescribeAuthDomainsResponse"/></returns>
        public DescribeAuthDomainsResponse DescribeAuthDomainsSync(DescribeAuthDomainsRequest req)
        {
             JsonResponseModel<DescribeAuthDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAuthDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuthDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云托管代码上传url
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseBuildServiceRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseBuildServiceResponse"/></returns>
        public async Task<DescribeCloudBaseBuildServiceResponse> DescribeCloudBaseBuildService(DescribeCloudBaseBuildServiceRequest req)
        {
             JsonResponseModel<DescribeCloudBaseBuildServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudBaseBuildService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseBuildServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云托管代码上传url
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseBuildServiceRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseBuildServiceResponse"/></returns>
        public DescribeCloudBaseBuildServiceResponse DescribeCloudBaseBuildServiceSync(DescribeCloudBaseBuildServiceRequest req)
        {
             JsonResponseModel<DescribeCloudBaseBuildServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudBaseBuildService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseBuildServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云开发项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseProjectLatestVersionListRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseProjectLatestVersionListResponse"/></returns>
        public async Task<DescribeCloudBaseProjectLatestVersionListResponse> DescribeCloudBaseProjectLatestVersionList(DescribeCloudBaseProjectLatestVersionListRequest req)
        {
             JsonResponseModel<DescribeCloudBaseProjectLatestVersionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudBaseProjectLatestVersionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseProjectLatestVersionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云开发项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseProjectLatestVersionListRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseProjectLatestVersionListResponse"/></returns>
        public DescribeCloudBaseProjectLatestVersionListResponse DescribeCloudBaseProjectLatestVersionListSync(DescribeCloudBaseProjectLatestVersionListRequest req)
        {
             JsonResponseModel<DescribeCloudBaseProjectLatestVersionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudBaseProjectLatestVersionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseProjectLatestVersionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云项目部署列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseProjectVersionListRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseProjectVersionListResponse"/></returns>
        public async Task<DescribeCloudBaseProjectVersionListResponse> DescribeCloudBaseProjectVersionList(DescribeCloudBaseProjectVersionListRequest req)
        {
             JsonResponseModel<DescribeCloudBaseProjectVersionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudBaseProjectVersionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseProjectVersionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云项目部署列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseProjectVersionListRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseProjectVersionListResponse"/></returns>
        public DescribeCloudBaseProjectVersionListResponse DescribeCloudBaseProjectVersionListSync(DescribeCloudBaseProjectVersionListRequest req)
        {
             JsonResponseModel<DescribeCloudBaseProjectVersionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudBaseProjectVersionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseProjectVersionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 独立网关中拉取云托管服务对应的配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunConfForGateWayRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunConfForGateWayResponse"/></returns>
        public async Task<DescribeCloudBaseRunConfForGateWayResponse> DescribeCloudBaseRunConfForGateWay(DescribeCloudBaseRunConfForGateWayRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunConfForGateWayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudBaseRunConfForGateWay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunConfForGateWayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 独立网关中拉取云托管服务对应的配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunConfForGateWayRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunConfForGateWayResponse"/></returns>
        public DescribeCloudBaseRunConfForGateWayResponse DescribeCloudBaseRunConfForGateWaySync(DescribeCloudBaseRunConfForGateWayRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunConfForGateWayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudBaseRunConfForGateWay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunConfForGateWayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看容器托管的集群状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunResourceRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunResourceResponse"/></returns>
        public async Task<DescribeCloudBaseRunResourceResponse> DescribeCloudBaseRunResource(DescribeCloudBaseRunResourceRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudBaseRunResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看容器托管的集群状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunResourceRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunResourceResponse"/></returns>
        public DescribeCloudBaseRunResourceResponse DescribeCloudBaseRunResourceSync(DescribeCloudBaseRunResourceRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudBaseRunResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看容器托管的集群状态扩展使用
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunResourceForExtendRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunResourceForExtendResponse"/></returns>
        public async Task<DescribeCloudBaseRunResourceForExtendResponse> DescribeCloudBaseRunResourceForExtend(DescribeCloudBaseRunResourceForExtendRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunResourceForExtendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudBaseRunResourceForExtend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunResourceForExtendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看容器托管的集群状态扩展使用
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunResourceForExtendRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunResourceForExtendResponse"/></returns>
        public DescribeCloudBaseRunResourceForExtendResponse DescribeCloudBaseRunResourceForExtendSync(DescribeCloudBaseRunResourceForExtendRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunResourceForExtendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudBaseRunResourceForExtend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunResourceForExtendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务版本的详情，CPU和MEM  请使用CPUSize和MemSize
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunServerVersionResponse"/></returns>
        public async Task<DescribeCloudBaseRunServerVersionResponse> DescribeCloudBaseRunServerVersion(DescribeCloudBaseRunServerVersionRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunServerVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudBaseRunServerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunServerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务版本的详情，CPU和MEM  请使用CPUSize和MemSize
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunServerVersionResponse"/></returns>
        public DescribeCloudBaseRunServerVersionResponse DescribeCloudBaseRunServerVersionSync(DescribeCloudBaseRunServerVersionRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunServerVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudBaseRunServerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunServerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务版本详情(新)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunVersionRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunVersionResponse"/></returns>
        public async Task<DescribeCloudBaseRunVersionResponse> DescribeCloudBaseRunVersion(DescribeCloudBaseRunVersionRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudBaseRunVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务版本详情(新)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunVersionRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunVersionResponse"/></returns>
        public DescribeCloudBaseRunVersionResponse DescribeCloudBaseRunVersionSync(DescribeCloudBaseRunVersionRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudBaseRunVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询版本历史
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunVersionSnapshotRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunVersionSnapshotResponse"/></returns>
        public async Task<DescribeCloudBaseRunVersionSnapshotResponse> DescribeCloudBaseRunVersionSnapshot(DescribeCloudBaseRunVersionSnapshotRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunVersionSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudBaseRunVersionSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunVersionSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询版本历史
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseRunVersionSnapshotRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseRunVersionSnapshotResponse"/></returns>
        public DescribeCloudBaseRunVersionSnapshotResponse DescribeCloudBaseRunVersionSnapshotSync(DescribeCloudBaseRunVersionSnapshotRequest req)
        {
             JsonResponseModel<DescribeCloudBaseRunVersionSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudBaseRunVersionSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudBaseRunVersionSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据库权限
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseACLRequest"/></param>
        /// <returns><see cref="DescribeDatabaseACLResponse"/></returns>
        public async Task<DescribeDatabaseACLResponse> DescribeDatabaseACL(DescribeDatabaseACLRequest req)
        {
             JsonResponseModel<DescribeDatabaseACLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabaseACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据库权限
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseACLRequest"/></param>
        /// <returns><see cref="DescribeDatabaseACLResponse"/></returns>
        public DescribeDatabaseACLResponse DescribeDatabaseACLSync(DescribeDatabaseACLRequest req)
        {
             JsonResponseModel<DescribeDatabaseACLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabaseACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取下载文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadFileRequest"/></param>
        /// <returns><see cref="DescribeDownloadFileResponse"/></returns>
        public async Task<DescribeDownloadFileResponse> DescribeDownloadFile(DescribeDownloadFileRequest req)
        {
             JsonResponseModel<DescribeDownloadFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDownloadFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDownloadFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取下载文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadFileRequest"/></param>
        /// <returns><see cref="DescribeDownloadFileResponse"/></returns>
        public DescribeDownloadFileResponse DescribeDownloadFileSync(DescribeDownloadFileRequest req)
        {
             JsonResponseModel<DescribeDownloadFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDownloadFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDownloadFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取环境终端用户新增与登录信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUserLoginStatisticRequest"/></param>
        /// <returns><see cref="DescribeEndUserLoginStatisticResponse"/></returns>
        public async Task<DescribeEndUserLoginStatisticResponse> DescribeEndUserLoginStatistic(DescribeEndUserLoginStatisticRequest req)
        {
             JsonResponseModel<DescribeEndUserLoginStatisticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEndUserLoginStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEndUserLoginStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取环境终端用户新增与登录信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUserLoginStatisticRequest"/></param>
        /// <returns><see cref="DescribeEndUserLoginStatisticResponse"/></returns>
        public DescribeEndUserLoginStatisticResponse DescribeEndUserLoginStatisticSync(DescribeEndUserLoginStatisticRequest req)
        {
             JsonResponseModel<DescribeEndUserLoginStatisticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEndUserLoginStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEndUserLoginStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取终端用户总量与平台分布情况
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUserStatisticRequest"/></param>
        /// <returns><see cref="DescribeEndUserStatisticResponse"/></returns>
        public async Task<DescribeEndUserStatisticResponse> DescribeEndUserStatistic(DescribeEndUserStatisticRequest req)
        {
             JsonResponseModel<DescribeEndUserStatisticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEndUserStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEndUserStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取终端用户总量与平台分布情况
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUserStatisticRequest"/></param>
        /// <returns><see cref="DescribeEndUserStatisticResponse"/></returns>
        public DescribeEndUserStatisticResponse DescribeEndUserStatisticSync(DescribeEndUserStatisticRequest req)
        {
             JsonResponseModel<DescribeEndUserStatisticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEndUserStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEndUserStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取终端用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUsersRequest"/></param>
        /// <returns><see cref="DescribeEndUsersResponse"/></returns>
        public async Task<DescribeEndUsersResponse> DescribeEndUsers(DescribeEndUsersRequest req)
        {
             JsonResponseModel<DescribeEndUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEndUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEndUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取终端用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEndUsersRequest"/></param>
        /// <returns><see cref="DescribeEndUsersResponse"/></returns>
        public DescribeEndUsersResponse DescribeEndUsersSync(DescribeEndUsersRequest req)
        {
             JsonResponseModel<DescribeEndUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEndUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEndUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询后付费免费配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvFreeQuotaRequest"/></param>
        /// <returns><see cref="DescribeEnvFreeQuotaResponse"/></returns>
        public async Task<DescribeEnvFreeQuotaResponse> DescribeEnvFreeQuota(DescribeEnvFreeQuotaRequest req)
        {
             JsonResponseModel<DescribeEnvFreeQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvFreeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvFreeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询后付费免费配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvFreeQuotaRequest"/></param>
        /// <returns><see cref="DescribeEnvFreeQuotaResponse"/></returns>
        public DescribeEnvFreeQuotaResponse DescribeEnvFreeQuotaSync(DescribeEnvFreeQuotaRequest req)
        {
             JsonResponseModel<DescribeEnvFreeQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvFreeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvFreeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询环境个数上限
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvLimitRequest"/></param>
        /// <returns><see cref="DescribeEnvLimitResponse"/></returns>
        public async Task<DescribeEnvLimitResponse> DescribeEnvLimit(DescribeEnvLimitRequest req)
        {
             JsonResponseModel<DescribeEnvLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询环境个数上限
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvLimitRequest"/></param>
        /// <returns><see cref="DescribeEnvLimitResponse"/></returns>
        public DescribeEnvLimitResponse DescribeEnvLimitSync(DescribeEnvLimitRequest req)
        {
             JsonResponseModel<DescribeEnvLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取环境列表，含环境下的各个资源信息。尤其是各资源的唯一标识，是请求各资源的关键参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvsRequest"/></param>
        /// <returns><see cref="DescribeEnvsResponse"/></returns>
        public async Task<DescribeEnvsResponse> DescribeEnvs(DescribeEnvsRequest req)
        {
             JsonResponseModel<DescribeEnvsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取环境列表，含环境下的各个资源信息。尤其是各资源的唯一标识，是请求各资源的关键参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvsRequest"/></param>
        /// <returns><see cref="DescribeEnvsResponse"/></returns>
        public DescribeEnvsResponse DescribeEnvsSync(DescribeEnvsRequest req)
        {
             JsonResponseModel<DescribeEnvsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述扩展上传文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionUploadInfoRequest"/></param>
        /// <returns><see cref="DescribeExtensionUploadInfoResponse"/></returns>
        public async Task<DescribeExtensionUploadInfoResponse> DescribeExtensionUploadInfo(DescribeExtensionUploadInfoRequest req)
        {
             JsonResponseModel<DescribeExtensionUploadInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExtensionUploadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtensionUploadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述扩展上传文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtensionUploadInfoRequest"/></param>
        /// <returns><see cref="DescribeExtensionUploadInfoResponse"/></returns>
        public DescribeExtensionUploadInfoResponse DescribeExtensionUploadInfoSync(DescribeExtensionUploadInfoRequest req)
        {
             JsonResponseModel<DescribeExtensionUploadInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExtensionUploadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtensionUploadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取增值包计费相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtraPkgBillingInfoRequest"/></param>
        /// <returns><see cref="DescribeExtraPkgBillingInfoResponse"/></returns>
        public async Task<DescribeExtraPkgBillingInfoResponse> DescribeExtraPkgBillingInfo(DescribeExtraPkgBillingInfoRequest req)
        {
             JsonResponseModel<DescribeExtraPkgBillingInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExtraPkgBillingInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtraPkgBillingInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取增值包计费相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExtraPkgBillingInfoRequest"/></param>
        /// <returns><see cref="DescribeExtraPkgBillingInfoResponse"/></returns>
        public DescribeExtraPkgBillingInfoResponse DescribeExtraPkgBillingInfoSync(DescribeExtraPkgBillingInfoRequest req)
        {
             JsonResponseModel<DescribeExtraPkgBillingInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExtraPkgBillingInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtraPkgBillingInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询静态托管域名任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeHostingDomainTaskRequest"/></param>
        /// <returns><see cref="DescribeHostingDomainTaskResponse"/></returns>
        public async Task<DescribeHostingDomainTaskResponse> DescribeHostingDomainTask(DescribeHostingDomainTaskRequest req)
        {
             JsonResponseModel<DescribeHostingDomainTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostingDomainTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostingDomainTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询静态托管域名任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeHostingDomainTaskRequest"/></param>
        /// <returns><see cref="DescribeHostingDomainTaskResponse"/></returns>
        public DescribeHostingDomainTaskResponse DescribeHostingDomainTaskSync(DescribeHostingDomainTaskRequest req)
        {
             JsonResponseModel<DescribeHostingDomainTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostingDomainTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostingDomainTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询后付费资源免费量
        /// </summary>
        /// <param name="req"><see cref="DescribePostpayFreeQuotasRequest"/></param>
        /// <returns><see cref="DescribePostpayFreeQuotasResponse"/></returns>
        public async Task<DescribePostpayFreeQuotasResponse> DescribePostpayFreeQuotas(DescribePostpayFreeQuotasRequest req)
        {
             JsonResponseModel<DescribePostpayFreeQuotasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePostpayFreeQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePostpayFreeQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询后付费资源免费量
        /// </summary>
        /// <param name="req"><see cref="DescribePostpayFreeQuotasRequest"/></param>
        /// <returns><see cref="DescribePostpayFreeQuotasResponse"/></returns>
        public DescribePostpayFreeQuotasResponse DescribePostpayFreeQuotasSync(DescribePostpayFreeQuotasRequest req)
        {
             JsonResponseModel<DescribePostpayFreeQuotasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePostpayFreeQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePostpayFreeQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取后付费免费额度
        /// </summary>
        /// <param name="req"><see cref="DescribePostpayPackageFreeQuotasRequest"/></param>
        /// <returns><see cref="DescribePostpayPackageFreeQuotasResponse"/></returns>
        public async Task<DescribePostpayPackageFreeQuotasResponse> DescribePostpayPackageFreeQuotas(DescribePostpayPackageFreeQuotasRequest req)
        {
             JsonResponseModel<DescribePostpayPackageFreeQuotasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePostpayPackageFreeQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePostpayPackageFreeQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取后付费免费额度
        /// </summary>
        /// <param name="req"><see cref="DescribePostpayPackageFreeQuotasRequest"/></param>
        /// <returns><see cref="DescribePostpayPackageFreeQuotasResponse"/></returns>
        public DescribePostpayPackageFreeQuotasResponse DescribePostpayPackageFreeQuotasSync(DescribePostpayPackageFreeQuotasRequest req)
        {
             JsonResponseModel<DescribePostpayPackageFreeQuotasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePostpayPackageFreeQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePostpayPackageFreeQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定指标的配额使用量
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaDataRequest"/></param>
        /// <returns><see cref="DescribeQuotaDataResponse"/></returns>
        public async Task<DescribeQuotaDataResponse> DescribeQuotaData(DescribeQuotaDataRequest req)
        {
             JsonResponseModel<DescribeQuotaDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQuotaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQuotaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定指标的配额使用量
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaDataRequest"/></param>
        /// <returns><see cref="DescribeQuotaDataResponse"/></returns>
        public DescribeQuotaDataResponse DescribeQuotaDataSync(DescribeQuotaDataRequest req)
        {
             JsonResponseModel<DescribeQuotaDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQuotaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQuotaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询后付费短信资源量
        /// 1 有免费包的返回SmsFreeQuota结构所有字段
        /// 2 没有免费包，有付费包，付费返回复用SmsFreeQuota结构，其中只有 TodayUsedQuota 字段有效
        /// 3 都没有返回为空数组
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsQuotasRequest"/></param>
        /// <returns><see cref="DescribeSmsQuotasResponse"/></returns>
        public async Task<DescribeSmsQuotasResponse> DescribeSmsQuotas(DescribeSmsQuotasRequest req)
        {
             JsonResponseModel<DescribeSmsQuotasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmsQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeSmsQuotasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSmsQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微信云托管环境信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWxCloudBaseRunEnvsRequest"/></param>
        /// <returns><see cref="DescribeWxCloudBaseRunEnvsResponse"/></returns>
        public async Task<DescribeWxCloudBaseRunEnvsResponse> DescribeWxCloudBaseRunEnvs(DescribeWxCloudBaseRunEnvsRequest req)
        {
             JsonResponseModel<DescribeWxCloudBaseRunEnvsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWxCloudBaseRunEnvs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWxCloudBaseRunEnvsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微信云托管环境信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWxCloudBaseRunEnvsRequest"/></param>
        /// <returns><see cref="DescribeWxCloudBaseRunEnvsResponse"/></returns>
        public DescribeWxCloudBaseRunEnvsResponse DescribeWxCloudBaseRunEnvsSync(DescribeWxCloudBaseRunEnvsRequest req)
        {
             JsonResponseModel<DescribeWxCloudBaseRunEnvsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWxCloudBaseRunEnvs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWxCloudBaseRunEnvsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微信云托管子网
        /// </summary>
        /// <param name="req"><see cref="DescribeWxCloudBaseRunSubNetsRequest"/></param>
        /// <returns><see cref="DescribeWxCloudBaseRunSubNetsResponse"/></returns>
        public async Task<DescribeWxCloudBaseRunSubNetsResponse> DescribeWxCloudBaseRunSubNets(DescribeWxCloudBaseRunSubNetsRequest req)
        {
             JsonResponseModel<DescribeWxCloudBaseRunSubNetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWxCloudBaseRunSubNets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWxCloudBaseRunSubNetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微信云托管子网
        /// </summary>
        /// <param name="req"><see cref="DescribeWxCloudBaseRunSubNetsRequest"/></param>
        /// <returns><see cref="DescribeWxCloudBaseRunSubNetsResponse"/></returns>
        public DescribeWxCloudBaseRunSubNetsResponse DescribeWxCloudBaseRunSubNetsSync(DescribeWxCloudBaseRunSubNetsRequest req)
        {
             JsonResponseModel<DescribeWxCloudBaseRunSubNetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWxCloudBaseRunSubNets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWxCloudBaseRunSubNetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁环境
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvRequest"/></param>
        /// <returns><see cref="DestroyEnvResponse"/></returns>
        public async Task<DestroyEnvResponse> DestroyEnv(DestroyEnvRequest req)
        {
             JsonResponseModel<DestroyEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁环境
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvRequest"/></param>
        /// <returns><see cref="DestroyEnvResponse"/></returns>
        public DestroyEnvResponse DestroyEnvSync(DestroyEnvRequest req)
        {
             JsonResponseModel<DestroyEnvResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁静态托管资源，该接口创建异步销毁任务，资源最终状态可从DestroyStaticStore接口查看
        /// </summary>
        /// <param name="req"><see cref="DestroyStaticStoreRequest"/></param>
        /// <returns><see cref="DestroyStaticStoreResponse"/></returns>
        public async Task<DestroyStaticStoreResponse> DestroyStaticStore(DestroyStaticStoreRequest req)
        {
             JsonResponseModel<DestroyStaticStoreResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyStaticStore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyStaticStoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁静态托管资源，该接口创建异步销毁任务，资源最终状态可从DestroyStaticStore接口查看
        /// </summary>
        /// <param name="req"><see cref="DestroyStaticStoreRequest"/></param>
        /// <returns><see cref="DestroyStaticStoreResponse"/></returns>
        public DestroyStaticStoreResponse DestroyStaticStoreSync(DestroyStaticStoreRequest req)
        {
             JsonResponseModel<DestroyStaticStoreResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyStaticStore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyStaticStoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云应用服务
        /// </summary>
        /// <param name="req"><see cref="EstablishCloudBaseRunServerRequest"/></param>
        /// <returns><see cref="EstablishCloudBaseRunServerResponse"/></returns>
        public async Task<EstablishCloudBaseRunServerResponse> EstablishCloudBaseRunServer(EstablishCloudBaseRunServerRequest req)
        {
             JsonResponseModel<EstablishCloudBaseRunServerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EstablishCloudBaseRunServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EstablishCloudBaseRunServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云应用服务
        /// </summary>
        /// <param name="req"><see cref="EstablishCloudBaseRunServerRequest"/></param>
        /// <returns><see cref="EstablishCloudBaseRunServerResponse"/></returns>
        public EstablishCloudBaseRunServerResponse EstablishCloudBaseRunServerSync(EstablishCloudBaseRunServerRequest req)
        {
             JsonResponseModel<EstablishCloudBaseRunServerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EstablishCloudBaseRunServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EstablishCloudBaseRunServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建或修改安全网关路由
        /// </summary>
        /// <param name="req"><see cref="EstablishWxGatewayRouteRequest"/></param>
        /// <returns><see cref="EstablishWxGatewayRouteResponse"/></returns>
        public async Task<EstablishWxGatewayRouteResponse> EstablishWxGatewayRoute(EstablishWxGatewayRouteRequest req)
        {
             JsonResponseModel<EstablishWxGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EstablishWxGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EstablishWxGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建或修改安全网关路由
        /// </summary>
        /// <param name="req"><see cref="EstablishWxGatewayRouteRequest"/></param>
        /// <returns><see cref="EstablishWxGatewayRouteResponse"/></returns>
        public EstablishWxGatewayRouteResponse EstablishWxGatewayRouteSync(EstablishWxGatewayRouteRequest req)
        {
             JsonResponseModel<EstablishWxGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EstablishWxGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EstablishWxGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改容器内的版本流量配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudBaseRunServerFlowConfRequest"/></param>
        /// <returns><see cref="ModifyCloudBaseRunServerFlowConfResponse"/></returns>
        public async Task<ModifyCloudBaseRunServerFlowConfResponse> ModifyCloudBaseRunServerFlowConf(ModifyCloudBaseRunServerFlowConfRequest req)
        {
             JsonResponseModel<ModifyCloudBaseRunServerFlowConfResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCloudBaseRunServerFlowConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudBaseRunServerFlowConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改容器内的版本流量配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudBaseRunServerFlowConfRequest"/></param>
        /// <returns><see cref="ModifyCloudBaseRunServerFlowConfResponse"/></returns>
        public ModifyCloudBaseRunServerFlowConfResponse ModifyCloudBaseRunServerFlowConfSync(ModifyCloudBaseRunServerFlowConfRequest req)
        {
             JsonResponseModel<ModifyCloudBaseRunServerFlowConfResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCloudBaseRunServerFlowConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudBaseRunServerFlowConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改数据库权限
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseACLRequest"/></param>
        /// <returns><see cref="ModifyDatabaseACLResponse"/></returns>
        public async Task<ModifyDatabaseACLResponse> ModifyDatabaseACL(ModifyDatabaseACLRequest req)
        {
             JsonResponseModel<ModifyDatabaseACLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDatabaseACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDatabaseACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改数据库权限
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseACLRequest"/></param>
        /// <returns><see cref="ModifyDatabaseACLResponse"/></returns>
        public ModifyDatabaseACLResponse ModifyDatabaseACLSync(ModifyDatabaseACLRequest req)
        {
             JsonResponseModel<ModifyDatabaseACLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDatabaseACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDatabaseACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 管理终端用户
        /// </summary>
        /// <param name="req"><see cref="ModifyEndUserRequest"/></param>
        /// <returns><see cref="ModifyEndUserResponse"/></returns>
        public async Task<ModifyEndUserResponse> ModifyEndUser(ModifyEndUserRequest req)
        {
             JsonResponseModel<ModifyEndUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEndUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEndUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 管理终端用户
        /// </summary>
        /// <param name="req"><see cref="ModifyEndUserRequest"/></param>
        /// <returns><see cref="ModifyEndUserResponse"/></returns>
        public ModifyEndUserResponse ModifyEndUserSync(ModifyEndUserRequest req)
        {
             JsonResponseModel<ModifyEndUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEndUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEndUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新环境信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvRequest"/></param>
        /// <returns><see cref="ModifyEnvResponse"/></returns>
        public async Task<ModifyEnvResponse> ModifyEnv(ModifyEnvRequest req)
        {
             JsonResponseModel<ModifyEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新环境信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvRequest"/></param>
        /// <returns><see cref="ModifyEnvResponse"/></returns>
        public ModifyEnvResponse ModifyEnvSync(ModifyEnvRequest req)
        {
             JsonResponseModel<ModifyEnvResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对已隔离的免费环境，可以通过本接口将其恢复访问。
        /// </summary>
        /// <param name="req"><see cref="ReinstateEnvRequest"/></param>
        /// <returns><see cref="ReinstateEnvResponse"/></returns>
        public async Task<ReinstateEnvResponse> ReinstateEnv(ReinstateEnvRequest req)
        {
             JsonResponseModel<ReinstateEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReinstateEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReinstateEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对已隔离的免费环境，可以通过本接口将其恢复访问。
        /// </summary>
        /// <param name="req"><see cref="ReinstateEnvRequest"/></param>
        /// <returns><see cref="ReinstateEnvResponse"/></returns>
        public ReinstateEnvResponse ReinstateEnvSync(ReinstateEnvRequest req)
        {
             JsonResponseModel<ReinstateEnvResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReinstateEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReinstateEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对特定的版本，进行滚动更新
        /// </summary>
        /// <param name="req"><see cref="RollUpdateCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="RollUpdateCloudBaseRunServerVersionResponse"/></returns>
        public async Task<RollUpdateCloudBaseRunServerVersionResponse> RollUpdateCloudBaseRunServerVersion(RollUpdateCloudBaseRunServerVersionRequest req)
        {
             JsonResponseModel<RollUpdateCloudBaseRunServerVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RollUpdateCloudBaseRunServerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollUpdateCloudBaseRunServerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对特定的版本，进行滚动更新
        /// </summary>
        /// <param name="req"><see cref="RollUpdateCloudBaseRunServerVersionRequest"/></param>
        /// <returns><see cref="RollUpdateCloudBaseRunServerVersionResponse"/></returns>
        public RollUpdateCloudBaseRunServerVersionResponse RollUpdateCloudBaseRunServerVersionSync(RollUpdateCloudBaseRunServerVersionRequest req)
        {
             JsonResponseModel<RollUpdateCloudBaseRunServerVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RollUpdateCloudBaseRunServerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollUpdateCloudBaseRunServerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
