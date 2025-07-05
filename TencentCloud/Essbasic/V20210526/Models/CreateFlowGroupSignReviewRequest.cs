/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class CreateFlowGroupSignReviewRequest : AbstractModel
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
        ///   合同(流程)组的合同组Id，为32位字符串，通过接口[通过多文件创建合同组签署流程](https://qian.tencent.com/developers/partnerApis/startFlows/ChannelCreateFlowGroupByFiles) 或[通过多模板创建合同组签署流程](https://qian.tencent.com/developers/partnerApis/startFlows/ChannelCreateFlowGroupByTemplates)创建合同组签署流程时返回。
        /// </summary>
        [JsonProperty("FlowGroupId")]
        public string FlowGroupId{ get; set; }

        /// <summary>
        /// 提交的审核结果，审核结果有下面三种情况
        /// <ul><li><b>PASS</b>: 审核通过，合同流程可以继续执行签署等操作</li>
        /// <li><b>REJECT</b>: 审核拒绝，合同流程不会变动</li>
        /// <li><b>SIGN_REJECT</b>:拒签，合同流程直接结束，合同状态变为**合同拒签**</li></ul>
        /// </summary>
        [JsonProperty("ReviewType")]
        public string ReviewType{ get; set; }

        /// <summary>
        /// 需要进行签署审核的签署人的个人信息或企业信息，签署方的匹配方式按照以下规则:
        /// 
        /// 个人：二选一（选择其中任意信息组合即可）
        /// <ul><li>姓名+证件类型+证件号</li>
        /// <li>姓名+手机号</li></ul>
        /// 
        /// 企业：二选一  （选择其中任意信息组合即可）
        /// <ul><li>企业名+姓名+证件类型+证件号</li>
        /// <li>企业名+姓名+手机号</li></ul>
        /// </summary>
        [JsonProperty("ApproverInfo")]
        public NeedReviewApproverInfo ApproverInfo{ get; set; }

        /// <summary>
        /// 审核不通过的原因，该字段的字符串长度不超过200个字符。
        /// 
        /// 注：`当审核类型（ReviewType）为审核拒绝（REJECT）或拒签（SIGN_REJECT）时，审核结果原因字段必须填写`
        /// </summary>
        [JsonProperty("ReviewMessage")]
        public string ReviewMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "FlowGroupId", this.FlowGroupId);
            this.SetParamSimple(map, prefix + "ReviewType", this.ReviewType);
            this.SetParamObj(map, prefix + "ApproverInfo.", this.ApproverInfo);
            this.SetParamSimple(map, prefix + "ReviewMessage", this.ReviewMessage);
        }
    }
}

