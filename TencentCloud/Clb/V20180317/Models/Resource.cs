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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Resource : AbstractModel
    {
        
        /// <summary>
        /// 运营商内具体资源信息，如"CMCC", "CUCC", "CTCC", "BGP", "INTERNAL"。
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// 运营商信息，如"CMCC", "CUCC", "CTCC", "BGP", "INTERNAL"。
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }

        /// <summary>
        /// 可用资源。
        /// </summary>
        [JsonProperty("AvailabilitySet")]
        public ResourceAvailability[] AvailabilitySet{ get; set; }

        /// <summary>
        /// 运营商类型信息
        /// </summary>
        [JsonProperty("TypeSet")]
        public TypeInfo[] TypeSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamArrayObj(map, prefix + "AvailabilitySet.", this.AvailabilitySet);
            this.SetParamArrayObj(map, prefix + "TypeSet.", this.TypeSet);
        }
    }
}

