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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeRunDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>节点运行信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeRun")]
        public NodeRun NodeRun{ get; set; }

        /// <summary>
        /// <p>节点运行内容</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeRunContent")]
        public NodeRunContent NodeRunContent{ get; set; }

        /// <summary>
        /// <p>节点运行过程</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeRunExecution")]
        public NodeRunExecution NodeRunExecution{ get; set; }

        /// <summary>
        /// <p>节点运行日志</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeRunLog")]
        public NodeRunLog NodeRunLog{ get; set; }

        /// <summary>
        /// <p>统计信息</p>
        /// </summary>
        [JsonProperty("StatisticList")]
        public Statistic[] StatisticList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "NodeRun.", this.NodeRun);
            this.SetParamObj(map, prefix + "NodeRunContent.", this.NodeRunContent);
            this.SetParamObj(map, prefix + "NodeRunExecution.", this.NodeRunExecution);
            this.SetParamObj(map, prefix + "NodeRunLog.", this.NodeRunLog);
            this.SetParamArrayObj(map, prefix + "StatisticList.", this.StatisticList);
        }
    }
}

