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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DatasourceInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据库ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 域类型，1、腾讯云，2、本地
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 数据库别名
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// 数据库驱动
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// HOST
        /// </summary>
        [JsonProperty("DbHost")]
        public string DbHost{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("DbPort")]
        public ulong? DbPort{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("DbUser")]
        public string DbUser{ get; set; }

        /// <summary>
        /// 数据库编码
        /// </summary>
        [JsonProperty("Charset")]
        public string Charset{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 创建人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedUser")]
        public string CreatedUser{ get; set; }

        /// <summary>
        /// catalog值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// 连接类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectType")]
        public string ConnectType{ get; set; }

        /// <summary>
        /// 项目id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 数据源描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 数据源状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 来源平台
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourcePlat")]
        public string SourcePlat{ get; set; }

        /// <summary>
        /// 扩展参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }

        /// <summary>
        /// 额外信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddInfo")]
        public string AddInfo{ get; set; }

        /// <summary>
        /// 项目名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 引擎类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// 数据源负责人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Manager")]
        public string Manager{ get; set; }

        /// <summary>
        /// 特定操作人员白名单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperatorWhitelist")]
        public string OperatorWhitelist{ get; set; }

        /// <summary>
        /// 数据源的vpc信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 数据源的uniqVpc信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 数据源的地域信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// 操作属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StateAction")]
        public BaseStateAction StateAction{ get; set; }

        /// <summary>
        /// 更新人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedUser")]
        public string UpdatedUser{ get; set; }

        /// <summary>
        /// 权限列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PermissionList")]
        public PermissionGroup[] PermissionList{ get; set; }

        /// <summary>
        /// 权限值列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthList")]
        public string[] AuthList{ get; set; }

        /// <summary>
        /// 第三方数据源标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataOrigin")]
        public string DataOrigin{ get; set; }

        /// <summary>
        /// 第三方项目id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataOriginProjectId")]
        public string DataOriginProjectId{ get; set; }

        /// <summary>
        /// 第三方数据源id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataOriginDatasourceId")]
        public string DataOriginDatasourceId{ get; set; }

        /// <summary>
        /// 集群id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 数据源名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbTypeName")]
        public string DbTypeName{ get; set; }

        /// <summary>
        /// 开启vpc
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseVPC")]
        public bool? UseVPC{ get; set; }

        /// <summary>
        /// 所属人ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 所属人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerName")]
        public string OwnerName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "DbHost", this.DbHost);
            this.SetParamSimple(map, prefix + "DbPort", this.DbPort);
            this.SetParamSimple(map, prefix + "DbUser", this.DbUser);
            this.SetParamSimple(map, prefix + "Charset", this.Charset);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "CreatedUser", this.CreatedUser);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "ConnectType", this.ConnectType);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SourcePlat", this.SourcePlat);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
            this.SetParamSimple(map, prefix + "AddInfo", this.AddInfo);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "Manager", this.Manager);
            this.SetParamSimple(map, prefix + "OperatorWhitelist", this.OperatorWhitelist);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamObj(map, prefix + "StateAction.", this.StateAction);
            this.SetParamSimple(map, prefix + "UpdatedUser", this.UpdatedUser);
            this.SetParamArrayObj(map, prefix + "PermissionList.", this.PermissionList);
            this.SetParamArraySimple(map, prefix + "AuthList.", this.AuthList);
            this.SetParamSimple(map, prefix + "DataOrigin", this.DataOrigin);
            this.SetParamSimple(map, prefix + "DataOriginProjectId", this.DataOriginProjectId);
            this.SetParamSimple(map, prefix + "DataOriginDatasourceId", this.DataOriginDatasourceId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "DbTypeName", this.DbTypeName);
            this.SetParamSimple(map, prefix + "UseVPC", this.UseVPC);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "OwnerName", this.OwnerName);
        }
    }
}

