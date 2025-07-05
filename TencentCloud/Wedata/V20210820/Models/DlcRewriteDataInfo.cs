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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DlcRewriteDataInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否启用数据重排布治理项：enable（启动）、disable（不启用，默认）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RewriteDataEnable")]
        public string RewriteDataEnable{ get; set; }

        /// <summary>
        /// 用于运行数据重排布治理项的引擎名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// 重排布任务执行的文件个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinInputFiles")]
        public ulong? MinInputFiles{ get; set; }

        /// <summary>
        /// 数据重排布写后的数据文件大小，单位为字节
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetFileSizeBytes")]
        public ulong? TargetFileSizeBytes{ get; set; }

        /// <summary>
        /// 数据重排布治理运行周期，单位为分钟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntervalMin")]
        public ulong? IntervalMin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RewriteDataEnable", this.RewriteDataEnable);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "MinInputFiles", this.MinInputFiles);
            this.SetParamSimple(map, prefix + "TargetFileSizeBytes", this.TargetFileSizeBytes);
            this.SetParamSimple(map, prefix + "IntervalMin", this.IntervalMin);
        }
    }
}

