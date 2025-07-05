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

    public class ChannelCreateFlowApproversRequest : AbstractModel
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
        /// 补充企业签署人信息。
        /// 
        /// - 如果发起方指定的补充签署人是企业签署人，则需要提供企业名称或者企业OpenId；
        /// 
        /// - 如果不指定，则使用姓名和手机号进行补充。
        /// </summary>
        [JsonProperty("Approvers")]
        public FillApproverInfo[] Approvers{ get; set; }

        /// <summary>
        /// 合同流程ID，为32位字符串。 
        /// - 建议开发者妥善保存此流程ID，以便于顺利进行后续操作。
        /// - 可登录腾讯电子签控制台，在 "合同"->"合同中心" 中查看某个合同的FlowId(在页面中展示为合同ID)。
        /// - <font color="red">不建议继续使用</font>，请使用<a href="https://qian.tencent.com/developers/partnerApis/dataTypes/#fillapproverinfo/" target="_blank">补充签署人结构体</a>中的FlowId指定合同
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 签署人信息补充方式
        /// 
        /// <ul><li>**1**: 表示往未指定签署人的节点，添加一个明确的签署人，支持企业或个人签署方。</li></ul>
        /// </summary>
        [JsonProperty("FillApproverType")]
        public long? FillApproverType{ get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 合同流程组的组ID, 在合同流程组场景下，生成合同流程组的签署链接时需要赋值
        /// </summary>
        [JsonProperty("FlowGroupId")]
        public string FlowGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "Approvers.", this.Approvers);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "FillApproverType", this.FillApproverType);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "FlowGroupId", this.FlowGroupId);
        }
    }
}

