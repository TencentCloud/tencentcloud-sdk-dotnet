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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountGroup : AbstractModel
    {
        
        /// <summary>
        /// 账号组id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 账号组名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 账号组id路径
        /// </summary>
        [JsonProperty("IdPath")]
        public string IdPath{ get; set; }

        /// <summary>
        /// 账号组名称路径
        /// </summary>
        [JsonProperty("NamePath")]
        public string NamePath{ get; set; }

        /// <summary>
        /// 父账号组id
        /// </summary>
        [JsonProperty("ParentId")]
        public long? ParentId{ get; set; }

        /// <summary>
        /// 账号组来源
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 账号组下用户总数
        /// </summary>
        [JsonProperty("UserTotal")]
        public long? UserTotal{ get; set; }

        /// <summary>
        /// 是否叶子节点
        /// </summary>
        [JsonProperty("IsLeaf")]
        public bool? IsLeaf{ get; set; }

        /// <summary>
        /// 账号组导入类型
        /// </summary>
        [JsonProperty("ImportType")]
        public string ImportType{ get; set; }

        /// <summary>
        /// 账号组描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 父源账号组织ID。使用第三方导入用户源时，记录该分组在源组织架构下的分组ID
        /// </summary>
        [JsonProperty("ParentOrgId")]
        public string ParentOrgId{ get; set; }

        /// <summary>
        /// 源账号组织ID。使用第三方导入用户源时，记录该分组在源组织架构下的分组ID
        /// </summary>
        [JsonProperty("OrgId")]
        public string OrgId{ get; set; }

        /// <summary>
        /// 账号组是否已经接入，0表示未接入，1表示接入
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdPath", this.IdPath);
            this.SetParamSimple(map, prefix + "NamePath", this.NamePath);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "UserTotal", this.UserTotal);
            this.SetParamSimple(map, prefix + "IsLeaf", this.IsLeaf);
            this.SetParamSimple(map, prefix + "ImportType", this.ImportType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ParentOrgId", this.ParentOrgId);
            this.SetParamSimple(map, prefix + "OrgId", this.OrgId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

