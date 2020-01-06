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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupInfo : AbstractModel
    {
        
        /// <summary>
        /// 备份文件名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 备份文件大小，单位：Byte
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 备份快照时间，时间格式：2016-03-17 02:10:37
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 内网下载地址
        /// </summary>
        [JsonProperty("IntranetUrl")]
        public string IntranetUrl{ get; set; }

        /// <summary>
        /// 外网下载地址
        /// </summary>
        [JsonProperty("InternetUrl")]
        public string InternetUrl{ get; set; }

        /// <summary>
        /// 日志具体类型，可能的值有：logic - 逻辑冷备，physical - 物理冷备
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 备份子任务的ID，删除备份文件时使用
        /// </summary>
        [JsonProperty("BackupId")]
        public long? BackupId{ get; set; }

        /// <summary>
        /// 备份任务状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 备份任务的完成时间
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// 备份的创建者，可能的值：SYSTEM - 系统创建，Uin - 发起者Uin值
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "IntranetUrl", this.IntranetUrl);
            this.SetParamSimple(map, prefix + "InternetUrl", this.InternetUrl);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
        }
    }
}

