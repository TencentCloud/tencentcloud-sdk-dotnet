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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataSourceDetail : AbstractModel
    {
        
        /// <summary>
        /// 数据源 ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 数据源名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 数据源标识
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 数据源类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 数据源描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 数据源配置
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// cms 项目状态, 0: 重新获取详情信息，1： 不需要重新获取详情信息
        /// </summary>
        [JsonProperty("CmsProject")]
        public string CmsProject{ get; set; }

        /// <summary>
        /// 当前为环境 id
        /// </summary>
        [JsonProperty("PkgId")]
        public string PkgId{ get; set; }

        /// <summary>
        /// schema 版本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaVersion")]
        public string SchemaVersion{ get; set; }

        /// <summary>
        /// 创建者用户 ID
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 环境 id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceVersion")]
        public string DataSourceVersion{ get; set; }

        /// <summary>
        /// 所属应用数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppUsageList")]
        public DataSourceLinkApp[] AppUsageList{ get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonProperty("PublishedAt")]
        public string PublishedAt{ get; set; }

        /// <summary>
        /// 子数据源ids
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChildDataSourceIds")]
        public string[] ChildDataSourceIds{ get; set; }

        /// <summary>
        /// 数据源发布信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Fun")]
        public string Fun{ get; set; }

        /// <summary>
        /// 云函数状态 1 Active 2 Creating 3 Updating 4 Deleting  9 Deleted 11 CreatFailed  12 UpdateFailed 13 DeleteFailed 21 UpdateTimeOut
        /// </summary>
        [JsonProperty("ScfStatus")]
        public ulong? ScfStatus{ get; set; }

        /// <summary>
        /// 自定义方法
        /// </summary>
        [JsonProperty("Methods")]
        public string Methods{ get; set; }

        /// <summary>
        /// 子数据源名数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChildDataSourceNames")]
        public string[] ChildDataSourceNames{ get; set; }

        /// <summary>
        /// 是否旧数据源 1 新 0 旧
        /// </summary>
        [JsonProperty("IsNewDataSource")]
        public long? IsNewDataSource{ get; set; }

        /// <summary>
        /// 数据源视图id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ViewId")]
        public string ViewId{ get; set; }

        /// <summary>
        /// 数据源属性配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Configuration")]
        public string Configuration{ get; set; }

        /// <summary>
        /// 外部数据源模板code
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateCode")]
        public string TemplateCode{ get; set; }

        /// <summary>
        /// 外部数据源模板来源 0 空模板 1 腾讯文档 2 腾讯会议 3 企业微信 4 微信电商
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 发布版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublishVersion")]
        [System.Obsolete]
        public string PublishVersion{ get; set; }

        /// <summary>
        /// 发布视图id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublishViewId")]
        public string PublishViewId{ get; set; }

        /// <summary>
        /// 数据源子类型   "database" 标准模型 "custom-database" 自定义模型 "system" 系统模型 "connector" 连接器 "custom-connector" 自定义连接器 "hidden" 隐藏数据源
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// 授权状态  0 授权无效 1 授权有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthStatus")]
        public long? AuthStatus{ get; set; }

        /// <summary>
        /// 数据源授权信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthInfo")]
        public TicketAuthInfo AuthInfo{ get; set; }

        /// <summary>
        /// 1发布0未发布
        /// </summary>
        [JsonProperty("PublishStatus")]
        public long? PublishStatus{ get; set; }

        /// <summary>
        /// 更新版本
        /// </summary>
        [JsonProperty("UpdateVersion")]
        public long? UpdateVersion{ get; set; }

        /// <summary>
        /// 模型关联关系字段列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelationFieldList")]
        public RelationField[] RelationFieldList{ get; set; }

        /// <summary>
        /// db实例类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbInstanceType")]
        public string DbInstanceType{ get; set; }

        /// <summary>
        /// 体验环境db表名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreviewTableName")]
        public string PreviewTableName{ get; set; }

        /// <summary>
        /// 正式环境db表名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublishedTableName")]
        public string PublishedTableName{ get; set; }

        /// <summary>
        /// DB来源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbSourceType")]
        public string DbSourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "CmsProject", this.CmsProject);
            this.SetParamSimple(map, prefix + "PkgId", this.PkgId);
            this.SetParamSimple(map, prefix + "SchemaVersion", this.SchemaVersion);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "DataSourceVersion", this.DataSourceVersion);
            this.SetParamArrayObj(map, prefix + "AppUsageList.", this.AppUsageList);
            this.SetParamSimple(map, prefix + "PublishedAt", this.PublishedAt);
            this.SetParamArraySimple(map, prefix + "ChildDataSourceIds.", this.ChildDataSourceIds);
            this.SetParamSimple(map, prefix + "Fun", this.Fun);
            this.SetParamSimple(map, prefix + "ScfStatus", this.ScfStatus);
            this.SetParamSimple(map, prefix + "Methods", this.Methods);
            this.SetParamArraySimple(map, prefix + "ChildDataSourceNames.", this.ChildDataSourceNames);
            this.SetParamSimple(map, prefix + "IsNewDataSource", this.IsNewDataSource);
            this.SetParamSimple(map, prefix + "ViewId", this.ViewId);
            this.SetParamSimple(map, prefix + "Configuration", this.Configuration);
            this.SetParamSimple(map, prefix + "TemplateCode", this.TemplateCode);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "PublishVersion", this.PublishVersion);
            this.SetParamSimple(map, prefix + "PublishViewId", this.PublishViewId);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "AuthStatus", this.AuthStatus);
            this.SetParamObj(map, prefix + "AuthInfo.", this.AuthInfo);
            this.SetParamSimple(map, prefix + "PublishStatus", this.PublishStatus);
            this.SetParamSimple(map, prefix + "UpdateVersion", this.UpdateVersion);
            this.SetParamArrayObj(map, prefix + "RelationFieldList.", this.RelationFieldList);
            this.SetParamSimple(map, prefix + "DbInstanceType", this.DbInstanceType);
            this.SetParamSimple(map, prefix + "PreviewTableName", this.PreviewTableName);
            this.SetParamSimple(map, prefix + "PublishedTableName", this.PublishedTableName);
            this.SetParamSimple(map, prefix + "DbSourceType", this.DbSourceType);
        }
    }
}

