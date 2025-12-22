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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricConfigLabel : AbstractModel
    {
        
        /// <summary>
        /// 元数据。
        /// 支持
        /// - `namespace`
        /// - `pod_name`
        /// - `pod_ip`
        /// - `pod_uid`
        /// - `container_name`
        /// - `container_id`
        /// - `image_name`
        /// - `cluster_id`
        /// - `node_id`
        /// - `node_ip`
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metadata")]
        public string[] Metadata{ get; set; }

        /// <summary>
        /// 元数据Pod Label信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Label")]
        public AppointLabel Label{ get; set; }

        /// <summary>
        /// 自定义label信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomLabels")]
        public CustomLabel[] CustomLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Metadata.", this.Metadata);
            this.SetParamObj(map, prefix + "Label.", this.Label);
            this.SetParamArrayObj(map, prefix + "CustomLabels.", this.CustomLabels);
        }
    }
}

