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

namespace TencentCloud.Dasb.V20191018.Models
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
            this.SetParamSimple(map, prefix + "SignValue", this.SignValue);
        }
    }
}

