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

namespace TencentCloud.Lighthouse.V20200324
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lighthouse.V20200324.Models;

   public class LighthouseClient : AbstractClient{

       private const string endpoint = "lighthouse.tencentcloudapi.com";
       private const string version = "2020-03-24";
       private const string sdkVersion = "SDK_NET_3.0.1361";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LighthouseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LighthouseClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（ApplyDiskBackup）用于回滚指定云硬盘的备份点。
        /// * 仅支持回滚到原云硬盘。
        /// * 用于回滚的云硬盘备份点必须处于 NORMAL 状态。
        ///   云硬盘备份点状态可以通过  [DescribeDiskBackups](https://cloud.tencent.com/document/api/1207/84379) 接口查询。
        /// * 回滚云硬盘备份点时，云硬盘的状态必须为 UNATTACHED或ATTACHED。
        ///   云硬盘状态可通过 [DescribeDisks](https://cloud.tencent.com/document/api/1207/66093) 接口查询。
        /// * 如果云硬盘处于 ATTACHED状态，相关RUNNING 状态的实例会强制关机，然后回滚云硬盘备份点。
        /// </summary>
        /// <param name="req"><see cref="ApplyDiskBackupRequest"/></param>
        /// <returns><see cref="ApplyDiskBackupResponse"/></returns>
        public Task<ApplyDiskBackupResponse> ApplyDiskBackup(ApplyDiskBackupRequest req)
        {
            return InternalRequestAsync<ApplyDiskBackupResponse>(req, "ApplyDiskBackup");
        }

        /// <summary>
        /// 本接口（ApplyDiskBackup）用于回滚指定云硬盘的备份点。
        /// * 仅支持回滚到原云硬盘。
        /// * 用于回滚的云硬盘备份点必须处于 NORMAL 状态。
        ///   云硬盘备份点状态可以通过  [DescribeDiskBackups](https://cloud.tencent.com/document/api/1207/84379) 接口查询。
        /// * 回滚云硬盘备份点时，云硬盘的状态必须为 UNATTACHED或ATTACHED。
        ///   云硬盘状态可通过 [DescribeDisks](https://cloud.tencent.com/document/api/1207/66093) 接口查询。
        /// * 如果云硬盘处于 ATTACHED状态，相关RUNNING 状态的实例会强制关机，然后回滚云硬盘备份点。
        /// </summary>
        /// <param name="req"><see cref="ApplyDiskBackupRequest"/></param>
        /// <returns><see cref="ApplyDiskBackupResponse"/></returns>
        public ApplyDiskBackupResponse ApplyDiskBackupSync(ApplyDiskBackupRequest req)
        {
            return InternalRequestAsync<ApplyDiskBackupResponse>(req, "ApplyDiskBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ApplyFirewallTemplate) 用于应用防火墙模板到多个实例。
        /// </summary>
        /// <param name="req"><see cref="ApplyFirewallTemplateRequest"/></param>
        /// <returns><see cref="ApplyFirewallTemplateResponse"/></returns>
        public Task<ApplyFirewallTemplateResponse> ApplyFirewallTemplate(ApplyFirewallTemplateRequest req)
        {
            return InternalRequestAsync<ApplyFirewallTemplateResponse>(req, "ApplyFirewallTemplate");
        }

        /// <summary>
        /// 本接口 (ApplyFirewallTemplate) 用于应用防火墙模板到多个实例。
        /// </summary>
        /// <param name="req"><see cref="ApplyFirewallTemplateRequest"/></param>
        /// <returns><see cref="ApplyFirewallTemplateResponse"/></returns>
        public ApplyFirewallTemplateResponse ApplyFirewallTemplateSync(ApplyFirewallTemplateRequest req)
        {
            return InternalRequestAsync<ApplyFirewallTemplateResponse>(req, "ApplyFirewallTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ApplyInstanceSnapshot）用于回滚指定实例的系统盘快照。
        /// - 仅支持回滚到原系统盘。
        /// - 用于回滚的快照必须处于 NORMAL 状态。快照状态可以通过 [DescribeSnapshots](https://cloud.tencent.com/document/product/1207/54388) 接口查询，见输出参数中 SnapshotState 字段解释。
        /// - 回滚快照时，实例的状态必须为 STOPPED 或 RUNNING，可通过 [DescribeInstances](https://cloud.tencent.com/document/product/1207/47573) 接口查询实例状态。处于 RUNNING 状态的实例会强制关机，然后回滚快照。
        /// </summary>
        /// <param name="req"><see cref="ApplyInstanceSnapshotRequest"/></param>
        /// <returns><see cref="ApplyInstanceSnapshotResponse"/></returns>
        public Task<ApplyInstanceSnapshotResponse> ApplyInstanceSnapshot(ApplyInstanceSnapshotRequest req)
        {
            return InternalRequestAsync<ApplyInstanceSnapshotResponse>(req, "ApplyInstanceSnapshot");
        }

        /// <summary>
        /// 本接口（ApplyInstanceSnapshot）用于回滚指定实例的系统盘快照。
        /// - 仅支持回滚到原系统盘。
        /// - 用于回滚的快照必须处于 NORMAL 状态。快照状态可以通过 [DescribeSnapshots](https://cloud.tencent.com/document/product/1207/54388) 接口查询，见输出参数中 SnapshotState 字段解释。
        /// - 回滚快照时，实例的状态必须为 STOPPED 或 RUNNING，可通过 [DescribeInstances](https://cloud.tencent.com/document/product/1207/47573) 接口查询实例状态。处于 RUNNING 状态的实例会强制关机，然后回滚快照。
        /// </summary>
        /// <param name="req"><see cref="ApplyInstanceSnapshotRequest"/></param>
        /// <returns><see cref="ApplyInstanceSnapshotResponse"/></returns>
        public ApplyInstanceSnapshotResponse ApplyInstanceSnapshotSync(ApplyInstanceSnapshotRequest req)
        {
            return InternalRequestAsync<ApplyInstanceSnapshotResponse>(req, "ApplyInstanceSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssociateInstancesKeyPairs）用于绑定用户指定密钥对到实例。
        /// * 只支持 [RUNNING, STOPPED] 状态的 LINUX_UNIX 操作系统的实例。处于 RUNNING 状态的实例会强制关机，然后绑定。
        /// * 将密钥的公钥写入到实例的 SSH 配置当中，用户就可以通过该密钥的私钥来登录实例。
        /// * 如果实例原来绑定过密钥，那么原来的密钥将失效。
        /// * 如果实例原来是通过密码登录，绑定密钥后无法使用密码登录。
        /// * 支持批量操作。每次请求批量实例的上限为 100。如果批量实例存在不允许操作的实例，操作会以特定错误码返回。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="AssociateInstancesKeyPairsResponse"/></returns>
        public Task<AssociateInstancesKeyPairsResponse> AssociateInstancesKeyPairs(AssociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<AssociateInstancesKeyPairsResponse>(req, "AssociateInstancesKeyPairs");
        }

        /// <summary>
        /// 本接口（AssociateInstancesKeyPairs）用于绑定用户指定密钥对到实例。
        /// * 只支持 [RUNNING, STOPPED] 状态的 LINUX_UNIX 操作系统的实例。处于 RUNNING 状态的实例会强制关机，然后绑定。
        /// * 将密钥的公钥写入到实例的 SSH 配置当中，用户就可以通过该密钥的私钥来登录实例。
        /// * 如果实例原来绑定过密钥，那么原来的密钥将失效。
        /// * 如果实例原来是通过密码登录，绑定密钥后无法使用密码登录。
        /// * 支持批量操作。每次请求批量实例的上限为 100。如果批量实例存在不允许操作的实例，操作会以特定错误码返回。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="AssociateInstancesKeyPairsResponse"/></returns>
        public AssociateInstancesKeyPairsResponse AssociateInstancesKeyPairsSync(AssociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<AssociateInstancesKeyPairsResponse>(req, "AssociateInstancesKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (AttachCcn) 用于建立与云联网的关联。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnRequest"/></param>
        /// <returns><see cref="AttachCcnResponse"/></returns>
        public Task<AttachCcnResponse> AttachCcn(AttachCcnRequest req)
        {
            return InternalRequestAsync<AttachCcnResponse>(req, "AttachCcn");
        }

        /// <summary>
        /// 本接口 (AttachCcn) 用于建立与云联网的关联。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnRequest"/></param>
        /// <returns><see cref="AttachCcnResponse"/></returns>
        public AttachCcnResponse AttachCcnSync(AttachCcnRequest req)
        {
            return InternalRequestAsync<AttachCcnResponse>(req, "AttachCcn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AttachDisks）用于挂载一个或多个云硬盘。
        /// <li>只能挂载磁盘状态（DiskState）处于待挂载（UNATTACHED）状态的云硬盘，磁盘状态可通过接口查询云硬盘（DescribeDisks）获取</li>
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public Task<AttachDisksResponse> AttachDisks(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks");
        }

        /// <summary>
        /// 本接口（AttachDisks）用于挂载一个或多个云硬盘。
        /// <li>只能挂载磁盘状态（DiskState）处于待挂载（UNATTACHED）状态的云硬盘，磁盘状态可通过接口查询云硬盘（DescribeDisks）获取</li>
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public AttachDisksResponse AttachDisksSync(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CancelShareBlueprintAcrossAccounts）用于取消镜像跨账号共享。
        /// 指定的镜像ID必须为自定义镜像，且指定账号ID必须已进行共享。
        /// </summary>
        /// <param name="req"><see cref="CancelShareBlueprintAcrossAccountsRequest"/></param>
        /// <returns><see cref="CancelShareBlueprintAcrossAccountsResponse"/></returns>
        public Task<CancelShareBlueprintAcrossAccountsResponse> CancelShareBlueprintAcrossAccounts(CancelShareBlueprintAcrossAccountsRequest req)
        {
            return InternalRequestAsync<CancelShareBlueprintAcrossAccountsResponse>(req, "CancelShareBlueprintAcrossAccounts");
        }

        /// <summary>
        /// 本接口（CancelShareBlueprintAcrossAccounts）用于取消镜像跨账号共享。
        /// 指定的镜像ID必须为自定义镜像，且指定账号ID必须已进行共享。
        /// </summary>
        /// <param name="req"><see cref="CancelShareBlueprintAcrossAccountsRequest"/></param>
        /// <returns><see cref="CancelShareBlueprintAcrossAccountsResponse"/></returns>
        public CancelShareBlueprintAcrossAccountsResponse CancelShareBlueprintAcrossAccountsSync(CancelShareBlueprintAcrossAccountsRequest req)
        {
            return InternalRequestAsync<CancelShareBlueprintAcrossAccountsResponse>(req, "CancelShareBlueprintAcrossAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateBlueprint) 用于创建镜像。
        /// </summary>
        /// <param name="req"><see cref="CreateBlueprintRequest"/></param>
        /// <returns><see cref="CreateBlueprintResponse"/></returns>
        public Task<CreateBlueprintResponse> CreateBlueprint(CreateBlueprintRequest req)
        {
            return InternalRequestAsync<CreateBlueprintResponse>(req, "CreateBlueprint");
        }

        /// <summary>
        /// 本接口 (CreateBlueprint) 用于创建镜像。
        /// </summary>
        /// <param name="req"><see cref="CreateBlueprintRequest"/></param>
        /// <returns><see cref="CreateBlueprintResponse"/></returns>
        public CreateBlueprintResponse CreateBlueprintSync(CreateBlueprintRequest req)
        {
            return InternalRequestAsync<CreateBlueprintResponse>(req, "CreateBlueprint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( CreateDiskBackup  ) 用于创建指定云硬盘（当前只支持数据盘）的备份点。
        /// </summary>
        /// <param name="req"><see cref="CreateDiskBackupRequest"/></param>
        /// <returns><see cref="CreateDiskBackupResponse"/></returns>
        public Task<CreateDiskBackupResponse> CreateDiskBackup(CreateDiskBackupRequest req)
        {
            return InternalRequestAsync<CreateDiskBackupResponse>(req, "CreateDiskBackup");
        }

        /// <summary>
        /// 本接口 ( CreateDiskBackup  ) 用于创建指定云硬盘（当前只支持数据盘）的备份点。
        /// </summary>
        /// <param name="req"><see cref="CreateDiskBackupRequest"/></param>
        /// <returns><see cref="CreateDiskBackupResponse"/></returns>
        public CreateDiskBackupResponse CreateDiskBackupSync(CreateDiskBackupRequest req)
        {
            return InternalRequestAsync<CreateDiskBackupResponse>(req, "CreateDiskBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateDisks)用于创建一个或多个云硬盘。
        /// </summary>
        /// <param name="req"><see cref="CreateDisksRequest"/></param>
        /// <returns><see cref="CreateDisksResponse"/></returns>
        public Task<CreateDisksResponse> CreateDisks(CreateDisksRequest req)
        {
            return InternalRequestAsync<CreateDisksResponse>(req, "CreateDisks");
        }

        /// <summary>
        /// 本接口(CreateDisks)用于创建一个或多个云硬盘。
        /// </summary>
        /// <param name="req"><see cref="CreateDisksRequest"/></param>
        /// <returns><see cref="CreateDisksResponse"/></returns>
        public CreateDisksResponse CreateDisksSync(CreateDisksRequest req)
        {
            return InternalRequestAsync<CreateDisksResponse>(req, "CreateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateFirewallRules）用于在实例上添加防火墙规则。
        /// 
        /// 
        /// * FirewallVersion 为防火墙版本号，用户每次更新防火墙规则版本会自动加1，防止您更新的规则已过期，不填不考虑冲突。FirewallVersion可通过[DescribeFirewallRules](https://cloud.tencent.com/document/api/1207/48252)接口返回值中的FirewallVersion获取。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ICMPv6，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="CreateFirewallRulesRequest"/></param>
        /// <returns><see cref="CreateFirewallRulesResponse"/></returns>
        public Task<CreateFirewallRulesResponse> CreateFirewallRules(CreateFirewallRulesRequest req)
        {
            return InternalRequestAsync<CreateFirewallRulesResponse>(req, "CreateFirewallRules");
        }

        /// <summary>
        /// 本接口（CreateFirewallRules）用于在实例上添加防火墙规则。
        /// 
        /// 
        /// * FirewallVersion 为防火墙版本号，用户每次更新防火墙规则版本会自动加1，防止您更新的规则已过期，不填不考虑冲突。FirewallVersion可通过[DescribeFirewallRules](https://cloud.tencent.com/document/api/1207/48252)接口返回值中的FirewallVersion获取。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ICMPv6，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="CreateFirewallRulesRequest"/></param>
        /// <returns><see cref="CreateFirewallRulesResponse"/></returns>
        public CreateFirewallRulesResponse CreateFirewallRulesSync(CreateFirewallRulesRequest req)
        {
            return InternalRequestAsync<CreateFirewallRulesResponse>(req, "CreateFirewallRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateFirewallTemplate) 用于创建防火墙模板。
        /// </summary>
        /// <param name="req"><see cref="CreateFirewallTemplateRequest"/></param>
        /// <returns><see cref="CreateFirewallTemplateResponse"/></returns>
        public Task<CreateFirewallTemplateResponse> CreateFirewallTemplate(CreateFirewallTemplateRequest req)
        {
            return InternalRequestAsync<CreateFirewallTemplateResponse>(req, "CreateFirewallTemplate");
        }

        /// <summary>
        /// 本接口 (CreateFirewallTemplate) 用于创建防火墙模板。
        /// </summary>
        /// <param name="req"><see cref="CreateFirewallTemplateRequest"/></param>
        /// <returns><see cref="CreateFirewallTemplateResponse"/></returns>
        public CreateFirewallTemplateResponse CreateFirewallTemplateSync(CreateFirewallTemplateRequest req)
        {
            return InternalRequestAsync<CreateFirewallTemplateResponse>(req, "CreateFirewallTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateFirewallTemplateRules) 用于创建防火墙模板规则。
        /// </summary>
        /// <param name="req"><see cref="CreateFirewallTemplateRulesRequest"/></param>
        /// <returns><see cref="CreateFirewallTemplateRulesResponse"/></returns>
        public Task<CreateFirewallTemplateRulesResponse> CreateFirewallTemplateRules(CreateFirewallTemplateRulesRequest req)
        {
            return InternalRequestAsync<CreateFirewallTemplateRulesResponse>(req, "CreateFirewallTemplateRules");
        }

        /// <summary>
        /// 本接口 (CreateFirewallTemplateRules) 用于创建防火墙模板规则。
        /// </summary>
        /// <param name="req"><see cref="CreateFirewallTemplateRulesRequest"/></param>
        /// <returns><see cref="CreateFirewallTemplateRulesResponse"/></returns>
        public CreateFirewallTemplateRulesResponse CreateFirewallTemplateRulesSync(CreateFirewallTemplateRulesRequest req)
        {
            return InternalRequestAsync<CreateFirewallTemplateRulesResponse>(req, "CreateFirewallTemplateRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateInstanceSnapshot）用于创建指定实例的系统盘快照。
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceSnapshotRequest"/></param>
        /// <returns><see cref="CreateInstanceSnapshotResponse"/></returns>
        public Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshot(CreateInstanceSnapshotRequest req)
        {
            return InternalRequestAsync<CreateInstanceSnapshotResponse>(req, "CreateInstanceSnapshot");
        }

        /// <summary>
        /// 本接口（CreateInstanceSnapshot）用于创建指定实例的系统盘快照。
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceSnapshotRequest"/></param>
        /// <returns><see cref="CreateInstanceSnapshotResponse"/></returns>
        public CreateInstanceSnapshotResponse CreateInstanceSnapshotSync(CreateInstanceSnapshotRequest req)
        {
            return InternalRequestAsync<CreateInstanceSnapshotResponse>(req, "CreateInstanceSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateInstances)用于创建一个或多个指定套餐的轻量应用服务器实例。
        /// *创建实例时，如指定实例访问域名信息时，本次创建请求，仅支持购买一台实例。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances");
        }

        /// <summary>
        /// 本接口(CreateInstances)用于创建一个或多个指定套餐的轻量应用服务器实例。
        /// *创建实例时，如指定实例访问域名信息时，本次创建请求，仅支持购买一台实例。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateKeyPair）用于创建一个密钥对。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public Task<CreateKeyPairResponse> CreateKeyPair(CreateKeyPairRequest req)
        {
            return InternalRequestAsync<CreateKeyPairResponse>(req, "CreateKeyPair");
        }

        /// <summary>
        /// 本接口（CreateKeyPair）用于创建一个密钥对。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public CreateKeyPairResponse CreateKeyPairSync(CreateKeyPairRequest req)
        {
            return InternalRequestAsync<CreateKeyPairResponse>(req, "CreateKeyPair")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateMcpServer）用于创建MCP Server。
        /// - 本接口为异步接口，请求发送成功后会返回一个 McpServerId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeMcpServers 接口查询。
        /// </summary>
        /// <param name="req"><see cref="CreateMcpServerRequest"/></param>
        /// <returns><see cref="CreateMcpServerResponse"/></returns>
        public Task<CreateMcpServerResponse> CreateMcpServer(CreateMcpServerRequest req)
        {
            return InternalRequestAsync<CreateMcpServerResponse>(req, "CreateMcpServer");
        }

        /// <summary>
        /// 本接口（CreateMcpServer）用于创建MCP Server。
        /// - 本接口为异步接口，请求发送成功后会返回一个 McpServerId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeMcpServers 接口查询。
        /// </summary>
        /// <param name="req"><see cref="CreateMcpServerRequest"/></param>
        /// <returns><see cref="CreateMcpServerResponse"/></returns>
        public CreateMcpServerResponse CreateMcpServerSync(CreateMcpServerRequest req)
        {
            return InternalRequestAsync<CreateMcpServerResponse>(req, "CreateMcpServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DeleteBlueprints) 用于删除镜像。可删除的镜像应满足如下条件：
        /// 1、删除镜像接口需要镜像状态为NORMAL（正常）、ISOLATED（已隔离）、CREATEFAILED（创建失败）、SYNCING_FAILED（目的地域同步失败），其他状态下的镜像不支持删除操作。镜像状态，可通过[DescribeBlueprints](https://cloud.tencent.com/document/product/1207/47689)接口返回值中的BlueprintState获取。
        /// 2、仅支持删除自定义镜像。
        /// </summary>
        /// <param name="req"><see cref="DeleteBlueprintsRequest"/></param>
        /// <returns><see cref="DeleteBlueprintsResponse"/></returns>
        public Task<DeleteBlueprintsResponse> DeleteBlueprints(DeleteBlueprintsRequest req)
        {
            return InternalRequestAsync<DeleteBlueprintsResponse>(req, "DeleteBlueprints");
        }

        /// <summary>
        /// 本接口 (DeleteBlueprints) 用于删除镜像。可删除的镜像应满足如下条件：
        /// 1、删除镜像接口需要镜像状态为NORMAL（正常）、ISOLATED（已隔离）、CREATEFAILED（创建失败）、SYNCING_FAILED（目的地域同步失败），其他状态下的镜像不支持删除操作。镜像状态，可通过[DescribeBlueprints](https://cloud.tencent.com/document/product/1207/47689)接口返回值中的BlueprintState获取。
        /// 2、仅支持删除自定义镜像。
        /// </summary>
        /// <param name="req"><see cref="DeleteBlueprintsRequest"/></param>
        /// <returns><see cref="DeleteBlueprintsResponse"/></returns>
        public DeleteBlueprintsResponse DeleteBlueprintsSync(DeleteBlueprintsRequest req)
        {
            return InternalRequestAsync<DeleteBlueprintsResponse>(req, "DeleteBlueprints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteDiskBackups）用于删除云硬盘备份点。
        /// 云硬盘备份点必须处于 NORMAL 状态，云硬盘备份点状态可以通过 [DescribeDiskBackups](https://cloud.tencent.com/document/api/1207/84379)接口查询，见输出参数中 DiskBackupState 字段解释。
        /// </summary>
        /// <param name="req"><see cref="DeleteDiskBackupsRequest"/></param>
        /// <returns><see cref="DeleteDiskBackupsResponse"/></returns>
        public Task<DeleteDiskBackupsResponse> DeleteDiskBackups(DeleteDiskBackupsRequest req)
        {
            return InternalRequestAsync<DeleteDiskBackupsResponse>(req, "DeleteDiskBackups");
        }

        /// <summary>
        /// 本接口（DeleteDiskBackups）用于删除云硬盘备份点。
        /// 云硬盘备份点必须处于 NORMAL 状态，云硬盘备份点状态可以通过 [DescribeDiskBackups](https://cloud.tencent.com/document/api/1207/84379)接口查询，见输出参数中 DiskBackupState 字段解释。
        /// </summary>
        /// <param name="req"><see cref="DeleteDiskBackupsRequest"/></param>
        /// <returns><see cref="DeleteDiskBackupsResponse"/></returns>
        public DeleteDiskBackupsResponse DeleteDiskBackupsSync(DeleteDiskBackupsRequest req)
        {
            return InternalRequestAsync<DeleteDiskBackupsResponse>(req, "DeleteDiskBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteFirewallRules）用于删除实例的防火墙规则。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接删除指定的规则。FirewallVersion可通过[DescribeFirewallRules](https://cloud.tencent.com/document/api/1207/48252)接口返回值中的FirewallVersion获取。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ICMPv6，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="DeleteFirewallRulesRequest"/></param>
        /// <returns><see cref="DeleteFirewallRulesResponse"/></returns>
        public Task<DeleteFirewallRulesResponse> DeleteFirewallRules(DeleteFirewallRulesRequest req)
        {
            return InternalRequestAsync<DeleteFirewallRulesResponse>(req, "DeleteFirewallRules");
        }

        /// <summary>
        /// 本接口（DeleteFirewallRules）用于删除实例的防火墙规则。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接删除指定的规则。FirewallVersion可通过[DescribeFirewallRules](https://cloud.tencent.com/document/api/1207/48252)接口返回值中的FirewallVersion获取。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ICMPv6，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="DeleteFirewallRulesRequest"/></param>
        /// <returns><see cref="DeleteFirewallRulesResponse"/></returns>
        public DeleteFirewallRulesResponse DeleteFirewallRulesSync(DeleteFirewallRulesRequest req)
        {
            return InternalRequestAsync<DeleteFirewallRulesResponse>(req, "DeleteFirewallRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DeleteFirewallTemplate) 用于删除防火墙模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteFirewallTemplateRequest"/></param>
        /// <returns><see cref="DeleteFirewallTemplateResponse"/></returns>
        public Task<DeleteFirewallTemplateResponse> DeleteFirewallTemplate(DeleteFirewallTemplateRequest req)
        {
            return InternalRequestAsync<DeleteFirewallTemplateResponse>(req, "DeleteFirewallTemplate");
        }

        /// <summary>
        /// 本接口 (DeleteFirewallTemplate) 用于删除防火墙模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteFirewallTemplateRequest"/></param>
        /// <returns><see cref="DeleteFirewallTemplateResponse"/></returns>
        public DeleteFirewallTemplateResponse DeleteFirewallTemplateSync(DeleteFirewallTemplateRequest req)
        {
            return InternalRequestAsync<DeleteFirewallTemplateResponse>(req, "DeleteFirewallTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DeleteFirewallTemplateRules) 用于删除防火墙模板规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteFirewallTemplateRulesRequest"/></param>
        /// <returns><see cref="DeleteFirewallTemplateRulesResponse"/></returns>
        public Task<DeleteFirewallTemplateRulesResponse> DeleteFirewallTemplateRules(DeleteFirewallTemplateRulesRequest req)
        {
            return InternalRequestAsync<DeleteFirewallTemplateRulesResponse>(req, "DeleteFirewallTemplateRules");
        }

        /// <summary>
        /// 本接口 (DeleteFirewallTemplateRules) 用于删除防火墙模板规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteFirewallTemplateRulesRequest"/></param>
        /// <returns><see cref="DeleteFirewallTemplateRulesResponse"/></returns>
        public DeleteFirewallTemplateRulesResponse DeleteFirewallTemplateRulesSync(DeleteFirewallTemplateRulesRequest req)
        {
            return InternalRequestAsync<DeleteFirewallTemplateRulesResponse>(req, "DeleteFirewallTemplateRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteKeyPairs）用于删除密钥对。
        /// - 不能删除已被实例或镜像引用的密钥对，删除之前需要确保没有被任何实例和镜像引用。
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public Task<DeleteKeyPairsResponse> DeleteKeyPairs(DeleteKeyPairsRequest req)
        {
            return InternalRequestAsync<DeleteKeyPairsResponse>(req, "DeleteKeyPairs");
        }

        /// <summary>
        /// 本接口（DeleteKeyPairs）用于删除密钥对。
        /// - 不能删除已被实例或镜像引用的密钥对，删除之前需要确保没有被任何实例和镜像引用。
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public DeleteKeyPairsResponse DeleteKeyPairsSync(DeleteKeyPairsRequest req)
        {
            return InternalRequestAsync<DeleteKeyPairsResponse>(req, "DeleteKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteSnapshots）用于删除快照。
        /// 快照必须处于 NORMAL 状态，快照状态可以通过 <a href="https://cloud.tencent.com/document/product/1207/54388" target="_blank">DescribeSnapshots</a> 接口查询，见输出参数中 SnapshotState 字段解释。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots");
        }

        /// <summary>
        /// 本接口（DeleteSnapshots）用于删除快照。
        /// 快照必须处于 NORMAL 状态，快照状态可以通过 <a href="https://cloud.tencent.com/document/product/1207/54388" target="_blank">DescribeSnapshots</a> 接口查询，见输出参数中 SnapshotState 字段解释。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public DeleteSnapshotsResponse DeleteSnapshotsSync(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAllScenes)用于查询全地域使用场景列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllScenesRequest"/></param>
        /// <returns><see cref="DescribeAllScenesResponse"/></returns>
        public Task<DescribeAllScenesResponse> DescribeAllScenes(DescribeAllScenesRequest req)
        {
            return InternalRequestAsync<DescribeAllScenesResponse>(req, "DescribeAllScenes");
        }

        /// <summary>
        /// 本接口(DescribeAllScenes)用于查询全地域使用场景列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllScenesRequest"/></param>
        /// <returns><see cref="DescribeAllScenesResponse"/></returns>
        public DescribeAllScenesResponse DescribeAllScenesSync(DescribeAllScenesRequest req)
        {
            return InternalRequestAsync<DescribeAllScenesResponse>(req, "DescribeAllScenes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBlueprintInstances）用于查询镜像实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintInstancesRequest"/></param>
        /// <returns><see cref="DescribeBlueprintInstancesResponse"/></returns>
        public Task<DescribeBlueprintInstancesResponse> DescribeBlueprintInstances(DescribeBlueprintInstancesRequest req)
        {
            return InternalRequestAsync<DescribeBlueprintInstancesResponse>(req, "DescribeBlueprintInstances");
        }

        /// <summary>
        /// 本接口（DescribeBlueprintInstances）用于查询镜像实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintInstancesRequest"/></param>
        /// <returns><see cref="DescribeBlueprintInstancesResponse"/></returns>
        public DescribeBlueprintInstancesResponse DescribeBlueprintInstancesSync(DescribeBlueprintInstancesRequest req)
        {
            return InternalRequestAsync<DescribeBlueprintInstancesResponse>(req, "DescribeBlueprintInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBlueprints）用于查询镜像信息。该接口返回的镜像类型有：自定义镜像、共享镜像、公共镜像。
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeBlueprintsResponse"/></returns>
        public Task<DescribeBlueprintsResponse> DescribeBlueprints(DescribeBlueprintsRequest req)
        {
            return InternalRequestAsync<DescribeBlueprintsResponse>(req, "DescribeBlueprints");
        }

        /// <summary>
        /// 本接口（DescribeBlueprints）用于查询镜像信息。该接口返回的镜像类型有：自定义镜像、共享镜像、公共镜像。
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeBlueprintsResponse"/></returns>
        public DescribeBlueprintsResponse DescribeBlueprintsSync(DescribeBlueprintsRequest req)
        {
            return InternalRequestAsync<DescribeBlueprintsResponse>(req, "DescribeBlueprints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBundleDiscount）用于查询套餐折扣信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBundleDiscountRequest"/></param>
        /// <returns><see cref="DescribeBundleDiscountResponse"/></returns>
        public Task<DescribeBundleDiscountResponse> DescribeBundleDiscount(DescribeBundleDiscountRequest req)
        {
            return InternalRequestAsync<DescribeBundleDiscountResponse>(req, "DescribeBundleDiscount");
        }

        /// <summary>
        /// 本接口（DescribeBundleDiscount）用于查询套餐折扣信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBundleDiscountRequest"/></param>
        /// <returns><see cref="DescribeBundleDiscountResponse"/></returns>
        public DescribeBundleDiscountResponse DescribeBundleDiscountSync(DescribeBundleDiscountRequest req)
        {
            return InternalRequestAsync<DescribeBundleDiscountResponse>(req, "DescribeBundleDiscount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBundles）用于查询套餐信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBundlesRequest"/></param>
        /// <returns><see cref="DescribeBundlesResponse"/></returns>
        public Task<DescribeBundlesResponse> DescribeBundles(DescribeBundlesRequest req)
        {
            return InternalRequestAsync<DescribeBundlesResponse>(req, "DescribeBundles");
        }

        /// <summary>
        /// 本接口（DescribeBundles）用于查询套餐信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBundlesRequest"/></param>
        /// <returns><see cref="DescribeBundlesResponse"/></returns>
        public DescribeBundlesResponse DescribeBundlesSync(DescribeBundlesRequest req)
        {
            return InternalRequestAsync<DescribeBundlesResponse>(req, "DescribeBundles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeCcnAttachedInstances) 用于查询云联网关联的实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public Task<DescribeCcnAttachedInstancesResponse> DescribeCcnAttachedInstances(DescribeCcnAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCcnAttachedInstancesResponse>(req, "DescribeCcnAttachedInstances");
        }

        /// <summary>
        /// 本接口 (DescribeCcnAttachedInstances) 用于查询云联网关联的实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public DescribeCcnAttachedInstancesResponse DescribeCcnAttachedInstancesSync(DescribeCcnAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCcnAttachedInstancesResponse>(req, "DescribeCcnAttachedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDiskBackups）用于查询云硬盘备份点的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskBackupsRequest"/></param>
        /// <returns><see cref="DescribeDiskBackupsResponse"/></returns>
        public Task<DescribeDiskBackupsResponse> DescribeDiskBackups(DescribeDiskBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDiskBackupsResponse>(req, "DescribeDiskBackups");
        }

        /// <summary>
        /// 本接口（DescribeDiskBackups）用于查询云硬盘备份点的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskBackupsRequest"/></param>
        /// <returns><see cref="DescribeDiskBackupsResponse"/></returns>
        public DescribeDiskBackupsResponse DescribeDiskBackupsSync(DescribeDiskBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDiskBackupsResponse>(req, "DescribeDiskBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDiskBackupsDeniedActions）用于查询一个或多个云硬盘备份点的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskBackupsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDiskBackupsDeniedActionsResponse"/></returns>
        public Task<DescribeDiskBackupsDeniedActionsResponse> DescribeDiskBackupsDeniedActions(DescribeDiskBackupsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeDiskBackupsDeniedActionsResponse>(req, "DescribeDiskBackupsDeniedActions");
        }

        /// <summary>
        /// 本接口（DescribeDiskBackupsDeniedActions）用于查询一个或多个云硬盘备份点的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskBackupsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDiskBackupsDeniedActionsResponse"/></returns>
        public DescribeDiskBackupsDeniedActionsResponse DescribeDiskBackupsDeniedActionsSync(DescribeDiskBackupsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeDiskBackupsDeniedActionsResponse>(req, "DescribeDiskBackupsDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDiskConfigs）用于查询云硬盘配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigsRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigsResponse"/></returns>
        public Task<DescribeDiskConfigsResponse> DescribeDiskConfigs(DescribeDiskConfigsRequest req)
        {
            return InternalRequestAsync<DescribeDiskConfigsResponse>(req, "DescribeDiskConfigs");
        }

        /// <summary>
        /// 本接口（DescribeDiskConfigs）用于查询云硬盘配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigsRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigsResponse"/></returns>
        public DescribeDiskConfigsResponse DescribeDiskConfigsSync(DescribeDiskConfigsRequest req)
        {
            return InternalRequestAsync<DescribeDiskConfigsResponse>(req, "DescribeDiskConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDiskDiscount)用于查询云硬盘折扣信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskDiscountRequest"/></param>
        /// <returns><see cref="DescribeDiskDiscountResponse"/></returns>
        public Task<DescribeDiskDiscountResponse> DescribeDiskDiscount(DescribeDiskDiscountRequest req)
        {
            return InternalRequestAsync<DescribeDiskDiscountResponse>(req, "DescribeDiskDiscount");
        }

        /// <summary>
        /// 本接口(DescribeDiskDiscount)用于查询云硬盘折扣信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskDiscountRequest"/></param>
        /// <returns><see cref="DescribeDiskDiscountResponse"/></returns>
        public DescribeDiskDiscountResponse DescribeDiskDiscountSync(DescribeDiskDiscountRequest req)
        {
            return InternalRequestAsync<DescribeDiskDiscountResponse>(req, "DescribeDiskDiscount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDisks）用于查询云硬盘信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public Task<DescribeDisksResponse> DescribeDisks(DescribeDisksRequest req)
        {
            return InternalRequestAsync<DescribeDisksResponse>(req, "DescribeDisks");
        }

        /// <summary>
        /// 本接口（DescribeDisks）用于查询云硬盘信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public DescribeDisksResponse DescribeDisksSync(DescribeDisksRequest req)
        {
            return InternalRequestAsync<DescribeDisksResponse>(req, "DescribeDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDisksDeniedActions）用于查询一个或多个云硬盘的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDisksDeniedActionsResponse"/></returns>
        public Task<DescribeDisksDeniedActionsResponse> DescribeDisksDeniedActions(DescribeDisksDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeDisksDeniedActionsResponse>(req, "DescribeDisksDeniedActions");
        }

        /// <summary>
        /// 本接口（DescribeDisksDeniedActions）用于查询一个或多个云硬盘的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDisksDeniedActionsResponse"/></returns>
        public DescribeDisksDeniedActionsResponse DescribeDisksDeniedActionsSync(DescribeDisksDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeDisksDeniedActionsResponse>(req, "DescribeDisksDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDisksReturnable）用于查询云硬盘是否可退还。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksReturnableRequest"/></param>
        /// <returns><see cref="DescribeDisksReturnableResponse"/></returns>
        public Task<DescribeDisksReturnableResponse> DescribeDisksReturnable(DescribeDisksReturnableRequest req)
        {
            return InternalRequestAsync<DescribeDisksReturnableResponse>(req, "DescribeDisksReturnable");
        }

        /// <summary>
        /// 本接口（DescribeDisksReturnable）用于查询云硬盘是否可退还。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksReturnableRequest"/></param>
        /// <returns><see cref="DescribeDisksReturnableResponse"/></returns>
        public DescribeDisksReturnableResponse DescribeDisksReturnableSync(DescribeDisksReturnableRequest req)
        {
            return InternalRequestAsync<DescribeDisksReturnableResponse>(req, "DescribeDisksReturnable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例内的Docker活动列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDockerActivitiesRequest"/></param>
        /// <returns><see cref="DescribeDockerActivitiesResponse"/></returns>
        public Task<DescribeDockerActivitiesResponse> DescribeDockerActivities(DescribeDockerActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeDockerActivitiesResponse>(req, "DescribeDockerActivities");
        }

        /// <summary>
        /// 查询实例内的Docker活动列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDockerActivitiesRequest"/></param>
        /// <returns><see cref="DescribeDockerActivitiesResponse"/></returns>
        public DescribeDockerActivitiesResponse DescribeDockerActivitiesSync(DescribeDockerActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeDockerActivitiesResponse>(req, "DescribeDockerActivities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例内的Docker容器配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDockerContainerConfigurationRequest"/></param>
        /// <returns><see cref="DescribeDockerContainerConfigurationResponse"/></returns>
        public Task<DescribeDockerContainerConfigurationResponse> DescribeDockerContainerConfiguration(DescribeDockerContainerConfigurationRequest req)
        {
            return InternalRequestAsync<DescribeDockerContainerConfigurationResponse>(req, "DescribeDockerContainerConfiguration");
        }

        /// <summary>
        /// 查询实例内的Docker容器配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDockerContainerConfigurationRequest"/></param>
        /// <returns><see cref="DescribeDockerContainerConfigurationResponse"/></returns>
        public DescribeDockerContainerConfigurationResponse DescribeDockerContainerConfigurationSync(DescribeDockerContainerConfigurationRequest req)
        {
            return InternalRequestAsync<DescribeDockerContainerConfigurationResponse>(req, "DescribeDockerContainerConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例内的Docker容器详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDockerContainerDetailRequest"/></param>
        /// <returns><see cref="DescribeDockerContainerDetailResponse"/></returns>
        public Task<DescribeDockerContainerDetailResponse> DescribeDockerContainerDetail(DescribeDockerContainerDetailRequest req)
        {
            return InternalRequestAsync<DescribeDockerContainerDetailResponse>(req, "DescribeDockerContainerDetail");
        }

        /// <summary>
        /// 查询实例内的Docker容器详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDockerContainerDetailRequest"/></param>
        /// <returns><see cref="DescribeDockerContainerDetailResponse"/></returns>
        public DescribeDockerContainerDetailResponse DescribeDockerContainerDetailSync(DescribeDockerContainerDetailRequest req)
        {
            return InternalRequestAsync<DescribeDockerContainerDetailResponse>(req, "DescribeDockerContainerDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例内的容器列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDockerContainersRequest"/></param>
        /// <returns><see cref="DescribeDockerContainersResponse"/></returns>
        public Task<DescribeDockerContainersResponse> DescribeDockerContainers(DescribeDockerContainersRequest req)
        {
            return InternalRequestAsync<DescribeDockerContainersResponse>(req, "DescribeDockerContainers");
        }

        /// <summary>
        /// 查询实例内的容器列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDockerContainersRequest"/></param>
        /// <returns><see cref="DescribeDockerContainersResponse"/></returns>
        public DescribeDockerContainersResponse DescribeDockerContainersSync(DescribeDockerContainersRequest req)
        {
            return InternalRequestAsync<DescribeDockerContainersResponse>(req, "DescribeDockerContainers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeFirewallRules）用于查询实例的防火墙规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesResponse"/></returns>
        public Task<DescribeFirewallRulesResponse> DescribeFirewallRules(DescribeFirewallRulesRequest req)
        {
            return InternalRequestAsync<DescribeFirewallRulesResponse>(req, "DescribeFirewallRules");
        }

        /// <summary>
        /// 本接口（DescribeFirewallRules）用于查询实例的防火墙规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesResponse"/></returns>
        public DescribeFirewallRulesResponse DescribeFirewallRulesSync(DescribeFirewallRulesRequest req)
        {
            return InternalRequestAsync<DescribeFirewallRulesResponse>(req, "DescribeFirewallRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeFirewallRulesTemplate）用于查询防火墙规则模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesTemplateRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesTemplateResponse"/></returns>
        public Task<DescribeFirewallRulesTemplateResponse> DescribeFirewallRulesTemplate(DescribeFirewallRulesTemplateRequest req)
        {
            return InternalRequestAsync<DescribeFirewallRulesTemplateResponse>(req, "DescribeFirewallRulesTemplate");
        }

        /// <summary>
        /// 本接口（DescribeFirewallRulesTemplate）用于查询防火墙规则模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesTemplateRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesTemplateResponse"/></returns>
        public DescribeFirewallRulesTemplateResponse DescribeFirewallRulesTemplateSync(DescribeFirewallRulesTemplateRequest req)
        {
            return InternalRequestAsync<DescribeFirewallRulesTemplateResponse>(req, "DescribeFirewallRulesTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeFirewallTemplateApplyRecords) 用于查询防火墙模板应用记录列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallTemplateApplyRecordsRequest"/></param>
        /// <returns><see cref="DescribeFirewallTemplateApplyRecordsResponse"/></returns>
        public Task<DescribeFirewallTemplateApplyRecordsResponse> DescribeFirewallTemplateApplyRecords(DescribeFirewallTemplateApplyRecordsRequest req)
        {
            return InternalRequestAsync<DescribeFirewallTemplateApplyRecordsResponse>(req, "DescribeFirewallTemplateApplyRecords");
        }

        /// <summary>
        /// 本接口 (DescribeFirewallTemplateApplyRecords) 用于查询防火墙模板应用记录列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallTemplateApplyRecordsRequest"/></param>
        /// <returns><see cref="DescribeFirewallTemplateApplyRecordsResponse"/></returns>
        public DescribeFirewallTemplateApplyRecordsResponse DescribeFirewallTemplateApplyRecordsSync(DescribeFirewallTemplateApplyRecordsRequest req)
        {
            return InternalRequestAsync<DescribeFirewallTemplateApplyRecordsResponse>(req, "DescribeFirewallTemplateApplyRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeFirewallTemplateQuota) 用于查询防火墙模板配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallTemplateQuotaRequest"/></param>
        /// <returns><see cref="DescribeFirewallTemplateQuotaResponse"/></returns>
        public Task<DescribeFirewallTemplateQuotaResponse> DescribeFirewallTemplateQuota(DescribeFirewallTemplateQuotaRequest req)
        {
            return InternalRequestAsync<DescribeFirewallTemplateQuotaResponse>(req, "DescribeFirewallTemplateQuota");
        }

        /// <summary>
        /// 本接口 (DescribeFirewallTemplateQuota) 用于查询防火墙模板配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallTemplateQuotaRequest"/></param>
        /// <returns><see cref="DescribeFirewallTemplateQuotaResponse"/></returns>
        public DescribeFirewallTemplateQuotaResponse DescribeFirewallTemplateQuotaSync(DescribeFirewallTemplateQuotaRequest req)
        {
            return InternalRequestAsync<DescribeFirewallTemplateQuotaResponse>(req, "DescribeFirewallTemplateQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeFirewallTemplateRuleQuota) 用于查询防火墙模板规则配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallTemplateRuleQuotaRequest"/></param>
        /// <returns><see cref="DescribeFirewallTemplateRuleQuotaResponse"/></returns>
        public Task<DescribeFirewallTemplateRuleQuotaResponse> DescribeFirewallTemplateRuleQuota(DescribeFirewallTemplateRuleQuotaRequest req)
        {
            return InternalRequestAsync<DescribeFirewallTemplateRuleQuotaResponse>(req, "DescribeFirewallTemplateRuleQuota");
        }

        /// <summary>
        /// 本接口 (DescribeFirewallTemplateRuleQuota) 用于查询防火墙模板规则配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallTemplateRuleQuotaRequest"/></param>
        /// <returns><see cref="DescribeFirewallTemplateRuleQuotaResponse"/></returns>
        public DescribeFirewallTemplateRuleQuotaResponse DescribeFirewallTemplateRuleQuotaSync(DescribeFirewallTemplateRuleQuotaRequest req)
        {
            return InternalRequestAsync<DescribeFirewallTemplateRuleQuotaResponse>(req, "DescribeFirewallTemplateRuleQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeFirewallTemplateRules) 用于查询防火墙模板规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallTemplateRulesRequest"/></param>
        /// <returns><see cref="DescribeFirewallTemplateRulesResponse"/></returns>
        public Task<DescribeFirewallTemplateRulesResponse> DescribeFirewallTemplateRules(DescribeFirewallTemplateRulesRequest req)
        {
            return InternalRequestAsync<DescribeFirewallTemplateRulesResponse>(req, "DescribeFirewallTemplateRules");
        }

        /// <summary>
        /// 本接口 (DescribeFirewallTemplateRules) 用于查询防火墙模板规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallTemplateRulesRequest"/></param>
        /// <returns><see cref="DescribeFirewallTemplateRulesResponse"/></returns>
        public DescribeFirewallTemplateRulesResponse DescribeFirewallTemplateRulesSync(DescribeFirewallTemplateRulesRequest req)
        {
            return InternalRequestAsync<DescribeFirewallTemplateRulesResponse>(req, "DescribeFirewallTemplateRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeFirewallTemplates) 用于查询防火墙模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallTemplatesRequest"/></param>
        /// <returns><see cref="DescribeFirewallTemplatesResponse"/></returns>
        public Task<DescribeFirewallTemplatesResponse> DescribeFirewallTemplates(DescribeFirewallTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeFirewallTemplatesResponse>(req, "DescribeFirewallTemplates");
        }

        /// <summary>
        /// 本接口 (DescribeFirewallTemplates) 用于查询防火墙模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallTemplatesRequest"/></param>
        /// <returns><see cref="DescribeFirewallTemplatesResponse"/></returns>
        public DescribeFirewallTemplatesResponse DescribeFirewallTemplatesSync(DescribeFirewallTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeFirewallTemplatesResponse>(req, "DescribeFirewallTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeGeneralResourceQuotas）用于查询通用资源配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralResourceQuotasRequest"/></param>
        /// <returns><see cref="DescribeGeneralResourceQuotasResponse"/></returns>
        public Task<DescribeGeneralResourceQuotasResponse> DescribeGeneralResourceQuotas(DescribeGeneralResourceQuotasRequest req)
        {
            return InternalRequestAsync<DescribeGeneralResourceQuotasResponse>(req, "DescribeGeneralResourceQuotas");
        }

        /// <summary>
        /// 本接口（DescribeGeneralResourceQuotas）用于查询通用资源配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralResourceQuotasRequest"/></param>
        /// <returns><see cref="DescribeGeneralResourceQuotasResponse"/></returns>
        public DescribeGeneralResourceQuotasResponse DescribeGeneralResourceQuotasSync(DescribeGeneralResourceQuotasRequest req)
        {
            return InternalRequestAsync<DescribeGeneralResourceQuotasResponse>(req, "DescribeGeneralResourceQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeImagesToShare) 用于查询CVM的自定义镜像列表共享到轻量应用服务器。
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesToShareRequest"/></param>
        /// <returns><see cref="DescribeImagesToShareResponse"/></returns>
        public Task<DescribeImagesToShareResponse> DescribeImagesToShare(DescribeImagesToShareRequest req)
        {
            return InternalRequestAsync<DescribeImagesToShareResponse>(req, "DescribeImagesToShare");
        }

        /// <summary>
        /// 本接口 (DescribeImagesToShare) 用于查询CVM的自定义镜像列表共享到轻量应用服务器。
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesToShareRequest"/></param>
        /// <returns><see cref="DescribeImagesToShareResponse"/></returns>
        public DescribeImagesToShareResponse DescribeImagesToShareSync(DescribeImagesToShareRequest req)
        {
            return InternalRequestAsync<DescribeImagesToShareResponse>(req, "DescribeImagesToShare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( DescribeInstanceVncUrl ) 用于查询实例管理终端地址，获取的地址可用于实例的 VNC 登录。
        /// 
        /// * 仅处于 `RUNNING`，`RESCUE_MODE` 状态的机器，且当前机器无变更中操作，才可使用此功能。
        /// * 管理终端地址的有效期为 15 秒，调用接口成功后如果 15 秒内不使用该链接进行访问，管理终端地址自动失效，您需要重新查询。
        /// * 管理终端地址一旦被访问，将自动失效，您需要重新查询。
        /// * 如果连接断开，每分钟内重新连接的次数不能超过 30 次。
        /// * 参数 `InstanceVncUrl` ：调用接口成功后会返回的 `InstanceVncUrl` 的值。
        /// 获取到 `InstanceVncUrl` 后，您需要在链接 `https://img.qcloud.com/qcloud/app/active_vnc/index.html?` 末尾加上参数 `InstanceVncUrl=xxxx`。
        ///  最后组成的 URL 格式如下：
        /// 
        /// ```
        /// https://img.qcloud.com/qcloud/app/active_vnc/index.html?InstanceVncUrl=wss%3A%2F%2Fbjvnc.qcloud.com%3A26789%2Fvnc%3Fs%3DaHpjWnRVMFNhYmxKdDM5MjRHNlVTSVQwajNUSW0wb2tBbmFtREFCTmFrcy8vUUNPMG0wSHZNOUUxRm5PMmUzWmFDcWlOdDJIbUJxSTZDL0RXcHZxYnZZMmRkWWZWcEZia2lyb09XMzdKNmM9
        /// ```
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest req)
        {
            return InternalRequestAsync<DescribeInstanceVncUrlResponse>(req, "DescribeInstanceVncUrl");
        }

        /// <summary>
        /// 本接口 ( DescribeInstanceVncUrl ) 用于查询实例管理终端地址，获取的地址可用于实例的 VNC 登录。
        /// 
        /// * 仅处于 `RUNNING`，`RESCUE_MODE` 状态的机器，且当前机器无变更中操作，才可使用此功能。
        /// * 管理终端地址的有效期为 15 秒，调用接口成功后如果 15 秒内不使用该链接进行访问，管理终端地址自动失效，您需要重新查询。
        /// * 管理终端地址一旦被访问，将自动失效，您需要重新查询。
        /// * 如果连接断开，每分钟内重新连接的次数不能超过 30 次。
        /// * 参数 `InstanceVncUrl` ：调用接口成功后会返回的 `InstanceVncUrl` 的值。
        /// 获取到 `InstanceVncUrl` 后，您需要在链接 `https://img.qcloud.com/qcloud/app/active_vnc/index.html?` 末尾加上参数 `InstanceVncUrl=xxxx`。
        ///  最后组成的 URL 格式如下：
        /// 
        /// ```
        /// https://img.qcloud.com/qcloud/app/active_vnc/index.html?InstanceVncUrl=wss%3A%2F%2Fbjvnc.qcloud.com%3A26789%2Fvnc%3Fs%3DaHpjWnRVMFNhYmxKdDM5MjRHNlVTSVQwajNUSW0wb2tBbmFtREFCTmFrcy8vUUNPMG0wSHZNOUUxRm5PMmUzWmFDcWlOdDJIbUJxSTZDL0RXcHZxYnZZMmRkWWZWcEZia2lyb09XMzdKNmM9
        /// ```
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlSync(DescribeInstanceVncUrlRequest req)
        {
            return InternalRequestAsync<DescribeInstanceVncUrlResponse>(req, "DescribeInstanceVncUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstances）用于查询一个或多个实例的详细信息。
        /// 
        /// * 可以根据实例 ID、实例名称或者实例的内网 IP 查询实例的详细信息。
        /// * 过滤信息详细请见过滤器 [Filters](https://cloud.tencent.com/document/product/1207/47576#Filter) 。
        /// * 如果参数为空，返回当前用户一定数量（Limit 所指定的数量，默认为 20）的实例。
        /// * 支持查询实例的最新操作（LatestOperation）以及最新操作状态（LatestOperationState）。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 本接口（DescribeInstances）用于查询一个或多个实例的详细信息。
        /// 
        /// * 可以根据实例 ID、实例名称或者实例的内网 IP 查询实例的详细信息。
        /// * 过滤信息详细请见过滤器 [Filters](https://cloud.tencent.com/document/product/1207/47576#Filter) 。
        /// * 如果参数为空，返回当前用户一定数量（Limit 所指定的数量，默认为 20）的实例。
        /// * 支持查询实例的最新操作（LatestOperation）以及最新操作状态（LatestOperationState）。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstancesDeniedActions）用于查询一个或多个实例的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public Task<DescribeInstancesDeniedActionsResponse> DescribeInstancesDeniedActions(DescribeInstancesDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDeniedActionsResponse>(req, "DescribeInstancesDeniedActions");
        }

        /// <summary>
        /// 本接口（DescribeInstancesDeniedActions）用于查询一个或多个实例的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public DescribeInstancesDeniedActionsResponse DescribeInstancesDeniedActionsSync(DescribeInstancesDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDeniedActionsResponse>(req, "DescribeInstancesDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeInstancesDiskNum)用于查询实例挂载云硬盘数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDiskNumRequest"/></param>
        /// <returns><see cref="DescribeInstancesDiskNumResponse"/></returns>
        public Task<DescribeInstancesDiskNumResponse> DescribeInstancesDiskNum(DescribeInstancesDiskNumRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDiskNumResponse>(req, "DescribeInstancesDiskNum");
        }

        /// <summary>
        /// 本接口(DescribeInstancesDiskNum)用于查询实例挂载云硬盘数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDiskNumRequest"/></param>
        /// <returns><see cref="DescribeInstancesDiskNumResponse"/></returns>
        public DescribeInstancesDiskNumResponse DescribeInstancesDiskNumSync(DescribeInstancesDiskNumRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDiskNumResponse>(req, "DescribeInstancesDiskNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstancesReturnable）用于查询实例是否可退还。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesReturnableRequest"/></param>
        /// <returns><see cref="DescribeInstancesReturnableResponse"/></returns>
        public Task<DescribeInstancesReturnableResponse> DescribeInstancesReturnable(DescribeInstancesReturnableRequest req)
        {
            return InternalRequestAsync<DescribeInstancesReturnableResponse>(req, "DescribeInstancesReturnable");
        }

        /// <summary>
        /// 本接口（DescribeInstancesReturnable）用于查询实例是否可退还。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesReturnableRequest"/></param>
        /// <returns><see cref="DescribeInstancesReturnableResponse"/></returns>
        public DescribeInstancesReturnableResponse DescribeInstancesReturnableSync(DescribeInstancesReturnableRequest req)
        {
            return InternalRequestAsync<DescribeInstancesReturnableResponse>(req, "DescribeInstancesReturnable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstancesTrafficPackages）用于查询一个或多个实例的流量包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeInstancesTrafficPackagesResponse"/></returns>
        public Task<DescribeInstancesTrafficPackagesResponse> DescribeInstancesTrafficPackages(DescribeInstancesTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesTrafficPackagesResponse>(req, "DescribeInstancesTrafficPackages");
        }

        /// <summary>
        /// 本接口（DescribeInstancesTrafficPackages）用于查询一个或多个实例的流量包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeInstancesTrafficPackagesResponse"/></returns>
        public DescribeInstancesTrafficPackagesResponse DescribeInstancesTrafficPackagesSync(DescribeInstancesTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesTrafficPackagesResponse>(req, "DescribeInstancesTrafficPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeKeyPairs) 用于查询用户密钥对信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public Task<DescribeKeyPairsResponse> DescribeKeyPairs(DescribeKeyPairsRequest req)
        {
            return InternalRequestAsync<DescribeKeyPairsResponse>(req, "DescribeKeyPairs");
        }

        /// <summary>
        /// 本接口 (DescribeKeyPairs) 用于查询用户密钥对信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public DescribeKeyPairsResponse DescribeKeyPairsSync(DescribeKeyPairsRequest req)
        {
            return InternalRequestAsync<DescribeKeyPairsResponse>(req, "DescribeKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMcpServerTemplates）用于查询MCP Server模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMcpServerTemplatesRequest"/></param>
        /// <returns><see cref="DescribeMcpServerTemplatesResponse"/></returns>
        public Task<DescribeMcpServerTemplatesResponse> DescribeMcpServerTemplates(DescribeMcpServerTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeMcpServerTemplatesResponse>(req, "DescribeMcpServerTemplates");
        }

        /// <summary>
        /// 本接口（DescribeMcpServerTemplates）用于查询MCP Server模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMcpServerTemplatesRequest"/></param>
        /// <returns><see cref="DescribeMcpServerTemplatesResponse"/></returns>
        public DescribeMcpServerTemplatesResponse DescribeMcpServerTemplatesSync(DescribeMcpServerTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeMcpServerTemplatesResponse>(req, "DescribeMcpServerTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMcpServers）用于查询MCP Server列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMcpServersRequest"/></param>
        /// <returns><see cref="DescribeMcpServersResponse"/></returns>
        public Task<DescribeMcpServersResponse> DescribeMcpServers(DescribeMcpServersRequest req)
        {
            return InternalRequestAsync<DescribeMcpServersResponse>(req, "DescribeMcpServers");
        }

        /// <summary>
        /// 本接口（DescribeMcpServers）用于查询MCP Server列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMcpServersRequest"/></param>
        /// <returns><see cref="DescribeMcpServersResponse"/></returns>
        public DescribeMcpServersResponse DescribeMcpServersSync(DescribeMcpServersRequest req)
        {
            return InternalRequestAsync<DescribeMcpServersResponse>(req, "DescribeMcpServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeModifyInstanceBundles）用于查询实例可变更套餐列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyInstanceBundlesRequest"/></param>
        /// <returns><see cref="DescribeModifyInstanceBundlesResponse"/></returns>
        public Task<DescribeModifyInstanceBundlesResponse> DescribeModifyInstanceBundles(DescribeModifyInstanceBundlesRequest req)
        {
            return InternalRequestAsync<DescribeModifyInstanceBundlesResponse>(req, "DescribeModifyInstanceBundles");
        }

        /// <summary>
        /// 本接口（DescribeModifyInstanceBundles）用于查询实例可变更套餐列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyInstanceBundlesRequest"/></param>
        /// <returns><see cref="DescribeModifyInstanceBundlesResponse"/></returns>
        public DescribeModifyInstanceBundlesResponse DescribeModifyInstanceBundlesSync(DescribeModifyInstanceBundlesRequest req)
        {
            return InternalRequestAsync<DescribeModifyInstanceBundlesResponse>(req, "DescribeModifyInstanceBundles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRegions）用于查询地域信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// 本接口（DescribeRegions）用于查询地域信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeResetInstanceBlueprints）查询重置实例的镜像信息。对于游戏专区实例，该接口只会返回当前镜像，且不支持 Filters 参数。
        /// </summary>
        /// <param name="req"><see cref="DescribeResetInstanceBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeResetInstanceBlueprintsResponse"/></returns>
        public Task<DescribeResetInstanceBlueprintsResponse> DescribeResetInstanceBlueprints(DescribeResetInstanceBlueprintsRequest req)
        {
            return InternalRequestAsync<DescribeResetInstanceBlueprintsResponse>(req, "DescribeResetInstanceBlueprints");
        }

        /// <summary>
        /// 本接口（DescribeResetInstanceBlueprints）查询重置实例的镜像信息。对于游戏专区实例，该接口只会返回当前镜像，且不支持 Filters 参数。
        /// </summary>
        /// <param name="req"><see cref="DescribeResetInstanceBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeResetInstanceBlueprintsResponse"/></returns>
        public DescribeResetInstanceBlueprintsResponse DescribeResetInstanceBlueprintsSync(DescribeResetInstanceBlueprintsRequest req)
        {
            return InternalRequestAsync<DescribeResetInstanceBlueprintsResponse>(req, "DescribeResetInstanceBlueprints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeScenes)用于查看使用场景列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public Task<DescribeScenesResponse> DescribeScenes(DescribeScenesRequest req)
        {
            return InternalRequestAsync<DescribeScenesResponse>(req, "DescribeScenes");
        }

        /// <summary>
        /// 本接口(DescribeScenes)用于查看使用场景列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public DescribeScenesResponse DescribeScenesSync(DescribeScenesRequest req)
        {
            return InternalRequestAsync<DescribeScenesResponse>(req, "DescribeScenes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSnapshots）用于查询快照的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots");
        }

        /// <summary>
        /// 本接口（DescribeSnapshots）用于查询快照的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public DescribeSnapshotsResponse DescribeSnapshotsSync(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSnapshotsDeniedActions）用于查询一个或多个快照的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsDeniedActionsResponse"/></returns>
        public Task<DescribeSnapshotsDeniedActionsResponse> DescribeSnapshotsDeniedActions(DescribeSnapshotsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsDeniedActionsResponse>(req, "DescribeSnapshotsDeniedActions");
        }

        /// <summary>
        /// 本接口（DescribeSnapshotsDeniedActions）用于查询一个或多个快照的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsDeniedActionsResponse"/></returns>
        public DescribeSnapshotsDeniedActionsResponse DescribeSnapshotsDeniedActionsSync(DescribeSnapshotsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsDeniedActionsResponse>(req, "DescribeSnapshotsDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询地域下可用区
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// 查询地域下可用区
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DetachCcn) 用于解除与云联网的关联。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnRequest"/></param>
        /// <returns><see cref="DetachCcnResponse"/></returns>
        public Task<DetachCcnResponse> DetachCcn(DetachCcnRequest req)
        {
            return InternalRequestAsync<DetachCcnResponse>(req, "DetachCcn");
        }

        /// <summary>
        /// 本接口 (DetachCcn) 用于解除与云联网的关联。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnRequest"/></param>
        /// <returns><see cref="DetachCcnResponse"/></returns>
        public DetachCcnResponse DetachCcnSync(DetachCcnRequest req)
        {
            return InternalRequestAsync<DetachCcnResponse>(req, "DetachCcn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DetachDisks）用于卸载一个或多个云硬盘。该操作目前仅支持云硬盘类型为数据盘的云硬盘。
        /// - 支持批量操作，卸载挂载在同一主机上的多块云硬盘。如果多块云硬盘中存在不允许卸载的云硬盘，则操作不执行，返回特定的错误码。
        /// - 本接口为异步接口，当请求成功返回时，云硬盘并未立即卸载，可通过接口[DescribeDisks](https://cloud.tencent.com/document/product/362/16315)来查询对应云硬盘的状态，如果云硬盘的状态由“ATTACHED”变为“UNATTACHED”，则为卸载成功。
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public Task<DetachDisksResponse> DetachDisks(DetachDisksRequest req)
        {
            return InternalRequestAsync<DetachDisksResponse>(req, "DetachDisks");
        }

        /// <summary>
        /// 本接口（DetachDisks）用于卸载一个或多个云硬盘。该操作目前仅支持云硬盘类型为数据盘的云硬盘。
        /// - 支持批量操作，卸载挂载在同一主机上的多块云硬盘。如果多块云硬盘中存在不允许卸载的云硬盘，则操作不执行，返回特定的错误码。
        /// - 本接口为异步接口，当请求成功返回时，云硬盘并未立即卸载，可通过接口[DescribeDisks](https://cloud.tencent.com/document/product/362/16315)来查询对应云硬盘的状态，如果云硬盘的状态由“ATTACHED”变为“UNATTACHED”，则为卸载成功。
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public DetachDisksResponse DetachDisksSync(DetachDisksRequest req)
        {
            return InternalRequestAsync<DetachDisksResponse>(req, "DetachDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisassociateInstancesKeyPairs）用于解除实例与指定密钥对的绑定关系。
        /// 
        /// * 只支持 [RUNNING, STOPPED] 状态的 LINUX_UNIX 操作系统的实例。处于 RUNNING 状态的实例会强制关机，然后解绑。
        /// * 解绑密钥后，实例可以通过原来设置的密码登录。
        /// * 如果原来没有设置密码，解绑后将无法使用 SSH 登录。可以调用 <a href="https://cloud.tencent.com/document/product/1207/55546" target="_blank">ResetInstancesPassword</a> 接口来设置登录密码。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public Task<DisassociateInstancesKeyPairsResponse> DisassociateInstancesKeyPairs(DisassociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<DisassociateInstancesKeyPairsResponse>(req, "DisassociateInstancesKeyPairs");
        }

        /// <summary>
        /// 本接口（DisassociateInstancesKeyPairs）用于解除实例与指定密钥对的绑定关系。
        /// 
        /// * 只支持 [RUNNING, STOPPED] 状态的 LINUX_UNIX 操作系统的实例。处于 RUNNING 状态的实例会强制关机，然后解绑。
        /// * 解绑密钥后，实例可以通过原来设置的密码登录。
        /// * 如果原来没有设置密码，解绑后将无法使用 SSH 登录。可以调用 <a href="https://cloud.tencent.com/document/product/1207/55546" target="_blank">ResetInstancesPassword</a> 接口来设置登录密码。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public DisassociateInstancesKeyPairsResponse DisassociateInstancesKeyPairsSync(DisassociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<DisassociateInstancesKeyPairsResponse>(req, "DisassociateInstancesKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ImportKeyPair）用于导入用户指定密钥对。
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public Task<ImportKeyPairResponse> ImportKeyPair(ImportKeyPairRequest req)
        {
            return InternalRequestAsync<ImportKeyPairResponse>(req, "ImportKeyPair");
        }

        /// <summary>
        /// 本接口（ImportKeyPair）用于导入用户指定密钥对。
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public ImportKeyPairResponse ImportKeyPairSync(ImportKeyPairRequest req)
        {
            return InternalRequestAsync<ImportKeyPairResponse>(req, "ImportKeyPair")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (InquirePriceCreateBlueprint) 用于创建镜像询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateBlueprintRequest"/></param>
        /// <returns><see cref="InquirePriceCreateBlueprintResponse"/></returns>
        public Task<InquirePriceCreateBlueprintResponse> InquirePriceCreateBlueprint(InquirePriceCreateBlueprintRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateBlueprintResponse>(req, "InquirePriceCreateBlueprint");
        }

        /// <summary>
        /// 本接口 (InquirePriceCreateBlueprint) 用于创建镜像询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateBlueprintRequest"/></param>
        /// <returns><see cref="InquirePriceCreateBlueprintResponse"/></returns>
        public InquirePriceCreateBlueprintResponse InquirePriceCreateBlueprintSync(InquirePriceCreateBlueprintRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateBlueprintResponse>(req, "InquirePriceCreateBlueprint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquirePriceCreateDisks）用于新购云硬盘询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDisksResponse"/></returns>
        public Task<InquirePriceCreateDisksResponse> InquirePriceCreateDisks(InquirePriceCreateDisksRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDisksResponse>(req, "InquirePriceCreateDisks");
        }

        /// <summary>
        /// 本接口（InquirePriceCreateDisks）用于新购云硬盘询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDisksResponse"/></returns>
        public InquirePriceCreateDisksResponse InquirePriceCreateDisksSync(InquirePriceCreateDisksRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDisksResponse>(req, "InquirePriceCreateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateInstances）用于创建实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateInstancesResponse"/></returns>
        public Task<InquirePriceCreateInstancesResponse> InquirePriceCreateInstances(InquirePriceCreateInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateInstancesResponse>(req, "InquirePriceCreateInstances");
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateInstances）用于创建实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateInstancesResponse"/></returns>
        public InquirePriceCreateInstancesResponse InquirePriceCreateInstancesSync(InquirePriceCreateInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateInstancesResponse>(req, "InquirePriceCreateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquirePriceRenewDisks）用于续费云硬盘询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDisksRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDisksResponse"/></returns>
        public Task<InquirePriceRenewDisksResponse> InquirePriceRenewDisks(InquirePriceRenewDisksRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewDisksResponse>(req, "InquirePriceRenewDisks");
        }

        /// <summary>
        /// 本接口（InquirePriceRenewDisks）用于续费云硬盘询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDisksRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDisksResponse"/></returns>
        public InquirePriceRenewDisksResponse InquirePriceRenewDisksSync(InquirePriceRenewDisksRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewDisksResponse>(req, "InquirePriceRenewDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquirePriceRenewInstances）用于续费实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstancesResponse"/></returns>
        public Task<InquirePriceRenewInstancesResponse> InquirePriceRenewInstances(InquirePriceRenewInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewInstancesResponse>(req, "InquirePriceRenewInstances");
        }

        /// <summary>
        /// 本接口（InquirePriceRenewInstances）用于续费实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstancesResponse"/></returns>
        public InquirePriceRenewInstancesResponse InquirePriceRenewInstancesSync(InquirePriceRenewInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewInstancesResponse>(req, "InquirePriceRenewInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(IsolateDisks)用于退还一个或多个轻量应用服务器云硬盘。
        /// 
        /// 只有状态为 UNATTACHED 的数据盘才可以进行此操作。
        /// 接口调用成功后，云硬盘会进入SHUTDOWN 状态。
        /// 支持批量操作。每次请求批量资源的上限为 20。
        /// 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。云硬盘操作结果可以通过调用 [DescribeDisks](https://cloud.tencent.com/document/product/1207/66093) 接口查询，如果云硬盘的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="IsolateDisksRequest"/></param>
        /// <returns><see cref="IsolateDisksResponse"/></returns>
        public Task<IsolateDisksResponse> IsolateDisks(IsolateDisksRequest req)
        {
            return InternalRequestAsync<IsolateDisksResponse>(req, "IsolateDisks");
        }

        /// <summary>
        /// 本接口(IsolateDisks)用于退还一个或多个轻量应用服务器云硬盘。
        /// 
        /// 只有状态为 UNATTACHED 的数据盘才可以进行此操作。
        /// 接口调用成功后，云硬盘会进入SHUTDOWN 状态。
        /// 支持批量操作。每次请求批量资源的上限为 20。
        /// 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。云硬盘操作结果可以通过调用 [DescribeDisks](https://cloud.tencent.com/document/product/1207/66093) 接口查询，如果云硬盘的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="IsolateDisksRequest"/></param>
        /// <returns><see cref="IsolateDisksResponse"/></returns>
        public IsolateDisksResponse IsolateDisksSync(IsolateDisksRequest req)
        {
            return InternalRequestAsync<IsolateDisksResponse>(req, "IsolateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(IsolateInstances)用于退还一个或多个轻量应用服务器实例。
        /// * 只有状态为 RUNNING 或 STOPPED 的实例才可以进行此操作。
        /// * 接口调用成功后，实例会进入SHUTDOWN 状态。
        /// * 支持批量操作。每次请求批量资源（包括实例与数据盘）的上限为 20。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="IsolateInstancesRequest"/></param>
        /// <returns><see cref="IsolateInstancesResponse"/></returns>
        public Task<IsolateInstancesResponse> IsolateInstances(IsolateInstancesRequest req)
        {
            return InternalRequestAsync<IsolateInstancesResponse>(req, "IsolateInstances");
        }

        /// <summary>
        /// 本接口(IsolateInstances)用于退还一个或多个轻量应用服务器实例。
        /// * 只有状态为 RUNNING 或 STOPPED 的实例才可以进行此操作。
        /// * 接口调用成功后，实例会进入SHUTDOWN 状态。
        /// * 支持批量操作。每次请求批量资源（包括实例与数据盘）的上限为 20。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="IsolateInstancesRequest"/></param>
        /// <returns><see cref="IsolateInstancesResponse"/></returns>
        public IsolateInstancesResponse IsolateInstancesSync(IsolateInstancesRequest req)
        {
            return InternalRequestAsync<IsolateInstancesResponse>(req, "IsolateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyBlueprintAttribute) 用于修改镜像属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyBlueprintAttributeRequest"/></param>
        /// <returns><see cref="ModifyBlueprintAttributeResponse"/></returns>
        public Task<ModifyBlueprintAttributeResponse> ModifyBlueprintAttribute(ModifyBlueprintAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBlueprintAttributeResponse>(req, "ModifyBlueprintAttribute");
        }

        /// <summary>
        /// 本接口 (ModifyBlueprintAttribute) 用于修改镜像属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyBlueprintAttributeRequest"/></param>
        /// <returns><see cref="ModifyBlueprintAttributeResponse"/></returns>
        public ModifyBlueprintAttributeResponse ModifyBlueprintAttributeSync(ModifyBlueprintAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBlueprintAttributeResponse>(req, "ModifyBlueprintAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyDiskBackupsAttribute) 用于修改云硬盘备份点属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskBackupsAttributeRequest"/></param>
        /// <returns><see cref="ModifyDiskBackupsAttributeResponse"/></returns>
        public Task<ModifyDiskBackupsAttributeResponse> ModifyDiskBackupsAttribute(ModifyDiskBackupsAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDiskBackupsAttributeResponse>(req, "ModifyDiskBackupsAttribute");
        }

        /// <summary>
        /// 本接口 (ModifyDiskBackupsAttribute) 用于修改云硬盘备份点属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskBackupsAttributeRequest"/></param>
        /// <returns><see cref="ModifyDiskBackupsAttributeResponse"/></returns>
        public ModifyDiskBackupsAttributeResponse ModifyDiskBackupsAttributeSync(ModifyDiskBackupsAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDiskBackupsAttributeResponse>(req, "ModifyDiskBackupsAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDisksAttribute)用于修改云硬盘属性。
        /// 云硬盘必须处于以下状态:
        /// <li> ATTACHED（已挂载）</li>
        /// <li> UNATTACHED（待挂载）</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisksAttributeResponse"/></returns>
        public Task<ModifyDisksAttributeResponse> ModifyDisksAttribute(ModifyDisksAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDisksAttributeResponse>(req, "ModifyDisksAttribute");
        }

        /// <summary>
        /// 本接口(ModifyDisksAttribute)用于修改云硬盘属性。
        /// 云硬盘必须处于以下状态:
        /// <li> ATTACHED（已挂载）</li>
        /// <li> UNATTACHED（待挂载）</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisksAttributeResponse"/></returns>
        public ModifyDisksAttributeResponse ModifyDisksAttributeSync(ModifyDisksAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDisksAttributeResponse>(req, "ModifyDisksAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDisksBackupQuota)用于调整云硬盘备份点配额。
        /// 该操作目前仅支持状态是ATTACHED（已挂载）或 UNATTACHED（待挂载）的云硬盘。
        /// 支持批量操作。每次批量请求云硬盘数量上限为15个。
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksBackupQuotaRequest"/></param>
        /// <returns><see cref="ModifyDisksBackupQuotaResponse"/></returns>
        public Task<ModifyDisksBackupQuotaResponse> ModifyDisksBackupQuota(ModifyDisksBackupQuotaRequest req)
        {
            return InternalRequestAsync<ModifyDisksBackupQuotaResponse>(req, "ModifyDisksBackupQuota");
        }

        /// <summary>
        /// 本接口(ModifyDisksBackupQuota)用于调整云硬盘备份点配额。
        /// 该操作目前仅支持状态是ATTACHED（已挂载）或 UNATTACHED（待挂载）的云硬盘。
        /// 支持批量操作。每次批量请求云硬盘数量上限为15个。
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksBackupQuotaRequest"/></param>
        /// <returns><see cref="ModifyDisksBackupQuotaResponse"/></returns>
        public ModifyDisksBackupQuotaResponse ModifyDisksBackupQuotaSync(ModifyDisksBackupQuotaRequest req)
        {
            return InternalRequestAsync<ModifyDisksBackupQuotaResponse>(req, "ModifyDisksBackupQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDisksRenewFlag）用于修改云硬盘续费标识。
        /// 云硬盘需要处于以下状态：
        /// <li> ATTACHED （已挂载）</li>
        /// <li> UNATTACHED （待挂载）</li>
        /// <li> ATTACHING （挂载中） </li>
        /// <li> DETACHING （卸载中）</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDisksRenewFlagResponse"/></returns>
        public Task<ModifyDisksRenewFlagResponse> ModifyDisksRenewFlag(ModifyDisksRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyDisksRenewFlagResponse>(req, "ModifyDisksRenewFlag");
        }

        /// <summary>
        /// 本接口（ModifyDisksRenewFlag）用于修改云硬盘续费标识。
        /// 云硬盘需要处于以下状态：
        /// <li> ATTACHED （已挂载）</li>
        /// <li> UNATTACHED （待挂载）</li>
        /// <li> ATTACHING （挂载中） </li>
        /// <li> DETACHING （卸载中）</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDisksRenewFlagResponse"/></returns>
        public ModifyDisksRenewFlagResponse ModifyDisksRenewFlagSync(ModifyDisksRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyDisksRenewFlagResponse>(req, "ModifyDisksRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例内的Docker容器，之后可以通过返回的ActivityId调用<a href="https://cloud.tencent.com/document/product/1207/95476" target="_blank">DescribeDockerActivities</a>接口查询重建情况。
        /// 请注意：本接口会重新创建并运行实例内的Docker容器。
        /// </summary>
        /// <param name="req"><see cref="ModifyDockerContainerRequest"/></param>
        /// <returns><see cref="ModifyDockerContainerResponse"/></returns>
        public Task<ModifyDockerContainerResponse> ModifyDockerContainer(ModifyDockerContainerRequest req)
        {
            return InternalRequestAsync<ModifyDockerContainerResponse>(req, "ModifyDockerContainer");
        }

        /// <summary>
        /// 修改实例内的Docker容器，之后可以通过返回的ActivityId调用<a href="https://cloud.tencent.com/document/product/1207/95476" target="_blank">DescribeDockerActivities</a>接口查询重建情况。
        /// 请注意：本接口会重新创建并运行实例内的Docker容器。
        /// </summary>
        /// <param name="req"><see cref="ModifyDockerContainerRequest"/></param>
        /// <returns><see cref="ModifyDockerContainerResponse"/></returns>
        public ModifyDockerContainerResponse ModifyDockerContainerSync(ModifyDockerContainerRequest req)
        {
            return InternalRequestAsync<ModifyDockerContainerResponse>(req, "ModifyDockerContainer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyFirewallRuleDescription）用于修改单条防火墙规则描述。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接修改防火墙规则备注。FirewallVersion可通过[DescribeFirewallRules](https://cloud.tencent.com/document/api/1207/48252)接口返回值中的FirewallVersion获取。
        /// 
        /// 用FirewallRule参数来指定要修改的防火墙规则，使用其中的Protocol， Port， CidrBlock，Action字段来匹配要修改的防火墙规则。
        /// 
        /// 在 FirewallRule 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ICMPv6，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRuleDescriptionRequest"/></param>
        /// <returns><see cref="ModifyFirewallRuleDescriptionResponse"/></returns>
        public Task<ModifyFirewallRuleDescriptionResponse> ModifyFirewallRuleDescription(ModifyFirewallRuleDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyFirewallRuleDescriptionResponse>(req, "ModifyFirewallRuleDescription");
        }

        /// <summary>
        /// 本接口（ModifyFirewallRuleDescription）用于修改单条防火墙规则描述。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接修改防火墙规则备注。FirewallVersion可通过[DescribeFirewallRules](https://cloud.tencent.com/document/api/1207/48252)接口返回值中的FirewallVersion获取。
        /// 
        /// 用FirewallRule参数来指定要修改的防火墙规则，使用其中的Protocol， Port， CidrBlock，Action字段来匹配要修改的防火墙规则。
        /// 
        /// 在 FirewallRule 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ICMPv6，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRuleDescriptionRequest"/></param>
        /// <returns><see cref="ModifyFirewallRuleDescriptionResponse"/></returns>
        public ModifyFirewallRuleDescriptionResponse ModifyFirewallRuleDescriptionSync(ModifyFirewallRuleDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyFirewallRuleDescriptionResponse>(req, "ModifyFirewallRuleDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyFirewallRules）用于重置实例防火墙规则。
        /// 
        /// 本接口先删除当前实例的所有防火墙规则，然后添加新的规则。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接重置防火墙规则。可通过[DescribeFirewallRules](https://cloud.tencent.com/document/api/1207/48252)接口返回值中的FirewallVersion获取。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ICMPv6，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRulesRequest"/></param>
        /// <returns><see cref="ModifyFirewallRulesResponse"/></returns>
        public Task<ModifyFirewallRulesResponse> ModifyFirewallRules(ModifyFirewallRulesRequest req)
        {
            return InternalRequestAsync<ModifyFirewallRulesResponse>(req, "ModifyFirewallRules");
        }

        /// <summary>
        /// 本接口（ModifyFirewallRules）用于重置实例防火墙规则。
        /// 
        /// 本接口先删除当前实例的所有防火墙规则，然后添加新的规则。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接重置防火墙规则。可通过[DescribeFirewallRules](https://cloud.tencent.com/document/api/1207/48252)接口返回值中的FirewallVersion获取。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ICMPv6，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRulesRequest"/></param>
        /// <returns><see cref="ModifyFirewallRulesResponse"/></returns>
        public ModifyFirewallRulesResponse ModifyFirewallRulesSync(ModifyFirewallRulesRequest req)
        {
            return InternalRequestAsync<ModifyFirewallRulesResponse>(req, "ModifyFirewallRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyFirewallTemplate) 用于修改防火墙模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallTemplateRequest"/></param>
        /// <returns><see cref="ModifyFirewallTemplateResponse"/></returns>
        public Task<ModifyFirewallTemplateResponse> ModifyFirewallTemplate(ModifyFirewallTemplateRequest req)
        {
            return InternalRequestAsync<ModifyFirewallTemplateResponse>(req, "ModifyFirewallTemplate");
        }

        /// <summary>
        /// 本接口 (ModifyFirewallTemplate) 用于修改防火墙模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallTemplateRequest"/></param>
        /// <returns><see cref="ModifyFirewallTemplateResponse"/></returns>
        public ModifyFirewallTemplateResponse ModifyFirewallTemplateSync(ModifyFirewallTemplateRequest req)
        {
            return InternalRequestAsync<ModifyFirewallTemplateResponse>(req, "ModifyFirewallTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyImageSharePermission) 用于共享和取消共享CVM自定义镜像到轻量应用服务器服务。
        /// CVM镜像共享到轻量应用服务器镜像需要满足如下条件：
        /// 1.已共享过的镜像不支持再次共享。
        /// 2.外部导入的镜像不支持共享。
        /// 3.整机镜像不支持共享。
        /// 4.镜像要支持Cloudinit才支持共享。
        /// 5.镜像的Platform和OsName要满足。
        /// 6.NORMAL状态的镜像才支持共享。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSharePermissionRequest"/></param>
        /// <returns><see cref="ModifyImageSharePermissionResponse"/></returns>
        public Task<ModifyImageSharePermissionResponse> ModifyImageSharePermission(ModifyImageSharePermissionRequest req)
        {
            return InternalRequestAsync<ModifyImageSharePermissionResponse>(req, "ModifyImageSharePermission");
        }

        /// <summary>
        /// 本接口 (ModifyImageSharePermission) 用于共享和取消共享CVM自定义镜像到轻量应用服务器服务。
        /// CVM镜像共享到轻量应用服务器镜像需要满足如下条件：
        /// 1.已共享过的镜像不支持再次共享。
        /// 2.外部导入的镜像不支持共享。
        /// 3.整机镜像不支持共享。
        /// 4.镜像要支持Cloudinit才支持共享。
        /// 5.镜像的Platform和OsName要满足。
        /// 6.NORMAL状态的镜像才支持共享。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSharePermissionRequest"/></param>
        /// <returns><see cref="ModifyImageSharePermissionResponse"/></returns>
        public ModifyImageSharePermissionResponse ModifyImageSharePermissionSync(ModifyImageSharePermissionRequest req)
        {
            return InternalRequestAsync<ModifyImageSharePermissionResponse>(req, "ModifyImageSharePermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyInstancesAttribute）用于修改实例的属性。
        /// * “实例名称”仅为方便用户自己管理之用。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public Task<ModifyInstancesAttributeResponse> ModifyInstancesAttribute(ModifyInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesAttributeResponse>(req, "ModifyInstancesAttribute");
        }

        /// <summary>
        /// 本接口（ModifyInstancesAttribute）用于修改实例的属性。
        /// * “实例名称”仅为方便用户自己管理之用。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public ModifyInstancesAttributeResponse ModifyInstancesAttributeSync(ModifyInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesAttributeResponse>(req, "ModifyInstancesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyInstancesBundle)用于变更一个或多个轻量应用服务器实例套餐。
        /// * 只有状态为 RUNNING，STOPPED的实例才可以进行此操作。
        /// * 支持批量操作。每次请求批量实例的上限为 30。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesBundleRequest"/></param>
        /// <returns><see cref="ModifyInstancesBundleResponse"/></returns>
        public Task<ModifyInstancesBundleResponse> ModifyInstancesBundle(ModifyInstancesBundleRequest req)
        {
            return InternalRequestAsync<ModifyInstancesBundleResponse>(req, "ModifyInstancesBundle");
        }

        /// <summary>
        /// 本接口(ModifyInstancesBundle)用于变更一个或多个轻量应用服务器实例套餐。
        /// * 只有状态为 RUNNING，STOPPED的实例才可以进行此操作。
        /// * 支持批量操作。每次请求批量实例的上限为 30。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesBundleRequest"/></param>
        /// <returns><see cref="ModifyInstancesBundleResponse"/></returns>
        public ModifyInstancesBundleResponse ModifyInstancesBundleSync(ModifyInstancesBundleRequest req)
        {
            return InternalRequestAsync<ModifyInstancesBundleResponse>(req, "ModifyInstancesBundle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyInstancesRenewFlag) 用于修改包年包月实例续费标识。
        /// 
        /// * 实例被标识为自动续费后，每次在实例到期时，会自动续费一个月。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstancesRenewFlagResponse"/></returns>
        public Task<ModifyInstancesRenewFlagResponse> ModifyInstancesRenewFlag(ModifyInstancesRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyInstancesRenewFlagResponse>(req, "ModifyInstancesRenewFlag");
        }

        /// <summary>
        /// 本接口 (ModifyInstancesRenewFlag) 用于修改包年包月实例续费标识。
        /// 
        /// * 实例被标识为自动续费后，每次在实例到期时，会自动续费一个月。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstancesRenewFlagResponse"/></returns>
        public ModifyInstancesRenewFlagResponse ModifyInstancesRenewFlagSync(ModifyInstancesRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyInstancesRenewFlagResponse>(req, "ModifyInstancesRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyMcpServer）用于修改实例的MCP Server信息。
        /// - 本接口为异步接口，API返回时修改操作并未立即完成。MCP Server的修改结果可以通过调用 DescribeMcpServers 接口查询。
        /// </summary>
        /// <param name="req"><see cref="ModifyMcpServerRequest"/></param>
        /// <returns><see cref="ModifyMcpServerResponse"/></returns>
        public Task<ModifyMcpServerResponse> ModifyMcpServer(ModifyMcpServerRequest req)
        {
            return InternalRequestAsync<ModifyMcpServerResponse>(req, "ModifyMcpServer");
        }

        /// <summary>
        /// 本接口（ModifyMcpServer）用于修改实例的MCP Server信息。
        /// - 本接口为异步接口，API返回时修改操作并未立即完成。MCP Server的修改结果可以通过调用 DescribeMcpServers 接口查询。
        /// </summary>
        /// <param name="req"><see cref="ModifyMcpServerRequest"/></param>
        /// <returns><see cref="ModifyMcpServerResponse"/></returns>
        public ModifyMcpServerResponse ModifyMcpServerSync(ModifyMcpServerRequest req)
        {
            return InternalRequestAsync<ModifyMcpServerResponse>(req, "ModifyMcpServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifySnapshotAttribute）用于修改指定快照的属性。
        /// <li>“快照名称”仅为方便用户自己管理之用。</li>
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotAttributeRequest"/></param>
        /// <returns><see cref="ModifySnapshotAttributeResponse"/></returns>
        public Task<ModifySnapshotAttributeResponse> ModifySnapshotAttribute(ModifySnapshotAttributeRequest req)
        {
            return InternalRequestAsync<ModifySnapshotAttributeResponse>(req, "ModifySnapshotAttribute");
        }

        /// <summary>
        /// 本接口（ModifySnapshotAttribute）用于修改指定快照的属性。
        /// <li>“快照名称”仅为方便用户自己管理之用。</li>
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotAttributeRequest"/></param>
        /// <returns><see cref="ModifySnapshotAttributeResponse"/></returns>
        public ModifySnapshotAttributeResponse ModifySnapshotAttributeSync(ModifySnapshotAttributeRequest req)
        {
            return InternalRequestAsync<ModifySnapshotAttributeResponse>(req, "ModifySnapshotAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RebootInstances）用于重启实例。
        /// 
        /// * 只有状态为 RUNNING 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 REBOOTING 状态；重启实例成功时，实例会进入 RUNNING 状态。
        /// * 支持批量操作，每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances");
        }

        /// <summary>
        /// 本接口（RebootInstances）用于重启实例。
        /// 
        /// * 只有状态为 RUNNING 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 REBOOTING 状态；重启实例成功时，实例会进入 RUNNING 状态。
        /// * 支持批量操作，每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public RebootInstancesResponse RebootInstancesSync(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询删除情况。
        /// </summary>
        /// <param name="req"><see cref="RemoveDockerContainersRequest"/></param>
        /// <returns><see cref="RemoveDockerContainersResponse"/></returns>
        public Task<RemoveDockerContainersResponse> RemoveDockerContainers(RemoveDockerContainersRequest req)
        {
            return InternalRequestAsync<RemoveDockerContainersResponse>(req, "RemoveDockerContainers");
        }

        /// <summary>
        /// 删除实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询删除情况。
        /// </summary>
        /// <param name="req"><see cref="RemoveDockerContainersRequest"/></param>
        /// <returns><see cref="RemoveDockerContainersResponse"/></returns>
        public RemoveDockerContainersResponse RemoveDockerContainersSync(RemoveDockerContainersRequest req)
        {
            return InternalRequestAsync<RemoveDockerContainersResponse>(req, "RemoveDockerContainers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RemoveMcpServers）用于删除MCP Server。
        /// - 本接口为异步接口，API返回时操作并未立即完成。MCP Server的操作结果可以通过调用 DescribeMcpServers 接口查询。
        /// - 本接口在操作多个MCP Server时，不会因为某一个失败而停止。您需要通过调用 DescribeMcpServers 接口查询最终操作结果，如无法查询到，代表删除成功。
        /// </summary>
        /// <param name="req"><see cref="RemoveMcpServersRequest"/></param>
        /// <returns><see cref="RemoveMcpServersResponse"/></returns>
        public Task<RemoveMcpServersResponse> RemoveMcpServers(RemoveMcpServersRequest req)
        {
            return InternalRequestAsync<RemoveMcpServersResponse>(req, "RemoveMcpServers");
        }

        /// <summary>
        /// 本接口（RemoveMcpServers）用于删除MCP Server。
        /// - 本接口为异步接口，API返回时操作并未立即完成。MCP Server的操作结果可以通过调用 DescribeMcpServers 接口查询。
        /// - 本接口在操作多个MCP Server时，不会因为某一个失败而停止。您需要通过调用 DescribeMcpServers 接口查询最终操作结果，如无法查询到，代表删除成功。
        /// </summary>
        /// <param name="req"><see cref="RemoveMcpServersRequest"/></param>
        /// <returns><see cref="RemoveMcpServersResponse"/></returns>
        public RemoveMcpServersResponse RemoveMcpServersSync(RemoveMcpServersRequest req)
        {
            return InternalRequestAsync<RemoveMcpServersResponse>(req, "RemoveMcpServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重命名实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询重命名情况。
        /// </summary>
        /// <param name="req"><see cref="RenameDockerContainerRequest"/></param>
        /// <returns><see cref="RenameDockerContainerResponse"/></returns>
        public Task<RenameDockerContainerResponse> RenameDockerContainer(RenameDockerContainerRequest req)
        {
            return InternalRequestAsync<RenameDockerContainerResponse>(req, "RenameDockerContainer");
        }

        /// <summary>
        /// 重命名实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询重命名情况。
        /// </summary>
        /// <param name="req"><see cref="RenameDockerContainerRequest"/></param>
        /// <returns><see cref="RenameDockerContainerResponse"/></returns>
        public RenameDockerContainerResponse RenameDockerContainerSync(RenameDockerContainerRequest req)
        {
            return InternalRequestAsync<RenameDockerContainerResponse>(req, "RenameDockerContainer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(RenewDisks)用于续费一个或多个轻量应用服务器云硬盘。
        /// 
        /// 只有状态为 ATTACHED，UNATTACHED 或 SHUTDOWN 的数据盘才可以进行此操作。
        /// 支持批量操作。每次请求批量云硬盘的上限为 50。
        /// 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。云硬盘操作结果可以通过调用 [DescribeDisks](https://cloud.tencent.com/document/product/1207/66093) 接口查询，如果云硬盘的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="RenewDisksRequest"/></param>
        /// <returns><see cref="RenewDisksResponse"/></returns>
        public Task<RenewDisksResponse> RenewDisks(RenewDisksRequest req)
        {
            return InternalRequestAsync<RenewDisksResponse>(req, "RenewDisks");
        }

        /// <summary>
        /// 本接口(RenewDisks)用于续费一个或多个轻量应用服务器云硬盘。
        /// 
        /// 只有状态为 ATTACHED，UNATTACHED 或 SHUTDOWN 的数据盘才可以进行此操作。
        /// 支持批量操作。每次请求批量云硬盘的上限为 50。
        /// 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。云硬盘操作结果可以通过调用 [DescribeDisks](https://cloud.tencent.com/document/product/1207/66093) 接口查询，如果云硬盘的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="RenewDisksRequest"/></param>
        /// <returns><see cref="RenewDisksResponse"/></returns>
        public RenewDisksResponse RenewDisksSync(RenewDisksRequest req)
        {
            return InternalRequestAsync<RenewDisksResponse>(req, "RenewDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(RenewInstances)用于续费一个或多个轻量应用服务器实例。
        /// * 只有状态为 RUNNING，STOPPED 或 SHUTDOWN 的实例才可以进行此操作。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="RenewInstancesRequest"/></param>
        /// <returns><see cref="RenewInstancesResponse"/></returns>
        public Task<RenewInstancesResponse> RenewInstances(RenewInstancesRequest req)
        {
            return InternalRequestAsync<RenewInstancesResponse>(req, "RenewInstances");
        }

        /// <summary>
        /// 本接口(RenewInstances)用于续费一个或多个轻量应用服务器实例。
        /// * 只有状态为 RUNNING，STOPPED 或 SHUTDOWN 的实例才可以进行此操作。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="RenewInstancesRequest"/></param>
        /// <returns><see cref="RenewInstancesResponse"/></returns>
        public RenewInstancesResponse RenewInstancesSync(RenewInstancesRequest req)
        {
            return InternalRequestAsync<RenewInstancesResponse>(req, "RenewInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ReplaceFirewallTemplateRules) 用于替换防火墙模板规则。
        /// </summary>
        /// <param name="req"><see cref="ReplaceFirewallTemplateRuleRequest"/></param>
        /// <returns><see cref="ReplaceFirewallTemplateRuleResponse"/></returns>
        public Task<ReplaceFirewallTemplateRuleResponse> ReplaceFirewallTemplateRule(ReplaceFirewallTemplateRuleRequest req)
        {
            return InternalRequestAsync<ReplaceFirewallTemplateRuleResponse>(req, "ReplaceFirewallTemplateRule");
        }

        /// <summary>
        /// 本接口 (ReplaceFirewallTemplateRules) 用于替换防火墙模板规则。
        /// </summary>
        /// <param name="req"><see cref="ReplaceFirewallTemplateRuleRequest"/></param>
        /// <returns><see cref="ReplaceFirewallTemplateRuleResponse"/></returns>
        public ReplaceFirewallTemplateRuleResponse ReplaceFirewallTemplateRuleSync(ReplaceFirewallTemplateRuleRequest req)
        {
            return InternalRequestAsync<ReplaceFirewallTemplateRuleResponse>(req, "ReplaceFirewallTemplateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新创建并运行实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询重建情况。
        /// </summary>
        /// <param name="req"><see cref="RerunDockerContainerRequest"/></param>
        /// <returns><see cref="RerunDockerContainerResponse"/></returns>
        public Task<RerunDockerContainerResponse> RerunDockerContainer(RerunDockerContainerRequest req)
        {
            return InternalRequestAsync<RerunDockerContainerResponse>(req, "RerunDockerContainer");
        }

        /// <summary>
        /// 重新创建并运行实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询重建情况。
        /// </summary>
        /// <param name="req"><see cref="RerunDockerContainerRequest"/></param>
        /// <returns><see cref="RerunDockerContainerResponse"/></returns>
        public RerunDockerContainerResponse RerunDockerContainerSync(RerunDockerContainerRequest req)
        {
            return InternalRequestAsync<RerunDockerContainerResponse>(req, "RerunDockerContainer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ResetAttachCcn) 用于关联云联网实例申请过期时，重新申请关联操作。
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnRequest"/></param>
        /// <returns><see cref="ResetAttachCcnResponse"/></returns>
        public Task<ResetAttachCcnResponse> ResetAttachCcn(ResetAttachCcnRequest req)
        {
            return InternalRequestAsync<ResetAttachCcnResponse>(req, "ResetAttachCcn");
        }

        /// <summary>
        /// 本接口 (ResetAttachCcn) 用于关联云联网实例申请过期时，重新申请关联操作。
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnRequest"/></param>
        /// <returns><see cref="ResetAttachCcnResponse"/></returns>
        public ResetAttachCcnResponse ResetAttachCcnSync(ResetAttachCcnRequest req)
        {
            return InternalRequestAsync<ResetAttachCcnResponse>(req, "ResetAttachCcn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ResetFirewallTemplateRules) 用于重置防火墙模板下所有规则。
        /// </summary>
        /// <param name="req"><see cref="ResetFirewallTemplateRulesRequest"/></param>
        /// <returns><see cref="ResetFirewallTemplateRulesResponse"/></returns>
        public Task<ResetFirewallTemplateRulesResponse> ResetFirewallTemplateRules(ResetFirewallTemplateRulesRequest req)
        {
            return InternalRequestAsync<ResetFirewallTemplateRulesResponse>(req, "ResetFirewallTemplateRules");
        }

        /// <summary>
        /// 本接口 (ResetFirewallTemplateRules) 用于重置防火墙模板下所有规则。
        /// </summary>
        /// <param name="req"><see cref="ResetFirewallTemplateRulesRequest"/></param>
        /// <returns><see cref="ResetFirewallTemplateRulesResponse"/></returns>
        public ResetFirewallTemplateRulesResponse ResetFirewallTemplateRulesSync(ResetFirewallTemplateRulesRequest req)
        {
            return InternalRequestAsync<ResetFirewallTemplateRulesResponse>(req, "ResetFirewallTemplateRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetInstance）用于重装指定实例上的镜像。
        /// 
        /// * 仅`RUNNING`，`STOPPED`状态的机器，且当前机器无变更中的操作，才支持重装系统。
        /// * 如果指定了 BlueprintId 参数，则使用指定的镜像重装，否则按照当前实例使用的镜像进行重装。
        /// * 非中国大陆地域的实例不支持使用该接口实现LIUNX_UNIX和WINDOWS操作系统切换。
        /// * 系统盘将会被格式化，并重置，请确保系统盘中无重要文件。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// * 对于游戏专区实例，仅支持重装当前镜像。
        /// </summary>
        /// <param name="req"><see cref="ResetInstanceRequest"/></param>
        /// <returns><see cref="ResetInstanceResponse"/></returns>
        public Task<ResetInstanceResponse> ResetInstance(ResetInstanceRequest req)
        {
            return InternalRequestAsync<ResetInstanceResponse>(req, "ResetInstance");
        }

        /// <summary>
        /// 本接口（ResetInstance）用于重装指定实例上的镜像。
        /// 
        /// * 仅`RUNNING`，`STOPPED`状态的机器，且当前机器无变更中的操作，才支持重装系统。
        /// * 如果指定了 BlueprintId 参数，则使用指定的镜像重装，否则按照当前实例使用的镜像进行重装。
        /// * 非中国大陆地域的实例不支持使用该接口实现LIUNX_UNIX和WINDOWS操作系统切换。
        /// * 系统盘将会被格式化，并重置，请确保系统盘中无重要文件。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// * 对于游戏专区实例，仅支持重装当前镜像。
        /// </summary>
        /// <param name="req"><see cref="ResetInstanceRequest"/></param>
        /// <returns><see cref="ResetInstanceResponse"/></returns>
        public ResetInstanceResponse ResetInstanceSync(ResetInstanceRequest req)
        {
            return InternalRequestAsync<ResetInstanceResponse>(req, "ResetInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetInstancesPassword）用于将实例操作系统的密码重置为用户指定的密码。
        /// * 只修改管理员账号的密码。实例的操作系统不同，管理员账号也会不一样（Windows 为 Administrator，Ubuntu 为 ubuntu ，其它系统为 root）。
        /// * 支持批量操作。将多个实例操作系统的密码重置为相同的密码。每次请求批量实例的上限为 100。
        /// * 建议对运行中的实例先手动关机，然后再进行密码重置。如实例处于运行中状态，本接口操作过程中会对实例进行关机操作，尝试正常关机失败后进行强制关机。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// 注意：强制关机的效果等同于关闭物理计算机的电源开关。强制关机可能会导致数据丢失或文件系统损坏。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public Task<ResetInstancesPasswordResponse> ResetInstancesPassword(ResetInstancesPasswordRequest req)
        {
            return InternalRequestAsync<ResetInstancesPasswordResponse>(req, "ResetInstancesPassword");
        }

        /// <summary>
        /// 本接口（ResetInstancesPassword）用于将实例操作系统的密码重置为用户指定的密码。
        /// * 只修改管理员账号的密码。实例的操作系统不同，管理员账号也会不一样（Windows 为 Administrator，Ubuntu 为 ubuntu ，其它系统为 root）。
        /// * 支持批量操作。将多个实例操作系统的密码重置为相同的密码。每次请求批量实例的上限为 100。
        /// * 建议对运行中的实例先手动关机，然后再进行密码重置。如实例处于运行中状态，本接口操作过程中会对实例进行关机操作，尝试正常关机失败后进行强制关机。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// 注意：强制关机的效果等同于关闭物理计算机的电源开关。强制关机可能会导致数据丢失或文件系统损坏。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public ResetInstancesPasswordResponse ResetInstancesPasswordSync(ResetInstancesPasswordRequest req)
        {
            return InternalRequestAsync<ResetInstancesPasswordResponse>(req, "ResetInstancesPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ResizeDisks)用于扩容云硬盘。该操作目前仅支持云硬盘类型为数据盘且状态处于ATTACHED（已挂载）或 UNATTACHED（待挂载）的云硬盘。
        /// </summary>
        /// <param name="req"><see cref="ResizeDisksRequest"/></param>
        /// <returns><see cref="ResizeDisksResponse"/></returns>
        public Task<ResizeDisksResponse> ResizeDisks(ResizeDisksRequest req)
        {
            return InternalRequestAsync<ResizeDisksResponse>(req, "ResizeDisks");
        }

        /// <summary>
        /// 本接口(ResizeDisks)用于扩容云硬盘。该操作目前仅支持云硬盘类型为数据盘且状态处于ATTACHED（已挂载）或 UNATTACHED（待挂载）的云硬盘。
        /// </summary>
        /// <param name="req"><see cref="ResizeDisksRequest"/></param>
        /// <returns><see cref="ResizeDisksResponse"/></returns>
        public ResizeDisksResponse ResizeDisksSync(ResizeDisksRequest req)
        {
            return InternalRequestAsync<ResizeDisksResponse>(req, "ResizeDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询重启情况。
        /// </summary>
        /// <param name="req"><see cref="RestartDockerContainersRequest"/></param>
        /// <returns><see cref="RestartDockerContainersResponse"/></returns>
        public Task<RestartDockerContainersResponse> RestartDockerContainers(RestartDockerContainersRequest req)
        {
            return InternalRequestAsync<RestartDockerContainersResponse>(req, "RestartDockerContainers");
        }

        /// <summary>
        /// 重启实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询重启情况。
        /// </summary>
        /// <param name="req"><see cref="RestartDockerContainersRequest"/></param>
        /// <returns><see cref="RestartDockerContainersResponse"/></returns>
        public RestartDockerContainersResponse RestartDockerContainersSync(RestartDockerContainersRequest req)
        {
            return InternalRequestAsync<RestartDockerContainersResponse>(req, "RestartDockerContainers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RestartMcpServers）用于重启实例中的MCP Server。
        /// - 本接口为异步接口，API返回时操作并未立即完成。MCP Server的操作结果可以通过调用 DescribeMcpServers 接口查询。
        /// - 本接口在操作多个MCP Server时，不会因为某一个失败而停止。您需要通过调用 DescribeMcpServers 接口查询最终操作结果。
        /// </summary>
        /// <param name="req"><see cref="RestartMcpServersRequest"/></param>
        /// <returns><see cref="RestartMcpServersResponse"/></returns>
        public Task<RestartMcpServersResponse> RestartMcpServers(RestartMcpServersRequest req)
        {
            return InternalRequestAsync<RestartMcpServersResponse>(req, "RestartMcpServers");
        }

        /// <summary>
        /// 本接口（RestartMcpServers）用于重启实例中的MCP Server。
        /// - 本接口为异步接口，API返回时操作并未立即完成。MCP Server的操作结果可以通过调用 DescribeMcpServers 接口查询。
        /// - 本接口在操作多个MCP Server时，不会因为某一个失败而停止。您需要通过调用 DescribeMcpServers 接口查询最终操作结果。
        /// </summary>
        /// <param name="req"><see cref="RestartMcpServersRequest"/></param>
        /// <returns><see cref="RestartMcpServersResponse"/></returns>
        public RestartMcpServersResponse RestartMcpServersSync(RestartMcpServersRequest req)
        {
            return InternalRequestAsync<RestartMcpServersResponse>(req, "RestartMcpServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建并运行多个Docker容器，之后可以通过返回的ActivityIds调用<a href="https://cloud.tencent.com/document/product/1207/95476" target="_blank">DescribeDockerActivities</a>接口查询创建情况。
        /// </summary>
        /// <param name="req"><see cref="RunDockerContainersRequest"/></param>
        /// <returns><see cref="RunDockerContainersResponse"/></returns>
        public Task<RunDockerContainersResponse> RunDockerContainers(RunDockerContainersRequest req)
        {
            return InternalRequestAsync<RunDockerContainersResponse>(req, "RunDockerContainers");
        }

        /// <summary>
        /// 创建并运行多个Docker容器，之后可以通过返回的ActivityIds调用<a href="https://cloud.tencent.com/document/product/1207/95476" target="_blank">DescribeDockerActivities</a>接口查询创建情况。
        /// </summary>
        /// <param name="req"><see cref="RunDockerContainersRequest"/></param>
        /// <returns><see cref="RunDockerContainersResponse"/></returns>
        public RunDockerContainersResponse RunDockerContainersSync(RunDockerContainersRequest req)
        {
            return InternalRequestAsync<RunDockerContainersResponse>(req, "RunDockerContainers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ShareBlueprintAcrossAccounts）用于跨账号共享镜像。
        /// 仅支持共享自定义镜像， 且用于共享的镜像状态必须为NORMAL。
        /// 共享的账号必须为主账号。
        /// </summary>
        /// <param name="req"><see cref="ShareBlueprintAcrossAccountsRequest"/></param>
        /// <returns><see cref="ShareBlueprintAcrossAccountsResponse"/></returns>
        public Task<ShareBlueprintAcrossAccountsResponse> ShareBlueprintAcrossAccounts(ShareBlueprintAcrossAccountsRequest req)
        {
            return InternalRequestAsync<ShareBlueprintAcrossAccountsResponse>(req, "ShareBlueprintAcrossAccounts");
        }

        /// <summary>
        /// 本接口（ShareBlueprintAcrossAccounts）用于跨账号共享镜像。
        /// 仅支持共享自定义镜像， 且用于共享的镜像状态必须为NORMAL。
        /// 共享的账号必须为主账号。
        /// </summary>
        /// <param name="req"><see cref="ShareBlueprintAcrossAccountsRequest"/></param>
        /// <returns><see cref="ShareBlueprintAcrossAccountsResponse"/></returns>
        public ShareBlueprintAcrossAccountsResponse ShareBlueprintAcrossAccountsSync(ShareBlueprintAcrossAccountsRequest req)
        {
            return InternalRequestAsync<ShareBlueprintAcrossAccountsResponse>(req, "ShareBlueprintAcrossAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询启动情况。
        /// </summary>
        /// <param name="req"><see cref="StartDockerContainersRequest"/></param>
        /// <returns><see cref="StartDockerContainersResponse"/></returns>
        public Task<StartDockerContainersResponse> StartDockerContainers(StartDockerContainersRequest req)
        {
            return InternalRequestAsync<StartDockerContainersResponse>(req, "StartDockerContainers");
        }

        /// <summary>
        /// 启动实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询启动情况。
        /// </summary>
        /// <param name="req"><see cref="StartDockerContainersRequest"/></param>
        /// <returns><see cref="StartDockerContainersResponse"/></returns>
        public StartDockerContainersResponse StartDockerContainersSync(StartDockerContainersRequest req)
        {
            return InternalRequestAsync<StartDockerContainersResponse>(req, "StartDockerContainers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartInstances）用于启动一个或多个实例。
        /// 
        /// * 只有状态为 STOPPED 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 STARTING 状态；启动实例成功时，实例会进入 RUNNING 状态。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances");
        }

        /// <summary>
        /// 本接口（StartInstances）用于启动一个或多个实例。
        /// 
        /// * 只有状态为 STOPPED 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 STARTING 状态；启动实例成功时，实例会进入 RUNNING 状态。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public StartInstancesResponse StartInstancesSync(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartMcpServers）用于开启实例中的MCP Server。
        /// - 本接口为异步接口，API返回时操作并未立即完成。MCP Server的操作结果可以通过调用 DescribeMcpServers 接口查询。
        /// - 本接口在操作多个MCP Server时，不会因为某一个失败而停止。您需要通过调用 DescribeMcpServers 接口查询最终操作结果。
        /// </summary>
        /// <param name="req"><see cref="StartMcpServersRequest"/></param>
        /// <returns><see cref="StartMcpServersResponse"/></returns>
        public Task<StartMcpServersResponse> StartMcpServers(StartMcpServersRequest req)
        {
            return InternalRequestAsync<StartMcpServersResponse>(req, "StartMcpServers");
        }

        /// <summary>
        /// 本接口（StartMcpServers）用于开启实例中的MCP Server。
        /// - 本接口为异步接口，API返回时操作并未立即完成。MCP Server的操作结果可以通过调用 DescribeMcpServers 接口查询。
        /// - 本接口在操作多个MCP Server时，不会因为某一个失败而停止。您需要通过调用 DescribeMcpServers 接口查询最终操作结果。
        /// </summary>
        /// <param name="req"><see cref="StartMcpServersRequest"/></param>
        /// <returns><see cref="StartMcpServersResponse"/></returns>
        public StartMcpServersResponse StartMcpServersSync(StartMcpServersRequest req)
        {
            return InternalRequestAsync<StartMcpServersResponse>(req, "StartMcpServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询停止情况。
        /// </summary>
        /// <param name="req"><see cref="StopDockerContainersRequest"/></param>
        /// <returns><see cref="StopDockerContainersResponse"/></returns>
        public Task<StopDockerContainersResponse> StopDockerContainers(StopDockerContainersRequest req)
        {
            return InternalRequestAsync<StopDockerContainersResponse>(req, "StopDockerContainers");
        }

        /// <summary>
        /// 停止实例内的Docker容器，之后可以通过返回的ActivityId调用[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口查询停止情况。
        /// </summary>
        /// <param name="req"><see cref="StopDockerContainersRequest"/></param>
        /// <returns><see cref="StopDockerContainersResponse"/></returns>
        public StopDockerContainersResponse StopDockerContainersSync(StopDockerContainersRequest req)
        {
            return InternalRequestAsync<StopDockerContainersResponse>(req, "StopDockerContainers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StopInstances）用于关闭一个或多个实例。
        /// * 只有状态为 RUNNING 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 STOPPING 状态；关闭实例成功时，实例会进入 STOPPED 状态。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances");
        }

        /// <summary>
        /// 本接口（StopInstances）用于关闭一个或多个实例。
        /// * 只有状态为 RUNNING 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 STOPPING 状态；关闭实例成功时，实例会进入 STOPPED 状态。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public StopInstancesResponse StopInstancesSync(StopInstancesRequest req)
        {
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StopMcpServers）用于关闭实例中的MCP Server。
        /// - 本接口为异步接口，API返回时操作并未立即完成。MCP Server的操作结果可以通过调用 DescribeMcpServers 接口查询。
        /// - 本接口在操作多个MCP Server时，不会因为某一个失败而停止。您需要通过调用 DescribeMcpServers 接口查询最终操作结果。
        /// </summary>
        /// <param name="req"><see cref="StopMcpServersRequest"/></param>
        /// <returns><see cref="StopMcpServersResponse"/></returns>
        public Task<StopMcpServersResponse> StopMcpServers(StopMcpServersRequest req)
        {
            return InternalRequestAsync<StopMcpServersResponse>(req, "StopMcpServers");
        }

        /// <summary>
        /// 本接口（StopMcpServers）用于关闭实例中的MCP Server。
        /// - 本接口为异步接口，API返回时操作并未立即完成。MCP Server的操作结果可以通过调用 DescribeMcpServers 接口查询。
        /// - 本接口在操作多个MCP Server时，不会因为某一个失败而停止。您需要通过调用 DescribeMcpServers 接口查询最终操作结果。
        /// </summary>
        /// <param name="req"><see cref="StopMcpServersRequest"/></param>
        /// <returns><see cref="StopMcpServersResponse"/></returns>
        public StopMcpServersResponse StopMcpServersSync(StopMcpServersRequest req)
        {
            return InternalRequestAsync<StopMcpServersResponse>(req, "StopMcpServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (SyncBlueprint) 用于将自定义镜像同步到其它地域。
        /// 
        /// * 支持向多个地域同步。最多10个地域。
        /// * 不支持向源地域同步。
        /// * 只支持NORMAL状态的镜像进行同步。
        /// * 不支持中国大陆地域和非中国大陆地域之间同步。
        /// * 可以通过[DescribeBlueprints](https://cloud.tencent.com/document/api/1207/47689)查询镜像状态，当镜像状态为NORMAL时表示源地域同步结束。
        /// </summary>
        /// <param name="req"><see cref="SyncBlueprintRequest"/></param>
        /// <returns><see cref="SyncBlueprintResponse"/></returns>
        public Task<SyncBlueprintResponse> SyncBlueprint(SyncBlueprintRequest req)
        {
            return InternalRequestAsync<SyncBlueprintResponse>(req, "SyncBlueprint");
        }

        /// <summary>
        /// 本接口 (SyncBlueprint) 用于将自定义镜像同步到其它地域。
        /// 
        /// * 支持向多个地域同步。最多10个地域。
        /// * 不支持向源地域同步。
        /// * 只支持NORMAL状态的镜像进行同步。
        /// * 不支持中国大陆地域和非中国大陆地域之间同步。
        /// * 可以通过[DescribeBlueprints](https://cloud.tencent.com/document/api/1207/47689)查询镜像状态，当镜像状态为NORMAL时表示源地域同步结束。
        /// </summary>
        /// <param name="req"><see cref="SyncBlueprintRequest"/></param>
        /// <returns><see cref="SyncBlueprintResponse"/></returns>
        public SyncBlueprintResponse SyncBlueprintSync(SyncBlueprintRequest req)
        {
            return InternalRequestAsync<SyncBlueprintResponse>(req, "SyncBlueprint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（TerminateDisks）用于销毁一个或多个云硬盘。
        /// 云硬盘状态必须处于SHUTDOWN（已隔离）状态。
        /// </summary>
        /// <param name="req"><see cref="TerminateDisksRequest"/></param>
        /// <returns><see cref="TerminateDisksResponse"/></returns>
        public Task<TerminateDisksResponse> TerminateDisks(TerminateDisksRequest req)
        {
            return InternalRequestAsync<TerminateDisksResponse>(req, "TerminateDisks");
        }

        /// <summary>
        /// 本接口（TerminateDisks）用于销毁一个或多个云硬盘。
        /// 云硬盘状态必须处于SHUTDOWN（已隔离）状态。
        /// </summary>
        /// <param name="req"><see cref="TerminateDisksRequest"/></param>
        /// <returns><see cref="TerminateDisksResponse"/></returns>
        public TerminateDisksResponse TerminateDisksSync(TerminateDisksRequest req)
        {
            return InternalRequestAsync<TerminateDisksResponse>(req, "TerminateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (TerminateInstances) 用于销毁实例。
        /// 
        /// * 处于 SHUTDOWN 状态的实例，可通过本接口销毁，且不可恢复。
        /// * 支持批量操作，每次请求批量实例的上限为100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果返回列表中不存在该实例，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances");
        }

        /// <summary>
        /// 本接口 (TerminateInstances) 用于销毁实例。
        /// 
        /// * 处于 SHUTDOWN 状态的实例，可通过本接口销毁，且不可恢复。
        /// * 支持批量操作，每次请求批量实例的上限为100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 <a href="https://cloud.tencent.com/document/product/1207/47573" target="_blank">DescribeInstances</a> 接口查询，如果返回列表中不存在该实例，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
