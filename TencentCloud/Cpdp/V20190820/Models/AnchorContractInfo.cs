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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnchorContractInfo : AbstractModel
    {
        
        /// <summary>
        /// 主播ID
        /// </summary>
        [JsonProperty("AnchorId")]
        public string AnchorId{ get; set; }

        /// <summary>
        /// 主播名称
        /// </summary>
        [JsonProperty("AnchorName")]
        public string AnchorName{ get; set; }

        /// <summary>
        /// 代理商ID
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// 代理商名称
        /// </summary>
        [JsonProperty("AgentName")]
        public string AgentName{ get; set; }

        /// <summary>
        /// 主播身份证号
        /// </summary>
        [JsonProperty("IdNo")]
        public string IdNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnchorId", this.AnchorId);
            this.SetParamSimple(map, prefix + "AnchorName", this.AnchorName);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "AgentName", this.AgentName);
            this.SetParamSimple(map, prefix + "IdNo", this.IdNo);
        }
    }
}

