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

namespace TencentCloud.Tem.V20201221.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthCheckConfig : AbstractModel
    {
        
        /// <summary>
        /// 支持的健康检查类型，如 HttpGet，TcpSocket，Exec
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 仅当健康检查类型为 HttpGet 时有效，表示协议类型，如 HTTP，HTTPS
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 仅当健康检查类型为 HttpGet 时有效，表示请求路径
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 仅当健康检查类型为 Exec 时有效，表示执行的脚本内容
        /// </summary>
        [JsonProperty("Exec")]
        public string Exec{ get; set; }

        /// <summary>
        /// 仅当健康检查类型为 HttpGet\TcpSocket 时有效，表示请求路径
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 检查延迟开始时间，单位为秒，默认为 0
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public long? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// 超时时间，单位为秒，默认为 1
        /// </summary>
        [JsonProperty("TimeoutSeconds")]
        public long? TimeoutSeconds{ get; set; }

        /// <summary>
        /// 间隔时间，单位为秒，默认为 10
        /// </summary>
        [JsonProperty("PeriodSeconds")]
        public long? PeriodSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Exec", this.Exec);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamSimple(map, prefix + "TimeoutSeconds", this.TimeoutSeconds);
            this.SetParamSimple(map, prefix + "PeriodSeconds", this.PeriodSeconds);
        }
    }
}

