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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchFileBySidResult : AbstractModel
    {
        
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
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "FileCurr", this.FileCurr);
            this.SetParamSimple(map, prefix + "FileNew", this.FileNew);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "SignValue", this.SignValue);
        }
    }
}

