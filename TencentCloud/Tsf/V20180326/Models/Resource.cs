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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Resource : AbstractModel
    {
        
        /// <summary>
        /// 资源ID，调用[DescribeResources](https://console.cloud.tencent.com/tsf/privilege-program-create?rid=1)接口，查看接口返回的ResourceId
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源编码，枚举值描述【cluster（集群）、namespace（命名空间）、config（应用配置）】
        /// </summary>
        [JsonProperty("ResourceCode")]
        public string ResourceCode{ get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 资源所属产品编码，枚举值描述【tsf】
        /// </summary>
        [JsonProperty("ServiceCode")]
        public string ServiceCode{ get; set; }

        /// <summary>
        /// 选取资源使用的Action，枚举值描述【DescribeSimpleCluster（查询简单集群列表）、DescribeTaskRecords（查询任务列表）】
        /// </summary>
        [JsonProperty("ResourceAction")]
        public string ResourceAction{ get; set; }

        /// <summary>
        /// 资源数据查询的ID字段名，调用[DescribeResources](https://console.cloud.tencent.com/tsf/privilege-program-create?rid=1)接口，查看接口返回的IdField
        /// </summary>
        [JsonProperty("IdField")]
        public string IdField{ get; set; }

        /// <summary>
        /// 资源数据查询的名称字段名
        /// </summary>
        [JsonProperty("NameField")]
        public string NameField{ get; set; }

        /// <summary>
        /// 资源数据查询的ID过滤字段名
        /// </summary>
        [JsonProperty("SelectIdsField")]
        public string SelectIdsField{ get; set; }

        /// <summary>
        /// 创建时间，时间戳格式【Long】
        /// </summary>
        [JsonProperty("CreationTime")]
        public long? CreationTime{ get; set; }

        /// <summary>
        /// 最后更新时间，时间戳格式【Long】
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public long? LastUpdateTime{ get; set; }

        /// <summary>
        /// 删除标识
        /// </summary>
        [JsonProperty("DeleteFlag")]
        public bool? DeleteFlag{ get; set; }

        /// <summary>
        /// 资源描述
        /// </summary>
        [JsonProperty("ResourceDesc")]
        public string ResourceDesc{ get; set; }

        /// <summary>
        /// 是否可以选择全部
        /// </summary>
        [JsonProperty("CanSelectAll")]
        public bool? CanSelectAll{ get; set; }

        /// <summary>
        /// 资源数据查询的模糊查询字段名
        /// </summary>
        [JsonProperty("SearchWordField")]
        public string SearchWordField{ get; set; }

        /// <summary>
        /// 排序，枚举值描述【10、20、77】
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceCode", this.ResourceCode);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ServiceCode", this.ServiceCode);
            this.SetParamSimple(map, prefix + "ResourceAction", this.ResourceAction);
            this.SetParamSimple(map, prefix + "IdField", this.IdField);
            this.SetParamSimple(map, prefix + "NameField", this.NameField);
            this.SetParamSimple(map, prefix + "SelectIdsField", this.SelectIdsField);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "DeleteFlag", this.DeleteFlag);
            this.SetParamSimple(map, prefix + "ResourceDesc", this.ResourceDesc);
            this.SetParamSimple(map, prefix + "CanSelectAll", this.CanSelectAll);
            this.SetParamSimple(map, prefix + "SearchWordField", this.SearchWordField);
            this.SetParamSimple(map, prefix + "Index", this.Index);
        }
    }
}

