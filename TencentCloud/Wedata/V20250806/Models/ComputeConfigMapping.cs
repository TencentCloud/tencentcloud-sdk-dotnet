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

    public class ComputeConfigMapping : AbstractModel
    {
        
        /// <summary>
        /// <p>任务类型ID</p><p>枚举值：</p><ul><li>32： DLC_SQL</li><li>46： DLC_SPARK</li><li>50： DLC_PYSPARK</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public long? TaskTypeId{ get; set; }

        /// <summary>
        /// <p>存算配置项。当前支持：COMPUTE_ENGINE、DLC_ENGINE_RESOURCE_GROUP</p><p>枚举值：</p><ul><li>COMPUTE_ENGINE： DLC 标准计算引擎</li><li>DLC_ENGINE_RESOURCE_GROUP：  DLC 标准引擎资源组</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComputeConfigItem")]
        public string ComputeConfigItem{ get; set; }

        /// <summary>
        /// <p>指定任务列表，非空时表示任务级覆盖，当前仅支持 DLC_SQL</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// <p>ComputeConfigItem=COMPUTE_ENGINE 时表示原引擎名；ComputeConfigItem=DLC_ENGINE_RESOURCE_GROUP 时表示原 DLC 标准引擎资源组名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceValue")]
        public string SourceValue{ get; set; }

        /// <summary>
        /// <p>ComputeConfigItem=COMPUTE_ENGINE 时表示目标引擎名；ComputeConfigItem=DLC_ENGINE_RESOURCE_GROUP 时表示目标 DLC 标准引擎资源组名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetValue")]
        public string TargetValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "ComputeConfigItem", this.ComputeConfigItem);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamSimple(map, prefix + "SourceValue", this.SourceValue);
            this.SetParamSimple(map, prefix + "TargetValue", this.TargetValue);
        }
    }
}

