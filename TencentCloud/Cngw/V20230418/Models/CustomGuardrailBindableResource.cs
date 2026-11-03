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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomGuardrailBindableResource : AbstractModel
    {
        
        /// <summary>
        /// <p>业务资源类型</p>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>业务资源 ID</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>业务资源名称</p>
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// <p>业务资源访问路径</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>数据面解析协议</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>该业务资源对应的全部 Kong Route ID，仅用于关联/排查；创建 Scope.Resources 时仍填业务 ResourceId。</p>
        /// </summary>
        [JsonProperty("RouteIds")]
        public string[] RouteIds{ get; set; }

        /// <summary>
        /// <p>对应任一 Route 是否被其他自定义护栏策略占用；查询时传 PolicyId 可排除自身占用。</p>
        /// </summary>
        [JsonProperty("Occupied")]
        public bool? Occupied{ get; set; }

        /// <summary>
        /// <p>占用策略的可读名称及 ID，格式为 策略名称 (策略ID)，多个以逗号分隔；名称不可用时回退 ID，不应按此展示字段解析策略主键。</p>
        /// </summary>
        [JsonProperty("OccupiedBy")]
        public string OccupiedBy{ get; set; }

        /// <summary>
        /// <p>资源当前是否可解析为受支持的绑定目标；与 Occupied 独立，选择时同时检查 Supported=true 且 Occupied=false。</p>
        /// </summary>
        [JsonProperty("Supported")]
        public bool? Supported{ get; set; }

        /// <summary>
        /// <p>不支持绑定的原因</p>
        /// </summary>
        [JsonProperty("UnsupportedReason")]
        public string UnsupportedReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArraySimple(map, prefix + "RouteIds.", this.RouteIds);
            this.SetParamSimple(map, prefix + "Occupied", this.Occupied);
            this.SetParamSimple(map, prefix + "OccupiedBy", this.OccupiedBy);
            this.SetParamSimple(map, prefix + "Supported", this.Supported);
            this.SetParamSimple(map, prefix + "UnsupportedReason", this.UnsupportedReason);
        }
    }
}

