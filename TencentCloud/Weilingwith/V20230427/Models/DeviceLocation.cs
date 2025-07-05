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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceLocation : AbstractModel
    {
        
        /// <summary>
        /// 点位X坐标值
        /// </summary>
        [JsonProperty("X")]
        public float? X{ get; set; }

        /// <summary>
        /// 点位Y坐标值
        /// </summary>
        [JsonProperty("Y")]
        public float? Y{ get; set; }

        /// <summary>
        /// 点位Z坐标值
        /// </summary>
        [JsonProperty("Z")]
        public float? Z{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "X", this.X);
            this.SetParamSimple(map, prefix + "Y", this.Y);
            this.SetParamSimple(map, prefix + "Z", this.Z);
        }
    }
}

