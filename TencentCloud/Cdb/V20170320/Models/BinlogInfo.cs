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

    public class BinlogInfo : AbstractModel
    {
        
        /// <summary>
        /// binlog 日志备份文件名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 备份文件大小，单位：Byte
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 文件存储时间，时间格式：2016-03-17 02:10:37
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
        /// 日志具体类型，可能的值有：binlog - 二进制日志
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// binlog 文件起始时间
        /// </summary>
        [JsonProperty("BinlogStartTime")]
        public string BinlogStartTime{ get; set; }

        /// <summary>
        /// binlog 文件截止时间
        /// </summary>
        [JsonProperty("BinlogFinishTime")]
        public string BinlogFinishTime{ get; set; }

        /// <summary>
        /// 本地binlog文件所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 备份任务状态。可能的值有 "SUCCESS": 备份成功， "FAILED": 备份失败， "RUNNING": 备份进行中。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// binlog异地备份详细信息
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
            this.SetParamSimple(map, prefix + "BinlogStartTime", this.BinlogStartTime);
            this.SetParamSimple(map, prefix + "BinlogFinishTime", this.BinlogFinishTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "RemoteInfo.", this.RemoteInfo);
            this.SetParamSimple(map, prefix + "CosStorageType", this.CosStorageType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

