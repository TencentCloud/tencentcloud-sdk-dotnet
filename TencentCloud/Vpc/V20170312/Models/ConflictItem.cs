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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConflictItem : AbstractModel
    {
        
        /// <summary>
        /// 冲突资源的ID。已废弃
        /// </summary>
        [JsonProperty("ConfilctId")]
        [System.Obsolete]
        public string ConfilctId{ get; set; }

        /// <summary>
        /// 冲突目的资源
        /// </summary>
        [JsonProperty("DestinationItem")]
        public string DestinationItem{ get; set; }

        /// <summary>
        /// 冲突资源的ID
        /// </summary>
        [JsonProperty("ConflictId")]
        public string ConflictId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfilctId", this.ConfilctId);
            this.SetParamSimple(map, prefix + "DestinationItem", this.DestinationItem);
            this.SetParamSimple(map, prefix + "ConflictId", this.ConflictId);
        }
    }
}

