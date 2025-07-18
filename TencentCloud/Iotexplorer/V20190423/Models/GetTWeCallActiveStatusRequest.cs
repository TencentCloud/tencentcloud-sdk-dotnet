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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetTWeCallActiveStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 参数已弃用，不用传参
        /// </summary>
        [JsonProperty("MiniProgramAppId")]
        [System.Obsolete]
        public string MiniProgramAppId{ get; set; }

        /// <summary>
        /// 设备列表
        /// </summary>
        [JsonProperty("DeviceList")]
        public TWeCallInfo[] DeviceList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MiniProgramAppId", this.MiniProgramAppId);
            this.SetParamArrayObj(map, prefix + "DeviceList.", this.DeviceList);
        }
    }
}

