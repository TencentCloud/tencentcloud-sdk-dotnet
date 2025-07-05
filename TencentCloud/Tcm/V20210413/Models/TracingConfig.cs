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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TracingConfig : AbstractModel
    {
        
        /// <summary>
        /// 调用链采样率，百分比
        /// </summary>
        [JsonProperty("Sampling")]
        public float? Sampling{ get; set; }

        /// <summary>
        /// 是否启用调用跟踪
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 腾讯云 APM 服务相关参数
        /// </summary>
        [JsonProperty("APM")]
        public APM APM{ get; set; }

        /// <summary>
        /// 启动第三方服务器的地址
        /// </summary>
        [JsonProperty("Zipkin")]
        public TracingZipkin Zipkin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sampling", this.Sampling);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamObj(map, prefix + "APM.", this.APM);
            this.SetParamObj(map, prefix + "Zipkin.", this.Zipkin);
        }
    }
}

