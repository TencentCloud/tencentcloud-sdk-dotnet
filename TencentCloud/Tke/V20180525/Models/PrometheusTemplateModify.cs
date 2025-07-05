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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusTemplateModify : AbstractModel
    {
        
        /// <summary>
        /// 修改名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 修改描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// 修改内容，只有当模板类型是Alert时生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlertRules")]
        public PrometheusAlertRule[] AlertRules{ get; set; }

        /// <summary>
        /// 当Level为instance时有效，
        /// 模板中的聚合规则列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordRules")]
        public PrometheusConfigItem[] RecordRules{ get; set; }

        /// <summary>
        /// 当Level为cluster时有效，
        /// 模板中的ServiceMonitor规则列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceMonitors")]
        public PrometheusConfigItem[] ServiceMonitors{ get; set; }

        /// <summary>
        /// 当Level为cluster时有效，
        /// 模板中的PodMonitors规则列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodMonitors")]
        public PrometheusConfigItem[] PodMonitors{ get; set; }

        /// <summary>
        /// 当Level为cluster时有效，
        /// 模板中的RawJobs规则列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RawJobs")]
        public PrometheusConfigItem[] RawJobs{ get; set; }

        /// <summary>
        /// 修改内容，只有当模板类型是Alert时生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlertDetailRules")]
        public PrometheusAlertRuleDetail[] AlertDetailRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamArrayObj(map, prefix + "AlertRules.", this.AlertRules);
            this.SetParamArrayObj(map, prefix + "RecordRules.", this.RecordRules);
            this.SetParamArrayObj(map, prefix + "ServiceMonitors.", this.ServiceMonitors);
            this.SetParamArrayObj(map, prefix + "PodMonitors.", this.PodMonitors);
            this.SetParamArrayObj(map, prefix + "RawJobs.", this.RawJobs);
            this.SetParamArrayObj(map, prefix + "AlertDetailRules.", this.AlertDetailRules);
        }
    }
}

