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

    public class PrepareFlowsRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 和 Agent.ProxyAppId 均必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 多个合同（签署流程）信息，最大支持20个签署流程。
        /// </summary>
        [JsonProperty("FlowInfos")]
        public FlowInfo[] FlowInfos{ get; set; }

        /// <summary>
        /// 操作完成后的跳转地址，最大长度200
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "FlowInfos.", this.FlowInfos);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

