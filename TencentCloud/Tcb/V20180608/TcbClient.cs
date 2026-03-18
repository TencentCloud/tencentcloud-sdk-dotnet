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
       private const string sdkVersion = "SDK_NET_3.0.1389";

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
        /// 添加身份认证源。在指定云开发环境下创建一个新的身份认证源，支持 OAuth 2.0、OIDC、SAML 2.0 等标准协议，以及自定义登录和邮箱登录等多种认证方式。
        /// 创建时需指定身份源协议类型（ProviderType）并配置对应的协议连接参数（Config）。若身份源 ID 已存在将返回错误。
        /// 限制：一个环境最大可允许加入20个认证源。
        /// </summary>
        /// <param name="req"><see cref="AddProviderRequest"/></param>
        /// <returns><see cref="AddProviderResponse"/></returns>
        public Task<AddProviderResponse> AddProvider(AddProviderRequest req)
        {
            return InternalRequestAsync<AddProviderResponse>(req, "AddProvider");
        }

        /// <summary>
        /// 添加身份认证源。在指定云开发环境下创建一个新的身份认证源，支持 OAuth 2.0、OIDC、SAML 2.0 等标准协议，以及自定义登录和邮箱登录等多种认证方式。
        /// 创建时需指定身份源协议类型（ProviderType）并配置对应的协议连接参数（Config）。若身份源 ID 已存在将返回错误。
        /// 限制：一个环境最大可允许加入20个认证源。
        /// </summary>
        /// <param name="req"><see cref="AddProviderRequest"/></param>
        /// <returns><see cref="AddProviderResponse"/></returns>
        public AddProviderResponse AddProviderSync(AddProviderRequest req)
        {
            return InternalRequestAsync<AddProviderResponse>(req, "AddProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// **创建环境日志资源**
        /// 
        /// 环境开通后，若用户需要开启检索日志功能，需调用此接口进行日志资源的开通。
        /// 
        /// > **注意**：日志资源的开通为**异步操作**，接口调用成功后并不代表日志资源已立即可用。
        /// 
        /// **如何确认日志开通状态：**
        /// 
        /// 可通过 [DescribeEnvs](https://cloud.tencent.com/document/product/876/34820) 接口轮询查询日志开通结果，建议每 5 秒轮询一次，最长等待 5 分钟。在返回的数据结构 [EnvInfo](https://cloud.tencent.com/document/api/876/34822#EnvInfo) 中，检查 `LogServices` 字段下 `LogServiceInfo` 是否包含有效的日志主题（Topic）等相关信息，以此判断日志资源是否已成功开通：
        /// 
        /// - **已开通**：`LogServiceInfo` 中存在日志主题 ID 等有效信息
        /// - **未开通 / 开通中**：`LogServiceInfo` 为空或相关字段缺失
        /// </summary>
        /// <param name="req"><see cref="CreateEnvResourceRequest"/></param>
        /// <returns><see cref="CreateEnvResourceResponse"/></returns>
        public Task<CreateEnvResourceResponse> CreateEnvResource(CreateEnvResourceRequest req)
        {
            return InternalRequestAsync<CreateEnvResourceResponse>(req, "CreateEnvResource");
        }

        /// <summary>
        /// **创建环境日志资源**
        /// 
        /// 环境开通后，若用户需要开启检索日志功能，需调用此接口进行日志资源的开通。
        /// 
        /// > **注意**：日志资源的开通为**异步操作**，接口调用成功后并不代表日志资源已立即可用。
        /// 
        /// **如何确认日志开通状态：**
        /// 
        /// 可通过 [DescribeEnvs](https://cloud.tencent.com/document/product/876/34820) 接口轮询查询日志开通结果，建议每 5 秒轮询一次，最长等待 5 分钟。在返回的数据结构 [EnvInfo](https://cloud.tencent.com/document/api/876/34822#EnvInfo) 中，检查 `LogServices` 字段下 `LogServiceInfo` 是否包含有效的日志主题（Topic）等相关信息，以此判断日志资源是否已成功开通：
        /// 
        /// - **已开通**：`LogServiceInfo` 中存在日志主题 ID 等有效信息
        /// - **未开通 / 开通中**：`LogServiceInfo` 为空或相关字段缺失
        /// </summary>
        /// <param name="req"><see cref="CreateEnvResourceRequest"/></param>
        /// <returns><see cref="CreateEnvResourceResponse"/></returns>
        public CreateEnvResourceResponse CreateEnvResourceSync(CreateEnvResourceRequest req)
        {
            return InternalRequestAsync<CreateEnvResourceResponse>(req, "CreateEnvResource")
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
        /// 本接口（CreateMySQL）用于开通Mysql型数据库。
        /// 
        /// 开通后，可通过 [DescribeCreateMySQLResult ](https://cloud.tencent.com/document/api/876/128185) 查询开通结果，Mysql开通成功后，可通过接口设置数据库账号相关功能包括但不限于【创建账号、删除账号、查询可授权权限列表、查询账号已有权限、修改主机、修改配置、修改账号库表权限】、集群操作相关【查询集群参数、修改集群参数】，连接设置相关【关闭外网、开通外网、查询集群信息】，备份回档相关【创建手动回档、删除手动回档、修改自动备份配置信息、查询备份文件列表、集群回档、查询任务列表、获取table列表、获取集群数据库列表、查询备份下载地址】，相关功能接口文档：[TDSQL-C MySQL API文档](https://cloud.tencent.com/document/product/1003/48106)，可以通过 [RunSql](https://cloud.tencent.com/document/api/876/127880) 接口来执行 sql 命令，比如创建表格、插入数据、删除表格等 sql 命令。
        /// </summary>
        /// <param name="req"><see cref="CreateMySQLRequest"/></param>
        /// <returns><see cref="CreateMySQLResponse"/></returns>
        public Task<CreateMySQLResponse> CreateMySQL(CreateMySQLRequest req)
        {
            return InternalRequestAsync<CreateMySQLResponse>(req, "CreateMySQL");
        }

        /// <summary>
        /// 本接口（CreateMySQL）用于开通Mysql型数据库。
        /// 
        /// 开通后，可通过 [DescribeCreateMySQLResult ](https://cloud.tencent.com/document/api/876/128185) 查询开通结果，Mysql开通成功后，可通过接口设置数据库账号相关功能包括但不限于【创建账号、删除账号、查询可授权权限列表、查询账号已有权限、修改主机、修改配置、修改账号库表权限】、集群操作相关【查询集群参数、修改集群参数】，连接设置相关【关闭外网、开通外网、查询集群信息】，备份回档相关【创建手动回档、删除手动回档、修改自动备份配置信息、查询备份文件列表、集群回档、查询任务列表、获取table列表、获取集群数据库列表、查询备份下载地址】，相关功能接口文档：[TDSQL-C MySQL API文档](https://cloud.tencent.com/document/product/1003/48106)，可以通过 [RunSql](https://cloud.tencent.com/document/api/876/127880) 接口来执行 sql 命令，比如创建表格、插入数据、删除表格等 sql 命令。
        /// </summary>
        /// <param name="req"><see cref="CreateMySQLRequest"/></param>
        /// <returns><see cref="CreateMySQLResponse"/></returns>
        public CreateMySQLResponse CreateMySQLSync(CreateMySQLRequest req)
        {
            return InternalRequestAsync<CreateMySQLResponse>(req, "CreateMySQL")
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
        /// 本接口(CreateTable)用于创建文档型数据库表，支持创建capped类型集合，暂时不支持分片表。
        /// </summary>
        /// <param name="req"><see cref="CreateTableRequest"/></param>
        /// <returns><see cref="CreateTableResponse"/></returns>
        public Task<CreateTableResponse> CreateTable(CreateTableRequest req)
        {
            return InternalRequestAsync<CreateTableResponse>(req, "CreateTable");
        }

        /// <summary>
        /// 本接口(CreateTable)用于创建文档型数据库表，支持创建capped类型集合，暂时不支持分片表。
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
        /// 删除合法域名。
        /// 云开发会校验网页应用请求的来源域名，您需要将来源域名加入到WEB安全域名列表中。
        /// 可以通过接口 [DescribeAuthDomains](https://cloud.tencent.com/document/product/876/42151) 获取当前已绑定生效的安全域名，将对应安全域名的id填入Domainlds中
        /// 
        /// 注意⚠️
        /// 安全域名被删除之后，可能会引起跨域问题，请谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuthDomainRequest"/></param>
        /// <returns><see cref="DeleteAuthDomainResponse"/></returns>
        public Task<DeleteAuthDomainResponse> DeleteAuthDomain(DeleteAuthDomainRequest req)
        {
            return InternalRequestAsync<DeleteAuthDomainResponse>(req, "DeleteAuthDomain");
        }

        /// <summary>
        /// 删除合法域名。
        /// 云开发会校验网页应用请求的来源域名，您需要将来源域名加入到WEB安全域名列表中。
        /// 可以通过接口 [DescribeAuthDomains](https://cloud.tencent.com/document/product/876/42151) 获取当前已绑定生效的安全域名，将对应安全域名的id填入Domainlds中
        /// 
        /// 注意⚠️
        /// 安全域名被删除之后，可能会引起跨域问题，请谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuthDomainRequest"/></param>
        /// <returns><see cref="DeleteAuthDomainResponse"/></returns>
        public DeleteAuthDomainResponse DeleteAuthDomainSync(DeleteAuthDomainRequest req)
        {
            return InternalRequestAsync<DeleteAuthDomainResponse>(req, "DeleteAuthDomain")
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
        /// 删除认证源
        /// </summary>
        /// <param name="req"><see cref="DeleteProviderRequest"/></param>
        /// <returns><see cref="DeleteProviderResponse"/></returns>
        public Task<DeleteProviderResponse> DeleteProvider(DeleteProviderRequest req)
        {
            return InternalRequestAsync<DeleteProviderResponse>(req, "DeleteProvider");
        }

        /// <summary>
        /// 删除认证源
        /// </summary>
        /// <param name="req"><see cref="DeleteProviderRequest"/></param>
        /// <returns><see cref="DeleteProviderResponse"/></returns>
        public DeleteProviderResponse DeleteProviderSync(DeleteProviderRequest req)
        {
            return InternalRequestAsync<DeleteProviderResponse>(req, "DeleteProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteTable)用于删除文档型数据库表，删除表后表中数据将会被删除且无法恢复，请谨慎操作。
        /// 
        /// 接口入参中的 Tag 为文档型数据库的实例 Id，可以通过 [DescribeEnvs](https://cloud.tencent.com/document/api/876/34820) 接口返回的 EnvList[0].Databases[0].InstanceId 获取。
        /// </summary>
        /// <param name="req"><see cref="DeleteTableRequest"/></param>
        /// <returns><see cref="DeleteTableResponse"/></returns>
        public Task<DeleteTableResponse> DeleteTable(DeleteTableRequest req)
        {
            return InternalRequestAsync<DeleteTableResponse>(req, "DeleteTable");
        }

        /// <summary>
        /// 本接口(DeleteTable)用于删除文档型数据库表，删除表后表中数据将会被删除且无法恢复，请谨慎操作。
        /// 
        /// 接口入参中的 Tag 为文档型数据库的实例 Id，可以通过 [DescribeEnvs](https://cloud.tencent.com/document/api/876/34820) 接口返回的 EnvList[0].Databases[0].InstanceId 获取。
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
        /// 查询客户端详情。获取指定云开发环境下某个客户端的配置信息，包括客户端基本信息（名称、图标、描述）、OAuth 凭证（ClientId、ClientSecret）、安全域名、允许的 Scope 列表、Token 有效期、会话控制策略等。当客户端 ID 等于环境 ID 时，返回该环境的默认客户端配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeClientRequest"/></param>
        /// <returns><see cref="DescribeClientResponse"/></returns>
        public Task<DescribeClientResponse> DescribeClient(DescribeClientRequest req)
        {
            return InternalRequestAsync<DescribeClientResponse>(req, "DescribeClient");
        }

        /// <summary>
        /// 查询客户端详情。获取指定云开发环境下某个客户端的配置信息，包括客户端基本信息（名称、图标、描述）、OAuth 凭证（ClientId、ClientSecret）、安全域名、允许的 Scope 列表、Token 有效期、会话控制策略等。当客户端 ID 等于环境 ID 时，返回该环境的默认客户端配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeClientRequest"/></param>
        /// <returns><see cref="DescribeClientResponse"/></returns>
        public DescribeClientResponse DescribeClientSync(DescribeClientRequest req)
        {
            return InternalRequestAsync<DescribeClientResponse>(req, "DescribeClient")
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
        /// 本接口（DescribeCreateMySQLResult）用于查询开通Mysql结果。
        /// 
        /// `Response.Data.Status = "notexist"` 表示未开通，如果未开通，可以调用 [CreateMySQL](https://cloud.tencent.com/document/api/876/128186) 来开通
        ///  `Response.Data. Status = "success"` 表示开通成功，Mysql开通成功后，可通过接口设置数据库账号相关功能包括但不限于【创建账号、删除账号、查询可授权权限列表、查询账号已有权限、修改主机、修改配置、修改账号库表权限】、集群操作相关【查询集群参数、修改集群参数】，连接设置相关【关闭外网、开通外网、查询集群信息】，备份回档相关【创建手动回档、删除手动回档、修改自动备份配置信息、查询备份文件列表、集群回档、查询任务列表、获取table列表、获取集群数据库列表、查询备份下载地址】，相关功能接口文档：[TDSQL-C MySQL API文档](https://cloud.tencent.com/document/product/1003/48106)，可以通过 [RunSql](https://cloud.tencent.com/document/api/876/127880) 接口来执行 sql 命令，比如创建表格、插入数据、删除表格等 MySql 命令。
        /// </summary>
        /// <param name="req"><see cref="DescribeCreateMySQLResultRequest"/></param>
        /// <returns><see cref="DescribeCreateMySQLResultResponse"/></returns>
        public Task<DescribeCreateMySQLResultResponse> DescribeCreateMySQLResult(DescribeCreateMySQLResultRequest req)
        {
            return InternalRequestAsync<DescribeCreateMySQLResultResponse>(req, "DescribeCreateMySQLResult");
        }

        /// <summary>
        /// 本接口（DescribeCreateMySQLResult）用于查询开通Mysql结果。
        /// 
        /// `Response.Data.Status = "notexist"` 表示未开通，如果未开通，可以调用 [CreateMySQL](https://cloud.tencent.com/document/api/876/128186) 来开通
        ///  `Response.Data. Status = "success"` 表示开通成功，Mysql开通成功后，可通过接口设置数据库账号相关功能包括但不限于【创建账号、删除账号、查询可授权权限列表、查询账号已有权限、修改主机、修改配置、修改账号库表权限】、集群操作相关【查询集群参数、修改集群参数】，连接设置相关【关闭外网、开通外网、查询集群信息】，备份回档相关【创建手动回档、删除手动回档、修改自动备份配置信息、查询备份文件列表、集群回档、查询任务列表、获取table列表、获取集群数据库列表、查询备份下载地址】，相关功能接口文档：[TDSQL-C MySQL API文档](https://cloud.tencent.com/document/product/1003/48106)，可以通过 [RunSql](https://cloud.tencent.com/document/api/876/127880) 接口来执行 sql 命令，比如创建表格、插入数据、删除表格等 MySql 命令。
        /// </summary>
        /// <param name="req"><see cref="DescribeCreateMySQLResultRequest"/></param>
        /// <returns><see cref="DescribeCreateMySQLResultResponse"/></returns>
        public DescribeCreateMySQLResultResponse DescribeCreateMySQLResultSync(DescribeCreateMySQLResultRequest req)
        {
            return InternalRequestAsync<DescribeCreateMySQLResultResponse>(req, "DescribeCreateMySQLResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据指定指标名称，查询某环境在指定时间范围内的监控数据，返回按统计粒度聚合后的时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurveDataRequest"/></param>
        /// <returns><see cref="DescribeCurveDataResponse"/></returns>
        public Task<DescribeCurveDataResponse> DescribeCurveData(DescribeCurveDataRequest req)
        {
            return InternalRequestAsync<DescribeCurveDataResponse>(req, "DescribeCurveData");
        }

        /// <summary>
        /// 根据指定指标名称，查询某环境在指定时间范围内的监控数据，返回按统计粒度聚合后的时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurveDataRequest"/></param>
        /// <returns><see cref="DescribeCurveDataResponse"/></returns>
        public DescribeCurveDataResponse DescribeCurveDataSync(DescribeCurveDataRequest req)
        {
            return InternalRequestAsync<DescribeCurveDataResponse>(req, "DescribeCurveData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDatabaseACL）获取文档型数据库权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseACLRequest"/></param>
        /// <returns><see cref="DescribeDatabaseACLResponse"/></returns>
        public Task<DescribeDatabaseACLResponse> DescribeDatabaseACL(DescribeDatabaseACLRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseACLResponse>(req, "DescribeDatabaseACL");
        }

        /// <summary>
        /// 本接口（DescribeDatabaseACL）获取文档型数据库权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseACLRequest"/></param>
        /// <returns><see cref="DescribeDatabaseACLResponse"/></returns>
        public DescribeDatabaseACLResponse DescribeDatabaseACLSync(DescribeDatabaseACLRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseACLResponse>(req, "DescribeDatabaseACL")
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
        /// 查询指定云开发环境的登录策略配置。包括手机号短信登录、邮箱登录、用户名密码登录和匿名登录方式的开启状态，同时包含短信验证码发送通道、MFA 多因子认证和密码的更新策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginConfigRequest"/></param>
        /// <returns><see cref="DescribeLoginConfigResponse"/></returns>
        public Task<DescribeLoginConfigResponse> DescribeLoginConfig(DescribeLoginConfigRequest req)
        {
            return InternalRequestAsync<DescribeLoginConfigResponse>(req, "DescribeLoginConfig");
        }

        /// <summary>
        /// 查询指定云开发环境的登录策略配置。包括手机号短信登录、邮箱登录、用户名密码登录和匿名登录方式的开启状态，同时包含短信验证码发送通道、MFA 多因子认证和密码的更新策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginConfigRequest"/></param>
        /// <returns><see cref="DescribeLoginConfigResponse"/></returns>
        public DescribeLoginConfigResponse DescribeLoginConfigSync(DescribeLoginConfigRequest req)
        {
            return InternalRequestAsync<DescribeLoginConfigResponse>(req, "DescribeLoginConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMySQLClusterDetail）查询Mysql集群信息。
        /// 
        /// 调用该接口前需要先查询Mysql是否开通，可通过 [DescribeCreateMySQLResult ](https://cloud.tencent.com/document/api/876/128185) 查询，只有已开通的才能查到集群信息，Mysql开通成功后，可通过接口设置数据库账号相关功能包括但不限于【创建账号、删除账号、查询可授权权限列表、查询账号已有权限、修改主机、修改配置、修改账号库表权限】、集群操作相关【查询集群参数、修改集群参数】，连接设置相关【关闭外网、开通外网、查询集群信息】，备份回档相关【创建手动回档、删除手动回档、修改自动备份配置信息、查询备份文件列表、集群回档、查询任务列表、获取table列表、获取集群数据库列表、查询备份下载地址】，相关功能接口文档：[TDSQL-C MySQL API文档](https://cloud.tencent.com/document/product/1003/48106)，可以通过 [RunSql](https://cloud.tencent.com/document/api/876/127880) 接口来执行 MySql 命令，比如创建表格、插入数据、删除表格等 MySql 命令。
        /// </summary>
        /// <param name="req"><see cref="DescribeMySQLClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeMySQLClusterDetailResponse"/></returns>
        public Task<DescribeMySQLClusterDetailResponse> DescribeMySQLClusterDetail(DescribeMySQLClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeMySQLClusterDetailResponse>(req, "DescribeMySQLClusterDetail");
        }

        /// <summary>
        /// 本接口（DescribeMySQLClusterDetail）查询Mysql集群信息。
        /// 
        /// 调用该接口前需要先查询Mysql是否开通，可通过 [DescribeCreateMySQLResult ](https://cloud.tencent.com/document/api/876/128185) 查询，只有已开通的才能查到集群信息，Mysql开通成功后，可通过接口设置数据库账号相关功能包括但不限于【创建账号、删除账号、查询可授权权限列表、查询账号已有权限、修改主机、修改配置、修改账号库表权限】、集群操作相关【查询集群参数、修改集群参数】，连接设置相关【关闭外网、开通外网、查询集群信息】，备份回档相关【创建手动回档、删除手动回档、修改自动备份配置信息、查询备份文件列表、集群回档、查询任务列表、获取table列表、获取集群数据库列表、查询备份下载地址】，相关功能接口文档：[TDSQL-C MySQL API文档](https://cloud.tencent.com/document/product/1003/48106)，可以通过 [RunSql](https://cloud.tencent.com/document/api/876/127880) 接口来执行 MySql 命令，比如创建表格、插入数据、删除表格等 MySql 命令。
        /// </summary>
        /// <param name="req"><see cref="DescribeMySQLClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeMySQLClusterDetailResponse"/></returns>
        public DescribeMySQLClusterDetailResponse DescribeMySQLClusterDetailSync(DescribeMySQLClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeMySQLClusterDetailResponse>(req, "DescribeMySQLClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMySQLTaskStatus）用于查询Mysql任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeMySQLTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeMySQLTaskStatusResponse"/></returns>
        public Task<DescribeMySQLTaskStatusResponse> DescribeMySQLTaskStatus(DescribeMySQLTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeMySQLTaskStatusResponse>(req, "DescribeMySQLTaskStatus");
        }

        /// <summary>
        /// 本接口（DescribeMySQLTaskStatus）用于查询Mysql任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeMySQLTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeMySQLTaskStatusResponse"/></returns>
        public DescribeMySQLTaskStatusResponse DescribeMySQLTaskStatusSync(DescribeMySQLTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeMySQLTaskStatusResponse>(req, "DescribeMySQLTaskStatus")
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
        /// 本接口（DescribeTable）用于查询文档型数据库表的相关信息，包括索引等信息。
        /// 
        /// 接口入参中的 Tag 为文档型数据库的实例 Id，可以通过 [DescribeEnvs](https://cloud.tencent.com/document/api/876/34820) 接口返回的 EnvList[0].Databases[0].InstanceId 获取。
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public Task<DescribeTableResponse> DescribeTable(DescribeTableRequest req)
        {
            return InternalRequestAsync<DescribeTableResponse>(req, "DescribeTable");
        }

        /// <summary>
        /// 本接口（DescribeTable）用于查询文档型数据库表的相关信息，包括索引等信息。
        /// 
        /// 接口入参中的 Tag 为文档型数据库的实例 Id，可以通过 [DescribeEnvs](https://cloud.tencent.com/document/api/876/34820) 接口返回的 EnvList[0].Databases[0].InstanceId 获取。
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public DescribeTableResponse DescribeTableSync(DescribeTableRequest req)
        {
            return InternalRequestAsync<DescribeTableResponse>(req, "DescribeTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeTables)用于查询文档型数据库所有表信息，包括表名、表中数据条数、表中数据量、索引个数及索引的大小等。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables");
        }

        /// <summary>
        /// 本接口(DescribeTables)用于查询文档型数据库所有表信息，包括表名、表中数据条数、表中数据量、索引个数及索引的大小等。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables")
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
        /// 云服务器规格list
        /// </summary>
        /// <param name="req"><see cref="DescribeVmSpecRequest"/></param>
        /// <returns><see cref="DescribeVmSpecResponse"/></returns>
        public Task<DescribeVmSpecResponse> DescribeVmSpec(DescribeVmSpecRequest req)
        {
            return InternalRequestAsync<DescribeVmSpecResponse>(req, "DescribeVmSpec");
        }

        /// <summary>
        /// 云服务器规格list
        /// </summary>
        /// <param name="req"><see cref="DescribeVmSpecRequest"/></param>
        /// <returns><see cref="DescribeVmSpecResponse"/></returns>
        public DescribeVmSpecResponse DescribeVmSpecSync(DescribeVmSpecRequest req)
        {
            return InternalRequestAsync<DescribeVmSpecResponse>(req, "DescribeVmSpec")
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
        /// 本接口（DestroyMySQL）用于销毁Mysql。
        /// 
        /// 销毁后可以通过 [DescribeMySQLTaskStatus](https://cloud.tencent.com/document/api/876/128183) 接口查询销毁结果，如果 `Response.Data. Status = FAILED ` 表示销毁失败，可以重新调用销毁接口重试。
        /// </summary>
        /// <param name="req"><see cref="DestroyMySQLRequest"/></param>
        /// <returns><see cref="DestroyMySQLResponse"/></returns>
        public Task<DestroyMySQLResponse> DestroyMySQL(DestroyMySQLRequest req)
        {
            return InternalRequestAsync<DestroyMySQLResponse>(req, "DestroyMySQL");
        }

        /// <summary>
        /// 本接口（DestroyMySQL）用于销毁Mysql。
        /// 
        /// 销毁后可以通过 [DescribeMySQLTaskStatus](https://cloud.tencent.com/document/api/876/128183) 接口查询销毁结果，如果 `Response.Data. Status = FAILED ` 表示销毁失败，可以重新调用销毁接口重试。
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
        /// 查询指定云开发环境下的身份认证源列表。返回该环境已配置的所有身份认证源信息，包括第三方登录（OAuth、OIDC、SAML）、微信小程序登录、自定义登录和邮箱登录等。返回结果包含认证源基本信息、关联应用、配置状态及启用情况。若自定义登录或邮箱登录的身份源尚未创建，接口会自动追加一个默认关闭状态的身份源记录。
        /// </summary>
        /// <param name="req"><see cref="GetProvidersRequest"/></param>
        /// <returns><see cref="GetProvidersResponse"/></returns>
        public Task<GetProvidersResponse> GetProviders(GetProvidersRequest req)
        {
            return InternalRequestAsync<GetProvidersResponse>(req, "GetProviders");
        }

        /// <summary>
        /// 查询指定云开发环境下的身份认证源列表。返回该环境已配置的所有身份认证源信息，包括第三方登录（OAuth、OIDC、SAML）、微信小程序登录、自定义登录和邮箱登录等。返回结果包含认证源基本信息、关联应用、配置状态及启用情况。若自定义登录或邮箱登录的身份源尚未创建，接口会自动追加一个默认关闭状态的身份源记录。
        /// </summary>
        /// <param name="req"><see cref="GetProvidersRequest"/></param>
        /// <returns><see cref="GetProvidersResponse"/></returns>
        public GetProvidersResponse GetProvidersSync(GetProvidersRequest req)
        {
            return InternalRequestAsync<GetProvidersResponse>(req, "GetProviders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ListTables)用于查询文档型数据库所有表信息，包括表名、表中数据条数、表中数据量、索引个数及索引的大小等。
        /// 
        /// 该接口跟 [DescribeTables](https://cloud.tencent.com/document/api/876/127962) 接口功能一致，后续该接口可能会下线，请使用 [DescribeTable](https://cloud.tencent.com/document/api/876/127962)接口。
        /// </summary>
        /// <param name="req"><see cref="ListTablesRequest"/></param>
        /// <returns><see cref="ListTablesResponse"/></returns>
        public Task<ListTablesResponse> ListTables(ListTablesRequest req)
        {
            return InternalRequestAsync<ListTablesResponse>(req, "ListTables");
        }

        /// <summary>
        /// 本接口(ListTables)用于查询文档型数据库所有表信息，包括表名、表中数据条数、表中数据量、索引个数及索引的大小等。
        /// 
        /// 该接口跟 [DescribeTables](https://cloud.tencent.com/document/api/876/127962) 接口功能一致，后续该接口可能会下线，请使用 [DescribeTable](https://cloud.tencent.com/document/api/876/127962)接口。
        /// </summary>
        /// <param name="req"><see cref="ListTablesRequest"/></param>
        /// <returns><see cref="ListTablesResponse"/></returns>
        public ListTablesResponse ListTablesSync(ListTablesRequest req)
        {
            return InternalRequestAsync<ListTablesResponse>(req, "ListTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改客户端配置。采用增量更新策略，仅更新请求中传入的非空字段，未传入的字段保持原值不变。支持修改客户端基本信息（名称、图标、描述、主页地址）、安全域名、允许的 Scope 列表、Token 有效期、会话控制策略及启用状态等配置。
        /// Id、Secret、CreatedAt、Meta 等字段在该接口中不可修改，当客户端 ID 等于环境 ID 且客户端尚未创建时，将自动创建默认客户端配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyClientRequest"/></param>
        /// <returns><see cref="ModifyClientResponse"/></returns>
        public Task<ModifyClientResponse> ModifyClient(ModifyClientRequest req)
        {
            return InternalRequestAsync<ModifyClientResponse>(req, "ModifyClient");
        }

        /// <summary>
        /// 修改客户端配置。采用增量更新策略，仅更新请求中传入的非空字段，未传入的字段保持原值不变。支持修改客户端基本信息（名称、图标、描述、主页地址）、安全域名、允许的 Scope 列表、Token 有效期、会话控制策略及启用状态等配置。
        /// Id、Secret、CreatedAt、Meta 等字段在该接口中不可修改，当客户端 ID 等于环境 ID 且客户端尚未创建时，将自动创建默认客户端配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyClientRequest"/></param>
        /// <returns><see cref="ModifyClientResponse"/></returns>
        public ModifyClientResponse ModifyClientSync(ModifyClientRequest req)
        {
            return InternalRequestAsync<ModifyClientResponse>(req, "ModifyClient")
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
        /// 本接口（ModifyDatabaseACL）用于修改文档型数据库权限。
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseACLRequest"/></param>
        /// <returns><see cref="ModifyDatabaseACLResponse"/></returns>
        public Task<ModifyDatabaseACLResponse> ModifyDatabaseACL(ModifyDatabaseACLRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseACLResponse>(req, "ModifyDatabaseACL");
        }

        /// <summary>
        /// 本接口（ModifyDatabaseACL）用于修改文档型数据库权限。
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
        /// 修改指定云开发环境的登录策略配置。支持开启或关闭手机号短信登录、邮箱登录、用户名密码登录和匿名登录，同时可配置短信验证码发送通道、MFA 多因子认证和密码更新策略。
        /// 修改后立即生效，影响该环境下所有终端用户的登录行为。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginConfigRequest"/></param>
        /// <returns><see cref="ModifyLoginConfigResponse"/></returns>
        public Task<ModifyLoginConfigResponse> ModifyLoginConfig(ModifyLoginConfigRequest req)
        {
            return InternalRequestAsync<ModifyLoginConfigResponse>(req, "ModifyLoginConfig");
        }

        /// <summary>
        /// 修改指定云开发环境的登录策略配置。支持开启或关闭手机号短信登录、邮箱登录、用户名密码登录和匿名登录，同时可配置短信验证码发送通道、MFA 多因子认证和密码更新策略。
        /// 修改后立即生效，影响该环境下所有终端用户的登录行为。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginConfigRequest"/></param>
        /// <returns><see cref="ModifyLoginConfigResponse"/></returns>
        public ModifyLoginConfigResponse ModifyLoginConfigSync(ModifyLoginConfigRequest req)
        {
            return InternalRequestAsync<ModifyLoginConfigResponse>(req, "ModifyLoginConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改身份认证源。更新指定云开发环境下已有身份认证源的配置信息，支持修改基本信息（名称、图标、描述）、协议连接配置（ClientId、ClientSecret、端点地址等）、登录行为控制（透传模式、自动注册、邮箱/手机号自动关联）以及启用状态。
        /// 对于 OIDC 类型身份源，修改 Issuer 后将自动通过 OpenID Connect Discovery 重新获取端点配置。
        /// 若自定义登录（CUSTOM）或邮箱登录（EMAIL）身份源尚不存在，调用该接口时将自动创建。
        /// </summary>
        /// <param name="req"><see cref="ModifyProviderRequest"/></param>
        /// <returns><see cref="ModifyProviderResponse"/></returns>
        public Task<ModifyProviderResponse> ModifyProvider(ModifyProviderRequest req)
        {
            return InternalRequestAsync<ModifyProviderResponse>(req, "ModifyProvider");
        }

        /// <summary>
        /// 修改身份认证源。更新指定云开发环境下已有身份认证源的配置信息，支持修改基本信息（名称、图标、描述）、协议连接配置（ClientId、ClientSecret、端点地址等）、登录行为控制（透传模式、自动注册、邮箱/手机号自动关联）以及启用状态。
        /// 对于 OIDC 类型身份源，修改 Issuer 后将自动通过 OpenID Connect Discovery 重新获取端点配置。
        /// 若自定义登录（CUSTOM）或邮箱登录（EMAIL）身份源尚不存在，调用该接口时将自动创建。
        /// </summary>
        /// <param name="req"><see cref="ModifyProviderRequest"/></param>
        /// <returns><see cref="ModifyProviderResponse"/></returns>
        public ModifyProviderResponse ModifyProviderSync(ModifyProviderRequest req)
        {
            return InternalRequestAsync<ModifyProviderResponse>(req, "ModifyProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置数据库安全规则。
        /// 安全规则，用于控制C端用户的访问权限。详见 [安全规则介绍 ](https://cloud.tencent.com/document/product/876/123478)。
        /// </summary>
        /// <param name="req"><see cref="ModifySafeRuleRequest"/></param>
        /// <returns><see cref="ModifySafeRuleResponse"/></returns>
        public Task<ModifySafeRuleResponse> ModifySafeRule(ModifySafeRuleRequest req)
        {
            return InternalRequestAsync<ModifySafeRuleResponse>(req, "ModifySafeRule");
        }

        /// <summary>
        /// 设置数据库安全规则。
        /// 安全规则，用于控制C端用户的访问权限。详见 [安全规则介绍 ](https://cloud.tencent.com/document/product/876/123478)。
        /// </summary>
        /// <param name="req"><see cref="ModifySafeRuleRequest"/></param>
        /// <returns><see cref="ModifySafeRuleResponse"/></returns>
        public ModifySafeRuleResponse ModifySafeRuleSync(ModifySafeRuleRequest req)
        {
            return InternalRequestAsync<ModifySafeRuleResponse>(req, "ModifySafeRule")
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
        /// 本接口（RunCommands）用于执行文档型数据库命令。
        /// </summary>
        /// <param name="req"><see cref="RunCommandsRequest"/></param>
        /// <returns><see cref="RunCommandsResponse"/></returns>
        public Task<RunCommandsResponse> RunCommands(RunCommandsRequest req)
        {
            return InternalRequestAsync<RunCommandsResponse>(req, "RunCommands");
        }

        /// <summary>
        /// 本接口（RunCommands）用于执行文档型数据库命令。
        /// </summary>
        /// <param name="req"><see cref="RunCommandsRequest"/></param>
        /// <returns><see cref="RunCommandsResponse"/></returns>
        public RunCommandsResponse RunCommandsSync(RunCommandsRequest req)
        {
            return InternalRequestAsync<RunCommandsResponse>(req, "RunCommands")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RunSql）用于执行MySQL语句。
        /// 
        /// 该接口用来执行 MySql 语句，比如创建表格、插入数据、修改数据、删除字段、添加索引等可以通过sql 语句实现的都可以使用该接口。
        /// 
        /// 调用该接口前需要先查询Mysql是否开通，可通过 [DescribeCreateMySQLResult ](https://cloud.tencent.com/document/api/876/128185) 查询，只有开通成功才能操作。
        /// </summary>
        /// <param name="req"><see cref="RunSqlRequest"/></param>
        /// <returns><see cref="RunSqlResponse"/></returns>
        public Task<RunSqlResponse> RunSql(RunSqlRequest req)
        {
            return InternalRequestAsync<RunSqlResponse>(req, "RunSql");
        }

        /// <summary>
        /// 本接口（RunSql）用于执行MySQL语句。
        /// 
        /// 该接口用来执行 MySql 语句，比如创建表格、插入数据、修改数据、删除字段、添加索引等可以通过sql 语句实现的都可以使用该接口。
        /// 
        /// 调用该接口前需要先查询Mysql是否开通，可通过 [DescribeCreateMySQLResult ](https://cloud.tencent.com/document/api/876/128185) 查询，只有开通成功才能操作。
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
        /// 本接口(UpdateTable)用于修改文档型数据库表信息，当前可以支持创建和删除索引。
        /// </summary>
        /// <param name="req"><see cref="UpdateTableRequest"/></param>
        /// <returns><see cref="UpdateTableResponse"/></returns>
        public Task<UpdateTableResponse> UpdateTable(UpdateTableRequest req)
        {
            return InternalRequestAsync<UpdateTableResponse>(req, "UpdateTable");
        }

        /// <summary>
        /// 本接口(UpdateTable)用于修改文档型数据库表信息，当前可以支持创建和删除索引。
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
