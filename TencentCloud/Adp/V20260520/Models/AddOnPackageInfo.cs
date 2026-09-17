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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddOnPackageInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>增值包总量</p>
        /// </summary>
        [JsonProperty("AddOnTotal")]
        public float? AddOnTotal{ get; set; }

        /// <summary>
        /// <p>增值包用量</p>
        /// </summary>
        [JsonProperty("AddOnUsage")]
        public float? AddOnUsage{ get; set; }

        /// <summary>
        /// <p>专属并发总数</p>
        /// </summary>
        [JsonProperty("ExclusiveConcurrency")]
        public ulong? ExclusiveConcurrency{ get; set; }

        /// <summary>
        /// <p>资源包状态</p><p>枚举值：</p><ul><li>1： 可使</li><li>2： 已用完</li><li>3： 已过期</li></ul>
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public ulong? ResourceStatus{ get; set; }

        /// <summary>
        /// <p>专属并发状态</p><p>枚举值：</p><ul><li>1： 可使</li><li>3： 已过期</li></ul>
        /// </summary>
        [JsonProperty("ConcurrencyStatus")]
        public ulong? ConcurrencyStatus{ get; set; }

        /// <summary>
        /// <p>专属tpm</p>
        /// </summary>
        [JsonProperty("ExclusiveTpm")]
        public ulong? ExclusiveTpm{ get; set; }

        /// <summary>
        /// <p>专属tpm状态</p><p>枚举值：</p><ul><li>1： 可使</li><li>3： 已过期</li></ul>
        /// </summary>
        [JsonProperty("ExclusiveTpmStatus")]
        public ulong? ExclusiveTpmStatus{ get; set; }

        /// <summary>
        /// <p>专属计算单元</p>
        /// </summary>
        [JsonProperty("ExclusiveComputeUnit")]
        public ulong? ExclusiveComputeUnit{ get; set; }

        /// <summary>
        /// <p>专属计算单元状态</p><p>枚举值：</p><ul><li>1： 可使</li><li>3： 已过期</li><li>4： 已销毁</li><li>5： 已隔离</li><li>6： 未生效</li><li>7： 暂不可用（套餐包过期时）</li></ul>
        /// </summary>
        [JsonProperty("ExclusiveComputeUnitStatus")]
        public ulong? ExclusiveComputeUnitStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddOnTotal", this.AddOnTotal);
            this.SetParamSimple(map, prefix + "AddOnUsage", this.AddOnUsage);
            this.SetParamSimple(map, prefix + "ExclusiveConcurrency", this.ExclusiveConcurrency);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
            this.SetParamSimple(map, prefix + "ConcurrencyStatus", this.ConcurrencyStatus);
            this.SetParamSimple(map, prefix + "ExclusiveTpm", this.ExclusiveTpm);
            this.SetParamSimple(map, prefix + "ExclusiveTpmStatus", this.ExclusiveTpmStatus);
            this.SetParamSimple(map, prefix + "ExclusiveComputeUnit", this.ExclusiveComputeUnit);
            this.SetParamSimple(map, prefix + "ExclusiveComputeUnitStatus", this.ExclusiveComputeUnitStatus);
        }
    }
}

