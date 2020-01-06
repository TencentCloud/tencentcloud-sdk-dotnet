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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class L4HealthConfig : AbstractModel
    {
        
        /// <summary>
        /// 转发协议，取值[TCP, UDP]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 转发端口
        /// </summary>
        [JsonProperty("VirtualPort")]
        public ulong? VirtualPort{ get; set; }

        /// <summary>
        /// =1表示开启；=0表示关闭
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// 响应超时时间，单位秒
        /// </summary>
        [JsonProperty("TimeOut")]
        public ulong? TimeOut{ get; set; }

        /// <summary>
        /// 检测间隔时间，单位秒
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// 不健康阈值，单位次
        /// </summary>
        [JsonProperty("KickNum")]
        public ulong? KickNum{ get; set; }

        /// <summary>
        /// 健康阈值，单位次
        /// </summary>
        [JsonProperty("AliveNum")]
        public ulong? AliveNum{ get; set; }

        /// <summary>
        /// 会话保持时间，单位秒
        /// </summary>
        [JsonProperty("KeepTime")]
        public ulong? KeepTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "VirtualPort", this.VirtualPort);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "TimeOut", this.TimeOut);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "KickNum", this.KickNum);
            this.SetParamSimple(map, prefix + "AliveNum", this.AliveNum);
            this.SetParamSimple(map, prefix + "KeepTime", this.KeepTime);
        }
    }
}

