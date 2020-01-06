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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDCDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 分片节点可用区分布，最多可填两个可用区。当分片规格为一主两从时，其中两个节点在第一个可用区。
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 欲购买的时长，单位：月。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 分片内存大小，单位：GB，可以通过 DescribeShardSpec
        ///  查询实例规格获得。
        /// </summary>
        [JsonProperty("ShardMemory")]
        public long? ShardMemory{ get; set; }

        /// <summary>
        /// 分片存储空间大小，单位：GB，可以通过 DescribeShardSpec
        ///  查询实例规格获得。
        /// </summary>
        [JsonProperty("ShardStorage")]
        public long? ShardStorage{ get; set; }

        /// <summary>
        /// 单个分片节点个数，可以通过 DescribeShardSpec
        ///  查询实例规格获得。
        /// </summary>
        [JsonProperty("ShardNodeCount")]
        public long? ShardNodeCount{ get; set; }

        /// <summary>
        /// 实例分片个数，可选范围2-8，可以通过升级实例进行新增分片到最多64个分片。
        /// </summary>
        [JsonProperty("ShardCount")]
        public long? ShardCount{ get; set; }

        /// <summary>
        /// 欲购买实例的数量，目前只支持购买1个实例
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 项目 ID，可以通过查看项目列表获取，不传则关联到默认项目
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 虚拟私有网络 ID，不传或传空表示创建为基础网络
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 虚拟私有网络子网 ID，VpcId不为空时必填
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 数据库引擎版本，当前可选：10.0.10，10.1.9，5.7.17。
        /// 10.0.10 - Mariadb 10.0.10；
        /// 10.1.9 - Mariadb 10.1.9；
        /// 5.7.17 - Percona 5.7.17。
        /// 如果不填的话，默认为10.1.9，表示Mariadb 10.1.9。
        /// </summary>
        [JsonProperty("DbVersionId")]
        public string DbVersionId{ get; set; }

        /// <summary>
        /// 是否自动使用代金券进行支付，默认不使用。
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }

        /// <summary>
        /// 代金券ID列表，目前仅支持指定一张代金券。
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ShardMemory", this.ShardMemory);
            this.SetParamSimple(map, prefix + "ShardStorage", this.ShardStorage);
            this.SetParamSimple(map, prefix + "ShardNodeCount", this.ShardNodeCount);
            this.SetParamSimple(map, prefix + "ShardCount", this.ShardCount);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DbVersionId", this.DbVersionId);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
        }
    }
}

