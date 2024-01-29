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

    public class ChannelCreateFlowSignReviewRequest : AbstractModel
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
        /// 合同流程ID，为32位字符串。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 企业内部审核结果
        /// <ul><li>PASS: 审核通过（流程可以继续签署或者发起）</li>
        /// <li>REJECT: 审核拒绝（流程状态不变，可以继续调用审核接口通过审核）</li>
        /// <li>SIGN_REJECT:拒签(流程终止，流程状态变为拒签状态)</li></ul>
        /// </summary>
        [JsonProperty("ReviewType")]
        public string ReviewType{ get; set; }

        /// <summary>
        /// 审核结果原因
        /// <ul><li>字符串长度不超过200</li>
        /// <li>当ReviewType 是拒绝（REJECT） 时此字段必填。</li>
        /// <li>当ReviewType 是拒绝（SIGN_REJECT） 时此字段必填。</li></ul>
        /// </summary>
        [JsonProperty("ReviewMessage")]
        public string ReviewMessage{ get; set; }

        /// <summary>
        /// 审核节点的签署人标志，用于指定当前审核的签署方
        /// <ul><li>**如果签署审核节点是个人， 此参数必填**。</li></ul>
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 流程审核操作类型，取值如下：
        /// <ul><li>**SignReview**：（默认）签署审核</li>
        /// <li>**CreateReview**：发起审核</li>
        /// <li>注意：`该字段不传或者为空，则默认为SignReview签署审核，走签署审核流程`</li></ul>
        /// 
        /// </summary>
        [JsonProperty("OperateType")]
        public string OperateType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "ReviewType", this.ReviewType);
            this.SetParamSimple(map, prefix + "ReviewMessage", this.ReviewMessage);
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamSimple(map, prefix + "OperateType", this.OperateType);
        }
    }
}

