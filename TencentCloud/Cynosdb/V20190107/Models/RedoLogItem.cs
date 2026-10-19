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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RedoLogItem : AbstractModel
    {
        
        /// <summary>
        /// <p>文件名</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>文件大小</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// <p>备份时间</p>
        /// </summary>
        [JsonProperty("BackupTime")]
        public string BackupTime{ get; set; }

        /// <summary>
        /// <p>redoLogId</p>
        /// </summary>
        [JsonProperty("RedoLogId")]
        public long? RedoLogId{ get; set; }

        /// <summary>
        /// <p>跨地域信息</p>
        /// </summary>
        [JsonProperty("RedoCrossRegions")]
        public BackupRegionAndIds[] RedoCrossRegions{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>完成时间</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>保险箱信息</p>
        /// </summary>
        [JsonProperty("VaultInfos")]
        public VaultInfo[] VaultInfos{ get; set; }

        /// <summary>
        /// <p>备份投递状态</p>
        /// </summary>
        [JsonProperty("CopyStatus")]
        public string CopyStatus{ get; set; }

        /// <summary>
        /// <p>加密秘钥key</p>
        /// </summary>
        [JsonProperty("EncryptKeyId")]
        public string EncryptKeyId{ get; set; }

        /// <summary>
        /// <p>加密秘钥地域</p>
        /// </summary>
        [JsonProperty("EncryptRegion")]
        public string EncryptRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "RedoLogId", this.RedoLogId);
            this.SetParamArrayObj(map, prefix + "RedoCrossRegions.", this.RedoCrossRegions);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamArrayObj(map, prefix + "VaultInfos.", this.VaultInfos);
            this.SetParamSimple(map, prefix + "CopyStatus", this.CopyStatus);
            this.SetParamSimple(map, prefix + "EncryptKeyId", this.EncryptKeyId);
            this.SetParamSimple(map, prefix + "EncryptRegion", this.EncryptRegion);
        }
    }
}

