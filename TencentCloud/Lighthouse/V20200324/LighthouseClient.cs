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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LighthouseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 本接口（ApplyInstanceSnapshot）用于回滚指定实例的系统盘快照。
        /// <li>仅支持回滚到原系统盘。</li>
        /// <li>用于回滚的快照必须处于 NORMAL 状态。快照状态可以通 DescribeSnapshots 接口查询，见输出参数中 SnapshotState 字段解释。</li>
        /// <li>回滚快照时，实例的状态必须为 STOPPED 或 RUNNING，可通过 DescribeInstances 接口查询实例状态。处于 RUNNING 状态的实例会强制关机，然后回滚快照。</li>
        /// </summary>
        /// <param name="req"><see cref="ApplyInstanceSnapshotRequest"/></param>
        /// <returns><see cref="ApplyInstanceSnapshotResponse"/></returns>
        public async Task<ApplyInstanceSnapshotResponse> ApplyInstanceSnapshot(ApplyInstanceSnapshotRequest req)
        {
             JsonResponseModel<ApplyInstanceSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyInstanceSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyInstanceSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ApplyInstanceSnapshot）用于回滚指定实例的系统盘快照。
        /// <li>仅支持回滚到原系统盘。</li>
        /// <li>用于回滚的快照必须处于 NORMAL 状态。快照状态可以通 DescribeSnapshots 接口查询，见输出参数中 SnapshotState 字段解释。</li>
        /// <li>回滚快照时，实例的状态必须为 STOPPED 或 RUNNING，可通过 DescribeInstances 接口查询实例状态。处于 RUNNING 状态的实例会强制关机，然后回滚快照。</li>
        /// </summary>
        /// <param name="req"><see cref="ApplyInstanceSnapshotRequest"/></param>
        /// <returns><see cref="ApplyInstanceSnapshotResponse"/></returns>
        public ApplyInstanceSnapshotResponse ApplyInstanceSnapshotSync(ApplyInstanceSnapshotRequest req)
        {
             JsonResponseModel<ApplyInstanceSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyInstanceSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyInstanceSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssociateInstancesKeyPairs）用于绑定用户指定密钥对到实例。
        /// * 只支持 [RUNNING, STOPPED] 状态的 LINUX_UNIX 操作系统的实例。处于 RUNNING 状态的实例会强制关机，然后绑定。
        /// * 将密钥的公钥写入到实例的 SSH 配置当中，用户就可以通过该密钥的私钥来登录实例。
        /// * 如果实例原来绑定过密钥，那么原来的密钥将失效。
        /// * 如果实例原来是通过密码登录，绑定密钥后无法使用密码登录。
        /// * 支持批量操作。每次请求批量实例的上限为 100。如果批量实例存在不允许操作的实例，操作会以特定错误码返回。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="AssociateInstancesKeyPairsResponse"/></returns>
        public async Task<AssociateInstancesKeyPairsResponse> AssociateInstancesKeyPairs(AssociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<AssociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssociateInstancesKeyPairs）用于绑定用户指定密钥对到实例。
        /// * 只支持 [RUNNING, STOPPED] 状态的 LINUX_UNIX 操作系统的实例。处于 RUNNING 状态的实例会强制关机，然后绑定。
        /// * 将密钥的公钥写入到实例的 SSH 配置当中，用户就可以通过该密钥的私钥来登录实例。
        /// * 如果实例原来绑定过密钥，那么原来的密钥将失效。
        /// * 如果实例原来是通过密码登录，绑定密钥后无法使用密码登录。
        /// * 支持批量操作。每次请求批量实例的上限为 100。如果批量实例存在不允许操作的实例，操作会以特定错误码返回。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="AssociateInstancesKeyPairsResponse"/></returns>
        public AssociateInstancesKeyPairsResponse AssociateInstancesKeyPairsSync(AssociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<AssociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AttachCcn) 用于建立与云联网的关联。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnRequest"/></param>
        /// <returns><see cref="AttachCcnResponse"/></returns>
        public async Task<AttachCcnResponse> AttachCcn(AttachCcnRequest req)
        {
             JsonResponseModel<AttachCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AttachCcn) 用于建立与云联网的关联。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnRequest"/></param>
        /// <returns><see cref="AttachCcnResponse"/></returns>
        public AttachCcnResponse AttachCcnSync(AttachCcnRequest req)
        {
             JsonResponseModel<AttachCcnResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachDisks）用于挂载一个或多个云硬盘。
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public async Task<AttachDisksResponse> AttachDisks(AttachDisksRequest req)
        {
             JsonResponseModel<AttachDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachDisks）用于挂载一个或多个云硬盘。
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public AttachDisksResponse AttachDisksSync(AttachDisksRequest req)
        {
             JsonResponseModel<AttachDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateBlueprint) 用于创建镜像。
        /// </summary>
        /// <param name="req"><see cref="CreateBlueprintRequest"/></param>
        /// <returns><see cref="CreateBlueprintResponse"/></returns>
        public async Task<CreateBlueprintResponse> CreateBlueprint(CreateBlueprintRequest req)
        {
             JsonResponseModel<CreateBlueprintResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBlueprint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlueprintResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateBlueprint) 用于创建镜像。
        /// </summary>
        /// <param name="req"><see cref="CreateBlueprintRequest"/></param>
        /// <returns><see cref="CreateBlueprintResponse"/></returns>
        public CreateBlueprintResponse CreateBlueprintSync(CreateBlueprintRequest req)
        {
             JsonResponseModel<CreateBlueprintResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBlueprint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlueprintResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateFirewallRules）用于在实例上添加防火墙规则。
        /// 
        /// 
        /// * FirewallVersion 为防火墙版本号，用户每次更新防火墙规则版本会自动加1，防止您更新的规则已过期，不填不考虑冲突。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="CreateFirewallRulesRequest"/></param>
        /// <returns><see cref="CreateFirewallRulesResponse"/></returns>
        public async Task<CreateFirewallRulesResponse> CreateFirewallRules(CreateFirewallRulesRequest req)
        {
             JsonResponseModel<CreateFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateFirewallRules）用于在实例上添加防火墙规则。
        /// 
        /// 
        /// * FirewallVersion 为防火墙版本号，用户每次更新防火墙规则版本会自动加1，防止您更新的规则已过期，不填不考虑冲突。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="CreateFirewallRulesRequest"/></param>
        /// <returns><see cref="CreateFirewallRulesResponse"/></returns>
        public CreateFirewallRulesResponse CreateFirewallRulesSync(CreateFirewallRulesRequest req)
        {
             JsonResponseModel<CreateFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateInstanceSnapshot）用于创建指定实例的系统盘快照。
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceSnapshotRequest"/></param>
        /// <returns><see cref="CreateInstanceSnapshotResponse"/></returns>
        public async Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshot(CreateInstanceSnapshotRequest req)
        {
             JsonResponseModel<CreateInstanceSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateInstanceSnapshot）用于创建指定实例的系统盘快照。
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceSnapshotRequest"/></param>
        /// <returns><see cref="CreateInstanceSnapshotResponse"/></returns>
        public CreateInstanceSnapshotResponse CreateInstanceSnapshotSync(CreateInstanceSnapshotRequest req)
        {
             JsonResponseModel<CreateInstanceSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateInstances)用于创建一个或多个指定套餐的轻量应用服务器实例。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public async Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateInstances)用于创建一个或多个指定套餐的轻量应用服务器实例。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateKeyPair）用于创建一个密钥对。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public async Task<CreateKeyPairResponse> CreateKeyPair(CreateKeyPairRequest req)
        {
             JsonResponseModel<CreateKeyPairResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateKeyPair）用于创建一个密钥对。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public CreateKeyPairResponse CreateKeyPairSync(CreateKeyPairRequest req)
        {
             JsonResponseModel<CreateKeyPairResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteBlueprints) 用于删除镜像。
        /// </summary>
        /// <param name="req"><see cref="DeleteBlueprintsRequest"/></param>
        /// <returns><see cref="DeleteBlueprintsResponse"/></returns>
        public async Task<DeleteBlueprintsResponse> DeleteBlueprints(DeleteBlueprintsRequest req)
        {
             JsonResponseModel<DeleteBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteBlueprints) 用于删除镜像。
        /// </summary>
        /// <param name="req"><see cref="DeleteBlueprintsRequest"/></param>
        /// <returns><see cref="DeleteBlueprintsResponse"/></returns>
        public DeleteBlueprintsResponse DeleteBlueprintsSync(DeleteBlueprintsRequest req)
        {
             JsonResponseModel<DeleteBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteFirewallRules）用于删除实例的防火墙规则。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接删除指定的规则。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="DeleteFirewallRulesRequest"/></param>
        /// <returns><see cref="DeleteFirewallRulesResponse"/></returns>
        public async Task<DeleteFirewallRulesResponse> DeleteFirewallRules(DeleteFirewallRulesRequest req)
        {
             JsonResponseModel<DeleteFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteFirewallRules）用于删除实例的防火墙规则。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接删除指定的规则。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="DeleteFirewallRulesRequest"/></param>
        /// <returns><see cref="DeleteFirewallRulesResponse"/></returns>
        public DeleteFirewallRulesResponse DeleteFirewallRulesSync(DeleteFirewallRulesRequest req)
        {
             JsonResponseModel<DeleteFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteKeyPairs）用于删除密钥对。
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public async Task<DeleteKeyPairsResponse> DeleteKeyPairs(DeleteKeyPairsRequest req)
        {
             JsonResponseModel<DeleteKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteKeyPairs）用于删除密钥对。
        /// </summary>
        /// <param name="req"><see cref="DeleteKeyPairsRequest"/></param>
        /// <returns><see cref="DeleteKeyPairsResponse"/></returns>
        public DeleteKeyPairsResponse DeleteKeyPairsSync(DeleteKeyPairsRequest req)
        {
             JsonResponseModel<DeleteKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteSnapshots）用于删除快照。
        /// 快照必须处于 NORMAL 状态，快照状态可以通过 DescribeSnapshots 接口查询，见输出参数中 SnapshotState 字段解释。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public async Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest req)
        {
             JsonResponseModel<DeleteSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteSnapshots）用于删除快照。
        /// 快照必须处于 NORMAL 状态，快照状态可以通过 DescribeSnapshots 接口查询，见输出参数中 SnapshotState 字段解释。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public DeleteSnapshotsResponse DeleteSnapshotsSync(DeleteSnapshotsRequest req)
        {
             JsonResponseModel<DeleteSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBlueprintInstances）用于查询镜像实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintInstancesRequest"/></param>
        /// <returns><see cref="DescribeBlueprintInstancesResponse"/></returns>
        public async Task<DescribeBlueprintInstancesResponse> DescribeBlueprintInstances(DescribeBlueprintInstancesRequest req)
        {
             JsonResponseModel<DescribeBlueprintInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlueprintInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlueprintInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBlueprintInstances）用于查询镜像实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintInstancesRequest"/></param>
        /// <returns><see cref="DescribeBlueprintInstancesResponse"/></returns>
        public DescribeBlueprintInstancesResponse DescribeBlueprintInstancesSync(DescribeBlueprintInstancesRequest req)
        {
             JsonResponseModel<DescribeBlueprintInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlueprintInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlueprintInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBlueprints）用于查询镜像信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeBlueprintsResponse"/></returns>
        public async Task<DescribeBlueprintsResponse> DescribeBlueprints(DescribeBlueprintsRequest req)
        {
             JsonResponseModel<DescribeBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBlueprints）用于查询镜像信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeBlueprintsResponse"/></returns>
        public DescribeBlueprintsResponse DescribeBlueprintsSync(DescribeBlueprintsRequest req)
        {
             JsonResponseModel<DescribeBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBundleDiscount）用于查询套餐折扣信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBundleDiscountRequest"/></param>
        /// <returns><see cref="DescribeBundleDiscountResponse"/></returns>
        public async Task<DescribeBundleDiscountResponse> DescribeBundleDiscount(DescribeBundleDiscountRequest req)
        {
             JsonResponseModel<DescribeBundleDiscountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBundleDiscount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBundleDiscountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBundleDiscount）用于查询套餐折扣信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBundleDiscountRequest"/></param>
        /// <returns><see cref="DescribeBundleDiscountResponse"/></returns>
        public DescribeBundleDiscountResponse DescribeBundleDiscountSync(DescribeBundleDiscountRequest req)
        {
             JsonResponseModel<DescribeBundleDiscountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBundleDiscount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBundleDiscountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBundles）用于查询套餐信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBundlesRequest"/></param>
        /// <returns><see cref="DescribeBundlesResponse"/></returns>
        public async Task<DescribeBundlesResponse> DescribeBundles(DescribeBundlesRequest req)
        {
             JsonResponseModel<DescribeBundlesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBundles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBundlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBundles）用于查询套餐信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBundlesRequest"/></param>
        /// <returns><see cref="DescribeBundlesResponse"/></returns>
        public DescribeBundlesResponse DescribeBundlesSync(DescribeBundlesRequest req)
        {
             JsonResponseModel<DescribeBundlesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBundles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBundlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeCcnAttachedInstances) 用于查询云联网关联的实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public async Task<DescribeCcnAttachedInstancesResponse> DescribeCcnAttachedInstances(DescribeCcnAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeCcnAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeCcnAttachedInstances) 用于查询云联网关联的实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public DescribeCcnAttachedInstancesResponse DescribeCcnAttachedInstancesSync(DescribeCcnAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeCcnAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcnAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDiskConfigs）用于查询云硬盘配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigsRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigsResponse"/></returns>
        public async Task<DescribeDiskConfigsResponse> DescribeDiskConfigs(DescribeDiskConfigsRequest req)
        {
             JsonResponseModel<DescribeDiskConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiskConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDiskConfigs）用于查询云硬盘配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskConfigsRequest"/></param>
        /// <returns><see cref="DescribeDiskConfigsResponse"/></returns>
        public DescribeDiskConfigsResponse DescribeDiskConfigsSync(DescribeDiskConfigsRequest req)
        {
             JsonResponseModel<DescribeDiskConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiskConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDiskDiscount)用于查询云硬盘折扣信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskDiscountRequest"/></param>
        /// <returns><see cref="DescribeDiskDiscountResponse"/></returns>
        public async Task<DescribeDiskDiscountResponse> DescribeDiskDiscount(DescribeDiskDiscountRequest req)
        {
             JsonResponseModel<DescribeDiskDiscountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiskDiscount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskDiscountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDiskDiscount)用于查询云硬盘折扣信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiskDiscountRequest"/></param>
        /// <returns><see cref="DescribeDiskDiscountResponse"/></returns>
        public DescribeDiskDiscountResponse DescribeDiskDiscountSync(DescribeDiskDiscountRequest req)
        {
             JsonResponseModel<DescribeDiskDiscountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiskDiscount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiskDiscountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDisks）用于查询云硬盘信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public async Task<DescribeDisksResponse> DescribeDisks(DescribeDisksRequest req)
        {
             JsonResponseModel<DescribeDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDisks）用于查询云硬盘信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public DescribeDisksResponse DescribeDisksSync(DescribeDisksRequest req)
        {
             JsonResponseModel<DescribeDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDisksDeniedActions）用于查询一个或多个云硬盘的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDisksDeniedActionsResponse"/></returns>
        public async Task<DescribeDisksDeniedActionsResponse> DescribeDisksDeniedActions(DescribeDisksDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeDisksDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDisksDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDisksDeniedActions）用于查询一个或多个云硬盘的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDisksDeniedActionsResponse"/></returns>
        public DescribeDisksDeniedActionsResponse DescribeDisksDeniedActionsSync(DescribeDisksDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeDisksDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDisksDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDisksReturnable）用于查询云硬盘是否可退还。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksReturnableRequest"/></param>
        /// <returns><see cref="DescribeDisksReturnableResponse"/></returns>
        public async Task<DescribeDisksReturnableResponse> DescribeDisksReturnable(DescribeDisksReturnableRequest req)
        {
             JsonResponseModel<DescribeDisksReturnableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDisksReturnable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksReturnableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDisksReturnable）用于查询云硬盘是否可退还。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksReturnableRequest"/></param>
        /// <returns><see cref="DescribeDisksReturnableResponse"/></returns>
        public DescribeDisksReturnableResponse DescribeDisksReturnableSync(DescribeDisksReturnableRequest req)
        {
             JsonResponseModel<DescribeDisksReturnableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDisksReturnable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDisksReturnableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFirewallRules）用于查询实例的防火墙规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesResponse"/></returns>
        public async Task<DescribeFirewallRulesResponse> DescribeFirewallRules(DescribeFirewallRulesRequest req)
        {
             JsonResponseModel<DescribeFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFirewallRules）用于查询实例的防火墙规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesResponse"/></returns>
        public DescribeFirewallRulesResponse DescribeFirewallRulesSync(DescribeFirewallRulesRequest req)
        {
             JsonResponseModel<DescribeFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFirewallRulesTemplate）用于查询防火墙规则模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesTemplateRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesTemplateResponse"/></returns>
        public async Task<DescribeFirewallRulesTemplateResponse> DescribeFirewallRulesTemplate(DescribeFirewallRulesTemplateRequest req)
        {
             JsonResponseModel<DescribeFirewallRulesTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFirewallRulesTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirewallRulesTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFirewallRulesTemplate）用于查询防火墙规则模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirewallRulesTemplateRequest"/></param>
        /// <returns><see cref="DescribeFirewallRulesTemplateResponse"/></returns>
        public DescribeFirewallRulesTemplateResponse DescribeFirewallRulesTemplateSync(DescribeFirewallRulesTemplateRequest req)
        {
             JsonResponseModel<DescribeFirewallRulesTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFirewallRulesTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirewallRulesTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGeneralResourceQuotas）用于查询通用资源配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralResourceQuotasRequest"/></param>
        /// <returns><see cref="DescribeGeneralResourceQuotasResponse"/></returns>
        public async Task<DescribeGeneralResourceQuotasResponse> DescribeGeneralResourceQuotas(DescribeGeneralResourceQuotasRequest req)
        {
             JsonResponseModel<DescribeGeneralResourceQuotasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGeneralResourceQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGeneralResourceQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGeneralResourceQuotas）用于查询通用资源配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralResourceQuotasRequest"/></param>
        /// <returns><see cref="DescribeGeneralResourceQuotasResponse"/></returns>
        public DescribeGeneralResourceQuotasResponse DescribeGeneralResourceQuotasSync(DescribeGeneralResourceQuotasRequest req)
        {
             JsonResponseModel<DescribeGeneralResourceQuotasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGeneralResourceQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGeneralResourceQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询实例默认登录密钥属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="DescribeInstanceLoginKeyPairAttributeResponse"/></returns>
        public async Task<DescribeInstanceLoginKeyPairAttributeResponse> DescribeInstanceLoginKeyPairAttribute(DescribeInstanceLoginKeyPairAttributeRequest req)
        {
             JsonResponseModel<DescribeInstanceLoginKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceLoginKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLoginKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询实例默认登录密钥属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="DescribeInstanceLoginKeyPairAttributeResponse"/></returns>
        public DescribeInstanceLoginKeyPairAttributeResponse DescribeInstanceLoginKeyPairAttributeSync(DescribeInstanceLoginKeyPairAttributeRequest req)
        {
             JsonResponseModel<DescribeInstanceLoginKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceLoginKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLoginKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceVncUrl）用于查询实例管理终端地址，获取的地址可用于实例的 VNC 登录。
        /// 
        /// * 处于 RUNNING 状态的机器可使用此功能。
        /// * 管理终端地址的有效期为 15 秒，调用接口成功后如果 15 秒内不使用该链接进行访问，管理终端地址自动失效，您需要重新查询。
        /// * 管理终端地址一旦被访问，将自动失效，您需要重新查询。
        /// * 如果连接断开，每分钟内重新连接的次数不能超过 30 次。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceVncUrl）用于查询实例管理终端地址，获取的地址可用于实例的 VNC 登录。
        /// 
        /// * 处于 RUNNING 状态的机器可使用此功能。
        /// * 管理终端地址的有效期为 15 秒，调用接口成功后如果 15 秒内不使用该链接进行访问，管理终端地址自动失效，您需要重新查询。
        /// * 管理终端地址一旦被访问，将自动失效，您需要重新查询。
        /// * 如果连接断开，每分钟内重新连接的次数不能超过 30 次。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlSync(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstancesDeniedActions）用于查询一个或多个实例的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public async Task<DescribeInstancesDeniedActionsResponse> DescribeInstancesDeniedActions(DescribeInstancesDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeInstancesDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstancesDeniedActions）用于查询一个或多个实例的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public DescribeInstancesDeniedActionsResponse DescribeInstancesDeniedActionsSync(DescribeInstancesDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeInstancesDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeInstancesDiskNum)用于查询实例挂载云硬盘数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDiskNumRequest"/></param>
        /// <returns><see cref="DescribeInstancesDiskNumResponse"/></returns>
        public async Task<DescribeInstancesDiskNumResponse> DescribeInstancesDiskNum(DescribeInstancesDiskNumRequest req)
        {
             JsonResponseModel<DescribeInstancesDiskNumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesDiskNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDiskNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeInstancesDiskNum)用于查询实例挂载云硬盘数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDiskNumRequest"/></param>
        /// <returns><see cref="DescribeInstancesDiskNumResponse"/></returns>
        public DescribeInstancesDiskNumResponse DescribeInstancesDiskNumSync(DescribeInstancesDiskNumRequest req)
        {
             JsonResponseModel<DescribeInstancesDiskNumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesDiskNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDiskNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstancesReturnable）用于查询实例是否可退还。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesReturnableRequest"/></param>
        /// <returns><see cref="DescribeInstancesReturnableResponse"/></returns>
        public async Task<DescribeInstancesReturnableResponse> DescribeInstancesReturnable(DescribeInstancesReturnableRequest req)
        {
             JsonResponseModel<DescribeInstancesReturnableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesReturnable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesReturnableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstancesReturnable）用于查询实例是否可退还。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesReturnableRequest"/></param>
        /// <returns><see cref="DescribeInstancesReturnableResponse"/></returns>
        public DescribeInstancesReturnableResponse DescribeInstancesReturnableSync(DescribeInstancesReturnableRequest req)
        {
             JsonResponseModel<DescribeInstancesReturnableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesReturnable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesReturnableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstancesTrafficPackages）用于查询一个或多个实例的流量包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeInstancesTrafficPackagesResponse"/></returns>
        public async Task<DescribeInstancesTrafficPackagesResponse> DescribeInstancesTrafficPackages(DescribeInstancesTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeInstancesTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstancesTrafficPackages）用于查询一个或多个实例的流量包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeInstancesTrafficPackagesResponse"/></returns>
        public DescribeInstancesTrafficPackagesResponse DescribeInstancesTrafficPackagesSync(DescribeInstancesTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeInstancesTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeKeyPairs) 用于查询用户密钥对信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public async Task<DescribeKeyPairsResponse> DescribeKeyPairs(DescribeKeyPairsRequest req)
        {
             JsonResponseModel<DescribeKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeKeyPairs) 用于查询用户密钥对信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKeyPairsRequest"/></param>
        /// <returns><see cref="DescribeKeyPairsResponse"/></returns>
        public DescribeKeyPairsResponse DescribeKeyPairsSync(DescribeKeyPairsRequest req)
        {
             JsonResponseModel<DescribeKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeModifyInstanceBundles）用于查询实例可变更套餐列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyInstanceBundlesRequest"/></param>
        /// <returns><see cref="DescribeModifyInstanceBundlesResponse"/></returns>
        public async Task<DescribeModifyInstanceBundlesResponse> DescribeModifyInstanceBundles(DescribeModifyInstanceBundlesRequest req)
        {
             JsonResponseModel<DescribeModifyInstanceBundlesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModifyInstanceBundles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModifyInstanceBundlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeModifyInstanceBundles）用于查询实例可变更套餐列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyInstanceBundlesRequest"/></param>
        /// <returns><see cref="DescribeModifyInstanceBundlesResponse"/></returns>
        public DescribeModifyInstanceBundlesResponse DescribeModifyInstanceBundlesSync(DescribeModifyInstanceBundlesRequest req)
        {
             JsonResponseModel<DescribeModifyInstanceBundlesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModifyInstanceBundles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModifyInstanceBundlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRegions）用于查询地域信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRegions）用于查询地域信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeResetInstanceBlueprints）查询重置实例的镜像信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeResetInstanceBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeResetInstanceBlueprintsResponse"/></returns>
        public async Task<DescribeResetInstanceBlueprintsResponse> DescribeResetInstanceBlueprints(DescribeResetInstanceBlueprintsRequest req)
        {
             JsonResponseModel<DescribeResetInstanceBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResetInstanceBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResetInstanceBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeResetInstanceBlueprints）查询重置实例的镜像信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeResetInstanceBlueprintsRequest"/></param>
        /// <returns><see cref="DescribeResetInstanceBlueprintsResponse"/></returns>
        public DescribeResetInstanceBlueprintsResponse DescribeResetInstanceBlueprintsSync(DescribeResetInstanceBlueprintsRequest req)
        {
             JsonResponseModel<DescribeResetInstanceBlueprintsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResetInstanceBlueprints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResetInstanceBlueprintsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshots）用于查询快照的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public async Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
             JsonResponseModel<DescribeSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshots）用于查询快照的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public DescribeSnapshotsResponse DescribeSnapshotsSync(DescribeSnapshotsRequest req)
        {
             JsonResponseModel<DescribeSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshotsDeniedActions）用于查询一个或多个快照的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsDeniedActionsResponse"/></returns>
        public async Task<DescribeSnapshotsDeniedActionsResponse> DescribeSnapshotsDeniedActions(DescribeSnapshotsDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeSnapshotsDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotsDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshotsDeniedActions）用于查询一个或多个快照的操作限制列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsDeniedActionsResponse"/></returns>
        public DescribeSnapshotsDeniedActionsResponse DescribeSnapshotsDeniedActionsSync(DescribeSnapshotsDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeSnapshotsDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotsDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询地域下可用区
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询地域下可用区
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AttachCcn) 用于解除与云联网的关联。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnRequest"/></param>
        /// <returns><see cref="DetachCcnResponse"/></returns>
        public async Task<DetachCcnResponse> DetachCcn(DetachCcnRequest req)
        {
             JsonResponseModel<DetachCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AttachCcn) 用于解除与云联网的关联。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnRequest"/></param>
        /// <returns><see cref="DetachCcnResponse"/></returns>
        public DetachCcnResponse DetachCcnSync(DetachCcnRequest req)
        {
             JsonResponseModel<DetachCcnResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachDisks）用于卸载一个或多个云硬盘。
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public async Task<DetachDisksResponse> DetachDisks(DetachDisksRequest req)
        {
             JsonResponseModel<DetachDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachDisks）用于卸载一个或多个云硬盘。
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public DetachDisksResponse DetachDisksSync(DetachDisksRequest req)
        {
             JsonResponseModel<DetachDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisassociateInstancesKeyPairs）用于解除实例与指定密钥对的绑定关系。
        /// 
        /// * 只支持 [RUNNING, STOPPED] 状态的 LINUX_UNIX 操作系统的实例。处于 RUNNING 状态的实例会强制关机，然后解绑。
        /// * 解绑密钥后，实例可以通过原来设置的密码登录。
        /// * 如果原来没有设置密码，解绑后将无法使用 SSH 登录。可以调用 ResetInstancesPassword 接口来设置登录密码。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public async Task<DisassociateInstancesKeyPairsResponse> DisassociateInstancesKeyPairs(DisassociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<DisassociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisassociateInstancesKeyPairs）用于解除实例与指定密钥对的绑定关系。
        /// 
        /// * 只支持 [RUNNING, STOPPED] 状态的 LINUX_UNIX 操作系统的实例。处于 RUNNING 状态的实例会强制关机，然后解绑。
        /// * 解绑密钥后，实例可以通过原来设置的密码登录。
        /// * 如果原来没有设置密码，解绑后将无法使用 SSH 登录。可以调用 ResetInstancesPassword 接口来设置登录密码。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public DisassociateInstancesKeyPairsResponse DisassociateInstancesKeyPairsSync(DisassociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<DisassociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ImportKeyPair）用于导入用户指定密钥对。
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public async Task<ImportKeyPairResponse> ImportKeyPair(ImportKeyPairRequest req)
        {
             JsonResponseModel<ImportKeyPairResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ImportKeyPair）用于导入用户指定密钥对。
        /// </summary>
        /// <param name="req"><see cref="ImportKeyPairRequest"/></param>
        /// <returns><see cref="ImportKeyPairResponse"/></returns>
        public ImportKeyPairResponse ImportKeyPairSync(ImportKeyPairRequest req)
        {
             JsonResponseModel<ImportKeyPairResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquirePriceCreateBlueprint) 用于创建镜像询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateBlueprintRequest"/></param>
        /// <returns><see cref="InquirePriceCreateBlueprintResponse"/></returns>
        public async Task<InquirePriceCreateBlueprintResponse> InquirePriceCreateBlueprint(InquirePriceCreateBlueprintRequest req)
        {
             JsonResponseModel<InquirePriceCreateBlueprintResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceCreateBlueprint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateBlueprintResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquirePriceCreateBlueprint) 用于创建镜像询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateBlueprintRequest"/></param>
        /// <returns><see cref="InquirePriceCreateBlueprintResponse"/></returns>
        public InquirePriceCreateBlueprintResponse InquirePriceCreateBlueprintSync(InquirePriceCreateBlueprintRequest req)
        {
             JsonResponseModel<InquirePriceCreateBlueprintResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceCreateBlueprint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateBlueprintResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquirePriceCreateDisks）用于新购云硬盘询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDisksResponse"/></returns>
        public async Task<InquirePriceCreateDisksResponse> InquirePriceCreateDisks(InquirePriceCreateDisksRequest req)
        {
             JsonResponseModel<InquirePriceCreateDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceCreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquirePriceCreateDisks）用于新购云硬盘询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDisksRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDisksResponse"/></returns>
        public InquirePriceCreateDisksResponse InquirePriceCreateDisksSync(InquirePriceCreateDisksRequest req)
        {
             JsonResponseModel<InquirePriceCreateDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceCreateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateInstances）用于创建实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateInstancesResponse"/></returns>
        public async Task<InquirePriceCreateInstancesResponse> InquirePriceCreateInstances(InquirePriceCreateInstancesRequest req)
        {
             JsonResponseModel<InquirePriceCreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceCreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateInstances）用于创建实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateInstancesResponse"/></returns>
        public InquirePriceCreateInstancesResponse InquirePriceCreateInstancesSync(InquirePriceCreateInstancesRequest req)
        {
             JsonResponseModel<InquirePriceCreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceCreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquirePriceRenewDisks）用于续费云硬盘询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDisksRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDisksResponse"/></returns>
        public async Task<InquirePriceRenewDisksResponse> InquirePriceRenewDisks(InquirePriceRenewDisksRequest req)
        {
             JsonResponseModel<InquirePriceRenewDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceRenewDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquirePriceRenewDisks）用于续费云硬盘询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDisksRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDisksResponse"/></returns>
        public InquirePriceRenewDisksResponse InquirePriceRenewDisksSync(InquirePriceRenewDisksRequest req)
        {
             JsonResponseModel<InquirePriceRenewDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceRenewDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquirePriceCreateInstances）用于续费实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstancesResponse"/></returns>
        public async Task<InquirePriceRenewInstancesResponse> InquirePriceRenewInstances(InquirePriceRenewInstancesRequest req)
        {
             JsonResponseModel<InquirePriceRenewInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceRenewInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquirePriceCreateInstances）用于续费实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstancesResponse"/></returns>
        public InquirePriceRenewInstancesResponse InquirePriceRenewInstancesSync(InquirePriceRenewInstancesRequest req)
        {
             JsonResponseModel<InquirePriceRenewInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceRenewInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyBlueprintAttribute) 用于修改镜像属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyBlueprintAttributeRequest"/></param>
        /// <returns><see cref="ModifyBlueprintAttributeResponse"/></returns>
        public async Task<ModifyBlueprintAttributeResponse> ModifyBlueprintAttribute(ModifyBlueprintAttributeRequest req)
        {
             JsonResponseModel<ModifyBlueprintAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBlueprintAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlueprintAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyBlueprintAttribute) 用于修改镜像属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyBlueprintAttributeRequest"/></param>
        /// <returns><see cref="ModifyBlueprintAttributeResponse"/></returns>
        public ModifyBlueprintAttributeResponse ModifyBlueprintAttributeSync(ModifyBlueprintAttributeRequest req)
        {
             JsonResponseModel<ModifyBlueprintAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBlueprintAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlueprintAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDisksAttribute)用于修改云硬盘属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisksAttributeResponse"/></returns>
        public async Task<ModifyDisksAttributeResponse> ModifyDisksAttribute(ModifyDisksAttributeRequest req)
        {
             JsonResponseModel<ModifyDisksAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDisksAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDisksAttribute)用于修改云硬盘属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksAttributeRequest"/></param>
        /// <returns><see cref="ModifyDisksAttributeResponse"/></returns>
        public ModifyDisksAttributeResponse ModifyDisksAttributeSync(ModifyDisksAttributeRequest req)
        {
             JsonResponseModel<ModifyDisksAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDisksAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDisksRenewFlag）用于修改云硬盘续费标识。
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDisksRenewFlagResponse"/></returns>
        public async Task<ModifyDisksRenewFlagResponse> ModifyDisksRenewFlag(ModifyDisksRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDisksRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDisksRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDisksRenewFlag）用于修改云硬盘续费标识。
        /// </summary>
        /// <param name="req"><see cref="ModifyDisksRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDisksRenewFlagResponse"/></returns>
        public ModifyDisksRenewFlagResponse ModifyDisksRenewFlagSync(ModifyDisksRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDisksRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDisksRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDisksRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyFirewallRuleDescription）用于修改单条防火墙规则描述。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接修改防火墙规则备注。
        /// 
        /// 在 FirewallRule 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRuleDescriptionRequest"/></param>
        /// <returns><see cref="ModifyFirewallRuleDescriptionResponse"/></returns>
        public async Task<ModifyFirewallRuleDescriptionResponse> ModifyFirewallRuleDescription(ModifyFirewallRuleDescriptionRequest req)
        {
             JsonResponseModel<ModifyFirewallRuleDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFirewallRuleDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFirewallRuleDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyFirewallRuleDescription）用于修改单条防火墙规则描述。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接修改防火墙规则备注。
        /// 
        /// 在 FirewallRule 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRuleDescriptionRequest"/></param>
        /// <returns><see cref="ModifyFirewallRuleDescriptionResponse"/></returns>
        public ModifyFirewallRuleDescriptionResponse ModifyFirewallRuleDescriptionSync(ModifyFirewallRuleDescriptionRequest req)
        {
             JsonResponseModel<ModifyFirewallRuleDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFirewallRuleDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFirewallRuleDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyFirewallRules）用于重置实例防火墙规则。
        /// 
        /// 本接口先删除当前实例的所有防火墙规则，然后添加新的规则。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接重置防火墙规则。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRulesRequest"/></param>
        /// <returns><see cref="ModifyFirewallRulesResponse"/></returns>
        public async Task<ModifyFirewallRulesResponse> ModifyFirewallRules(ModifyFirewallRulesRequest req)
        {
             JsonResponseModel<ModifyFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyFirewallRules）用于重置实例防火墙规则。
        /// 
        /// 本接口先删除当前实例的所有防火墙规则，然后添加新的规则。
        /// 
        /// * FirewallVersion 用于指定要操作的防火墙的版本。传入 FirewallVersion 版本号若不等于当前防火墙的最新版本，将返回失败；若不传 FirewallVersion 则直接重置防火墙规则。
        /// 
        /// 在 FirewallRules 参数中：
        /// * Protocol 字段支持输入 TCP，UDP，ICMP，ALL。
        /// * Port 字段允许输入 ALL，或者一个单独的端口号，或者用逗号分隔的离散端口号，或者用减号分隔的两个端口号代表的端口范围。当 Port 为范围时，减号分隔的第一个端口号小于第二个端口号。当 Protocol 字段不是 TCP 或 UDP 时，Port 字段只能为空或 ALL。Port 字段长度不得超过 64。
        /// * CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。租户之间网络隔离规则优先于防火墙中的内网规则。
        /// * Action 字段只允许输入 ACCEPT 或 DROP。
        /// * FirewallRuleDescription 字段长度不得超过 64。
        /// </summary>
        /// <param name="req"><see cref="ModifyFirewallRulesRequest"/></param>
        /// <returns><see cref="ModifyFirewallRulesResponse"/></returns>
        public ModifyFirewallRulesResponse ModifyFirewallRulesSync(ModifyFirewallRulesRequest req)
        {
             JsonResponseModel<ModifyFirewallRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFirewallRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFirewallRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyInstancesAttribute）用于修改实例的属性。
        /// * “实例名称”仅为方便用户自己管理之用。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public async Task<ModifyInstancesAttributeResponse> ModifyInstancesAttribute(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyInstancesAttribute）用于修改实例的属性。
        /// * “实例名称”仅为方便用户自己管理之用。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public ModifyInstancesAttributeResponse ModifyInstancesAttributeSync(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于设置实例默认登录密钥对属性。
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesLoginKeyPairAttributeResponse"/></returns>
        public async Task<ModifyInstancesLoginKeyPairAttributeResponse> ModifyInstancesLoginKeyPairAttribute(ModifyInstancesLoginKeyPairAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesLoginKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesLoginKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesLoginKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于设置实例默认登录密钥对属性。
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesLoginKeyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesLoginKeyPairAttributeResponse"/></returns>
        public ModifyInstancesLoginKeyPairAttributeResponse ModifyInstancesLoginKeyPairAttributeSync(ModifyInstancesLoginKeyPairAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesLoginKeyPairAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesLoginKeyPairAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesLoginKeyPairAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyInstancesRenewFlag) 用于修改包年包月实例续费标识。
        /// 
        /// * 实例被标识为自动续费后，每次在实例到期时，会自动续费一个月。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstancesRenewFlagResponse"/></returns>
        public async Task<ModifyInstancesRenewFlagResponse> ModifyInstancesRenewFlag(ModifyInstancesRenewFlagRequest req)
        {
             JsonResponseModel<ModifyInstancesRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyInstancesRenewFlag) 用于修改包年包月实例续费标识。
        /// 
        /// * 实例被标识为自动续费后，每次在实例到期时，会自动续费一个月。
        /// * 支持批量操作。每次请求批量实例的上限为100。
        /// * 实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态(LatestOperationState)为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstancesRenewFlagResponse"/></returns>
        public ModifyInstancesRenewFlagResponse ModifyInstancesRenewFlagSync(ModifyInstancesRenewFlagRequest req)
        {
             JsonResponseModel<ModifyInstancesRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySnapshotAttribute）用于修改指定快照的属性。
        /// <li>“快照名称”仅为方便用户自己管理之用。</li>
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotAttributeRequest"/></param>
        /// <returns><see cref="ModifySnapshotAttributeResponse"/></returns>
        public async Task<ModifySnapshotAttributeResponse> ModifySnapshotAttribute(ModifySnapshotAttributeRequest req)
        {
             JsonResponseModel<ModifySnapshotAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySnapshotAttribute）用于修改指定快照的属性。
        /// <li>“快照名称”仅为方便用户自己管理之用。</li>
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotAttributeRequest"/></param>
        /// <returns><see cref="ModifySnapshotAttributeResponse"/></returns>
        public ModifySnapshotAttributeResponse ModifySnapshotAttributeSync(ModifySnapshotAttributeRequest req)
        {
             JsonResponseModel<ModifySnapshotAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySnapshotAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RebootInstances）用于重启实例。
        /// 
        /// * 只有状态为 RUNNING 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 REBOOTING 状态；重启实例成功时，实例会进入 RUNNING 状态。
        /// * 支持批量操作，每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public async Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RebootInstances）用于重启实例。
        /// 
        /// * 只有状态为 RUNNING 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 REBOOTING 状态；重启实例成功时，实例会进入 RUNNING 状态。
        /// * 支持批量操作，每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public RebootInstancesResponse RebootInstancesSync(RebootInstancesRequest req)
        {
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ResetAttachCcn) 用于关联云联网实例申请过期时，重新申请关联操作。
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnRequest"/></param>
        /// <returns><see cref="ResetAttachCcnResponse"/></returns>
        public async Task<ResetAttachCcnResponse> ResetAttachCcn(ResetAttachCcnRequest req)
        {
             JsonResponseModel<ResetAttachCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAttachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAttachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ResetAttachCcn) 用于关联云联网实例申请过期时，重新申请关联操作。
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnRequest"/></param>
        /// <returns><see cref="ResetAttachCcnResponse"/></returns>
        public ResetAttachCcnResponse ResetAttachCcnSync(ResetAttachCcnRequest req)
        {
             JsonResponseModel<ResetAttachCcnResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetAttachCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAttachCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetInstance）用于重装指定实例上的镜像。
        /// 
        /// * 如果指定了 BlueprintId 参数，则使用指定的镜像重装；否则按照当前实例使用的镜像进行重装。
        /// * 系统盘将会被格式化，并重置；请确保系统盘中无重要文件。
        /// * 目前不支持实例使用该接口实现 LINUX_UNIX 和 WINDOWS 操作系统切换。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ResetInstanceRequest"/></param>
        /// <returns><see cref="ResetInstanceResponse"/></returns>
        public async Task<ResetInstanceResponse> ResetInstance(ResetInstanceRequest req)
        {
             JsonResponseModel<ResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetInstance）用于重装指定实例上的镜像。
        /// 
        /// * 如果指定了 BlueprintId 参数，则使用指定的镜像重装；否则按照当前实例使用的镜像进行重装。
        /// * 系统盘将会被格式化，并重置；请确保系统盘中无重要文件。
        /// * 目前不支持实例使用该接口实现 LINUX_UNIX 和 WINDOWS 操作系统切换。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="ResetInstanceRequest"/></param>
        /// <returns><see cref="ResetInstanceResponse"/></returns>
        public ResetInstanceResponse ResetInstanceSync(ResetInstanceRequest req)
        {
             JsonResponseModel<ResetInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetInstancesPassword）用于将实例操作系统的密码重置为用户指定的密码。
        /// * 只修改管理员帐号的密码。实例的操作系统不同，管理员帐号也会不一样（Windows 为 Administrator，Ubuntu 为 ubuntu ，其它系统为 root）。
        /// * 支持批量操作。将多个实例操作系统的密码重置为相同的密码。每次请求批量实例的上限为 100。
        /// * 建议对运行中的实例先手动关机，然后再进行密码重置。如实例处于运行中状态，本接口操作过程中会对实例进行关机操作，尝试正常关机失败后进行强制关机。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// 注意：强制关机的效果等同于关闭物理计算机的电源开关。强制关机可能会导致数据丢失或文件系统损坏。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public async Task<ResetInstancesPasswordResponse> ResetInstancesPassword(ResetInstancesPasswordRequest req)
        {
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetInstancesPassword）用于将实例操作系统的密码重置为用户指定的密码。
        /// * 只修改管理员帐号的密码。实例的操作系统不同，管理员帐号也会不一样（Windows 为 Administrator，Ubuntu 为 ubuntu ，其它系统为 root）。
        /// * 支持批量操作。将多个实例操作系统的密码重置为相同的密码。每次请求批量实例的上限为 100。
        /// * 建议对运行中的实例先手动关机，然后再进行密码重置。如实例处于运行中状态，本接口操作过程中会对实例进行关机操作，尝试正常关机失败后进行强制关机。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// 注意：强制关机的效果等同于关闭物理计算机的电源开关。强制关机可能会导致数据丢失或文件系统损坏。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public ResetInstancesPasswordResponse ResetInstancesPasswordSync(ResetInstancesPasswordRequest req)
        {
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartInstances）用于启动一个或多个实例。
        /// 
        /// * 只有状态为 STOPPED 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 STARTING 状态；启动实例成功时，实例会进入 RUNNING 状态。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public async Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartInstances）用于启动一个或多个实例。
        /// 
        /// * 只有状态为 STOPPED 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 STARTING 状态；启动实例成功时，实例会进入 RUNNING 状态。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public StartInstancesResponse StartInstancesSync(StartInstancesRequest req)
        {
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopInstances）用于关闭一个或多个实例。
        /// * 只有状态为 RUNNING 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 STOPPING 状态；关闭实例成功时，实例会进入 STOPPED 状态。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public async Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopInstances）用于关闭一个或多个实例。
        /// * 只有状态为 RUNNING 的实例才可以进行此操作。
        /// * 接口调用成功时，实例会进入 STOPPING 状态；关闭实例成功时，实例会进入 STOPPED 状态。
        /// * 支持批量操作。每次请求批量实例的上限为 100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态（LatestOperationState）为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public StopInstancesResponse StopInstancesSync(StopInstancesRequest req)
        {
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（TerminateDisks）用于销毁一个或多个云硬盘。
        /// </summary>
        /// <param name="req"><see cref="TerminateDisksRequest"/></param>
        /// <returns><see cref="TerminateDisksResponse"/></returns>
        public async Task<TerminateDisksResponse> TerminateDisks(TerminateDisksRequest req)
        {
             JsonResponseModel<TerminateDisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（TerminateDisks）用于销毁一个或多个云硬盘。
        /// </summary>
        /// <param name="req"><see cref="TerminateDisksRequest"/></param>
        /// <returns><see cref="TerminateDisksResponse"/></returns>
        public TerminateDisksResponse TerminateDisksSync(TerminateDisksRequest req)
        {
             JsonResponseModel<TerminateDisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateDisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (TerminateInstances) 用于销毁实例。
        /// 
        /// * 处于 SHUTDOWN 状态的实例，可通过本接口销毁，且不可恢复。
        /// * 支持批量操作，每次请求批量实例的上限为100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态 (LatestOperationState) 为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public async Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (TerminateInstances) 用于销毁实例。
        /// 
        /// * 处于 SHUTDOWN 状态的实例，可通过本接口销毁，且不可恢复。
        /// * 支持批量操作，每次请求批量实例的上限为100。
        /// * 本接口为异步接口，请求发送成功后会返回一个 RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeInstances 接口查询，如果实例的最新操作状态 (LatestOperationState) 为“SUCCESS”，则代表操作成功。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
