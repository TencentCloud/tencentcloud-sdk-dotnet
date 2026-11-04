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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataSourceBrief : AbstractModel
    {
        
        /// <summary>
        /// <p>存储实例ID</p>
        /// </summary>
        [JsonProperty("StorageId")]
        public string StorageId{ get; set; }

        /// <summary>
        /// <p>存储实例名称</p>
        /// </summary>
        [JsonProperty("StorageName")]
        public string StorageName{ get; set; }

        /// <summary>
        /// <p>存储目录</p>
        /// </summary>
        [JsonProperty("WorkDir")]
        public string WorkDir{ get; set; }

        /// <summary>
        /// <p>数据源读写权限，RW/RO</p>
        /// </summary>
        [JsonProperty("Permission")]
        public string Permission{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageId", this.StorageId);
            this.SetParamSimple(map, prefix + "StorageName", this.StorageName);
            this.SetParamSimple(map, prefix + "WorkDir", this.WorkDir);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
        }
    }
}

