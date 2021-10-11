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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FenceEventItem : AbstractModel
    {
        
        /// <summary>
        /// 围栏事件的产品Id
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 围栏事件的设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 围栏Id
        /// </summary>
        [JsonProperty("FenceId")]
        public long? FenceId{ get; set; }

        /// <summary>
        /// 围栏事件的告警类型（In，进围栏报警；Out，出围栏报警；InOrOut，进围栏或者出围栏均报警）
        /// </summary>
        [JsonProperty("AlertType")]
        public string AlertType{ get; set; }

        /// <summary>
        /// 围栏事件的设备位置信息
        /// </summary>
        [JsonProperty("Data")]
        public FenceAlarmPoint Data{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "FenceId", this.FenceId);
            this.SetParamSimple(map, prefix + "AlertType", this.AlertType);
            this.SetParamObj(map, prefix + "Data.", this.Data);
        }
    }
}

