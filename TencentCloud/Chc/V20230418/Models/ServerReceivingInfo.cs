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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerReceivingInfo : AbstractModel
    {
        
        /// <summary>
        /// 设备sn
        /// </summary>
        [JsonProperty("DeviceSn")]
        public string DeviceSn{ get; set; }

        /// <summary>
        /// 设备型号-版本
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// 需要万兆机位
        /// </summary>
        [JsonProperty("Need10GbSlot")]
        public string Need10GbSlot{ get; set; }

        /// <summary>
        /// 需要直流电
        /// </summary>
        [JsonProperty("NeedDCPower")]
        public string NeedDCPower{ get; set; }

        /// <summary>
        /// 需要外网
        /// </summary>
        [JsonProperty("NeedExtranet")]
        public string NeedExtranet{ get; set; }

        /// <summary>
        /// 需要虚拟化
        /// </summary>
        [JsonProperty("NeedVirtualization")]
        public string NeedVirtualization{ get; set; }

        /// <summary>
        /// 硬件备注
        /// </summary>
        [JsonProperty("HardwareMemo")]
        public string HardwareMemo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceSn", this.DeviceSn);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "Need10GbSlot", this.Need10GbSlot);
            this.SetParamSimple(map, prefix + "NeedDCPower", this.NeedDCPower);
            this.SetParamSimple(map, prefix + "NeedExtranet", this.NeedExtranet);
            this.SetParamSimple(map, prefix + "NeedVirtualization", this.NeedVirtualization);
            this.SetParamSimple(map, prefix + "HardwareMemo", this.HardwareMemo);
        }
    }
}

