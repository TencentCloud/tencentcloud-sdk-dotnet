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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtectDirInfo : AbstractModel
    {
        
        /// <summary>
        /// 网站名称
        /// </summary>
        [JsonProperty("DirName")]
        public string DirName{ get; set; }

        /// <summary>
        /// 网站防护目录地址
        /// </summary>
        [JsonProperty("DirPath")]
        public string DirPath{ get; set; }

        /// <summary>
        /// 关联服务器数
        /// </summary>
        [JsonProperty("RelatedServerNum")]
        public ulong? RelatedServerNum{ get; set; }

        /// <summary>
        /// 防护服务器数
        /// </summary>
        [JsonProperty("ProtectServerNum")]
        public ulong? ProtectServerNum{ get; set; }

        /// <summary>
        /// 未防护服务器数
        /// </summary>
        [JsonProperty("NoProtectServerNum")]
        public ulong? NoProtectServerNum{ get; set; }

        /// <summary>
        /// 唯一ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 防护状态
        /// </summary>
        [JsonProperty("ProtectStatus")]
        public ulong? ProtectStatus{ get; set; }

        /// <summary>
        /// 防护异常
        /// </summary>
        [JsonProperty("ProtectException")]
        public ulong? ProtectException{ get; set; }

        /// <summary>
        /// 自动恢复开关 (Filters 过滤Quuid 时 返回) 默认0
        /// </summary>
        [JsonProperty("AutoRestoreSwitchStatus")]
        public ulong? AutoRestoreSwitchStatus{ get; set; }

        /// <summary>
        /// 首次开启防护时间
        /// </summary>
        [JsonProperty("FirstProtectTime")]
        public string FirstProtectTime{ get; set; }

        /// <summary>
        /// 最近开启防护时间
        /// </summary>
        [JsonProperty("LatestProtectTime")]
        public string LatestProtectTime{ get; set; }

        /// <summary>
        /// 防护文件类型
        /// </summary>
        [JsonProperty("ProtectFileType")]
        public string ProtectFileType{ get; set; }

        /// <summary>
        /// 防护文件总数
        /// </summary>
        [JsonProperty("ProtectFilesCount")]
        public long? ProtectFilesCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirName", this.DirName);
            this.SetParamSimple(map, prefix + "DirPath", this.DirPath);
            this.SetParamSimple(map, prefix + "RelatedServerNum", this.RelatedServerNum);
            this.SetParamSimple(map, prefix + "ProtectServerNum", this.ProtectServerNum);
            this.SetParamSimple(map, prefix + "NoProtectServerNum", this.NoProtectServerNum);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ProtectStatus", this.ProtectStatus);
            this.SetParamSimple(map, prefix + "ProtectException", this.ProtectException);
            this.SetParamSimple(map, prefix + "AutoRestoreSwitchStatus", this.AutoRestoreSwitchStatus);
            this.SetParamSimple(map, prefix + "FirstProtectTime", this.FirstProtectTime);
            this.SetParamSimple(map, prefix + "LatestProtectTime", this.LatestProtectTime);
            this.SetParamSimple(map, prefix + "ProtectFileType", this.ProtectFileType);
            this.SetParamSimple(map, prefix + "ProtectFilesCount", this.ProtectFilesCount);
        }
    }
}

