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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 按照一个或者多个实例 ID 查询。实例 ID 形如：tdsql-ow728lmc。每次请求的实例的上限为100。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 搜索的字段名，当前支持的值有：instancename、vip、all。传 instancename 表示按实例名进行搜索；传 vip 表示按内网IP进行搜索；传 all 将会按实例ID、实例名和内网IP进行搜索。
        /// </summary>
        [JsonProperty("SearchName")]
        public string SearchName{ get; set; }

        /// <summary>
        /// 搜索的关键字，支持模糊搜索。多个关键字使用换行符（'\n'）分割。
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// 按项目 ID 查询
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// 是否根据 VPC 网络来搜索
        /// </summary>
        [JsonProperty("IsFilterVpc")]
        public bool? IsFilterVpc{ get; set; }

        /// <summary>
        /// 私有网络 ID， IsFilterVpc 为 1 时有效
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络的子网 ID， IsFilterVpc 为 1 时有效
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 排序字段， projectId， createtime， instancename 三者之一
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序类型， desc 或者 asc
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }

        /// <summary>
        /// 偏移量，默认为 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为 20，最大值为 100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 按 OriginSerialId 查询
        /// </summary>
        [JsonProperty("OriginSerialIds")]
        public string[] OriginSerialIds{ get; set; }

        /// <summary>
        /// 标识是否使用ExclusterType字段, false不使用，true使用
        /// </summary>
        [JsonProperty("IsFilterExcluster")]
        public bool? IsFilterExcluster{ get; set; }

        /// <summary>
        /// 实例所属独享集群类型。取值范围：1-非独享集群，2-独享集群， 0-全部
        /// </summary>
        [JsonProperty("ExclusterType")]
        public long? ExclusterType{ get; set; }

        /// <summary>
        /// 按独享集群ID过滤实例，独享集群ID形如dbdc-4ih6uct9
        /// </summary>
        [JsonProperty("ExclusterIds")]
        public string[] ExclusterIds{ get; set; }

        /// <summary>
        /// 按标签key查询
        /// </summary>
        [JsonProperty("TagKeys")]
        public string[] TagKeys{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 实例类型过滤，1-独享实例，2-主实例，3-灾备实例，多个按逗号分隔
        /// </summary>
        [JsonProperty("FilterInstanceType")]
        public string FilterInstanceType{ get; set; }

        /// <summary>
        /// 按照实例状态进行筛选。状态值 -2：已删除； -1：已隔离；0：创建中；1：流程处理中；2：运行中
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// 排除实例状态。状态值 -2：已删除； -1：已隔离；0：创建中；1：流程处理中；2：运行中
        /// </summary>
        [JsonProperty("ExcludeStatus")]
        public long?[] ExcludeStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "SearchName", this.SearchName);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamSimple(map, prefix + "IsFilterVpc", this.IsFilterVpc);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "OriginSerialIds.", this.OriginSerialIds);
            this.SetParamSimple(map, prefix + "IsFilterExcluster", this.IsFilterExcluster);
            this.SetParamSimple(map, prefix + "ExclusterType", this.ExclusterType);
            this.SetParamArraySimple(map, prefix + "ExclusterIds.", this.ExclusterIds);
            this.SetParamArraySimple(map, prefix + "TagKeys.", this.TagKeys);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "FilterInstanceType", this.FilterInstanceType);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "ExcludeStatus.", this.ExcludeStatus);
        }
    }
}

