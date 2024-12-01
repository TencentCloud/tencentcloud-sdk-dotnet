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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternalMedicineVessel : AbstractModel
    {
        
        /// <summary>
        /// 血管总体描述
        /// </summary>
        [JsonProperty("Text")]
        public KeyValueItem Text{ get; set; }

        /// <summary>
        /// 血管杂音
        /// </summary>
        [JsonProperty("VascularMurmur")]
        public KeyValueItem VascularMurmur{ get; set; }

        /// <summary>
        /// 外周血管
        /// </summary>
        [JsonProperty("PeripheralVessel")]
        public KeyValueItem PeripheralVessel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Text.", this.Text);
            this.SetParamObj(map, prefix + "VascularMurmur.", this.VascularMurmur);
            this.SetParamObj(map, prefix + "PeripheralVessel.", this.PeripheralVessel);
        }
    }
}

