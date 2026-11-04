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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileArrivalConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>运行命中的文件所在COS桶名</p><p>举例：dlc-sh-store-139153****</p><p>入参不填，如果填写则忽略；</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// <p>运行命中的文件所在COS地域</p><p>举例：ap-shanghai</p><p>入参不填，如果填写则忽略；</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// <p>文件存储路径</p><p>举例：cosn://dlc-sh-store-139153****/test/</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileStoragePath")]
        public string FileStoragePath{ get; set; }

        /// <summary>
        /// <p>文件名匹配规则</p><p>举例：</p><ul><li>空: 当前监听范围内的全部文件</li><li><code>*.csv: 任意以 .csv 结尾的文件名</code></li><li><code>orders_*.csv: orders_ 开头且以 .csv 结尾的文件名</code></li><li>orders.csv: 精确匹配 orders.csv</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileNamePattern")]
        public string FileNamePattern{ get; set; }

        /// <summary>
        /// <p>是否包含子目录</p><p>默认值：false</p><p>是否递归匹配子目录，默认 false</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Recursive")]
        public bool? Recursive{ get; set; }

        /// <summary>
        /// <p>最小触发间隔时间</p><p>参数格式：数字</p><p>默认值：300</p><p>单位：秒；默认 300秒（5 分钟）；60-86400 秒（1–1440 分钟）；两次触发之间的最小间隔。期间内到达的文件，需等待该时间结束后才会触发运行。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinTriggerIntervalTime")]
        public string MinTriggerIntervalTime{ get; set; }

        /// <summary>
        /// <p>批次等待时间</p><p>参数格式：数字</p><p>默认值：120</p><p>单位：秒；默认 120秒（2 分钟）；60-3600 秒（1–60 分钟）；文件到达后等待该时长才触发运行。若等待期间再次有新文件到达，则重新开始计时。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BatchWaitTime")]
        public string BatchWaitTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "FileStoragePath", this.FileStoragePath);
            this.SetParamSimple(map, prefix + "FileNamePattern", this.FileNamePattern);
            this.SetParamSimple(map, prefix + "Recursive", this.Recursive);
            this.SetParamSimple(map, prefix + "MinTriggerIntervalTime", this.MinTriggerIntervalTime);
            this.SetParamSimple(map, prefix + "BatchWaitTime", this.BatchWaitTime);
        }
    }
}

