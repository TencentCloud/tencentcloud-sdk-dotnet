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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StatDeviceType : AbstractModel
    {
        
        /// <summary>
        /// 汇总数。在线（正常+故障） + 离线
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 正常数
        /// </summary>
        [JsonProperty("Normal")]
        public long? Normal{ get; set; }

        /// <summary>
        /// 离线数
        /// </summary>
        [JsonProperty("Offline")]
        public long? Offline{ get; set; }

        /// <summary>
        /// 故障数
        /// </summary>
        [JsonProperty("Fault")]
        public long? Fault{ get; set; }

        /// <summary>
        /// 设备名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Normal", this.Normal);
            this.SetParamSimple(map, prefix + "Offline", this.Offline);
            this.SetParamSimple(map, prefix + "Fault", this.Fault);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
        }
    }
}

