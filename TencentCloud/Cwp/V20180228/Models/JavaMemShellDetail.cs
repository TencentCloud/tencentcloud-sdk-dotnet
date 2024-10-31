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

    public class JavaMemShellDetail : AbstractModel
    {
        
        /// <summary>
        /// 容器名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例状态：RUNNING,STOPPED,SHUTDOWN...
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// 内网IP
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 公共ip
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 内存马类型  0:Filter型 1:Listener型 2:Servlet型 3:Interceptors型 4:Agent型 5:其他
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 首次发现时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近检测时间
        /// </summary>
        [JsonProperty("RecentFoundTime")]
        public string RecentFoundTime{ get; set; }

        /// <summary>
        /// 处理状态  0 -- 待处理 1 -- 已加白 2 -- 已删除 3 - 已忽略  4 - 已手动处理
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// java加载器类名
        /// </summary>
        [JsonProperty("ClassLoaderName")]
        public string ClassLoaderName{ get; set; }

        /// <summary>
        /// 父类名
        /// </summary>
        [JsonProperty("SuperClassName")]
        public string SuperClassName{ get; set; }

        /// <summary>
        /// 类文件MD5
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// 继承的接口
        /// </summary>
        [JsonProperty("Interfaces")]
        public string Interfaces{ get; set; }

        /// <summary>
        /// 注释
        /// </summary>
        [JsonProperty("Annotations")]
        public string Annotations{ get; set; }

        /// <summary>
        /// 进程pid
        /// </summary>
        [JsonProperty("Pid")]
        public ulong? Pid{ get; set; }

        /// <summary>
        /// java进程路径
        /// </summary>
        [JsonProperty("Exe")]
        public string Exe{ get; set; }

        /// <summary>
        /// java进程命令行参数
        /// </summary>
        [JsonProperty("Args")]
        public string Args{ get; set; }

        /// <summary>
        /// 类名
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }

        /// <summary>
        /// java内存马二进制代码(base64)
        /// </summary>
        [JsonProperty("ClassContent")]
        public string ClassContent{ get; set; }

        /// <summary>
        /// java内存马反编译代码
        /// </summary>
        [JsonProperty("ClassContentPretty")]
        public string ClassContentPretty{ get; set; }

        /// <summary>
        /// 事件描述
        /// </summary>
        [JsonProperty("EventDescription")]
        public string EventDescription{ get; set; }

        /// <summary>
        /// 安全建议
        /// </summary>
        [JsonProperty("SecurityAdvice")]
        public string SecurityAdvice{ get; set; }

        /// <summary>
        ///  主机额外信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// agent状态：OFFLINE,ONLINE
        /// </summary>
        [JsonProperty("MachineState")]
        public string MachineState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RecentFoundTime", this.RecentFoundTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClassLoaderName", this.ClassLoaderName);
            this.SetParamSimple(map, prefix + "SuperClassName", this.SuperClassName);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamSimple(map, prefix + "Interfaces", this.Interfaces);
            this.SetParamSimple(map, prefix + "Annotations", this.Annotations);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "Exe", this.Exe);
            this.SetParamSimple(map, prefix + "Args", this.Args);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
            this.SetParamSimple(map, prefix + "ClassContent", this.ClassContent);
            this.SetParamSimple(map, prefix + "ClassContentPretty", this.ClassContentPretty);
            this.SetParamSimple(map, prefix + "EventDescription", this.EventDescription);
            this.SetParamSimple(map, prefix + "SecurityAdvice", this.SecurityAdvice);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "MachineState", this.MachineState);
        }
    }
}

