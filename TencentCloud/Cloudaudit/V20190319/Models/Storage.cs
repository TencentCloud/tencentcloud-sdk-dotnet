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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Storage : AbstractModel
    {
        
        /// <summary>
        /// <p>存储类型（目前支持 cos、cls、ckafka）</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>存储所在地域</p>
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// <p>存储名称(cos：存储名称为用户自定义的存储桶名称，不包含&quot;-APPID&quot;，仅支持小写字母、数字以及中划线&quot;-&quot;的组合，不能超过50字符，且不支持中划线&quot;-&quot;开头或结尾； cls：存储名称为日志主题id，字符长度为1-50个字符； ckafka： ckafka实例ID/topic. 举例：ckafka-xxxxxx/tencent_test_audit_log)</p>
        /// </summary>
        [JsonProperty("StorageName")]
        public string StorageName{ get; set; }

        /// <summary>
        /// <p>存储目录前缀，cos日志文件前缀仅支持字母和数字的组合，3-40个字符</p>
        /// </summary>
        [JsonProperty("StoragePrefix")]
        public string StoragePrefix{ get; set; }

        /// <summary>
        /// <p>被指定存储用户ID</p>
        /// </summary>
        [JsonProperty("StorageAccountId")]
        public string StorageAccountId{ get; set; }

        /// <summary>
        /// <p>被指定存储用户appid</p>
        /// </summary>
        [JsonProperty("StorageAppId")]
        public string StorageAppId{ get; set; }

        /// <summary>
        /// <p>是否压缩。<br>1:压缩  2:不压缩</p>
        /// </summary>
        [JsonProperty("Compress")]
        public ulong? Compress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "StorageName", this.StorageName);
            this.SetParamSimple(map, prefix + "StoragePrefix", this.StoragePrefix);
            this.SetParamSimple(map, prefix + "StorageAccountId", this.StorageAccountId);
            this.SetParamSimple(map, prefix + "StorageAppId", this.StorageAppId);
            this.SetParamSimple(map, prefix + "Compress", this.Compress);
        }
    }
}

