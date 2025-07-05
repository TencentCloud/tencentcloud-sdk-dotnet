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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PresetItem : AbstractModel
    {
        
        /// <summary>
        /// 预置位ID
        /// </summary>
        [JsonProperty("PresetId")]
        public long? PresetId{ get; set; }

        /// <summary>
        /// 预置位名称
        /// </summary>
        [JsonProperty("PresetName")]
        public string PresetName{ get; set; }

        /// <summary>
        /// 预置位状态 0:未设置预置位 1:已设置预置位 2:已设置预置位&看守位
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 预置位启用时的自动归位时间
        /// </summary>
        [JsonProperty("ResetTime")]
        public long? ResetTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PresetId", this.PresetId);
            this.SetParamSimple(map, prefix + "PresetName", this.PresetName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ResetTime", this.ResetTime);
        }
    }
}

