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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageRepoRegistryInfo : AbstractModel
    {
        
        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("RegistryId")]
        public ulong? RegistryId{ get; set; }

        /// <summary>
        /// 仓库名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 仓库类型，列表：harbor、tcr
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// 仓库url
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 网络类型，列表：public
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// 区域，列表：default
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// 仓库版本
        /// </summary>
        [JsonProperty("RegistryVersion")]
        public string RegistryVersion{ get; set; }

        /// <summary>
        /// 仓库连接错误信息，待废弃，请使用ConnDetectException
        /// </summary>
        [JsonProperty("ConnectMsg")]
        public string ConnectMsg{ get; set; }

        /// <summary>
        /// 联通性检测方式
        /// </summary>
        [JsonProperty("ConnDetectType")]
        public string ConnDetectType{ get; set; }

        /// <summary>
        /// 联通性检测主机数
        /// </summary>
        [JsonProperty("ConnDetectHostCount")]
        public ulong? ConnDetectHostCount{ get; set; }

        /// <summary>
        /// 联通性检测详情
        /// </summary>
        [JsonProperty("ConnDetectDetail")]
        public RegistryConnDetectResult[] ConnDetectDetail{ get; set; }

        /// <summary>
        /// tcr情况下的instance_id
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 最近同步成功时间
        /// </summary>
        [JsonProperty("LatestSyncTime")]
        public string LatestSyncTime{ get; set; }

        /// <summary>
        /// 同步状态
        /// </summary>
        [JsonProperty("SyncStatus")]
        public string SyncStatus{ get; set; }

        /// <summary>
        /// 同步失败原因
        /// </summary>
        [JsonProperty("SyncFailReason")]
        public string SyncFailReason{ get; set; }

        /// <summary>
        /// 同步失败解决方案
        /// </summary>
        [JsonProperty("SyncSolution")]
        public string SyncSolution{ get; set; }

        /// <summary>
        /// 同步失败信息
        /// </summary>
        [JsonProperty("SyncMessage")]
        public string SyncMessage{ get; set; }

        /// <summary>
        /// 同步方式，0全量同步，1增量同步	
        /// </summary>
        [JsonProperty("SyncMode")]
        public ulong? SyncMode{ get; set; }


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
            this.SetParamSimple(map, prefix + "ConnectMsg", this.ConnectMsg);
            this.SetParamSimple(map, prefix + "ConnDetectType", this.ConnDetectType);
            this.SetParamSimple(map, prefix + "ConnDetectHostCount", this.ConnDetectHostCount);
            this.SetParamArrayObj(map, prefix + "ConnDetectDetail.", this.ConnDetectDetail);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "LatestSyncTime", this.LatestSyncTime);
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
            this.SetParamSimple(map, prefix + "SyncFailReason", this.SyncFailReason);
            this.SetParamSimple(map, prefix + "SyncSolution", this.SyncSolution);
            this.SetParamSimple(map, prefix + "SyncMessage", this.SyncMessage);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
        }
    }
}

