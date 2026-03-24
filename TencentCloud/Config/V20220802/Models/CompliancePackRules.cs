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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompliancePackRules : AbstractModel
    {
        
        /// <summary>
        /// <p>规则标识</p>
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// <p>规则编号信息</p>
        /// </summary>
        [JsonProperty("Control")]
        public Control[] Control{ get; set; }

        /// <summary>
        /// <p>资源类型</p>
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public string[] ResourceTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamArrayObj(map, prefix + "Control.", this.Control);
            this.SetParamArraySimple(map, prefix + "ResourceTypes.", this.ResourceTypes);
        }
    }
}

