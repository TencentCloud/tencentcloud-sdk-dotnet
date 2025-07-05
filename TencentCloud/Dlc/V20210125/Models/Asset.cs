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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Asset : AbstractModel
    {
        
        /// <summary>
        /// 主键
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 对象GUID值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Guid")]
        public string Guid{ get; set; }

        /// <summary>
        /// 数据目录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 对象owner
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 对象owner账户
        /// </summary>
        [JsonProperty("OwnerAccount")]
        public string OwnerAccount{ get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        [JsonProperty("PermValues")]
        public KVPair[] PermValues{ get; set; }

        /// <summary>
        /// 附加属性
        /// </summary>
        [JsonProperty("Params")]
        public KVPair[] Params{ get; set; }

        /// <summary>
        /// 附加业务属性
        /// </summary>
        [JsonProperty("BizParams")]
        public KVPair[] BizParams{ get; set; }

        /// <summary>
        /// 数据版本
        /// </summary>
        [JsonProperty("DataVersion")]
        public long? DataVersion{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// 数据源主键
        /// </summary>
        [JsonProperty("DatasourceId")]
        public long? DatasourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Guid", this.Guid);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "OwnerAccount", this.OwnerAccount);
            this.SetParamArrayObj(map, prefix + "PermValues.", this.PermValues);
            this.SetParamArrayObj(map, prefix + "Params.", this.Params);
            this.SetParamArrayObj(map, prefix + "BizParams.", this.BizParams);
            this.SetParamSimple(map, prefix + "DataVersion", this.DataVersion);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
        }
    }
}

