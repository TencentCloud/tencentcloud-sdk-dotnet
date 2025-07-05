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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MultiZoneSetting : AbstractModel
    {
        
        /// <summary>
        /// "master"、"standby"、"third-party"
        /// </summary>
        [JsonProperty("ZoneTag")]
        public string ZoneTag{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("VPCSettings")]
        public VPCSettings VPCSettings{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NewResourceSpec ResourceSpec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneTag", this.ZoneTag);
            this.SetParamObj(map, prefix + "VPCSettings.", this.VPCSettings);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
        }
    }
}

