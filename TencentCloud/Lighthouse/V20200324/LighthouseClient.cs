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

    }
}
