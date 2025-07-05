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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WarningObject : AbstractModel
    {
        
        /// <summary>
        /// 事件告警类型；1：离线，2：木马，3：异常登录，4：爆破，5：漏洞（已拆分为9-12四种类型）6：高位命令，7：反弹sell，8：本地提权，9：系统组件漏洞，10：web应用漏洞，11：应急漏洞，12：安全基线，14：恶意请求，15: 网络攻击，16：Windows系统漏洞，17：Linux软件漏洞
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 1: 关闭告警 0: 开启告警
        /// </summary>
        [JsonProperty("DisablePhoneWarning")]
        public ulong? DisablePhoneWarning{ get; set; }

        /// <summary>
        /// 开始时间，格式: HH:mm
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 结束时间，格式: HH:mm
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 漏洞等级控制位二进制，每一位对应页面漏洞等级的开启关闭：低中高（0:关闭；1：开启），例如：101 → 同时勾选低+高；01→(登录审计)疑似不告警，高危告警
        /// </summary>
        [JsonProperty("ControlBits")]
        public string ControlBits{ get; set; }

        /// <summary>
        /// 告警主机范围类型，0:全部主机，1:按所属项目选，2:按腾讯云标签选，3:按主机安全标签选，4:自选主机
        /// </summary>
        [JsonProperty("HostRange")]
        public long? HostRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DisablePhoneWarning", this.DisablePhoneWarning);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ControlBits", this.ControlBits);
            this.SetParamSimple(map, prefix + "HostRange", this.HostRange);
        }
    }
}

