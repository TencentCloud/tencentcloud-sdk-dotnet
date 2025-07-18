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

    public class ServerlessIndexOptionsField : AbstractModel
    {
        
        /// <summary>
        /// 过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireMaxAge")]
        public string ExpireMaxAge{ get; set; }

        /// <summary>
        /// 时间分区字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimestampField")]
        public string TimestampField{ get; set; }

        /// <summary>
        /// 标准存储时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SinkCycleAge")]
        public string SinkCycleAge{ get; set; }

        /// <summary>
        /// 标准存储时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StandardStorageAge")]
        public string StandardStorageAge{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpireMaxAge", this.ExpireMaxAge);
            this.SetParamSimple(map, prefix + "TimestampField", this.TimestampField);
            this.SetParamSimple(map, prefix + "SinkCycleAge", this.SinkCycleAge);
            this.SetParamSimple(map, prefix + "StandardStorageAge", this.StandardStorageAge);
        }
    }
}

