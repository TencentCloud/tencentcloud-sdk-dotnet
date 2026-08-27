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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HTTPServiceCacheParams : AbstractModel
    {
        
        /// <summary>
        /// <p>遵循源站</p>
        /// </summary>
        [JsonProperty("FollowOrigin")]
        public bool? FollowOrigin{ get; set; }

        /// <summary>
        /// <p>不缓存</p>
        /// </summary>
        [JsonProperty("NoCache")]
        public bool? NoCache{ get; set; }

        /// <summary>
        /// <p>自定义缓存时间（秒）</p><p>取值范围：[0, 31536000]</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("CacheTime")]
        public ulong? CacheTime{ get; set; }

        /// <summary>
        /// <p>浏览器缓存秒数（对应 max-age）</p><p>取值范围：[0, 31536000]</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("MaxAgeTime")]
        public ulong? MaxAgeTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FollowOrigin", this.FollowOrigin);
            this.SetParamSimple(map, prefix + "NoCache", this.NoCache);
            this.SetParamSimple(map, prefix + "CacheTime", this.CacheTime);
            this.SetParamSimple(map, prefix + "MaxAgeTime", this.MaxAgeTime);
        }
    }
}

