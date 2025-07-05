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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PackageBuyInfo : AbstractModel
    {
        
        /// <summary>
        /// 套餐包Id
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 套餐包类型，0-外呼套餐包|1-400呼入套餐包
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 套餐包总量
        /// </summary>
        [JsonProperty("CapacitySize")]
        public long? CapacitySize{ get; set; }

        /// <summary>
        /// 套餐包剩余量
        /// </summary>
        [JsonProperty("CapacityRemain")]
        public long? CapacityRemain{ get; set; }

        /// <summary>
        /// 购买时间戳
        /// </summary>
        [JsonProperty("BuyTime")]
        public long? BuyTime{ get; set; }

        /// <summary>
        /// 截止时间戳
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CapacitySize", this.CapacitySize);
            this.SetParamSimple(map, prefix + "CapacityRemain", this.CapacityRemain);
            this.SetParamSimple(map, prefix + "BuyTime", this.BuyTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

