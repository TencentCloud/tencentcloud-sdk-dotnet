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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterSnapshotRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>快照名称</p>
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// <p>索引名称</p>
        /// </summary>
        [JsonProperty("Indices")]
        public string Indices{ get; set; }

        /// <summary>
        /// <p>0 腾讯云仓库; 1 客户仓库</p>
        /// </summary>
        [JsonProperty("EsRepositoryType")]
        public ulong? EsRepositoryType{ get; set; }

        /// <summary>
        /// <p>客户快照仓库名称</p>
        /// </summary>
        [JsonProperty("UserEsRepository")]
        public string UserEsRepository{ get; set; }

        /// <summary>
        /// <p>快照存储周期 单位天，范围[0, INF), 如果没有设置则默认7天</p>
        /// </summary>
        [JsonProperty("StorageDuration")]
        public ulong? StorageDuration{ get; set; }

        /// <summary>
        /// <p>备份锁定 0 不锁定; 1 锁定</p>
        /// </summary>
        [JsonProperty("CosRetention")]
        public ulong? CosRetention{ get; set; }

        /// <summary>
        /// <p>锁定截止日期 2022-12-10T08:34:48.000Z</p>
        /// </summary>
        [JsonProperty("RetainUntilDate")]
        public string RetainUntilDate{ get; set; }

        /// <summary>
        /// <p>锁定宽限期,单位天</p>
        /// </summary>
        [JsonProperty("RetentionGraceTime")]
        public ulong? RetentionGraceTime{ get; set; }

        /// <summary>
        /// <p>跨地域备份 0 不跨地域; 1 跨地域</p>
        /// </summary>
        [JsonProperty("RemoteCos")]
        public ulong? RemoteCos{ get; set; }

        /// <summary>
        /// <p>跨地域备份地域名称 ap-guangzhou</p>
        /// </summary>
        [JsonProperty("RemoteCosRegion")]
        public string RemoteCosRegion{ get; set; }

        /// <summary>
        /// <p>cos多AZ备份 0 单AZ; 1 多AZ</p>
        /// </summary>
        [JsonProperty("MultiAz")]
        public ulong? MultiAz{ get; set; }

        /// <summary>
        /// <p>快照创建速率（单位mb）</p>
        /// </summary>
        [JsonProperty("MaxSnapshotPerSec")]
        public string MaxSnapshotPerSec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "Indices", this.Indices);
            this.SetParamSimple(map, prefix + "EsRepositoryType", this.EsRepositoryType);
            this.SetParamSimple(map, prefix + "UserEsRepository", this.UserEsRepository);
            this.SetParamSimple(map, prefix + "StorageDuration", this.StorageDuration);
            this.SetParamSimple(map, prefix + "CosRetention", this.CosRetention);
            this.SetParamSimple(map, prefix + "RetainUntilDate", this.RetainUntilDate);
            this.SetParamSimple(map, prefix + "RetentionGraceTime", this.RetentionGraceTime);
            this.SetParamSimple(map, prefix + "RemoteCos", this.RemoteCos);
            this.SetParamSimple(map, prefix + "RemoteCosRegion", this.RemoteCosRegion);
            this.SetParamSimple(map, prefix + "MultiAz", this.MultiAz);
            this.SetParamSimple(map, prefix + "MaxSnapshotPerSec", this.MaxSnapshotPerSec);
        }
    }
}

