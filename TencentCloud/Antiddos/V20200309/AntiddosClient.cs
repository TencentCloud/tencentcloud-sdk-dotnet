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

namespace TencentCloud.Antiddos.V20200309
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Antiddos.V20200309.Models;

   public class AntiddosClient : AbstractClient{

       private const string endpoint = "antiddos.tencentcloudapi.com";
       private const string version = "2020-03-09";
       private const string sdkVersion = "SDK_NET_3.0.1208";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AntiddosClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AntiddosClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口 (AssociateDDoSEipAddress) 用于将高防弹性公网IP绑定到实例或弹性网卡的指定内网 IP 上。
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipAddressResponse"/></returns>
        public Task<AssociateDDoSEipAddressResponse> AssociateDDoSEipAddress(AssociateDDoSEipAddressRequest req)
        {
            return InternalRequestAsync<AssociateDDoSEipAddressResponse>(req, "AssociateDDoSEipAddress");
        }

        /// <summary>
        /// 本接口 (AssociateDDoSEipAddress) 用于将高防弹性公网IP绑定到实例或弹性网卡的指定内网 IP 上。
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipAddressResponse"/></returns>
        public AssociateDDoSEipAddressResponse AssociateDDoSEipAddressSync(AssociateDDoSEipAddressRequest req)
        {
            return InternalRequestAsync<AssociateDDoSEipAddressResponse>(req, "AssociateDDoSEipAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (AssociateDDoSEipLoadBalancer) 用于将高防弹性公网IP绑定到负载均衡指定内网 IP 上。
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipLoadBalancerResponse"/></returns>
        public Task<AssociateDDoSEipLoadBalancerResponse> AssociateDDoSEipLoadBalancer(AssociateDDoSEipLoadBalancerRequest req)
        {
            return InternalRequestAsync<AssociateDDoSEipLoadBalancerResponse>(req, "AssociateDDoSEipLoadBalancer");
        }

        /// <summary>
        /// 本接口 (AssociateDDoSEipLoadBalancer) 用于将高防弹性公网IP绑定到负载均衡指定内网 IP 上。
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipLoadBalancerResponse"/></returns>
        public AssociateDDoSEipLoadBalancerResponse AssociateDDoSEipLoadBalancerSync(AssociateDDoSEipLoadBalancerRequest req)
        {
            return InternalRequestAsync<AssociateDDoSEipLoadBalancerResponse>(req, "AssociateDDoSEipLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加DDoS防护的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateBlackWhiteIpListResponse"/></returns>
        public Task<CreateBlackWhiteIpListResponse> CreateBlackWhiteIpList(CreateBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<CreateBlackWhiteIpListResponse>(req, "CreateBlackWhiteIpList");
        }

        /// <summary>
        /// 添加DDoS防护的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateBlackWhiteIpListResponse"/></returns>
        public CreateBlackWhiteIpListResponse CreateBlackWhiteIpListSync(CreateBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<CreateBlackWhiteIpListResponse>(req, "CreateBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定IP到高防包实例，支持独享包、共享包（新版）；需要注意的是此接口绑定或解绑IP是异步接口，当处于绑定或解绑中时，则不允许再进行绑定或解绑，需要等待当前绑定或解绑完成。
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public Task<CreateBoundIPResponse> CreateBoundIP(CreateBoundIPRequest req)
        {
            return InternalRequestAsync<CreateBoundIPResponse>(req, "CreateBoundIP");
        }

        /// <summary>
        /// 绑定IP到高防包实例，支持独享包、共享包（新版）；需要注意的是此接口绑定或解绑IP是异步接口，当处于绑定或解绑中时，则不允许再进行绑定或解绑，需要等待当前绑定或解绑完成。
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public CreateBoundIPResponse CreateBoundIPSync(CreateBoundIPRequest req)
        {
            return InternalRequestAsync<CreateBoundIPResponse>(req, "CreateBoundIP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="CreateCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="CreateCCPrecisionPolicyResponse"/></returns>
        public Task<CreateCCPrecisionPolicyResponse> CreateCCPrecisionPolicy(CreateCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<CreateCCPrecisionPolicyResponse>(req, "CreateCCPrecisionPolicy");
        }

        /// <summary>
        /// 新增CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="CreateCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="CreateCCPrecisionPolicyResponse"/></returns>
        public CreateCCPrecisionPolicyResponse CreateCCPrecisionPolicySync(CreateCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<CreateCCPrecisionPolicyResponse>(req, "CreateCCPrecisionPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="CreateCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="CreateCCReqLimitPolicyResponse"/></returns>
        public Task<CreateCCReqLimitPolicyResponse> CreateCCReqLimitPolicy(CreateCCReqLimitPolicyRequest req)
        {
            return InternalRequestAsync<CreateCCReqLimitPolicyResponse>(req, "CreateCCReqLimitPolicy");
        }

        /// <summary>
        /// 新增CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="CreateCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="CreateCCReqLimitPolicyResponse"/></returns>
        public CreateCCReqLimitPolicyResponse CreateCCReqLimitPolicySync(CreateCCReqLimitPolicyRequest req)
        {
            return InternalRequestAsync<CreateCCReqLimitPolicyResponse>(req, "CreateCCReqLimitPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateCcBlackWhiteIpListResponse"/></returns>
        public Task<CreateCcBlackWhiteIpListResponse> CreateCcBlackWhiteIpList(CreateCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<CreateCcBlackWhiteIpListResponse>(req, "CreateCcBlackWhiteIpList");
        }

        /// <summary>
        /// 新建CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateCcBlackWhiteIpListResponse"/></returns>
        public CreateCcBlackWhiteIpListResponse CreateCcBlackWhiteIpListSync(CreateCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<CreateCcBlackWhiteIpListResponse>(req, "CreateCcBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建CC防护的地域封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateCcGeoIPBlockConfigResponse"/></returns>
        public Task<CreateCcGeoIPBlockConfigResponse> CreateCcGeoIPBlockConfig(CreateCcGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateCcGeoIPBlockConfigResponse>(req, "CreateCcGeoIPBlockConfig");
        }

        /// <summary>
        /// 新建CC防护的地域封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateCcGeoIPBlockConfigResponse"/></returns>
        public CreateCcGeoIPBlockConfigResponse CreateCcGeoIPBlockConfigSync(CreateCcGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateCcGeoIPBlockConfigResponse>(req, "CreateCcGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置DDoS防护的AI防护开关
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSAIRequest"/></param>
        /// <returns><see cref="CreateDDoSAIResponse"/></returns>
        public Task<CreateDDoSAIResponse> CreateDDoSAI(CreateDDoSAIRequest req)
        {
            return InternalRequestAsync<CreateDDoSAIResponse>(req, "CreateDDoSAI");
        }

        /// <summary>
        /// 设置DDoS防护的AI防护开关
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSAIRequest"/></param>
        /// <returns><see cref="CreateDDoSAIResponse"/></returns>
        public CreateDDoSAIResponse CreateDDoSAISync(CreateDDoSAIRequest req)
        {
            return InternalRequestAsync<CreateDDoSAIResponse>(req, "CreateDDoSAI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateDDoSBlackWhiteIpListResponse"/></returns>
        public Task<CreateDDoSBlackWhiteIpListResponse> CreateDDoSBlackWhiteIpList(CreateDDoSBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<CreateDDoSBlackWhiteIpListResponse>(req, "CreateDDoSBlackWhiteIpList");
        }

        /// <summary>
        /// 添加DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateDDoSBlackWhiteIpListResponse"/></returns>
        public CreateDDoSBlackWhiteIpListResponse CreateDDoSBlackWhiteIpListSync(CreateDDoSBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<CreateDDoSBlackWhiteIpListResponse>(req, "CreateDDoSBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 配置DDoS连接抑制选项
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSConnectLimitRequest"/></param>
        /// <returns><see cref="CreateDDoSConnectLimitResponse"/></returns>
        public Task<CreateDDoSConnectLimitResponse> CreateDDoSConnectLimit(CreateDDoSConnectLimitRequest req)
        {
            return InternalRequestAsync<CreateDDoSConnectLimitResponse>(req, "CreateDDoSConnectLimit");
        }

        /// <summary>
        /// 配置DDoS连接抑制选项
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSConnectLimitRequest"/></param>
        /// <returns><see cref="CreateDDoSConnectLimitResponse"/></returns>
        public CreateDDoSConnectLimitResponse CreateDDoSConnectLimitSync(CreateDDoSConnectLimitRequest req)
        {
            return InternalRequestAsync<CreateDDoSConnectLimitResponse>(req, "CreateDDoSConnectLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSGeoIPBlockConfigResponse"/></returns>
        public Task<CreateDDoSGeoIPBlockConfigResponse> CreateDDoSGeoIPBlockConfig(CreateDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateDDoSGeoIPBlockConfigResponse>(req, "CreateDDoSGeoIPBlockConfig");
        }

        /// <summary>
        /// 添加DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSGeoIPBlockConfigResponse"/></returns>
        public CreateDDoSGeoIPBlockConfigResponse CreateDDoSGeoIPBlockConfigSync(CreateDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateDDoSGeoIPBlockConfigResponse>(req, "CreateDDoSGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSSpeedLimitConfigResponse"/></returns>
        public Task<CreateDDoSSpeedLimitConfigResponse> CreateDDoSSpeedLimitConfig(CreateDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<CreateDDoSSpeedLimitConfigResponse>(req, "CreateDDoSSpeedLimitConfig");
        }

        /// <summary>
        /// 添加DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSSpeedLimitConfigResponse"/></returns>
        public CreateDDoSSpeedLimitConfigResponse CreateDDoSSpeedLimitConfigSync(CreateDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<CreateDDoSSpeedLimitConfigResponse>(req, "CreateDDoSSpeedLimitConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置单IP默认告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateDefaultAlarmThresholdResponse"/></returns>
        public Task<CreateDefaultAlarmThresholdResponse> CreateDefaultAlarmThreshold(CreateDefaultAlarmThresholdRequest req)
        {
            return InternalRequestAsync<CreateDefaultAlarmThresholdResponse>(req, "CreateDefaultAlarmThreshold");
        }

        /// <summary>
        /// 设置单IP默认告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateDefaultAlarmThresholdResponse"/></returns>
        public CreateDefaultAlarmThresholdResponse CreateDefaultAlarmThresholdSync(CreateDefaultAlarmThresholdRequest req)
        {
            return InternalRequestAsync<CreateDefaultAlarmThresholdResponse>(req, "CreateDefaultAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置单IP告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="CreateIPAlarmThresholdConfigRequest"/></param>
        /// <returns><see cref="CreateIPAlarmThresholdConfigResponse"/></returns>
        public Task<CreateIPAlarmThresholdConfigResponse> CreateIPAlarmThresholdConfig(CreateIPAlarmThresholdConfigRequest req)
        {
            return InternalRequestAsync<CreateIPAlarmThresholdConfigResponse>(req, "CreateIPAlarmThresholdConfig");
        }

        /// <summary>
        /// 设置单IP告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="CreateIPAlarmThresholdConfigRequest"/></param>
        /// <returns><see cref="CreateIPAlarmThresholdConfigResponse"/></returns>
        public CreateIPAlarmThresholdConfigResponse CreateIPAlarmThresholdConfigSync(CreateIPAlarmThresholdConfigRequest req)
        {
            return InternalRequestAsync<CreateIPAlarmThresholdConfigResponse>(req, "CreateIPAlarmThresholdConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量配置L7转发规则的证书供SSL测调用
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertsRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertsResponse"/></returns>
        public Task<CreateL7RuleCertsResponse> CreateL7RuleCerts(CreateL7RuleCertsRequest req)
        {
            return InternalRequestAsync<CreateL7RuleCertsResponse>(req, "CreateL7RuleCerts");
        }

        /// <summary>
        /// 批量配置L7转发规则的证书供SSL测调用
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertsRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertsResponse"/></returns>
        public CreateL7RuleCertsResponse CreateL7RuleCertsSync(CreateL7RuleCertsRequest req)
        {
            return InternalRequestAsync<CreateL7RuleCertsResponse>(req, "CreateL7RuleCerts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加7层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesResponse"/></returns>
        public Task<CreateNewL7RulesResponse> CreateNewL7Rules(CreateNewL7RulesRequest req)
        {
            return InternalRequestAsync<CreateNewL7RulesResponse>(req, "CreateNewL7Rules");
        }

        /// <summary>
        /// 添加7层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesResponse"/></returns>
        public CreateNewL7RulesResponse CreateNewL7RulesSync(CreateNewL7RulesRequest req)
        {
            return InternalRequestAsync<CreateNewL7RulesResponse>(req, "CreateNewL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="CreatePacketFilterConfigRequest"/></param>
        /// <returns><see cref="CreatePacketFilterConfigResponse"/></returns>
        public Task<CreatePacketFilterConfigResponse> CreatePacketFilterConfig(CreatePacketFilterConfigRequest req)
        {
            return InternalRequestAsync<CreatePacketFilterConfigResponse>(req, "CreatePacketFilterConfig");
        }

        /// <summary>
        /// 添加DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="CreatePacketFilterConfigRequest"/></param>
        /// <returns><see cref="CreatePacketFilterConfigResponse"/></returns>
        public CreatePacketFilterConfigResponse CreatePacketFilterConfigSync(CreatePacketFilterConfigRequest req)
        {
            return InternalRequestAsync<CreatePacketFilterConfigResponse>(req, "CreatePacketFilterConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="CreatePortAclConfigRequest"/></param>
        /// <returns><see cref="CreatePortAclConfigResponse"/></returns>
        public Task<CreatePortAclConfigResponse> CreatePortAclConfig(CreatePortAclConfigRequest req)
        {
            return InternalRequestAsync<CreatePortAclConfigResponse>(req, "CreatePortAclConfig");
        }

        /// <summary>
        /// 添加DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="CreatePortAclConfigRequest"/></param>
        /// <returns><see cref="CreatePortAclConfigResponse"/></returns>
        public CreatePortAclConfigResponse CreatePortAclConfigSync(CreatePortAclConfigRequest req)
        {
            return InternalRequestAsync<CreatePortAclConfigResponse>(req, "CreatePortAclConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量添加DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="CreatePortAclConfigListRequest"/></param>
        /// <returns><see cref="CreatePortAclConfigListResponse"/></returns>
        public Task<CreatePortAclConfigListResponse> CreatePortAclConfigList(CreatePortAclConfigListRequest req)
        {
            return InternalRequestAsync<CreatePortAclConfigListResponse>(req, "CreatePortAclConfigList");
        }

        /// <summary>
        /// 批量添加DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="CreatePortAclConfigListRequest"/></param>
        /// <returns><see cref="CreatePortAclConfigListResponse"/></returns>
        public CreatePortAclConfigListResponse CreatePortAclConfigListSync(CreatePortAclConfigListRequest req)
        {
            return InternalRequestAsync<CreatePortAclConfigListResponse>(req, "CreatePortAclConfigList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置DDoS防护的协议封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="CreateProtocolBlockConfigResponse"/></returns>
        public Task<CreateProtocolBlockConfigResponse> CreateProtocolBlockConfig(CreateProtocolBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateProtocolBlockConfigResponse>(req, "CreateProtocolBlockConfig");
        }

        /// <summary>
        /// 设置DDoS防护的协议封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="CreateProtocolBlockConfigResponse"/></returns>
        public CreateProtocolBlockConfigResponse CreateProtocolBlockConfigSync(CreateProtocolBlockConfigRequest req)
        {
            return InternalRequestAsync<CreateProtocolBlockConfigResponse>(req, "CreateProtocolBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个域名，可用于在封堵时调度切换IP
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulingDomainRequest"/></param>
        /// <returns><see cref="CreateSchedulingDomainResponse"/></returns>
        public Task<CreateSchedulingDomainResponse> CreateSchedulingDomain(CreateSchedulingDomainRequest req)
        {
            return InternalRequestAsync<CreateSchedulingDomainResponse>(req, "CreateSchedulingDomain");
        }

        /// <summary>
        /// 创建一个域名，可用于在封堵时调度切换IP
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulingDomainRequest"/></param>
        /// <returns><see cref="CreateSchedulingDomainResponse"/></returns>
        public CreateSchedulingDomainResponse CreateSchedulingDomainSync(CreateSchedulingDomainRequest req)
        {
            return InternalRequestAsync<CreateSchedulingDomainResponse>(req, "CreateSchedulingDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加DDoS防护的水印防护配置
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintConfigRequest"/></param>
        /// <returns><see cref="CreateWaterPrintConfigResponse"/></returns>
        public Task<CreateWaterPrintConfigResponse> CreateWaterPrintConfig(CreateWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<CreateWaterPrintConfigResponse>(req, "CreateWaterPrintConfig");
        }

        /// <summary>
        /// 添加DDoS防护的水印防护配置
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintConfigRequest"/></param>
        /// <returns><see cref="CreateWaterPrintConfigResponse"/></returns>
        public CreateWaterPrintConfigResponse CreateWaterPrintConfigSync(CreateWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<CreateWaterPrintConfigResponse>(req, "CreateWaterPrintConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加DDoS防护的水印防护密钥
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintKeyRequest"/></param>
        /// <returns><see cref="CreateWaterPrintKeyResponse"/></returns>
        public Task<CreateWaterPrintKeyResponse> CreateWaterPrintKey(CreateWaterPrintKeyRequest req)
        {
            return InternalRequestAsync<CreateWaterPrintKeyResponse>(req, "CreateWaterPrintKey");
        }

        /// <summary>
        /// 添加DDoS防护的水印防护密钥
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintKeyRequest"/></param>
        /// <returns><see cref="CreateWaterPrintKeyResponse"/></returns>
        public CreateWaterPrintKeyResponse CreateWaterPrintKeySync(CreateWaterPrintKeyRequest req)
        {
            return InternalRequestAsync<CreateWaterPrintKeyResponse>(req, "CreateWaterPrintKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除CC分级策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCLevelPolicyResponse"/></returns>
        public Task<DeleteCCLevelPolicyResponse> DeleteCCLevelPolicy(DeleteCCLevelPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCLevelPolicyResponse>(req, "DeleteCCLevelPolicy");
        }

        /// <summary>
        /// 删除CC分级策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCLevelPolicyResponse"/></returns>
        public DeleteCCLevelPolicyResponse DeleteCCLevelPolicySync(DeleteCCLevelPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCLevelPolicyResponse>(req, "DeleteCCLevelPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCPrecisionPolicyResponse"/></returns>
        public Task<DeleteCCPrecisionPolicyResponse> DeleteCCPrecisionPolicy(DeleteCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCPrecisionPolicyResponse>(req, "DeleteCCPrecisionPolicy");
        }

        /// <summary>
        /// 删除CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCPrecisionPolicyResponse"/></returns>
        public DeleteCCPrecisionPolicyResponse DeleteCCPrecisionPolicySync(DeleteCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCPrecisionPolicyResponse>(req, "DeleteCCPrecisionPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCRequestLimitPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCRequestLimitPolicyResponse"/></returns>
        public Task<DeleteCCRequestLimitPolicyResponse> DeleteCCRequestLimitPolicy(DeleteCCRequestLimitPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCRequestLimitPolicyResponse>(req, "DeleteCCRequestLimitPolicy");
        }

        /// <summary>
        /// 删除CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCRequestLimitPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCRequestLimitPolicyResponse"/></returns>
        public DeleteCCRequestLimitPolicyResponse DeleteCCRequestLimitPolicySync(DeleteCCRequestLimitPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCRequestLimitPolicyResponse>(req, "DeleteCCRequestLimitPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除CC清洗阈值策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCThresholdPolicyResponse"/></returns>
        public Task<DeleteCCThresholdPolicyResponse> DeleteCCThresholdPolicy(DeleteCCThresholdPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCThresholdPolicyResponse>(req, "DeleteCCThresholdPolicy");
        }

        /// <summary>
        /// 删除CC清洗阈值策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCThresholdPolicyResponse"/></returns>
        public DeleteCCThresholdPolicyResponse DeleteCCThresholdPolicySync(DeleteCCThresholdPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCThresholdPolicyResponse>(req, "DeleteCCThresholdPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteCcBlackWhiteIpListResponse"/></returns>
        public Task<DeleteCcBlackWhiteIpListResponse> DeleteCcBlackWhiteIpList(DeleteCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DeleteCcBlackWhiteIpListResponse>(req, "DeleteCcBlackWhiteIpList");
        }

        /// <summary>
        /// 删除CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteCcBlackWhiteIpListResponse"/></returns>
        public DeleteCcBlackWhiteIpListResponse DeleteCcBlackWhiteIpListSync(DeleteCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DeleteCcBlackWhiteIpListResponse>(req, "DeleteCcBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除CC防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="DeleteCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteCcGeoIPBlockConfigResponse"/></returns>
        public Task<DeleteCcGeoIPBlockConfigResponse> DeleteCcGeoIPBlockConfig(DeleteCcGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DeleteCcGeoIPBlockConfigResponse>(req, "DeleteCcGeoIPBlockConfig");
        }

        /// <summary>
        /// 删除CC防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="DeleteCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteCcGeoIPBlockConfigResponse"/></returns>
        public DeleteCcGeoIPBlockConfigResponse DeleteCcGeoIPBlockConfigSync(DeleteCcGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DeleteCcGeoIPBlockConfigResponse>(req, "DeleteCcGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteDDoSBlackWhiteIpListResponse"/></returns>
        public Task<DeleteDDoSBlackWhiteIpListResponse> DeleteDDoSBlackWhiteIpList(DeleteDDoSBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DeleteDDoSBlackWhiteIpListResponse>(req, "DeleteDDoSBlackWhiteIpList");
        }

        /// <summary>
        /// 删除DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteDDoSBlackWhiteIpListResponse"/></returns>
        public DeleteDDoSBlackWhiteIpListResponse DeleteDDoSBlackWhiteIpListSync(DeleteDDoSBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DeleteDDoSBlackWhiteIpListResponse>(req, "DeleteDDoSBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSGeoIPBlockConfigResponse"/></returns>
        public Task<DeleteDDoSGeoIPBlockConfigResponse> DeleteDDoSGeoIPBlockConfig(DeleteDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DeleteDDoSGeoIPBlockConfigResponse>(req, "DeleteDDoSGeoIPBlockConfig");
        }

        /// <summary>
        /// 删除DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSGeoIPBlockConfigResponse"/></returns>
        public DeleteDDoSGeoIPBlockConfigResponse DeleteDDoSGeoIPBlockConfigSync(DeleteDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DeleteDDoSGeoIPBlockConfigResponse>(req, "DeleteDDoSGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSSpeedLimitConfigResponse"/></returns>
        public Task<DeleteDDoSSpeedLimitConfigResponse> DeleteDDoSSpeedLimitConfig(DeleteDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<DeleteDDoSSpeedLimitConfigResponse>(req, "DeleteDDoSSpeedLimitConfig");
        }

        /// <summary>
        /// 删除DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSSpeedLimitConfigResponse"/></returns>
        public DeleteDDoSSpeedLimitConfigResponse DeleteDDoSSpeedLimitConfigSync(DeleteDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<DeleteDDoSSpeedLimitConfigResponse>(req, "DeleteDDoSSpeedLimitConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="DeletePacketFilterConfigRequest"/></param>
        /// <returns><see cref="DeletePacketFilterConfigResponse"/></returns>
        public Task<DeletePacketFilterConfigResponse> DeletePacketFilterConfig(DeletePacketFilterConfigRequest req)
        {
            return InternalRequestAsync<DeletePacketFilterConfigResponse>(req, "DeletePacketFilterConfig");
        }

        /// <summary>
        /// 删除DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="DeletePacketFilterConfigRequest"/></param>
        /// <returns><see cref="DeletePacketFilterConfigResponse"/></returns>
        public DeletePacketFilterConfigResponse DeletePacketFilterConfigSync(DeletePacketFilterConfigRequest req)
        {
            return InternalRequestAsync<DeletePacketFilterConfigResponse>(req, "DeletePacketFilterConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="DeletePortAclConfigRequest"/></param>
        /// <returns><see cref="DeletePortAclConfigResponse"/></returns>
        public Task<DeletePortAclConfigResponse> DeletePortAclConfig(DeletePortAclConfigRequest req)
        {
            return InternalRequestAsync<DeletePortAclConfigResponse>(req, "DeletePortAclConfig");
        }

        /// <summary>
        /// 删除DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="DeletePortAclConfigRequest"/></param>
        /// <returns><see cref="DeletePortAclConfigResponse"/></returns>
        public DeletePortAclConfigResponse DeletePortAclConfigSync(DeletePortAclConfigRequest req)
        {
            return InternalRequestAsync<DeletePortAclConfigResponse>(req, "DeletePortAclConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除DDoS防护的水印防护配置
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintConfigResponse"/></returns>
        public Task<DeleteWaterPrintConfigResponse> DeleteWaterPrintConfig(DeleteWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<DeleteWaterPrintConfigResponse>(req, "DeleteWaterPrintConfig");
        }

        /// <summary>
        /// 删除DDoS防护的水印防护配置
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintConfigResponse"/></returns>
        public DeleteWaterPrintConfigResponse DeleteWaterPrintConfigSync(DeleteWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<DeleteWaterPrintConfigResponse>(req, "DeleteWaterPrintConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除DDoS防护的水印防护密钥
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintKeyRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintKeyResponse"/></returns>
        public Task<DeleteWaterPrintKeyResponse> DeleteWaterPrintKey(DeleteWaterPrintKeyRequest req)
        {
            return InternalRequestAsync<DeleteWaterPrintKeyResponse>(req, "DeleteWaterPrintKey");
        }

        /// <summary>
        /// 删除DDoS防护的水印防护密钥
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintKeyRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintKeyResponse"/></returns>
        public DeleteWaterPrintKeyResponse DeleteWaterPrintKeySync(DeleteWaterPrintKeyRequest req)
        {
            return InternalRequestAsync<DeleteWaterPrintKeyResponse>(req, "DeleteWaterPrintKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 高防IP获取7层规则
        /// </summary>
        /// <param name="req"><see cref="DescribeBGPIPL7RulesRequest"/></param>
        /// <returns><see cref="DescribeBGPIPL7RulesResponse"/></returns>
        public Task<DescribeBGPIPL7RulesResponse> DescribeBGPIPL7Rules(DescribeBGPIPL7RulesRequest req)
        {
            return InternalRequestAsync<DescribeBGPIPL7RulesResponse>(req, "DescribeBGPIPL7Rules");
        }

        /// <summary>
        /// 高防IP获取7层规则
        /// </summary>
        /// <param name="req"><see cref="DescribeBGPIPL7RulesRequest"/></param>
        /// <returns><see cref="DescribeBGPIPL7RulesResponse"/></returns>
        public DescribeBGPIPL7RulesResponse DescribeBGPIPL7RulesSync(DescribeBGPIPL7RulesRequest req)
        {
            return InternalRequestAsync<DescribeBGPIPL7RulesResponse>(req, "DescribeBGPIPL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基础防护攻击状态
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceStatusRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceStatusResponse"/></returns>
        public Task<DescribeBasicDeviceStatusResponse> DescribeBasicDeviceStatus(DescribeBasicDeviceStatusRequest req)
        {
            return InternalRequestAsync<DescribeBasicDeviceStatusResponse>(req, "DescribeBasicDeviceStatus");
        }

        /// <summary>
        /// 获取基础防护攻击状态
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceStatusRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceStatusResponse"/></returns>
        public DescribeBasicDeviceStatusResponse DescribeBasicDeviceStatusSync(DescribeBasicDeviceStatusRequest req)
        {
            return InternalRequestAsync<DescribeBasicDeviceStatusResponse>(req, "DescribeBasicDeviceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防包流量折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeBgpBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBgpBizTrendResponse"/></returns>
        public Task<DescribeBgpBizTrendResponse> DescribeBgpBizTrend(DescribeBgpBizTrendRequest req)
        {
            return InternalRequestAsync<DescribeBgpBizTrendResponse>(req, "DescribeBgpBizTrend");
        }

        /// <summary>
        /// 获取高防包流量折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeBgpBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBgpBizTrendResponse"/></returns>
        public DescribeBgpBizTrendResponse DescribeBgpBizTrendSync(DescribeBgpBizTrendRequest req)
        {
            return InternalRequestAsync<DescribeBgpBizTrendResponse>(req, "DescribeBgpBizTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取业务流量状态码统计列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBizHttpStatusRequest"/></param>
        /// <returns><see cref="DescribeBizHttpStatusResponse"/></returns>
        public Task<DescribeBizHttpStatusResponse> DescribeBizHttpStatus(DescribeBizHttpStatusRequest req)
        {
            return InternalRequestAsync<DescribeBizHttpStatusResponse>(req, "DescribeBizHttpStatus");
        }

        /// <summary>
        /// 获取业务流量状态码统计列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBizHttpStatusRequest"/></param>
        /// <returns><see cref="DescribeBizHttpStatusResponse"/></returns>
        public DescribeBizHttpStatusResponse DescribeBizHttpStatusSync(DescribeBizHttpStatusRequest req)
        {
            return InternalRequestAsync<DescribeBizHttpStatusResponse>(req, "DescribeBizHttpStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防IP业务监控流量曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeBizMonitorTrendRequest"/></param>
        /// <returns><see cref="DescribeBizMonitorTrendResponse"/></returns>
        public Task<DescribeBizMonitorTrendResponse> DescribeBizMonitorTrend(DescribeBizMonitorTrendRequest req)
        {
            return InternalRequestAsync<DescribeBizMonitorTrendResponse>(req, "DescribeBizMonitorTrend");
        }

        /// <summary>
        /// 获取高防IP业务监控流量曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeBizMonitorTrendRequest"/></param>
        /// <returns><see cref="DescribeBizMonitorTrendResponse"/></returns>
        public DescribeBizMonitorTrendResponse DescribeBizMonitorTrendSync(DescribeBizMonitorTrendRequest req)
        {
            return InternalRequestAsync<DescribeBizMonitorTrendResponse>(req, "DescribeBizMonitorTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取业务流量曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBizTrendResponse"/></returns>
        public Task<DescribeBizTrendResponse> DescribeBizTrend(DescribeBizTrendRequest req)
        {
            return InternalRequestAsync<DescribeBizTrendResponse>(req, "DescribeBizTrend");
        }

        /// <summary>
        /// 获取业务流量曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBizTrendResponse"/></returns>
        public DescribeBizTrendResponse DescribeBizTrendSync(DescribeBizTrendRequest req)
        {
            return InternalRequestAsync<DescribeBizTrendResponse>(req, "DescribeBizTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取边界防护CC防护等级列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelListRequest"/></param>
        /// <returns><see cref="DescribeCCLevelListResponse"/></returns>
        public Task<DescribeCCLevelListResponse> DescribeCCLevelList(DescribeCCLevelListRequest req)
        {
            return InternalRequestAsync<DescribeCCLevelListResponse>(req, "DescribeCCLevelList");
        }

        /// <summary>
        /// 获取边界防护CC防护等级列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelListRequest"/></param>
        /// <returns><see cref="DescribeCCLevelListResponse"/></returns>
        public DescribeCCLevelListResponse DescribeCCLevelListSync(DescribeCCLevelListRequest req)
        {
            return InternalRequestAsync<DescribeCCLevelListResponse>(req, "DescribeCCLevelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC分级策略
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DescribeCCLevelPolicyResponse"/></returns>
        public Task<DescribeCCLevelPolicyResponse> DescribeCCLevelPolicy(DescribeCCLevelPolicyRequest req)
        {
            return InternalRequestAsync<DescribeCCLevelPolicyResponse>(req, "DescribeCCLevelPolicy");
        }

        /// <summary>
        /// 获取CC分级策略
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DescribeCCLevelPolicyResponse"/></returns>
        public DescribeCCLevelPolicyResponse DescribeCCLevelPolicySync(DescribeCCLevelPolicyRequest req)
        {
            return InternalRequestAsync<DescribeCCLevelPolicyResponse>(req, "DescribeCCLevelPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC精准防护列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCPrecisionPlyListRequest"/></param>
        /// <returns><see cref="DescribeCCPrecisionPlyListResponse"/></returns>
        public Task<DescribeCCPrecisionPlyListResponse> DescribeCCPrecisionPlyList(DescribeCCPrecisionPlyListRequest req)
        {
            return InternalRequestAsync<DescribeCCPrecisionPlyListResponse>(req, "DescribeCCPrecisionPlyList");
        }

        /// <summary>
        /// 获取CC精准防护列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCPrecisionPlyListRequest"/></param>
        /// <returns><see cref="DescribeCCPrecisionPlyListResponse"/></returns>
        public DescribeCCPrecisionPlyListResponse DescribeCCPrecisionPlyListSync(DescribeCCPrecisionPlyListRequest req)
        {
            return InternalRequestAsync<DescribeCCPrecisionPlyListResponse>(req, "DescribeCCPrecisionPlyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC频率限制策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCReqLimitPolicyListRequest"/></param>
        /// <returns><see cref="DescribeCCReqLimitPolicyListResponse"/></returns>
        public Task<DescribeCCReqLimitPolicyListResponse> DescribeCCReqLimitPolicyList(DescribeCCReqLimitPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeCCReqLimitPolicyListResponse>(req, "DescribeCCReqLimitPolicyList");
        }

        /// <summary>
        /// 获取CC频率限制策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCReqLimitPolicyListRequest"/></param>
        /// <returns><see cref="DescribeCCReqLimitPolicyListResponse"/></returns>
        public DescribeCCReqLimitPolicyListResponse DescribeCCReqLimitPolicyListSync(DescribeCCReqLimitPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeCCReqLimitPolicyListResponse>(req, "DescribeCCReqLimitPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC清洗阈值列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCThresholdListRequest"/></param>
        /// <returns><see cref="DescribeCCThresholdListResponse"/></returns>
        public Task<DescribeCCThresholdListResponse> DescribeCCThresholdList(DescribeCCThresholdListRequest req)
        {
            return InternalRequestAsync<DescribeCCThresholdListResponse>(req, "DescribeCCThresholdList");
        }

        /// <summary>
        /// 获取CC清洗阈值列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCThresholdListRequest"/></param>
        /// <returns><see cref="DescribeCCThresholdListResponse"/></returns>
        public DescribeCCThresholdListResponse DescribeCCThresholdListSync(DescribeCCThresholdListRequest req)
        {
            return InternalRequestAsync<DescribeCCThresholdListResponse>(req, "DescribeCCThresholdList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC攻击指标数据，包括总请求峰值(QPS)和攻击请求(QPS)以及总请求次数和攻击请求次数
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public Task<DescribeCCTrendResponse> DescribeCCTrend(DescribeCCTrendRequest req)
        {
            return InternalRequestAsync<DescribeCCTrendResponse>(req, "DescribeCCTrend");
        }

        /// <summary>
        /// 获取CC攻击指标数据，包括总请求峰值(QPS)和攻击请求(QPS)以及总请求次数和攻击请求次数
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public DescribeCCTrendResponse DescribeCCTrendSync(DescribeCCTrendRequest req)
        {
            return InternalRequestAsync<DescribeCCTrendResponse>(req, "DescribeCCTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC四层黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeCcBlackWhiteIpListResponse"/></returns>
        public Task<DescribeCcBlackWhiteIpListResponse> DescribeCcBlackWhiteIpList(DescribeCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeCcBlackWhiteIpListResponse>(req, "DescribeCcBlackWhiteIpList");
        }

        /// <summary>
        /// 获取CC四层黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeCcBlackWhiteIpListResponse"/></returns>
        public DescribeCcBlackWhiteIpListResponse DescribeCcBlackWhiteIpListSync(DescribeCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeCcBlackWhiteIpListResponse>(req, "DescribeCcBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC防护的区域封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCcGeoIPBlockConfigListRequest"/></param>
        /// <returns><see cref="DescribeCcGeoIPBlockConfigListResponse"/></returns>
        public Task<DescribeCcGeoIPBlockConfigListResponse> DescribeCcGeoIPBlockConfigList(DescribeCcGeoIPBlockConfigListRequest req)
        {
            return InternalRequestAsync<DescribeCcGeoIPBlockConfigListResponse>(req, "DescribeCcGeoIPBlockConfigList");
        }

        /// <summary>
        /// 获取CC防护的区域封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCcGeoIPBlockConfigListRequest"/></param>
        /// <returns><see cref="DescribeCcGeoIPBlockConfigListResponse"/></returns>
        public DescribeCcGeoIPBlockConfigListResponse DescribeCcGeoIPBlockConfigListSync(DescribeCcGeoIPBlockConfigListRequest req)
        {
            return InternalRequestAsync<DescribeCcGeoIPBlockConfigListResponse>(req, "DescribeCcGeoIPBlockConfigList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlackWhiteIpListResponse"/></returns>
        public Task<DescribeDDoSBlackWhiteIpListResponse> DescribeDDoSBlackWhiteIpList(DescribeDDoSBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSBlackWhiteIpListResponse>(req, "DescribeDDoSBlackWhiteIpList");
        }

        /// <summary>
        /// 获取DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlackWhiteIpListResponse"/></returns>
        public DescribeDDoSBlackWhiteIpListResponse DescribeDDoSBlackWhiteIpListSync(DescribeDDoSBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSBlackWhiteIpListResponse>(req, "DescribeDDoSBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS连接抑制配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSConnectLimitListRequest"/></param>
        /// <returns><see cref="DescribeDDoSConnectLimitListResponse"/></returns>
        public Task<DescribeDDoSConnectLimitListResponse> DescribeDDoSConnectLimitList(DescribeDDoSConnectLimitListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSConnectLimitListResponse>(req, "DescribeDDoSConnectLimitList");
        }

        /// <summary>
        /// 获取DDoS连接抑制配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSConnectLimitListRequest"/></param>
        /// <returns><see cref="DescribeDDoSConnectLimitListResponse"/></returns>
        public DescribeDDoSConnectLimitListResponse DescribeDDoSConnectLimitListSync(DescribeDDoSConnectLimitListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSConnectLimitListResponse>(req, "DescribeDDoSConnectLimitList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public Task<DescribeDDoSTrendResponse> DescribeDDoSTrend(DescribeDDoSTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSTrendResponse>(req, "DescribeDDoSTrend");
        }

        /// <summary>
        /// 获取DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public DescribeDDoSTrendResponse DescribeDDoSTrendSync(DescribeDDoSTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSTrendResponse>(req, "DescribeDDoSTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单IP默认告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDefaultAlarmThresholdResponse"/></returns>
        public Task<DescribeDefaultAlarmThresholdResponse> DescribeDefaultAlarmThreshold(DescribeDefaultAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeDefaultAlarmThresholdResponse>(req, "DescribeDefaultAlarmThreshold");
        }

        /// <summary>
        /// 获取单IP默认告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDefaultAlarmThresholdResponse"/></returns>
        public DescribeDefaultAlarmThresholdResponse DescribeDefaultAlarmThresholdSync(DescribeDefaultAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeDefaultAlarmThresholdResponse>(req, "DescribeDefaultAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取IP封堵列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIpBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpBlockListResponse"/></returns>
        public Task<DescribeIpBlockListResponse> DescribeIpBlockList(DescribeIpBlockListRequest req)
        {
            return InternalRequestAsync<DescribeIpBlockListResponse>(req, "DescribeIpBlockList");
        }

        /// <summary>
        /// 获取IP封堵列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIpBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpBlockListResponse"/></returns>
        public DescribeIpBlockListResponse DescribeIpBlockListSync(DescribeIpBlockListRequest req)
        {
            return InternalRequestAsync<DescribeIpBlockListResponse>(req, "DescribeIpBlockList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询与证书ID对于域名匹配的七层规则
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesBySSLCertIdRequest"/></param>
        /// <returns><see cref="DescribeL7RulesBySSLCertIdResponse"/></returns>
        public Task<DescribeL7RulesBySSLCertIdResponse> DescribeL7RulesBySSLCertId(DescribeL7RulesBySSLCertIdRequest req)
        {
            return InternalRequestAsync<DescribeL7RulesBySSLCertIdResponse>(req, "DescribeL7RulesBySSLCertId");
        }

        /// <summary>
        /// 查询与证书ID对于域名匹配的七层规则
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesBySSLCertIdRequest"/></param>
        /// <returns><see cref="DescribeL7RulesBySSLCertIdResponse"/></returns>
        public DescribeL7RulesBySSLCertIdResponse DescribeL7RulesBySSLCertIdSync(DescribeL7RulesBySSLCertIdRequest req)
        {
            return InternalRequestAsync<DescribeL7RulesBySSLCertIdResponse>(req, "DescribeL7RulesBySSLCertId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防IP资产实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPIPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPIPInstancesResponse"/></returns>
        public Task<DescribeListBGPIPInstancesResponse> DescribeListBGPIPInstances(DescribeListBGPIPInstancesRequest req)
        {
            return InternalRequestAsync<DescribeListBGPIPInstancesResponse>(req, "DescribeListBGPIPInstances");
        }

        /// <summary>
        /// 获取高防IP资产实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPIPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPIPInstancesResponse"/></returns>
        public DescribeListBGPIPInstancesResponse DescribeListBGPIPInstancesSync(DescribeListBGPIPInstancesRequest req)
        {
            return InternalRequestAsync<DescribeListBGPIPInstancesResponse>(req, "DescribeListBGPIPInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防包资产实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPInstancesResponse"/></returns>
        public Task<DescribeListBGPInstancesResponse> DescribeListBGPInstances(DescribeListBGPInstancesRequest req)
        {
            return InternalRequestAsync<DescribeListBGPInstancesResponse>(req, "DescribeListBGPInstances");
        }

        /// <summary>
        /// 获取高防包资产实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPInstancesResponse"/></returns>
        public DescribeListBGPInstancesResponse DescribeListBGPInstancesSync(DescribeListBGPInstancesRequest req)
        {
            return InternalRequestAsync<DescribeListBGPInstancesResponse>(req, "DescribeListBGPInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS防护的IP黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeListBlackWhiteIpListResponse"/></returns>
        public Task<DescribeListBlackWhiteIpListResponse> DescribeListBlackWhiteIpList(DescribeListBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeListBlackWhiteIpListResponse>(req, "DescribeListBlackWhiteIpList");
        }

        /// <summary>
        /// 获取DDoS防护的IP黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeListBlackWhiteIpListResponse"/></returns>
        public DescribeListBlackWhiteIpListResponse DescribeListBlackWhiteIpListSync(DescribeListBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<DescribeListBlackWhiteIpListResponse>(req, "DescribeListBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS防护的AI防护开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSAIRequest"/></param>
        /// <returns><see cref="DescribeListDDoSAIResponse"/></returns>
        public Task<DescribeListDDoSAIResponse> DescribeListDDoSAI(DescribeListDDoSAIRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSAIResponse>(req, "DescribeListDDoSAI");
        }

        /// <summary>
        /// 获取DDoS防护的AI防护开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSAIRequest"/></param>
        /// <returns><see cref="DescribeListDDoSAIResponse"/></returns>
        public DescribeListDDoSAIResponse DescribeListDDoSAISync(DescribeListDDoSAIRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSAIResponse>(req, "DescribeListDDoSAI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS防护的区域封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSGeoIPBlockConfigResponse"/></returns>
        public Task<DescribeListDDoSGeoIPBlockConfigResponse> DescribeListDDoSGeoIPBlockConfig(DescribeListDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSGeoIPBlockConfigResponse>(req, "DescribeListDDoSGeoIPBlockConfig");
        }

        /// <summary>
        /// 获取DDoS防护的区域封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSGeoIPBlockConfigResponse"/></returns>
        public DescribeListDDoSGeoIPBlockConfigResponse DescribeListDDoSGeoIPBlockConfigSync(DescribeListDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSGeoIPBlockConfigResponse>(req, "DescribeListDDoSGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS防护的访问限速配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSSpeedLimitConfigResponse"/></returns>
        public Task<DescribeListDDoSSpeedLimitConfigResponse> DescribeListDDoSSpeedLimitConfig(DescribeListDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSSpeedLimitConfigResponse>(req, "DescribeListDDoSSpeedLimitConfig");
        }

        /// <summary>
        /// 获取DDoS防护的访问限速配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSSpeedLimitConfigResponse"/></returns>
        public DescribeListDDoSSpeedLimitConfigResponse DescribeListDDoSSpeedLimitConfigSync(DescribeListDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<DescribeListDDoSSpeedLimitConfigResponse>(req, "DescribeListDDoSSpeedLimitConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单IP告警阈值配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListIPAlarmConfigRequest"/></param>
        /// <returns><see cref="DescribeListIPAlarmConfigResponse"/></returns>
        public Task<DescribeListIPAlarmConfigResponse> DescribeListIPAlarmConfig(DescribeListIPAlarmConfigRequest req)
        {
            return InternalRequestAsync<DescribeListIPAlarmConfigResponse>(req, "DescribeListIPAlarmConfig");
        }

        /// <summary>
        /// 获取单IP告警阈值配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListIPAlarmConfigRequest"/></param>
        /// <returns><see cref="DescribeListIPAlarmConfigResponse"/></returns>
        public DescribeListIPAlarmConfigResponse DescribeListIPAlarmConfigSync(DescribeListIPAlarmConfigRequest req)
        {
            return InternalRequestAsync<DescribeListIPAlarmConfigResponse>(req, "DescribeListIPAlarmConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取转发监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListListenerRequest"/></param>
        /// <returns><see cref="DescribeListListenerResponse"/></returns>
        public Task<DescribeListListenerResponse> DescribeListListener(DescribeListListenerRequest req)
        {
            return InternalRequestAsync<DescribeListListenerResponse>(req, "DescribeListListener");
        }

        /// <summary>
        /// 获取转发监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListListenerRequest"/></param>
        /// <returns><see cref="DescribeListListenerResponse"/></returns>
        public DescribeListListenerResponse DescribeListListenerSync(DescribeListListenerRequest req)
        {
            return InternalRequestAsync<DescribeListListenerResponse>(req, "DescribeListListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS防护的特征过滤规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListPacketFilterConfigRequest"/></param>
        /// <returns><see cref="DescribeListPacketFilterConfigResponse"/></returns>
        public Task<DescribeListPacketFilterConfigResponse> DescribeListPacketFilterConfig(DescribeListPacketFilterConfigRequest req)
        {
            return InternalRequestAsync<DescribeListPacketFilterConfigResponse>(req, "DescribeListPacketFilterConfig");
        }

        /// <summary>
        /// 获取DDoS防护的特征过滤规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListPacketFilterConfigRequest"/></param>
        /// <returns><see cref="DescribeListPacketFilterConfigResponse"/></returns>
        public DescribeListPacketFilterConfigResponse DescribeListPacketFilterConfigSync(DescribeListPacketFilterConfigRequest req)
        {
            return InternalRequestAsync<DescribeListPacketFilterConfigResponse>(req, "DescribeListPacketFilterConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS防护的端口acl策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListPortAclListRequest"/></param>
        /// <returns><see cref="DescribeListPortAclListResponse"/></returns>
        public Task<DescribeListPortAclListResponse> DescribeListPortAclList(DescribeListPortAclListRequest req)
        {
            return InternalRequestAsync<DescribeListPortAclListResponse>(req, "DescribeListPortAclList");
        }

        /// <summary>
        /// 获取DDoS防护的端口acl策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListPortAclListRequest"/></param>
        /// <returns><see cref="DescribeListPortAclListResponse"/></returns>
        public DescribeListPortAclListResponse DescribeListPortAclListSync(DescribeListPortAclListRequest req)
        {
            return InternalRequestAsync<DescribeListPortAclListResponse>(req, "DescribeListPortAclList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS防护的协议封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtocolBlockConfigResponse"/></returns>
        public Task<DescribeListProtocolBlockConfigResponse> DescribeListProtocolBlockConfig(DescribeListProtocolBlockConfigRequest req)
        {
            return InternalRequestAsync<DescribeListProtocolBlockConfigResponse>(req, "DescribeListProtocolBlockConfig");
        }

        /// <summary>
        /// 获取DDoS防护的协议封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtocolBlockConfigResponse"/></returns>
        public DescribeListProtocolBlockConfigResponse DescribeListProtocolBlockConfigSync(DescribeListProtocolBlockConfigRequest req)
        {
            return InternalRequestAsync<DescribeListProtocolBlockConfigResponse>(req, "DescribeListProtocolBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取智能调度域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListSchedulingDomainRequest"/></param>
        /// <returns><see cref="DescribeListSchedulingDomainResponse"/></returns>
        public Task<DescribeListSchedulingDomainResponse> DescribeListSchedulingDomain(DescribeListSchedulingDomainRequest req)
        {
            return InternalRequestAsync<DescribeListSchedulingDomainResponse>(req, "DescribeListSchedulingDomain");
        }

        /// <summary>
        /// 获取智能调度域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListSchedulingDomainRequest"/></param>
        /// <returns><see cref="DescribeListSchedulingDomainResponse"/></returns>
        public DescribeListSchedulingDomainResponse DescribeListSchedulingDomainSync(DescribeListSchedulingDomainRequest req)
        {
            return InternalRequestAsync<DescribeListSchedulingDomainResponse>(req, "DescribeListSchedulingDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS防护的水印防护配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DescribeListWaterPrintConfigResponse"/></returns>
        public Task<DescribeListWaterPrintConfigResponse> DescribeListWaterPrintConfig(DescribeListWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<DescribeListWaterPrintConfigResponse>(req, "DescribeListWaterPrintConfig");
        }

        /// <summary>
        /// 获取DDoS防护的水印防护配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DescribeListWaterPrintConfigResponse"/></returns>
        public DescribeListWaterPrintConfigResponse DescribeListWaterPrintConfigSync(DescribeListWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<DescribeListWaterPrintConfigResponse>(req, "DescribeListWaterPrintConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 高防IP获取7层规则
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesResponse"/></returns>
        public Task<DescribeNewL7RulesResponse> DescribeNewL7Rules(DescribeNewL7RulesRequest req)
        {
            return InternalRequestAsync<DescribeNewL7RulesResponse>(req, "DescribeNewL7Rules");
        }

        /// <summary>
        /// 高防IP获取7层规则
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesResponse"/></returns>
        public DescribeNewL7RulesResponse DescribeNewL7RulesSync(DescribeNewL7RulesRequest req)
        {
            return InternalRequestAsync<DescribeNewL7RulesResponse>(req, "DescribeNewL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取L7转发规则健康检查异常结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesErrHealthResponse"/></returns>
        public Task<DescribeNewL7RulesErrHealthResponse> DescribeNewL7RulesErrHealth(DescribeNewL7RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeNewL7RulesErrHealthResponse>(req, "DescribeNewL7RulesErrHealth");
        }

        /// <summary>
        /// 获取L7转发规则健康检查异常结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesErrHealthResponse"/></returns>
        public DescribeNewL7RulesErrHealthResponse DescribeNewL7RulesErrHealthSync(DescribeNewL7RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeNewL7RulesErrHealthResponse>(req, "DescribeNewL7RulesErrHealth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取防护概览攻击趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewAttackTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewAttackTrendResponse"/></returns>
        public Task<DescribeOverviewAttackTrendResponse> DescribeOverviewAttackTrend(DescribeOverviewAttackTrendRequest req)
        {
            return InternalRequestAsync<DescribeOverviewAttackTrendResponse>(req, "DescribeOverviewAttackTrend");
        }

        /// <summary>
        /// 拉取防护概览攻击趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewAttackTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewAttackTrendResponse"/></returns>
        public DescribeOverviewAttackTrendResponse DescribeOverviewAttackTrendSync(DescribeOverviewAttackTrendRequest req)
        {
            return InternalRequestAsync<DescribeOverviewAttackTrendResponse>(req, "DescribeOverviewAttackTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取防护概览总请求峰值(QPS)和攻击请求(QPS)以及总请求次数和攻击请求次数
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewCCTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewCCTrendResponse"/></returns>
        public Task<DescribeOverviewCCTrendResponse> DescribeOverviewCCTrend(DescribeOverviewCCTrendRequest req)
        {
            return InternalRequestAsync<DescribeOverviewCCTrendResponse>(req, "DescribeOverviewCCTrend");
        }

        /// <summary>
        /// 获取防护概览总请求峰值(QPS)和攻击请求(QPS)以及总请求次数和攻击请求次数
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewCCTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewCCTrendResponse"/></returns>
        public DescribeOverviewCCTrendResponse DescribeOverviewCCTrendSync(DescribeOverviewCCTrendRequest req)
        {
            return InternalRequestAsync<DescribeOverviewCCTrendResponse>(req, "DescribeOverviewCCTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取防护概览的ddos攻击事件
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSEventListRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSEventListResponse"/></returns>
        public Task<DescribeOverviewDDoSEventListResponse> DescribeOverviewDDoSEventList(DescribeOverviewDDoSEventListRequest req)
        {
            return InternalRequestAsync<DescribeOverviewDDoSEventListResponse>(req, "DescribeOverviewDDoSEventList");
        }

        /// <summary>
        /// 获取防护概览的ddos攻击事件
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSEventListRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSEventListResponse"/></returns>
        public DescribeOverviewDDoSEventListResponse DescribeOverviewDDoSEventListSync(DescribeOverviewDDoSEventListRequest req)
        {
            return InternalRequestAsync<DescribeOverviewDDoSEventListResponse>(req, "DescribeOverviewDDoSEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取防护概览DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSTrendResponse"/></returns>
        public Task<DescribeOverviewDDoSTrendResponse> DescribeOverviewDDoSTrend(DescribeOverviewDDoSTrendRequest req)
        {
            return InternalRequestAsync<DescribeOverviewDDoSTrendResponse>(req, "DescribeOverviewDDoSTrend");
        }

        /// <summary>
        /// 获取防护概览DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSTrendResponse"/></returns>
        public DescribeOverviewDDoSTrendResponse DescribeOverviewDDoSTrendSync(DescribeOverviewDDoSTrendRequest req)
        {
            return InternalRequestAsync<DescribeOverviewDDoSTrendResponse>(req, "DescribeOverviewDDoSTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取防护概览指标
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewIndexRequest"/></param>
        /// <returns><see cref="DescribeOverviewIndexResponse"/></returns>
        public Task<DescribeOverviewIndexResponse> DescribeOverviewIndex(DescribeOverviewIndexRequest req)
        {
            return InternalRequestAsync<DescribeOverviewIndexResponse>(req, "DescribeOverviewIndex");
        }

        /// <summary>
        /// 拉取防护概览指标
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewIndexRequest"/></param>
        /// <returns><see cref="DescribeOverviewIndexResponse"/></returns>
        public DescribeOverviewIndexResponse DescribeOverviewIndexSync(DescribeOverviewIndexRequest req)
        {
            return InternalRequestAsync<DescribeOverviewIndexResponse>(req, "DescribeOverviewIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询账号维度待处理风险信息，包括是否为付费用户，查询攻击中、封堵中、过期资源数量等
        /// </summary>
        /// <param name="req"><see cref="DescribePendingRiskInfoRequest"/></param>
        /// <returns><see cref="DescribePendingRiskInfoResponse"/></returns>
        public Task<DescribePendingRiskInfoResponse> DescribePendingRiskInfo(DescribePendingRiskInfoRequest req)
        {
            return InternalRequestAsync<DescribePendingRiskInfoResponse>(req, "DescribePendingRiskInfo");
        }

        /// <summary>
        /// 查询账号维度待处理风险信息，包括是否为付费用户，查询攻击中、封堵中、过期资源数量等
        /// </summary>
        /// <param name="req"><see cref="DescribePendingRiskInfoRequest"/></param>
        /// <returns><see cref="DescribePendingRiskInfoResponse"/></returns>
        public DescribePendingRiskInfoResponse DescribePendingRiskInfoSync(DescribePendingRiskInfoRequest req)
        {
            return InternalRequestAsync<DescribePendingRiskInfoResponse>(req, "DescribePendingRiskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DisassociateDDoSEipAddress) 用于解绑高防弹性公网IP。
        /// </summary>
        /// <param name="req"><see cref="DisassociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="DisassociateDDoSEipAddressResponse"/></returns>
        public Task<DisassociateDDoSEipAddressResponse> DisassociateDDoSEipAddress(DisassociateDDoSEipAddressRequest req)
        {
            return InternalRequestAsync<DisassociateDDoSEipAddressResponse>(req, "DisassociateDDoSEipAddress");
        }

        /// <summary>
        /// 本接口 (DisassociateDDoSEipAddress) 用于解绑高防弹性公网IP。
        /// </summary>
        /// <param name="req"><see cref="DisassociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="DisassociateDDoSEipAddressResponse"/></returns>
        public DisassociateDDoSEipAddressResponse DisassociateDDoSEipAddressSync(DisassociateDDoSEipAddressRequest req)
        {
            return InternalRequestAsync<DisassociateDDoSEipAddressResponse>(req, "DisassociateDDoSEipAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改CC防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyCCLevelPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCLevelPolicyResponse"/></returns>
        public Task<ModifyCCLevelPolicyResponse> ModifyCCLevelPolicy(ModifyCCLevelPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCLevelPolicyResponse>(req, "ModifyCCLevelPolicy");
        }

        /// <summary>
        /// 修改CC防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyCCLevelPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCLevelPolicyResponse"/></returns>
        public ModifyCCLevelPolicyResponse ModifyCCLevelPolicySync(ModifyCCLevelPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCLevelPolicyResponse>(req, "ModifyCCLevelPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCPrecisionPolicyResponse"/></returns>
        public Task<ModifyCCPrecisionPolicyResponse> ModifyCCPrecisionPolicy(ModifyCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCPrecisionPolicyResponse>(req, "ModifyCCPrecisionPolicy");
        }

        /// <summary>
        /// 修改CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCPrecisionPolicyResponse"/></returns>
        public ModifyCCPrecisionPolicyResponse ModifyCCPrecisionPolicySync(ModifyCCPrecisionPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCPrecisionPolicyResponse>(req, "ModifyCCPrecisionPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCReqLimitPolicyResponse"/></returns>
        public Task<ModifyCCReqLimitPolicyResponse> ModifyCCReqLimitPolicy(ModifyCCReqLimitPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCReqLimitPolicyResponse>(req, "ModifyCCReqLimitPolicy");
        }

        /// <summary>
        /// 修改CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCReqLimitPolicyResponse"/></returns>
        public ModifyCCReqLimitPolicyResponse ModifyCCReqLimitPolicySync(ModifyCCReqLimitPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCReqLimitPolicyResponse>(req, "ModifyCCReqLimitPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改CC清洗阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCThresholdPolicyResponse"/></returns>
        public Task<ModifyCCThresholdPolicyResponse> ModifyCCThresholdPolicy(ModifyCCThresholdPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCThresholdPolicyResponse>(req, "ModifyCCThresholdPolicy");
        }

        /// <summary>
        /// 修改CC清洗阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCThresholdPolicyResponse"/></returns>
        public ModifyCCThresholdPolicyResponse ModifyCCThresholdPolicySync(ModifyCCThresholdPolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCThresholdPolicyResponse>(req, "ModifyCCThresholdPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyCcBlackWhiteIpListResponse"/></returns>
        public Task<ModifyCcBlackWhiteIpListResponse> ModifyCcBlackWhiteIpList(ModifyCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<ModifyCcBlackWhiteIpListResponse>(req, "ModifyCcBlackWhiteIpList");
        }

        /// <summary>
        /// 修改CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyCcBlackWhiteIpListResponse"/></returns>
        public ModifyCcBlackWhiteIpListResponse ModifyCcBlackWhiteIpListSync(ModifyCcBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<ModifyCcBlackWhiteIpListResponse>(req, "ModifyCcBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DDoS黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyDDoSBlackWhiteIpListResponse"/></returns>
        public Task<ModifyDDoSBlackWhiteIpListResponse> ModifyDDoSBlackWhiteIpList(ModifyDDoSBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<ModifyDDoSBlackWhiteIpListResponse>(req, "ModifyDDoSBlackWhiteIpList");
        }

        /// <summary>
        /// 修改DDoS黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyDDoSBlackWhiteIpListResponse"/></returns>
        public ModifyDDoSBlackWhiteIpListResponse ModifyDDoSBlackWhiteIpListSync(ModifyDDoSBlackWhiteIpListRequest req)
        {
            return InternalRequestAsync<ModifyDDoSBlackWhiteIpListResponse>(req, "ModifyDDoSBlackWhiteIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSGeoIPBlockConfigResponse"/></returns>
        public Task<ModifyDDoSGeoIPBlockConfigResponse> ModifyDDoSGeoIPBlockConfig(ModifyDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<ModifyDDoSGeoIPBlockConfigResponse>(req, "ModifyDDoSGeoIPBlockConfig");
        }

        /// <summary>
        /// 修改DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSGeoIPBlockConfigResponse"/></returns>
        public ModifyDDoSGeoIPBlockConfigResponse ModifyDDoSGeoIPBlockConfigSync(ModifyDDoSGeoIPBlockConfigRequest req)
        {
            return InternalRequestAsync<ModifyDDoSGeoIPBlockConfigResponse>(req, "ModifyDDoSGeoIPBlockConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 读取或修改DDoS的防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns><see cref="ModifyDDoSLevelResponse"/></returns>
        public Task<ModifyDDoSLevelResponse> ModifyDDoSLevel(ModifyDDoSLevelRequest req)
        {
            return InternalRequestAsync<ModifyDDoSLevelResponse>(req, "ModifyDDoSLevel");
        }

        /// <summary>
        /// 读取或修改DDoS的防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns><see cref="ModifyDDoSLevelResponse"/></returns>
        public ModifyDDoSLevelResponse ModifyDDoSLevelSync(ModifyDDoSLevelRequest req)
        {
            return InternalRequestAsync<ModifyDDoSLevelResponse>(req, "ModifyDDoSLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSSpeedLimitConfigResponse"/></returns>
        public Task<ModifyDDoSSpeedLimitConfigResponse> ModifyDDoSSpeedLimitConfig(ModifyDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<ModifyDDoSSpeedLimitConfigResponse>(req, "ModifyDDoSSpeedLimitConfig");
        }

        /// <summary>
        /// 修改DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSSpeedLimitConfigResponse"/></returns>
        public ModifyDDoSSpeedLimitConfigResponse ModifyDDoSSpeedLimitConfigSync(ModifyDDoSSpeedLimitConfigRequest req)
        {
            return InternalRequestAsync<ModifyDDoSSpeedLimitConfigResponse>(req, "ModifyDDoSSpeedLimitConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DDoS清洗阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSThresholdResponse"/></returns>
        public Task<ModifyDDoSThresholdResponse> ModifyDDoSThreshold(ModifyDDoSThresholdRequest req)
        {
            return InternalRequestAsync<ModifyDDoSThresholdResponse>(req, "ModifyDDoSThreshold");
        }

        /// <summary>
        /// 修改DDoS清洗阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSThresholdResponse"/></returns>
        public ModifyDDoSThresholdResponse ModifyDDoSThresholdSync(ModifyDDoSThresholdRequest req)
        {
            return InternalRequestAsync<ModifyDDoSThresholdResponse>(req, "ModifyDDoSThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改智能解析域名名称
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUsrNameRequest"/></param>
        /// <returns><see cref="ModifyDomainUsrNameResponse"/></returns>
        public Task<ModifyDomainUsrNameResponse> ModifyDomainUsrName(ModifyDomainUsrNameRequest req)
        {
            return InternalRequestAsync<ModifyDomainUsrNameResponse>(req, "ModifyDomainUsrName");
        }

        /// <summary>
        /// 修改智能解析域名名称
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUsrNameRequest"/></param>
        /// <returns><see cref="ModifyDomainUsrNameResponse"/></returns>
        public ModifyDomainUsrNameResponse ModifyDomainUsrNameSync(ModifyDomainUsrNameRequest req)
        {
            return InternalRequestAsync<ModifyDomainUsrNameResponse>(req, "ModifyDomainUsrName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改7层转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNewDomainRulesRequest"/></param>
        /// <returns><see cref="ModifyNewDomainRulesResponse"/></returns>
        public Task<ModifyNewDomainRulesResponse> ModifyNewDomainRules(ModifyNewDomainRulesRequest req)
        {
            return InternalRequestAsync<ModifyNewDomainRulesResponse>(req, "ModifyNewDomainRules");
        }

        /// <summary>
        /// 修改7层转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNewDomainRulesRequest"/></param>
        /// <returns><see cref="ModifyNewDomainRulesResponse"/></returns>
        public ModifyNewDomainRulesResponse ModifyNewDomainRulesSync(ModifyNewDomainRulesRequest req)
        {
            return InternalRequestAsync<ModifyNewDomainRulesResponse>(req, "ModifyNewDomainRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPacketFilterConfigRequest"/></param>
        /// <returns><see cref="ModifyPacketFilterConfigResponse"/></returns>
        public Task<ModifyPacketFilterConfigResponse> ModifyPacketFilterConfig(ModifyPacketFilterConfigRequest req)
        {
            return InternalRequestAsync<ModifyPacketFilterConfigResponse>(req, "ModifyPacketFilterConfig");
        }

        /// <summary>
        /// 修改DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPacketFilterConfigRequest"/></param>
        /// <returns><see cref="ModifyPacketFilterConfigResponse"/></returns>
        public ModifyPacketFilterConfigResponse ModifyPacketFilterConfigSync(ModifyPacketFilterConfigRequest req)
        {
            return InternalRequestAsync<ModifyPacketFilterConfigResponse>(req, "ModifyPacketFilterConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPortAclConfigRequest"/></param>
        /// <returns><see cref="ModifyPortAclConfigResponse"/></returns>
        public Task<ModifyPortAclConfigResponse> ModifyPortAclConfig(ModifyPortAclConfigRequest req)
        {
            return InternalRequestAsync<ModifyPortAclConfigResponse>(req, "ModifyPortAclConfig");
        }

        /// <summary>
        /// 修改DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPortAclConfigRequest"/></param>
        /// <returns><see cref="ModifyPortAclConfigResponse"/></returns>
        public ModifyPortAclConfigResponse ModifyPortAclConfigSync(ModifyPortAclConfigRequest req)
        {
            return InternalRequestAsync<ModifyPortAclConfigResponse>(req, "ModifyPortAclConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或关闭DDoS防护的水印防护配置，此功能为付费增值服务，有需求请联系售后
        /// </summary>
        /// <param name="req"><see cref="SwitchWaterPrintConfigRequest"/></param>
        /// <returns><see cref="SwitchWaterPrintConfigResponse"/></returns>
        public Task<SwitchWaterPrintConfigResponse> SwitchWaterPrintConfig(SwitchWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<SwitchWaterPrintConfigResponse>(req, "SwitchWaterPrintConfig");
        }

        /// <summary>
        /// 开启或关闭DDoS防护的水印防护配置，此功能为付费增值服务，有需求请联系售后
        /// </summary>
        /// <param name="req"><see cref="SwitchWaterPrintConfigRequest"/></param>
        /// <returns><see cref="SwitchWaterPrintConfigResponse"/></returns>
        public SwitchWaterPrintConfigResponse SwitchWaterPrintConfigSync(SwitchWaterPrintConfigRequest req)
        {
            return InternalRequestAsync<SwitchWaterPrintConfigResponse>(req, "SwitchWaterPrintConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
