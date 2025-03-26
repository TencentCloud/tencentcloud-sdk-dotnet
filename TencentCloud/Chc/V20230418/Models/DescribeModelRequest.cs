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

    public class DescribeModelRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务器设备型号
        /// </summary>
        [JsonProperty("DevModel")]
        public string DevModel{ get; set; }

        /// <summary>
        /// 园区ID
        /// </summary>
        [JsonProperty("CampusId")]
        public ulong? CampusId{ get; set; }

        /// <summary>
        /// 设备类型，服务器传入 server，网络设备传入 netDevice
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 是否只返回已评估的版本
        /// </summary>
        [JsonProperty("Checked")]
        public bool? Checked{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DevModel", this.DevModel);
            this.SetParamSimple(map, prefix + "CampusId", this.CampusId);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "Checked", this.Checked);
        }
    }
}

