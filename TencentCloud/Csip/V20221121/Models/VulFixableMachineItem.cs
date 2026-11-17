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

    public class VulFixableMachineItem : AbstractModel
    {
        
        /// <summary>
        /// <p>漏洞ID列表，按 SupportAutoFix 维度分组：SupportAutoFix=1 时为可修复的漏洞ID，SupportAutoFix=0 时为不可修复的漏洞ID</p>
        /// </summary>
        [JsonProperty("VulIds")]
        public long?[] VulIds{ get; set; }

        /// <summary>
        /// <p>主机实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>主机名称</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>主机IP</p>
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// <p>公网IP</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>操作系统类型<br>枚举值：<br>linux：Linux操作系统<br>windows：Windows操作系统</p>
        /// </summary>
        [JsonProperty("OsType")]
        public string OsType{ get; set; }

        /// <summary>
        /// <p>操作系统名称</p>
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// <p>主机在线状态<br>枚举值：<br>ONLINE：在线<br>OFFLINE：离线</p>
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// <p>主机运行状态</p><p>枚举值：</p><ul><li>RUNNING： 运行中</li><li>STOPPED： 已停止</li><li>EXPIRED： 待回收</li></ul>
        /// </summary>
        [JsonProperty("HostStatus")]
        public string HostStatus{ get; set; }

        /// <summary>
        /// <p>是否支持自动修复<br>枚举值：<br>0：不支持<br>1：支持</p>
        /// </summary>
        [JsonProperty("SupportAutoFix")]
        public long? SupportAutoFix{ get; set; }

        /// <summary>
        /// <p>当前修复状态<br>枚举值：<br>0：未修复<br>1：修复中<br>2：修复失败<br>3：修复成功<br>4：修复超时</p>
        /// </summary>
        [JsonProperty("FixStatus")]
        public long? FixStatus{ get; set; }

        /// <summary>
        /// <p>最近一次修复时间<br>参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）</p>
        /// </summary>
        [JsonProperty("LatestFixTime")]
        public string LatestFixTime{ get; set; }

        /// <summary>
        /// <p>不可修复原因，SupportAutoFix为0时返回</p>
        /// </summary>
        [JsonProperty("NotFixableReason")]
        public string NotFixableReason{ get; set; }

        /// <summary>
        /// <p>不可修复原因码，SupportAutoFix为0时返回<br>枚举值：<br>BASIC_VERSION：基础版主机不支持一键修复<br>HOST_STOPPED：主机已关机<br>CLIENT_OFFLINE：主机防护客户端已离线<br>PATCH_UNAVAILABLE：官方已停止发布该系统版本的安全补丁<br>SOURCE_COMPILED：源码编译安装，不支持一键修复</p>
        /// </summary>
        [JsonProperty("NotFixableReasonCode")]
        public string NotFixableReasonCode{ get; set; }

        /// <summary>
        /// <p>不可修复原因关联动作，SupportAutoFix为0且存在可引导动作时返回</p>
        /// </summary>
        [JsonProperty("NotFixableAction")]
        public VulFixableMachineAction NotFixableAction{ get; set; }

        /// <summary>
        /// <p>修复命令列表，SupportAutoFix为1时返回</p>
        /// </summary>
        [JsonProperty("FixCommands")]
        public string[] FixCommands{ get; set; }

        /// <summary>
        /// <p>关联组件列表</p>
        /// </summary>
        [JsonProperty("Components")]
        public string[] Components{ get; set; }

        /// <summary>
        /// <p>资产标签列表</p>
        /// </summary>
        [JsonProperty("TagItems")]
        public MiniTagItem[] TagItems{ get; set; }

        /// <summary>
        /// <p>所属账号AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>付费版本信息<br>枚举值：<br>BASIC：基础版<br>PRO：专业版<br>ULTIMATE：旗舰版</p>
        /// </summary>
        [JsonProperty("PayVersion")]
        public string PayVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "VulIds.", this.VulIds);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "HostStatus", this.HostStatus);
            this.SetParamSimple(map, prefix + "SupportAutoFix", this.SupportAutoFix);
            this.SetParamSimple(map, prefix + "FixStatus", this.FixStatus);
            this.SetParamSimple(map, prefix + "LatestFixTime", this.LatestFixTime);
            this.SetParamSimple(map, prefix + "NotFixableReason", this.NotFixableReason);
            this.SetParamSimple(map, prefix + "NotFixableReasonCode", this.NotFixableReasonCode);
            this.SetParamObj(map, prefix + "NotFixableAction.", this.NotFixableAction);
            this.SetParamArraySimple(map, prefix + "FixCommands.", this.FixCommands);
            this.SetParamArraySimple(map, prefix + "Components.", this.Components);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PayVersion", this.PayVersion);
        }
    }
}

