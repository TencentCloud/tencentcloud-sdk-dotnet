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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebhookNotifyItem : AbstractModel
    {
        
        /// <summary>
        /// <p>模块编码（与 ModifyNotifySettingAlert 共用枚举）<br>枚举值：<br>Vul：漏洞与云安全态势<br>Alert：告警中心<br>AkSk：云API风险治理<br>Agent：客户端/主机资产<br>LogAnalysis：日志分析</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>子模块编码<br>枚举值（部分）：<br>MALWARE_FILE：恶意文件<br>MALWARE_PROCESS：恶意进程<br>RISK_LOGIN：异常登录<br>BRUTE_FORCE：密码破解<br>MALICIOUS_REQUEST：恶意请求<br>HIGH_RISK_COMMAND：高危命令<br>PRIVILEGE_ESCALATION：本地提权<br>REVERSE_SHELL：反弹Shell<br>NETWORK_ATTACK：网络攻击<br>MULTI_BEHAVIOR_ATTACK：多行为攻击<br>AGENT_OFFLINE：客户端离线<br>AGENT_UNINSTALL：客户端卸载<br>完整枚举见 DescribeWebhookNotifyItemTree</p>
        /// </summary>
        [JsonProperty("SubModule")]
        public string SubModule{ get; set; }

        /// <summary>
        /// <p>风险等级集合<br>枚举值：<br>CRITICAL：严重<br>HIGH：高危<br>MEDIUM：中危<br>LOW：低危<br>INFO：提示<br>不支持等级的子模块传空数组</p>
        /// </summary>
        [JsonProperty("Levels")]
        public string[] Levels{ get; set; }

        /// <summary>
        /// <p>处理状态等</p>
        /// </summary>
        [JsonProperty("Items")]
        public string[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "SubModule", this.SubModule);
            this.SetParamArraySimple(map, prefix + "Levels.", this.Levels);
            this.SetParamArraySimple(map, prefix + "Items.", this.Items);
        }
    }
}

