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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TdwParam : AbstractModel
    {
        
        /// <summary>
        /// <p>Tdw的bid</p>
        /// </summary>
        [JsonProperty("Bid")]
        public string Bid{ get; set; }

        /// <summary>
        /// <p>Tdw的tid</p>
        /// </summary>
        [JsonProperty("Tid")]
        public string Tid{ get; set; }

        /// <summary>
        /// <p>默认true</p>
        /// </summary>
        [JsonProperty("IsDomestic")]
        public bool? IsDomestic{ get; set; }

        /// <summary>
        /// <p>TDW地址，默认tl-tdbank-tdmanager.tencent-distribute.com</p>
        /// </summary>
        [JsonProperty("TdwHost")]
        public string TdwHost{ get; set; }

        /// <summary>
        /// <p>TDW端口，默认8099</p>
        /// </summary>
        [JsonProperty("TdwPort")]
        public long? TdwPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bid", this.Bid);
            this.SetParamSimple(map, prefix + "Tid", this.Tid);
            this.SetParamSimple(map, prefix + "IsDomestic", this.IsDomestic);
            this.SetParamSimple(map, prefix + "TdwHost", this.TdwHost);
            this.SetParamSimple(map, prefix + "TdwPort", this.TdwPort);
        }
    }
}

