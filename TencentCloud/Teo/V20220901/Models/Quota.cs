/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Quota : AbstractModel
    {
        
        /// <summary>
        /// 单次批量提交配额上限。
        /// </summary>
        [JsonProperty("Batch")]
        public long? Batch{ get; set; }

        /// <summary>
        /// 每日提交配额上限。
        /// </summary>
        [JsonProperty("Daily")]
        public long? Daily{ get; set; }

        /// <summary>
        /// 每日剩余的可提交配额。
        /// </summary>
        [JsonProperty("DailyAvailable")]
        public long? DailyAvailable{ get; set; }

        /// <summary>
        /// 刷新预热缓存类型，取值有：
        /// <li> purge_prefix：按前缀刷新；</li>
        /// <li> purge_url：按URL刷新；</li>
        /// <li> purge_host：按Hostname刷新；</li>
        /// <li> purge_all：刷新全部缓存内容；</li>
        /// <li> purge_cache_tag：按CacheTag刷新；</li><li> prefetch_url：按URL预热。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Batch", this.Batch);
            this.SetParamSimple(map, prefix + "Daily", this.Daily);
            this.SetParamSimple(map, prefix + "DailyAvailable", this.DailyAvailable);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

