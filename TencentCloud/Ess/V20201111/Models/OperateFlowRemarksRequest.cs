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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OperateFlowRemarksRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>执行本接口操作的员工信息。<br>注: <code>在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。</code></p>
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// <p>指定对合同备注的操作</p><p>枚举值：</p><ul><li>CREATE： 创建合同备注</li><li>UPDATE： 更新合同备注</li><li>DELETE： 删除合同备注</li></ul>
        /// </summary>
        [JsonProperty("OperateType")]
        public string OperateType{ get; set; }

        /// <summary>
        /// <p>对应的合同流程id</p><p>目标合同为合同组时此参数不填</p>
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// <p>代理企业和员工的信息。<br>在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。</p>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// <p>对应合同组id</p><p>目标合同为单份合同时此参数不填</p>
        /// </summary>
        [JsonProperty("FlowGroupId")]
        public string FlowGroupId{ get; set; }

        /// <summary>
        /// <p>合同备注信息。</p><p>入参限制：当OperateType为UPDATE和DELETE时，通过该结构体进行对应备注操作，合同备注数量范围为 1 - 5个。</p>
        /// </summary>
        [JsonProperty("FlowItem")]
        public FlowRemarkItem FlowItem{ get; set; }

        /// <summary>
        /// <p>合同备注列表。</p><p>入参限制：当OperateType为CREATE时，通过该参数进行全量的合同备注创建。</p>
        /// </summary>
        [JsonProperty("FlowItems")]
        public string[] FlowItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "OperateType", this.OperateType);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "FlowGroupId", this.FlowGroupId);
            this.SetParamObj(map, prefix + "FlowItem.", this.FlowItem);
            this.SetParamArraySimple(map, prefix + "FlowItems.", this.FlowItems);
        }
    }
}

