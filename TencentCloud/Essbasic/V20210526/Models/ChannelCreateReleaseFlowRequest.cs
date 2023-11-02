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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelCreateReleaseFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// <li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li>
        /// <li>第三方平台子客企业中的员工标识: Agent. ProxyOperator.OpenId</li>
        /// </ul>
        /// 第三方平台子客企业和员工必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 待解除的签署流程编号(即原签署流程的编号)。
        /// </summary>
        [JsonProperty("NeedRelievedFlowId")]
        public string NeedRelievedFlowId{ get; set; }

        /// <summary>
        /// 解除协议内容, 包括解除理由等信息。
        /// </summary>
        [JsonProperty("ReliveInfo")]
        public RelieveInfo ReliveInfo{ get; set; }

        /// <summary>
        /// 替换解除协议的签署人， 如不指定替换签署人,  则使用原流程的签署人。 <br/>
        /// 如需更换原合同中的企业端签署人，可通过指定该签署人的RecipientId编号更换此企业端签署人。(可通过接口<a href="https://qian.tencent.com/developers/companyApis/queryFlows/DescribeFlowInfo/">DescribeFlowInfo</a>查询签署人的RecipientId编号)<br/>
        /// 
        /// 注意：
        /// <ul>
        /// <li>只能更换自己企业的签署人, 不支持更换个人类型或者其他企业的签署人</li>
        /// <li>可以不指定替换签署人, 使用原流程的签署人</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ReleasedApprovers")]
        public ReleasedApprover[] ReleasedApprovers{ get; set; }

        /// <summary>
        /// 签署完回调url，最大长度1000个字符
        /// </summary>
        [JsonProperty("CallbackUrl")]
        [System.Obsolete]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Organization")]
        [System.Obsolete]
        public OrganizationInfo Organization{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 合同流程的签署截止时间，格式为Unix标准时间戳(秒)，如果未设置签署截止时间，则默认为合同流程创建后的7天时截止。
        /// 如果在签署截止时间前未完成签署，则合同状态会变为已过期，导致合同作废。
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 调用方自定义的个性化字段，该字段的值可以是字符串JSON或其他字符串形式，客户可以根据自身需求自定义数据格式并在需要时进行解析。该字段的信息将以Base64编码的形式传输，支持的最大数据大小为20480长度。
        /// 
        /// 在合同状态变更的回调信息等场景中，该字段的信息将原封不动地透传给贵方。
        /// 
        /// 回调的相关说明可参考开发者中心的<a href="https://qian.tencent.com/developers/company/callback_types_v2" target="_blank">回调通知</a>模块。
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "NeedRelievedFlowId", this.NeedRelievedFlowId);
            this.SetParamObj(map, prefix + "ReliveInfo.", this.ReliveInfo);
            this.SetParamArrayObj(map, prefix + "ReleasedApprovers.", this.ReleasedApprovers);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamObj(map, prefix + "Organization.", this.Organization);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
        }
    }
}

