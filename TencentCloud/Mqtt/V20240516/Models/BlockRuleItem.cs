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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BlockRuleItem : AbstractModel
    {
        
        /// <summary>
        /// <p>封禁策略名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>封禁策略类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>备注信息</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>包含规则</p>
        /// </summary>
        [JsonProperty("Include")]
        public string Include{ get; set; }

        /// <summary>
        /// <p>排除规则</p>
        /// </summary>
        [JsonProperty("Excludes")]
        public string[] Excludes{ get; set; }

        /// <summary>
        /// <p>过期时间，毫秒级时间戳 。</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// <p>修改时间，毫秒级时间戳 。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// <p>创建时间，毫秒级时间戳 。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Include", this.Include);
            this.SetParamArraySimple(map, prefix + "Excludes.", this.Excludes);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

