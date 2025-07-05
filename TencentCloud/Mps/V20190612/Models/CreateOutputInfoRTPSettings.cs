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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOutputInfoRTPSettings : AbstractModel
    {
        
        /// <summary>
        /// 转推的目标地址，可填1~2个。
        /// </summary>
        [JsonProperty("Destinations")]
        public CreateOutputRTPSettingsDestinations[] Destinations{ get; set; }

        /// <summary>
        /// 只能填none。
        /// </summary>
        [JsonProperty("FEC")]
        public string FEC{ get; set; }

        /// <summary>
        /// 空闲超时时间，单位ms。
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public long? IdleTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Destinations.", this.Destinations);
            this.SetParamSimple(map, prefix + "FEC", this.FEC);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
        }
    }
}

