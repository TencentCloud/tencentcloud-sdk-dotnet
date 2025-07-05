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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MaxAge : AbstractModel
    {
        
        /// <summary>
        /// 是否遵循源站，取值有：
        /// <li>on：遵循源站，忽略MaxAge 时间设置；</li>
        /// <li>off：不遵循源站，使用MaxAge 时间设置。</li>
        /// </summary>
        [JsonProperty("FollowOrigin")]
        public string FollowOrigin{ get; set; }

        /// <summary>
        /// MaxAge 时间设置，单位秒，最大365天。
        /// 注意：时间为0，即不缓存。
        /// </summary>
        [JsonProperty("MaxAgeTime")]
        public long? MaxAgeTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FollowOrigin", this.FollowOrigin);
            this.SetParamSimple(map, prefix + "MaxAgeTime", this.MaxAgeTime);
        }
    }
}

