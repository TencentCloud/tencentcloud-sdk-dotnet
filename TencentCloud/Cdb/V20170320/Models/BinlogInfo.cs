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
        /// <p>binlog 日志备份文件名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>备份文件大小，单位：Byte</p>
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// <p>文件存储时间，时间格式：2016-03-17 02:10:37</p>
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// <p>下载地址<br>说明：此下载地址和参数 InternetUrl 的下载地址一样。</p>
        /// </summary>
        [JsonProperty("IntranetUrl")]
        public string IntranetUrl{ get; set; }

        /// <summary>
        /// <p>下载地址<br>说明：此下载地址和参数 IntranetUrl 的下载地址一样。</p>
        /// </summary>
        [JsonProperty("InternetUrl")]
        public string InternetUrl{ get; set; }

        /// <summary>
        /// <p>日志具体类型，可能的值有：binlog - 二进制日志</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>binlog 文件起始时间</p>
        /// </summary>
        [JsonProperty("BinlogStartTime")]
        public string BinlogStartTime{ get; set; }

        /// <summary>
        /// <p>binlog 文件截止时间</p>
        /// </summary>
        [JsonProperty("BinlogFinishTime")]
        public string BinlogFinishTime{ get; set; }

        /// <summary>
        /// <p>本地binlog文件所在地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>备份任务状态。可能的值有 &quot;SUCCESS&quot;: 备份成功， &quot;FAILED&quot;: 备份失败， &quot;RUNNING&quot;: 备份进行中。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>binlog异地备份详细信息</p>
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
        [System.Obsolete]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>备份完成进度</p>
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }


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
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
        }
    }
}

