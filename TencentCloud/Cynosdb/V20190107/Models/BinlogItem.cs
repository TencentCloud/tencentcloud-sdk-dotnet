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

    public class BinlogItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Binlog文件名称</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>文件大小，单位：字节</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// <p>事务最早时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>事务最晚时间</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>Binlog文件ID</p>
        /// </summary>
        [JsonProperty("BinlogId")]
        public long? BinlogId{ get; set; }

        /// <summary>
        /// <p>binlog所跨地域</p>
        /// </summary>
        [JsonProperty("CrossRegions")]
        public string[] CrossRegions{ get; set; }

        /// <summary>
        /// <p>备份投递状态</p>
        /// </summary>
        [JsonProperty("CopyStatus")]
        public string CopyStatus{ get; set; }

        /// <summary>
        /// <p>保险箱信息</p>
        /// </summary>
        [JsonProperty("VaultInfos")]
        public VaultInfo[] VaultInfos{ get; set; }

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
        /// <p>备份的地域分布信息</p>
        /// </summary>
        [JsonProperty("ExistRegions")]
        public BinlogRegionInfo[] ExistRegions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "BinlogId", this.BinlogId);
            this.SetParamArraySimple(map, prefix + "CrossRegions.", this.CrossRegions);
            this.SetParamSimple(map, prefix + "CopyStatus", this.CopyStatus);
            this.SetParamArrayObj(map, prefix + "VaultInfos.", this.VaultInfos);
            this.SetParamSimple(map, prefix + "EncryptKeyId", this.EncryptKeyId);
            this.SetParamSimple(map, prefix + "EncryptRegion", this.EncryptRegion);
            this.SetParamArrayObj(map, prefix + "ExistRegions.", this.ExistRegions);
        }
    }
}

