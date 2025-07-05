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

    public class ModifyFlowDeadlineRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 合同流程ID，为32位字符串。
        /// <ul><li>建议开发者妥善保存此流程ID，以便于顺利进行后续操作。</li>
        /// <li>可登录腾讯电子签控制台，在 "合同"->"合同中心" 中查看某个合同的FlowId(在页面中展示为合同ID)。</li></ul>
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 签署流程或签署人新的签署截止时间，格式为Unix标准时间戳（秒）
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 签署方角色编号，为32位字符串
        /// <ul><li>若指定了此参数，则只调整签署流程中此签署人的签署截止时间，否则调整合同整体的签署截止时间（合同截止时间+发起时未设置签署人截止时间的参与人的签署截止时间）</li>
        /// <li>通过[用PDF文件创建签署流程](https://test.qian.tencent.cn/developers/partnerApis/startFlows/ChannelCreateFlowByFiles)发起合同，或通过[用模板创建签署流程](https://test.qian.tencent.cn/developers/partnerApis/startFlows/CreateFlowsByTemplates)时，返回参数[FlowApprovers](https://test.qian.tencent.cn/developers/partnerApis/dataTypes/#approveritem)会返回此信息，建议开发者妥善保存</li>
        /// <li>也可通过[获取合同信息](https://test.qian.tencent.cn/developers/partnerApis/flows/DescribeFlowDetailInfo)接口查询签署人的RecipientId编号</li></ul>
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
        }
    }
}

