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

namespace TencentCloud.Tics.V20181115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileInfoType : AbstractModel
    {
        
        /// <summary>
        /// 判定渠道
        /// </summary>
        [JsonProperty("DetectId")]
        public string DetectId{ get; set; }

        /// <summary>
        /// 检测优先级
        /// </summary>
        [JsonProperty("DetectPriority")]
        public string DetectPriority{ get; set; }

        /// <summary>
        /// 引擎优先级
        /// </summary>
        [JsonProperty("EnginePriority")]
        public string EnginePriority{ get; set; }

        /// <summary>
        /// 样本是否存在
        /// </summary>
        [JsonProperty("FileExist")]
        public string FileExist{ get; set; }

        /// <summary>
        /// 文件上传
        /// </summary>
        [JsonProperty("FileForceUpload")]
        public string FileForceUpload{ get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonProperty("FileSize")]
        public string FileSize{ get; set; }

        /// <summary>
        /// 文件上传时间
        /// </summary>
        [JsonProperty("FileupTime")]
        public string FileupTime{ get; set; }

        /// <summary>
        /// 病毒文件全名
        /// </summary>
        [JsonProperty("FullVirusName")]
        public string FullVirusName{ get; set; }

        /// <summary>
        /// IDC位置
        /// </summary>
        [JsonProperty("IdcPosition")]
        public string IdcPosition{ get; set; }

        /// <summary>
        /// 文件md5值
        /// </summary>
        [JsonProperty("Md5Type")]
        public string Md5Type{ get; set; }

        /// <summary>
        /// PE结构是否存在
        /// </summary>
        [JsonProperty("PeExist")]
        public string PeExist{ get; set; }

        /// <summary>
        /// PE结构上传
        /// </summary>
        [JsonProperty("PeForceUpload")]
        public string PeForceUpload{ get; set; }

        /// <summary>
        /// 安全性等级
        /// </summary>
        [JsonProperty("SafeLevel")]
        public string SafeLevel{ get; set; }

        /// <summary>
        /// 扫描时间
        /// </summary>
        [JsonProperty("ScanModiTime")]
        public string ScanModiTime{ get; set; }

        /// <summary>
        /// 子判定渠道
        /// </summary>
        [JsonProperty("SubdetectId")]
        public string SubdetectId{ get; set; }

        /// <summary>
        /// 病毒名
        /// </summary>
        [JsonProperty("UserDefName")]
        public string UserDefName{ get; set; }

        /// <summary>
        /// 病毒类型
        /// </summary>
        [JsonProperty("VirusType")]
        public string VirusType{ get; set; }

        /// <summary>
        /// 白名单分数
        /// </summary>
        [JsonProperty("WhiteScore")]
        public string WhiteScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DetectId", this.DetectId);
            this.SetParamSimple(map, prefix + "DetectPriority", this.DetectPriority);
            this.SetParamSimple(map, prefix + "EnginePriority", this.EnginePriority);
            this.SetParamSimple(map, prefix + "FileExist", this.FileExist);
            this.SetParamSimple(map, prefix + "FileForceUpload", this.FileForceUpload);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FileupTime", this.FileupTime);
            this.SetParamSimple(map, prefix + "FullVirusName", this.FullVirusName);
            this.SetParamSimple(map, prefix + "IdcPosition", this.IdcPosition);
            this.SetParamSimple(map, prefix + "Md5Type", this.Md5Type);
            this.SetParamSimple(map, prefix + "PeExist", this.PeExist);
            this.SetParamSimple(map, prefix + "PeForceUpload", this.PeForceUpload);
            this.SetParamSimple(map, prefix + "SafeLevel", this.SafeLevel);
            this.SetParamSimple(map, prefix + "ScanModiTime", this.ScanModiTime);
            this.SetParamSimple(map, prefix + "SubdetectId", this.SubdetectId);
            this.SetParamSimple(map, prefix + "UserDefName", this.UserDefName);
            this.SetParamSimple(map, prefix + "VirusType", this.VirusType);
            this.SetParamSimple(map, prefix + "WhiteScore", this.WhiteScore);
        }
    }
}

