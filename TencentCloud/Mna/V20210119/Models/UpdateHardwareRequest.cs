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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateHardwareRequest : AbstractModel
    {
        
        /// <summary>
        /// 硬件ID
        /// </summary>
        [JsonProperty("HardwareId")]
        public string HardwareId{ get; set; }

        /// <summary>
        /// 硬件序列号
        /// </summary>
        [JsonProperty("SN")]
        public string SN{ get; set; }

        /// <summary>
        /// 设备备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HardwareId", this.HardwareId);
            this.SetParamSimple(map, prefix + "SN", this.SN);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

