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

    public class FullBackupProgress : AbstractModel
    {
        
        /// <summary>
        /// 结构备份进度，取值范围为 0 - 100，单位：百分比。
        /// </summary>
        [JsonProperty("SchemaProgress")]
        public long? SchemaProgress{ get; set; }

        /// <summary>
        /// 数据备份进度，取值范围为 0 - 100，单位：百分比。
        /// </summary>
        [JsonProperty("DataProgress")]
        public long? DataProgress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SchemaProgress", this.SchemaProgress);
            this.SetParamSimple(map, prefix + "DataProgress", this.DataProgress);
        }
    }
}

