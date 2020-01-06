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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserCmdTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 自动编号，可忽略
        /// </summary>
        [JsonProperty("AutoId")]
        public ulong? AutoId{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [JsonProperty("RunBeginTime")]
        public string RunBeginTime{ get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [JsonProperty("RunEndTime")]
        public string RunEndTime{ get; set; }

        /// <summary>
        /// 任务状态ID，取值为 -1：进行中；0：成功；>0：失败错误码
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 设备别名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 私有网络名
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 私有网络整型ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络Cidr
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// 子网名
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 子网Cidr
        /// </summary>
        [JsonProperty("SubnetCidrBlock")]
        public string SubnetCidrBlock{ get; set; }

        /// <summary>
        /// 内网IP
        /// </summary>
        [JsonProperty("LanIp")]
        public string LanIp{ get; set; }

        /// <summary>
        /// 脚本内容，base64编码后的值
        /// </summary>
        [JsonProperty("CmdContent")]
        public string CmdContent{ get; set; }

        /// <summary>
        /// 脚本参数，base64编码后的值
        /// </summary>
        [JsonProperty("CmdParam")]
        public string CmdParam{ get; set; }

        /// <summary>
        /// 脚本执行结果，base64编码后的值
        /// </summary>
        [JsonProperty("CmdResult")]
        public string CmdResult{ get; set; }

        /// <summary>
        /// 用户AppId
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 用户执行脚本结束退出的返回值，没有返回值为-1
        /// </summary>
        [JsonProperty("LastShellExit")]
        public long? LastShellExit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoId", this.AutoId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "RunBeginTime", this.RunBeginTime);
            this.SetParamSimple(map, prefix + "RunEndTime", this.RunEndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetCidrBlock", this.SubnetCidrBlock);
            this.SetParamSimple(map, prefix + "LanIp", this.LanIp);
            this.SetParamSimple(map, prefix + "CmdContent", this.CmdContent);
            this.SetParamSimple(map, prefix + "CmdParam", this.CmdParam);
            this.SetParamSimple(map, prefix + "CmdResult", this.CmdResult);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "LastShellExit", this.LastShellExit);
        }
    }
}

