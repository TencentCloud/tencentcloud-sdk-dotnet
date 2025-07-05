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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchFileResult : AbstractModel
    {
        
        /// <summary>
        /// 文件传输的时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("RealName")]
        public string RealName{ get; set; }

        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 资产名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 资产公网IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 资产内网IP
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 操作结果：1 - 已执行，2 - 已阻断
        /// </summary>
        [JsonProperty("Action")]
        public ulong? Action{ get; set; }

        /// <summary>
        /// 操作类型：1 - 文件上传，2 - 文件下载，3 - 文件删除，4 - 文件(夹)移动，5 - 文件(夹)重命名，6 - 新建文件夹，9 - 删除文件夹
        /// </summary>
        [JsonProperty("Method")]
        public ulong? Method{ get; set; }

        /// <summary>
        /// 下载的文件（夹）路径及名称
        /// </summary>
        [JsonProperty("FileCurr")]
        public string FileCurr{ get; set; }

        /// <summary>
        /// 上传或新建文件（夹）路径及名称
        /// </summary>
        [JsonProperty("FileNew")]
        public string FileNew{ get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [JsonProperty("Sid")]
        public string Sid{ get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// 来源id
        /// </summary>
        [JsonProperty("FromIp")]
        public string FromIp{ get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// 复核时间
        /// </summary>
        [JsonProperty("ConfirmTime")]
        public string ConfirmTime{ get; set; }

        /// <summary>
        /// 用户部门id
        /// </summary>
        [JsonProperty("UserDepartmentId")]
        public string UserDepartmentId{ get; set; }

        /// <summary>
        /// 用户部门name
        /// </summary>
        [JsonProperty("UserDepartmentName")]
        public string UserDepartmentName{ get; set; }

        /// <summary>
        /// 设备部门id
        /// </summary>
        [JsonProperty("DeviceDepartmentId")]
        public string DeviceDepartmentId{ get; set; }

        /// <summary>
        /// 设备部门name	
        /// </summary>
        [JsonProperty("DeviceDepartmentName")]
        public string DeviceDepartmentName{ get; set; }

        /// <summary>
        /// 签名值
        /// </summary>
        [JsonProperty("SignValue")]
        public string SignValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "RealName", this.RealName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "FileCurr", this.FileCurr);
            this.SetParamSimple(map, prefix + "FileNew", this.FileNew);
            this.SetParamSimple(map, prefix + "Sid", this.Sid);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "FromIp", this.FromIp);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "ConfirmTime", this.ConfirmTime);
            this.SetParamSimple(map, prefix + "UserDepartmentId", this.UserDepartmentId);
            this.SetParamSimple(map, prefix + "UserDepartmentName", this.UserDepartmentName);
            this.SetParamSimple(map, prefix + "DeviceDepartmentId", this.DeviceDepartmentId);
            this.SetParamSimple(map, prefix + "DeviceDepartmentName", this.DeviceDepartmentName);
            this.SetParamSimple(map, prefix + "SignValue", this.SignValue);
        }
    }
}

