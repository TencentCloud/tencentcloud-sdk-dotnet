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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddLibraDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Cpu核数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存，单位为GB
        /// </summary>
        [JsonProperty("Mem")]
        public long? Mem{ get; set; }

        /// <summary>
        /// 磁盘大小
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// 付费模式
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 同步对象列表
        /// </summary>
        [JsonProperty("Objects")]
        public Objects Objects{ get; set; }

        /// <summary>
        /// 新增RO组时使用的Port，取值范围为[0,65535)
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 新增只读实例数，取值范围为(0,15]
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// 实例名称，字符串长度范围为[0,64)，取值范围为大小写字母，0-9数字，'_','-','.'
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 副本数
        /// </summary>
        [JsonProperty("ReplicasNum")]
        public long? ReplicasNum{ get; set; }

        /// <summary>
        /// ReplicasNum>1或者ReplicasNum=1且Cpu>=32核的时候取值为'Exclusive'，其余场景取值'Common'
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 磁盘类型
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 是否自动选择代金券 1是 0否 默认为0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// 订单来源，字符串长度范围为[0,64)
        /// </summary>
        [JsonProperty("OrderSource")]
        public string OrderSource{ get; set; }

        /// <summary>
        /// 交易模式 0-下单并支付 1-下单
        /// </summary>
        [JsonProperty("DealMode")]
        public long? DealMode{ get; set; }

        /// <summary>
        /// 所属VPC网络ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 所属子网ID，如果设置了VpcId，则SubnetId必填。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 安全组ID，新建只读实例时可以指定安全组。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 分析引擎版本
        /// </summary>
        [JsonProperty("LibraDBVersion")]
        public string LibraDBVersion{ get; set; }

        /// <summary>
        /// 购买时长,与TimeUnit组合才能生效
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 购买时长单位, 与TimeSpan组合生效，可选:日:d,月:m
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 源端实例id
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamObj(map, prefix + "Objects.", this.Objects);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ReplicasNum", this.ReplicasNum);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "OrderSource", this.OrderSource);
            this.SetParamSimple(map, prefix + "DealMode", this.DealMode);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "LibraDBVersion", this.LibraDBVersion);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
        }
    }
}

