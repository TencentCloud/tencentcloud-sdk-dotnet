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

namespace TencentCloud.Cdb.V20170320
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdb.V20170320.Models;

   public class CdbClient : AbstractClient{

       private const string endpoint = "cdb.tencentcloudapi.com";
       private const string version = "2017-03-20";
       private const string sdkVersion = "SDK_NET_3.0.1026";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口(AddTimeWindow)用于添加云数据库实例的维护时间窗口，以指定实例在哪些时间段可以自动执行切换访问操作。
        /// </summary>
        /// <param name="req"><see cref="AddTimeWindowRequest"/></param>
        /// <returns><see cref="AddTimeWindowResponse"/></returns>
        public Task<AddTimeWindowResponse> AddTimeWindow(AddTimeWindowRequest req)
        {
            return InternalRequestAsync<AddTimeWindowResponse>(req, "AddTimeWindow");
        }

        /// <summary>
        /// 本接口(AddTimeWindow)用于添加云数据库实例的维护时间窗口，以指定实例在哪些时间段可以自动执行切换访问操作。
        /// </summary>
        /// <param name="req"><see cref="AddTimeWindowRequest"/></param>
        /// <returns><see cref="AddTimeWindowResponse"/></returns>
        public AddTimeWindowResponse AddTimeWindowSync(AddTimeWindowRequest req)
        {
            return InternalRequestAsync<AddTimeWindowResponse>(req, "AddTimeWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整数据库代理配置
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyResponse"/></returns>
        public Task<AdjustCdbProxyResponse> AdjustCdbProxy(AdjustCdbProxyRequest req)
        {
            return InternalRequestAsync<AdjustCdbProxyResponse>(req, "AdjustCdbProxy");
        }

        /// <summary>
        /// 调整数据库代理配置
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyResponse"/></returns>
        public AdjustCdbProxyResponse AdjustCdbProxySync(AdjustCdbProxyRequest req)
        {
            return InternalRequestAsync<AdjustCdbProxyResponse>(req, "AdjustCdbProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整数据库代理地址配置
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyAddressRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyAddressResponse"/></returns>
        public Task<AdjustCdbProxyAddressResponse> AdjustCdbProxyAddress(AdjustCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<AdjustCdbProxyAddressResponse>(req, "AdjustCdbProxyAddress");
        }

        /// <summary>
        /// 调整数据库代理地址配置
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyAddressRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyAddressResponse"/></returns>
        public AdjustCdbProxyAddressResponse AdjustCdbProxyAddressSync(AdjustCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<AdjustCdbProxyAddressResponse>(req, "AdjustCdbProxyAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在不同过滤条件下的审计日志结果集中，选定特定的数据列进行聚合统计。
        /// </summary>
        /// <param name="req"><see cref="AnalyzeAuditLogsRequest"/></param>
        /// <returns><see cref="AnalyzeAuditLogsResponse"/></returns>
        public Task<AnalyzeAuditLogsResponse> AnalyzeAuditLogs(AnalyzeAuditLogsRequest req)
        {
            return InternalRequestAsync<AnalyzeAuditLogsResponse>(req, "AnalyzeAuditLogs");
        }

        /// <summary>
        /// 在不同过滤条件下的审计日志结果集中，选定特定的数据列进行聚合统计。
        /// </summary>
        /// <param name="req"><see cref="AnalyzeAuditLogsRequest"/></param>
        /// <returns><see cref="AnalyzeAuditLogsResponse"/></returns>
        public AnalyzeAuditLogsResponse AnalyzeAuditLogsSync(AnalyzeAuditLogsRequest req)
        {
            return InternalRequestAsync<AnalyzeAuditLogsResponse>(req, "AnalyzeAuditLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(AssociateSecurityGroups)用于安全组批量绑定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// 本接口(AssociateSecurityGroups)用于安全组批量绑定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(BalanceRoGroupLoad)用于重新均衡 RO 组内实例的负载。注意，RO 组内 RO 实例会有一次数据库连接瞬断，请确保应用程序能重连数据库，谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="BalanceRoGroupLoadRequest"/></param>
        /// <returns><see cref="BalanceRoGroupLoadResponse"/></returns>
        public Task<BalanceRoGroupLoadResponse> BalanceRoGroupLoad(BalanceRoGroupLoadRequest req)
        {
            return InternalRequestAsync<BalanceRoGroupLoadResponse>(req, "BalanceRoGroupLoad");
        }

        /// <summary>
        /// 本接口(BalanceRoGroupLoad)用于重新均衡 RO 组内实例的负载。注意，RO 组内 RO 实例会有一次数据库连接瞬断，请确保应用程序能重连数据库，谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="BalanceRoGroupLoadRequest"/></param>
        /// <returns><see cref="BalanceRoGroupLoadResponse"/></returns>
        public BalanceRoGroupLoadResponse BalanceRoGroupLoadSync(BalanceRoGroupLoadRequest req)
        {
            return InternalRequestAsync<BalanceRoGroupLoadResponse>(req, "BalanceRoGroupLoad")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 高可用实例一键迁移到集群版校验
        /// </summary>
        /// <param name="req"><see cref="CheckMigrateClusterRequest"/></param>
        /// <returns><see cref="CheckMigrateClusterResponse"/></returns>
        public Task<CheckMigrateClusterResponse> CheckMigrateCluster(CheckMigrateClusterRequest req)
        {
            return InternalRequestAsync<CheckMigrateClusterResponse>(req, "CheckMigrateCluster");
        }

        /// <summary>
        /// 高可用实例一键迁移到集群版校验
        /// </summary>
        /// <param name="req"><see cref="CheckMigrateClusterRequest"/></param>
        /// <returns><see cref="CheckMigrateClusterResponse"/></returns>
        public CheckMigrateClusterResponse CheckMigrateClusterSync(CheckMigrateClusterRequest req)
        {
            return InternalRequestAsync<CheckMigrateClusterResponse>(req, "CheckMigrateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例关闭审计服务
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public Task<CloseAuditServiceResponse> CloseAuditService(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService");
        }

        /// <summary>
        /// 实例关闭审计服务
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public CloseAuditServiceResponse CloseAuditServiceSync(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭数据库代理
        /// </summary>
        /// <param name="req"><see cref="CloseCDBProxyRequest"/></param>
        /// <returns><see cref="CloseCDBProxyResponse"/></returns>
        public Task<CloseCDBProxyResponse> CloseCDBProxy(CloseCDBProxyRequest req)
        {
            return InternalRequestAsync<CloseCDBProxyResponse>(req, "CloseCDBProxy");
        }

        /// <summary>
        /// 关闭数据库代理
        /// </summary>
        /// <param name="req"><see cref="CloseCDBProxyRequest"/></param>
        /// <returns><see cref="CloseCDBProxyResponse"/></returns>
        public CloseCDBProxyResponse CloseCDBProxySync(CloseCDBProxyRequest req)
        {
            return InternalRequestAsync<CloseCDBProxyResponse>(req, "CloseCDBProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 请求关闭数据库代理地址
        /// </summary>
        /// <param name="req"><see cref="CloseCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CloseCdbProxyAddressResponse"/></returns>
        public Task<CloseCdbProxyAddressResponse> CloseCdbProxyAddress(CloseCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<CloseCdbProxyAddressResponse>(req, "CloseCdbProxyAddress");
        }

        /// <summary>
        /// 请求关闭数据库代理地址
        /// </summary>
        /// <param name="req"><see cref="CloseCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CloseCdbProxyAddressResponse"/></returns>
        public CloseCdbProxyAddressResponse CloseCdbProxyAddressSync(CloseCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<CloseCdbProxyAddressResponse>(req, "CloseCdbProxyAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭SSL连接功能。
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public Task<CloseSSLResponse> CloseSSL(CloseSSLRequest req)
        {
            return InternalRequestAsync<CloseSSLResponse>(req, "CloseSSL");
        }

        /// <summary>
        /// 关闭SSL连接功能。
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public CloseSSLResponse CloseSSLSync(CloseSSLRequest req)
        {
            return InternalRequestAsync<CloseSSLResponse>(req, "CloseSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CloseWanService)用于关闭云数据库实例的外网访问。关闭外网访问后，外网地址将不可访问。
        /// </summary>
        /// <param name="req"><see cref="CloseWanServiceRequest"/></param>
        /// <returns><see cref="CloseWanServiceResponse"/></returns>
        public Task<CloseWanServiceResponse> CloseWanService(CloseWanServiceRequest req)
        {
            return InternalRequestAsync<CloseWanServiceResponse>(req, "CloseWanService");
        }

        /// <summary>
        /// 本接口(CloseWanService)用于关闭云数据库实例的外网访问。关闭外网访问后，外网地址将不可访问。
        /// </summary>
        /// <param name="req"><see cref="CloseWanServiceRequest"/></param>
        /// <returns><see cref="CloseWanServiceResponse"/></returns>
        public CloseWanServiceResponse CloseWanServiceSync(CloseWanServiceRequest req)
        {
            return InternalRequestAsync<CloseWanServiceResponse>(req, "CloseWanService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateAccounts)用于创建云数据库的账户，需要指定新的账户名和域名，以及所对应的密码，同时可以设置账号的备注信息以及最大可用连接数。
        /// </summary>
        /// <param name="req"><see cref="CreateAccountsRequest"/></param>
        /// <returns><see cref="CreateAccountsResponse"/></returns>
        public Task<CreateAccountsResponse> CreateAccounts(CreateAccountsRequest req)
        {
            return InternalRequestAsync<CreateAccountsResponse>(req, "CreateAccounts");
        }

        /// <summary>
        /// 本接口(CreateAccounts)用于创建云数据库的账户，需要指定新的账户名和域名，以及所对应的密码，同时可以设置账号的备注信息以及最大可用连接数。
        /// </summary>
        /// <param name="req"><see cref="CreateAccountsRequest"/></param>
        /// <returns><see cref="CreateAccountsResponse"/></returns>
        public CreateAccountsResponse CreateAccountsSync(CreateAccountsRequest req)
        {
            return InternalRequestAsync<CreateAccountsResponse>(req, "CreateAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateAuditLogFile)用于创建云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public Task<CreateAuditLogFileResponse> CreateAuditLogFile(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile");
        }

        /// <summary>
        /// 本接口(CreateAuditLogFile)用于创建云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public CreateAuditLogFileResponse CreateAuditLogFileSync(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateAuditPolicy)用于创建云数据库实例的审计策略，即将审计规则绑定到具体的云数据库实例上。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditPolicyRequest"/></param>
        /// <returns><see cref="CreateAuditPolicyResponse"/></returns>
        public Task<CreateAuditPolicyResponse> CreateAuditPolicy(CreateAuditPolicyRequest req)
        {
            return InternalRequestAsync<CreateAuditPolicyResponse>(req, "CreateAuditPolicy");
        }

        /// <summary>
        /// 本接口(CreateAuditPolicy)用于创建云数据库实例的审计策略，即将审计规则绑定到具体的云数据库实例上。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditPolicyRequest"/></param>
        /// <returns><see cref="CreateAuditPolicyResponse"/></returns>
        public CreateAuditPolicyResponse CreateAuditPolicySync(CreateAuditPolicyRequest req)
        {
            return InternalRequestAsync<CreateAuditPolicyResponse>(req, "CreateAuditPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateAuditRule)用于创建用户在当前地域的审计规则。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRuleRequest"/></param>
        /// <returns><see cref="CreateAuditRuleResponse"/></returns>
        public Task<CreateAuditRuleResponse> CreateAuditRule(CreateAuditRuleRequest req)
        {
            return InternalRequestAsync<CreateAuditRuleResponse>(req, "CreateAuditRule");
        }

        /// <summary>
        /// 本接口(CreateAuditRule)用于创建用户在当前地域的审计规则。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRuleRequest"/></param>
        /// <returns><see cref="CreateAuditRuleResponse"/></returns>
        public CreateAuditRuleResponse CreateAuditRuleSync(CreateAuditRuleRequest req)
        {
            return InternalRequestAsync<CreateAuditRuleResponse>(req, "CreateAuditRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建审计规则模板
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateAuditRuleTemplateResponse"/></returns>
        public Task<CreateAuditRuleTemplateResponse> CreateAuditRuleTemplate(CreateAuditRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateAuditRuleTemplateResponse>(req, "CreateAuditRuleTemplate");
        }

        /// <summary>
        /// 创建审计规则模板
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateAuditRuleTemplateResponse"/></returns>
        public CreateAuditRuleTemplateResponse CreateAuditRuleTemplateSync(CreateAuditRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateAuditRuleTemplateResponse>(req, "CreateAuditRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateBackup)用于创建数据库备份。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup");
        }

        /// <summary>
        /// 本接口(CreateBackup)用于创建数据库备份。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 主实例创建数据库代理
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyRequest"/></param>
        /// <returns><see cref="CreateCdbProxyResponse"/></returns>
        public Task<CreateCdbProxyResponse> CreateCdbProxy(CreateCdbProxyRequest req)
        {
            return InternalRequestAsync<CreateCdbProxyResponse>(req, "CreateCdbProxy");
        }

        /// <summary>
        /// 主实例创建数据库代理
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyRequest"/></param>
        /// <returns><see cref="CreateCdbProxyResponse"/></returns>
        public CreateCdbProxyResponse CreateCdbProxySync(CreateCdbProxyRequest req)
        {
            return InternalRequestAsync<CreateCdbProxyResponse>(req, "CreateCdbProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据库代理增加代理地址
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CreateCdbProxyAddressResponse"/></returns>
        public Task<CreateCdbProxyAddressResponse> CreateCdbProxyAddress(CreateCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<CreateCdbProxyAddressResponse>(req, "CreateCdbProxyAddress");
        }

        /// <summary>
        /// 数据库代理增加代理地址
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CreateCdbProxyAddressResponse"/></returns>
        public CreateCdbProxyAddressResponse CreateCdbProxyAddressSync(CreateCdbProxyAddressRequest req)
        {
            return InternalRequestAsync<CreateCdbProxyAddressResponse>(req, "CreateCdbProxyAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateCloneInstance) 用于从目标源实例创建一个克隆实例，可以指定克隆实例回档到源实例的指定物理备份文件或者指定的回档时间点。
        /// </summary>
        /// <param name="req"><see cref="CreateCloneInstanceRequest"/></param>
        /// <returns><see cref="CreateCloneInstanceResponse"/></returns>
        public Task<CreateCloneInstanceResponse> CreateCloneInstance(CreateCloneInstanceRequest req)
        {
            return InternalRequestAsync<CreateCloneInstanceResponse>(req, "CreateCloneInstance");
        }

        /// <summary>
        /// 本接口(CreateCloneInstance) 用于从目标源实例创建一个克隆实例，可以指定克隆实例回档到源实例的指定物理备份文件或者指定的回档时间点。
        /// </summary>
        /// <param name="req"><see cref="CreateCloneInstanceRequest"/></param>
        /// <returns><see cref="CreateCloneInstanceResponse"/></returns>
        public CreateCloneInstanceResponse CreateCloneInstanceSync(CreateCloneInstanceRequest req)
        {
            return InternalRequestAsync<CreateCloneInstanceResponse>(req, "CreateCloneInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateDBImportJob)用于创建云数据库数据导入任务。
        /// 
        /// 注意，用户进行数据导入任务的文件，必须提前上传到腾讯云。用户须在控制台进行文件导入。
        /// </summary>
        /// <param name="req"><see cref="CreateDBImportJobRequest"/></param>
        /// <returns><see cref="CreateDBImportJobResponse"/></returns>
        public Task<CreateDBImportJobResponse> CreateDBImportJob(CreateDBImportJobRequest req)
        {
            return InternalRequestAsync<CreateDBImportJobResponse>(req, "CreateDBImportJob");
        }

        /// <summary>
        /// 本接口(CreateDBImportJob)用于创建云数据库数据导入任务。
        /// 
        /// 注意，用户进行数据导入任务的文件，必须提前上传到腾讯云。用户须在控制台进行文件导入。
        /// </summary>
        /// <param name="req"><see cref="CreateDBImportJobRequest"/></param>
        /// <returns><see cref="CreateDBImportJobResponse"/></returns>
        public CreateDBImportJobResponse CreateDBImportJobSync(CreateDBImportJobRequest req)
        {
            return InternalRequestAsync<CreateDBImportJobResponse>(req, "CreateDBImportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateDBInstance)用于创建包年包月的云数据库实例（包括主实例、灾备实例和只读实例），可通过传入实例规格、MySQL 版本号、购买时长和数量等信息创建云数据库实例。
        /// 
        /// 该接口为异步接口，您还可以使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询该实例的详细信息。当该实例的 Status 为1，且 TaskStatus 为0，表示实例已经发货成功。
        /// 
        /// 1. 首先请使用 [获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229) 接口查询可创建的实例规格信息，然后请使用 [查询数据库价格](https://cloud.tencent.com/document/api/236/18566) 接口查询可创建实例的售卖价格；
        /// 2. 单次创建实例最大支持 100 个，实例时长最大支持 36 个月；
        /// 3. 支持创建 MySQL 5.5 、 MySQL 5.6 、 MySQL 5.7 、 MySQL 8.0 版本；
        /// 4. 支持创建主实例、只读实例、灾备实例；
        /// 5. 当入参指定 Port 和 ParamTemplateType 参数模板，相关参数才会自动初始化（不支持基础版实例）；
        /// 6. 当入参指定 ParamTemplateId 或 AlarmPolicyList 时，需将SDK提升至最新版本方可支持；
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public Task<CreateDBInstanceResponse> CreateDBInstance(CreateDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceResponse>(req, "CreateDBInstance");
        }

        /// <summary>
        /// 本接口(CreateDBInstance)用于创建包年包月的云数据库实例（包括主实例、灾备实例和只读实例），可通过传入实例规格、MySQL 版本号、购买时长和数量等信息创建云数据库实例。
        /// 
        /// 该接口为异步接口，您还可以使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询该实例的详细信息。当该实例的 Status 为1，且 TaskStatus 为0，表示实例已经发货成功。
        /// 
        /// 1. 首先请使用 [获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229) 接口查询可创建的实例规格信息，然后请使用 [查询数据库价格](https://cloud.tencent.com/document/api/236/18566) 接口查询可创建实例的售卖价格；
        /// 2. 单次创建实例最大支持 100 个，实例时长最大支持 36 个月；
        /// 3. 支持创建 MySQL 5.5 、 MySQL 5.6 、 MySQL 5.7 、 MySQL 8.0 版本；
        /// 4. 支持创建主实例、只读实例、灾备实例；
        /// 5. 当入参指定 Port 和 ParamTemplateType 参数模板，相关参数才会自动初始化（不支持基础版实例）；
        /// 6. 当入参指定 ParamTemplateId 或 AlarmPolicyList 时，需将SDK提升至最新版本方可支持；
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public CreateDBInstanceResponse CreateDBInstanceSync(CreateDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceResponse>(req, "CreateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateDBInstanceHour)用于创建按量计费的实例，可通过传入实例规格、MySQL 版本号和数量等信息创建云数据库实例，支持主实例、灾备实例和只读实例的创建。
        /// 
        /// 该接口为异步接口，您还可以使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询该实例的详细信息。当该实例的 Status 为 1，且 TaskStatus 为 0，表示实例已经发货成功。
        /// 
        /// 1. 首先请使用 [获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229) 接口查询可创建的实例规格信息，然后请使用 [查询数据库价格](https://cloud.tencent.com/document/api/236/18566) 接口查询可创建实例的售卖价格；
        /// 2. 单次创建实例最大支持 100 个，实例时长最大支持 36 个月；
        /// 3. 支持创建 MySQL 5.5、MySQL 5.6 、MySQL 5.7 和 MySQL 8.0 版本；
        /// 4. 支持创建主实例、灾备实例和只读实例；
        /// 5. 当入参指定 Port，ParamTemplateType 或 Password 时，该实例会进行初始化操作；
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public Task<CreateDBInstanceHourResponse> CreateDBInstanceHour(CreateDBInstanceHourRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceHourResponse>(req, "CreateDBInstanceHour");
        }

        /// <summary>
        /// 本接口(CreateDBInstanceHour)用于创建按量计费的实例，可通过传入实例规格、MySQL 版本号和数量等信息创建云数据库实例，支持主实例、灾备实例和只读实例的创建。
        /// 
        /// 该接口为异步接口，您还可以使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询该实例的详细信息。当该实例的 Status 为 1，且 TaskStatus 为 0，表示实例已经发货成功。
        /// 
        /// 1. 首先请使用 [获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229) 接口查询可创建的实例规格信息，然后请使用 [查询数据库价格](https://cloud.tencent.com/document/api/236/18566) 接口查询可创建实例的售卖价格；
        /// 2. 单次创建实例最大支持 100 个，实例时长最大支持 36 个月；
        /// 3. 支持创建 MySQL 5.5、MySQL 5.6 、MySQL 5.7 和 MySQL 8.0 版本；
        /// 4. 支持创建主实例、灾备实例和只读实例；
        /// 5. 当入参指定 Port，ParamTemplateType 或 Password 时，该实例会进行初始化操作；
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public CreateDBInstanceHourResponse CreateDBInstanceHourSync(CreateDBInstanceHourRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceHourResponse>(req, "CreateDBInstanceHour")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateDatabase)用于在云数据库实例中创建数据库。
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public Task<CreateDatabaseResponse> CreateDatabase(CreateDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDatabaseResponse>(req, "CreateDatabase");
        }

        /// <summary>
        /// 本接口(CreateDatabase)用于在云数据库实例中创建数据库。
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public CreateDatabaseResponse CreateDatabaseSync(CreateDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDatabaseResponse>(req, "CreateDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateDeployGroup)用于创建放置实例的置放群组
        /// </summary>
        /// <param name="req"><see cref="CreateDeployGroupRequest"/></param>
        /// <returns><see cref="CreateDeployGroupResponse"/></returns>
        public Task<CreateDeployGroupResponse> CreateDeployGroup(CreateDeployGroupRequest req)
        {
            return InternalRequestAsync<CreateDeployGroupResponse>(req, "CreateDeployGroup");
        }

        /// <summary>
        /// 本接口(CreateDeployGroup)用于创建放置实例的置放群组
        /// </summary>
        /// <param name="req"><see cref="CreateDeployGroupRequest"/></param>
        /// <returns><see cref="CreateDeployGroupResponse"/></returns>
        public CreateDeployGroupResponse CreateDeployGroupSync(CreateDeployGroupRequest req)
        {
            return InternalRequestAsync<CreateDeployGroupResponse>(req, "CreateDeployGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateParamTemplate）用于创建参数模板，全地域公共参数Region均为ap-guangzhou。
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public Task<CreateParamTemplateResponse> CreateParamTemplate(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate");
        }

        /// <summary>
        /// 该接口（CreateParamTemplate）用于创建参数模板，全地域公共参数Region均为ap-guangzhou。
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public CreateParamTemplateResponse CreateParamTemplateSync(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateRoInstanceIp)用于创建云数据库只读实例的独立VIP。
        /// </summary>
        /// <param name="req"><see cref="CreateRoInstanceIpRequest"/></param>
        /// <returns><see cref="CreateRoInstanceIpResponse"/></returns>
        public Task<CreateRoInstanceIpResponse> CreateRoInstanceIp(CreateRoInstanceIpRequest req)
        {
            return InternalRequestAsync<CreateRoInstanceIpResponse>(req, "CreateRoInstanceIp");
        }

        /// <summary>
        /// 本接口(CreateRoInstanceIp)用于创建云数据库只读实例的独立VIP。
        /// </summary>
        /// <param name="req"><see cref="CreateRoInstanceIpRequest"/></param>
        /// <returns><see cref="CreateRoInstanceIpResponse"/></returns>
        public CreateRoInstanceIpResponse CreateRoInstanceIpSync(CreateRoInstanceIpRequest req)
        {
            return InternalRequestAsync<CreateRoInstanceIpResponse>(req, "CreateRoInstanceIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteAccounts)用于删除云数据库的账户。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountsRequest"/></param>
        /// <returns><see cref="DeleteAccountsResponse"/></returns>
        public Task<DeleteAccountsResponse> DeleteAccounts(DeleteAccountsRequest req)
        {
            return InternalRequestAsync<DeleteAccountsResponse>(req, "DeleteAccounts");
        }

        /// <summary>
        /// 本接口(DeleteAccounts)用于删除云数据库的账户。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountsRequest"/></param>
        /// <returns><see cref="DeleteAccountsResponse"/></returns>
        public DeleteAccountsResponse DeleteAccountsSync(DeleteAccountsRequest req)
        {
            return InternalRequestAsync<DeleteAccountsResponse>(req, "DeleteAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteAuditLogFile)用于删除云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public Task<DeleteAuditLogFileResponse> DeleteAuditLogFile(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile");
        }

        /// <summary>
        /// 本接口(DeleteAuditLogFile)用于删除云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public DeleteAuditLogFileResponse DeleteAuditLogFileSync(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteAuditPolicy)用于删除用户的审计策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditPolicyRequest"/></param>
        /// <returns><see cref="DeleteAuditPolicyResponse"/></returns>
        public Task<DeleteAuditPolicyResponse> DeleteAuditPolicy(DeleteAuditPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAuditPolicyResponse>(req, "DeleteAuditPolicy");
        }

        /// <summary>
        /// 本接口(DeleteAuditPolicy)用于删除用户的审计策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditPolicyRequest"/></param>
        /// <returns><see cref="DeleteAuditPolicyResponse"/></returns>
        public DeleteAuditPolicyResponse DeleteAuditPolicySync(DeleteAuditPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAuditPolicyResponse>(req, "DeleteAuditPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteAuditRule)用于删除用户的审计规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRuleRequest"/></param>
        /// <returns><see cref="DeleteAuditRuleResponse"/></returns>
        public Task<DeleteAuditRuleResponse> DeleteAuditRule(DeleteAuditRuleRequest req)
        {
            return InternalRequestAsync<DeleteAuditRuleResponse>(req, "DeleteAuditRule");
        }

        /// <summary>
        /// 本接口(DeleteAuditRule)用于删除用户的审计规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRuleRequest"/></param>
        /// <returns><see cref="DeleteAuditRuleResponse"/></returns>
        public DeleteAuditRuleResponse DeleteAuditRuleSync(DeleteAuditRuleRequest req)
        {
            return InternalRequestAsync<DeleteAuditRuleResponse>(req, "DeleteAuditRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除审计规则模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DeleteAuditRuleTemplatesResponse"/></returns>
        public Task<DeleteAuditRuleTemplatesResponse> DeleteAuditRuleTemplates(DeleteAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteAuditRuleTemplatesResponse>(req, "DeleteAuditRuleTemplates");
        }

        /// <summary>
        /// 删除审计规则模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DeleteAuditRuleTemplatesResponse"/></returns>
        public DeleteAuditRuleTemplatesResponse DeleteAuditRuleTemplatesSync(DeleteAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteAuditRuleTemplatesResponse>(req, "DeleteAuditRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteBackup)用于删除数据库备份。本接口只支持删除手动发起的备份。
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRequest"/></param>
        /// <returns><see cref="DeleteBackupResponse"/></returns>
        public Task<DeleteBackupResponse> DeleteBackup(DeleteBackupRequest req)
        {
            return InternalRequestAsync<DeleteBackupResponse>(req, "DeleteBackup");
        }

        /// <summary>
        /// 本接口(DeleteBackup)用于删除数据库备份。本接口只支持删除手动发起的备份。
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRequest"/></param>
        /// <returns><see cref="DeleteBackupResponse"/></returns>
        public DeleteBackupResponse DeleteBackupSync(DeleteBackupRequest req)
        {
            return InternalRequestAsync<DeleteBackupResponse>(req, "DeleteBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteDatabase)用于在云数据库实例中删除数据库。
        /// </summary>
        /// <param name="req"><see cref="DeleteDatabaseRequest"/></param>
        /// <returns><see cref="DeleteDatabaseResponse"/></returns>
        public Task<DeleteDatabaseResponse> DeleteDatabase(DeleteDatabaseRequest req)
        {
            return InternalRequestAsync<DeleteDatabaseResponse>(req, "DeleteDatabase");
        }

        /// <summary>
        /// 本接口(DeleteDatabase)用于在云数据库实例中删除数据库。
        /// </summary>
        /// <param name="req"><see cref="DeleteDatabaseRequest"/></param>
        /// <returns><see cref="DeleteDatabaseResponse"/></returns>
        public DeleteDatabaseResponse DeleteDatabaseSync(DeleteDatabaseRequest req)
        {
            return InternalRequestAsync<DeleteDatabaseResponse>(req, "DeleteDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据置放群组ID删除置放群组（置放群组中有资源存在时不能删除该置放群组）
        /// </summary>
        /// <param name="req"><see cref="DeleteDeployGroupsRequest"/></param>
        /// <returns><see cref="DeleteDeployGroupsResponse"/></returns>
        public Task<DeleteDeployGroupsResponse> DeleteDeployGroups(DeleteDeployGroupsRequest req)
        {
            return InternalRequestAsync<DeleteDeployGroupsResponse>(req, "DeleteDeployGroups");
        }

        /// <summary>
        /// 根据置放群组ID删除置放群组（置放群组中有资源存在时不能删除该置放群组）
        /// </summary>
        /// <param name="req"><see cref="DeleteDeployGroupsRequest"/></param>
        /// <returns><see cref="DeleteDeployGroupsResponse"/></returns>
        public DeleteDeployGroupsResponse DeleteDeployGroupsSync(DeleteDeployGroupsRequest req)
        {
            return InternalRequestAsync<DeleteDeployGroupsResponse>(req, "DeleteDeployGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DeleteParamTemplate）用于删除参数模板，全地域公共参数Region均为ap-guangzhou。
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public Task<DeleteParamTemplateResponse> DeleteParamTemplate(DeleteParamTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParamTemplateResponse>(req, "DeleteParamTemplate");
        }

        /// <summary>
        /// 该接口（DeleteParamTemplate）用于删除参数模板，全地域公共参数Region均为ap-guangzhou。
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public DeleteParamTemplateResponse DeleteParamTemplateSync(DeleteParamTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParamTemplateResponse>(req, "DeleteParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteTimeWindow)用于删除云数据库实例的维护时间窗口。删除实例维护时间窗口之后，默认的维护时间窗为 03:00-04:00，即当选择在维护时间窗口内切换访问新实例时，默认会在 03:00-04:00 点进行切换访问新实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteTimeWindowRequest"/></param>
        /// <returns><see cref="DeleteTimeWindowResponse"/></returns>
        public Task<DeleteTimeWindowResponse> DeleteTimeWindow(DeleteTimeWindowRequest req)
        {
            return InternalRequestAsync<DeleteTimeWindowResponse>(req, "DeleteTimeWindow");
        }

        /// <summary>
        /// 本接口(DeleteTimeWindow)用于删除云数据库实例的维护时间窗口。删除实例维护时间窗口之后，默认的维护时间窗为 03:00-04:00，即当选择在维护时间窗口内切换访问新实例时，默认会在 03:00-04:00 点进行切换访问新实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteTimeWindowRequest"/></param>
        /// <returns><see cref="DeleteTimeWindowResponse"/></returns>
        public DeleteTimeWindowResponse DeleteTimeWindowSync(DeleteTimeWindowRequest req)
        {
            return InternalRequestAsync<DeleteTimeWindowResponse>(req, "DeleteTimeWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAccountPrivileges)用于查询云数据库账户支持的权限信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges");
        }

        /// <summary>
        /// 本接口(DescribeAccountPrivileges)用于查询云数据库账户支持的权限信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public DescribeAccountPrivilegesResponse DescribeAccountPrivilegesSync(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAccounts)用于查询云数据库的所有账户信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// 本接口(DescribeAccounts)用于查询云数据库的所有账户信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAsyncRequestInfo)用于查询云数据库实例异步任务的执行结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo");
        }

        /// <summary>
        /// 本接口(DescribeAsyncRequestInfo)用于查询云数据库实例异步任务的执行结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAuditConfig)用于查询云数据库审计策略的服务配置，包括审计日志保存时长等。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditConfigRequest"/></param>
        /// <returns><see cref="DescribeAuditConfigResponse"/></returns>
        public Task<DescribeAuditConfigResponse> DescribeAuditConfig(DescribeAuditConfigRequest req)
        {
            return InternalRequestAsync<DescribeAuditConfigResponse>(req, "DescribeAuditConfig");
        }

        /// <summary>
        /// 本接口(DescribeAuditConfig)用于查询云数据库审计策略的服务配置，包括审计日志保存时长等。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditConfigRequest"/></param>
        /// <returns><see cref="DescribeAuditConfigResponse"/></returns>
        public DescribeAuditConfigResponse DescribeAuditConfigSync(DescribeAuditConfigRequest req)
        {
            return InternalRequestAsync<DescribeAuditConfigResponse>(req, "DescribeAuditConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取审计实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public Task<DescribeAuditInstanceListResponse> DescribeAuditInstanceList(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList");
        }

        /// <summary>
        /// 获取审计实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public DescribeAuditInstanceListResponse DescribeAuditInstanceListSync(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAuditLogFiles)用于查询云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogFilesRequest"/></param>
        /// <returns><see cref="DescribeAuditLogFilesResponse"/></returns>
        public Task<DescribeAuditLogFilesResponse> DescribeAuditLogFiles(DescribeAuditLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogFilesResponse>(req, "DescribeAuditLogFiles");
        }

        /// <summary>
        /// 本接口(DescribeAuditLogFiles)用于查询云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogFilesRequest"/></param>
        /// <returns><see cref="DescribeAuditLogFilesResponse"/></returns>
        public DescribeAuditLogFilesResponse DescribeAuditLogFilesSync(DescribeAuditLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogFilesResponse>(req, "DescribeAuditLogFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAuditLogs)用于查询数据库审计日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogsRequest"/></param>
        /// <returns><see cref="DescribeAuditLogsResponse"/></returns>
        public Task<DescribeAuditLogsResponse> DescribeAuditLogs(DescribeAuditLogsRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogsResponse>(req, "DescribeAuditLogs");
        }

        /// <summary>
        /// 本接口(DescribeAuditLogs)用于查询数据库审计日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogsRequest"/></param>
        /// <returns><see cref="DescribeAuditLogsResponse"/></returns>
        public DescribeAuditLogsResponse DescribeAuditLogsSync(DescribeAuditLogsRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogsResponse>(req, "DescribeAuditLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAuditPolicies)用于查询云数据库实例的审计策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAuditPoliciesResponse"/></returns>
        public Task<DescribeAuditPoliciesResponse> DescribeAuditPolicies(DescribeAuditPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAuditPoliciesResponse>(req, "DescribeAuditPolicies");
        }

        /// <summary>
        /// 本接口(DescribeAuditPolicies)用于查询云数据库实例的审计策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAuditPoliciesResponse"/></returns>
        public DescribeAuditPoliciesResponse DescribeAuditPoliciesSync(DescribeAuditPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAuditPoliciesResponse>(req, "DescribeAuditPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则模板变更记录
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplateModifyHistoryRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplateModifyHistoryResponse"/></returns>
        public Task<DescribeAuditRuleTemplateModifyHistoryResponse> DescribeAuditRuleTemplateModifyHistory(DescribeAuditRuleTemplateModifyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplateModifyHistoryResponse>(req, "DescribeAuditRuleTemplateModifyHistory");
        }

        /// <summary>
        /// 查询规则模板变更记录
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplateModifyHistoryRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplateModifyHistoryResponse"/></returns>
        public DescribeAuditRuleTemplateModifyHistoryResponse DescribeAuditRuleTemplateModifyHistorySync(DescribeAuditRuleTemplateModifyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplateModifyHistoryResponse>(req, "DescribeAuditRuleTemplateModifyHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询审计规则模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplatesResponse"/></returns>
        public Task<DescribeAuditRuleTemplatesResponse> DescribeAuditRuleTemplates(DescribeAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplatesResponse>(req, "DescribeAuditRuleTemplates");
        }

        /// <summary>
        /// 查询审计规则模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAuditRuleTemplatesResponse"/></returns>
        public DescribeAuditRuleTemplatesResponse DescribeAuditRuleTemplatesSync(DescribeAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRuleTemplatesResponse>(req, "DescribeAuditRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAuditRules)用于查询用户在当前地域的审计规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRulesRequest"/></param>
        /// <returns><see cref="DescribeAuditRulesResponse"/></returns>
        public Task<DescribeAuditRulesResponse> DescribeAuditRules(DescribeAuditRulesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRulesResponse>(req, "DescribeAuditRules");
        }

        /// <summary>
        /// 本接口(DescribeAuditRules)用于查询用户在当前地域的审计规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRulesRequest"/></param>
        /// <returns><see cref="DescribeAuditRulesResponse"/></returns>
        public DescribeAuditRulesResponse DescribeAuditRulesSync(DescribeAuditRulesRequest req)
        {
            return InternalRequestAsync<DescribeAuditRulesResponse>(req, "DescribeAuditRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupConfig)用于查询数据库备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public Task<DescribeBackupConfigResponse> DescribeBackupConfig(DescribeBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeBackupConfigResponse>(req, "DescribeBackupConfig");
        }

        /// <summary>
        /// 本接口(DescribeBackupConfig)用于查询数据库备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public DescribeBackupConfigResponse DescribeBackupConfigSync(DescribeBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeBackupConfigResponse>(req, "DescribeBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupDecryptionKey)用于查询备份文件解密密钥。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDecryptionKeyRequest"/></param>
        /// <returns><see cref="DescribeBackupDecryptionKeyResponse"/></returns>
        public Task<DescribeBackupDecryptionKeyResponse> DescribeBackupDecryptionKey(DescribeBackupDecryptionKeyRequest req)
        {
            return InternalRequestAsync<DescribeBackupDecryptionKeyResponse>(req, "DescribeBackupDecryptionKey");
        }

        /// <summary>
        /// 本接口(DescribeBackupDecryptionKey)用于查询备份文件解密密钥。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDecryptionKeyRequest"/></param>
        /// <returns><see cref="DescribeBackupDecryptionKeyResponse"/></returns>
        public DescribeBackupDecryptionKeyResponse DescribeBackupDecryptionKeySync(DescribeBackupDecryptionKeyRequest req)
        {
            return InternalRequestAsync<DescribeBackupDecryptionKeyResponse>(req, "DescribeBackupDecryptionKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用户查询当前地域用户设置的默认备份下载来源限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public Task<DescribeBackupDownloadRestrictionResponse> DescribeBackupDownloadRestriction(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction");
        }

        /// <summary>
        /// 该接口用户查询当前地域用户设置的默认备份下载来源限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public DescribeBackupDownloadRestrictionResponse DescribeBackupDownloadRestrictionSync(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupEncryptionStatus)用于查询实例默认备份加密状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeBackupEncryptionStatusResponse"/></returns>
        public Task<DescribeBackupEncryptionStatusResponse> DescribeBackupEncryptionStatus(DescribeBackupEncryptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeBackupEncryptionStatusResponse>(req, "DescribeBackupEncryptionStatus");
        }

        /// <summary>
        /// 本接口(DescribeBackupEncryptionStatus)用于查询实例默认备份加密状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeBackupEncryptionStatusResponse"/></returns>
        public DescribeBackupEncryptionStatusResponse DescribeBackupEncryptionStatusSync(DescribeBackupEncryptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeBackupEncryptionStatusResponse>(req, "DescribeBackupEncryptionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupOverview)用于查询用户的备份概览。返回用户当前备份总个数、备份总的占用容量、赠送的免费容量、计费容量（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public Task<DescribeBackupOverviewResponse> DescribeBackupOverview(DescribeBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBackupOverviewResponse>(req, "DescribeBackupOverview");
        }

        /// <summary>
        /// 本接口(DescribeBackupOverview)用于查询用户的备份概览。返回用户当前备份总个数、备份总的占用容量、赠送的免费容量、计费容量（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public DescribeBackupOverviewResponse DescribeBackupOverviewSync(DescribeBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBackupOverviewResponse>(req, "DescribeBackupOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupSummaries)用于查询备份的统计情况，返回以实例为维度的备份占用容量，以及每个实例的数据备份和日志备份的个数和容量（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public Task<DescribeBackupSummariesResponse> DescribeBackupSummaries(DescribeBackupSummariesRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummariesResponse>(req, "DescribeBackupSummaries");
        }

        /// <summary>
        /// 本接口(DescribeBackupSummaries)用于查询备份的统计情况，返回以实例为维度的备份占用容量，以及每个实例的数据备份和日志备份的个数和容量（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public DescribeBackupSummariesResponse DescribeBackupSummariesSync(DescribeBackupSummariesRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummariesResponse>(req, "DescribeBackupSummaries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackups)用于查询云数据库实例的备份数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public Task<DescribeBackupsResponse> DescribeBackups(DescribeBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBackupsResponse>(req, "DescribeBackups");
        }

        /// <summary>
        /// 本接口(DescribeBackups)用于查询云数据库实例的备份数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public DescribeBackupsResponse DescribeBackupsSync(DescribeBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBackupsResponse>(req, "DescribeBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBinlogBackupOverview)用于查询用户在当前地域总的日志备份概览。
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBinlogBackupOverviewResponse"/></returns>
        public Task<DescribeBinlogBackupOverviewResponse> DescribeBinlogBackupOverview(DescribeBinlogBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBinlogBackupOverviewResponse>(req, "DescribeBinlogBackupOverview");
        }

        /// <summary>
        /// 本接口(DescribeBinlogBackupOverview)用于查询用户在当前地域总的日志备份概览。
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBinlogBackupOverviewResponse"/></returns>
        public DescribeBinlogBackupOverviewResponse DescribeBinlogBackupOverviewSync(DescribeBinlogBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBinlogBackupOverviewResponse>(req, "DescribeBinlogBackupOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBinlogs)用于查询云数据库实例的 binlog 文件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogsRequest"/></param>
        /// <returns><see cref="DescribeBinlogsResponse"/></returns>
        public Task<DescribeBinlogsResponse> DescribeBinlogs(DescribeBinlogsRequest req)
        {
            return InternalRequestAsync<DescribeBinlogsResponse>(req, "DescribeBinlogs");
        }

        /// <summary>
        /// 本接口(DescribeBinlogs)用于查询云数据库实例的 binlog 文件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogsRequest"/></param>
        /// <returns><see cref="DescribeBinlogsResponse"/></returns>
        public DescribeBinlogsResponse DescribeBinlogsSync(DescribeBinlogsRequest req)
        {
            return InternalRequestAsync<DescribeBinlogsResponse>(req, "DescribeBinlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据库代理详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbProxyInfoRequest"/></param>
        /// <returns><see cref="DescribeCdbProxyInfoResponse"/></returns>
        public Task<DescribeCdbProxyInfoResponse> DescribeCdbProxyInfo(DescribeCdbProxyInfoRequest req)
        {
            return InternalRequestAsync<DescribeCdbProxyInfoResponse>(req, "DescribeCdbProxyInfo");
        }

        /// <summary>
        /// 查询数据库代理详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbProxyInfoRequest"/></param>
        /// <returns><see cref="DescribeCdbProxyInfoResponse"/></returns>
        public DescribeCdbProxyInfoResponse DescribeCdbProxyInfoSync(DescribeCdbProxyInfoRequest req)
        {
            return InternalRequestAsync<DescribeCdbProxyInfoResponse>(req, "DescribeCdbProxyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeCdbZoneConfig)用于查询云数据库各地域可售卖的规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbZoneConfigRequest"/></param>
        /// <returns><see cref="DescribeCdbZoneConfigResponse"/></returns>
        public Task<DescribeCdbZoneConfigResponse> DescribeCdbZoneConfig(DescribeCdbZoneConfigRequest req)
        {
            return InternalRequestAsync<DescribeCdbZoneConfigResponse>(req, "DescribeCdbZoneConfig");
        }

        /// <summary>
        /// 本接口(DescribeCdbZoneConfig)用于查询云数据库各地域可售卖的规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbZoneConfigRequest"/></param>
        /// <returns><see cref="DescribeCdbZoneConfigResponse"/></returns>
        public DescribeCdbZoneConfigResponse DescribeCdbZoneConfigSync(DescribeCdbZoneConfigRequest req)
        {
            return InternalRequestAsync<DescribeCdbZoneConfigResponse>(req, "DescribeCdbZoneConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeCloneList) 用于查询用户实例的克隆任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneListRequest"/></param>
        /// <returns><see cref="DescribeCloneListResponse"/></returns>
        public Task<DescribeCloneListResponse> DescribeCloneList(DescribeCloneListRequest req)
        {
            return InternalRequestAsync<DescribeCloneListResponse>(req, "DescribeCloneList");
        }

        /// <summary>
        /// 本接口(DescribeCloneList) 用于查询用户实例的克隆任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneListRequest"/></param>
        /// <returns><see cref="DescribeCloneListResponse"/></returns>
        public DescribeCloneListResponse DescribeCloneListSync(DescribeCloneListRequest req)
        {
            return InternalRequestAsync<DescribeCloneListResponse>(req, "DescribeCloneList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeClusterInfo)用于查询集群版实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInfoRequest"/></param>
        /// <returns><see cref="DescribeClusterInfoResponse"/></returns>
        public Task<DescribeClusterInfoResponse> DescribeClusterInfo(DescribeClusterInfoRequest req)
        {
            return InternalRequestAsync<DescribeClusterInfoResponse>(req, "DescribeClusterInfo");
        }

        /// <summary>
        /// 本接口(DescribeClusterInfo)用于查询集群版实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInfoRequest"/></param>
        /// <returns><see cref="DescribeClusterInfoResponse"/></returns>
        public DescribeClusterInfoResponse DescribeClusterInfoSync(DescribeClusterInfoRequest req)
        {
            return InternalRequestAsync<DescribeClusterInfoResponse>(req, "DescribeClusterInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过该 API 可以查询实例的 CPU 弹性扩容策略
        /// </summary>
        /// <param name="req"><see cref="DescribeCpuExpandStrategyRequest"/></param>
        /// <returns><see cref="DescribeCpuExpandStrategyResponse"/></returns>
        public Task<DescribeCpuExpandStrategyResponse> DescribeCpuExpandStrategy(DescribeCpuExpandStrategyRequest req)
        {
            return InternalRequestAsync<DescribeCpuExpandStrategyResponse>(req, "DescribeCpuExpandStrategy");
        }

        /// <summary>
        /// 通过该 API 可以查询实例的 CPU 弹性扩容策略
        /// </summary>
        /// <param name="req"><see cref="DescribeCpuExpandStrategyRequest"/></param>
        /// <returns><see cref="DescribeCpuExpandStrategyResponse"/></returns>
        public DescribeCpuExpandStrategyResponse DescribeCpuExpandStrategySync(DescribeCpuExpandStrategyRequest req)
        {
            return InternalRequestAsync<DescribeCpuExpandStrategyResponse>(req, "DescribeCpuExpandStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBFeatures)用于查询云数据库版本属性，包括是否支持数据库加密、数据库审计等功能。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBFeaturesRequest"/></param>
        /// <returns><see cref="DescribeDBFeaturesResponse"/></returns>
        public Task<DescribeDBFeaturesResponse> DescribeDBFeatures(DescribeDBFeaturesRequest req)
        {
            return InternalRequestAsync<DescribeDBFeaturesResponse>(req, "DescribeDBFeatures");
        }

        /// <summary>
        /// 本接口(DescribeDBFeatures)用于查询云数据库版本属性，包括是否支持数据库加密、数据库审计等功能。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBFeaturesRequest"/></param>
        /// <returns><see cref="DescribeDBFeaturesResponse"/></returns>
        public DescribeDBFeaturesResponse DescribeDBFeaturesSync(DescribeDBFeaturesRequest req)
        {
            return InternalRequestAsync<DescribeDBFeaturesResponse>(req, "DescribeDBFeatures")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBImportRecords)用于查询云数据库导入任务操作日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBImportRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBImportRecordsResponse"/></returns>
        public Task<DescribeDBImportRecordsResponse> DescribeDBImportRecords(DescribeDBImportRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDBImportRecordsResponse>(req, "DescribeDBImportRecords");
        }

        /// <summary>
        /// 本接口(DescribeDBImportRecords)用于查询云数据库导入任务操作日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBImportRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBImportRecordsResponse"/></returns>
        public DescribeDBImportRecordsResponse DescribeDBImportRecordsSync(DescribeDBImportRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDBImportRecordsResponse>(req, "DescribeDBImportRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceCharset)用于查询云数据库实例的字符集，获取字符集的名称。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceCharsetRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceCharsetResponse"/></returns>
        public Task<DescribeDBInstanceCharsetResponse> DescribeDBInstanceCharset(DescribeDBInstanceCharsetRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceCharsetResponse>(req, "DescribeDBInstanceCharset");
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceCharset)用于查询云数据库实例的字符集，获取字符集的名称。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceCharsetRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceCharsetResponse"/></returns>
        public DescribeDBInstanceCharsetResponse DescribeDBInstanceCharsetSync(DescribeDBInstanceCharsetRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceCharsetResponse>(req, "DescribeDBInstanceCharset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceConfig)用于云数据库实例的配置信息，包括同步模式，部署模式等。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceConfigResponse"/></returns>
        public Task<DescribeDBInstanceConfigResponse> DescribeDBInstanceConfig(DescribeDBInstanceConfigRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceConfigResponse>(req, "DescribeDBInstanceConfig");
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceConfig)用于云数据库实例的配置信息，包括同步模式，部署模式等。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceConfigResponse"/></returns>
        public DescribeDBInstanceConfigResponse DescribeDBInstanceConfigSync(DescribeDBInstanceConfigRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceConfigResponse>(req, "DescribeDBInstanceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceGTID)用于查询云数据库实例是否开通了 GTID，不支持版本为 5.5 以及以下的实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceGTIDResponse"/></returns>
        public Task<DescribeDBInstanceGTIDResponse> DescribeDBInstanceGTID(DescribeDBInstanceGTIDRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceGTIDResponse>(req, "DescribeDBInstanceGTID");
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceGTID)用于查询云数据库实例是否开通了 GTID，不支持版本为 5.5 以及以下的实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceGTIDResponse"/></returns>
        public DescribeDBInstanceGTIDResponse DescribeDBInstanceGTIDSync(DescribeDBInstanceGTIDRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceGTIDResponse>(req, "DescribeDBInstanceGTID")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例基本信息（实例 ID ，实例名称，是否开通加密 ）
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceInfoResponse"/></returns>
        public Task<DescribeDBInstanceInfoResponse> DescribeDBInstanceInfo(DescribeDBInstanceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceInfoResponse>(req, "DescribeDBInstanceInfo");
        }

        /// <summary>
        /// 查询实例基本信息（实例 ID ，实例名称，是否开通加密 ）
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceInfoResponse"/></returns>
        public DescribeDBInstanceInfoResponse DescribeDBInstanceInfoSync(DescribeDBInstanceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceInfoResponse>(req, "DescribeDBInstanceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceLogToCLS)用于查询实例慢日志、错误日志投递CLS的配置，通过AppId、Region以及实例ID过滤出当前实例日志投递CLS的配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceLogToCLSRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceLogToCLSResponse"/></returns>
        public Task<DescribeDBInstanceLogToCLSResponse> DescribeDBInstanceLogToCLS(DescribeDBInstanceLogToCLSRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceLogToCLSResponse>(req, "DescribeDBInstanceLogToCLS");
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceLogToCLS)用于查询实例慢日志、错误日志投递CLS的配置，通过AppId、Region以及实例ID过滤出当前实例日志投递CLS的配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceLogToCLSRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceLogToCLSResponse"/></returns>
        public DescribeDBInstanceLogToCLSResponse DescribeDBInstanceLogToCLSSync(DescribeDBInstanceLogToCLSRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceLogToCLSResponse>(req, "DescribeDBInstanceLogToCLS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceRebootTime)用于查询云数据库实例重启预计所需的时间。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceRebootTimeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceRebootTimeResponse"/></returns>
        public Task<DescribeDBInstanceRebootTimeResponse> DescribeDBInstanceRebootTime(DescribeDBInstanceRebootTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceRebootTimeResponse>(req, "DescribeDBInstanceRebootTime");
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceRebootTime)用于查询云数据库实例重启预计所需的时间。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceRebootTimeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceRebootTimeResponse"/></returns>
        public DescribeDBInstanceRebootTimeResponse DescribeDBInstanceRebootTimeSync(DescribeDBInstanceRebootTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceRebootTimeResponse>(req, "DescribeDBInstanceRebootTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBInstances)用于查询云数据库实例列表，支持通过项目 ID、实例 ID、访问地址、实例状态等过滤条件来筛选实例。支持查询主实例、灾备实例和只读实例信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// 本接口(DescribeDBInstances)用于查询云数据库实例列表，支持通过项目 ID、实例 ID、访问地址、实例状态等过滤条件来筛选实例。支持查询主实例、灾备实例和只读实例信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBPrice)用于查询购买或续费云数据库实例的价格，支持查询按量计费或者包年包月的价格。可传入实例类型、购买时长、购买数量、内存大小、硬盘大小和可用区信息等来查询实例价格。可传入实例名称来查询实例续费价格。
        /// 
        /// 注意：对某个地域进行询价，请使用对应地域的接入点，接入点信息请参照 <a href="https://cloud.tencent.com/document/api/236/15832">服务地址</a> 文档。例如：对广州地域进行询价，请把请求发到：cdb.ap-guangzhou.tencentcloudapi.com。同理对上海地域询价，把请求发到：cdb.ap-shanghai.tencentcloudapi.com。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDBPriceResponse"/></returns>
        public Task<DescribeDBPriceResponse> DescribeDBPrice(DescribeDBPriceRequest req)
        {
            return InternalRequestAsync<DescribeDBPriceResponse>(req, "DescribeDBPrice");
        }

        /// <summary>
        /// 本接口(DescribeDBPrice)用于查询购买或续费云数据库实例的价格，支持查询按量计费或者包年包月的价格。可传入实例类型、购买时长、购买数量、内存大小、硬盘大小和可用区信息等来查询实例价格。可传入实例名称来查询实例续费价格。
        /// 
        /// 注意：对某个地域进行询价，请使用对应地域的接入点，接入点信息请参照 <a href="https://cloud.tencent.com/document/api/236/15832">服务地址</a> 文档。例如：对广州地域进行询价，请把请求发到：cdb.ap-guangzhou.tencentcloudapi.com。同理对上海地域询价，把请求发到：cdb.ap-shanghai.tencentcloudapi.com。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDBPriceResponse"/></returns>
        public DescribeDBPriceResponse DescribeDBPriceSync(DescribeDBPriceRequest req)
        {
            return InternalRequestAsync<DescribeDBPriceResponse>(req, "DescribeDBPrice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// 本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBSwitchRecords)用于查询云数据库实例切换记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSwitchRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBSwitchRecordsResponse"/></returns>
        public Task<DescribeDBSwitchRecordsResponse> DescribeDBSwitchRecords(DescribeDBSwitchRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDBSwitchRecordsResponse>(req, "DescribeDBSwitchRecords");
        }

        /// <summary>
        /// 本接口(DescribeDBSwitchRecords)用于查询云数据库实例切换记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSwitchRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBSwitchRecordsResponse"/></returns>
        public DescribeDBSwitchRecordsResponse DescribeDBSwitchRecordsSync(DescribeDBSwitchRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDBSwitchRecordsResponse>(req, "DescribeDBSwitchRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDataBackupOverview)用于查询用户在当前地域总的数据备份概览。
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeDataBackupOverviewResponse"/></returns>
        public Task<DescribeDataBackupOverviewResponse> DescribeDataBackupOverview(DescribeDataBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDataBackupOverviewResponse>(req, "DescribeDataBackupOverview");
        }

        /// <summary>
        /// 本接口(DescribeDataBackupOverview)用于查询用户在当前地域总的数据备份概览。
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeDataBackupOverviewResponse"/></returns>
        public DescribeDataBackupOverviewResponse DescribeDataBackupOverviewSync(DescribeDataBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDataBackupOverviewResponse>(req, "DescribeDataBackupOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDatabases)用于查询云数据库实例的数据库信息，仅支持主实例和灾备实例，不支持只读实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases");
        }

        /// <summary>
        /// 本接口(DescribeDatabases)用于查询云数据库实例的数据库信息，仅支持主实例和灾备实例，不支持只读实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeDefaultParams）用于查询默认的可设置参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParamsRequest"/></param>
        /// <returns><see cref="DescribeDefaultParamsResponse"/></returns>
        public Task<DescribeDefaultParamsResponse> DescribeDefaultParams(DescribeDefaultParamsRequest req)
        {
            return InternalRequestAsync<DescribeDefaultParamsResponse>(req, "DescribeDefaultParams");
        }

        /// <summary>
        /// 该接口（DescribeDefaultParams）用于查询默认的可设置参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParamsRequest"/></param>
        /// <returns><see cref="DescribeDefaultParamsResponse"/></returns>
        public DescribeDefaultParamsResponse DescribeDefaultParamsSync(DescribeDefaultParamsRequest req)
        {
            return InternalRequestAsync<DescribeDefaultParamsResponse>(req, "DescribeDefaultParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDeployGroupList)用于查询用户的置放群组列表，可以指定置放群组 ID 或置放群组名称。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployGroupListRequest"/></param>
        /// <returns><see cref="DescribeDeployGroupListResponse"/></returns>
        public Task<DescribeDeployGroupListResponse> DescribeDeployGroupList(DescribeDeployGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDeployGroupListResponse>(req, "DescribeDeployGroupList");
        }

        /// <summary>
        /// 本接口(DescribeDeployGroupList)用于查询用户的置放群组列表，可以指定置放群组 ID 或置放群组名称。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployGroupListRequest"/></param>
        /// <returns><see cref="DescribeDeployGroupListResponse"/></returns>
        public DescribeDeployGroupListResponse DescribeDeployGroupListSync(DescribeDeployGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDeployGroupListResponse>(req, "DescribeDeployGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDeviceMonitorInfo）用于查询云数据库物理机当天的监控信息，暂只支持内存488G、硬盘6T的实例查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceMonitorInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceMonitorInfoResponse"/></returns>
        public Task<DescribeDeviceMonitorInfoResponse> DescribeDeviceMonitorInfo(DescribeDeviceMonitorInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceMonitorInfoResponse>(req, "DescribeDeviceMonitorInfo");
        }

        /// <summary>
        /// 本接口（DescribeDeviceMonitorInfo）用于查询云数据库物理机当天的监控信息，暂只支持内存488G、硬盘6T的实例查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceMonitorInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceMonitorInfoResponse"/></returns>
        public DescribeDeviceMonitorInfoResponse DescribeDeviceMonitorInfoSync(DescribeDeviceMonitorInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceMonitorInfoResponse>(req, "DescribeDeviceMonitorInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据检索条件查询实例错误日志详情。只能查询一个月之内的错误日志。
        /// 使用时需要注意：可能存在单条错误日志太大，导致整个http请求的回包太大，进而引发接口超时。一旦发生超时，建议您缩小查询时的Limit参数值，从而降低包的大小，让接口能够及时返回内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorLogDataRequest"/></param>
        /// <returns><see cref="DescribeErrorLogDataResponse"/></returns>
        public Task<DescribeErrorLogDataResponse> DescribeErrorLogData(DescribeErrorLogDataRequest req)
        {
            return InternalRequestAsync<DescribeErrorLogDataResponse>(req, "DescribeErrorLogData");
        }

        /// <summary>
        /// 根据检索条件查询实例错误日志详情。只能查询一个月之内的错误日志。
        /// 使用时需要注意：可能存在单条错误日志太大，导致整个http请求的回包太大，进而引发接口超时。一旦发生超时，建议您缩小查询时的Limit参数值，从而降低包的大小，让接口能够及时返回内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorLogDataRequest"/></param>
        /// <returns><see cref="DescribeErrorLogDataResponse"/></returns>
        public DescribeErrorLogDataResponse DescribeErrorLogDataSync(DescribeErrorLogDataRequest req)
        {
            return InternalRequestAsync<DescribeErrorLogDataResponse>(req, "DescribeErrorLogData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例发生的事件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeInstanceAlarmEventsResponse"/></returns>
        public Task<DescribeInstanceAlarmEventsResponse> DescribeInstanceAlarmEvents(DescribeInstanceAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAlarmEventsResponse>(req, "DescribeInstanceAlarmEvents");
        }

        /// <summary>
        /// 查询实例发生的事件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeInstanceAlarmEventsResponse"/></returns>
        public DescribeInstanceAlarmEventsResponse DescribeInstanceAlarmEventsSync(DescribeInstanceAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAlarmEventsResponse>(req, "DescribeInstanceAlarmEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeInstanceParamRecords）用于查询实例参数修改历史。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public Task<DescribeInstanceParamRecordsResponse> DescribeInstanceParamRecords(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords");
        }

        /// <summary>
        /// 该接口（DescribeInstanceParamRecords）用于查询实例参数修改历史。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public DescribeInstanceParamRecordsResponse DescribeInstanceParamRecordsSync(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeInstanceParams）用于查询实例的参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams");
        }

        /// <summary>
        /// 该接口（DescribeInstanceParams）用于查询实例的参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询实例本地binlog保留策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="DescribeLocalBinlogConfigResponse"/></returns>
        public Task<DescribeLocalBinlogConfigResponse> DescribeLocalBinlogConfig(DescribeLocalBinlogConfigRequest req)
        {
            return InternalRequestAsync<DescribeLocalBinlogConfigResponse>(req, "DescribeLocalBinlogConfig");
        }

        /// <summary>
        /// 该接口用于查询实例本地binlog保留策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="DescribeLocalBinlogConfigResponse"/></returns>
        public DescribeLocalBinlogConfigResponse DescribeLocalBinlogConfigSync(DescribeLocalBinlogConfigRequest req)
        {
            return InternalRequestAsync<DescribeLocalBinlogConfigResponse>(req, "DescribeLocalBinlogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeParamTemplateInfo）用于查询参数模板详情，全地域公共参数Region均为ap-guangzhou。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public Task<DescribeParamTemplateInfoResponse> DescribeParamTemplateInfo(DescribeParamTemplateInfoRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateInfoResponse>(req, "DescribeParamTemplateInfo");
        }

        /// <summary>
        /// 该接口（DescribeParamTemplateInfo）用于查询参数模板详情，全地域公共参数Region均为ap-guangzhou。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public DescribeParamTemplateInfoResponse DescribeParamTemplateInfoSync(DescribeParamTemplateInfoRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateInfoResponse>(req, "DescribeParamTemplateInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeParamTemplates）查询参数模板列表，全地域公共参数Region均为ap-guangzhou。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public Task<DescribeParamTemplatesResponse> DescribeParamTemplates(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates");
        }

        /// <summary>
        /// 该接口（DescribeParamTemplates）查询参数模板列表，全地域公共参数Region均为ap-guangzhou。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public DescribeParamTemplatesResponse DescribeParamTemplatesSync(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups");
        }

        /// <summary>
        /// 本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询代理规格配置
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyCustomConfRequest"/></param>
        /// <returns><see cref="DescribeProxyCustomConfResponse"/></returns>
        public Task<DescribeProxyCustomConfResponse> DescribeProxyCustomConf(DescribeProxyCustomConfRequest req)
        {
            return InternalRequestAsync<DescribeProxyCustomConfResponse>(req, "DescribeProxyCustomConf");
        }

        /// <summary>
        /// 查询代理规格配置
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyCustomConfRequest"/></param>
        /// <returns><see cref="DescribeProxyCustomConfResponse"/></returns>
        public DescribeProxyCustomConfResponse DescribeProxyCustomConfSync(DescribeProxyCustomConfRequest req)
        {
            return InternalRequestAsync<DescribeProxyCustomConfResponse>(req, "DescribeProxyCustomConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例支持代理版本和参数
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySupportParamRequest"/></param>
        /// <returns><see cref="DescribeProxySupportParamResponse"/></returns>
        public Task<DescribeProxySupportParamResponse> DescribeProxySupportParam(DescribeProxySupportParamRequest req)
        {
            return InternalRequestAsync<DescribeProxySupportParamResponse>(req, "DescribeProxySupportParam");
        }

        /// <summary>
        /// 查询实例支持代理版本和参数
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySupportParamRequest"/></param>
        /// <returns><see cref="DescribeProxySupportParamResponse"/></returns>
        public DescribeProxySupportParamResponse DescribeProxySupportParamSync(DescribeProxySupportParamRequest req)
        {
            return InternalRequestAsync<DescribeProxySupportParamResponse>(req, "DescribeProxySupportParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeRemoteBackupConfig)用于查询数据库异地备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeRemoteBackupConfigResponse"/></returns>
        public Task<DescribeRemoteBackupConfigResponse> DescribeRemoteBackupConfig(DescribeRemoteBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeRemoteBackupConfigResponse>(req, "DescribeRemoteBackupConfig");
        }

        /// <summary>
        /// 本接口(DescribeRemoteBackupConfig)用于查询数据库异地备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeRemoteBackupConfigResponse"/></returns>
        public DescribeRemoteBackupConfigResponse DescribeRemoteBackupConfigSync(DescribeRemoteBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeRemoteBackupConfigResponse>(req, "DescribeRemoteBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeRoGroups)用于查询云数据库实例的所有的RO组的信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoGroupsRequest"/></param>
        /// <returns><see cref="DescribeRoGroupsResponse"/></returns>
        public Task<DescribeRoGroupsResponse> DescribeRoGroups(DescribeRoGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRoGroupsResponse>(req, "DescribeRoGroups");
        }

        /// <summary>
        /// 本接口(DescribeRoGroups)用于查询云数据库实例的所有的RO组的信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoGroupsRequest"/></param>
        /// <returns><see cref="DescribeRoGroupsResponse"/></returns>
        public DescribeRoGroupsResponse DescribeRoGroupsSync(DescribeRoGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRoGroupsResponse>(req, "DescribeRoGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeRoMinScale)用于获取只读实例购买、升级时的最小规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoMinScaleRequest"/></param>
        /// <returns><see cref="DescribeRoMinScaleResponse"/></returns>
        public Task<DescribeRoMinScaleResponse> DescribeRoMinScale(DescribeRoMinScaleRequest req)
        {
            return InternalRequestAsync<DescribeRoMinScaleResponse>(req, "DescribeRoMinScale");
        }

        /// <summary>
        /// 本接口(DescribeRoMinScale)用于获取只读实例购买、升级时的最小规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoMinScaleRequest"/></param>
        /// <returns><see cref="DescribeRoMinScaleResponse"/></returns>
        public DescribeRoMinScaleResponse DescribeRoMinScaleSync(DescribeRoMinScaleRequest req)
        {
            return InternalRequestAsync<DescribeRoMinScaleResponse>(req, "DescribeRoMinScale")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeRollbackRangeTime)用于查询云数据库实例可回档的时间范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackRangeTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackRangeTimeResponse"/></returns>
        public Task<DescribeRollbackRangeTimeResponse> DescribeRollbackRangeTime(DescribeRollbackRangeTimeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackRangeTimeResponse>(req, "DescribeRollbackRangeTime");
        }

        /// <summary>
        /// 本接口(DescribeRollbackRangeTime)用于查询云数据库实例可回档的时间范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackRangeTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackRangeTimeResponse"/></returns>
        public DescribeRollbackRangeTimeResponse DescribeRollbackRangeTimeSync(DescribeRollbackRangeTimeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackRangeTimeResponse>(req, "DescribeRollbackRangeTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeRollbackTaskDetail)用于查询云数据库实例回档任务详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRollbackTaskDetailResponse"/></returns>
        public Task<DescribeRollbackTaskDetailResponse> DescribeRollbackTaskDetail(DescribeRollbackTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTaskDetailResponse>(req, "DescribeRollbackTaskDetail");
        }

        /// <summary>
        /// 本接口(DescribeRollbackTaskDetail)用于查询云数据库实例回档任务详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRollbackTaskDetailResponse"/></returns>
        public DescribeRollbackTaskDetailResponse DescribeRollbackTaskDetailSync(DescribeRollbackTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTaskDetailResponse>(req, "DescribeRollbackTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 SSL 开通情况。如果已经开通 SSL ，会同步返回证书下载链接。
        /// </summary>
        /// <param name="req"><see cref="DescribeSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeSSLStatusResponse"/></returns>
        public Task<DescribeSSLStatusResponse> DescribeSSLStatus(DescribeSSLStatusRequest req)
        {
            return InternalRequestAsync<DescribeSSLStatusResponse>(req, "DescribeSSLStatus");
        }

        /// <summary>
        /// 查询 SSL 开通情况。如果已经开通 SSL ，会同步返回证书下载链接。
        /// </summary>
        /// <param name="req"><see cref="DescribeSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeSSLStatusResponse"/></returns>
        public DescribeSSLStatusResponse DescribeSSLStatusSync(DescribeSSLStatusRequest req)
        {
            return InternalRequestAsync<DescribeSSLStatusResponse>(req, "DescribeSSLStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 条件检索实例的慢日志。只允许查看一个月之内的慢日志。
        /// 使用时需要注意：可能存在单条慢日志太大，导致整个http请求的回包太大，进而引发接口超时。一旦发生超时，建议您缩小查询时的Limit参数值，从而降低包的大小，让接口能够及时返回内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogDataRequest"/></param>
        /// <returns><see cref="DescribeSlowLogDataResponse"/></returns>
        public Task<DescribeSlowLogDataResponse> DescribeSlowLogData(DescribeSlowLogDataRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogDataResponse>(req, "DescribeSlowLogData");
        }

        /// <summary>
        /// 条件检索实例的慢日志。只允许查看一个月之内的慢日志。
        /// 使用时需要注意：可能存在单条慢日志太大，导致整个http请求的回包太大，进而引发接口超时。一旦发生超时，建议您缩小查询时的Limit参数值，从而降低包的大小，让接口能够及时返回内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogDataRequest"/></param>
        /// <returns><see cref="DescribeSlowLogDataResponse"/></returns>
        public DescribeSlowLogDataResponse DescribeSlowLogDataSync(DescribeSlowLogDataRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogDataResponse>(req, "DescribeSlowLogData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeSlowLogs)用于获取云数据库实例的慢查询日志。说明：若单次查询数据量过大，则有可能响应超时，建议缩短单次查询时间范围，如一小时，避免导致超时。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public Task<DescribeSlowLogsResponse> DescribeSlowLogs(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs");
        }

        /// <summary>
        /// 本接口(DescribeSlowLogs)用于获取云数据库实例的慢查询日志。说明：若单次查询数据量过大，则有可能响应超时，建议缩短单次查询时间范围，如一小时，避免导致超时。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public DescribeSlowLogsResponse DescribeSlowLogsSync(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeSupportedPrivileges)用于查询云数据库的支持的权限信息，包括全局权限，数据库权限，表权限以及列权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeSupportedPrivilegesResponse"/></returns>
        public Task<DescribeSupportedPrivilegesResponse> DescribeSupportedPrivileges(DescribeSupportedPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeSupportedPrivilegesResponse>(req, "DescribeSupportedPrivileges");
        }

        /// <summary>
        /// 本接口(DescribeSupportedPrivileges)用于查询云数据库的支持的权限信息，包括全局权限，数据库权限，表权限以及列权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeSupportedPrivilegesResponse"/></returns>
        public DescribeSupportedPrivilegesResponse DescribeSupportedPrivilegesSync(DescribeSupportedPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeSupportedPrivilegesResponse>(req, "DescribeSupportedPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeTables)用于查询云数据库实例的数据库表信息，仅支持主实例和灾备实例，不支持只读实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables");
        }

        /// <summary>
        /// 本接口(DescribeTables)用于查询云数据库实例的数据库表信息，仅支持主实例和灾备实例，不支持只读实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeTagsOfInstanceIds)用于获取云数据库实例的标签信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsOfInstanceIdsRequest"/></param>
        /// <returns><see cref="DescribeTagsOfInstanceIdsResponse"/></returns>
        public Task<DescribeTagsOfInstanceIdsResponse> DescribeTagsOfInstanceIds(DescribeTagsOfInstanceIdsRequest req)
        {
            return InternalRequestAsync<DescribeTagsOfInstanceIdsResponse>(req, "DescribeTagsOfInstanceIds");
        }

        /// <summary>
        /// 本接口(DescribeTagsOfInstanceIds)用于获取云数据库实例的标签信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsOfInstanceIdsRequest"/></param>
        /// <returns><see cref="DescribeTagsOfInstanceIdsResponse"/></returns>
        public DescribeTagsOfInstanceIdsResponse DescribeTagsOfInstanceIdsSync(DescribeTagsOfInstanceIdsRequest req)
        {
            return InternalRequestAsync<DescribeTagsOfInstanceIdsResponse>(req, "DescribeTagsOfInstanceIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeTasks)用于查询云数据库实例任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// 本接口(DescribeTasks)用于查询云数据库实例任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeTimeWindow)用于查询云数据库实例的维护时间窗口。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeWindowRequest"/></param>
        /// <returns><see cref="DescribeTimeWindowResponse"/></returns>
        public Task<DescribeTimeWindowResponse> DescribeTimeWindow(DescribeTimeWindowRequest req)
        {
            return InternalRequestAsync<DescribeTimeWindowResponse>(req, "DescribeTimeWindow");
        }

        /// <summary>
        /// 本接口(DescribeTimeWindow)用于查询云数据库实例的维护时间窗口。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeWindowRequest"/></param>
        /// <returns><see cref="DescribeTimeWindowResponse"/></returns>
        public DescribeTimeWindowResponse DescribeTimeWindowSync(DescribeTimeWindowRequest req)
        {
            return InternalRequestAsync<DescribeTimeWindowResponse>(req, "DescribeTimeWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeUploadedFiles)用于查询用户导入的SQL文件列表，全地域公共参数Region均为ap-shanghai。
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadedFilesRequest"/></param>
        /// <returns><see cref="DescribeUploadedFilesResponse"/></returns>
        public Task<DescribeUploadedFilesResponse> DescribeUploadedFiles(DescribeUploadedFilesRequest req)
        {
            return InternalRequestAsync<DescribeUploadedFilesResponse>(req, "DescribeUploadedFiles");
        }

        /// <summary>
        /// 本接口(DescribeUploadedFiles)用于查询用户导入的SQL文件列表，全地域公共参数Region均为ap-shanghai。
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadedFilesRequest"/></param>
        /// <returns><see cref="DescribeUploadedFilesResponse"/></returns>
        public DescribeUploadedFilesResponse DescribeUploadedFilesSync(DescribeUploadedFilesRequest req)
        {
            return InternalRequestAsync<DescribeUploadedFilesResponse>(req, "DescribeUploadedFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// 本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口不再维护，参考CreateDBInstance+API文档，在发货时即可完成初始化。
        /// 
        /// 本接口(InitDBInstances)用于初始化云数据库实例，包括初始化密码、默认字符集、实例端口号等。该接口已经废弃，在发货接口CreateDBInstance、CreateDBInstanceHour可以直接使用参数Password设置密码，使用参数ParamList设置字符集，使用参数Port设置端口号。
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public Task<InitDBInstancesResponse> InitDBInstances(InitDBInstancesRequest req)
        {
            return InternalRequestAsync<InitDBInstancesResponse>(req, "InitDBInstances");
        }

        /// <summary>
        /// 该接口不再维护，参考CreateDBInstance+API文档，在发货时即可完成初始化。
        /// 
        /// 本接口(InitDBInstances)用于初始化云数据库实例，包括初始化密码、默认字符集、实例端口号等。该接口已经废弃，在发货接口CreateDBInstance、CreateDBInstanceHour可以直接使用参数Password设置密码，使用参数ParamList设置字符集，使用参数Port设置端口号。
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public InitDBInstancesResponse InitDBInstancesSync(InitDBInstancesRequest req)
        {
            return InternalRequestAsync<InitDBInstancesResponse>(req, "InitDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(InquiryPriceUpgradeInstances)用于查询云数据库实例升级的价格，支持查询按量计费或者包年包月实例的升级价格，实例类型支持主实例、灾备实例和只读实例。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeInstancesResponse"/></returns>
        public Task<InquiryPriceUpgradeInstancesResponse> InquiryPriceUpgradeInstances(InquiryPriceUpgradeInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeInstancesResponse>(req, "InquiryPriceUpgradeInstances");
        }

        /// <summary>
        /// 本接口(InquiryPriceUpgradeInstances)用于查询云数据库实例升级的价格，支持查询按量计费或者包年包月实例的升级价格，实例类型支持主实例、灾备实例和只读实例。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeInstancesResponse"/></returns>
        public InquiryPriceUpgradeInstancesResponse InquiryPriceUpgradeInstancesSync(InquiryPriceUpgradeInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeInstancesResponse>(req, "InquiryPriceUpgradeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(IsolateDBInstance)用于隔离云数据库实例，隔离后不能通过IP和端口访问数据库。隔离的实例可在回收站中进行开机。若为欠费隔离，请尽快进行充值。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public Task<IsolateDBInstanceResponse> IsolateDBInstance(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance");
        }

        /// <summary>
        /// 本接口(IsolateDBInstance)用于隔离云数据库实例，隔离后不能通过IP和端口访问数据库。隔离的实例可在回收站中进行开机。若为欠费隔离，请尽快进行充值。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public IsolateDBInstanceResponse IsolateDBInstanceSync(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAccountDescription)用于修改云数据库账户的备注信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription");
        }

        /// <summary>
        /// 本接口(ModifyAccountDescription)用于修改云数据库账户的备注信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionSync(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAccountHost)用于修改云数据库账户的主机。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountHostRequest"/></param>
        /// <returns><see cref="ModifyAccountHostResponse"/></returns>
        public Task<ModifyAccountHostResponse> ModifyAccountHost(ModifyAccountHostRequest req)
        {
            return InternalRequestAsync<ModifyAccountHostResponse>(req, "ModifyAccountHost");
        }

        /// <summary>
        /// 本接口(ModifyAccountHost)用于修改云数据库账户的主机。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountHostRequest"/></param>
        /// <returns><see cref="ModifyAccountHostResponse"/></returns>
        public ModifyAccountHostResponse ModifyAccountHostSync(ModifyAccountHostRequest req)
        {
            return InternalRequestAsync<ModifyAccountHostResponse>(req, "ModifyAccountHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAccountMaxUserConnections)用于修改云数据库账户最大可用连接数。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountMaxUserConnectionsRequest"/></param>
        /// <returns><see cref="ModifyAccountMaxUserConnectionsResponse"/></returns>
        public Task<ModifyAccountMaxUserConnectionsResponse> ModifyAccountMaxUserConnections(ModifyAccountMaxUserConnectionsRequest req)
        {
            return InternalRequestAsync<ModifyAccountMaxUserConnectionsResponse>(req, "ModifyAccountMaxUserConnections");
        }

        /// <summary>
        /// 本接口(ModifyAccountMaxUserConnections)用于修改云数据库账户最大可用连接数。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountMaxUserConnectionsRequest"/></param>
        /// <returns><see cref="ModifyAccountMaxUserConnectionsResponse"/></returns>
        public ModifyAccountMaxUserConnectionsResponse ModifyAccountMaxUserConnectionsSync(ModifyAccountMaxUserConnectionsRequest req)
        {
            return InternalRequestAsync<ModifyAccountMaxUserConnectionsResponse>(req, "ModifyAccountMaxUserConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAccountPassword)用于修改云数据库账户的密码。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPasswordRequest"/></param>
        /// <returns><see cref="ModifyAccountPasswordResponse"/></returns>
        public Task<ModifyAccountPasswordResponse> ModifyAccountPassword(ModifyAccountPasswordRequest req)
        {
            return InternalRequestAsync<ModifyAccountPasswordResponse>(req, "ModifyAccountPassword");
        }

        /// <summary>
        /// 本接口(ModifyAccountPassword)用于修改云数据库账户的密码。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPasswordRequest"/></param>
        /// <returns><see cref="ModifyAccountPasswordResponse"/></returns>
        public ModifyAccountPasswordResponse ModifyAccountPasswordSync(ModifyAccountPasswordRequest req)
        {
            return InternalRequestAsync<ModifyAccountPasswordResponse>(req, "ModifyAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAccountPrivileges)用于修改云数据库的账户的权限信息。
        /// 
        /// 注意，修改账号权限时，需要传入该账号下的全量权限信息。用户可以先通过 [查询云数据库账户的权限信息
        /// ](https://cloud.tencent.com/document/api/236/17500) 查询该账号下的全量权限信息，然后进行权限修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivileges(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges");
        }

        /// <summary>
        /// 本接口(ModifyAccountPrivileges)用于修改云数据库的账户的权限信息。
        /// 
        /// 注意，修改账号权限时，需要传入该账号下的全量权限信息。用户可以先通过 [查询云数据库账户的权限信息
        /// ](https://cloud.tencent.com/document/api/236/17500) 查询该账号下的全量权限信息，然后进行权限修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public ModifyAccountPrivilegesResponse ModifyAccountPrivilegesSync(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAuditConfig)用于修改云数据库审计策略的服务配置，包括审计日志保存时长等。
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditConfigRequest"/></param>
        /// <returns><see cref="ModifyAuditConfigResponse"/></returns>
        public Task<ModifyAuditConfigResponse> ModifyAuditConfig(ModifyAuditConfigRequest req)
        {
            return InternalRequestAsync<ModifyAuditConfigResponse>(req, "ModifyAuditConfig");
        }

        /// <summary>
        /// 本接口(ModifyAuditConfig)用于修改云数据库审计策略的服务配置，包括审计日志保存时长等。
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditConfigRequest"/></param>
        /// <returns><see cref="ModifyAuditConfigResponse"/></returns>
        public ModifyAuditConfigResponse ModifyAuditConfigSync(ModifyAuditConfigRequest req)
        {
            return InternalRequestAsync<ModifyAuditConfigResponse>(req, "ModifyAuditConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAuditRule)用于修改用户的审计规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditRuleRequest"/></param>
        /// <returns><see cref="ModifyAuditRuleResponse"/></returns>
        public Task<ModifyAuditRuleResponse> ModifyAuditRule(ModifyAuditRuleRequest req)
        {
            return InternalRequestAsync<ModifyAuditRuleResponse>(req, "ModifyAuditRule");
        }

        /// <summary>
        /// 本接口(ModifyAuditRule)用于修改用户的审计规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditRuleRequest"/></param>
        /// <returns><see cref="ModifyAuditRuleResponse"/></returns>
        public ModifyAuditRuleResponse ModifyAuditRuleSync(ModifyAuditRuleRequest req)
        {
            return InternalRequestAsync<ModifyAuditRuleResponse>(req, "ModifyAuditRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改审计规则模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="ModifyAuditRuleTemplatesResponse"/></returns>
        public Task<ModifyAuditRuleTemplatesResponse> ModifyAuditRuleTemplates(ModifyAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<ModifyAuditRuleTemplatesResponse>(req, "ModifyAuditRuleTemplates");
        }

        /// <summary>
        /// 修改审计规则模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditRuleTemplatesRequest"/></param>
        /// <returns><see cref="ModifyAuditRuleTemplatesResponse"/></returns>
        public ModifyAuditRuleTemplatesResponse ModifyAuditRuleTemplatesSync(ModifyAuditRuleTemplatesRequest req)
        {
            return InternalRequestAsync<ModifyAuditRuleTemplatesResponse>(req, "ModifyAuditRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAuditService)用于修改云数据库审计日志保存时长、审计规则等服务配置
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public Task<ModifyAuditServiceResponse> ModifyAuditService(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService");
        }

        /// <summary>
        /// 本接口(ModifyAuditService)用于修改云数据库审计日志保存时长、审计规则等服务配置
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public ModifyAuditServiceResponse ModifyAuditServiceSync(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAutoRenewFlag)用于修改云数据库实例的自动续费标记。仅支持包年包月的实例设置自动续费标记。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public Task<ModifyAutoRenewFlagResponse> ModifyAutoRenewFlag(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag");
        }

        /// <summary>
        /// 本接口(ModifyAutoRenewFlag)用于修改云数据库实例的自动续费标记。仅支持包年包月的实例设置自动续费标记。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public ModifyAutoRenewFlagResponse ModifyAutoRenewFlagSync(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyBackupConfig)用于修改数据库备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public Task<ModifyBackupConfigResponse> ModifyBackupConfig(ModifyBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyBackupConfigResponse>(req, "ModifyBackupConfig");
        }

        /// <summary>
        /// 本接口(ModifyBackupConfig)用于修改数据库备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public ModifyBackupConfigResponse ModifyBackupConfigSync(ModifyBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyBackupConfigResponse>(req, "ModifyBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改用户当前地域的备份文件限制下载来源，可以设置内外网均可下载、仅内网可下载，或内网指定的vpc、ip可以下载。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public Task<ModifyBackupDownloadRestrictionResponse> ModifyBackupDownloadRestriction(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction");
        }

        /// <summary>
        /// 该接口用于修改用户当前地域的备份文件限制下载来源，可以设置内外网均可下载、仅内网可下载，或内网指定的vpc、ip可以下载。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public ModifyBackupDownloadRestrictionResponse ModifyBackupDownloadRestrictionSync(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyBackupEncryptionStatus)用于设置实例备份文件是否加密。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="ModifyBackupEncryptionStatusResponse"/></returns>
        public Task<ModifyBackupEncryptionStatusResponse> ModifyBackupEncryptionStatus(ModifyBackupEncryptionStatusRequest req)
        {
            return InternalRequestAsync<ModifyBackupEncryptionStatusResponse>(req, "ModifyBackupEncryptionStatus");
        }

        /// <summary>
        /// 本接口(ModifyBackupEncryptionStatus)用于设置实例备份文件是否加密。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="ModifyBackupEncryptionStatusResponse"/></returns>
        public ModifyBackupEncryptionStatusResponse ModifyBackupEncryptionStatusSync(ModifyBackupEncryptionStatusRequest req)
        {
            return InternalRequestAsync<ModifyBackupEncryptionStatusResponse>(req, "ModifyBackupEncryptionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改代理地址描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressDescRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressDescResponse"/></returns>
        public Task<ModifyCdbProxyAddressDescResponse> ModifyCdbProxyAddressDesc(ModifyCdbProxyAddressDescRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyAddressDescResponse>(req, "ModifyCdbProxyAddressDesc");
        }

        /// <summary>
        /// 修改代理地址描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressDescRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressDescResponse"/></returns>
        public ModifyCdbProxyAddressDescResponse ModifyCdbProxyAddressDescSync(ModifyCdbProxyAddressDescRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyAddressDescResponse>(req, "ModifyCdbProxyAddressDesc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改数据库代理地址VPC信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressVipAndVPortRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressVipAndVPortResponse"/></returns>
        public Task<ModifyCdbProxyAddressVipAndVPortResponse> ModifyCdbProxyAddressVipAndVPort(ModifyCdbProxyAddressVipAndVPortRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyAddressVipAndVPortResponse>(req, "ModifyCdbProxyAddressVipAndVPort");
        }

        /// <summary>
        /// 修改数据库代理地址VPC信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressVipAndVPortRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressVipAndVPortResponse"/></returns>
        public ModifyCdbProxyAddressVipAndVPortResponse ModifyCdbProxyAddressVipAndVPortSync(ModifyCdbProxyAddressVipAndVPortRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyAddressVipAndVPortResponse>(req, "ModifyCdbProxyAddressVipAndVPort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 配置数据库代理参数
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyParamRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyParamResponse"/></returns>
        public Task<ModifyCdbProxyParamResponse> ModifyCdbProxyParam(ModifyCdbProxyParamRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyParamResponse>(req, "ModifyCdbProxyParam");
        }

        /// <summary>
        /// 配置数据库代理参数
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyParamRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyParamResponse"/></returns>
        public ModifyCdbProxyParamResponse ModifyCdbProxyParamSync(ModifyCdbProxyParamRequest req)
        {
            return InternalRequestAsync<ModifyCdbProxyParamResponse>(req, "ModifyCdbProxyParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启/关闭CDB慢日志、错误日志投递CLS
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceLogToCLSRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceLogToCLSResponse"/></returns>
        public Task<ModifyDBInstanceLogToCLSResponse> ModifyDBInstanceLogToCLS(ModifyDBInstanceLogToCLSRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceLogToCLSResponse>(req, "ModifyDBInstanceLogToCLS");
        }

        /// <summary>
        /// 开启/关闭CDB慢日志、错误日志投递CLS
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceLogToCLSRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceLogToCLSResponse"/></returns>
        public ModifyDBInstanceLogToCLSResponse ModifyDBInstanceLogToCLSSync(ModifyDBInstanceLogToCLSRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceLogToCLSResponse>(req, "ModifyDBInstanceLogToCLS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceName)用于修改云数据库实例的名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName");
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceName)用于修改云数据库实例的名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceProject)用于修改云数据库实例的所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public Task<ModifyDBInstanceProjectResponse> ModifyDBInstanceProject(ModifyDBInstanceProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceProjectResponse>(req, "ModifyDBInstanceProject");
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceProject)用于修改云数据库实例的所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public ModifyDBInstanceProjectResponse ModifyDBInstanceProjectSync(ModifyDBInstanceProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceProjectResponse>(req, "ModifyDBInstanceProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceVipVport)用于修改云数据库实例的IP和端口号，也可进行基础网络转 VPC 网络和 VPC 网络下的子网变更。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceVipVportRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceVipVportResponse"/></returns>
        public Task<ModifyDBInstanceVipVportResponse> ModifyDBInstanceVipVport(ModifyDBInstanceVipVportRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceVipVportResponse>(req, "ModifyDBInstanceVipVport");
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceVipVport)用于修改云数据库实例的IP和端口号，也可进行基础网络转 VPC 网络和 VPC 网络下的子网变更。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceVipVportRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceVipVportResponse"/></returns>
        public ModifyDBInstanceVipVportResponse ModifyDBInstanceVipVportSync(ModifyDBInstanceVipVportRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceVipVportResponse>(req, "ModifyDBInstanceVipVport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyInstanceParam)用于修改云数据库实例的参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public Task<ModifyInstanceParamResponse> ModifyInstanceParam(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam");
        }

        /// <summary>
        /// 本接口(ModifyInstanceParam)用于修改云数据库实例的参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public ModifyInstanceParamResponse ModifyInstanceParamSync(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyInstancePasswordComplexity)用于修改云数据库实例的密码复杂度。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePasswordComplexityRequest"/></param>
        /// <returns><see cref="ModifyInstancePasswordComplexityResponse"/></returns>
        public Task<ModifyInstancePasswordComplexityResponse> ModifyInstancePasswordComplexity(ModifyInstancePasswordComplexityRequest req)
        {
            return InternalRequestAsync<ModifyInstancePasswordComplexityResponse>(req, "ModifyInstancePasswordComplexity");
        }

        /// <summary>
        /// 本接口(ModifyInstancePasswordComplexity)用于修改云数据库实例的密码复杂度。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePasswordComplexityRequest"/></param>
        /// <returns><see cref="ModifyInstancePasswordComplexityResponse"/></returns>
        public ModifyInstancePasswordComplexityResponse ModifyInstancePasswordComplexitySync(ModifyInstancePasswordComplexityRequest req)
        {
            return InternalRequestAsync<ModifyInstancePasswordComplexityResponse>(req, "ModifyInstancePasswordComplexity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyInstanceTag)用于对实例标签进行添加、修改或者删除。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTagRequest"/></param>
        /// <returns><see cref="ModifyInstanceTagResponse"/></returns>
        public Task<ModifyInstanceTagResponse> ModifyInstanceTag(ModifyInstanceTagRequest req)
        {
            return InternalRequestAsync<ModifyInstanceTagResponse>(req, "ModifyInstanceTag");
        }

        /// <summary>
        /// 本接口(ModifyInstanceTag)用于对实例标签进行添加、修改或者删除。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTagRequest"/></param>
        /// <returns><see cref="ModifyInstanceTagResponse"/></returns>
        public ModifyInstanceTagResponse ModifyInstanceTagSync(ModifyInstanceTagRequest req)
        {
            return InternalRequestAsync<ModifyInstanceTagResponse>(req, "ModifyInstanceTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改实例本地binlog保留策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="ModifyLocalBinlogConfigResponse"/></returns>
        public Task<ModifyLocalBinlogConfigResponse> ModifyLocalBinlogConfig(ModifyLocalBinlogConfigRequest req)
        {
            return InternalRequestAsync<ModifyLocalBinlogConfigResponse>(req, "ModifyLocalBinlogConfig");
        }

        /// <summary>
        /// 该接口用于修改实例本地binlog保留策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="ModifyLocalBinlogConfigResponse"/></returns>
        public ModifyLocalBinlogConfigResponse ModifyLocalBinlogConfigSync(ModifyLocalBinlogConfigRequest req)
        {
            return InternalRequestAsync<ModifyLocalBinlogConfigResponse>(req, "ModifyLocalBinlogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改置放群组的名称或者描述
        /// </summary>
        /// <param name="req"><see cref="ModifyNameOrDescByDpIdRequest"/></param>
        /// <returns><see cref="ModifyNameOrDescByDpIdResponse"/></returns>
        public Task<ModifyNameOrDescByDpIdResponse> ModifyNameOrDescByDpId(ModifyNameOrDescByDpIdRequest req)
        {
            return InternalRequestAsync<ModifyNameOrDescByDpIdResponse>(req, "ModifyNameOrDescByDpId");
        }

        /// <summary>
        /// 修改置放群组的名称或者描述
        /// </summary>
        /// <param name="req"><see cref="ModifyNameOrDescByDpIdRequest"/></param>
        /// <returns><see cref="ModifyNameOrDescByDpIdResponse"/></returns>
        public ModifyNameOrDescByDpIdResponse ModifyNameOrDescByDpIdSync(ModifyNameOrDescByDpIdRequest req)
        {
            return InternalRequestAsync<ModifyNameOrDescByDpIdResponse>(req, "ModifyNameOrDescByDpId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（ModifyParamTemplate）用于修改参数模板，全地域公共参数Region均为ap-guangzhou。
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public Task<ModifyParamTemplateResponse> ModifyParamTemplate(ModifyParamTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParamTemplateResponse>(req, "ModifyParamTemplate");
        }

        /// <summary>
        /// 该接口（ModifyParamTemplate）用于修改参数模板，全地域公共参数Region均为ap-guangzhou。
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public ModifyParamTemplateResponse ModifyParamTemplateSync(ModifyParamTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParamTemplateResponse>(req, "ModifyParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyRemoteBackupConfig)用于修改数据库异地备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyRemoteBackupConfigResponse"/></returns>
        public Task<ModifyRemoteBackupConfigResponse> ModifyRemoteBackupConfig(ModifyRemoteBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyRemoteBackupConfigResponse>(req, "ModifyRemoteBackupConfig");
        }

        /// <summary>
        /// 本接口(ModifyRemoteBackupConfig)用于修改数据库异地备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyRemoteBackupConfigResponse"/></returns>
        public ModifyRemoteBackupConfigResponse ModifyRemoteBackupConfigSync(ModifyRemoteBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyRemoteBackupConfigResponse>(req, "ModifyRemoteBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyRoGroupInfo）用于更新云数据库只读组的信息。包括设置实例延迟超限剔除策略，设置只读实例读权重，设置复制延迟时间等。
        /// </summary>
        /// <param name="req"><see cref="ModifyRoGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyRoGroupInfoResponse"/></returns>
        public Task<ModifyRoGroupInfoResponse> ModifyRoGroupInfo(ModifyRoGroupInfoRequest req)
        {
            return InternalRequestAsync<ModifyRoGroupInfoResponse>(req, "ModifyRoGroupInfo");
        }

        /// <summary>
        /// 本接口（ModifyRoGroupInfo）用于更新云数据库只读组的信息。包括设置实例延迟超限剔除策略，设置只读实例读权重，设置复制延迟时间等。
        /// </summary>
        /// <param name="req"><see cref="ModifyRoGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyRoGroupInfoResponse"/></returns>
        public ModifyRoGroupInfoResponse ModifyRoGroupInfoSync(ModifyRoGroupInfoRequest req)
        {
            return InternalRequestAsync<ModifyRoGroupInfoResponse>(req, "ModifyRoGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyTimeWindow)用于更新云数据库实例的维护时间窗口。
        /// </summary>
        /// <param name="req"><see cref="ModifyTimeWindowRequest"/></param>
        /// <returns><see cref="ModifyTimeWindowResponse"/></returns>
        public Task<ModifyTimeWindowResponse> ModifyTimeWindow(ModifyTimeWindowRequest req)
        {
            return InternalRequestAsync<ModifyTimeWindowResponse>(req, "ModifyTimeWindow");
        }

        /// <summary>
        /// 本接口(ModifyTimeWindow)用于更新云数据库实例的维护时间窗口。
        /// </summary>
        /// <param name="req"><see cref="ModifyTimeWindowRequest"/></param>
        /// <returns><see cref="ModifyTimeWindowResponse"/></returns>
        public ModifyTimeWindowResponse ModifyTimeWindowSync(ModifyTimeWindowRequest req)
        {
            return InternalRequestAsync<ModifyTimeWindowResponse>(req, "ModifyTimeWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(OfflineIsolatedInstances)用于立即下线隔离状态的云数据库实例。进行操作的实例状态必须为隔离状态，即通过 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询到 Status 值为 5 的实例。
        /// 
        /// 该接口为异步操作，部分资源的回收可能存在延迟。您可以通过使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口，指定实例 InstanceId 和状态 Status 为 [5,6,7] 进行查询，若返回实例为空，则实例资源已全部释放。
        /// 
        /// 注意，实例下线后，相关资源和数据将无法找回，请谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedInstancesRequest"/></param>
        /// <returns><see cref="OfflineIsolatedInstancesResponse"/></returns>
        public Task<OfflineIsolatedInstancesResponse> OfflineIsolatedInstances(OfflineIsolatedInstancesRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedInstancesResponse>(req, "OfflineIsolatedInstances");
        }

        /// <summary>
        /// 本接口(OfflineIsolatedInstances)用于立即下线隔离状态的云数据库实例。进行操作的实例状态必须为隔离状态，即通过 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询到 Status 值为 5 的实例。
        /// 
        /// 该接口为异步操作，部分资源的回收可能存在延迟。您可以通过使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口，指定实例 InstanceId 和状态 Status 为 [5,6,7] 进行查询，若返回实例为空，则实例资源已全部释放。
        /// 
        /// 注意，实例下线后，相关资源和数据将无法找回，请谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedInstancesRequest"/></param>
        /// <returns><see cref="OfflineIsolatedInstancesResponse"/></returns>
        public OfflineIsolatedInstancesResponse OfflineIsolatedInstancesSync(OfflineIsolatedInstancesRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedInstancesResponse>(req, "OfflineIsolatedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CDB实例开通审计服务
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public Task<OpenAuditServiceResponse> OpenAuditService(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService");
        }

        /// <summary>
        /// CDB实例开通审计服务
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public OpenAuditServiceResponse OpenAuditServiceSync(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(OpenDBInstanceEncryption)用于启用实例数据存储加密功能，支持用户指定自定义密钥。
        /// 
        /// 注意，启用实例数据存储加密之前，需要进行以下操作：
        /// 
        /// 1、进行 [实例初始化](https://cloud.tencent.com/document/api/236/15873) 操作；
        /// 
        /// 2、开启 [KMS服务](https://console.cloud.tencent.com/kms2)；
        /// 
        /// 3、对云数据库(MySQL)[授予访问KMS密钥的权限](https://console.cloud.tencent.com/cam/role)，角色名为MySQL_QCSRole，预设策略名为QcloudAccessForMySQLRole；
        /// 
        /// 该 API 耗时可能到10s，客户端可能超时，如果调用 API 返回 InternalError ，请您调用DescribeDBInstanceInfo 确认后端加密是否开通成功。
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceEncryptionRequest"/></param>
        /// <returns><see cref="OpenDBInstanceEncryptionResponse"/></returns>
        public Task<OpenDBInstanceEncryptionResponse> OpenDBInstanceEncryption(OpenDBInstanceEncryptionRequest req)
        {
            return InternalRequestAsync<OpenDBInstanceEncryptionResponse>(req, "OpenDBInstanceEncryption");
        }

        /// <summary>
        /// 本接口(OpenDBInstanceEncryption)用于启用实例数据存储加密功能，支持用户指定自定义密钥。
        /// 
        /// 注意，启用实例数据存储加密之前，需要进行以下操作：
        /// 
        /// 1、进行 [实例初始化](https://cloud.tencent.com/document/api/236/15873) 操作；
        /// 
        /// 2、开启 [KMS服务](https://console.cloud.tencent.com/kms2)；
        /// 
        /// 3、对云数据库(MySQL)[授予访问KMS密钥的权限](https://console.cloud.tencent.com/cam/role)，角色名为MySQL_QCSRole，预设策略名为QcloudAccessForMySQLRole；
        /// 
        /// 该 API 耗时可能到10s，客户端可能超时，如果调用 API 返回 InternalError ，请您调用DescribeDBInstanceInfo 确认后端加密是否开通成功。
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceEncryptionRequest"/></param>
        /// <returns><see cref="OpenDBInstanceEncryptionResponse"/></returns>
        public OpenDBInstanceEncryptionResponse OpenDBInstanceEncryptionSync(OpenDBInstanceEncryptionRequest req)
        {
            return InternalRequestAsync<OpenDBInstanceEncryptionResponse>(req, "OpenDBInstanceEncryption")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(OpenDBInstanceGTID)用于开启云数据库实例的 GTID，只支持版本为 5.6 以及以上的实例。
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="OpenDBInstanceGTIDResponse"/></returns>
        public Task<OpenDBInstanceGTIDResponse> OpenDBInstanceGTID(OpenDBInstanceGTIDRequest req)
        {
            return InternalRequestAsync<OpenDBInstanceGTIDResponse>(req, "OpenDBInstanceGTID");
        }

        /// <summary>
        /// 本接口(OpenDBInstanceGTID)用于开启云数据库实例的 GTID，只支持版本为 5.6 以及以上的实例。
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="OpenDBInstanceGTIDResponse"/></returns>
        public OpenDBInstanceGTIDResponse OpenDBInstanceGTIDSync(OpenDBInstanceGTIDRequest req)
        {
            return InternalRequestAsync<OpenDBInstanceGTIDResponse>(req, "OpenDBInstanceGTID")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启SSL连接功能。
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public Task<OpenSSLResponse> OpenSSL(OpenSSLRequest req)
        {
            return InternalRequestAsync<OpenSSLResponse>(req, "OpenSSL");
        }

        /// <summary>
        /// 开启SSL连接功能。
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public OpenSSLResponse OpenSSLSync(OpenSSLRequest req)
        {
            return InternalRequestAsync<OpenSSLResponse>(req, "OpenSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(OpenWanService)用于开通实例外网访问。
        /// 
        /// 注意，实例开通外网访问之前，需要先将实例进行 [实例初始化](https://cloud.tencent.com/document/api/236/15873) 操作。
        /// </summary>
        /// <param name="req"><see cref="OpenWanServiceRequest"/></param>
        /// <returns><see cref="OpenWanServiceResponse"/></returns>
        public Task<OpenWanServiceResponse> OpenWanService(OpenWanServiceRequest req)
        {
            return InternalRequestAsync<OpenWanServiceResponse>(req, "OpenWanService");
        }

        /// <summary>
        /// 本接口(OpenWanService)用于开通实例外网访问。
        /// 
        /// 注意，实例开通外网访问之前，需要先将实例进行 [实例初始化](https://cloud.tencent.com/document/api/236/15873) 操作。
        /// </summary>
        /// <param name="req"><see cref="OpenWanServiceRequest"/></param>
        /// <returns><see cref="OpenWanServiceResponse"/></returns>
        public OpenWanServiceResponse OpenWanServiceSync(OpenWanServiceRequest req)
        {
            return InternalRequestAsync<OpenWanServiceResponse>(req, "OpenWanService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ReleaseIsolatedDBInstances）用于恢复已隔离云数据库实例。仅用于按量计费实例的解隔离，包年包月实例的解隔离请使用 RenewDBInstance 。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIsolatedDBInstancesRequest"/></param>
        /// <returns><see cref="ReleaseIsolatedDBInstancesResponse"/></returns>
        public Task<ReleaseIsolatedDBInstancesResponse> ReleaseIsolatedDBInstances(ReleaseIsolatedDBInstancesRequest req)
        {
            return InternalRequestAsync<ReleaseIsolatedDBInstancesResponse>(req, "ReleaseIsolatedDBInstances");
        }

        /// <summary>
        /// 本接口（ReleaseIsolatedDBInstances）用于恢复已隔离云数据库实例。仅用于按量计费实例的解隔离，包年包月实例的解隔离请使用 RenewDBInstance 。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIsolatedDBInstancesRequest"/></param>
        /// <returns><see cref="ReleaseIsolatedDBInstancesResponse"/></returns>
        public ReleaseIsolatedDBInstancesResponse ReleaseIsolatedDBInstancesSync(ReleaseIsolatedDBInstancesRequest req)
        {
            return InternalRequestAsync<ReleaseIsolatedDBInstancesResponse>(req, "ReleaseIsolatedDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新负载均衡数据库代理
        /// </summary>
        /// <param name="req"><see cref="ReloadBalanceProxyNodeRequest"/></param>
        /// <returns><see cref="ReloadBalanceProxyNodeResponse"/></returns>
        public Task<ReloadBalanceProxyNodeResponse> ReloadBalanceProxyNode(ReloadBalanceProxyNodeRequest req)
        {
            return InternalRequestAsync<ReloadBalanceProxyNodeResponse>(req, "ReloadBalanceProxyNode");
        }

        /// <summary>
        /// 重新负载均衡数据库代理
        /// </summary>
        /// <param name="req"><see cref="ReloadBalanceProxyNodeRequest"/></param>
        /// <returns><see cref="ReloadBalanceProxyNodeResponse"/></returns>
        public ReloadBalanceProxyNodeResponse ReloadBalanceProxyNodeSync(ReloadBalanceProxyNodeRequest req)
        {
            return InternalRequestAsync<ReloadBalanceProxyNodeResponse>(req, "ReloadBalanceProxyNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(RenewDBInstance)用于续费云数据库实例，支持付费模式为包年包月的实例。按量计费实例可通过该接口续费为包年包月的实例。
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDBInstanceResponse"/></returns>
        public Task<RenewDBInstanceResponse> RenewDBInstance(RenewDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewDBInstanceResponse>(req, "RenewDBInstance");
        }

        /// <summary>
        /// 本接口(RenewDBInstance)用于续费云数据库实例，支持付费模式为包年包月的实例。按量计费实例可通过该接口续费为包年包月的实例。
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDBInstanceResponse"/></returns>
        public RenewDBInstanceResponse RenewDBInstanceSync(RenewDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewDBInstanceResponse>(req, "RenewDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置实例ROOT账号，初始化账号权限
        /// </summary>
        /// <param name="req"><see cref="ResetRootAccountRequest"/></param>
        /// <returns><see cref="ResetRootAccountResponse"/></returns>
        public Task<ResetRootAccountResponse> ResetRootAccount(ResetRootAccountRequest req)
        {
            return InternalRequestAsync<ResetRootAccountResponse>(req, "ResetRootAccount");
        }

        /// <summary>
        /// 重置实例ROOT账号，初始化账号权限
        /// </summary>
        /// <param name="req"><see cref="ResetRootAccountRequest"/></param>
        /// <returns><see cref="ResetRootAccountResponse"/></returns>
        public ResetRootAccountResponse ResetRootAccountSync(ResetRootAccountRequest req)
        {
            return InternalRequestAsync<ResetRootAccountResponse>(req, "ResetRootAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(RestartDBInstances)用于重启云数据库实例。
        /// 
        /// 注意：
        /// 1、本接口只支持主实例进行重启操作；
        /// 2、实例状态必须为正常，并且没有其他异步任务在执行中。
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public Task<RestartDBInstancesResponse> RestartDBInstances(RestartDBInstancesRequest req)
        {
            return InternalRequestAsync<RestartDBInstancesResponse>(req, "RestartDBInstances");
        }

        /// <summary>
        /// 本接口(RestartDBInstances)用于重启云数据库实例。
        /// 
        /// 注意：
        /// 1、本接口只支持主实例进行重启操作；
        /// 2、实例状态必须为正常，并且没有其他异步任务在执行中。
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public RestartDBInstancesResponse RestartDBInstancesSync(RestartDBInstancesRequest req)
        {
            return InternalRequestAsync<RestartDBInstancesResponse>(req, "RestartDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（StartBatchRollback）用于批量回档云数据库实例的库表。
        /// </summary>
        /// <param name="req"><see cref="StartBatchRollbackRequest"/></param>
        /// <returns><see cref="StartBatchRollbackResponse"/></returns>
        public Task<StartBatchRollbackResponse> StartBatchRollback(StartBatchRollbackRequest req)
        {
            return InternalRequestAsync<StartBatchRollbackResponse>(req, "StartBatchRollback");
        }

        /// <summary>
        /// 该接口（StartBatchRollback）用于批量回档云数据库实例的库表。
        /// </summary>
        /// <param name="req"><see cref="StartBatchRollbackRequest"/></param>
        /// <returns><see cref="StartBatchRollbackResponse"/></returns>
        public StartBatchRollbackResponse StartBatchRollbackSync(StartBatchRollbackRequest req)
        {
            return InternalRequestAsync<StartBatchRollbackResponse>(req, "StartBatchRollback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过该API，可以开启CPU弹性扩容，包括一次性的手动扩容以及自动弹性扩容。
        /// </summary>
        /// <param name="req"><see cref="StartCpuExpandRequest"/></param>
        /// <returns><see cref="StartCpuExpandResponse"/></returns>
        public Task<StartCpuExpandResponse> StartCpuExpand(StartCpuExpandRequest req)
        {
            return InternalRequestAsync<StartCpuExpandResponse>(req, "StartCpuExpand");
        }

        /// <summary>
        /// 通过该API，可以开启CPU弹性扩容，包括一次性的手动扩容以及自动弹性扩容。
        /// </summary>
        /// <param name="req"><see cref="StartCpuExpandRequest"/></param>
        /// <returns><see cref="StartCpuExpandResponse"/></returns>
        public StartCpuExpandResponse StartCpuExpandSync(StartCpuExpandRequest req)
        {
            return InternalRequestAsync<StartCpuExpandResponse>(req, "StartCpuExpand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启 RO 复制，从主实例同步数据。
        /// </summary>
        /// <param name="req"><see cref="StartReplicationRequest"/></param>
        /// <returns><see cref="StartReplicationResponse"/></returns>
        public Task<StartReplicationResponse> StartReplication(StartReplicationRequest req)
        {
            return InternalRequestAsync<StartReplicationResponse>(req, "StartReplication");
        }

        /// <summary>
        /// 开启 RO 复制，从主实例同步数据。
        /// </summary>
        /// <param name="req"><see cref="StartReplicationRequest"/></param>
        /// <returns><see cref="StartReplicationResponse"/></returns>
        public StartReplicationResponse StartReplicationSync(StartReplicationRequest req)
        {
            return InternalRequestAsync<StartReplicationResponse>(req, "StartReplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过该API，可以关闭 CPU 弹性扩容。
        /// </summary>
        /// <param name="req"><see cref="StopCpuExpandRequest"/></param>
        /// <returns><see cref="StopCpuExpandResponse"/></returns>
        public Task<StopCpuExpandResponse> StopCpuExpand(StopCpuExpandRequest req)
        {
            return InternalRequestAsync<StopCpuExpandResponse>(req, "StopCpuExpand");
        }

        /// <summary>
        /// 通过该API，可以关闭 CPU 弹性扩容。
        /// </summary>
        /// <param name="req"><see cref="StopCpuExpandRequest"/></param>
        /// <returns><see cref="StopCpuExpandResponse"/></returns>
        public StopCpuExpandResponse StopCpuExpandSync(StopCpuExpandRequest req)
        {
            return InternalRequestAsync<StopCpuExpandResponse>(req, "StopCpuExpand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(StopDBImportJob)用于终止数据导入任务。
        /// </summary>
        /// <param name="req"><see cref="StopDBImportJobRequest"/></param>
        /// <returns><see cref="StopDBImportJobResponse"/></returns>
        public Task<StopDBImportJobResponse> StopDBImportJob(StopDBImportJobRequest req)
        {
            return InternalRequestAsync<StopDBImportJobResponse>(req, "StopDBImportJob");
        }

        /// <summary>
        /// 本接口(StopDBImportJob)用于终止数据导入任务。
        /// </summary>
        /// <param name="req"><see cref="StopDBImportJobRequest"/></param>
        /// <returns><see cref="StopDBImportJobResponse"/></returns>
        public StopDBImportJobResponse StopDBImportJobSync(StopDBImportJobRequest req)
        {
            return InternalRequestAsync<StopDBImportJobResponse>(req, "StopDBImportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止 RO 复制，中断从主实例同步数据。
        /// </summary>
        /// <param name="req"><see cref="StopReplicationRequest"/></param>
        /// <returns><see cref="StopReplicationResponse"/></returns>
        public Task<StopReplicationResponse> StopReplication(StopReplicationRequest req)
        {
            return InternalRequestAsync<StopReplicationResponse>(req, "StopReplication");
        }

        /// <summary>
        /// 停止 RO 复制，中断从主实例同步数据。
        /// </summary>
        /// <param name="req"><see cref="StopReplicationRequest"/></param>
        /// <returns><see cref="StopReplicationResponse"/></returns>
        public StopReplicationResponse StopReplicationSync(StopReplicationRequest req)
        {
            return InternalRequestAsync<StopReplicationResponse>(req, "StopReplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(StopRollback) 用于撤销实例正在进行的回档任务，该接口返回一个异步任务id。 撤销结果可以通过 DescribeAsyncRequestInfo 查询任务的执行情况。
        /// </summary>
        /// <param name="req"><see cref="StopRollbackRequest"/></param>
        /// <returns><see cref="StopRollbackResponse"/></returns>
        public Task<StopRollbackResponse> StopRollback(StopRollbackRequest req)
        {
            return InternalRequestAsync<StopRollbackResponse>(req, "StopRollback");
        }

        /// <summary>
        /// 本接口(StopRollback) 用于撤销实例正在进行的回档任务，该接口返回一个异步任务id。 撤销结果可以通过 DescribeAsyncRequestInfo 查询任务的执行情况。
        /// </summary>
        /// <param name="req"><see cref="StopRollbackRequest"/></param>
        /// <returns><see cref="StopRollbackResponse"/></returns>
        public StopRollbackResponse StopRollbackSync(StopRollbackRequest req)
        {
            return InternalRequestAsync<StopRollbackResponse>(req, "StopRollback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据库代理配置变更或则升级版本后手动发起立即切换
        /// </summary>
        /// <param name="req"><see cref="SwitchCDBProxyRequest"/></param>
        /// <returns><see cref="SwitchCDBProxyResponse"/></returns>
        public Task<SwitchCDBProxyResponse> SwitchCDBProxy(SwitchCDBProxyRequest req)
        {
            return InternalRequestAsync<SwitchCDBProxyResponse>(req, "SwitchCDBProxy");
        }

        /// <summary>
        /// 数据库代理配置变更或则升级版本后手动发起立即切换
        /// </summary>
        /// <param name="req"><see cref="SwitchCDBProxyRequest"/></param>
        /// <returns><see cref="SwitchCDBProxyResponse"/></returns>
        public SwitchCDBProxyResponse SwitchCDBProxySync(SwitchCDBProxyRequest req)
        {
            return InternalRequestAsync<SwitchCDBProxyResponse>(req, "SwitchCDBProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口 (SwitchDBInstanceMasterSlave) 支持用户主动切换实例主从角色。
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceMasterSlaveRequest"/></param>
        /// <returns><see cref="SwitchDBInstanceMasterSlaveResponse"/></returns>
        public Task<SwitchDBInstanceMasterSlaveResponse> SwitchDBInstanceMasterSlave(SwitchDBInstanceMasterSlaveRequest req)
        {
            return InternalRequestAsync<SwitchDBInstanceMasterSlaveResponse>(req, "SwitchDBInstanceMasterSlave");
        }

        /// <summary>
        /// 该接口 (SwitchDBInstanceMasterSlave) 支持用户主动切换实例主从角色。
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceMasterSlaveRequest"/></param>
        /// <returns><see cref="SwitchDBInstanceMasterSlaveResponse"/></returns>
        public SwitchDBInstanceMasterSlaveResponse SwitchDBInstanceMasterSlaveSync(SwitchDBInstanceMasterSlaveRequest req)
        {
            return InternalRequestAsync<SwitchDBInstanceMasterSlaveResponse>(req, "SwitchDBInstanceMasterSlave")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(SwitchDrInstanceToMaster)用于将云数据库灾备实例切换为主实例，注意请求必须发到灾备实例所在的地域。
        /// </summary>
        /// <param name="req"><see cref="SwitchDrInstanceToMasterRequest"/></param>
        /// <returns><see cref="SwitchDrInstanceToMasterResponse"/></returns>
        public Task<SwitchDrInstanceToMasterResponse> SwitchDrInstanceToMaster(SwitchDrInstanceToMasterRequest req)
        {
            return InternalRequestAsync<SwitchDrInstanceToMasterResponse>(req, "SwitchDrInstanceToMaster");
        }

        /// <summary>
        /// 本接口(SwitchDrInstanceToMaster)用于将云数据库灾备实例切换为主实例，注意请求必须发到灾备实例所在的地域。
        /// </summary>
        /// <param name="req"><see cref="SwitchDrInstanceToMasterRequest"/></param>
        /// <returns><see cref="SwitchDrInstanceToMasterResponse"/></returns>
        public SwitchDrInstanceToMasterResponse SwitchDrInstanceToMasterSync(SwitchDrInstanceToMasterRequest req)
        {
            return InternalRequestAsync<SwitchDrInstanceToMasterResponse>(req, "SwitchDrInstanceToMaster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(SwitchForUpgrade)用于切换访问新实例，针对主升级中的实例处于待切换状态时，用户可主动发起该流程。
        /// </summary>
        /// <param name="req"><see cref="SwitchForUpgradeRequest"/></param>
        /// <returns><see cref="SwitchForUpgradeResponse"/></returns>
        public Task<SwitchForUpgradeResponse> SwitchForUpgrade(SwitchForUpgradeRequest req)
        {
            return InternalRequestAsync<SwitchForUpgradeResponse>(req, "SwitchForUpgrade");
        }

        /// <summary>
        /// 本接口(SwitchForUpgrade)用于切换访问新实例，针对主升级中的实例处于待切换状态时，用户可主动发起该流程。
        /// </summary>
        /// <param name="req"><see cref="SwitchForUpgradeRequest"/></param>
        /// <returns><see cref="SwitchForUpgradeResponse"/></returns>
        public SwitchForUpgradeResponse SwitchForUpgradeSync(SwitchForUpgradeRequest req)
        {
            return InternalRequestAsync<SwitchForUpgradeResponse>(req, "SwitchForUpgrade")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级数据库代理版本
        /// </summary>
        /// <param name="req"><see cref="UpgradeCDBProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeCDBProxyVersionResponse"/></returns>
        public Task<UpgradeCDBProxyVersionResponse> UpgradeCDBProxyVersion(UpgradeCDBProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeCDBProxyVersionResponse>(req, "UpgradeCDBProxyVersion");
        }

        /// <summary>
        /// 升级数据库代理版本
        /// </summary>
        /// <param name="req"><see cref="UpgradeCDBProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeCDBProxyVersionResponse"/></returns>
        public UpgradeCDBProxyVersionResponse UpgradeCDBProxyVersionSync(UpgradeCDBProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeCDBProxyVersionResponse>(req, "UpgradeCDBProxyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(UpgradeDBInstance)用于升级或降级云数据库实例的配置，实例类型支持主实例、灾备实例和只读实例。如果进行迁移业务，请一定填写实例规格（CPU、内存），不然系统会默认以最小允许规格传参。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public Task<UpgradeDBInstanceResponse> UpgradeDBInstance(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance");
        }

        /// <summary>
        /// 本接口(UpgradeDBInstance)用于升级或降级云数据库实例的配置，实例类型支持主实例、灾备实例和只读实例。如果进行迁移业务，请一定填写实例规格（CPU、内存），不然系统会默认以最小允许规格传参。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public UpgradeDBInstanceResponse UpgradeDBInstanceSync(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(UpgradeDBInstanceEngineVersion)用于升级云数据库实例版本，实例类型支持主实例、灾备实例和只读实例。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceEngineVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceEngineVersionResponse"/></returns>
        public Task<UpgradeDBInstanceEngineVersionResponse> UpgradeDBInstanceEngineVersion(UpgradeDBInstanceEngineVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceEngineVersionResponse>(req, "UpgradeDBInstanceEngineVersion");
        }

        /// <summary>
        /// 本接口(UpgradeDBInstanceEngineVersion)用于升级云数据库实例版本，实例类型支持主实例、灾备实例和只读实例。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceEngineVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceEngineVersionResponse"/></returns>
        public UpgradeDBInstanceEngineVersionResponse UpgradeDBInstanceEngineVersionSync(UpgradeDBInstanceEngineVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceEngineVersionResponse>(req, "UpgradeDBInstanceEngineVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(VerifyRootAccount)用于校验云数据库实例的 ROOT 账号是否有足够的权限进行授权操作。
        /// </summary>
        /// <param name="req"><see cref="VerifyRootAccountRequest"/></param>
        /// <returns><see cref="VerifyRootAccountResponse"/></returns>
        public Task<VerifyRootAccountResponse> VerifyRootAccount(VerifyRootAccountRequest req)
        {
            return InternalRequestAsync<VerifyRootAccountResponse>(req, "VerifyRootAccount");
        }

        /// <summary>
        /// 本接口(VerifyRootAccount)用于校验云数据库实例的 ROOT 账号是否有足够的权限进行授权操作。
        /// </summary>
        /// <param name="req"><see cref="VerifyRootAccountRequest"/></param>
        /// <returns><see cref="VerifyRootAccountResponse"/></returns>
        public VerifyRootAccountResponse VerifyRootAccountSync(VerifyRootAccountRequest req)
        {
            return InternalRequestAsync<VerifyRootAccountResponse>(req, "VerifyRootAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
