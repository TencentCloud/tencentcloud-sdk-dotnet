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

    public class FenceBindDeviceItem : AbstractModel
    {
        
        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 告警条件(In，进围栏报警；Out，出围栏报警；InOrOut，进围栏或者出围栏均报警)
        /// </summary>
        [JsonProperty("AlertCondition")]
        public string AlertCondition{ get; set; }

        /// <summary>
        /// 是否使能围栏(true，使能；false，禁用)
        /// </summary>
        [JsonProperty("FenceEnable")]
        public bool? FenceEnable{ get; set; }

        /// <summary>
        /// 告警处理方法
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "AlertCondition", this.AlertCondition);
            this.SetParamSimple(map, prefix + "FenceEnable", this.FenceEnable);
            this.SetParamSimple(map, prefix + "Method", this.Method);
        }
    }
}

