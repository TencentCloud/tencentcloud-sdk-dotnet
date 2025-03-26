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

    public class CreateRackOnWorkOrderRequest : AbstractModel
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
        /// 上架人员 1.自行解决 2.由腾讯IDC负责
        /// </summary>
        [JsonProperty("StuffOption")]
        public string StuffOption{ get; set; }

        /// <summary>
        /// 上架后是否开电
        /// </summary>
        [JsonProperty("WithPowerOn")]
        public bool? WithPowerOn{ get; set; }

        /// <summary>
        /// 服务器收货列表
        /// </summary>
        [JsonProperty("DeviceRackOnList")]
        public DeviceRackOn[] DeviceRackOnList{ get; set; }

        /// <summary>
        /// 自行解决必填
        /// </summary>
        [JsonProperty("SelfOperationInfo")]
        public SelfOperation SelfOperationInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdcId", this.IdcId);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "StuffOption", this.StuffOption);
            this.SetParamSimple(map, prefix + "WithPowerOn", this.WithPowerOn);
            this.SetParamArrayObj(map, prefix + "DeviceRackOnList.", this.DeviceRackOnList);
            this.SetParamObj(map, prefix + "SelfOperationInfo.", this.SelfOperationInfo);
        }
    }
}

