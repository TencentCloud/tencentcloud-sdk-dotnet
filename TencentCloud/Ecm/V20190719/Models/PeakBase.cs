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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PeakBase : AbstractModel
    {
        
        /// <summary>
        /// CPU峰值
        /// </summary>
        [JsonProperty("PeakCpuNum")]
        public long? PeakCpuNum{ get; set; }

        /// <summary>
        /// 内存峰值
        /// </summary>
        [JsonProperty("PeakMemoryNum")]
        public long? PeakMemoryNum{ get; set; }

        /// <summary>
        /// 硬盘峰值
        /// </summary>
        [JsonProperty("PeakStorageNum")]
        public long? PeakStorageNum{ get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [JsonProperty("RecordTime")]
        public string RecordTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PeakCpuNum", this.PeakCpuNum);
            this.SetParamSimple(map, prefix + "PeakMemoryNum", this.PeakMemoryNum);
            this.SetParamSimple(map, prefix + "PeakStorageNum", this.PeakStorageNum);
            this.SetParamSimple(map, prefix + "RecordTime", this.RecordTime);
        }
    }
}

