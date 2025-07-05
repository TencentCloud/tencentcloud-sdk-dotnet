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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerlessDi : AbstractModel
    {
        
        /// <summary>
        /// 数据链路采集源类型，如cvm_collector、tke_collector
        /// </summary>
        [JsonProperty("DiSourceType")]
        public string DiSourceType{ get; set; }

        /// <summary>
        /// cvm数据源
        /// </summary>
        [JsonProperty("DiSourceCvm")]
        public DiSourceCvm DiSourceCvm{ get; set; }

        /// <summary>
        /// tke数据源
        /// </summary>
        [JsonProperty("DiSourceTke")]
        public DiSourceTke DiSourceTke{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiSourceType", this.DiSourceType);
            this.SetParamObj(map, prefix + "DiSourceCvm.", this.DiSourceCvm);
            this.SetParamObj(map, prefix + "DiSourceTke.", this.DiSourceTke);
        }
    }
}

