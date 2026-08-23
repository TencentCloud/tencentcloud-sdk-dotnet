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

    public class ImageRegistryInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>仓库id</p>
        /// </summary>
        [JsonProperty("RegistryId")]
        public ulong? RegistryId{ get; set; }

        /// <summary>
        /// <p>仓库名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>仓库类型</p>
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// <p>仓库url</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>网络连接类型</p>
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// <p>仓库所在地域</p>
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// <p>仓库版本</p>
        /// </summary>
        [JsonProperty("RegistryVersion")]
        public string RegistryVersion{ get; set; }

        /// <summary>
        /// <p>仓库实例id</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>最后同步时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("LatestSyncTime")]
        public string LatestSyncTime{ get; set; }

        /// <summary>
        /// <p>同步失败解决方案</p>
        /// </summary>
        [JsonProperty("SyncSolution")]
        public string SyncSolution{ get; set; }

        /// <summary>
        /// <p>同步方式</p>
        /// </summary>
        [JsonProperty("SyncMode")]
        public ulong? SyncMode{ get; set; }

        /// <summary>
        /// <p>连接探测详情</p>
        /// </summary>
        [JsonProperty("ConnDetectDetail")]
        public RegistryConnDetectResult[] ConnDetectDetail{ get; set; }

        /// <summary>
        /// <p>连接类型</p>
        /// </summary>
        [JsonProperty("ConnDetectType")]
        public string ConnDetectType{ get; set; }

        /// <summary>
        /// <p>仓库所属账号名</p>
        /// </summary>
        [JsonProperty("OwnerAccountName")]
        public string OwnerAccountName{ get; set; }

        /// <summary>
        /// <p>仓库所属账号appid</p>
        /// </summary>
        [JsonProperty("OwnerAppId")]
        public ulong? OwnerAppId{ get; set; }

        /// <summary>
        /// <p>仓库所属账号uin</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>同步状态</p><p>枚举值：</p><ul><li>doing： 同步中</li><li>success： 同步成功</li><li>failed： 同步失败</li></ul>
        /// </summary>
        [JsonProperty("SyncStatus")]
        public string SyncStatus{ get; set; }

        /// <summary>
        /// <p>同步失败原因</p>
        /// </summary>
        [JsonProperty("SyncFailReason")]
        public string SyncFailReason{ get; set; }

        /// <summary>
        /// <p>地域信息</p>
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// <p>镜像仓库用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "RegistryRegion", this.RegistryRegion);
            this.SetParamSimple(map, prefix + "RegistryVersion", this.RegistryVersion);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "LatestSyncTime", this.LatestSyncTime);
            this.SetParamSimple(map, prefix + "SyncSolution", this.SyncSolution);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamArrayObj(map, prefix + "ConnDetectDetail.", this.ConnDetectDetail);
            this.SetParamSimple(map, prefix + "ConnDetectType", this.ConnDetectType);
            this.SetParamSimple(map, prefix + "OwnerAccountName", this.OwnerAccountName);
            this.SetParamSimple(map, prefix + "OwnerAppId", this.OwnerAppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
            this.SetParamSimple(map, prefix + "SyncFailReason", this.SyncFailReason);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
        }
    }
}

