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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReverseShell : AbstractModel
    {
        
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 云镜UUID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 主机内网IP
        /// </summary>
        [JsonProperty("Hostip")]
        public string Hostip{ get; set; }

        /// <summary>
        /// 目标IP
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// 目标端口
        /// </summary>
        [JsonProperty("DstPort")]
        public ulong? DstPort{ get; set; }

        /// <summary>
        /// 进程名
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// 进程路径
        /// </summary>
        [JsonProperty("FullPath")]
        public string FullPath{ get; set; }

        /// <summary>
        /// 命令详情
        /// </summary>
        [JsonProperty("CmdLine")]
        public string CmdLine{ get; set; }

        /// <summary>
        /// 执行用户
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 执行用户组
        /// </summary>
        [JsonProperty("UserGroup")]
        public string UserGroup{ get; set; }

        /// <summary>
        /// 父进程名
        /// </summary>
        [JsonProperty("ParentProcName")]
        public string ParentProcName{ get; set; }

        /// <summary>
        /// 父进程用户
        /// </summary>
        [JsonProperty("ParentProcUser")]
        public string ParentProcUser{ get; set; }

        /// <summary>
        /// 父进程用户组
        /// </summary>
        [JsonProperty("ParentProcGroup")]
        public string ParentProcGroup{ get; set; }

        /// <summary>
        /// 父进程路径
        /// </summary>
        [JsonProperty("ParentProcPath")]
        public string ParentProcPath{ get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 产生时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 主机名
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 进程树
        /// </summary>
        [JsonProperty("ProcTree")]
        public string ProcTree{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Hostip", this.Hostip);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "FullPath", this.FullPath);
            this.SetParamSimple(map, prefix + "CmdLine", this.CmdLine);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UserGroup", this.UserGroup);
            this.SetParamSimple(map, prefix + "ParentProcName", this.ParentProcName);
            this.SetParamSimple(map, prefix + "ParentProcUser", this.ParentProcUser);
            this.SetParamSimple(map, prefix + "ParentProcGroup", this.ParentProcGroup);
            this.SetParamSimple(map, prefix + "ParentProcPath", this.ParentProcPath);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "ProcTree", this.ProcTree);
        }
    }
}

