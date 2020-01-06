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

namespace TencentCloud.Fmu.V20191213.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RGBAInfo : AbstractModel
    {
        
        /// <summary>
        /// R通道数值。[0,255]。
        /// </summary>
        [JsonProperty("R")]
        public long? R{ get; set; }

        /// <summary>
        /// G通道数值。[0,255]。
        /// </summary>
        [JsonProperty("G")]
        public long? G{ get; set; }

        /// <summary>
        /// B通道数值。[0,255]。
        /// </summary>
        [JsonProperty("B")]
        public long? B{ get; set; }

        /// <summary>
        /// A通道数值。[0,100]。建议取值50。
        /// </summary>
        [JsonProperty("A")]
        public long? A{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "R", this.R);
            this.SetParamSimple(map, prefix + "G", this.G);
            this.SetParamSimple(map, prefix + "B", this.B);
            this.SetParamSimple(map, prefix + "A", this.A);
        }
    }
}

