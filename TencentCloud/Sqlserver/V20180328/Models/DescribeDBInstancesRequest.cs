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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 实例状态。取值范围：
        /// <li>1：申请中</li>
        /// <li>2：运行中</li>
        /// <li>3：受限运行中 (主备切换中)</li>
        /// <li>4：已隔离</li>
        /// <li>5：回收中</li>
        /// <li>6：已回收</li>
        /// <li>7：任务执行中 (实例做备份、回档等操作)</li>
        /// <li>8：已下线</li>
        /// <li>9：实例扩容中</li>
        /// <li>10：实例迁移中</li>
        /// <li>11：只读</li>
        /// <li>12：重启中</li>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 分页返回，页编号，默认值为第0页
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页返回，每页返回的数目，取值为1-100，默认值为100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 一个或者多个实例ID。实例ID，格式如：mssql-si2823jyl
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// 付费类型检索 1-包年包月，0-按量计费
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 实例所属VPC的唯一字符串ID，格式如：vpc-xxx，传空字符串(“”)则按照基础网络筛选。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 实例所属子网的唯一字符串ID，格式如： subnet-xxx，传空字符串(“”)则按照基础网络筛选。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例内网地址列表，格式如：172.1.0.12
        /// </summary>
        [JsonProperty("VipSet")]
        public string[] VipSet{ get; set; }

        /// <summary>
        /// 实例名称列表，模糊查询
        /// </summary>
        [JsonProperty("InstanceNameSet")]
        public string[] InstanceNameSet{ get; set; }

        /// <summary>
        /// 实例版本代号列表，格式如：2008R2，2012SP3等
        /// </summary>
        [JsonProperty("VersionSet")]
        public string[] VersionSet{ get; set; }

        /// <summary>
        /// 实例可用区，格式如：ap-guangzhou-2
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例标签列表
        /// </summary>
        [JsonProperty("TagKeys")]
        public string[] TagKeys{ get; set; }

        /// <summary>
        /// 模糊查询关键字，支持实例id、实例名、内网ip
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// 实例唯一Uid列表
        /// </summary>
        [JsonProperty("UidSet")]
        public string[] UidSet{ get; set; }

        /// <summary>
        /// 实例类型 HA-高可用 RO-只读实例 SI-基础版 BI-商业智能服务
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 分页查询方式 offset-按照偏移量分页查询，pageNumber-按照页数分页查询，默认取值pageNumber
        /// </summary>
        [JsonProperty("PaginationType")]
        public string PaginationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArraySimple(map, prefix + "VipSet.", this.VipSet);
            this.SetParamArraySimple(map, prefix + "InstanceNameSet.", this.InstanceNameSet);
            this.SetParamArraySimple(map, prefix + "VersionSet.", this.VersionSet);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArraySimple(map, prefix + "TagKeys.", this.TagKeys);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamArraySimple(map, prefix + "UidSet.", this.UidSet);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "PaginationType", this.PaginationType);
        }
    }
}

