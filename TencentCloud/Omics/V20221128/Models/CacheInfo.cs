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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CacheInfo : AbstractModel
    {
        
        /// <summary>
        /// 缓存清理时间(小时)。
        /// </summary>
        [JsonProperty("CacheClearDelay")]
        public ulong? CacheClearDelay{ get; set; }

        /// <summary>
        /// 缓存清理计划时间。
        /// </summary>
        [JsonProperty("CacheClearTime")]
        public string CacheClearTime{ get; set; }

        /// <summary>
        /// 缓存是否已被清理。
        /// </summary>
        [JsonProperty("CacheCleared")]
        public bool? CacheCleared{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CacheClearDelay", this.CacheClearDelay);
            this.SetParamSimple(map, prefix + "CacheClearTime", this.CacheClearTime);
            this.SetParamSimple(map, prefix + "CacheCleared", this.CacheCleared);
        }
    }
}

