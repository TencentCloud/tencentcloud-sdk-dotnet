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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Catalog : AbstractModel
    {
        
        /// <summary>
        /// <p>数据目录唯一id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>数据目录名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>数据目录类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>数据目录描述信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>状态信息：注册中0，待测试1，连接成功2，连接失败3，删除中4，已删除5</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>数据目录属性</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Properties")]
        public KVPair[] Properties{ get; set; }

        /// <summary>
        /// <p>操作人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>责任人信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaOwner")]
        public MetaOwner MetaOwner{ get; set; }

        /// <summary>
        /// <p>审计信息</p>
        /// </summary>
        [JsonProperty("Audit")]
        public Audit Audit{ get; set; }

        /// <summary>
        /// <p>资产全局唯一ID</p>
        /// </summary>
        [JsonProperty("AssetGuid")]
        public string AssetGuid{ get; set; }

        /// <summary>
        /// <p>当前workspace权限级别，取值对应PermissionLevel，0-无权限，1-只读，2-读写</p>
        /// </summary>
        [JsonProperty("CurrentWorkspacePermissionLevel")]
        public long? CurrentWorkspacePermissionLevel{ get; set; }

        /// <summary>
        /// <p>tccatalog属性中的tccatalog.identifier</p>
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// <p>当前用户对该实体的权限信息</p>
        /// </summary>
        [JsonProperty("PermissionDetail")]
        public PermissionDetail PermissionDetail{ get; set; }

        /// <summary>
        /// <p>是否为外部数据目录（基于数据源连接创建的Catalog，如MYSQL、EMR_HIVE、TCHOUSE_D、POSTGRESQL、DLC等）。true:外部目录, false:内置目录（TABLE/MODEL/VOLUME）</p>
        /// </summary>
        [JsonProperty("IsExternal")]
        public bool? IsExternal{ get; set; }

        /// <summary>
        /// <p>标签信息列表。注意：仅当请求中 FetchTags=true 时返回，默认不返回</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public CommonTagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>数据目录来源</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CatalogSource")]
        public string CatalogSource{ get; set; }

        /// <summary>
        /// <p>连接侧数据目录名或数据库名（仅分析版三段式数据源有值，二段式数据源为空字符串）。Doris/StarRocks/TChouse-D 等 MySQL 内核三段式数据源：external catalog 名称；PostgreSQL/Tencent PG/GaussDB/Hologres 等 PG 内核三段式数据源：databaseName；MySQL 等二段式数据源：空字符串。注意：此字段仅分析版（CatalogSource=CONNECTION）有效，专业版（METALAKE）不填充。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectionCatalogName")]
        public string ConnectionCatalogName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamObj(map, prefix + "MetaOwner.", this.MetaOwner);
            this.SetParamObj(map, prefix + "Audit.", this.Audit);
            this.SetParamSimple(map, prefix + "AssetGuid", this.AssetGuid);
            this.SetParamSimple(map, prefix + "CurrentWorkspacePermissionLevel", this.CurrentWorkspacePermissionLevel);
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamObj(map, prefix + "PermissionDetail.", this.PermissionDetail);
            this.SetParamSimple(map, prefix + "IsExternal", this.IsExternal);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CatalogSource", this.CatalogSource);
            this.SetParamSimple(map, prefix + "ConnectionCatalogName", this.ConnectionCatalogName);
        }
    }
}

