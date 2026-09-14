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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIRoundPath : AbstractModel
    {
        
        /// <summary>
        /// <p>画布中的节点名称</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>画布中的节点类型</p><p>枚举值：</p><ul><li>DIALOGUE： 对话节点</li><li>API_CALL： 接口调用节点</li><li>TRANSFER： 转接节点</li><li>KEY_PRESS： 按键节点</li><li>END_CALL： 挂断节点</li><li>TRANSFER_AGENT： 转接智能体节点</li><li>WORK_TIME： 工作时间节点</li></ul>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>经过当前节点的时间戳</p><p>单位：ms</p>
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// <p>接口调用节点的调用详情，包含请求、响应、耗时以及每次重试的明细。仅 NodeType 为 API_CALL 时有值，其余节点类型不返回该字段。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("APICall")]
        public AICallAPICallDetail APICall{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamObj(map, prefix + "APICall.", this.APICall);
        }
    }
}

