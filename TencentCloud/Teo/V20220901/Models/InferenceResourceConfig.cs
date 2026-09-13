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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceResourceConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>扩容缩容的方式。取值有：<li>Auto：根据请求量自动调整实例数量；</li><li>Manual：人工设置固定的实例数量。</li></p>
        /// </summary>
        [JsonProperty("ScalingMode")]
        public string ScalingMode{ get; set; }

        /// <summary>
        /// <p>硬件规格标识。已废弃，请参考使用 <code>HardwareSpecId</code>。</p>
        /// </summary>
        [JsonProperty("HardwareSpec")]
        [System.Obsolete]
        public string HardwareSpec{ get; set; }

        /// <summary>
        /// <p>硬件规格唯一标识 ID，可通过 <code>DescribeInferenceHardwareSpecifications</code> 接口获取当前站点支持的硬件规格。</p><p>系统默认按照所选 <code>HardwareSpecId</code> 对应的硬件规格配置推理服务所需资源；如需调整，可通过 <code>HardwareConfig</code> 自定义硬件资源配置。</p>
        /// </summary>
        [JsonProperty("HardwareSpecId")]
        public string HardwareSpecId{ get; set; }

        /// <summary>
        /// <p>推理服务硬件配置。</p><p>作为入参时，若未填充则按照所选 <code>HardwareSpecId</code> 规格的默认值配置硬件资源；若填充则优先按照填写值进行配置。</p>
        /// </summary>
        [JsonProperty("HardwareConfig")]
        public InferenceHardwareConfig HardwareConfig{ get; set; }

        /// <summary>
        /// <p>推理服务自动伸缩配置。当 ScalingMode 为 Auto 时必填。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoScalingConfig")]
        public InferenceAutoScalingConfig AutoScalingConfig{ get; set; }

        /// <summary>
        /// <p>推理服务人工设置实例配置。当 ScalingMode 为 Manual 时必填。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManualInstanceConfig")]
        public InferenceManualInstanceConfig ManualInstanceConfig{ get; set; }

        /// <summary>
        /// <p>单实例的并发数。默认值为 1。</p>
        /// </summary>
        [JsonProperty("Concurrency")]
        public long? Concurrency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScalingMode", this.ScalingMode);
            this.SetParamSimple(map, prefix + "HardwareSpec", this.HardwareSpec);
            this.SetParamSimple(map, prefix + "HardwareSpecId", this.HardwareSpecId);
            this.SetParamObj(map, prefix + "HardwareConfig.", this.HardwareConfig);
            this.SetParamObj(map, prefix + "AutoScalingConfig.", this.AutoScalingConfig);
            this.SetParamObj(map, prefix + "ManualInstanceConfig.", this.ManualInstanceConfig);
            this.SetParamSimple(map, prefix + "Concurrency", this.Concurrency);
        }
    }
}

