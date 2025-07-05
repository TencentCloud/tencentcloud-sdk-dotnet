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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HLSConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// 单个 TS 文件时长，单位：秒，取值范围 5-30 秒。
        /// 
        /// 不填默认为 30 秒。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ItemDuration")]
        public long? ItemDuration{ get; set; }

        /// <summary>
        /// 录制周期，单位：秒，取值范围 10 分钟到  12 小时。
        /// 
        /// 不填默认为 10分钟（3600 秒）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// 续录等待时间，单位：秒。取值范围为60秒-1800秒。
        /// 不填默认为0（不启用续录）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContinueTimeout")]
        public long? ContinueTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemDuration", this.ItemDuration);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "ContinueTimeout", this.ContinueTimeout);
        }
    }
}

