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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDataTableRequest : AbstractModel
    {
        
        /// <summary>
        /// 后端提供字典：数据表类型，1、数据库建表，2、SQL建表，3、Excel上传，4、API接入，5、腾讯文档，6、云数据库，7、手工输入，8、关联查询
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 数据表名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 所属文件夹
        /// </summary>
        [JsonProperty("FoldId")]
        public ulong? FoldId{ get; set; }

        /// <summary>
        /// 数据源Id
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// 物理表名
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// sql语句
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// excel地址
        /// </summary>
        [JsonProperty("ExcelUrl")]
        public string ExcelUrl{ get; set; }

        /// <summary>
        /// 字段配置
        /// </summary>
        [JsonProperty("Fields")]
        public TableField[] Fields{ get; set; }

        /// <summary>
        /// 多表关联使用: 1:数据源原表,2:本地表,3:Excel表,4:API表
        /// </summary>
        [JsonProperty("TableNodeType")]
        public ulong? TableNodeType{ get; set; }

        /// <summary>
        /// 多表关联的原始表信息
        /// </summary>
        [JsonProperty("Tables")]
        public JoinSourceTable[] Tables{ get; set; }

        /// <summary>
        /// 多表关联的关联信息
        /// </summary>
        [JsonProperty("Joins")]
        public JoinRelation[] Joins{ get; set; }

        /// <summary>
        /// 补充信息，如api数据源信息，腾讯文档接入信息等
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// 是否是异步
        /// </summary>
        [JsonProperty("AsyncRequest")]
        public bool? AsyncRequest{ get; set; }

        /// <summary>
        /// 依赖的异步事务id
        /// </summary>
        [JsonProperty("ParentTranId")]
        public string ParentTranId{ get; set; }

        /// <summary>
        /// API数据源配置
        /// </summary>
        [JsonProperty("ApiDatasourceConfig")]
        public ApiDatasourceConfig ApiDatasourceConfig{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("ParamList")]
        public ParamCreateDTO[] ParamList{ get; set; }

        /// <summary>
        /// dlc高级参数
        /// </summary>
        [JsonProperty("DlcExtInfo")]
        public string DlcExtInfo{ get; set; }

        /// <summary>
        /// 是否查询数据库
        /// </summary>
        [JsonProperty("QueryDbData")]
        public string QueryDbData{ get; set; }

        /// <summary>
        /// 数据表备注
        /// </summary>
        [JsonProperty("TableComment")]
        public string TableComment{ get; set; }

        /// <summary>
        /// 是否查询字段备注
        /// </summary>
        [JsonProperty("QueryFieldRemark")]
        public long? QueryFieldRemark{ get; set; }

        /// <summary>
        /// 字段备注列表
        /// </summary>
        [JsonProperty("FieldRemarkList")]
        public FieldRemarkDTO[] FieldRemarkList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "FoldId", this.FoldId);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "ExcelUrl", this.ExcelUrl);
            this.SetParamArrayObj(map, prefix + "Fields.", this.Fields);
            this.SetParamSimple(map, prefix + "TableNodeType", this.TableNodeType);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
            this.SetParamArrayObj(map, prefix + "Joins.", this.Joins);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "AsyncRequest", this.AsyncRequest);
            this.SetParamSimple(map, prefix + "ParentTranId", this.ParentTranId);
            this.SetParamObj(map, prefix + "ApiDatasourceConfig.", this.ApiDatasourceConfig);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamSimple(map, prefix + "DlcExtInfo", this.DlcExtInfo);
            this.SetParamSimple(map, prefix + "QueryDbData", this.QueryDbData);
            this.SetParamSimple(map, prefix + "TableComment", this.TableComment);
            this.SetParamSimple(map, prefix + "QueryFieldRemark", this.QueryFieldRemark);
            this.SetParamArrayObj(map, prefix + "FieldRemarkList.", this.FieldRemarkList);
        }
    }
}

