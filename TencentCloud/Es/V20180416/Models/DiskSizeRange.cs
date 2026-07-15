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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskSizeRange : AbstractModel
    {
        
        /// <summary>
        /// 最小值
        /// </summary>
        [JsonProperty("Min")]
        public ulong? Min{ get; set; }

        /// <summary>
        /// 小刻度值
        /// </summary>
        [JsonProperty("Sml")]
        public ulong? Sml{ get; set; }

        /// <summary>
        /// 中刻度值
        /// </summary>
        [JsonProperty("Med")]
        public ulong? Med{ get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        [JsonProperty("Max")]
        public ulong? Max{ get; set; }

        /// <summary>
        /// 磁盘块数最小值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskCountMin")]
        public ulong? DiskCountMin{ get; set; }

        /// <summary>
        /// 磁盘块数最大值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskCountMax")]
        public ulong? DiskCountMax{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "Sml", this.Sml);
            this.SetParamSimple(map, prefix + "Med", this.Med);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "DiskCountMin", this.DiskCountMin);
            this.SetParamSimple(map, prefix + "DiskCountMax", this.DiskCountMax);
        }
    }
}

