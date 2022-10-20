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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AbnormalProcessEventTendencyInfo : AbstractModel
    {
        
        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 待处理代理软件事件数
        /// </summary>
        [JsonProperty("ProxyToolEventCount")]
        public long? ProxyToolEventCount{ get; set; }

        /// <summary>
        /// 待处理横向参透事件数
        /// </summary>
        [JsonProperty("TransferControlEventCount")]
        public long? TransferControlEventCount{ get; set; }

        /// <summary>
        /// 待处理恶意命令事件数
        /// </summary>
        [JsonProperty("AttackCmdEventCount")]
        public long? AttackCmdEventCount{ get; set; }

        /// <summary>
        /// 待处理反弹shell事件数
        /// </summary>
        [JsonProperty("ReverseShellEventCount")]
        public long? ReverseShellEventCount{ get; set; }

        /// <summary>
        /// 待处理无文件程序执行事件数
        /// </summary>
        [JsonProperty("FilelessEventCount")]
        public long? FilelessEventCount{ get; set; }

        /// <summary>
        /// 待处理高危命令事件数
        /// </summary>
        [JsonProperty("RiskCmdEventCount")]
        public long? RiskCmdEventCount{ get; set; }

        /// <summary>
        /// 待处理敏感服务异常子进程启动事件数
        /// </summary>
        [JsonProperty("AbnormalChildProcessEventCount")]
        public long? AbnormalChildProcessEventCount{ get; set; }

        /// <summary>
        /// 待处理自定义规则事件数
        /// </summary>
        [JsonProperty("UserDefinedRuleEventCount")]
        public long? UserDefinedRuleEventCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "ProxyToolEventCount", this.ProxyToolEventCount);
            this.SetParamSimple(map, prefix + "TransferControlEventCount", this.TransferControlEventCount);
            this.SetParamSimple(map, prefix + "AttackCmdEventCount", this.AttackCmdEventCount);
            this.SetParamSimple(map, prefix + "ReverseShellEventCount", this.ReverseShellEventCount);
            this.SetParamSimple(map, prefix + "FilelessEventCount", this.FilelessEventCount);
            this.SetParamSimple(map, prefix + "RiskCmdEventCount", this.RiskCmdEventCount);
            this.SetParamSimple(map, prefix + "AbnormalChildProcessEventCount", this.AbnormalChildProcessEventCount);
            this.SetParamSimple(map, prefix + "UserDefinedRuleEventCount", this.UserDefinedRuleEventCount);
        }
    }
}

