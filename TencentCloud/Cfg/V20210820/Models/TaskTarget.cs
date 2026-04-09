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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskTarget : AbstractModel
    {
        
        /// <summary>
        /// <p>目标标签ID</p>
        /// </summary>
        [JsonProperty("TargetId")]
        public long? TargetId{ get; set; }

        /// <summary>
        /// <p>目标描述</p>
        /// </summary>
        [JsonProperty("TargetDesc")]
        public string TargetDesc{ get; set; }

        /// <summary>
        /// <p>1:演练场景<br>2:演练目标</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>1:平台 2:用户个人</p>
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// <p>目标标签是否已被删除</p><p>枚举值：</p><ul><li>0： 未删除</li><li>1： 已删除</li></ul>
        /// </summary>
        [JsonProperty("TargetStatus")]
        public long? TargetStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
            this.SetParamSimple(map, prefix + "TargetDesc", this.TargetDesc);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "TargetStatus", this.TargetStatus);
        }
    }
}

