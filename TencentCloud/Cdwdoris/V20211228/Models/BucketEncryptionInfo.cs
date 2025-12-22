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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BucketEncryptionInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否已加密
        /// </summary>
        [JsonProperty("IsEncrypted")]
        public bool? IsEncrypted{ get; set; }

        /// <summary>
        /// 加密类型：SSE-COS/SSE-KMS/disabled
        /// </summary>
        [JsonProperty("EncryptionType")]
        public string EncryptionType{ get; set; }

        /// <summary>
        /// 最后操作类型：enable/disable
        /// </summary>
        [JsonProperty("LastOperation")]
        public string LastOperation{ get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsEncrypted", this.IsEncrypted);
            this.SetParamSimple(map, prefix + "EncryptionType", this.EncryptionType);
            this.SetParamSimple(map, prefix + "LastOperation", this.LastOperation);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
        }
    }
}

