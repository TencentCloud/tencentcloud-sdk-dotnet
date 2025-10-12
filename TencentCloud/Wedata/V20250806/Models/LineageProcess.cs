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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LineageProcess : AbstractModel
    {
        
        /// <summary>
        /// 原始唯一ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessId")]
        public string ProcessId{ get; set; }

        /// <summary>
        /// 任务类型
        ///     //调度任务
        ///     SCHEDULE_TASK,
        ///     //集成任务
        ///     INTEGRATION_TASK,
        ///     //第三方上报
        ///     THIRD_REPORT,
        ///     //数据建模
        ///     TABLE_MODEL,
        ///     //模型创建指标
        ///     MODEL_METRIC,
        ///     //原子指标创建衍生指标
        ///     METRIC_METRIC,
        ///     //数据服务
        ///     DATA_SERVICE
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessType")]
        public string ProcessType{ get; set; }

        /// <summary>
        /// WEDATA, THIRD;
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 任务子类型
        ///  SQL_TASK,
        ///     //集成实时任务血缘
        ///     INTEGRATED_STREAM,
        ///     //集成离线任务血缘
        ///     INTEGRATED_OFFLINE;
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessSubType")]
        public string ProcessSubType{ get; set; }

        /// <summary>
        /// 额外扩展参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessProperties")]
        public LineageProperty[] ProcessProperties{ get; set; }

        /// <summary>
        /// 血缘任务唯一节点ID
        /// </summary>
        [JsonProperty("LineageNodeId")]
        public string LineageNodeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProcessId", this.ProcessId);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "ProcessSubType", this.ProcessSubType);
            this.SetParamArrayObj(map, prefix + "ProcessProperties.", this.ProcessProperties);
            this.SetParamSimple(map, prefix + "LineageNodeId", this.LineageNodeId);
        }
    }
}

