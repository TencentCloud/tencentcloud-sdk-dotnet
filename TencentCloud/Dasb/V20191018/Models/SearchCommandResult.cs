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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchCommandResult : AbstractModel
    {
        
        /// <summary>
        /// 命令输入的时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("RealName")]
        public string RealName{ get; set; }

        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 资产名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 资产公网IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 资产内网IP
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 命令
        /// </summary>
        [JsonProperty("Cmd")]
        public string Cmd{ get; set; }

        /// <summary>
        /// 命令执行情况，1--允许，2--拒绝
        /// </summary>
        [JsonProperty("Action")]
        public ulong? Action{ get; set; }

        /// <summary>
        /// 命令所属的会话ID
        /// </summary>
        [JsonProperty("Sid")]
        public string Sid{ get; set; }

        /// <summary>
        /// 命令执行时间相对于所属会话开始时间的偏移量，单位ms
        /// </summary>
        [JsonProperty("TimeOffset")]
        public ulong? TimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "RealName", this.RealName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "Cmd", this.Cmd);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Sid", this.Sid);
            this.SetParamSimple(map, prefix + "TimeOffset", this.TimeOffset);
        }
    }
}

