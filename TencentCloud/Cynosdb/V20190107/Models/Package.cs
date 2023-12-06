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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Package : AbstractModel
    {
        
        /// <summary>
        /// AppID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 资源包唯一ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 资源包名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// 资源包类型
        /// CCU-计算资源包，DISK-存储资源包
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 资源包使用地域
        /// china-中国内地通用，overseas-港澳台及海外通用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string PackageRegion{ get; set; }

        /// <summary>
        /// 资源包状态
        /// creating-创建中；
        /// using-使用中；
        /// expired-已过期；
        /// normal_finish-使用完；
        /// apply_refund-申请退费中；
        /// refund-已退费。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 资源包总量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageTotalSpec")]
        public float? PackageTotalSpec{ get; set; }

        /// <summary>
        /// 资源包已使用量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageUsedSpec")]
        public float? PackageUsedSpec{ get; set; }

        /// <summary>
        /// 是否还有库存余量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasQuota")]
        public bool? HasQuota{ get; set; }

        /// <summary>
        /// 绑定实例信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BindInstanceInfos")]
        public BindInstanceInfo[] BindInstanceInfos{ get; set; }

        /// <summary>
        /// 生效时间：2022-07-01 00:00:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 失效时间：2022-08-01 00:00:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 资源包历史绑定（已解绑）实例信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HistoryBindResourceInfos")]
        public BindInstanceInfo[] HistoryBindResourceInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "PackageRegion", this.PackageRegion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PackageTotalSpec", this.PackageTotalSpec);
            this.SetParamSimple(map, prefix + "PackageUsedSpec", this.PackageUsedSpec);
            this.SetParamSimple(map, prefix + "HasQuota", this.HasQuota);
            this.SetParamArrayObj(map, prefix + "BindInstanceInfos.", this.BindInstanceInfos);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamArrayObj(map, prefix + "HistoryBindResourceInfos.", this.HistoryBindResourceInfos);
        }
    }
}

