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

    public class EdgeKVPutRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 命名空间名称。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 键名，长度为 1-512 个字符，允许的字符为字母、数字、中划线和下划线。
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 键值。不能为空，最大支持 1 MB。支持存储字符串数据。
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// 键值对的过期时间，绝对时间，单位为秒，表示从 1970 年 1 月 1 日 00:00:00（UTC）起经过的秒数（即 Unix 时间戳）。取值必须大于等于当前时间 + 60，即过期时间距当前至少 60 秒。当 Expiration 与 ExpirationTTL 同时填写时，以 ExpirationTTL 为准；当两者均不填写时，键值对永不过期。
        /// </summary>
        [JsonProperty("Expiration")]
        public long? Expiration{ get; set; }

        /// <summary>
        /// 键值对的存活时长，相对时间，单位为秒，表示数据将在写入后经过指定秒数过期。取值范围：大于等于 60。当 Expiration 与 ExpirationTTL 同时填写时，以 ExpirationTTL 为准；当两者均不填写时，键值对永不过期。
        /// </summary>
        [JsonProperty("ExpirationTTL")]
        public long? ExpirationTTL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Expiration", this.Expiration);
            this.SetParamSimple(map, prefix + "ExpirationTTL", this.ExpirationTTL);
        }
    }
}

