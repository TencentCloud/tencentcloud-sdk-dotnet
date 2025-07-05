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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestartPolicy : AbstractModel
    {
        
        /// <summary>
        /// 重启策略名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 策略展示名称。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 策略描述。
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// 批量重启节点数可选范围。
        /// </summary>
        [JsonProperty("BatchSizeRange")]
        public long?[] BatchSizeRange{ get; set; }

        /// <summary>
        /// 是否是默认策略。
        /// </summary>
        [JsonProperty("IsDefault")]
        public string IsDefault{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamArraySimple(map, prefix + "BatchSizeRange.", this.BatchSizeRange);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
        }
    }
}

