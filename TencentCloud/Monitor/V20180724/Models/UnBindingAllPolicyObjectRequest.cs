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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnBindingAllPolicyObjectRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>固定值，为&quot;monitor&quot;</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>策略组id，如传入 PolicyId 则该字段被忽略可传入任意值如 0</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// <p>告警策略ID，使用此字段时 GroupId 会被忽略</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// <p>事件配置的告警</p>
        /// </summary>
        [JsonProperty("EbSubject")]
        public string EbSubject{ get; set; }

        /// <summary>
        /// <p>是否配置了事件告警</p>
        /// </summary>
        [JsonProperty("EbEventFlag")]
        public long? EbEventFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "EbSubject", this.EbSubject);
            this.SetParamSimple(map, prefix + "EbEventFlag", this.EbEventFlag);
        }
    }
}

