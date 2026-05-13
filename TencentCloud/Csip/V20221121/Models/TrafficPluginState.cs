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

    public class TrafficPluginState : AbstractModel
    {
        
        /// <summary>
        /// 插件安装状态（上层聚合）
        /// 枚举值：
        /// NONE：未安装
        /// INSTALLING：安装中
        /// INSTALLED：已安装
        /// INSTALL_FAIL：安装失败
        /// </summary>
        [JsonProperty("InstallStatus")]
        public string InstallStatus{ get; set; }

        /// <summary>
        /// 插件安装细分状态。取值与 InstallStatus 对应：未安装（InstallStatus=UNINSTALL）时为空字符串；安装成功（InstallStatus=INSTALLED）时为 SUCCESS；安装失败（InstallStatus=INSTALL_FAIL）时为具体失败原因
        /// 枚举值：
        /// NOT_SUPPORT：环境不支持
        /// CONTAINER_NOT_FOUND：容器不存在
        /// REQUIRE_RESTART：需要重启
        /// CA_FAILED：CA 失败
        /// EBPF_FAILED：eBPF 失败
        /// IPTABLE_FAILED：iptables 失败
        /// REDIRECT_FAILED：流量重定向失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 状态文案（由 Status 根据请求语言派生的国际化描述）
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 插件最近活跃时间
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("ActivityTime")]
        public string ActivityTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstallStatus", this.InstallStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "ActivityTime", this.ActivityTime);
        }
    }
}

