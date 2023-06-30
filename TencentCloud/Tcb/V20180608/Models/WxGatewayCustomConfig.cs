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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WxGatewayCustomConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否开启x-real-ip
        /// </summary>
        [JsonProperty("IsOpenXRealIp")]
        public bool? IsOpenXRealIp{ get; set; }

        /// <summary>
        /// 封禁配置
        /// </summary>
        [JsonProperty("BanConfig")]
        public BanConfig BanConfig{ get; set; }

        /// <summary>
        /// 获取源ip方式，PPV1(Proxy Protocol V1)、PPV2(Proxy Protocol V2)、TOA(tcp option address)
        /// </summary>
        [JsonProperty("SourceIpType")]
        public string SourceIpType{ get; set; }

        /// <summary>
        /// 日志信息
        /// </summary>
        [JsonProperty("LogConfig")]
        public CustomLogConfig LogConfig{ get; set; }

        /// <summary>
        /// 是否开启http1.0
        /// </summary>
        [JsonProperty("IsAcceptHttpOne")]
        public bool? IsAcceptHttpOne{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsOpenXRealIp", this.IsOpenXRealIp);
            this.SetParamObj(map, prefix + "BanConfig.", this.BanConfig);
            this.SetParamSimple(map, prefix + "SourceIpType", this.SourceIpType);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
            this.SetParamSimple(map, prefix + "IsAcceptHttpOne", this.IsAcceptHttpOne);
        }
    }
}

