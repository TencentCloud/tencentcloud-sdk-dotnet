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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddInstancesRequest : AbstractModel
    {
        
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
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 新增只读实例数，取值范围为(0,15]
        /// </summary>
        [JsonProperty("ReadOnlyCount")]
        public long? ReadOnlyCount{ get; set; }

        /// <summary>
        /// 实例组ID，在已有RO组中新增实例时使用，不传则新增RO组。当前版本不建议传输该值。
        /// </summary>
        [JsonProperty("InstanceGrpId")]
        [System.Obsolete]
        public string InstanceGrpId{ get; set; }

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
        /// 新增RO组时使用的Port，取值范围为[0,65535)
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 实例名称，字符串长度范围为[0,64)，取值范围为大小写字母，0-9数字，'_','-','.'
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 是否自动选择代金券 1是 0否 默认为0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// 数据库类型，取值范围: 
        /// <li> MYSQL </li>
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

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
        /// 参数模板ID
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public long? ParamTemplateId{ get; set; }

        /// <summary>
        /// 参数列表，ParamTemplateId 传入时InstanceParams才有效
        /// </summary>
        [JsonProperty("InstanceParams")]
        public ModifyParamItem[] InstanceParams{ get; set; }

        /// <summary>
        /// 安全组ID，新建只读实例时可以指定安全组。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "ReadOnlyCount", this.ReadOnlyCount);
            this.SetParamSimple(map, prefix + "InstanceGrpId", this.InstanceGrpId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "OrderSource", this.OrderSource);
            this.SetParamSimple(map, prefix + "DealMode", this.DealMode);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamArrayObj(map, prefix + "InstanceParams.", this.InstanceParams);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

