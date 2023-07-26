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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AntiddosClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 本接口 (AssociateDDoSEipAddress) 用于将高防弹性公网IP绑定到实例或弹性网卡的指定内网 IP 上。
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipAddressResponse"/></returns>
        public async Task<AssociateDDoSEipAddressResponse> AssociateDDoSEipAddress(AssociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<AssociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AssociateDDoSEipAddress) 用于将高防弹性公网IP绑定到实例或弹性网卡的指定内网 IP 上。
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipAddressResponse"/></returns>
        public AssociateDDoSEipAddressResponse AssociateDDoSEipAddressSync(AssociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<AssociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AssociateDDoSEipLoadBalancer) 用于将高防弹性公网IP绑定到负载均衡指定内网 IP 上。
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipLoadBalancerResponse"/></returns>
        public async Task<AssociateDDoSEipLoadBalancerResponse> AssociateDDoSEipLoadBalancer(AssociateDDoSEipLoadBalancerRequest req)
        {
             JsonResponseModel<AssociateDDoSEipLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateDDoSEipLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDDoSEipLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AssociateDDoSEipLoadBalancer) 用于将高防弹性公网IP绑定到负载均衡指定内网 IP 上。
        /// </summary>
        /// <param name="req"><see cref="AssociateDDoSEipLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateDDoSEipLoadBalancerResponse"/></returns>
        public AssociateDDoSEipLoadBalancerResponse AssociateDDoSEipLoadBalancerSync(AssociateDDoSEipLoadBalancerRequest req)
        {
             JsonResponseModel<AssociateDDoSEipLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateDDoSEipLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDDoSEipLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateBlackWhiteIpListResponse"/></returns>
        public async Task<CreateBlackWhiteIpListResponse> CreateBlackWhiteIpList(CreateBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateBlackWhiteIpListResponse"/></returns>
        public CreateBlackWhiteIpListResponse CreateBlackWhiteIpListSync(CreateBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定IP到高防包实例，支持独享包、共享包；需要注意的是此接口绑定或解绑IP是异步接口，当处于绑定或解绑中时，则不允许再进行绑定或解绑，需要等待当前绑定或解绑完成。
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public async Task<CreateBoundIPResponse> CreateBoundIP(CreateBoundIPRequest req)
        {
             JsonResponseModel<CreateBoundIPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBoundIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBoundIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定IP到高防包实例，支持独享包、共享包；需要注意的是此接口绑定或解绑IP是异步接口，当处于绑定或解绑中时，则不允许再进行绑定或解绑，需要等待当前绑定或解绑完成。
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public CreateBoundIPResponse CreateBoundIPSync(CreateBoundIPRequest req)
        {
             JsonResponseModel<CreateBoundIPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBoundIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBoundIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="CreateCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="CreateCCPrecisionPolicyResponse"/></returns>
        public async Task<CreateCCPrecisionPolicyResponse> CreateCCPrecisionPolicy(CreateCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<CreateCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="CreateCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="CreateCCPrecisionPolicyResponse"/></returns>
        public CreateCCPrecisionPolicyResponse CreateCCPrecisionPolicySync(CreateCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<CreateCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="CreateCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="CreateCCReqLimitPolicyResponse"/></returns>
        public async Task<CreateCCReqLimitPolicyResponse> CreateCCReqLimitPolicy(CreateCCReqLimitPolicyRequest req)
        {
             JsonResponseModel<CreateCCReqLimitPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCCReqLimitPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCReqLimitPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="CreateCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="CreateCCReqLimitPolicyResponse"/></returns>
        public CreateCCReqLimitPolicyResponse CreateCCReqLimitPolicySync(CreateCCReqLimitPolicyRequest req)
        {
             JsonResponseModel<CreateCCReqLimitPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCCReqLimitPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCReqLimitPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateCcBlackWhiteIpListResponse"/></returns>
        public async Task<CreateCcBlackWhiteIpListResponse> CreateCcBlackWhiteIpList(CreateCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateCcBlackWhiteIpListResponse"/></returns>
        public CreateCcBlackWhiteIpListResponse CreateCcBlackWhiteIpListSync(CreateCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建cc防护的地域封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateCcGeoIPBlockConfigResponse"/></returns>
        public async Task<CreateCcGeoIPBlockConfigResponse> CreateCcGeoIPBlockConfig(CreateCcGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<CreateCcGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCcGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建cc防护的地域封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateCcGeoIPBlockConfigResponse"/></returns>
        public CreateCcGeoIPBlockConfigResponse CreateCcGeoIPBlockConfigSync(CreateCcGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<CreateCcGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCcGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置DDoS防护的AI防护开关
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSAIRequest"/></param>
        /// <returns><see cref="CreateDDoSAIResponse"/></returns>
        public async Task<CreateDDoSAIResponse> CreateDDoSAI(CreateDDoSAIRequest req)
        {
             JsonResponseModel<CreateDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置DDoS防护的AI防护开关
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSAIRequest"/></param>
        /// <returns><see cref="CreateDDoSAIResponse"/></returns>
        public CreateDDoSAIResponse CreateDDoSAISync(CreateDDoSAIRequest req)
        {
             JsonResponseModel<CreateDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateDDoSBlackWhiteIpListResponse"/></returns>
        public async Task<CreateDDoSBlackWhiteIpListResponse> CreateDDoSBlackWhiteIpList(CreateDDoSBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateDDoSBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="CreateDDoSBlackWhiteIpListResponse"/></returns>
        public CreateDDoSBlackWhiteIpListResponse CreateDDoSBlackWhiteIpListSync(CreateDDoSBlackWhiteIpListRequest req)
        {
             JsonResponseModel<CreateDDoSBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置DDoS连接抑制选项
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSConnectLimitRequest"/></param>
        /// <returns><see cref="CreateDDoSConnectLimitResponse"/></returns>
        public async Task<CreateDDoSConnectLimitResponse> CreateDDoSConnectLimit(CreateDDoSConnectLimitRequest req)
        {
             JsonResponseModel<CreateDDoSConnectLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSConnectLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSConnectLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置DDoS连接抑制选项
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSConnectLimitRequest"/></param>
        /// <returns><see cref="CreateDDoSConnectLimitResponse"/></returns>
        public CreateDDoSConnectLimitResponse CreateDDoSConnectLimitSync(CreateDDoSConnectLimitRequest req)
        {
             JsonResponseModel<CreateDDoSConnectLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSConnectLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSConnectLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<CreateDDoSGeoIPBlockConfigResponse> CreateDDoSGeoIPBlockConfig(CreateDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSGeoIPBlockConfigResponse"/></returns>
        public CreateDDoSGeoIPBlockConfigResponse CreateDDoSGeoIPBlockConfigSync(CreateDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<CreateDDoSSpeedLimitConfigResponse> CreateDDoSSpeedLimitConfig(CreateDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<CreateDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="CreateDDoSSpeedLimitConfigResponse"/></returns>
        public CreateDDoSSpeedLimitConfigResponse CreateDDoSSpeedLimitConfigSync(CreateDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<CreateDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置单IP默认告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateDefaultAlarmThresholdResponse"/></returns>
        public async Task<CreateDefaultAlarmThresholdResponse> CreateDefaultAlarmThreshold(CreateDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<CreateDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置单IP默认告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateDefaultAlarmThresholdResponse"/></returns>
        public CreateDefaultAlarmThresholdResponse CreateDefaultAlarmThresholdSync(CreateDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<CreateDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置单IP告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="CreateIPAlarmThresholdConfigRequest"/></param>
        /// <returns><see cref="CreateIPAlarmThresholdConfigResponse"/></returns>
        public async Task<CreateIPAlarmThresholdConfigResponse> CreateIPAlarmThresholdConfig(CreateIPAlarmThresholdConfigRequest req)
        {
             JsonResponseModel<CreateIPAlarmThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIPAlarmThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIPAlarmThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置单IP告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="CreateIPAlarmThresholdConfigRequest"/></param>
        /// <returns><see cref="CreateIPAlarmThresholdConfigResponse"/></returns>
        public CreateIPAlarmThresholdConfigResponse CreateIPAlarmThresholdConfigSync(CreateIPAlarmThresholdConfigRequest req)
        {
             JsonResponseModel<CreateIPAlarmThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIPAlarmThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIPAlarmThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量配置L7转发规则的证书供SSL测调用
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertsRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertsResponse"/></returns>
        public async Task<CreateL7RuleCertsResponse> CreateL7RuleCerts(CreateL7RuleCertsRequest req)
        {
             JsonResponseModel<CreateL7RuleCertsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7RuleCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RuleCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量配置L7转发规则的证书供SSL测调用
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertsRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertsResponse"/></returns>
        public CreateL7RuleCertsResponse CreateL7RuleCertsSync(CreateL7RuleCertsRequest req)
        {
             JsonResponseModel<CreateL7RuleCertsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7RuleCerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RuleCertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加7层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesResponse"/></returns>
        public async Task<CreateNewL7RulesResponse> CreateNewL7Rules(CreateNewL7RulesRequest req)
        {
             JsonResponseModel<CreateNewL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNewL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNewL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加7层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesResponse"/></returns>
        public CreateNewL7RulesResponse CreateNewL7RulesSync(CreateNewL7RulesRequest req)
        {
             JsonResponseModel<CreateNewL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNewL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNewL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="CreatePacketFilterConfigRequest"/></param>
        /// <returns><see cref="CreatePacketFilterConfigResponse"/></returns>
        public async Task<CreatePacketFilterConfigResponse> CreatePacketFilterConfig(CreatePacketFilterConfigRequest req)
        {
             JsonResponseModel<CreatePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="CreatePacketFilterConfigRequest"/></param>
        /// <returns><see cref="CreatePacketFilterConfigResponse"/></returns>
        public CreatePacketFilterConfigResponse CreatePacketFilterConfigSync(CreatePacketFilterConfigRequest req)
        {
             JsonResponseModel<CreatePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="CreatePortAclConfigRequest"/></param>
        /// <returns><see cref="CreatePortAclConfigResponse"/></returns>
        public async Task<CreatePortAclConfigResponse> CreatePortAclConfig(CreatePortAclConfigRequest req)
        {
             JsonResponseModel<CreatePortAclConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePortAclConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePortAclConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="CreatePortAclConfigRequest"/></param>
        /// <returns><see cref="CreatePortAclConfigResponse"/></returns>
        public CreatePortAclConfigResponse CreatePortAclConfigSync(CreatePortAclConfigRequest req)
        {
             JsonResponseModel<CreatePortAclConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePortAclConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePortAclConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量添加DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="CreatePortAclConfigListRequest"/></param>
        /// <returns><see cref="CreatePortAclConfigListResponse"/></returns>
        public async Task<CreatePortAclConfigListResponse> CreatePortAclConfigList(CreatePortAclConfigListRequest req)
        {
             JsonResponseModel<CreatePortAclConfigListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePortAclConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePortAclConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量添加DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="CreatePortAclConfigListRequest"/></param>
        /// <returns><see cref="CreatePortAclConfigListResponse"/></returns>
        public CreatePortAclConfigListResponse CreatePortAclConfigListSync(CreatePortAclConfigListRequest req)
        {
             JsonResponseModel<CreatePortAclConfigListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePortAclConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePortAclConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置DDoS防护的协议封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="CreateProtocolBlockConfigResponse"/></returns>
        public async Task<CreateProtocolBlockConfigResponse> CreateProtocolBlockConfig(CreateProtocolBlockConfigRequest req)
        {
             JsonResponseModel<CreateProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置DDoS防护的协议封禁配置
        /// </summary>
        /// <param name="req"><see cref="CreateProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="CreateProtocolBlockConfigResponse"/></returns>
        public CreateProtocolBlockConfigResponse CreateProtocolBlockConfigSync(CreateProtocolBlockConfigRequest req)
        {
             JsonResponseModel<CreateProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个域名，可用于在封堵时调度切换IP
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulingDomainRequest"/></param>
        /// <returns><see cref="CreateSchedulingDomainResponse"/></returns>
        public async Task<CreateSchedulingDomainResponse> CreateSchedulingDomain(CreateSchedulingDomainRequest req)
        {
             JsonResponseModel<CreateSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个域名，可用于在封堵时调度切换IP
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulingDomainRequest"/></param>
        /// <returns><see cref="CreateSchedulingDomainResponse"/></returns>
        public CreateSchedulingDomainResponse CreateSchedulingDomainSync(CreateSchedulingDomainRequest req)
        {
             JsonResponseModel<CreateSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的水印防护配置
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintConfigRequest"/></param>
        /// <returns><see cref="CreateWaterPrintConfigResponse"/></returns>
        public async Task<CreateWaterPrintConfigResponse> CreateWaterPrintConfig(CreateWaterPrintConfigRequest req)
        {
             JsonResponseModel<CreateWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的水印防护配置
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintConfigRequest"/></param>
        /// <returns><see cref="CreateWaterPrintConfigResponse"/></returns>
        public CreateWaterPrintConfigResponse CreateWaterPrintConfigSync(CreateWaterPrintConfigRequest req)
        {
             JsonResponseModel<CreateWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的水印防护密钥
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintKeyRequest"/></param>
        /// <returns><see cref="CreateWaterPrintKeyResponse"/></returns>
        public async Task<CreateWaterPrintKeyResponse> CreateWaterPrintKey(CreateWaterPrintKeyRequest req)
        {
             JsonResponseModel<CreateWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS防护的水印防护密钥
        /// </summary>
        /// <param name="req"><see cref="CreateWaterPrintKeyRequest"/></param>
        /// <returns><see cref="CreateWaterPrintKeyResponse"/></returns>
        public CreateWaterPrintKeyResponse CreateWaterPrintKeySync(CreateWaterPrintKeyRequest req)
        {
             JsonResponseModel<CreateWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC分级策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCLevelPolicyResponse"/></returns>
        public async Task<DeleteCCLevelPolicyResponse> DeleteCCLevelPolicy(DeleteCCLevelPolicyRequest req)
        {
             JsonResponseModel<DeleteCCLevelPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCCLevelPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCLevelPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC分级策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCLevelPolicyResponse"/></returns>
        public DeleteCCLevelPolicyResponse DeleteCCLevelPolicySync(DeleteCCLevelPolicyRequest req)
        {
             JsonResponseModel<DeleteCCLevelPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCCLevelPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCLevelPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCPrecisionPolicyResponse"/></returns>
        public async Task<DeleteCCPrecisionPolicyResponse> DeleteCCPrecisionPolicy(DeleteCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<DeleteCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCPrecisionPolicyResponse"/></returns>
        public DeleteCCPrecisionPolicyResponse DeleteCCPrecisionPolicySync(DeleteCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<DeleteCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCRequestLimitPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCRequestLimitPolicyResponse"/></returns>
        public async Task<DeleteCCRequestLimitPolicyResponse> DeleteCCRequestLimitPolicy(DeleteCCRequestLimitPolicyRequest req)
        {
             JsonResponseModel<DeleteCCRequestLimitPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCCRequestLimitPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCRequestLimitPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCRequestLimitPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCRequestLimitPolicyResponse"/></returns>
        public DeleteCCRequestLimitPolicyResponse DeleteCCRequestLimitPolicySync(DeleteCCRequestLimitPolicyRequest req)
        {
             JsonResponseModel<DeleteCCRequestLimitPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCCRequestLimitPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCRequestLimitPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC清洗阈值策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCThresholdPolicyResponse"/></returns>
        public async Task<DeleteCCThresholdPolicyResponse> DeleteCCThresholdPolicy(DeleteCCThresholdPolicyRequest req)
        {
             JsonResponseModel<DeleteCCThresholdPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCCThresholdPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCThresholdPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC清洗阈值策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="DeleteCCThresholdPolicyResponse"/></returns>
        public DeleteCCThresholdPolicyResponse DeleteCCThresholdPolicySync(DeleteCCThresholdPolicyRequest req)
        {
             JsonResponseModel<DeleteCCThresholdPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCCThresholdPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCThresholdPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteCcBlackWhiteIpListResponse"/></returns>
        public async Task<DeleteCcBlackWhiteIpListResponse> DeleteCcBlackWhiteIpList(DeleteCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DeleteCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteCcBlackWhiteIpListResponse"/></returns>
        public DeleteCcBlackWhiteIpListResponse DeleteCcBlackWhiteIpListSync(DeleteCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DeleteCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="DeleteCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteCcGeoIPBlockConfigResponse"/></returns>
        public async Task<DeleteCcGeoIPBlockConfigResponse> DeleteCcGeoIPBlockConfig(DeleteCcGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DeleteCcGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCcGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="DeleteCcGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteCcGeoIPBlockConfigResponse"/></returns>
        public DeleteCcGeoIPBlockConfigResponse DeleteCcGeoIPBlockConfigSync(DeleteCcGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DeleteCcGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCcGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteDDoSBlackWhiteIpListResponse"/></returns>
        public async Task<DeleteDDoSBlackWhiteIpListResponse> DeleteDDoSBlackWhiteIpList(DeleteDDoSBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DeleteDDoSBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDDoSBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DeleteDDoSBlackWhiteIpListResponse"/></returns>
        public DeleteDDoSBlackWhiteIpListResponse DeleteDDoSBlackWhiteIpListSync(DeleteDDoSBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DeleteDDoSBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDDoSBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<DeleteDDoSGeoIPBlockConfigResponse> DeleteDDoSGeoIPBlockConfig(DeleteDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSGeoIPBlockConfigResponse"/></returns>
        public DeleteDDoSGeoIPBlockConfigResponse DeleteDDoSGeoIPBlockConfigSync(DeleteDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<DeleteDDoSSpeedLimitConfigResponse> DeleteDDoSSpeedLimitConfig(DeleteDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DeleteDDoSSpeedLimitConfigResponse"/></returns>
        public DeleteDDoSSpeedLimitConfigResponse DeleteDDoSSpeedLimitConfigSync(DeleteDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="DeletePacketFilterConfigRequest"/></param>
        /// <returns><see cref="DeletePacketFilterConfigResponse"/></returns>
        public async Task<DeletePacketFilterConfigResponse> DeletePacketFilterConfig(DeletePacketFilterConfigRequest req)
        {
             JsonResponseModel<DeletePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="DeletePacketFilterConfigRequest"/></param>
        /// <returns><see cref="DeletePacketFilterConfigResponse"/></returns>
        public DeletePacketFilterConfigResponse DeletePacketFilterConfigSync(DeletePacketFilterConfigRequest req)
        {
             JsonResponseModel<DeletePacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="DeletePortAclConfigRequest"/></param>
        /// <returns><see cref="DeletePortAclConfigResponse"/></returns>
        public async Task<DeletePortAclConfigResponse> DeletePortAclConfig(DeletePortAclConfigRequest req)
        {
             JsonResponseModel<DeletePortAclConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePortAclConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePortAclConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="DeletePortAclConfigRequest"/></param>
        /// <returns><see cref="DeletePortAclConfigResponse"/></returns>
        public DeletePortAclConfigResponse DeletePortAclConfigSync(DeletePortAclConfigRequest req)
        {
             JsonResponseModel<DeletePortAclConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePortAclConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePortAclConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的水印防护配置
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintConfigResponse"/></returns>
        public async Task<DeleteWaterPrintConfigResponse> DeleteWaterPrintConfig(DeleteWaterPrintConfigRequest req)
        {
             JsonResponseModel<DeleteWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的水印防护配置
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintConfigResponse"/></returns>
        public DeleteWaterPrintConfigResponse DeleteWaterPrintConfigSync(DeleteWaterPrintConfigRequest req)
        {
             JsonResponseModel<DeleteWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的水印防护密钥
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintKeyRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintKeyResponse"/></returns>
        public async Task<DeleteWaterPrintKeyResponse> DeleteWaterPrintKey(DeleteWaterPrintKeyRequest req)
        {
             JsonResponseModel<DeleteWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS防护的水印防护密钥
        /// </summary>
        /// <param name="req"><see cref="DeleteWaterPrintKeyRequest"/></param>
        /// <returns><see cref="DeleteWaterPrintKeyResponse"/></returns>
        public DeleteWaterPrintKeyResponse DeleteWaterPrintKeySync(DeleteWaterPrintKeyRequest req)
        {
             JsonResponseModel<DeleteWaterPrintKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWaterPrintKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWaterPrintKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础防护攻击状态
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceStatusRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceStatusResponse"/></returns>
        public async Task<DescribeBasicDeviceStatusResponse> DescribeBasicDeviceStatus(DescribeBasicDeviceStatusRequest req)
        {
             JsonResponseModel<DescribeBasicDeviceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBasicDeviceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicDeviceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础防护攻击状态
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceStatusRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceStatusResponse"/></returns>
        public DescribeBasicDeviceStatusResponse DescribeBasicDeviceStatusSync(DescribeBasicDeviceStatusRequest req)
        {
             JsonResponseModel<DescribeBasicDeviceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBasicDeviceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicDeviceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防包流量折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeBgpBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBgpBizTrendResponse"/></returns>
        public async Task<DescribeBgpBizTrendResponse> DescribeBgpBizTrend(DescribeBgpBizTrendRequest req)
        {
             JsonResponseModel<DescribeBgpBizTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBgpBizTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBgpBizTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防包流量折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeBgpBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBgpBizTrendResponse"/></returns>
        public DescribeBgpBizTrendResponse DescribeBgpBizTrendSync(DescribeBgpBizTrendRequest req)
        {
             JsonResponseModel<DescribeBgpBizTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBgpBizTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBgpBizTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取业务流量状态码统计列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBizHttpStatusRequest"/></param>
        /// <returns><see cref="DescribeBizHttpStatusResponse"/></returns>
        public async Task<DescribeBizHttpStatusResponse> DescribeBizHttpStatus(DescribeBizHttpStatusRequest req)
        {
             JsonResponseModel<DescribeBizHttpStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBizHttpStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBizHttpStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取业务流量状态码统计列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBizHttpStatusRequest"/></param>
        /// <returns><see cref="DescribeBizHttpStatusResponse"/></returns>
        public DescribeBizHttpStatusResponse DescribeBizHttpStatusSync(DescribeBizHttpStatusRequest req)
        {
             JsonResponseModel<DescribeBizHttpStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBizHttpStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBizHttpStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防IP业务监控流量曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeBizMonitorTrendRequest"/></param>
        /// <returns><see cref="DescribeBizMonitorTrendResponse"/></returns>
        public async Task<DescribeBizMonitorTrendResponse> DescribeBizMonitorTrend(DescribeBizMonitorTrendRequest req)
        {
             JsonResponseModel<DescribeBizMonitorTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBizMonitorTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBizMonitorTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防IP业务监控流量曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeBizMonitorTrendRequest"/></param>
        /// <returns><see cref="DescribeBizMonitorTrendResponse"/></returns>
        public DescribeBizMonitorTrendResponse DescribeBizMonitorTrendSync(DescribeBizMonitorTrendRequest req)
        {
             JsonResponseModel<DescribeBizMonitorTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBizMonitorTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBizMonitorTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取业务流量曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBizTrendResponse"/></returns>
        public async Task<DescribeBizTrendResponse> DescribeBizTrend(DescribeBizTrendRequest req)
        {
             JsonResponseModel<DescribeBizTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBizTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBizTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取业务流量曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBizTrendResponse"/></returns>
        public DescribeBizTrendResponse DescribeBizTrendSync(DescribeBizTrendRequest req)
        {
             JsonResponseModel<DescribeBizTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBizTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBizTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeBlackWhiteIpListResponse"/></returns>
        public async Task<DescribeBlackWhiteIpListResponse> DescribeBlackWhiteIpList(DescribeBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeBlackWhiteIpListResponse"/></returns>
        public DescribeBlackWhiteIpListResponse DescribeBlackWhiteIpListSync(DescribeBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边界防护CC防护等级列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelListRequest"/></param>
        /// <returns><see cref="DescribeCCLevelListResponse"/></returns>
        public async Task<DescribeCCLevelListResponse> DescribeCCLevelList(DescribeCCLevelListRequest req)
        {
             JsonResponseModel<DescribeCCLevelListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCLevelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCLevelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边界防护CC防护等级列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelListRequest"/></param>
        /// <returns><see cref="DescribeCCLevelListResponse"/></returns>
        public DescribeCCLevelListResponse DescribeCCLevelListSync(DescribeCCLevelListRequest req)
        {
             JsonResponseModel<DescribeCCLevelListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCLevelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCLevelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC分级策略
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DescribeCCLevelPolicyResponse"/></returns>
        public async Task<DescribeCCLevelPolicyResponse> DescribeCCLevelPolicy(DescribeCCLevelPolicyRequest req)
        {
             JsonResponseModel<DescribeCCLevelPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCLevelPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCLevelPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC分级策略
        /// </summary>
        /// <param name="req"><see cref="DescribeCCLevelPolicyRequest"/></param>
        /// <returns><see cref="DescribeCCLevelPolicyResponse"/></returns>
        public DescribeCCLevelPolicyResponse DescribeCCLevelPolicySync(DescribeCCLevelPolicyRequest req)
        {
             JsonResponseModel<DescribeCCLevelPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCLevelPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCLevelPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC精准防护列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCPrecisionPlyListRequest"/></param>
        /// <returns><see cref="DescribeCCPrecisionPlyListResponse"/></returns>
        public async Task<DescribeCCPrecisionPlyListResponse> DescribeCCPrecisionPlyList(DescribeCCPrecisionPlyListRequest req)
        {
             JsonResponseModel<DescribeCCPrecisionPlyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCPrecisionPlyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCPrecisionPlyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC精准防护列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCPrecisionPlyListRequest"/></param>
        /// <returns><see cref="DescribeCCPrecisionPlyListResponse"/></returns>
        public DescribeCCPrecisionPlyListResponse DescribeCCPrecisionPlyListSync(DescribeCCPrecisionPlyListRequest req)
        {
             JsonResponseModel<DescribeCCPrecisionPlyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCPrecisionPlyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCPrecisionPlyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC频率限制策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCReqLimitPolicyListRequest"/></param>
        /// <returns><see cref="DescribeCCReqLimitPolicyListResponse"/></returns>
        public async Task<DescribeCCReqLimitPolicyListResponse> DescribeCCReqLimitPolicyList(DescribeCCReqLimitPolicyListRequest req)
        {
             JsonResponseModel<DescribeCCReqLimitPolicyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCReqLimitPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCReqLimitPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC频率限制策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCReqLimitPolicyListRequest"/></param>
        /// <returns><see cref="DescribeCCReqLimitPolicyListResponse"/></returns>
        public DescribeCCReqLimitPolicyListResponse DescribeCCReqLimitPolicyListSync(DescribeCCReqLimitPolicyListRequest req)
        {
             JsonResponseModel<DescribeCCReqLimitPolicyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCReqLimitPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCReqLimitPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC清洗阈值列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCThresholdListRequest"/></param>
        /// <returns><see cref="DescribeCCThresholdListResponse"/></returns>
        public async Task<DescribeCCThresholdListResponse> DescribeCCThresholdList(DescribeCCThresholdListRequest req)
        {
             JsonResponseModel<DescribeCCThresholdListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCThresholdList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCThresholdListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC清洗阈值列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCThresholdListRequest"/></param>
        /// <returns><see cref="DescribeCCThresholdListResponse"/></returns>
        public DescribeCCThresholdListResponse DescribeCCThresholdListSync(DescribeCCThresholdListRequest req)
        {
             JsonResponseModel<DescribeCCThresholdListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCThresholdList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCThresholdListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC攻击指标数据，包括总请求峰值(QPS)和攻击请求(QPS)以及总请求次数和攻击请求次数
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public async Task<DescribeCCTrendResponse> DescribeCCTrend(DescribeCCTrendRequest req)
        {
             JsonResponseModel<DescribeCCTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC攻击指标数据，包括总请求峰值(QPS)和攻击请求(QPS)以及总请求次数和攻击请求次数
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public DescribeCCTrendResponse DescribeCCTrendSync(DescribeCCTrendRequest req)
        {
             JsonResponseModel<DescribeCCTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC四层黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeCcBlackWhiteIpListResponse"/></returns>
        public async Task<DescribeCcBlackWhiteIpListResponse> DescribeCcBlackWhiteIpList(DescribeCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC四层黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeCcBlackWhiteIpListResponse"/></returns>
        public DescribeCcBlackWhiteIpListResponse DescribeCcBlackWhiteIpListSync(DescribeCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC防护的区域封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCcGeoIPBlockConfigListRequest"/></param>
        /// <returns><see cref="DescribeCcGeoIPBlockConfigListResponse"/></returns>
        public async Task<DescribeCcGeoIPBlockConfigListResponse> DescribeCcGeoIPBlockConfigList(DescribeCcGeoIPBlockConfigListRequest req)
        {
             JsonResponseModel<DescribeCcGeoIPBlockConfigListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcGeoIPBlockConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcGeoIPBlockConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC防护的区域封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCcGeoIPBlockConfigListRequest"/></param>
        /// <returns><see cref="DescribeCcGeoIPBlockConfigListResponse"/></returns>
        public DescribeCcGeoIPBlockConfigListResponse DescribeCcGeoIPBlockConfigListSync(DescribeCcGeoIPBlockConfigListRequest req)
        {
             JsonResponseModel<DescribeCcGeoIPBlockConfigListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcGeoIPBlockConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcGeoIPBlockConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlackWhiteIpListResponse"/></returns>
        public async Task<DescribeDDoSBlackWhiteIpListResponse> DescribeDDoSBlackWhiteIpList(DescribeDDoSBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeDDoSBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的IP网段黑白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlackWhiteIpListResponse"/></returns>
        public DescribeDDoSBlackWhiteIpListResponse DescribeDDoSBlackWhiteIpListSync(DescribeDDoSBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeDDoSBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS连接抑制配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSConnectLimitListRequest"/></param>
        /// <returns><see cref="DescribeDDoSConnectLimitListResponse"/></returns>
        public async Task<DescribeDDoSConnectLimitListResponse> DescribeDDoSConnectLimitList(DescribeDDoSConnectLimitListRequest req)
        {
             JsonResponseModel<DescribeDDoSConnectLimitListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSConnectLimitList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSConnectLimitListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS连接抑制配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSConnectLimitListRequest"/></param>
        /// <returns><see cref="DescribeDDoSConnectLimitListResponse"/></returns>
        public DescribeDDoSConnectLimitListResponse DescribeDDoSConnectLimitListSync(DescribeDDoSConnectLimitListRequest req)
        {
             JsonResponseModel<DescribeDDoSConnectLimitListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSConnectLimitList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSConnectLimitListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public async Task<DescribeDDoSTrendResponse> DescribeDDoSTrend(DescribeDDoSTrendRequest req)
        {
             JsonResponseModel<DescribeDDoSTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public DescribeDDoSTrendResponse DescribeDDoSTrendSync(DescribeDDoSTrendRequest req)
        {
             JsonResponseModel<DescribeDDoSTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单IP默认告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDefaultAlarmThresholdResponse"/></returns>
        public async Task<DescribeDefaultAlarmThresholdResponse> DescribeDefaultAlarmThreshold(DescribeDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单IP默认告警阈值配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDefaultAlarmThresholdResponse"/></returns>
        public DescribeDefaultAlarmThresholdResponse DescribeDefaultAlarmThresholdSync(DescribeDefaultAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeDefaultAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefaultAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询与证书ID对于域名匹配的七层规则
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesBySSLCertIdRequest"/></param>
        /// <returns><see cref="DescribeL7RulesBySSLCertIdResponse"/></returns>
        public async Task<DescribeL7RulesBySSLCertIdResponse> DescribeL7RulesBySSLCertId(DescribeL7RulesBySSLCertIdRequest req)
        {
             JsonResponseModel<DescribeL7RulesBySSLCertIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL7RulesBySSLCertId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7RulesBySSLCertIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询与证书ID对于域名匹配的七层规则
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesBySSLCertIdRequest"/></param>
        /// <returns><see cref="DescribeL7RulesBySSLCertIdResponse"/></returns>
        public DescribeL7RulesBySSLCertIdResponse DescribeL7RulesBySSLCertIdSync(DescribeL7RulesBySSLCertIdRequest req)
        {
             JsonResponseModel<DescribeL7RulesBySSLCertIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL7RulesBySSLCertId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7RulesBySSLCertIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防IP资产实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPIPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPIPInstancesResponse"/></returns>
        public async Task<DescribeListBGPIPInstancesResponse> DescribeListBGPIPInstances(DescribeListBGPIPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPIPInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListBGPIPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPIPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防IP资产实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPIPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPIPInstancesResponse"/></returns>
        public DescribeListBGPIPInstancesResponse DescribeListBGPIPInstancesSync(DescribeListBGPIPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPIPInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListBGPIPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPIPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防包资产实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPInstancesResponse"/></returns>
        public async Task<DescribeListBGPInstancesResponse> DescribeListBGPInstances(DescribeListBGPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListBGPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防包资产实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBGPInstancesRequest"/></param>
        /// <returns><see cref="DescribeListBGPInstancesResponse"/></returns>
        public DescribeListBGPInstancesResponse DescribeListBGPInstancesSync(DescribeListBGPInstancesRequest req)
        {
             JsonResponseModel<DescribeListBGPInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListBGPInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBGPInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的IP黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeListBlackWhiteIpListResponse"/></returns>
        public async Task<DescribeListBlackWhiteIpListResponse> DescribeListBlackWhiteIpList(DescribeListBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeListBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的IP黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="DescribeListBlackWhiteIpListResponse"/></returns>
        public DescribeListBlackWhiteIpListResponse DescribeListBlackWhiteIpListSync(DescribeListBlackWhiteIpListRequest req)
        {
             JsonResponseModel<DescribeListBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的AI防护开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSAIRequest"/></param>
        /// <returns><see cref="DescribeListDDoSAIResponse"/></returns>
        public async Task<DescribeListDDoSAIResponse> DescribeListDDoSAI(DescribeListDDoSAIRequest req)
        {
             JsonResponseModel<DescribeListDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的AI防护开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSAIRequest"/></param>
        /// <returns><see cref="DescribeListDDoSAIResponse"/></returns>
        public DescribeListDDoSAIResponse DescribeListDDoSAISync(DescribeListDDoSAIRequest req)
        {
             JsonResponseModel<DescribeListDDoSAIResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListDDoSAI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSAIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的区域封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<DescribeListDDoSGeoIPBlockConfigResponse> DescribeListDDoSGeoIPBlockConfig(DescribeListDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的区域封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSGeoIPBlockConfigResponse"/></returns>
        public DescribeListDDoSGeoIPBlockConfigResponse DescribeListDDoSGeoIPBlockConfigSync(DescribeListDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的访问限速配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<DescribeListDDoSSpeedLimitConfigResponse> DescribeListDDoSSpeedLimitConfig(DescribeListDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的访问限速配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="DescribeListDDoSSpeedLimitConfigResponse"/></returns>
        public DescribeListDDoSSpeedLimitConfigResponse DescribeListDDoSSpeedLimitConfigSync(DescribeListDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单IP告警阈值配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListIPAlarmConfigRequest"/></param>
        /// <returns><see cref="DescribeListIPAlarmConfigResponse"/></returns>
        public async Task<DescribeListIPAlarmConfigResponse> DescribeListIPAlarmConfig(DescribeListIPAlarmConfigRequest req)
        {
             JsonResponseModel<DescribeListIPAlarmConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListIPAlarmConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListIPAlarmConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单IP告警阈值配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListIPAlarmConfigRequest"/></param>
        /// <returns><see cref="DescribeListIPAlarmConfigResponse"/></returns>
        public DescribeListIPAlarmConfigResponse DescribeListIPAlarmConfigSync(DescribeListIPAlarmConfigRequest req)
        {
             JsonResponseModel<DescribeListIPAlarmConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListIPAlarmConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListIPAlarmConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取转发监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListListenerRequest"/></param>
        /// <returns><see cref="DescribeListListenerResponse"/></returns>
        public async Task<DescribeListListenerResponse> DescribeListListener(DescribeListListenerRequest req)
        {
             JsonResponseModel<DescribeListListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取转发监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListListenerRequest"/></param>
        /// <returns><see cref="DescribeListListenerResponse"/></returns>
        public DescribeListListenerResponse DescribeListListenerSync(DescribeListListenerRequest req)
        {
             JsonResponseModel<DescribeListListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的特征过滤规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListPacketFilterConfigRequest"/></param>
        /// <returns><see cref="DescribeListPacketFilterConfigResponse"/></returns>
        public async Task<DescribeListPacketFilterConfigResponse> DescribeListPacketFilterConfig(DescribeListPacketFilterConfigRequest req)
        {
             JsonResponseModel<DescribeListPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的特征过滤规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListPacketFilterConfigRequest"/></param>
        /// <returns><see cref="DescribeListPacketFilterConfigResponse"/></returns>
        public DescribeListPacketFilterConfigResponse DescribeListPacketFilterConfigSync(DescribeListPacketFilterConfigRequest req)
        {
             JsonResponseModel<DescribeListPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的端口acl策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListPortAclListRequest"/></param>
        /// <returns><see cref="DescribeListPortAclListResponse"/></returns>
        public async Task<DescribeListPortAclListResponse> DescribeListPortAclList(DescribeListPortAclListRequest req)
        {
             JsonResponseModel<DescribeListPortAclListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListPortAclList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListPortAclListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的端口acl策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListPortAclListRequest"/></param>
        /// <returns><see cref="DescribeListPortAclListResponse"/></returns>
        public DescribeListPortAclListResponse DescribeListPortAclListSync(DescribeListPortAclListRequest req)
        {
             JsonResponseModel<DescribeListPortAclListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListPortAclList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListPortAclListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护阈值配置列表，包括DDoS的AI、等级、CC阈值开关等
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtectThresholdConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtectThresholdConfigResponse"/></returns>
        public async Task<DescribeListProtectThresholdConfigResponse> DescribeListProtectThresholdConfig(DescribeListProtectThresholdConfigRequest req)
        {
             JsonResponseModel<DescribeListProtectThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListProtectThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtectThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护阈值配置列表，包括DDoS的AI、等级、CC阈值开关等
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtectThresholdConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtectThresholdConfigResponse"/></returns>
        public DescribeListProtectThresholdConfigResponse DescribeListProtectThresholdConfigSync(DescribeListProtectThresholdConfigRequest req)
        {
             JsonResponseModel<DescribeListProtectThresholdConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListProtectThresholdConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtectThresholdConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的协议封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtocolBlockConfigResponse"/></returns>
        public async Task<DescribeListProtocolBlockConfigResponse> DescribeListProtocolBlockConfig(DescribeListProtocolBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的协议封禁配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListProtocolBlockConfigRequest"/></param>
        /// <returns><see cref="DescribeListProtocolBlockConfigResponse"/></returns>
        public DescribeListProtocolBlockConfigResponse DescribeListProtocolBlockConfigSync(DescribeListProtocolBlockConfigRequest req)
        {
             JsonResponseModel<DescribeListProtocolBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListProtocolBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListProtocolBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取智能调度域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListSchedulingDomainRequest"/></param>
        /// <returns><see cref="DescribeListSchedulingDomainResponse"/></returns>
        public async Task<DescribeListSchedulingDomainResponse> DescribeListSchedulingDomain(DescribeListSchedulingDomainRequest req)
        {
             JsonResponseModel<DescribeListSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取智能调度域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListSchedulingDomainRequest"/></param>
        /// <returns><see cref="DescribeListSchedulingDomainResponse"/></returns>
        public DescribeListSchedulingDomainResponse DescribeListSchedulingDomainSync(DescribeListSchedulingDomainRequest req)
        {
             JsonResponseModel<DescribeListSchedulingDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListSchedulingDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListSchedulingDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的水印防护配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DescribeListWaterPrintConfigResponse"/></returns>
        public async Task<DescribeListWaterPrintConfigResponse> DescribeListWaterPrintConfig(DescribeListWaterPrintConfigRequest req)
        {
             JsonResponseModel<DescribeListWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护的水印防护配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListWaterPrintConfigRequest"/></param>
        /// <returns><see cref="DescribeListWaterPrintConfigResponse"/></returns>
        public DescribeListWaterPrintConfigResponse DescribeListWaterPrintConfigSync(DescribeListWaterPrintConfigRequest req)
        {
             JsonResponseModel<DescribeListWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 高防IP获取7层规则
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesResponse"/></returns>
        public async Task<DescribeNewL7RulesResponse> DescribeNewL7Rules(DescribeNewL7RulesRequest req)
        {
             JsonResponseModel<DescribeNewL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNewL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNewL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 高防IP获取7层规则
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesResponse"/></returns>
        public DescribeNewL7RulesResponse DescribeNewL7RulesSync(DescribeNewL7RulesRequest req)
        {
             JsonResponseModel<DescribeNewL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNewL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNewL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取L7转发规则健康检查异常结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesErrHealthResponse"/></returns>
        public async Task<DescribeNewL7RulesErrHealthResponse> DescribeNewL7RulesErrHealth(DescribeNewL7RulesErrHealthRequest req)
        {
             JsonResponseModel<DescribeNewL7RulesErrHealthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNewL7RulesErrHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNewL7RulesErrHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取L7转发规则健康检查异常结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesErrHealthResponse"/></returns>
        public DescribeNewL7RulesErrHealthResponse DescribeNewL7RulesErrHealthSync(DescribeNewL7RulesErrHealthRequest req)
        {
             JsonResponseModel<DescribeNewL7RulesErrHealthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNewL7RulesErrHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNewL7RulesErrHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取防护概览攻击趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewAttackTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewAttackTrendResponse"/></returns>
        public async Task<DescribeOverviewAttackTrendResponse> DescribeOverviewAttackTrend(DescribeOverviewAttackTrendRequest req)
        {
             JsonResponseModel<DescribeOverviewAttackTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOverviewAttackTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewAttackTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取防护概览攻击趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewAttackTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewAttackTrendResponse"/></returns>
        public DescribeOverviewAttackTrendResponse DescribeOverviewAttackTrendSync(DescribeOverviewAttackTrendRequest req)
        {
             JsonResponseModel<DescribeOverviewAttackTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOverviewAttackTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewAttackTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护概览总请求峰值(QPS)和攻击请求(QPS)以及总请求次数和攻击请求次数
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewCCTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewCCTrendResponse"/></returns>
        public async Task<DescribeOverviewCCTrendResponse> DescribeOverviewCCTrend(DescribeOverviewCCTrendRequest req)
        {
             JsonResponseModel<DescribeOverviewCCTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOverviewCCTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewCCTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护概览总请求峰值(QPS)和攻击请求(QPS)以及总请求次数和攻击请求次数
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewCCTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewCCTrendResponse"/></returns>
        public DescribeOverviewCCTrendResponse DescribeOverviewCCTrendSync(DescribeOverviewCCTrendRequest req)
        {
             JsonResponseModel<DescribeOverviewCCTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOverviewCCTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewCCTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护概览的ddos攻击事件
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSEventListRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSEventListResponse"/></returns>
        public async Task<DescribeOverviewDDoSEventListResponse> DescribeOverviewDDoSEventList(DescribeOverviewDDoSEventListRequest req)
        {
             JsonResponseModel<DescribeOverviewDDoSEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOverviewDDoSEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewDDoSEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护概览的ddos攻击事件
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSEventListRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSEventListResponse"/></returns>
        public DescribeOverviewDDoSEventListResponse DescribeOverviewDDoSEventListSync(DescribeOverviewDDoSEventListRequest req)
        {
             JsonResponseModel<DescribeOverviewDDoSEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOverviewDDoSEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewDDoSEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护概览DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSTrendResponse"/></returns>
        public async Task<DescribeOverviewDDoSTrendResponse> DescribeOverviewDDoSTrend(DescribeOverviewDDoSTrendRequest req)
        {
             JsonResponseModel<DescribeOverviewDDoSTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOverviewDDoSTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewDDoSTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护概览DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeOverviewDDoSTrendResponse"/></returns>
        public DescribeOverviewDDoSTrendResponse DescribeOverviewDDoSTrendSync(DescribeOverviewDDoSTrendRequest req)
        {
             JsonResponseModel<DescribeOverviewDDoSTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOverviewDDoSTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewDDoSTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取防护概览指标
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewIndexRequest"/></param>
        /// <returns><see cref="DescribeOverviewIndexResponse"/></returns>
        public async Task<DescribeOverviewIndexResponse> DescribeOverviewIndex(DescribeOverviewIndexRequest req)
        {
             JsonResponseModel<DescribeOverviewIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOverviewIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取防护概览指标
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewIndexRequest"/></param>
        /// <returns><see cref="DescribeOverviewIndexResponse"/></returns>
        public DescribeOverviewIndexResponse DescribeOverviewIndexSync(DescribeOverviewIndexRequest req)
        {
             JsonResponseModel<DescribeOverviewIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOverviewIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账号维度待处理风险信息，包括是否为付费用户，查询攻击中、封堵中、过期资源数量等
        /// </summary>
        /// <param name="req"><see cref="DescribePendingRiskInfoRequest"/></param>
        /// <returns><see cref="DescribePendingRiskInfoResponse"/></returns>
        public async Task<DescribePendingRiskInfoResponse> DescribePendingRiskInfo(DescribePendingRiskInfoRequest req)
        {
             JsonResponseModel<DescribePendingRiskInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePendingRiskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePendingRiskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账号维度待处理风险信息，包括是否为付费用户，查询攻击中、封堵中、过期资源数量等
        /// </summary>
        /// <param name="req"><see cref="DescribePendingRiskInfoRequest"/></param>
        /// <returns><see cref="DescribePendingRiskInfoResponse"/></returns>
        public DescribePendingRiskInfoResponse DescribePendingRiskInfoSync(DescribePendingRiskInfoRequest req)
        {
             JsonResponseModel<DescribePendingRiskInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePendingRiskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePendingRiskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DisassociateDDoSEipAddress) 用于解绑高防弹性公网IP。
        /// </summary>
        /// <param name="req"><see cref="DisassociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="DisassociateDDoSEipAddressResponse"/></returns>
        public async Task<DisassociateDDoSEipAddressResponse> DisassociateDDoSEipAddress(DisassociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<DisassociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DisassociateDDoSEipAddress) 用于解绑高防弹性公网IP。
        /// </summary>
        /// <param name="req"><see cref="DisassociateDDoSEipAddressRequest"/></param>
        /// <returns><see cref="DisassociateDDoSEipAddressResponse"/></returns>
        public DisassociateDDoSEipAddressResponse DisassociateDDoSEipAddressSync(DisassociateDDoSEipAddressRequest req)
        {
             JsonResponseModel<DisassociateDDoSEipAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateDDoSEipAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDDoSEipAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyCCLevelPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCLevelPolicyResponse"/></returns>
        public async Task<ModifyCCLevelPolicyResponse> ModifyCCLevelPolicy(ModifyCCLevelPolicyRequest req)
        {
             JsonResponseModel<ModifyCCLevelPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCLevelPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCLevelPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyCCLevelPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCLevelPolicyResponse"/></returns>
        public ModifyCCLevelPolicyResponse ModifyCCLevelPolicySync(ModifyCCLevelPolicyRequest req)
        {
             JsonResponseModel<ModifyCCLevelPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCLevelPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCLevelPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCPrecisionPolicyResponse"/></returns>
        public async Task<ModifyCCPrecisionPolicyResponse> ModifyCCPrecisionPolicy(ModifyCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<ModifyCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC精准防护策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPrecisionPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCPrecisionPolicyResponse"/></returns>
        public ModifyCCPrecisionPolicyResponse ModifyCCPrecisionPolicySync(ModifyCCPrecisionPolicyRequest req)
        {
             JsonResponseModel<ModifyCCPrecisionPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCPrecisionPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCPrecisionPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCReqLimitPolicyResponse"/></returns>
        public async Task<ModifyCCReqLimitPolicyResponse> ModifyCCReqLimitPolicy(ModifyCCReqLimitPolicyRequest req)
        {
             JsonResponseModel<ModifyCCReqLimitPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCReqLimitPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCReqLimitPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC频率限制策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCCReqLimitPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCReqLimitPolicyResponse"/></returns>
        public ModifyCCReqLimitPolicyResponse ModifyCCReqLimitPolicySync(ModifyCCReqLimitPolicyRequest req)
        {
             JsonResponseModel<ModifyCCReqLimitPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCReqLimitPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCReqLimitPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC清洗阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCThresholdPolicyResponse"/></returns>
        public async Task<ModifyCCThresholdPolicyResponse> ModifyCCThresholdPolicy(ModifyCCThresholdPolicyRequest req)
        {
             JsonResponseModel<ModifyCCThresholdPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCThresholdPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCThresholdPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC清洗阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyCCThresholdPolicyRequest"/></param>
        /// <returns><see cref="ModifyCCThresholdPolicyResponse"/></returns>
        public ModifyCCThresholdPolicyResponse ModifyCCThresholdPolicySync(ModifyCCThresholdPolicyRequest req)
        {
             JsonResponseModel<ModifyCCThresholdPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCThresholdPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCThresholdPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyCcBlackWhiteIpListResponse"/></returns>
        public async Task<ModifyCcBlackWhiteIpListResponse> ModifyCcBlackWhiteIpList(ModifyCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<ModifyCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC四层黑白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCcBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyCcBlackWhiteIpListResponse"/></returns>
        public ModifyCcBlackWhiteIpListResponse ModifyCcBlackWhiteIpListSync(ModifyCcBlackWhiteIpListRequest req)
        {
             JsonResponseModel<ModifyCcBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCcBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyDDoSBlackWhiteIpListResponse"/></returns>
        public async Task<ModifyDDoSBlackWhiteIpListResponse> ModifyDDoSBlackWhiteIpList(ModifyDDoSBlackWhiteIpListRequest req)
        {
             JsonResponseModel<ModifyDDoSBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS黑白名单列表
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSBlackWhiteIpListRequest"/></param>
        /// <returns><see cref="ModifyDDoSBlackWhiteIpListResponse"/></returns>
        public ModifyDDoSBlackWhiteIpListResponse ModifyDDoSBlackWhiteIpListSync(ModifyDDoSBlackWhiteIpListRequest req)
        {
             JsonResponseModel<ModifyDDoSBlackWhiteIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSBlackWhiteIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSBlackWhiteIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSGeoIPBlockConfigResponse"/></returns>
        public async Task<ModifyDDoSGeoIPBlockConfigResponse> ModifyDDoSGeoIPBlockConfig(ModifyDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS防护的区域封禁配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSGeoIPBlockConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSGeoIPBlockConfigResponse"/></returns>
        public ModifyDDoSGeoIPBlockConfigResponse ModifyDDoSGeoIPBlockConfigSync(ModifyDDoSGeoIPBlockConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSGeoIPBlockConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSGeoIPBlockConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 读取或修改DDoS的防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns><see cref="ModifyDDoSLevelResponse"/></returns>
        public async Task<ModifyDDoSLevelResponse> ModifyDDoSLevel(ModifyDDoSLevelRequest req)
        {
             JsonResponseModel<ModifyDDoSLevelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 读取或修改DDoS的防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns><see cref="ModifyDDoSLevelResponse"/></returns>
        public ModifyDDoSLevelResponse ModifyDDoSLevelSync(ModifyDDoSLevelRequest req)
        {
             JsonResponseModel<ModifyDDoSLevelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSSpeedLimitConfigResponse"/></returns>
        public async Task<ModifyDDoSSpeedLimitConfigResponse> ModifyDDoSSpeedLimitConfig(ModifyDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS防护的访问限速配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSpeedLimitConfigRequest"/></param>
        /// <returns><see cref="ModifyDDoSSpeedLimitConfigResponse"/></returns>
        public ModifyDDoSSpeedLimitConfigResponse ModifyDDoSSpeedLimitConfigSync(ModifyDDoSSpeedLimitConfigRequest req)
        {
             JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSSpeedLimitConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSSpeedLimitConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS清洗阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSThresholdResponse"/></returns>
        public async Task<ModifyDDoSThresholdResponse> ModifyDDoSThreshold(ModifyDDoSThresholdRequest req)
        {
             JsonResponseModel<ModifyDDoSThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS清洗阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSThresholdResponse"/></returns>
        public ModifyDDoSThresholdResponse ModifyDDoSThresholdSync(ModifyDDoSThresholdRequest req)
        {
             JsonResponseModel<ModifyDDoSThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改智能解析域名名称
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUsrNameRequest"/></param>
        /// <returns><see cref="ModifyDomainUsrNameResponse"/></returns>
        public async Task<ModifyDomainUsrNameResponse> ModifyDomainUsrName(ModifyDomainUsrNameRequest req)
        {
             JsonResponseModel<ModifyDomainUsrNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainUsrName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainUsrNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改智能解析域名名称
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUsrNameRequest"/></param>
        /// <returns><see cref="ModifyDomainUsrNameResponse"/></returns>
        public ModifyDomainUsrNameResponse ModifyDomainUsrNameSync(ModifyDomainUsrNameRequest req)
        {
             JsonResponseModel<ModifyDomainUsrNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainUsrName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainUsrNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改7层转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNewDomainRulesRequest"/></param>
        /// <returns><see cref="ModifyNewDomainRulesResponse"/></returns>
        public async Task<ModifyNewDomainRulesResponse> ModifyNewDomainRules(ModifyNewDomainRulesRequest req)
        {
             JsonResponseModel<ModifyNewDomainRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNewDomainRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNewDomainRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改7层转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNewDomainRulesRequest"/></param>
        /// <returns><see cref="ModifyNewDomainRulesResponse"/></returns>
        public ModifyNewDomainRulesResponse ModifyNewDomainRulesSync(ModifyNewDomainRulesRequest req)
        {
             JsonResponseModel<ModifyNewDomainRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNewDomainRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNewDomainRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPacketFilterConfigRequest"/></param>
        /// <returns><see cref="ModifyPacketFilterConfigResponse"/></returns>
        public async Task<ModifyPacketFilterConfigResponse> ModifyPacketFilterConfig(ModifyPacketFilterConfigRequest req)
        {
             JsonResponseModel<ModifyPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS防护的特征过滤规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPacketFilterConfigRequest"/></param>
        /// <returns><see cref="ModifyPacketFilterConfigResponse"/></returns>
        public ModifyPacketFilterConfigResponse ModifyPacketFilterConfigSync(ModifyPacketFilterConfigRequest req)
        {
             JsonResponseModel<ModifyPacketFilterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPacketFilterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPacketFilterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPortAclConfigRequest"/></param>
        /// <returns><see cref="ModifyPortAclConfigResponse"/></returns>
        public async Task<ModifyPortAclConfigResponse> ModifyPortAclConfig(ModifyPortAclConfigRequest req)
        {
             JsonResponseModel<ModifyPortAclConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPortAclConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPortAclConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS防护的端口acl策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPortAclConfigRequest"/></param>
        /// <returns><see cref="ModifyPortAclConfigResponse"/></returns>
        public ModifyPortAclConfigResponse ModifyPortAclConfigSync(ModifyPortAclConfigRequest req)
        {
             JsonResponseModel<ModifyPortAclConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPortAclConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPortAclConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或关闭DDoS防护的水印防护配置
        /// </summary>
        /// <param name="req"><see cref="SwitchWaterPrintConfigRequest"/></param>
        /// <returns><see cref="SwitchWaterPrintConfigResponse"/></returns>
        public async Task<SwitchWaterPrintConfigResponse> SwitchWaterPrintConfig(SwitchWaterPrintConfigRequest req)
        {
             JsonResponseModel<SwitchWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或关闭DDoS防护的水印防护配置
        /// </summary>
        /// <param name="req"><see cref="SwitchWaterPrintConfigRequest"/></param>
        /// <returns><see cref="SwitchWaterPrintConfigResponse"/></returns>
        public SwitchWaterPrintConfigResponse SwitchWaterPrintConfigSync(SwitchWaterPrintConfigRequest req)
        {
             JsonResponseModel<SwitchWaterPrintConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchWaterPrintConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchWaterPrintConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
