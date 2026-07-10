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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySnapBackupCrossRegionConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>是否开启跨地域快照备份ON/OFF</p>
        /// </summary>
        [JsonProperty("CrossRegionsEnable")]
        public string CrossRegionsEnable{ get; set; }

        /// <summary>
        /// <p>快照备份所跨地域</p>
        /// </summary>
        [JsonProperty("CrossRegions")]
        public string[] CrossRegions{ get; set; }

        /// <summary>
        /// <p>跨地域备份保留时间</p><p>单位：天</p>
        /// </summary>
        [JsonProperty("CrossRegionSaveDays")]
        public long? CrossRegionSaveDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "CrossRegionsEnable", this.CrossRegionsEnable);
            this.SetParamArraySimple(map, prefix + "CrossRegions.", this.CrossRegions);
            this.SetParamSimple(map, prefix + "CrossRegionSaveDays", this.CrossRegionSaveDays);
        }
    }
}

