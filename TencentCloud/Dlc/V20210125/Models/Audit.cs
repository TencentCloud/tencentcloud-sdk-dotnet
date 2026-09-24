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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Audit : AbstractModel
    {
        
        /// <summary>
        /// <p>创建者</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>最后修改者</p>
        /// </summary>
        [JsonProperty("LastModifier")]
        public string LastModifier{ get; set; }

        /// <summary>
        /// <p>创建时间戳</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public ulong? CreatedAt{ get; set; }

        /// <summary>
        /// <p>最后修改时间戳</p>
        /// </summary>
        [JsonProperty("LastModifiedAt")]
        public ulong? LastModifiedAt{ get; set; }

        /// <summary>
        /// <p>最后修改时间（已废弃）</p><p>参数格式：2024-11-01 11:01:01</p>
        /// </summary>
        [JsonProperty("LastModifiedTime")]
        public string LastModifiedTime{ get; set; }

        /// <summary>
        /// <p>创建时间（已废弃）</p><p>参数格式：2024-11-01 11:01:01</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "LastModifier", this.LastModifier);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "LastModifiedAt", this.LastModifiedAt);
            this.SetParamSimple(map, prefix + "LastModifiedTime", this.LastModifiedTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

