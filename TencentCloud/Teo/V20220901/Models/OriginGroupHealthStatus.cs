/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginGroupHealthStatus : AbstractModel
    {
        
        /// <summary>
        /// 源站组 ID。
        /// </summary>
        [JsonProperty("OriginGroupID")]
        public string OriginGroupID{ get; set; }

        /// <summary>
        /// 源站组名。
        /// </summary>
        [JsonProperty("OriginGroupName")]
        public string OriginGroupName{ get; set; }

        /// <summary>
        /// 源站组类型，取值有：
        /// <li>HTTP：HTTP 专用型；</li>
        /// <li>GENERAL：通用型。</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 优先级。
        /// </summary>
        [JsonProperty("Priority")]
        public string Priority{ get; set; }

        /// <summary>
        /// 源站组里各源站的健康状态。
        /// </summary>
        [JsonProperty("OriginHealthStatus")]
        public OriginHealthStatus[] OriginHealthStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginGroupID", this.OriginGroupID);
            this.SetParamSimple(map, prefix + "OriginGroupName", this.OriginGroupName);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamArrayObj(map, prefix + "OriginHealthStatus.", this.OriginHealthStatus);
        }
    }
}

