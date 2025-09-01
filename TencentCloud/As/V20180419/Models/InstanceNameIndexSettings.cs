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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceNameIndexSettings : AbstractModel
    {
        
        /// <summary>
        /// 是否开启实例创建序号，默认不开启。取值范围：
        /// 
        /// **TRUE**：表示开启实例创建序号; **FALSE**：表示不开启实例创建序号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 初始序号。取值范围为 [0, 99999999]。
        /// 
        /// 当序号递增后超出取值范围时，扩容活动会失败。
        /// 
        /// 首次开启实例名称序号：默认值为 0。
        /// 非首次开启实例名称序号：若不指定该参数，沿用历史序号。
        /// 下调初始序号可能会造成伸缩组内实例名称序号重复。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeginIndex")]
        public long? BeginIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "BeginIndex", this.BeginIndex);
        }
    }
}

