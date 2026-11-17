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

    public class KBUpdateMachineItem : AbstractModel
    {
        
        /// <summary>
        /// KB补丁ID
        /// </summary>
        [JsonProperty("KBId")]
        public long? KBId{ get; set; }

        /// <summary>
        /// 主机实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 主机IP
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// 公网IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 操作系统名称
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// 主机在线状态
        /// 枚举值：
        /// ONLINE：在线
        /// OFFLINE：离线
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// 主机运行状态
        /// 枚举值：
        /// RUNNING：运行中
        /// STOPPED：已停止
        /// EXPIRED：待回收
        /// </summary>
        [JsonProperty("HostStatus")]
        public string HostStatus{ get; set; }

        /// <summary>
        /// 是否支持自动更新补丁
        /// 枚举值：
        /// 0：不支持
        /// 1：支持
        /// </summary>
        [JsonProperty("SupportAutoFix")]
        public long? SupportAutoFix{ get; set; }

        /// <summary>
        /// 当前修复状态
        /// 枚举值：
        /// 0：未修复
        /// 1：修复中
        /// 2：修复失败
        /// 3：修复成功
        /// 4：修复超时
        /// </summary>
        [JsonProperty("FixStatus")]
        public long? FixStatus{ get; set; }

        /// <summary>
        /// 最近一次修复时间
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("LatestFixTime")]
        public string LatestFixTime{ get; set; }

        /// <summary>
        /// 不可修复原因，SupportAutoFix为0时返回
        /// </summary>
        [JsonProperty("NotFixableReason")]
        public string NotFixableReason{ get; set; }

        /// <summary>
        /// 不可修复原因关联动作，SupportAutoFix为0且存在可引导动作时返回
        /// </summary>
        [JsonProperty("NotFixableAction")]
        public VulFixableMachineAction NotFixableAction{ get; set; }

        /// <summary>
        /// 资产标签列表
        /// </summary>
        [JsonProperty("TagItems")]
        public MiniTagItem[] TagItems{ get; set; }

        /// <summary>
        /// 所属账号AppId
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 付费版本信息
        /// 枚举值：
        /// BASIC：基础版
        /// PRO：专业版
        /// ULTIMATE：旗舰版
        /// PRO_LH：轻量版
        /// </summary>
        [JsonProperty("PayVersion")]
        public string PayVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KBId", this.KBId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "HostStatus", this.HostStatus);
            this.SetParamSimple(map, prefix + "SupportAutoFix", this.SupportAutoFix);
            this.SetParamSimple(map, prefix + "FixStatus", this.FixStatus);
            this.SetParamSimple(map, prefix + "LatestFixTime", this.LatestFixTime);
            this.SetParamSimple(map, prefix + "NotFixableReason", this.NotFixableReason);
            this.SetParamObj(map, prefix + "NotFixableAction.", this.NotFixableAction);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PayVersion", this.PayVersion);
        }
    }
}

