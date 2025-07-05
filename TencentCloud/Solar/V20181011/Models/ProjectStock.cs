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

namespace TencentCloud.Solar.V20181011.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProjectStock : AbstractModel
    {
        
        /// <summary>
        /// 奖品id
        /// </summary>
        [JsonProperty("PrizeId")]
        public string PrizeId{ get; set; }

        /// <summary>
        /// 奖品批次
        /// </summary>
        [JsonProperty("PrizeBat")]
        public ulong? PrizeBat{ get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [JsonProperty("PrizeName")]
        public string PrizeName{ get; set; }

        /// <summary>
        /// 已分配奖品数量
        /// </summary>
        [JsonProperty("UsedStock")]
        public ulong? UsedStock{ get; set; }

        /// <summary>
        /// 该奖品剩余库存数量
        /// </summary>
        [JsonProperty("RemainStock")]
        public ulong? RemainStock{ get; set; }

        /// <summary>
        /// 奖品所在奖池index
        /// </summary>
        [JsonProperty("PoolIdx")]
        public ulong? PoolIdx{ get; set; }

        /// <summary>
        /// 奖品所在奖池名称
        /// </summary>
        [JsonProperty("PoolName")]
        public string PoolName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrizeId", this.PrizeId);
            this.SetParamSimple(map, prefix + "PrizeBat", this.PrizeBat);
            this.SetParamSimple(map, prefix + "PrizeName", this.PrizeName);
            this.SetParamSimple(map, prefix + "UsedStock", this.UsedStock);
            this.SetParamSimple(map, prefix + "RemainStock", this.RemainStock);
            this.SetParamSimple(map, prefix + "PoolIdx", this.PoolIdx);
            this.SetParamSimple(map, prefix + "PoolName", this.PoolName);
        }
    }
}

