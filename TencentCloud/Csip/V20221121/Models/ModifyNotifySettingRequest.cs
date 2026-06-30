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

    public class ModifyNotifySettingRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>通知模块</p><p>枚举值：</p><ul><li>AkSk： 云API风险治理</li><li>Alert： 告警中心</li><li>Agent： 客户端</li></ul>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>通知设置模式</p><p>枚举值：</p><ul><li>0： 标准模式</li><li>1： 高级模式</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// <p>通知状态</p><p>枚举值：</p><ul><li>0： 通知关闭</li><li>1： 通知开启</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>通知开始时间</p><p>参数格式：hh:mm:ss</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>通知结束时间</p><p>参数格式：hh:mm:ss</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>通知选项</p><p>枚举值：</p><ul><li>CRITICAL： 告警等级：严重</li><li>HIGH： 告警等级：高危</li><li>MEDIUM： 告警等级：中危</li><li>LOW： 告警等级：低危</li><li>INFO： 告警等级：提醒</li><li>AGENT_UNINSTALL： 客户端卸载</li><li>AGENT_OFFLINE： 客户端离线</li></ul>
        /// </summary>
        [JsonProperty("Option")]
        public string[] Option{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Option.", this.Option);
        }
    }
}

