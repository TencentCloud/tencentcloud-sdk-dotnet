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

    public class AssetPortBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 主机内网IP
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// 主机外网IP
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// 主机Quuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 主机Uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 操作系统信息
        /// </summary>
        [JsonProperty("OsInfo")]
        public string OsInfo{ get; set; }

        /// <summary>
        /// 主机业务组ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 主机标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public MachineTag[] Tag{ get; set; }

        /// <summary>
        /// 进程名称
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// 进程版本
        /// </summary>
        [JsonProperty("ProcessVersion")]
        public string ProcessVersion{ get; set; }

        /// <summary>
        /// 进程路径
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// 进程ID
        /// </summary>
        [JsonProperty("Pid")]
        public string Pid{ get; set; }

        /// <summary>
        /// 运行用户
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 启动时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 启动参数
        /// </summary>
        [JsonProperty("Param")]
        public string Param{ get; set; }

        /// <summary>
        /// 进程TTY
        /// </summary>
        [JsonProperty("Teletype")]
        public string Teletype{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 所属用户组
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 进程MD5
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// 父进程ID
        /// </summary>
        [JsonProperty("Ppid")]
        public string Ppid{ get; set; }

        /// <summary>
        /// 父进程名称
        /// </summary>
        [JsonProperty("ParentProcessName")]
        public string ParentProcessName{ get; set; }

        /// <summary>
        /// 端口协议
        /// </summary>
        [JsonProperty("Proto")]
        public string Proto{ get; set; }

        /// <summary>
        /// 绑定IP
        /// </summary>
        [JsonProperty("BindIp")]
        public string BindIp{ get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 数据更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 首次采集时间
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// 是否新增[0:否|1:是]
        /// </summary>
        [JsonProperty("IsNew")]
        public long? IsNew{ get; set; }

        /// <summary>
        ///  附加信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "OsInfo", this.OsInfo);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "ProcessVersion", this.ProcessVersion);
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Param", this.Param);
            this.SetParamSimple(map, prefix + "Teletype", this.Teletype);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamSimple(map, prefix + "Ppid", this.Ppid);
            this.SetParamSimple(map, prefix + "ParentProcessName", this.ParentProcessName);
            this.SetParamSimple(map, prefix + "Proto", this.Proto);
            this.SetParamSimple(map, prefix + "BindIp", this.BindIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
        }
    }
}

