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
        /// <p>数据转储后的存储类型。其中：InfrequentAccess：低频介质存储；ColdStorage：冷存储。</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>数据转储文件类型。其中，BIG_FILE：超大文件；STD_FILE：普通文件；SMALL_FILE：小文件；ALL：所有文件。</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>数据转储行为。其中，Archive：沉降；Noarchive：不沉降。</p>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>数据转储触发时间。由“DEFAULT_ATIME_”与“数字”组成，单位为天。当 Action 为 Noarchive，请保持为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// <p>数据转储文件最大规格。其数值需使用“数字+单位”格式进行表示，单位支持K（KiB）、M（MiB）、G（GiB）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileMaxSize")]
        public string FileMaxSize{ get; set; }

        /// <summary>
        /// <p>数据转储文件最小规格。其数值需使用“数字+单位”格式进行表示，单位支持K（KiB）、M（MiB）、G（GiB）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileMinSize")]
        public string FileMinSize{ get; set; }

        /// <summary>
        /// <p>策略类型</p>
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// <p>阈值范围[10-90]</p>
        /// </summary>
        [JsonProperty("ExpireThreshold")]
        public ulong? ExpireThreshold{ get; set; }

        /// <summary>
        /// <p>阈值范围[10-90]</p>
        /// </summary>
        [JsonProperty("TargetThreshold")]
        public ulong? TargetThreshold{ get; set; }

        /// <summary>
        /// <p>当CFSTurbo内的文件和外置存储存在同名情况时，是否覆盖。</p><p>ture：覆盖</p><p>false：不覆盖（同时也不会释放热存数据）</p><p>为空时，默认为false</p>
        /// </summary>
        [JsonProperty("IsOverwrite")]
        public bool? IsOverwrite{ get; set; }

        /// <summary>
        /// <p>新建文件是否近实时同步至 S3。true：近实时同步（30 秒内）/ false：基于策略配置时间同步。默认 false。仅当 StorageType=ExternalStorage 时生效</p>
        /// </summary>
        [JsonProperty("IsCreateRealTimeSync")]
        public bool? IsCreateRealTimeSync{ get; set; }

        /// <summary>
        /// <p>修改文件是否近实时同步至 S3。true：近实时同步（30 秒内）/ false：基于策略配置时间同步。默认 false。仅当 StorageType=ExternalStorage 时生效。与 IsOverwrite 独立</p>
        /// </summary>
        [JsonProperty("IsModifyRealTimeSync")]
        public bool? IsModifyRealTimeSync{ get; set; }

        /// <summary>
        /// <p>删除文件是否同步至 S3。true：同步删除（30 秒内）/ false：不同步删除。默认 false。为 true 时要求目标 COS Bucket 已开启多版本。仅当 StorageType=ExternalStorage 时生效</p>
        /// </summary>
        [JsonProperty("IsSyncDelete")]
        public bool? IsSyncDelete{ get; set; }


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
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "ExpireThreshold", this.ExpireThreshold);
            this.SetParamSimple(map, prefix + "TargetThreshold", this.TargetThreshold);
            this.SetParamSimple(map, prefix + "IsOverwrite", this.IsOverwrite);
            this.SetParamSimple(map, prefix + "IsCreateRealTimeSync", this.IsCreateRealTimeSync);
            this.SetParamSimple(map, prefix + "IsModifyRealTimeSync", this.IsModifyRealTimeSync);
            this.SetParamSimple(map, prefix + "IsSyncDelete", this.IsSyncDelete);
        }
    }
}

