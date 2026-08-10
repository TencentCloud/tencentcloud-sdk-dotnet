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

    public class VulHostBriefInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>云主机实例 ID<br>参数格式：形如 ins-xxxxxxxx</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>主机名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>公网 IP 地址</p>
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// <p>内网 IP 地址</p>
        /// </summary>
        [JsonProperty("PrivateIP")]
        public string PrivateIP{ get; set; }

        /// <summary>
        /// <p>防护版本<br>枚举值：<br>NONE：无防护<br>BASIC：基础版<br>PRO：专业版<br>ULTIMATE：旗舰版<br>PRO_LH：轻量版</p>
        /// </summary>
        [JsonProperty("DefendVersion")]
        public string DefendVersion{ get; set; }

        /// <summary>
        /// <p>漏洞防御状态<br>枚举值：<br>ENABLED：已开启<br>NOT_SUPPORTED：不支持<br>NOT_ENABLED：未开启</p>
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }

        /// <summary>
        /// <p>所属账号信息</p>
        /// </summary>
        [JsonProperty("Account")]
        public AccountBriefInfo Account{ get; set; }

        /// <summary>
        /// <p>云主机实例状态<br>枚举值：<br>RUNNING：运行中<br>STOPPED：已停止<br>UNKNOWN：未知</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>修复状态枚举值</p><p>枚举值：</p><ul><li>PENDING： 待修复</li><li>SCANNING： 扫描中</li><li>FIXED： 已修复</li><li>IGNORED： 已忽略</li><li>FIXING： 修复中</li><li>FIX_FAILED： 修复失败</li><li>NEED_REBOOT： 修复待重启</li></ul>
        /// </summary>
        [JsonProperty("RiskStatus")]
        public string RiskStatus{ get; set; }

        /// <summary>
        /// <p>VPR 评级信息（含评级结果与各维度详情）</p>
        /// </summary>
        [JsonProperty("VPRRating")]
        public VPRRatingInfo VPRRating{ get; set; }

        /// <summary>
        /// <p>CWP Agent 状态<br>枚举值：<br>ONLINE：在线<br>OFFLINE：离线<br>UNINSTALLED：未安装</p>
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// <p>资产标签列表（CSIP 内部资产标签）</p>
        /// </summary>
        [JsonProperty("TagItem")]
        public MiniTagItem[] TagItem{ get; set; }

        /// <summary>
        /// <p>云上标签列表（云资产侧 Tag）</p>
        /// </summary>
        [JsonProperty("CloudTag")]
        public Tag[] CloudTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "PrivateIP", this.PrivateIP);
            this.SetParamSimple(map, prefix + "DefendVersion", this.DefendVersion);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamObj(map, prefix + "Account.", this.Account);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
            this.SetParamObj(map, prefix + "VPRRating.", this.VPRRating);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamArrayObj(map, prefix + "TagItem.", this.TagItem);
            this.SetParamArrayObj(map, prefix + "CloudTag.", this.CloudTag);
        }
    }
}

