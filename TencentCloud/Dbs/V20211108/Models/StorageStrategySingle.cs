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

namespace TencentCloud.Dbs.V20211108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StorageStrategySingle : AbstractModel
    {
        
        /// <summary>
        /// 存储策略类型。取值：
        /// - standard：标准存储
        /// - tiered：分级存储
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetentionType")]
        public string RetentionType{ get; set; }

        /// <summary>
        /// 备份保留天数，取值范围为 7 - 3650。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetentionPeriod")]
        public long? RetentionPeriod{ get; set; }

        /// <summary>
        /// 分级存储策略。RetentionType 为 tiered 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TieredStrategy")]
        public StorageTieredStrategy TieredStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RetentionType", this.RetentionType);
            this.SetParamSimple(map, prefix + "RetentionPeriod", this.RetentionPeriod);
            this.SetParamObj(map, prefix + "TieredStrategy.", this.TieredStrategy);
        }
    }
}

