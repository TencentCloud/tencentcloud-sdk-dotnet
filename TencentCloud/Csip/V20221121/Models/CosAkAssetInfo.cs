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

    public class CosAkAssetInfo : AbstractModel
    {
        
        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// ak id
        /// </summary>
        [JsonProperty("AkId")]
        public string AkId{ get; set; }

        /// <summary>
        /// ak名称
        /// </summary>
        [JsonProperty("AkName")]
        public string AkName{ get; set; }

        /// <summary>
        /// ak备注
        /// </summary>
        [JsonProperty("AkRemark")]
        public string AkRemark{ get; set; }

        /// <summary>
        /// ak所属uin
        /// </summary>
        [JsonProperty("AkOwnerUin")]
        public string AkOwnerUin{ get; set; }

        /// <summary>
        /// ak类型 1 主 2 子
        /// </summary>
        [JsonProperty("AkOwnerType")]
        public long? AkOwnerType{ get; set; }

        /// <summary>
        /// ak所属账号名
        /// </summary>
        [JsonProperty("AkOwnerName")]
        public string AkOwnerName{ get; set; }

        /// <summary>
        /// ak主账号名
        /// </summary>
        [JsonProperty("AkMainOwnerName")]
        public string AkMainOwnerName{ get; set; }

        /// <summary>
        /// ak关联桶集合
        /// </summary>
        [JsonProperty("AkRelBucketSet")]
        public string[] AkRelBucketSet{ get; set; }

        /// <summary>
        /// ak关联告警集合
        /// </summary>
        [JsonProperty("AkRelAlarmSet")]
        public CosRiskInfo[] AkRelAlarmSet{ get; set; }

        /// <summary>
        /// Ak关联ip数
        /// </summary>
        [JsonProperty("AkRelIpCount")]
        public ulong? AkRelIpCount{ get; set; }

        /// <summary>
        /// ak状态 0 禁用 1 启用
        /// </summary>
        [JsonProperty("AkStatus")]
        public long? AkStatus{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTimestamp")]
        public ulong? CreateTimestamp{ get; set; }

        /// <summary>
        /// 最后访问时间
        /// </summary>
        [JsonProperty("LastAccessTimestamp")]
        public ulong? LastAccessTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AkId", this.AkId);
            this.SetParamSimple(map, prefix + "AkName", this.AkName);
            this.SetParamSimple(map, prefix + "AkRemark", this.AkRemark);
            this.SetParamSimple(map, prefix + "AkOwnerUin", this.AkOwnerUin);
            this.SetParamSimple(map, prefix + "AkOwnerType", this.AkOwnerType);
            this.SetParamSimple(map, prefix + "AkOwnerName", this.AkOwnerName);
            this.SetParamSimple(map, prefix + "AkMainOwnerName", this.AkMainOwnerName);
            this.SetParamArraySimple(map, prefix + "AkRelBucketSet.", this.AkRelBucketSet);
            this.SetParamArrayObj(map, prefix + "AkRelAlarmSet.", this.AkRelAlarmSet);
            this.SetParamSimple(map, prefix + "AkRelIpCount", this.AkRelIpCount);
            this.SetParamSimple(map, prefix + "AkStatus", this.AkStatus);
            this.SetParamSimple(map, prefix + "CreateTimestamp", this.CreateTimestamp);
            this.SetParamSimple(map, prefix + "LastAccessTimestamp", this.LastAccessTimestamp);
        }
    }
}

