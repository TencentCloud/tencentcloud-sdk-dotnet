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
        /// 下载地址
        /// </summary>
        [JsonProperty("IntranetUrl")]
        public string IntranetUrl{ get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        [JsonProperty("InternetUrl")]
        public string InternetUrl{ get; set; }

        /// <summary>
        /// 日志具体类型。可能的值有 "logical": 逻辑冷备， "physical": 物理冷备。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 备份子任务的ID，删除备份文件时使用
        /// </summary>
        [JsonProperty("BackupId")]
        public long? BackupId{ get; set; }

        /// <summary>
        /// 备份任务状态。可能的值有 "SUCCESS": 备份成功， "FAILED": 备份失败， "RUNNING": 备份进行中。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 备份任务的完成时间
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// （该值将废弃，不建议使用）备份的创建者，可能的值：SYSTEM - 系统创建，Uin - 发起者Uin值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 备份任务的开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 备份方法。可能的值有 "full": 全量备份， "partial": 部分备份。
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 备份方式。可能的值有 "manual": 手动备份， "automatic": 自动备份。
        /// </summary>
        [JsonProperty("Way")]
        public string Way{ get; set; }

        /// <summary>
        /// 手动备份别名
        /// </summary>
        [JsonProperty("ManualBackupName")]
        public string ManualBackupName{ get; set; }

        /// <summary>
        /// 备份保留类型，save_mode_regular - 常规保存备份，save_mode_period - 定期保存备份
        /// </summary>
        [JsonProperty("SaveMode")]
        public string SaveMode{ get; set; }

        /// <summary>
        /// 本地备份所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 异地备份详细信息
        /// </summary>
        [JsonProperty("RemoteInfo")]
        public RemoteBackupInfo[] RemoteInfo{ get; set; }

        /// <summary>
        /// 存储方式，0-常规存储，1-归档存储，2-标准存储，默认为0
        /// </summary>
        [JsonProperty("CosStorageType")]
        public long? CosStorageType{ get; set; }

        /// <summary>
        /// 实例 ID，格式如：cdb-c1nl9rpv。与云数据库控制台页面中显示的实例 ID 相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 备份文件是否加密， on-加密， off-未加密
        /// </summary>
        [JsonProperty("EncryptionFlag")]
        public string EncryptionFlag{ get; set; }

        /// <summary>
        /// 备份GTID点位
        /// </summary>
        [JsonProperty("ExecutedGTIDSet")]
        public string ExecutedGTIDSet{ get; set; }

        /// <summary>
        /// 备份文件MD5值
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
            this.SetParamSimple(map, prefix + "EncryptionFlag", this.EncryptionFlag);
            this.SetParamSimple(map, prefix + "ExecutedGTIDSet", this.ExecutedGTIDSet);
            this.SetParamSimple(map, prefix + "MD5", this.MD5);
        }
    }
}

