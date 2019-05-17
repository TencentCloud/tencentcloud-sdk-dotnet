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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetHealth : AbstractModel
    {
        
        /// <summary>
        /// Target的内网IP
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// Target绑定的端口
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 当前健康状态，true：健康，false：不健康。
        /// </summary>
        [JsonProperty("HealthStatus")]
        public bool? HealthStatus{ get; set; }

        /// <summary>
        /// Target的实例ID，如 ins-12345678
        /// </summary>
        [JsonProperty("TargetId")]
        public string TargetId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "HealthStatus", this.HealthStatus);
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
        }
    }
}

