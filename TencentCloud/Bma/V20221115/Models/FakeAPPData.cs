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

namespace TencentCloud.Bma.V20221115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FakeAPPData : AbstractModel
    {
        
        /// <summary>
        /// 仿冒应用id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FakeAPPId")]
        public long? FakeAPPId{ get; set; }

        /// <summary>
        /// 品牌名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrandName")]
        public string BrandName{ get; set; }

        /// <summary>
        /// 仿冒来源：0-系统检测 1-人工举报
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Origin")]
        public long? Origin{ get; set; }

        /// <summary>
        /// 仿冒应用名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FakeAPPName")]
        public string FakeAPPName{ get; set; }

        /// <summary>
        /// 仿冒应用包名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FakeAPPPackageName")]
        public string FakeAPPPackageName{ get; set; }

        /// <summary>
        /// 仿冒应用证书
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FakeAPPCert")]
        public string FakeAPPCert{ get; set; }

        /// <summary>
        /// 仿冒应用大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FakeAPPSize")]
        public string FakeAPPSize{ get; set; }

        /// <summary>
        /// 热度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Heat")]
        public long? Heat{ get; set; }

        /// <summary>
        /// 协助处置状态：0-未处置 1-处置中 2-处置成功 3-处置失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockStatus")]
        public long? BlockStatus{ get; set; }

        /// <summary>
        /// 协助处置状态说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockNote")]
        public string BlockNote{ get; set; }

        /// <summary>
        /// 关停状态：0-未关停 1-关停中 2-关停成功 3-关停失败 4-重复上架
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineStatus")]
        public long? OfflineStatus{ get; set; }

        /// <summary>
        /// 关停状态说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineNote")]
        public string OfflineNote{ get; set; }

        /// <summary>
        /// app来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownloadWay")]
        public string DownloadWay{ get; set; }

        /// <summary>
        /// 新增时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// App下载链接
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownloadCosURL")]
        public string DownloadCosURL{ get; set; }

        /// <summary>
        /// 资质证明状态:0-不可用 1-可用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificationStatus")]
        public long? CertificationStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FakeAPPId", this.FakeAPPId);
            this.SetParamSimple(map, prefix + "BrandName", this.BrandName);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "FakeAPPName", this.FakeAPPName);
            this.SetParamSimple(map, prefix + "FakeAPPPackageName", this.FakeAPPPackageName);
            this.SetParamSimple(map, prefix + "FakeAPPCert", this.FakeAPPCert);
            this.SetParamSimple(map, prefix + "FakeAPPSize", this.FakeAPPSize);
            this.SetParamSimple(map, prefix + "Heat", this.Heat);
            this.SetParamSimple(map, prefix + "BlockStatus", this.BlockStatus);
            this.SetParamSimple(map, prefix + "BlockNote", this.BlockNote);
            this.SetParamSimple(map, prefix + "OfflineStatus", this.OfflineStatus);
            this.SetParamSimple(map, prefix + "OfflineNote", this.OfflineNote);
            this.SetParamSimple(map, prefix + "DownloadWay", this.DownloadWay);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "DownloadCosURL", this.DownloadCosURL);
            this.SetParamSimple(map, prefix + "CertificationStatus", this.CertificationStatus);
        }
    }
}

