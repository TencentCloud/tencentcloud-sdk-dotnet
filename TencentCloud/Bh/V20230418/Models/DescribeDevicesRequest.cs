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

    public class DescribeDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资产ID集合</p>
        /// </summary>
        [JsonProperty("IdSet")]
        public ulong?[] IdSet{ get; set; }

        /// <summary>
        /// <p>资产名或资产IP，模糊查询</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>暂未使用</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>地域码集合</p>
        /// </summary>
        [JsonProperty("ApCodeSet")]
        public string[] ApCodeSet{ get; set; }

        /// <summary>
        /// <p>操作系统类型, 1 - Linux, 2 - Windows, 3 - MySQL, 4 - SQLServer</p>
        /// </summary>
        [JsonProperty("Kind")]
        public ulong? Kind{ get; set; }

        /// <summary>
        /// <p>分页偏移位置，默认值为0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>每页条目数量</p><p>取值范围：[0, 500]</p><p>默认值：20</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>有该资产访问权限的用户ID集合</p>
        /// </summary>
        [JsonProperty("AuthorizedUserIdSet")]
        public ulong?[] AuthorizedUserIdSet{ get; set; }

        /// <summary>
        /// <p>过滤条件，资产绑定的堡垒机服务ID集合</p>
        /// </summary>
        [JsonProperty("ResourceIdSet")]
        public string[] ResourceIdSet{ get; set; }

        /// <summary>
        /// <p>可提供按照多种类型过滤, 1 - Linux, 2 - Windows, 3 - MySQL, 4 - SQLServer</p>
        /// </summary>
        [JsonProperty("KindSet")]
        public ulong?[] KindSet{ get; set; }

        /// <summary>
        /// <p>资产是否包含托管账号。1，包含；0，不包含</p>
        /// </summary>
        [JsonProperty("ManagedAccount")]
        public string ManagedAccount{ get; set; }

        /// <summary>
        /// <p>过滤条件，可按照部门ID进行过滤</p>
        /// </summary>
        [JsonProperty("DepartmentId")]
        public string DepartmentId{ get; set; }

        /// <summary>
        /// <p>资产所属云账号id</p>
        /// </summary>
        [JsonProperty("AccountIdSet")]
        public ulong?[] AccountIdSet{ get; set; }

        /// <summary>
        /// <p>云厂商类型，1-腾讯云，2-阿里云</p>
        /// </summary>
        [JsonProperty("ProviderTypeSet")]
        public ulong?[] ProviderTypeSet{ get; set; }

        /// <summary>
        /// <p>同步的云资产状态，标记同步的资产的状态情况，0-已删除,1-正常,2-已隔离,3-已过期</p>
        /// </summary>
        [JsonProperty("CloudDeviceStatusSet")]
        public ulong?[] CloudDeviceStatusSet{ get; set; }

        /// <summary>
        /// <p>过滤条件，可按照标签键、标签进行过滤。如果同时指定标签键和标签过滤条件，它们之间为“AND”的关系</p>
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }

        /// <summary>
        /// <p>过滤数组。支持的Name：<br>BindingStatus 绑定状态</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>所属成员 AppId</p>
        /// </summary>
        [JsonProperty("OwnerAppIds")]
        public ulong?[] OwnerAppIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IdSet.", this.IdSet);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamArraySimple(map, prefix + "ApCodeSet.", this.ApCodeSet);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "AuthorizedUserIdSet.", this.AuthorizedUserIdSet);
            this.SetParamArraySimple(map, prefix + "ResourceIdSet.", this.ResourceIdSet);
            this.SetParamArraySimple(map, prefix + "KindSet.", this.KindSet);
            this.SetParamSimple(map, prefix + "ManagedAccount", this.ManagedAccount);
            this.SetParamSimple(map, prefix + "DepartmentId", this.DepartmentId);
            this.SetParamArraySimple(map, prefix + "AccountIdSet.", this.AccountIdSet);
            this.SetParamArraySimple(map, prefix + "ProviderTypeSet.", this.ProviderTypeSet);
            this.SetParamArraySimple(map, prefix + "CloudDeviceStatusSet.", this.CloudDeviceStatusSet);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "OwnerAppIds.", this.OwnerAppIds);
        }
    }
}

