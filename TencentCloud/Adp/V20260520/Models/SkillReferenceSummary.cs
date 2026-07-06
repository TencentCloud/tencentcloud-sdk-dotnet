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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillReferenceSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>关联ID</p>
        /// </summary>
        [JsonProperty("ReferenceId")]
        public string ReferenceId{ get; set; }

        /// <summary>
        /// <p>关联名称</p>
        /// </summary>
        [JsonProperty("ReferenceName")]
        public string ReferenceName{ get; set; }

        /// <summary>
        /// <p>关联类型</p><p>枚举值:<br>| uint | 描述 |<br>| --- | --- |<br>| 0 | 占位 |<br>| 1 | ClawPro |<br>| 2 | agent |</p>
        /// </summary>
        [JsonProperty("ReferenceType")]
        public long? ReferenceType{ get; set; }

        /// <summary>
        /// <p>空间ID</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>空间名称</p>
        /// </summary>
        [JsonProperty("SpaceName")]
        public string SpaceName{ get; set; }

        /// <summary>
        /// <p>Reference实例拥有者</p>
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReferenceId", this.ReferenceId);
            this.SetParamSimple(map, prefix + "ReferenceName", this.ReferenceName);
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "SpaceName", this.SpaceName);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
        }
    }
}

