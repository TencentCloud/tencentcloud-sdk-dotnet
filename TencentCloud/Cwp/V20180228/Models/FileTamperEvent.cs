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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileTamperEvent : AbstractModel
    {
        
        /// <summary>
        /// 机器名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 机器IP
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// 发生时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近发生时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 事件id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 主机uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// cvm id
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 事件类型/动作  0 -- 告警
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 进程路径
        /// </summary>
        [JsonProperty("ProcessExe")]
        public string ProcessExe{ get; set; }

        /// <summary>
        /// 进程参数
        /// </summary>
        [JsonProperty("ProcessArgv")]
        public string ProcessArgv{ get; set; }

        /// <summary>
        /// 目标文件路径
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// 处理状态  0 -- 待处理 1 -- 已加白 2 -- 已删除 3 - 已忽略 4-已手动处理
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 事件产生次数
        /// </summary>
        [JsonProperty("EventCount")]
        public ulong? EventCount{ get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 事件详情: json格式
        /// </summary>
        [JsonProperty("Pstree")]
        public string Pstree{ get; set; }

        /// <summary>
        /// 规则类型 0系统规则 1自定义规则
        /// </summary>
        [JsonProperty("RuleCategory")]
        public ulong? RuleCategory{ get; set; }

        /// <summary>
        /// 主机在线信息 ONLINE、OFFLINE
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// 危害描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 修护建议
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 内网ip
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 进程权限
        /// </summary>
        [JsonProperty("ExePermission")]
        public string ExePermission{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 用户组
        /// </summary>
        [JsonProperty("UserGroup")]
        public string UserGroup{ get; set; }

        /// <summary>
        /// 进程名
        /// </summary>
        [JsonProperty("ExeMd5")]
        public string ExeMd5{ get; set; }

        /// <summary>
        /// 进程文件大小
        /// </summary>
        [JsonProperty("ExeSize")]
        public ulong? ExeSize{ get; set; }

        /// <summary>
        /// 进程执行时长
        /// </summary>
        [JsonProperty("ExeTime")]
        public ulong? ExeTime{ get; set; }

        /// <summary>
        /// 目标文件大小
        /// </summary>
        [JsonProperty("TargetSize")]
        public ulong? TargetSize{ get; set; }

        /// <summary>
        /// 目标文件权限
        /// </summary>
        [JsonProperty("TargetPermission")]
        public string TargetPermission{ get; set; }

        /// <summary>
        /// 目标文件更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetModifyTime")]
        public string TargetModifyTime{ get; set; }

        /// <summary>
        /// 目标文件创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetCreatTime")]
        public string TargetCreatTime{ get; set; }

        /// <summary>
        /// 进程pid
        /// </summary>
        [JsonProperty("ExePid")]
        public ulong? ExePid{ get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// 参考链接
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

        /// <summary>
        /// 风险等级 0：无， 1: 高危， 2:中危， 3: 低危
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 进程名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExeName")]
        public string ExeName{ get; set; }

        /// <summary>
        ///  主机额外信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ProcessExe", this.ProcessExe);
            this.SetParamSimple(map, prefix + "ProcessArgv", this.ProcessArgv);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Pstree", this.Pstree);
            this.SetParamSimple(map, prefix + "RuleCategory", this.RuleCategory);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "ExePermission", this.ExePermission);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UserGroup", this.UserGroup);
            this.SetParamSimple(map, prefix + "ExeMd5", this.ExeMd5);
            this.SetParamSimple(map, prefix + "ExeSize", this.ExeSize);
            this.SetParamSimple(map, prefix + "ExeTime", this.ExeTime);
            this.SetParamSimple(map, prefix + "TargetSize", this.TargetSize);
            this.SetParamSimple(map, prefix + "TargetPermission", this.TargetPermission);
            this.SetParamSimple(map, prefix + "TargetModifyTime", this.TargetModifyTime);
            this.SetParamSimple(map, prefix + "TargetCreatTime", this.TargetCreatTime);
            this.SetParamSimple(map, prefix + "ExePid", this.ExePid);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "ExeName", this.ExeName);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
        }
    }
}

