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

    public class FetchOption : AbstractModel
    {
        
        /// <summary>
        /// <p>是否在响应中返回权限列表，默认false</p>
        /// </summary>
        [JsonProperty("FetchPermissions")]
        public bool? FetchPermissions{ get; set; }

        /// <summary>
        /// <p>是否获取特征表详情，当AssetType为TABLE时有效</p>
        /// </summary>
        [JsonProperty("FetchFeatureTableDetail")]
        public bool? FetchFeatureTableDetail{ get; set; }

        /// <summary>
        /// <p>按权限过滤，传入权限列表，仅返回当前用户拥有指定权限的实体。例如传入[&quot;SELECT_TABLE&quot;]则仅返回当前用户有SELECT_TABLE权限的实体。只对list接口生效，为空时不进行权限过滤</p>
        /// </summary>
        [JsonProperty("FilterPermissions")]
        public string[] FilterPermissions{ get; set; }

        /// <summary>
        /// <p>是否在响应中返回负责人信息。不传或为true时返回负责人信息（默认返回），显式传false时不返回</p>
        /// </summary>
        [JsonProperty("FetchOwners")]
        public bool? FetchOwners{ get; set; }

        /// <summary>
        /// <p>是否将用户Uin转换为用户名(userName)。影响范围：Audit中的CreatorName/LastModifierName、MetaOwner中的OwnerName。不传或为true时执行转换（默认转换），显式传false时不转换</p>
        /// </summary>
        [JsonProperty("FetchUserInfo")]
        public bool? FetchUserInfo{ get; set; }

        /// <summary>
        /// <p>是否返回字段脱敏策略信息，默认不返回，传true则会查询表字段对应的字段脱敏策略信息</p>
        /// </summary>
        [JsonProperty("FetchMask")]
        public bool? FetchMask{ get; set; }

        /// <summary>
        /// <p>是否返回标签信息，默认不返回。传true时，GetTable/ListTables/GetCatalog/ListCatalogs/GetSchema/ListSchemas/GetView/ListViews/GetFunction/ListFunctions/GetVolume/ListVolumes/GetModel/ListModels等接口会在对应实体中返回标签（Tags）字段</p>
        /// </summary>
        [JsonProperty("FetchTags")]
        public bool? FetchTags{ get; set; }

        /// <summary>
        /// <p>是否返回字段关联的字典维度信息，默认不传，不返回</p>
        /// </summary>
        [JsonProperty("FetchDimensions")]
        public bool? FetchDimensions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FetchPermissions", this.FetchPermissions);
            this.SetParamSimple(map, prefix + "FetchFeatureTableDetail", this.FetchFeatureTableDetail);
            this.SetParamArraySimple(map, prefix + "FilterPermissions.", this.FilterPermissions);
            this.SetParamSimple(map, prefix + "FetchOwners", this.FetchOwners);
            this.SetParamSimple(map, prefix + "FetchUserInfo", this.FetchUserInfo);
            this.SetParamSimple(map, prefix + "FetchMask", this.FetchMask);
            this.SetParamSimple(map, prefix + "FetchTags", this.FetchTags);
            this.SetParamSimple(map, prefix + "FetchDimensions", this.FetchDimensions);
        }
    }
}

