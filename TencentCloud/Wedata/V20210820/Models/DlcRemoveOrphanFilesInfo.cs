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

    public class DlcRemoveOrphanFilesInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否启用移除孤立文件治理项：enable、none
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoveOrphanFilesEnable")]
        public string RemoveOrphanFilesEnable{ get; set; }

        /// <summary>
        /// 用于运行移除孤立文件治理项的引擎名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// 移除指定天前的孤立文件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeforeDays")]
        public ulong? BeforeDays{ get; set; }

        /// <summary>
        /// 移除孤立文件的并行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxConcurrentDeletes")]
        public ulong? MaxConcurrentDeletes{ get; set; }

        /// <summary>
        /// 移除孤立文件治理运行周期，单位为分钟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntervalMin")]
        public ulong? IntervalMin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RemoveOrphanFilesEnable", this.RemoveOrphanFilesEnable);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "BeforeDays", this.BeforeDays);
            this.SetParamSimple(map, prefix + "MaxConcurrentDeletes", this.MaxConcurrentDeletes);
            this.SetParamSimple(map, prefix + "IntervalMin", this.IntervalMin);
        }
    }
}

