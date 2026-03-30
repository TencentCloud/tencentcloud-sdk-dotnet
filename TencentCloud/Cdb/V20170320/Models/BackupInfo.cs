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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>备份文件名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>备份文件大小，单位：Byte</p>
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// <p>备份快照时间，时间格式：2016-03-17 02:10:37</p>
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// <p>下载地址</p>
        /// </summary>
        [JsonProperty("IntranetUrl")]
        public string IntranetUrl{ get; set; }

        /// <summary>
        /// <p>下载地址</p>
        /// </summary>
        [JsonProperty("InternetUrl")]
        public string InternetUrl{ get; set; }

        /// <summary>
        /// <p>日志具体类型。可能的值有 &quot;logical&quot;: 逻辑冷备， &quot;physical&quot;: 物理冷备。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>备份子任务的ID，删除备份文件时使用</p>
        /// </summary>
        [JsonProperty("BackupId")]
        public long? BackupId{ get; set; }

        /// <summary>
        /// <p>备份任务状态。可能的值有 &quot;SUCCESS&quot;: 备份成功， &quot;FAILED&quot;: 备份失败， &quot;RUNNING&quot;: 备份进行中。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>备份任务的完成时间</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>（该值将废弃，不建议使用）备份的创建者，可能的值：SYSTEM - 系统创建，Uin - 发起者Uin值。</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>备份任务的开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>备份方法。可能的值有 &quot;full&quot;: 全量备份， &quot;partial&quot;: 部分备份。</p>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>备份方式。可能的值有 &quot;manual&quot;: 手动备份， &quot;automatic&quot;: 自动备份。</p>
        /// </summary>
        [JsonProperty("Way")]
        public string Way{ get; set; }

        /// <summary>
        /// <p>手动备份别名</p>
        /// </summary>
        [JsonProperty("ManualBackupName")]
        public string ManualBackupName{ get; set; }

        /// <summary>
        /// <p>备份保留类型，save_mode_regular - 常规保存备份，save_mode_period - 定期保存备份</p>
        /// </summary>
        [JsonProperty("SaveMode")]
        public string SaveMode{ get; set; }

        /// <summary>
        /// <p>本地备份所在地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>异地备份详细信息</p>
        /// </summary>
        [JsonProperty("RemoteInfo")]
        public RemoteBackupInfo[] RemoteInfo{ get; set; }

        /// <summary>
        /// <p>存储方式，0-常规存储，1-归档存储，2-标准存储，默认为0</p>
        /// </summary>
        [JsonProperty("CosStorageType")]
        public long? CosStorageType{ get; set; }

        /// <summary>
        /// <p>实例 ID，格式如：cdb-c1nl9rpv。与云数据库控制台页面中显示的实例 ID 相同。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>备份完成进度</p>
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// <p>备份文件是否加密， on-加密， off-未加密</p>
        /// </summary>
        [JsonProperty("EncryptionFlag")]
        public string EncryptionFlag{ get; set; }

        /// <summary>
        /// <p>备份GTID点位</p>
        /// </summary>
        [JsonProperty("ExecutedGTIDSet")]
        public string ExecutedGTIDSet{ get; set; }

        /// <summary>
        /// <p>备份文件MD5值</p>
        /// </summary>
        [JsonProperty("MD5")]
        public string MD5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Way", this.Way);
            this.SetParamSimple(map, prefix + "ManualBackupName", this.ManualBackupName);
            this.SetParamSimple(map, prefix + "SaveMode", this.SaveMode);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "RemoteInfo.", this.RemoteInfo);
            this.SetParamSimple(map, prefix + "CosStorageType", this.CosStorageType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "EncryptionFlag", this.EncryptionFlag);
            this.SetParamSimple(map, prefix + "ExecutedGTIDSet", this.ExecutedGTIDSet);
            this.SetParamSimple(map, prefix + "MD5", this.MD5);
        }
    }
}

