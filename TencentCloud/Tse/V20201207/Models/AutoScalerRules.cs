/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScalerRules : AbstractModel
    {
        
        /// <summary>
        /// 稳定窗口时间，扩容时默认0，缩容时默认300
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StabilizationWindowSeconds")]
        public long? StabilizationWindowSeconds{ get; set; }

        /// <summary>
        /// 选择策略依据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelectPolicy")]
        public string SelectPolicy{ get; set; }

        /// <summary>
        /// 扩缩容策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Policies")]
        public AutoScalerPolicy[] Policies{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StabilizationWindowSeconds", this.StabilizationWindowSeconds);
            this.SetParamSimple(map, prefix + "SelectPolicy", this.SelectPolicy);
            this.SetParamArrayObj(map, prefix + "Policies.", this.Policies);
        }
    }
}

