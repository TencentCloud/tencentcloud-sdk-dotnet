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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricLabels : AbstractModel
    {
        
        /// <summary>
        /// <p>GPU 卡型简称，取值如 T4 / A10 / V100 / L20 / H20。来自 TKE GPU Exporter 暴露的 gpu_info.name，由查询层归一（name=&quot;Tesla T4&quot; → GpuType=&quot;T4&quot;）；未识别的卡型保留原始 name 值</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// <p>队列编码 code（多队列时序查询时，每个 series 携带所属队列 code，与 GpuType 组合区分曲线；展示别名见 QueueAlias）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>队列展示别名（多队列时序查询时每个 series 携带，前端图例展示用；队列不存在或 alias 为空时回落为队列 code）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueAlias")]
        public string QueueAlias{ get; set; }

        /// <summary>
        /// <p>计费项资源类型（CPU / HM_CPU）。Overview 路径的 CPU / 内存类指标按计费项资源类型拆分 series 时携带；时序路径当前不输出该字段（预留对齐 MetricLabels 定义）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "QueueAlias", this.QueueAlias);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
        }
    }
}

