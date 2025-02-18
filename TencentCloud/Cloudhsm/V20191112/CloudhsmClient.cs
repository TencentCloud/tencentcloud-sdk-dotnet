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

namespace TencentCloud.Cloudhsm.V20191112
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudhsm.V20191112.Models;

   public class CloudhsmClient : AbstractClient{

       private const string endpoint = "cloudhsm.tencentcloudapi.com";
       private const string version = "2019-11-12";
       private const string sdkVersion = "SDK_NET_3.0.1182";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudhsmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CloudhsmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 通过SubnetId获取Hsm资源数
        /// </summary>
        /// <param name="req"><see cref="DescribeHSMBySubnetIdRequest"/></param>
        /// <returns><see cref="DescribeHSMBySubnetIdResponse"/></returns>
        public Task<DescribeHSMBySubnetIdResponse> DescribeHSMBySubnetId(DescribeHSMBySubnetIdRequest req)
        {
            return InternalRequestAsync<DescribeHSMBySubnetIdResponse>(req, "DescribeHSMBySubnetId");
        }

        /// <summary>
        /// 通过SubnetId获取Hsm资源数
        /// </summary>
        /// <param name="req"><see cref="DescribeHSMBySubnetIdRequest"/></param>
        /// <returns><see cref="DescribeHSMBySubnetIdResponse"/></returns>
        public DescribeHSMBySubnetIdResponse DescribeHSMBySubnetIdSync(DescribeHSMBySubnetIdRequest req)
        {
            return InternalRequestAsync<DescribeHSMBySubnetIdResponse>(req, "DescribeHSMBySubnetId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过VpcId获取Hsm资源数
        /// </summary>
        /// <param name="req"><see cref="DescribeHSMByVpcIdRequest"/></param>
        /// <returns><see cref="DescribeHSMByVpcIdResponse"/></returns>
        public Task<DescribeHSMByVpcIdResponse> DescribeHSMByVpcId(DescribeHSMByVpcIdRequest req)
        {
            return InternalRequestAsync<DescribeHSMByVpcIdResponse>(req, "DescribeHSMByVpcId");
        }

        /// <summary>
        /// 通过VpcId获取Hsm资源数
        /// </summary>
        /// <param name="req"><see cref="DescribeHSMByVpcIdRequest"/></param>
        /// <returns><see cref="DescribeHSMByVpcIdResponse"/></returns>
        public DescribeHSMByVpcIdResponse DescribeHSMByVpcIdSync(DescribeHSMByVpcIdRequest req)
        {
            return InternalRequestAsync<DescribeHSMByVpcIdResponse>(req, "DescribeHSMByVpcId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetRequest"/></param>
        /// <returns><see cref="DescribeSubnetResponse"/></returns>
        public Task<DescribeSubnetResponse> DescribeSubnet(DescribeSubnetRequest req)
        {
            return InternalRequestAsync<DescribeSubnetResponse>(req, "DescribeSubnet");
        }

        /// <summary>
        /// 查询子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetRequest"/></param>
        /// <returns><see cref="DescribeSubnetResponse"/></returns>
        public DescribeSubnetResponse DescribeSubnetSync(DescribeSubnetRequest req)
        {
            return InternalRequestAsync<DescribeSubnetResponse>(req, "DescribeSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前地域所支持的设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedHsmRequest"/></param>
        /// <returns><see cref="DescribeSupportedHsmResponse"/></returns>
        public Task<DescribeSupportedHsmResponse> DescribeSupportedHsm(DescribeSupportedHsmRequest req)
        {
            return InternalRequestAsync<DescribeSupportedHsmResponse>(req, "DescribeSupportedHsm");
        }

        /// <summary>
        /// 获取当前地域所支持的设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedHsmRequest"/></param>
        /// <returns><see cref="DescribeSupportedHsmResponse"/></returns>
        public DescribeSupportedHsmResponse DescribeSupportedHsmSync(DescribeSupportedHsmRequest req)
        {
            return InternalRequestAsync<DescribeSupportedHsmResponse>(req, "DescribeSupportedHsm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据用户的AppId获取用户安全组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsgRequest"/></param>
        /// <returns><see cref="DescribeUsgResponse"/></returns>
        public Task<DescribeUsgResponse> DescribeUsg(DescribeUsgRequest req)
        {
            return InternalRequestAsync<DescribeUsgResponse>(req, "DescribeUsg");
        }

        /// <summary>
        /// 根据用户的AppId获取用户安全组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsgRequest"/></param>
        /// <returns><see cref="DescribeUsgResponse"/></returns>
        public DescribeUsgResponse DescribeUsgSync(DescribeUsgRequest req)
        {
            return InternalRequestAsync<DescribeUsgResponse>(req, "DescribeUsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取安全组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUsgRuleRequest"/></param>
        /// <returns><see cref="DescribeUsgRuleResponse"/></returns>
        public Task<DescribeUsgRuleResponse> DescribeUsgRule(DescribeUsgRuleRequest req)
        {
            return InternalRequestAsync<DescribeUsgRuleResponse>(req, "DescribeUsgRule");
        }

        /// <summary>
        /// 获取安全组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUsgRuleRequest"/></param>
        /// <returns><see cref="DescribeUsgRuleResponse"/></returns>
        public DescribeUsgRuleResponse DescribeUsgRuleSync(DescribeUsgRuleRequest req)
        {
            return InternalRequestAsync<DescribeUsgRuleResponse>(req, "DescribeUsgRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户的私有网络列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcRequest"/></param>
        /// <returns><see cref="DescribeVpcResponse"/></returns>
        public Task<DescribeVpcResponse> DescribeVpc(DescribeVpcRequest req)
        {
            return InternalRequestAsync<DescribeVpcResponse>(req, "DescribeVpc");
        }

        /// <summary>
        /// 查询用户的私有网络列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcRequest"/></param>
        /// <returns><see cref="DescribeVpcResponse"/></returns>
        public DescribeVpcResponse DescribeVpcSync(DescribeVpcRequest req)
        {
            return InternalRequestAsync<DescribeVpcResponse>(req, "DescribeVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取VSM属性
        /// </summary>
        /// <param name="req"><see cref="DescribeVsmAttributesRequest"/></param>
        /// <returns><see cref="DescribeVsmAttributesResponse"/></returns>
        public Task<DescribeVsmAttributesResponse> DescribeVsmAttributes(DescribeVsmAttributesRequest req)
        {
            return InternalRequestAsync<DescribeVsmAttributesResponse>(req, "DescribeVsmAttributes");
        }

        /// <summary>
        /// 获取VSM属性
        /// </summary>
        /// <param name="req"><see cref="DescribeVsmAttributesRequest"/></param>
        /// <returns><see cref="DescribeVsmAttributesResponse"/></returns>
        public DescribeVsmAttributesResponse DescribeVsmAttributesSync(DescribeVsmAttributesRequest req)
        {
            return InternalRequestAsync<DescribeVsmAttributesResponse>(req, "DescribeVsmAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户VSM列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVsmsRequest"/></param>
        /// <returns><see cref="DescribeVsmsResponse"/></returns>
        public Task<DescribeVsmsResponse> DescribeVsms(DescribeVsmsRequest req)
        {
            return InternalRequestAsync<DescribeVsmsResponse>(req, "DescribeVsms");
        }

        /// <summary>
        /// 获取用户VSM列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVsmsRequest"/></param>
        /// <returns><see cref="DescribeVsmsResponse"/></returns>
        public DescribeVsmsResponse DescribeVsmsSync(DescribeVsmsRequest req)
        {
            return InternalRequestAsync<DescribeVsmsResponse>(req, "DescribeVsms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取告警事件
        /// </summary>
        /// <param name="req"><see cref="GetAlarmEventRequest"/></param>
        /// <returns><see cref="GetAlarmEventResponse"/></returns>
        public Task<GetAlarmEventResponse> GetAlarmEvent(GetAlarmEventRequest req)
        {
            return InternalRequestAsync<GetAlarmEventResponse>(req, "GetAlarmEvent");
        }

        /// <summary>
        /// 获取告警事件
        /// </summary>
        /// <param name="req"><see cref="GetAlarmEventRequest"/></param>
        /// <returns><see cref="GetAlarmEventResponse"/></returns>
        public GetAlarmEventResponse GetAlarmEventSync(GetAlarmEventRequest req)
        {
            return InternalRequestAsync<GetAlarmEventResponse>(req, "GetAlarmEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取VSM监控信息
        /// </summary>
        /// <param name="req"><see cref="GetVsmMonitorInfoRequest"/></param>
        /// <returns><see cref="GetVsmMonitorInfoResponse"/></returns>
        public Task<GetVsmMonitorInfoResponse> GetVsmMonitorInfo(GetVsmMonitorInfoRequest req)
        {
            return InternalRequestAsync<GetVsmMonitorInfoResponse>(req, "GetVsmMonitorInfo");
        }

        /// <summary>
        /// 获取VSM监控信息
        /// </summary>
        /// <param name="req"><see cref="GetVsmMonitorInfoRequest"/></param>
        /// <returns><see cref="GetVsmMonitorInfoResponse"/></returns>
        public GetVsmMonitorInfoResponse GetVsmMonitorInfoSync(GetVsmMonitorInfoRequest req)
        {
            return InternalRequestAsync<GetVsmMonitorInfoResponse>(req, "GetVsmMonitorInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买询价接口
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceBuyVsmRequest"/></param>
        /// <returns><see cref="InquiryPriceBuyVsmResponse"/></returns>
        public Task<InquiryPriceBuyVsmResponse> InquiryPriceBuyVsm(InquiryPriceBuyVsmRequest req)
        {
            return InternalRequestAsync<InquiryPriceBuyVsmResponse>(req, "InquiryPriceBuyVsm");
        }

        /// <summary>
        /// 购买询价接口
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceBuyVsmRequest"/></param>
        /// <returns><see cref="InquiryPriceBuyVsmResponse"/></returns>
        public InquiryPriceBuyVsmResponse InquiryPriceBuyVsmSync(InquiryPriceBuyVsmRequest req)
        {
            return InternalRequestAsync<InquiryPriceBuyVsmResponse>(req, "InquiryPriceBuyVsm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改告警事件
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmEventRequest"/></param>
        /// <returns><see cref="ModifyAlarmEventResponse"/></returns>
        public Task<ModifyAlarmEventResponse> ModifyAlarmEvent(ModifyAlarmEventRequest req)
        {
            return InternalRequestAsync<ModifyAlarmEventResponse>(req, "ModifyAlarmEvent");
        }

        /// <summary>
        /// 修改告警事件
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmEventRequest"/></param>
        /// <returns><see cref="ModifyAlarmEventResponse"/></returns>
        public ModifyAlarmEventResponse ModifyAlarmEventSync(ModifyAlarmEventRequest req)
        {
            return InternalRequestAsync<ModifyAlarmEventResponse>(req, "ModifyAlarmEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改VSM属性
        /// </summary>
        /// <param name="req"><see cref="ModifyVsmAttributesRequest"/></param>
        /// <returns><see cref="ModifyVsmAttributesResponse"/></returns>
        public Task<ModifyVsmAttributesResponse> ModifyVsmAttributes(ModifyVsmAttributesRequest req)
        {
            return InternalRequestAsync<ModifyVsmAttributesResponse>(req, "ModifyVsmAttributes");
        }

        /// <summary>
        /// 修改VSM属性
        /// </summary>
        /// <param name="req"><see cref="ModifyVsmAttributesRequest"/></param>
        /// <returns><see cref="ModifyVsmAttributesResponse"/></returns>
        public ModifyVsmAttributesResponse ModifyVsmAttributesSync(ModifyVsmAttributesRequest req)
        {
            return InternalRequestAsync<ModifyVsmAttributesResponse>(req, "ModifyVsmAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
