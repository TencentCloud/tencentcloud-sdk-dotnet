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

    public class SearchFileBySidResult : AbstractModel
    {
        
        /// <summary>
        /// 会话Id
        /// </summary>
        [JsonProperty("Sid")]
        public string Sid{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 资产账号
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// 来源Ip
        /// </summary>
        [JsonProperty("FromIp")]
        public string FromIp{ get; set; }

        /// <summary>
        /// 文件操作时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 1-上传文件 2-下载文件 3-删除文件 4-移动文件 5-重命名文件 6-新建文件夹 7-移动文件夹 8-重命名文件夹 9-删除文件夹
        /// </summary>
        [JsonProperty("Method")]
        public long? Method{ get; set; }

        /// <summary>
        /// 文件传输协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// method为上传、下载、删除时文件在服务器上的位置, 或重命名、移动文件前文件的位置
        /// </summary>
        [JsonProperty("FileCurr")]
        public string FileCurr{ get; set; }

        /// <summary>
        /// method为重命名、移动文件时代表移动后的新位置.其他情况为null
        /// </summary>
        [JsonProperty("FileNew")]
        public string FileNew{ get; set; }

        /// <summary>
        /// method为上传文件、下载文件、删除文件时显示文件大小。其他情况为null
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 堡垒机拦截情况, 1-已执行，  2-被阻断
        /// </summary>
        [JsonProperty("Action")]
        public long? Action{ get; set; }

        /// <summary>
        /// 复核时间，当Action是3时，需有复核时间
        /// </summary>
        [JsonProperty("ConfirmTime")]
        public string ConfirmTime{ get; set; }

        /// <summary>
        /// 用户部门Id
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
            this.SetParamSimple(map, prefix + "Sid", this.Sid);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "FromIp", this.FromIp);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "FileCurr", this.FileCurr);
            this.SetParamSimple(map, prefix + "FileNew", this.FileNew);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "ConfirmTime", this.ConfirmTime);
            this.SetParamSimple(map, prefix + "UserDepartmentId", this.UserDepartmentId);
            this.SetParamSimple(map, prefix + "UserDepartmentName", this.UserDepartmentName);
            this.SetParamSimple(map, prefix + "DeviceDepartmentId", this.DeviceDepartmentId);
            this.SetParamSimple(map, prefix + "DeviceDepartmentName", this.DeviceDepartmentName);
            this.SetParamSimple(map, prefix + "SignValue", this.SignValue);
        }
    }
}

