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

    public class RedisGlobalKeyInfo : AbstractModel
    {
        
        /// <summary>
        /// 占用内存大小，单位Byte。
        /// </summary>
        [JsonProperty("Capacity")]
        public long? Capacity{ get; set; }

        /// <summary>
        /// Key个数。
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 剩余过期时间范围的结束时间，当小于0时，代表已过期时间，单位：小时。当RangeMin与RangeMax同时为空时，代表未设置过期时间。当RangeMax为空时，代表剩余过期时间大于等于RangeMin小时。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RangeMax")]
        public long? RangeMax{ get; set; }

        /// <summary>
        /// 剩余过期时间范围的起始时间，当小于0时，代表已过期时间，单位：小时。当RangeMin与RangeMax同时为空时，代表未设置过期时间。当RangeMin为空时，代表已过期。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RangeMin")]
        public long? RangeMin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "RangeMax", this.RangeMax);
            this.SetParamSimple(map, prefix + "RangeMin", this.RangeMin);
        }
    }
}

