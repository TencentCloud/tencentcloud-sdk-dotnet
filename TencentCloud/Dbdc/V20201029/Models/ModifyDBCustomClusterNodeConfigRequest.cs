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

namespace TencentCloud.Dbdc.V20201029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBCustomClusterNodeConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>目标集群 ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>要修改的节点 ID 列表</p><p>入参限制：数量范围 1~50 个</p>
        /// </summary>
        [JsonProperty("NodeIds")]
        public string[] NodeIds{ get; set; }

        /// <summary>
        /// <p>新增或覆盖的集群 Label</p><p>入参限制：- 单次 ≤ 20 对；合并后节点总量不超过 20</p><ul><li>Key 格式对齐 K8s 原生（两段式，prefix DNS 子域 ≤ 253 字符，name ≤ 63 字符）</li><li>Value ≤ 63 字符，可为空</li><li>不可操作系统保留前缀</li></ul>
        /// </summary>
        [JsonProperty("UpsertLabels")]
        public Label[] UpsertLabels{ get; set; }

        /// <summary>
        /// <p>要删除的 Label key 列表，按 key 精确匹配，key 不存在时幂等放行。</p><p>入参限制：- Key 格式对齐 K8s 原生（两段式，prefix DNS 子域 ≤ 253 字符，name ≤ 63 字符）</p><ul><li>Value ≤ 63 字符，可为空</li><li>不可操作系统保留前缀</li></ul>
        /// </summary>
        [JsonProperty("DeleteLabelKeys")]
        public string[] DeleteLabelKeys{ get; set; }

        /// <summary>
        /// <p>新增或覆盖的 Taint。</p><p>入参限制：- 单次 ≤ 5 对；合并后节点总量不超过 5。</p><ul><li>唯一性键为 (Key, Effect)，匹配到已有 (Key, Effect) 时覆盖 Value，否则新增</li><li>Effect 合法值：NoSchedule / PreferNoSchedule / NoExecute</li><li>同一 Key 允许多个不同 Effect 的 Taint 并存</li></ul>
        /// </summary>
        [JsonProperty("UpsertTaints")]
        public Taint[] UpsertTaints{ get; set; }

        /// <summary>
        /// <p>要删除的 Taint 过滤器列表</p><p>入参限制：- 唯一性键为 (Key, Effect)，匹配到已有 (Key, Effect) 时覆盖 Value，否则新增</p><ul><li>Effect 合法值：NoSchedule / PreferNoSchedule / NoExecute</li><li>同一 Key 允许多个不同 Effect 的 Taint 并存</li></ul>
        /// </summary>
        [JsonProperty("DeleteTaints")]
        public Taint[] DeleteTaints{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "NodeIds.", this.NodeIds);
            this.SetParamArrayObj(map, prefix + "UpsertLabels.", this.UpsertLabels);
            this.SetParamArraySimple(map, prefix + "DeleteLabelKeys.", this.DeleteLabelKeys);
            this.SetParamArrayObj(map, prefix + "UpsertTaints.", this.UpsertTaints);
            this.SetParamArrayObj(map, prefix + "DeleteTaints.", this.DeleteTaints);
        }
    }
}

