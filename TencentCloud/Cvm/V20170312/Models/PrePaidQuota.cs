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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrePaidQuota : AbstractModel
    {
        
        /// <summary>
        /// 当月已使用配额
        /// </summary>
        [JsonProperty("UsedQuota")]
        public ulong? UsedQuota{ get; set; }

        /// <summary>
        /// 单次购买最大数量
        /// </summary>
        [JsonProperty("OnceQuota")]
        public ulong? OnceQuota{ get; set; }

        /// <summary>
        /// 剩余配额
        /// </summary>
        [JsonProperty("RemainingQuota")]
        public ulong? RemainingQuota{ get; set; }

        /// <summary>
        /// 总配额
        /// </summary>
        [JsonProperty("TotalQuota")]
        public ulong? TotalQuota{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UsedQuota", this.UsedQuota);
            this.SetParamSimple(map, prefix + "OnceQuota", this.OnceQuota);
            this.SetParamSimple(map, prefix + "RemainingQuota", this.RemainingQuota);
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
        }
    }
}

