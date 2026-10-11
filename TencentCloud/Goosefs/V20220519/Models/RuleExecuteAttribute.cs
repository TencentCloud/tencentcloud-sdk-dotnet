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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleExecuteAttribute : AbstractModel
    {
        
        /// <summary>
        /// <p>执行id</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>开始执行时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>执行结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>执行状态</p><p>枚举值：</p><ul><li>0： 等待中</li><li>1： 执行中</li><li>2： 已完成</li><li>3： 已跳过</li></ul><p>默认值：0</p><p>已跳过是指任务排队超过了任务的等待时间会自动跳过</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>存储量</p><p>单位：GB</p><p>默认值：0</p><p>不足1G按照1G 统计</p>
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }

        /// <summary>
        /// <p>文件数</p>
        /// </summary>
        [JsonProperty("FileCount")]
        public ulong? FileCount{ get; set; }

        /// <summary>
        /// <p>文件清单路径</p><p>参数格式：http://xxx/xxx/xx</p>
        /// </summary>
        [JsonProperty("ManifestUrl")]
        public string ManifestUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
            this.SetParamSimple(map, prefix + "FileCount", this.FileCount);
            this.SetParamSimple(map, prefix + "ManifestUrl", this.ManifestUrl);
        }
    }
}

