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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WarningRule : AbstractModel
    {
        
        /// <summary>
        /// 告警事件类型：
        /// 镜像仓库安全-木马：IMG_REG_VIRUS
        /// 镜像仓库安全-漏洞：IMG_REG_VUL
        /// 镜像仓库安全-敏感信息：IMG_REG_RISK
        /// 镜像安全-木马：IMG_VIRUS
        /// 镜像安全-漏洞：IMG_VUL
        /// 镜像安全-敏感信息：IMG_RISK
        /// 镜像安全-镜像拦截：IMG_INTERCEPT
        /// 运行时安全-容器逃逸：RUNTIME_ESCAPE
        /// 运行时安全-异常进程：RUNTIME_FILE
        /// 运行时安全-异常文件访问：RUNTIME_PROCESS
        /// 运行时安全-高危系统调用：RUNTIME_SYSCALL
        /// 运行时安全-反弹Shell：RUNTIME_REVERSE_SHELL
        /// 运行时安全-木马：RUNTIME_VIRUS
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 开关状态：
        /// 打开：ON
        /// 关闭：OFF
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 告警开始时间，格式: HH:mm
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 告警结束时间，格式: HH:mm
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 告警等级策略控制，二进制位每位代表一个含义，值以字符串类型传递
        /// 控制开关分为高、中、低，则二进制位分别为：第1位:低，第2位:中，第3位:高，0表示关闭、1表示打开。
        /// 如：高危和中危打开告警，低危关闭告警，则二进制值为：110
        /// 告警类型不区分等级控制，则传1。
        /// </summary>
        [JsonProperty("ControlBits")]
        public string ControlBits{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ControlBits", this.ControlBits);
        }
    }
}

