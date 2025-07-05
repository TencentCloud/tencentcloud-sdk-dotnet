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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceNewRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 是否高可用
        /// </summary>
        [JsonProperty("HaFlag")]
        public bool? HaFlag{ get; set; }

        /// <summary>
        /// 私有网络
        /// </summary>
        [JsonProperty("UserVPCId")]
        public string UserVPCId{ get; set; }

        /// <summary>
        /// 子网
        /// </summary>
        [JsonProperty("UserSubnetId")]
        public string UserSubnetId{ get; set; }

        /// <summary>
        /// 系统版本
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// 计费方式
        /// </summary>
        [JsonProperty("ChargeProperties")]
        public Charge ChargeProperties{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 数据节点
        /// SpecName从DescribeSpec接口中返回的DataSpec.Name获取
        /// </summary>
        [JsonProperty("DataSpec")]
        public NodeSpec DataSpec{ get; set; }

        /// <summary>
        /// 标签列表（废弃）
        /// </summary>
        [JsonProperty("Tags")]
        [System.Obsolete]
        public Tag Tags{ get; set; }

        /// <summary>
        /// 日志主题ID
        /// </summary>
        [JsonProperty("ClsLogSetId")]
        public string ClsLogSetId{ get; set; }

        /// <summary>
        /// COS桶名称
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// 是否是裸盘挂载，默认值 0 为 未挂载，1 为挂载。
        /// </summary>
        [JsonProperty("MountDiskType")]
        public long? MountDiskType{ get; set; }

        /// <summary>
        /// 是否是ZK高可用
        /// </summary>
        [JsonProperty("HAZk")]
        public bool? HAZk{ get; set; }

        /// <summary>
        /// ZK节点
        /// SpecName从DescribeSpec接口中返回的CommonSpec.Name（ZK节点）获取
        /// </summary>
        [JsonProperty("CommonSpec")]
        public NodeSpec CommonSpec{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("TagItems")]
        public Tag[] TagItems{ get; set; }

        /// <summary>
        /// 副可用去信息
        /// </summary>
        [JsonProperty("SecondaryZoneInfo")]
        public SecondaryZoneInfo[] SecondaryZoneInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "HaFlag", this.HaFlag);
            this.SetParamSimple(map, prefix + "UserVPCId", this.UserVPCId);
            this.SetParamSimple(map, prefix + "UserSubnetId", this.UserSubnetId);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamObj(map, prefix + "ChargeProperties.", this.ChargeProperties);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamObj(map, prefix + "DataSpec.", this.DataSpec);
            this.SetParamObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ClsLogSetId", this.ClsLogSetId);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "MountDiskType", this.MountDiskType);
            this.SetParamSimple(map, prefix + "HAZk", this.HAZk);
            this.SetParamObj(map, prefix + "CommonSpec.", this.CommonSpec);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
            this.SetParamArrayObj(map, prefix + "SecondaryZoneInfo.", this.SecondaryZoneInfo);
        }
    }
}

