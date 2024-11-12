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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostRiskLevelCount : AbstractModel
    {
        
        /// <summary>
        /// 主机ID
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// 主机名
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 严重个数
        /// </summary>
        [JsonProperty("SeriousCount")]
        public long? SeriousCount{ get; set; }

        /// <summary>
        /// 高危个数
        /// </summary>
        [JsonProperty("HighCount")]
        public long? HighCount{ get; set; }

        /// <summary>
        /// 中危个数
        /// </summary>
        [JsonProperty("MediumCount")]
        public long? MediumCount{ get; set; }

        /// <summary>
        /// 低危个数
        /// </summary>
        [JsonProperty("LowCount")]
        public long? LowCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "SeriousCount", this.SeriousCount);
            this.SetParamSimple(map, prefix + "HighCount", this.HighCount);
            this.SetParamSimple(map, prefix + "MediumCount", this.MediumCount);
            this.SetParamSimple(map, prefix + "LowCount", this.LowCount);
        }
    }
}

