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

namespace TencentCloud.Bma.V20221115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FakeURLData : AbstractModel
    {
        
        /// <summary>
        /// 仿冒网址id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FakeURLId")]
        public long? FakeURLId{ get; set; }

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
        /// 仿冒网址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FakeURL")]
        public string FakeURL{ get; set; }

        /// <summary>
        /// 仿冒域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FakeDomain")]
        public string FakeDomain{ get; set; }

        /// <summary>
        /// 热度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Heat")]
        public long? Heat{ get; set; }

        /// <summary>
        /// 拦截处置状态：0-未处置 1-处置中 2-处置成功 3-处置失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockStatus")]
        public long? BlockStatus{ get; set; }

        /// <summary>
        /// 拦截处置状态说明
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
        /// ip地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// ip地理位置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPLocation")]
        public string IPLocation{ get; set; }

        /// <summary>
        /// 网站所属单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebCompany")]
        public string WebCompany{ get; set; }

        /// <summary>
        /// 网站性质
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebAttribute")]
        public string WebAttribute{ get; set; }

        /// <summary>
        /// 网站名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebName")]
        public string WebName{ get; set; }

        /// <summary>
        /// 备案号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebICP")]
        public string WebICP{ get; set; }

        /// <summary>
        /// 网站创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebCreateTime")]
        public string WebCreateTime{ get; set; }

        /// <summary>
        /// 网站过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebExpireTime")]
        public string WebExpireTime{ get; set; }

        /// <summary>
        /// 新增时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// 资质证明状态：0-不可用 1-可用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificationStatus")]
        public long? CertificationStatus{ get; set; }

        /// <summary>
        /// 网址截图
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Snapshot")]
        public string Snapshot{ get; set; }

        /// <summary>
        /// 账户资源状态：0-不可用 1-可用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountStatus")]
        public long? AccountStatus{ get; set; }

        /// <summary>
        /// 审核状态：0-未审核 1-审核中 2-审核成功 3-审核失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuditStatus")]
        public long? AuditStatus{ get; set; }

        /// <summary>
        /// 下线时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FakeURLId", this.FakeURLId);
            this.SetParamSimple(map, prefix + "BrandName", this.BrandName);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "FakeURL", this.FakeURL);
            this.SetParamSimple(map, prefix + "FakeDomain", this.FakeDomain);
            this.SetParamSimple(map, prefix + "Heat", this.Heat);
            this.SetParamSimple(map, prefix + "BlockStatus", this.BlockStatus);
            this.SetParamSimple(map, prefix + "BlockNote", this.BlockNote);
            this.SetParamSimple(map, prefix + "OfflineStatus", this.OfflineStatus);
            this.SetParamSimple(map, prefix + "OfflineNote", this.OfflineNote);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "IPLocation", this.IPLocation);
            this.SetParamSimple(map, prefix + "WebCompany", this.WebCompany);
            this.SetParamSimple(map, prefix + "WebAttribute", this.WebAttribute);
            this.SetParamSimple(map, prefix + "WebName", this.WebName);
            this.SetParamSimple(map, prefix + "WebICP", this.WebICP);
            this.SetParamSimple(map, prefix + "WebCreateTime", this.WebCreateTime);
            this.SetParamSimple(map, prefix + "WebExpireTime", this.WebExpireTime);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "CertificationStatus", this.CertificationStatus);
            this.SetParamSimple(map, prefix + "Snapshot", this.Snapshot);
            this.SetParamSimple(map, prefix + "AccountStatus", this.AccountStatus);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
        }
    }
}

