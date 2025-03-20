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

    public class CreateFlowForwardsRequest : AbstractModel
    {
        
        /// <summary>
        /// 合同对应参与方需要修改的目标经办人对应的OpenId。
        /// 
        /// 注意：`需要保证目标经办人已经加入企业且已实名`
        /// </summary>
        [JsonProperty("TargetOpenId")]
        public string TargetOpenId{ get; set; }

        /// <summary>
        /// 企业签署方的合同及对应签署方
        /// </summary>
        [JsonProperty("FlowForwardInfos")]
        public FlowForwardInfo[] FlowForwardInfos{ get; set; }

        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。此接口下面信息必填。<ul><li>渠道应用标识:  Agent.AppId</li><li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li><li>第三方平台子客企业中的员工标识: Agent. ProxyOperator.OpenId</li></ul>第三方平台子客企业和员工必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetOpenId", this.TargetOpenId);
            this.SetParamArrayObj(map, prefix + "FlowForwardInfos.", this.FlowForwardInfos);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

