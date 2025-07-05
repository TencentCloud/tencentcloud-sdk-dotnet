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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationBasicConfig : AbstractModel
    {
        
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 工作负载类型
        /// </summary>
        [JsonProperty("WorkflowKind")]
        public string WorkflowKind{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// Grid唯一Key
        /// </summary>
        [JsonProperty("GridUniqKey")]
        public string GridUniqKey{ get; set; }

        /// <summary>
        /// NodeSelector标签
        /// </summary>
        [JsonProperty("NodeSelector")]
        public Label[] NodeSelector{ get; set; }

        /// <summary>
        /// 实例数
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// 可用实例数
        /// </summary>
        [JsonProperty("AvailableReplicas")]
        public long? AvailableReplicas{ get; set; }

        /// <summary>
        /// 是否开启service环境变量注入pod
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableServiceLinks")]
        public bool? EnableServiceLinks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "WorkflowKind", this.WorkflowKind);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "GridUniqKey", this.GridUniqKey);
            this.SetParamArrayObj(map, prefix + "NodeSelector.", this.NodeSelector);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamSimple(map, prefix + "AvailableReplicas", this.AvailableReplicas);
            this.SetParamSimple(map, prefix + "EnableServiceLinks", this.EnableServiceLinks);
        }
    }
}

