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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableInfo : AbstractModel
    {
        
        /// <summary>
        /// 表名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 表实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableInstanceId")]
        public string TableInstanceId{ get; set; }

        /// <summary>
        /// 表数据结构类型，如：`GENERIC`或`LIST`
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// 表数据描述语言（IDL）类型，如：`PROTO`或`TDR`
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableIdlType")]
        public string TableIdlType{ get; set; }

        /// <summary>
        /// 表所属应用实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 表所属应用名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 表所属大区ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogicZoneId")]
        public string LogicZoneId{ get; set; }

        /// <summary>
        /// 表所属大区名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 表主键结构json字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyStruct")]
        public string KeyStruct{ get; set; }

        /// <summary>
        /// 表非主键结构json字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueStruct")]
        public string ValueStruct{ get; set; }

        /// <summary>
        /// 表分表因子集合，PROTO表有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShardingKeySet")]
        public string ShardingKeySet{ get; set; }

        /// <summary>
        /// 表索引键集合，PROTO表有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexStruct")]
        public string IndexStruct{ get; set; }

        /// <summary>
        /// LIST表元素个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ListElementNum")]
        public ulong? ListElementNum{ get; set; }

        /// <summary>
        /// 表所关联IDL文件信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdlFiles")]
        public IdlFileInfo[] IdlFiles{ get; set; }

        /// <summary>
        /// 表预留容量（GB）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReservedVolume")]
        public long? ReservedVolume{ get; set; }

        /// <summary>
        /// 表预留读QPS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReservedReadQps")]
        public long? ReservedReadQps{ get; set; }

        /// <summary>
        /// 表预留写QPS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReservedWriteQps")]
        public long? ReservedWriteQps{ get; set; }

        /// <summary>
        /// 表实际数据量大小（MB）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableSize")]
        public long? TableSize{ get; set; }

        /// <summary>
        /// 表状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 表创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 最后一次更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// 表备注信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Memo")]
        public string Memo{ get; set; }

        /// <summary>
        /// 错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Error")]
        public ErrorInfo Error{ get; set; }

        /// <summary>
        /// Api接入ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiAccessId")]
        public string ApiAccessId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableInstanceId", this.TableInstanceId);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "TableIdlType", this.TableIdlType);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "LogicZoneId", this.LogicZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "KeyStruct", this.KeyStruct);
            this.SetParamSimple(map, prefix + "ValueStruct", this.ValueStruct);
            this.SetParamSimple(map, prefix + "ShardingKeySet", this.ShardingKeySet);
            this.SetParamSimple(map, prefix + "IndexStruct", this.IndexStruct);
            this.SetParamSimple(map, prefix + "ListElementNum", this.ListElementNum);
            this.SetParamArrayObj(map, prefix + "IdlFiles.", this.IdlFiles);
            this.SetParamSimple(map, prefix + "ReservedVolume", this.ReservedVolume);
            this.SetParamSimple(map, prefix + "ReservedReadQps", this.ReservedReadQps);
            this.SetParamSimple(map, prefix + "ReservedWriteQps", this.ReservedWriteQps);
            this.SetParamSimple(map, prefix + "TableSize", this.TableSize);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "Memo", this.Memo);
            this.SetParamObj(map, prefix + "Error.", this.Error);
            this.SetParamSimple(map, prefix + "ApiAccessId", this.ApiAccessId);
        }
    }
}

