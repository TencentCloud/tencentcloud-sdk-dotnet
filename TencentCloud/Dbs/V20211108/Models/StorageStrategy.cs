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

namespace TencentCloud.Dbs.V20211108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StorageStrategy : AbstractModel
    {
        
        /// <summary>
        /// 存储类型。目前仅支持 "system" - DBS 内置存储。默认值为 "system"。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 加密方式。可能的取值为：
        /// "UnEncrypted" - 非加密存储;
        /// "SSE-COS" - 内置加密存储;
        /// 当该参数用作入参时，默认值为 "UnEncrypted"。
        /// </summary>
        [JsonProperty("Encryption")]
        public string Encryption{ get; set; }

        /// <summary>
        /// 日志保留时间，单位为天。取值范围为[7, 3650]，默认值为 30。
        /// </summary>
        [JsonProperty("BackupRetentionPeriod")]
        public long? BackupRetentionPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
            this.SetParamSimple(map, prefix + "BackupRetentionPeriod", this.BackupRetentionPeriod);
        }
    }
}

