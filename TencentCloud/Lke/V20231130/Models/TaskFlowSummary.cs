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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskFlowSummary : AbstractModel
    {
        
        /// <summary>
        /// 任务流程名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentName")]
        public string IntentName{ get; set; }

        /// <summary>
        /// 实体列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedSlotValues")]
        public ValueInfo[] UpdatedSlotValues{ get; set; }

        /// <summary>
        /// 节点列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunNodes")]
        public RunNodeInfo[] RunNodes{ get; set; }

        /// <summary>
        /// 意图判断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Purposes")]
        public string[] Purposes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IntentName", this.IntentName);
            this.SetParamArrayObj(map, prefix + "UpdatedSlotValues.", this.UpdatedSlotValues);
            this.SetParamArrayObj(map, prefix + "RunNodes.", this.RunNodes);
            this.SetParamArraySimple(map, prefix + "Purposes.", this.Purposes);
        }
    }
}

