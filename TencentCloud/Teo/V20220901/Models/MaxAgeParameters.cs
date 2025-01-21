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

    public class MaxAgeParameters : AbstractModel
    {
        
        /// <summary>
        /// 遵循源站 Cache-Control 开关，取值有：
        /// <li>on：遵循源站，忽略 CacheTime 时间设置；</li>
        /// <li>off：不遵循源站，使用 CacheTime 时间设置。</li>
        /// </summary>
        [JsonProperty("FollowOrigin")]
        public string FollowOrigin{ get; set; }

        /// <summary>
        /// 自定义缓存时间数值，单位为秒，取值：0～315360000。<br>注意：当 FollowOrigin 为 off 时，表示不遵循源站，使用 CacheTime 设置缓存时间，否则此字段不生效。
        /// </summary>
        [JsonProperty("CacheTime")]
        public long? CacheTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FollowOrigin", this.FollowOrigin);
            this.SetParamSimple(map, prefix + "CacheTime", this.CacheTime);
        }
    }
}

