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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetAccountGroupData : AbstractModel
    {
        
        /// <summary>
        /// 分组名称全路径，点分格式
        /// </summary>
        [JsonProperty("NamePath")]
        public string NamePath{ get; set; }

        /// <summary>
        /// 分组ID全路径，数组格式
        /// </summary>
        [JsonProperty("IdPathArr")]
        public long?[] IdPathArr{ get; set; }

        /// <summary>
        /// 分组扩展信息
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public string ExtraInfo{ get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [JsonProperty("Utime")]
        public string Utime{ get; set; }

        /// <summary>
        /// 当前分组的父分组ID
        /// </summary>
        [JsonProperty("ParentId")]
        public ulong? ParentId{ get; set; }

        /// <summary>
        /// 源账号组ID，该字段仅适用于第三方同步的组织架构，通过OrgId-Id构成源组织架构分组ID-现组织架构分组ID映射关系
        /// </summary>
        [JsonProperty("OrgId")]
        public string OrgId{ get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 分组ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 分组描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 分组导入源(只支持32位)
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// 分组ID全路径，点分格式
        /// </summary>
        [JsonProperty("IdPath")]
        public string IdPath{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("Itime")]
        public string Itime{ get; set; }

        /// <summary>
        /// 父源账号组ID，该字段仅适用于第三方同步的组织架构
        /// </summary>
        [JsonProperty("ParentOrgId")]
        public string ParentOrgId{ get; set; }

        /// <summary>
        /// 导入信息,json格式
        /// </summary>
        [JsonProperty("Import")]
        public string Import{ get; set; }

        /// <summary>
        /// 是否开启导入架构
        /// </summary>
        [JsonProperty("ImportEnable")]
        public bool? ImportEnable{ get; set; }

        /// <summary>
        /// 导入类型
        /// </summary>
        [JsonProperty("ImportType")]
        public string ImportType{ get; set; }

        /// <summary>
        /// miniIAMId，MiniIAM源才有
        /// </summary>
        [JsonProperty("MiniIamId")]
        public string MiniIamId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NamePath", this.NamePath);
            this.SetParamArraySimple(map, prefix + "IdPathArr.", this.IdPathArr);
            this.SetParamSimple(map, prefix + "ExtraInfo", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "Utime", this.Utime);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "OrgId", this.OrgId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "IdPath", this.IdPath);
            this.SetParamSimple(map, prefix + "Itime", this.Itime);
            this.SetParamSimple(map, prefix + "ParentOrgId", this.ParentOrgId);
            this.SetParamSimple(map, prefix + "Import", this.Import);
            this.SetParamSimple(map, prefix + "ImportEnable", this.ImportEnable);
            this.SetParamSimple(map, prefix + "ImportType", this.ImportType);
            this.SetParamSimple(map, prefix + "MiniIamId", this.MiniIamId);
        }
    }
}

