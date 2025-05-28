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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AvailableZoneScatterScheduleRule : AbstractModel
    {
        
        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("ScatterDimension")]
        public string ScatterDimension{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("MaxUnbalanceQuantity")]
        public long? MaxUnbalanceQuantity{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("IsForceSchedule")]
        public bool? IsForceSchedule{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("Paths")]
        public CommonOption[] Paths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScatterDimension", this.ScatterDimension);
            this.SetParamSimple(map, prefix + "MaxUnbalanceQuantity", this.MaxUnbalanceQuantity);
            this.SetParamSimple(map, prefix + "IsForceSchedule", this.IsForceSchedule);
            this.SetParamArrayObj(map, prefix + "Paths.", this.Paths);
        }
    }
}

