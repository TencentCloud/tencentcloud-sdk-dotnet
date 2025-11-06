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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifecycleRule : AbstractModel
    {
        
        /// <summary>
        /// 数据转储后的存储类型。其中：InfrequentAccess：低频介质存储；ColdStorage：冷存储。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 数据转储文件类型。其中，BIG_FILE：超大文件；STD_FILE：普通文件；SMALL_FILE：小文件；ALL：所有文件。
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 数据转储行为。其中，Archive：沉降；Noarchive：不沉降。
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 数据转储触发时间。由“DEFAULT_ATIME_”与“数字”组成，单位为天。当 Action 为 Noarchive，请保持为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// 数据转储文件最大规格。其数值需使用“数字+单位”格式进行表示，单位支持K（KiB）、M（MiB）、G（GiB）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileMaxSize")]
        public string FileMaxSize{ get; set; }

        /// <summary>
        /// 数据转储文件最小规格。其数值需使用“数字+单位”格式进行表示，单位支持K（KiB）、M（MiB）、G（GiB）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileMinSize")]
        public string FileMinSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "FileMaxSize", this.FileMaxSize);
            this.SetParamSimple(map, prefix + "FileMinSize", this.FileMinSize);
        }
    }
}

