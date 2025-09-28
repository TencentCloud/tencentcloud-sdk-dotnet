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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutonomyUserProfileInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否开启自治。枚举值：true，false。
        /// 其中：
        /// true - 开启
        /// false - 关闭
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 用户Uin。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 内存上限。
        /// </summary>
        [JsonProperty("MemoryUpperLimit")]
        public long? MemoryUpperLimit{ get; set; }

        /// <summary>
        /// 指标阈值规则。
        /// </summary>
        [JsonProperty("ThresholdRule")]
        public MetricThreshold ThresholdRule{ get; set; }

        /// <summary>
        /// 自治功能类型。
        /// </summary>
        [JsonProperty("EnabledItems")]
        public string[] EnabledItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "MemoryUpperLimit", this.MemoryUpperLimit);
            this.SetParamObj(map, prefix + "ThresholdRule.", this.ThresholdRule);
            this.SetParamArraySimple(map, prefix + "EnabledItems.", this.EnabledItems);
        }
    }
}

