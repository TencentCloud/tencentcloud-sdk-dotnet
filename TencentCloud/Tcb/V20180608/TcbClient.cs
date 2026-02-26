/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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
       private const string sdkVersion = "SDK_NET_3.0.1378";

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
        /// 绑定云开发自定义域名，用于云接入和静态托管
        /// </summary>
        /// <param name="req"><see cref="BindCloudBaseAccessDomainRequest"/></param>
        /// <returns><see cref="BindCloudBaseAccessDomainResponse"/></returns>
        public Task<BindCloudBaseAccessDomainResponse> BindCloudBaseAccessDomain(BindCloudBaseAccessDomainRequest req)
        {
            return InternalRequestAsync<BindCloudBaseAccessDomainResponse>(req, "BindCloudBaseAccessDomain");
        }

        /// <summary>
        /// 绑定云开发自定义域名，用于云接入和静态托管
        /// </summary>
        /// <param name="req"><see cref="BindCloudBaseAccessDomainRequest"/></param>
        /// <returns><see cref="BindCloudBaseAccessDomainResponse"/></returns>
        public BindCloudBaseAccessDomainResponse BindCloudBaseAccessDomainSync(BindCloudBaseAccessDomainRequest req)
        {
            return InternalRequestAsync<BindCloudBaseAccessDomainResponse>(req, "BindCloudBaseAccessDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定自定义域名
        /// </summary>
        /// <param name="req"><see cref="BindCloudBaseGWDomainRequest"/></param>
        /// <returns><see cref="BindCloudBaseGWDomainResponse"/></returns>
        public Task<BindCloudBaseGWDomainResponse> BindCloudBaseGWDomain(BindCloudBaseGWDomainRequest req)
        {
            return InternalRequestAsync<BindCloudBaseGWDomainResponse>(req, "BindCloudBaseGWDomain");
        }

        /// <summary>
        /// 绑定自定义域名
        /// </summary>
        /// <param name="req"><see cref="BindCloudBaseGWDomainRequest"/></param>
        /// <returns><see cref="BindCloudBaseGWDomainResponse"/></returns>
        public BindCloudBaseGWDomainResponse BindCloudBaseGWDomainSync(BindCloudBaseGWDomainRequest req)
        {
            return InternalRequestAsync<BindCloudBaseGWDomainResponse>(req, "BindCloudBaseGWDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// 增加安全域名。
        /// 云开发会校验网页应用请求的来源域名，您需要将来源域名加入到WEB安全域名列表中。
        /// 可以通过接口 [DescribeAuthDomains](https://cloud.tencent.com/document/product/876/42151) 获取当前已绑定生效的安全域名。
        /// 
        /// 注意⚠️
        ///   安全域名绑定成功之后，需要几分钟时间逐步生效。
        /// </summary>
        /// <param name="req"><see cref="CreateAuthDomainRequest"/></param>
        /// <returns><see cref="CreateAuthDomainResponse"/></returns>
        public Task<CreateAuthDomainResponse> CreateAuthDomain(CreateAuthDomainRequest req)
        {
            return InternalRequestAsync<CreateAuthDomainResponse>(req, "CreateAuthDomain");
        }

        /// <summary>
        /// 增加安全域名。
        /// 云开发会校验网页应用请求的来源域名，您需要将来源域名加入到WEB安全域名列表中。
        /// 可以通过接口 [DescribeAuthDomains](https://cloud.tencent.com/document/product/876/42151) 获取当前已绑定生效的安全域名。
        /// 
        /// 注意⚠️
        ///   安全域名绑定成功之后，需要几分钟时间逐步生效。
        /// </summary>
        /// <param name="req"><see cref="CreateAuthDomainRequest"/></param>
        /// <returns><see cref="CreateAuthDomainResponse"/></returns>
        public CreateAuthDomainResponse CreateAuthDomainSync(CreateAuthDomainRequest req)
        {
            return InternalRequestAsync<CreateAuthDomainResponse>(req, "CreateAuthDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云开发产品计费订单，用于以下几种场景：
        /// 1. 购买云开发环境
        /// 2. 续费云开发环境
        /// 3. 变更云开发环境套餐
        /// 4. 购买云开发资源包
        /// 5. 购买云开发大促包
        /// 
        /// 该接口支持下单并支付(CreateAndPay=true时)，此时会自动在腾讯云账户中扣除余额（余额不足会下单失败）。
        /// 该接口支持自动扣除代金券（AutoVoucher=true时），符合条件的代金券会被自动扣除。
        /// </summary>
        /// <param name="req"><see cref="CreateBillDealRequest"/></param>
        /// <returns><see cref="CreateBillDealResponse"/></returns>
        public Task<CreateBillDealResponse> CreateBillDeal(CreateBillDealRequest req)
        {
            return InternalRequestAsync<CreateBillDealResponse>(req, "CreateBillDeal");
        }

        /// <summary>
        /// 创建云开发产品计费订单，用于以下几种场景：
        /// 1. 购买云开发环境
        /// 2. 续费云开发环境
        /// 3. 变更云开发环境套餐
        /// 4. 购买云开发资源包
        /// 5. 购买云开发大促包
        /// 
        /// 该接口支持下单并支付(CreateAndPay=true时)，此时会自动在腾讯云账户中扣除余额（余额不足会下单失败）。
        /// 该接口支持自动扣除代金券（AutoVoucher=true时），符合条件的代金券会被自动扣除。
        /// </summary>
        /// <param name="req"><see cref="CreateBillDealRequest"/></param>
        /// <returns><see cref="CreateBillDealResponse"/></returns>
        public CreateBillDealResponse CreateBillDealSync(CreateBillDealRequest req)
        {
            return InternalRequestAsync<CreateBillDealResponse>(req, "CreateBillDeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云开发网关API
        /// </summary>
        /// <param name="req"><see cref="CreateCloudBaseGWAPIRequest"/></param>
        /// <returns><see cref="CreateCloudBaseGWAPIResponse"/></returns>
        public Task<CreateCloudBaseGWAPIResponse> CreateCloudBaseGWAPI(CreateCloudBaseGWAPIRequest req)
        {
            return InternalRequestAsync<CreateCloudBaseGWAPIResponse>(req, "CreateCloudBaseGWAPI");
        }

        /// <summary>
        /// 创建云开发网关API
        /// </summary>
        /// <param name="req"><see cref="CreateCloudBaseGWAPIRequest"/></param>
        /// <returns><see cref="CreateCloudBaseGWAPIResponse"/></returns>
        public CreateCloudBaseGWAPIResponse CreateCloudBaseGWAPISync(CreateCloudBaseGWAPIRequest req)
        {
            return InternalRequestAsync<CreateCloudBaseGWAPIResponse>(req, "CreateCloudBaseGWAPI")
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
        /// 本接口用于购买云开发环境。
        /// 该接口会自动下单并支付，会在腾讯云账户中扣除余额（余额不足会下单失败）。
        /// 该接口支持自动扣除代金券（AutoVoucher=true时），符合条件的代金券会被自动扣除。
        /// 环境下单成功之后会返回EnvId。EnvId是全局唯一表示。
        /// 环境发货是异步行为，后续可以通过接口 [DescribeEnvs ](https://cloud.tencent.com/document/product/876/34820) 查询环境状态和各项资源信息；通过 [DescribeBillingInfo](https://cloud.tencent.com/document/product/876/94390) 查询环境套餐信息，包括 到期时间、当前套餐等。
        /// </summary>
        /// <param name="req"><see cref="CreateEnvRequest"/></param>
        /// <returns><see cref="CreateEnvResponse"/></returns>
        public Task<CreateEnvResponse> CreateEnv(CreateEnvRequest req)
        {
            return InternalRequestAsync<CreateEnvResponse>(req, "CreateEnv");
        }

        /// <summary>
        /// 本接口用于购买云开发环境。
        /// 该接口会自动下单并支付，会在腾讯云账户中扣除余额（余额不足会下单失败）。
        /// 该接口支持自动扣除代金券（AutoVoucher=true时），符合条件的代金券会被自动扣除。
        /// 环境下单成功之后会返回EnvId。EnvId是全局唯一表示。
        /// 环境发货是异步行为，后续可以通过接口 [DescribeEnvs ](https://cloud.tencent.com/document/product/876/34820) 查询环境状态和各项资源信息；通过 [DescribeBillingInfo](https://cloud.tencent.com/document/product/876/94390) 查询环境套餐信息，包括 到期时间、当前套餐等。
        /// </summary>
        /// <param name="req"><see cref="CreateEnvRequest"/></param>
        /// <returns><see cref="CreateEnvResponse"/></returns>
        public CreateEnvResponse CreateEnvSync(CreateEnvRequest req)
        {
            return InternalRequestAsync<CreateEnvResponse>(req, "CreateEnv")
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
        /// 开通Mysql
        /// </summary>
        /// <param name="req"><see cref="CreateMySQLRequest"/></param>
        /// <returns><see cref="CreateMySQLResponse"/></returns>
        public Task<CreateMySQLResponse> CreateMySQL(CreateMySQLRequest req)
        {
            return InternalRequestAsync<CreateMySQLResponse>(req, "CreateMySQL");
        }

        /// <summary>
        /// 开通Mysql
        /// </summary>
        /// <param name="req"><see cref="CreateMySQLRequest"/></param>
        /// <returns><see cref="CreateMySQLResponse"/></returns>
        public CreateMySQLResponse CreateMySQLSync(CreateMySQLRequest req)
        {
            return InternalRequestAsync<CreateMySQLResponse>(req, "CreateMySQL")
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
        /// 本接口(CreateTable)用于创建表，支持创建capped类型集合，暂时不支持分片表
        /// </summary>
        /// <param name="req"><see cref="CreateTableRequest"/></param>
        /// <returns><see cref="CreateTableResponse"/></returns>
        public Task<CreateTableResponse> CreateTable(CreateTableRequest req)
        {
            return InternalRequestAsync<CreateTableResponse>(req, "CreateTable");
        }

        /// <summary>
        /// 本接口(CreateTable)用于创建表，支持创建capped类型集合，暂时不支持分片表
        /// </summary>
        /// <param name="req"><see cref="CreateTableRequest"/></param>
        /// <returns><see cref="CreateTableResponse"/></returns>
        public CreateTableResponse CreateTableSync(CreateTableRequest req)
        {
            return InternalRequestAsync<CreateTableResponse>(req, "CreateTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建tcb用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// 创建tcb用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除网关API
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseGWAPIRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseGWAPIResponse"/></returns>
        public Task<DeleteCloudBaseGWAPIResponse> DeleteCloudBaseGWAPI(DeleteCloudBaseGWAPIRequest req)
        {
            return InternalRequestAsync<DeleteCloudBaseGWAPIResponse>(req, "DeleteCloudBaseGWAPI");
        }

        /// <summary>
        /// 删除网关API
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseGWAPIRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseGWAPIResponse"/></returns>
        public DeleteCloudBaseGWAPIResponse DeleteCloudBaseGWAPISync(DeleteCloudBaseGWAPIRequest req)
        {
            return InternalRequestAsync<DeleteCloudBaseGWAPIResponse>(req, "DeleteCloudBaseGWAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除网关域名
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseGWDomainRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseGWDomainResponse"/></returns>
        public Task<DeleteCloudBaseGWDomainResponse> DeleteCloudBaseGWDomain(DeleteCloudBaseGWDomainRequest req)
        {
            return InternalRequestAsync<DeleteCloudBaseGWDomainResponse>(req, "DeleteCloudBaseGWDomain");
        }

        /// <summary>
        /// 删除网关域名
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudBaseGWDomainRequest"/></param>
        /// <returns><see cref="DeleteCloudBaseGWDomainResponse"/></returns>
        public DeleteCloudBaseGWDomainResponse DeleteCloudBaseGWDomainSync(DeleteCloudBaseGWDomainRequest req)
        {
            return InternalRequestAsync<DeleteCloudBaseGWDomainResponse>(req, "DeleteCloudBaseGWDomain")
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
        /// 本接口(DeleteTable)用于删除表，删除表后表中数据将会被删除且无法恢复，请谨慎操作
        /// </summary>
        /// <param name="req"><see cref="DeleteTableRequest"/></param>
        /// <returns><see cref="DeleteTableResponse"/></returns>
        public Task<DeleteTableResponse> DeleteTable(DeleteTableRequest req)
        {
            return InternalRequestAsync<DeleteTableResponse>(req, "DeleteTable");
        }

        /// <summary>
        /// 本接口(DeleteTable)用于删除表，删除表后表中数据将会被删除且无法恢复，请谨慎操作
        /// </summary>
        /// <param name="req"><see cref="DeleteTableRequest"/></param>
        /// <returns><see cref="DeleteTableResponse"/></returns>
        public DeleteTableResponse DeleteTableSync(DeleteTableRequest req)
        {
            return InternalRequestAsync<DeleteTableResponse>(req, "DeleteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除tcb用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers");
        }

        /// <summary>
        /// 删除tcb用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public DeleteUsersResponse DeleteUsersSync(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers")
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
        /// 本接口用于获取当前环境的安全域名列表。
        /// 云开发会校验网页应用请求的来源域名，您需要将来源域名加入到WEB安全域名列表中。
        /// 可以通过接口 [CreateAuthDomain](https://cloud.tencent.com/document/product/876/42764) 增加安全域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthDomainsRequest"/></param>
        /// <returns><see cref="DescribeAuthDomainsResponse"/></returns>
        public Task<DescribeAuthDomainsResponse> DescribeAuthDomains(DescribeAuthDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAuthDomainsResponse>(req, "DescribeAuthDomains");
        }

        /// <summary>
        /// 本接口用于获取当前环境的安全域名列表。
        /// 云开发会校验网页应用请求的来源域名，您需要将来源域名加入到WEB安全域名列表中。
        /// 可以通过接口 [CreateAuthDomain](https://cloud.tencent.com/document/product/876/42764) 增加安全域名。
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
        /// 获取网关API列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseGWAPIRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseGWAPIResponse"/></returns>
        public Task<DescribeCloudBaseGWAPIResponse> DescribeCloudBaseGWAPI(DescribeCloudBaseGWAPIRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseGWAPIResponse>(req, "DescribeCloudBaseGWAPI");
        }

        /// <summary>
        /// 获取网关API列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseGWAPIRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseGWAPIResponse"/></returns>
        public DescribeCloudBaseGWAPIResponse DescribeCloudBaseGWAPISync(DescribeCloudBaseGWAPIRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseGWAPIResponse>(req, "DescribeCloudBaseGWAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取网关服务
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseGWServiceRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseGWServiceResponse"/></returns>
        public Task<DescribeCloudBaseGWServiceResponse> DescribeCloudBaseGWService(DescribeCloudBaseGWServiceRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseGWServiceResponse>(req, "DescribeCloudBaseGWService");
        }

        /// <summary>
        /// 获取网关服务
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudBaseGWServiceRequest"/></param>
        /// <returns><see cref="DescribeCloudBaseGWServiceResponse"/></returns>
        public DescribeCloudBaseGWServiceResponse DescribeCloudBaseGWServiceSync(DescribeCloudBaseGWServiceRequest req)
        {
            return InternalRequestAsync<DescribeCloudBaseGWServiceResponse>(req, "DescribeCloudBaseGWService")
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
        /// 查询开通Mysql结果，Mysql开通成功后，可通过接口设置数据库账号相关功能包括但不限于【创建账号、删除账号、查询可授权权限列表、查询账号已有权限、修改主机、修改配置、修改账号库表权限】、集群操作相关【查询集群参数、修改集群参数】，连接设置相关【关闭外网、开通外网、查询集群信息】，备份回档相关【创建手动回档、删除手动回档、修改自动备份配置信息、查询备份文件列表、集群回档、查询任务列表、获取table列表、获取集群数据库列表、查询备份下载地址】，相关功能接口文档：[TDSQL-C MySQL API文档](https://cloud.tencent.com/document/product/1003/48106)
        /// </summary>
        /// <param name="req"><see cref="DescribeCreateMySQLResultRequest"/></param>
        /// <returns><see cref="DescribeCreateMySQLResultResponse"/></returns>
        public Task<DescribeCreateMySQLResultResponse> DescribeCreateMySQLResult(DescribeCreateMySQLResultRequest req)
        {
            return InternalRequestAsync<DescribeCreateMySQLResultResponse>(req, "DescribeCreateMySQLResult");
        }

        /// <summary>
        /// 查询开通Mysql结果，Mysql开通成功后，可通过接口设置数据库账号相关功能包括但不限于【创建账号、删除账号、查询可授权权限列表、查询账号已有权限、修改主机、修改配置、修改账号库表权限】、集群操作相关【查询集群参数、修改集群参数】，连接设置相关【关闭外网、开通外网、查询集群信息】，备份回档相关【创建手动回档、删除手动回档、修改自动备份配置信息、查询备份文件列表、集群回档、查询任务列表、获取table列表、获取集群数据库列表、查询备份下载地址】，相关功能接口文档：[TDSQL-C MySQL API文档](https://cloud.tencent.com/document/product/1003/48106)
        /// </summary>
        /// <param name="req"><see cref="DescribeCreateMySQLResultRequest"/></param>
        /// <returns><see cref="DescribeCreateMySQLResultResponse"/></returns>
        public DescribeCreateMySQLResultResponse DescribeCreateMySQLResultSync(DescribeCreateMySQLResultRequest req)
        {
            return InternalRequestAsync<DescribeCreateMySQLResultResponse>(req, "DescribeCreateMySQLResult")
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
        /// 查询环境计费周期。
        /// 云开发环境的资源点都是按月结算的，每个月都有一定的抵扣额度。
        /// 
        /// 例如：
        ///   某个环境在 2026-01-05 购买了3个月个人版(到期时间: 2026-04-05)，则他可以在以下3个周期内，分别享有40000资源点的额度：
        ///   1. 2026-01-05 ~ 2026-02-05 23:59:59
        ///   2. 2026-02-06 ~ 2026-03-05 23:59:59
        ///   3. 2026-03-06 ~ 2026-04-05 23:59:59
        /// 
        /// 本接口，用于获取环境当前属于哪个计费周期内。
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvAccountCircleRequest"/></param>
        /// <returns><see cref="DescribeEnvAccountCircleResponse"/></returns>
        public Task<DescribeEnvAccountCircleResponse> DescribeEnvAccountCircle(DescribeEnvAccountCircleRequest req)
        {
            return InternalRequestAsync<DescribeEnvAccountCircleResponse>(req, "DescribeEnvAccountCircle");
        }

        /// <summary>
        /// 查询环境计费周期。
        /// 云开发环境的资源点都是按月结算的，每个月都有一定的抵扣额度。
        /// 
        /// 例如：
        ///   某个环境在 2026-01-05 购买了3个月个人版(到期时间: 2026-04-05)，则他可以在以下3个周期内，分别享有40000资源点的额度：
        ///   1. 2026-01-05 ~ 2026-02-05 23:59:59
        ///   2. 2026-02-06 ~ 2026-03-05 23:59:59
        ///   3. 2026-03-06 ~ 2026-04-05 23:59:59
        /// 
        /// 本接口，用于获取环境当前属于哪个计费周期内。
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvAccountCircleRequest"/></param>
        /// <returns><see cref="DescribeEnvAccountCircleResponse"/></returns>
        public DescribeEnvAccountCircleResponse DescribeEnvAccountCircleSync(DescribeEnvAccountCircleRequest req)
        {
            return InternalRequestAsync<DescribeEnvAccountCircleResponse>(req, "DescribeEnvAccountCircle")
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
        /// 销毁Mysql
        /// </summary>
        /// <param name="req"><see cref="DescribeMySQLClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeMySQLClusterDetailResponse"/></returns>
        public Task<DescribeMySQLClusterDetailResponse> DescribeMySQLClusterDetail(DescribeMySQLClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeMySQLClusterDetailResponse>(req, "DescribeMySQLClusterDetail");
        }

        /// <summary>
        /// 销毁Mysql
        /// </summary>
        /// <param name="req"><see cref="DescribeMySQLClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeMySQLClusterDetailResponse"/></returns>
        public DescribeMySQLClusterDetailResponse DescribeMySQLClusterDetailSync(DescribeMySQLClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeMySQLClusterDetailResponse>(req, "DescribeMySQLClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Mysql任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeMySQLTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeMySQLTaskStatusResponse"/></returns>
        public Task<DescribeMySQLTaskStatusResponse> DescribeMySQLTaskStatus(DescribeMySQLTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeMySQLTaskStatusResponse>(req, "DescribeMySQLTaskStatus");
        }

        /// <summary>
        /// 查询Mysql任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeMySQLTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeMySQLTaskStatusResponse"/></returns>
        public DescribeMySQLTaskStatusResponse DescribeMySQLTaskStatusSync(DescribeMySQLTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeMySQLTaskStatusResponse>(req, "DescribeMySQLTaskStatus")
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
        /// 查询数据库安全规则。
        /// 安全规则，用于控制C端用户的访问权限。详见 [安全规则介绍](https://cloud.tencent.com/document/product/876/123478) 。
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeRuleRequest"/></param>
        /// <returns><see cref="DescribeSafeRuleResponse"/></returns>
        public Task<DescribeSafeRuleResponse> DescribeSafeRule(DescribeSafeRuleRequest req)
        {
            return InternalRequestAsync<DescribeSafeRuleResponse>(req, "DescribeSafeRule");
        }

        /// <summary>
        /// 查询数据库安全规则。
        /// 安全规则，用于控制C端用户的访问权限。详见 [安全规则介绍](https://cloud.tencent.com/document/product/876/123478) 。
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeRuleRequest"/></param>
        /// <returns><see cref="DescribeSafeRuleResponse"/></returns>
        public DescribeSafeRuleResponse DescribeSafeRuleSync(DescribeSafeRuleRequest req)
        {
            return InternalRequestAsync<DescribeSafeRuleResponse>(req, "DescribeSafeRule")
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
        /// 查看当前环境下静态托管资源信息，根据返回结果判断静态资源的状态
        /// </summary>
        /// <param name="req"><see cref="DescribeStaticStoreRequest"/></param>
        /// <returns><see cref="DescribeStaticStoreResponse"/></returns>
        public Task<DescribeStaticStoreResponse> DescribeStaticStore(DescribeStaticStoreRequest req)
        {
            return InternalRequestAsync<DescribeStaticStoreResponse>(req, "DescribeStaticStore");
        }

        /// <summary>
        /// 查看当前环境下静态托管资源信息，根据返回结果判断静态资源的状态
        /// </summary>
        /// <param name="req"><see cref="DescribeStaticStoreRequest"/></param>
        /// <returns><see cref="DescribeStaticStoreResponse"/></returns>
        public DescribeStaticStoreResponse DescribeStaticStoreSync(DescribeStaticStoreRequest req)
        {
            return InternalRequestAsync<DescribeStaticStoreResponse>(req, "DescribeStaticStore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表的相关信息，包括索引等信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public Task<DescribeTableResponse> DescribeTable(DescribeTableRequest req)
        {
            return InternalRequestAsync<DescribeTableResponse>(req, "DescribeTable");
        }

        /// <summary>
        /// 查询表的相关信息，包括索引等信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public DescribeTableResponse DescribeTableSync(DescribeTableRequest req)
        {
            return InternalRequestAsync<DescribeTableResponse>(req, "DescribeTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ListTables)用于查询所有表信息，包括表名、表中数据条数、表中数据量、索引个数及索引的大小等
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables");
        }

        /// <summary>
        /// 本接口(ListTables)用于查询所有表信息，包括表名、表中数据条数、表中数据量、索引个数及索引的大小等
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables")
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
        /// 查询tcb用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public Task<DescribeUserListResponse> DescribeUserList(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList");
        }

        /// <summary>
        /// 查询tcb用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public DescribeUserListResponse DescribeUserListSync(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList")
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
        /// 本接口用于销毁云开发环境。
        /// 云开发环境遵循腾讯云包年包月预付费产品生命周期，因此环境销毁需要分两步：
        /// 1. 资源退费。此时会根据当前环境剩余有效期，自动退还相关费用(代金券不退)。退款后，环境进入隔离期。
        /// 2. 环境删除。环境在进入隔离期后15天会自动删除。也可以通过本接口，指定 IsForce=true 来强制删除隔离期环境。
        /// 
        /// **注意**⚠️
        ///   1. 环境退费后进入隔离期，则所有资源均无法访问，控制台无法操作和管理。
        ///   2. 环境被彻底删除后，所有数据均无法找回。请谨慎操作。
        /// 
        /// 可以通过接口 [tcb:DescribeBillingInfo](https://cloud.tencent.com/document/product/876/94390) 查询环境计费状态。
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvRequest"/></param>
        /// <returns><see cref="DestroyEnvResponse"/></returns>
        public Task<DestroyEnvResponse> DestroyEnv(DestroyEnvRequest req)
        {
            return InternalRequestAsync<DestroyEnvResponse>(req, "DestroyEnv");
        }

        /// <summary>
        /// 本接口用于销毁云开发环境。
        /// 云开发环境遵循腾讯云包年包月预付费产品生命周期，因此环境销毁需要分两步：
        /// 1. 资源退费。此时会根据当前环境剩余有效期，自动退还相关费用(代金券不退)。退款后，环境进入隔离期。
        /// 2. 环境删除。环境在进入隔离期后15天会自动删除。也可以通过本接口，指定 IsForce=true 来强制删除隔离期环境。
        /// 
        /// **注意**⚠️
        ///   1. 环境退费后进入隔离期，则所有资源均无法访问，控制台无法操作和管理。
        ///   2. 环境被彻底删除后，所有数据均无法找回。请谨慎操作。
        /// 
        /// 可以通过接口 [tcb:DescribeBillingInfo](https://cloud.tencent.com/document/product/876/94390) 查询环境计费状态。
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvRequest"/></param>
        /// <returns><see cref="DestroyEnvResponse"/></returns>
        public DestroyEnvResponse DestroyEnvSync(DestroyEnvRequest req)
        {
            return InternalRequestAsync<DestroyEnvResponse>(req, "DestroyEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁Mysql
        /// </summary>
        /// <param name="req"><see cref="DestroyMySQLRequest"/></param>
        /// <returns><see cref="DestroyMySQLResponse"/></returns>
        public Task<DestroyMySQLResponse> DestroyMySQL(DestroyMySQLRequest req)
        {
            return InternalRequestAsync<DestroyMySQLResponse>(req, "DestroyMySQL");
        }

        /// <summary>
        /// 销毁Mysql
        /// </summary>
        /// <param name="req"><see cref="DestroyMySQLRequest"/></param>
        /// <returns><see cref="DestroyMySQLResponse"/></returns>
        public DestroyMySQLResponse DestroyMySQLSync(DestroyMySQLRequest req)
        {
            return InternalRequestAsync<DestroyMySQLResponse>(req, "DestroyMySQL")
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
        /// 修改登录配置
        /// </summary>
        /// <param name="req"><see cref="EditAuthConfigRequest"/></param>
        /// <returns><see cref="EditAuthConfigResponse"/></returns>
        public Task<EditAuthConfigResponse> EditAuthConfig(EditAuthConfigRequest req)
        {
            return InternalRequestAsync<EditAuthConfigResponse>(req, "EditAuthConfig");
        }

        /// <summary>
        /// 修改登录配置
        /// </summary>
        /// <param name="req"><see cref="EditAuthConfigRequest"/></param>
        /// <returns><see cref="EditAuthConfigResponse"/></returns>
        public EditAuthConfigResponse EditAuthConfigSync(EditAuthConfigRequest req)
        {
            return InternalRequestAsync<EditAuthConfigResponse>(req, "EditAuthConfig")
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
        /// 本接口(ListTables)用于查询所有表信息，包括表名、表中数据条数、表中数据量、索引个数及索引的大小等
        /// </summary>
        /// <param name="req"><see cref="ListTablesRequest"/></param>
        /// <returns><see cref="ListTablesResponse"/></returns>
        public Task<ListTablesResponse> ListTables(ListTablesRequest req)
        {
            return InternalRequestAsync<ListTablesResponse>(req, "ListTables");
        }

        /// <summary>
        /// 本接口(ListTables)用于查询所有表信息，包括表名、表中数据条数、表中数据量、索引个数及索引的大小等
        /// </summary>
        /// <param name="req"><see cref="ListTablesRequest"/></param>
        /// <returns><see cref="ListTablesResponse"/></returns>
        public ListTablesResponse ListTablesSync(ListTablesRequest req)
        {
            return InternalRequestAsync<ListTablesResponse>(req, "ListTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云开发网关API
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudBaseGWAPIRequest"/></param>
        /// <returns><see cref="ModifyCloudBaseGWAPIResponse"/></returns>
        public Task<ModifyCloudBaseGWAPIResponse> ModifyCloudBaseGWAPI(ModifyCloudBaseGWAPIRequest req)
        {
            return InternalRequestAsync<ModifyCloudBaseGWAPIResponse>(req, "ModifyCloudBaseGWAPI");
        }

        /// <summary>
        /// 修改云开发网关API
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudBaseGWAPIRequest"/></param>
        /// <returns><see cref="ModifyCloudBaseGWAPIResponse"/></returns>
        public ModifyCloudBaseGWAPIResponse ModifyCloudBaseGWAPISync(ModifyCloudBaseGWAPIRequest req)
        {
            return InternalRequestAsync<ModifyCloudBaseGWAPIResponse>(req, "ModifyCloudBaseGWAPI")
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
        /// 本接口用于变更云开发环境套餐。
        /// 该接口会自动下单并支付，会在腾讯云账户中扣除余额（余额不足会下单失败）。
        /// 该接口支持自动扣除代金券（AutoVoucher=true时），符合条件的代金券会被自动扣除。
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvPlanRequest"/></param>
        /// <returns><see cref="ModifyEnvPlanResponse"/></returns>
        public Task<ModifyEnvPlanResponse> ModifyEnvPlan(ModifyEnvPlanRequest req)
        {
            return InternalRequestAsync<ModifyEnvPlanResponse>(req, "ModifyEnvPlan");
        }

        /// <summary>
        /// 本接口用于变更云开发环境套餐。
        /// 该接口会自动下单并支付，会在腾讯云账户中扣除余额（余额不足会下单失败）。
        /// 该接口支持自动扣除代金券（AutoVoucher=true时），符合条件的代金券会被自动扣除。
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvPlanRequest"/></param>
        /// <returns><see cref="ModifyEnvPlanResponse"/></returns>
        public ModifyEnvPlanResponse ModifyEnvPlanSync(ModifyEnvPlanRequest req)
        {
            return InternalRequestAsync<ModifyEnvPlanResponse>(req, "ModifyEnvPlan")
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
        /// 修改tcb用户
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser");
        }

        /// <summary>
        /// 修改tcb用户
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser")
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
        /// 本接口用于云开发环境套餐续费。
        /// 该接口会自动下单并支付，会在腾讯云账户中扣除余额（余额不足会下单失败）。
        /// 该接口支持自动扣除代金券（AutoVoucher=true时），符合条件的代金券会被自动扣除。
        /// </summary>
        /// <param name="req"><see cref="RenewEnvRequest"/></param>
        /// <returns><see cref="RenewEnvResponse"/></returns>
        public Task<RenewEnvResponse> RenewEnv(RenewEnvRequest req)
        {
            return InternalRequestAsync<RenewEnvResponse>(req, "RenewEnv");
        }

        /// <summary>
        /// 本接口用于云开发环境套餐续费。
        /// 该接口会自动下单并支付，会在腾讯云账户中扣除余额（余额不足会下单失败）。
        /// 该接口支持自动扣除代金券（AutoVoucher=true时），符合条件的代金券会被自动扣除。
        /// </summary>
        /// <param name="req"><see cref="RenewEnvRequest"/></param>
        /// <returns><see cref="RenewEnvResponse"/></returns>
        public RenewEnvResponse RenewEnvSync(RenewEnvRequest req)
        {
            return InternalRequestAsync<RenewEnvResponse>(req, "RenewEnv")
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
        /// 执行SQL语句
        /// </summary>
        /// <param name="req"><see cref="RunSqlRequest"/></param>
        /// <returns><see cref="RunSqlResponse"/></returns>
        public Task<RunSqlResponse> RunSql(RunSqlRequest req)
        {
            return InternalRequestAsync<RunSqlResponse>(req, "RunSql");
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="req"><see cref="RunSqlRequest"/></param>
        /// <returns><see cref="RunSqlResponse"/></returns>
        public RunSqlResponse RunSqlSync(RunSqlRequest req)
        {
            return InternalRequestAsync<RunSqlResponse>(req, "RunSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 搜索用户调用日志
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public Task<SearchClsLogResponse> SearchClsLog(SearchClsLogRequest req)
        {
            return InternalRequestAsync<SearchClsLogResponse>(req, "SearchClsLog");
        }

        /// <summary>
        /// 搜索用户调用日志
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public SearchClsLogResponse SearchClsLogSync(SearchClsLogRequest req)
        {
            return InternalRequestAsync<SearchClsLogResponse>(req, "SearchClsLog")
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

        /// <summary>
        /// 本接口(UpdateTable)用于修改表信息，当前可以支持创建和删除索引
        /// </summary>
        /// <param name="req"><see cref="UpdateTableRequest"/></param>
        /// <returns><see cref="UpdateTableResponse"/></returns>
        public Task<UpdateTableResponse> UpdateTable(UpdateTableRequest req)
        {
            return InternalRequestAsync<UpdateTableResponse>(req, "UpdateTable");
        }

        /// <summary>
        /// 本接口(UpdateTable)用于修改表信息，当前可以支持创建和删除索引
        /// </summary>
        /// <param name="req"><see cref="UpdateTableRequest"/></param>
        /// <returns><see cref="UpdateTableResponse"/></returns>
        public UpdateTableResponse UpdateTableSync(UpdateTableRequest req)
        {
            return InternalRequestAsync<UpdateTableResponse>(req, "UpdateTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
