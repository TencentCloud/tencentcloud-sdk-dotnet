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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDataSourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据源名称，在相同SpaceName下，数据源名称不能为空
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 数据源类别：绑定引擎、绑定数据库
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 数据源类型:枚举值
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 数据源ID
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// 业务侧数据源的配置信息扩展
        /// </summary>
        [JsonProperty("BizParams")]
        public string BizParams{ get; set; }

        /// <summary>
        /// 数据源的配置信息，以JSON KV存储，根据每个数据源类型不同，而KV存储信息不同
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }

        /// <summary>
        /// 数据源描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 数据源展示名，为了可视化查看
        /// </summary>
        [JsonProperty("Display")]
        public string Display{ get; set; }

        /// <summary>
        /// 若数据源列表为绑定数据库，则为db名称
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 数据源引擎的实例ID，如CDB实例ID
        /// </summary>
        [JsonProperty("Instance")]
        public string Instance{ get; set; }

        /// <summary>
        /// 数据源数据源的可见性，1为可见、0为不可见。默认为1
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 数据源所属的业务空间名称
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 是否采集
        /// </summary>
        [JsonProperty("Collect")]
        public string Collect{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("OwnerProjectId")]
        public string OwnerProjectId{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("OwnerProjectName")]
        public string OwnerProjectName{ get; set; }

        /// <summary>
        /// 项目中文名
        /// </summary>
        [JsonProperty("OwnerProjectIdent")]
        public string OwnerProjectIdent{ get; set; }

        /// <summary>
        /// cos bucket
        /// </summary>
        [JsonProperty("COSBucket")]
        public string COSBucket{ get; set; }

        /// <summary>
        /// cos region
        /// </summary>
        [JsonProperty("COSRegion")]
        public string COSRegion{ get; set; }

        /// <summary>
        /// 操作项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 数据源开发环境配置
        /// </summary>
        [JsonProperty("DevelopmentParams")]
        public string DevelopmentParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "BizParams", this.BizParams);
            this.SetParamSimple(map, prefix + "Params", this.Params);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Display", this.Display);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "Instance", this.Instance);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Collect", this.Collect);
            this.SetParamSimple(map, prefix + "OwnerProjectId", this.OwnerProjectId);
            this.SetParamSimple(map, prefix + "OwnerProjectName", this.OwnerProjectName);
            this.SetParamSimple(map, prefix + "OwnerProjectIdent", this.OwnerProjectIdent);
            this.SetParamSimple(map, prefix + "COSBucket", this.COSBucket);
            this.SetParamSimple(map, prefix + "COSRegion", this.COSRegion);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DevelopmentParams", this.DevelopmentParams);
        }
    }
}

