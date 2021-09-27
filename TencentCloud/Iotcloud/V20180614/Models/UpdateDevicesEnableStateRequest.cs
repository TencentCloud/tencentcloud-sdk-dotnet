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

namespace TencentCloud.Iotcloud.V20180614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateDevicesEnableStateRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备所属产品id
        /// </summary>
        [JsonProperty("ProductID")]
        public string ProductID{ get; set; }

        /// <summary>
        /// 设备名称集合
        /// </summary>
        [JsonProperty("DeviceNames")]
        public string[] DeviceNames{ get; set; }

        /// <summary>
        /// 要设置的设备状态，1为启用，0为禁用
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductID", this.ProductID);
            this.SetParamArraySimple(map, prefix + "DeviceNames.", this.DeviceNames);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

