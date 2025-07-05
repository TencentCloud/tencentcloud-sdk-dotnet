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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExternalRedis : AbstractModel
    {
        
        /// <summary>
        /// redis ip
        /// </summary>
        [JsonProperty("RedisHost")]
        public string RedisHost{ get; set; }

        /// <summary>
        /// redis密码
        /// </summary>
        [JsonProperty("RedisPassword")]
        public string RedisPassword{ get; set; }

        /// <summary>
        /// redis端口
        /// </summary>
        [JsonProperty("RedisPort")]
        public long? RedisPort{ get; set; }

        /// <summary>
        /// 超时时间  ms
        /// </summary>
        [JsonProperty("RedisTimeout")]
        public long? RedisTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RedisHost", this.RedisHost);
            this.SetParamSimple(map, prefix + "RedisPassword", this.RedisPassword);
            this.SetParamSimple(map, prefix + "RedisPort", this.RedisPort);
            this.SetParamSimple(map, prefix + "RedisTimeout", this.RedisTimeout);
        }
    }
}

