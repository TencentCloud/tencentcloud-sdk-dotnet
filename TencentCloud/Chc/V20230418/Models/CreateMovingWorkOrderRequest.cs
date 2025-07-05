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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMovingWorkOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 机房id
        /// </summary>
        [JsonProperty("IdcId")]
        public ulong? IdcId{ get; set; }

        /// <summary>
        /// 设备类型，server, netDevice
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 上架后是否开电
        /// </summary>
        [JsonProperty("WithPowerOn")]
        public bool? WithPowerOn{ get; set; }

        /// <summary>
        /// 设备搬迁信息列表
        /// </summary>
        [JsonProperty("DeviceMovingList")]
        public DeviceRackOn[] DeviceMovingList{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdcId", this.IdcId);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "WithPowerOn", this.WithPowerOn);
            this.SetParamArrayObj(map, prefix + "DeviceMovingList.", this.DeviceMovingList);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

