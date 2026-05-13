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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupLog : AbstractModel
    {
        
        /// <summary>
        /// 索引
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 索引开始时间
        /// </summary>
        [JsonProperty("IndexStartTime")]
        public long? IndexStartTime{ get; set; }

        /// <summary>
        /// 索引结束时间
        /// </summary>
        [JsonProperty("IndexEndTime")]
        public long? IndexEndTime{ get; set; }

        /// <summary>
        /// 备份后压缩的大小，单位M
        /// </summary>
        [JsonProperty("BackupSize")]
        public long? BackupSize{ get; set; }

        /// <summary>
        /// 日志状态 0备份未完成， 1备份文件，2恢复中，3已恢复，4.已删除
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 恢复剩余的分钟数，分钟，需要前端转换
        /// </summary>
        [JsonProperty("RestoreProcessRemindTime")]
        public long? RestoreProcessRemindTime{ get; set; }

        /// <summary>
        /// 恢复日志保留的时间
        /// </summary>
        [JsonProperty("RestoreRemindTime")]
        public long? RestoreRemindTime{ get; set; }

        /// <summary>
        /// 恢复索引大小
        /// </summary>
        [JsonProperty("RestoreIndexSize")]
        public long? RestoreIndexSize{ get; set; }

        /// <summary>
        /// 恢复日志执行结束时间
        /// </summary>
        [JsonProperty("RestoreEndTime")]
        public long? RestoreEndTime{ get; set; }

        /// <summary>
        /// 备份所属的appId
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 备份所属的资产ID
        /// </summary>
        [JsonProperty("AssetId")]
        public ulong? AssetId{ get; set; }

        /// <summary>
        /// 账号昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 资产所属账号uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "IndexStartTime", this.IndexStartTime);
            this.SetParamSimple(map, prefix + "IndexEndTime", this.IndexEndTime);
            this.SetParamSimple(map, prefix + "BackupSize", this.BackupSize);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RestoreProcessRemindTime", this.RestoreProcessRemindTime);
            this.SetParamSimple(map, prefix + "RestoreRemindTime", this.RestoreRemindTime);
            this.SetParamSimple(map, prefix + "RestoreIndexSize", this.RestoreIndexSize);
            this.SetParamSimple(map, prefix + "RestoreEndTime", this.RestoreEndTime);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
        }
    }
}

