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

namespace TencentCloud.Bmeip.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EipInfo : AbstractModel
    {
        
        /// <summary>
        /// EIP实例ID
        /// </summary>
        [JsonProperty("EipId")]
        public string EipId{ get; set; }

        /// <summary>
        /// EIP名称
        /// </summary>
        [JsonProperty("EipName")]
        public string EipName{ get; set; }

        /// <summary>
        /// EIP地址
        /// </summary>
        [JsonProperty("Eip")]
        public string Eip{ get; set; }

        /// <summary>
        /// 运营商ID 0：电信； 1：联通； 2：移动； 3：教育网； 4：盈科； 5：BGP； 6：中国香港
        /// </summary>
        [JsonProperty("IspId")]
        public long? IspId{ get; set; }

        /// <summary>
        /// 状态 0：创建中； 1：绑定中； 2：已绑定； 3：解绑中； 4：未绑定； 6：下线中； 9：创建失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 是否欠费隔离 1： 欠费隔离； 0： 正常。处在欠费隔离情况下的EIP不能进行任何管理操作。
        /// </summary>
        [JsonProperty("Arrears")]
        public long? Arrears{ get; set; }

        /// <summary>
        /// EIP所绑定的服务器实例ID，未绑定则为空
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 服务器别名
        /// </summary>
        [JsonProperty("InstanceAlias")]
        public string InstanceAlias{ get; set; }

        /// <summary>
        /// EIP解绑时间
        /// </summary>
        [JsonProperty("FreeAt")]
        public string FreeAt{ get; set; }

        /// <summary>
        /// EIP创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// EIP更新时间
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// EIP未绑定服务器时长（单位：秒）
        /// </summary>
        [JsonProperty("FreeSecond")]
        public long? FreeSecond{ get; set; }

        /// <summary>
        /// EIP所绑定的资源类型，-1：未绑定资源；0：黑石物理机，字段对应unInstanceId；1：Nat网关，字段对应natUid；2：云服务器字段对应vpcIp; 3: 托管机器，字段对应HInstanceId, HInstanceAlias
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// EIP计费模式，"flow"：流量计费； "bandwidth"：带宽计费
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// EIP带宽计费模式下的带宽上限（单位：MB）
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 最近一次操作变更的EIP计费模式，"flow"：流量计费； "bandwidth"：带宽计费
        /// </summary>
        [JsonProperty("LatestPayMode")]
        public string LatestPayMode{ get; set; }

        /// <summary>
        /// 最近一次操作变更的EIP计费模式对应的带宽上限值，仅在带宽计费模式下有效（单位：MB）
        /// </summary>
        [JsonProperty("LatestBandwidth")]
        public long? LatestBandwidth{ get; set; }

        /// <summary>
        /// 私有网络名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// EIP所绑定的NAT网关的数字ID，形如：1001,，未绑定则为空
        /// </summary>
        [JsonProperty("NatId")]
        public long? NatId{ get; set; }

        /// <summary>
        /// EIP所绑定的NAT网关实例ID，形如："nat-n47xxxxx"，未绑定则为空
        /// </summary>
        [JsonProperty("NatUid")]
        public string NatUid{ get; set; }

        /// <summary>
        /// EIP所绑定的云服务器IP(托管或者云服务器的IP），形如："10.1.1.3"。 注意：IP资源需要通过bmvpc模块注册或者申请后才可以绑定eip，接口使用申请子网IP和注册子网IP：,未绑定则为空
        /// </summary>
        [JsonProperty("VpcIp")]
        public string VpcIp{ get; set; }

        /// <summary>
        /// 私有网络实例ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 是否为独占类型EIP
        /// </summary>
        [JsonProperty("Exclusive")]
        public long? Exclusive{ get; set; }

        /// <summary>
        /// 私有网络的cidr
        /// </summary>
        [JsonProperty("VpcCidr")]
        public string VpcCidr{ get; set; }

        /// <summary>
        /// EIP ACL实例ID
        /// </summary>
        [JsonProperty("AclId")]
        public string AclId{ get; set; }

        /// <summary>
        /// EIP ACL名称
        /// </summary>
        [JsonProperty("AclName")]
        public string AclName{ get; set; }

        /// <summary>
        /// 托管机器实例ID
        /// </summary>
        [JsonProperty("HInstanceId")]
        public string HInstanceId{ get; set; }

        /// <summary>
        /// 托管机器别名
        /// </summary>
        [JsonProperty("HInstanceAlias")]
        public string HInstanceAlias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EipId", this.EipId);
            this.SetParamSimple(map, prefix + "EipName", this.EipName);
            this.SetParamSimple(map, prefix + "Eip", this.Eip);
            this.SetParamSimple(map, prefix + "IspId", this.IspId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Arrears", this.Arrears);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceAlias", this.InstanceAlias);
            this.SetParamSimple(map, prefix + "FreeAt", this.FreeAt);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "FreeSecond", this.FreeSecond);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "LatestPayMode", this.LatestPayMode);
            this.SetParamSimple(map, prefix + "LatestBandwidth", this.LatestBandwidth);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "NatId", this.NatId);
            this.SetParamSimple(map, prefix + "NatUid", this.NatUid);
            this.SetParamSimple(map, prefix + "VpcIp", this.VpcIp);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
            this.SetParamSimple(map, prefix + "VpcCidr", this.VpcCidr);
            this.SetParamSimple(map, prefix + "AclId", this.AclId);
            this.SetParamSimple(map, prefix + "AclName", this.AclName);
            this.SetParamSimple(map, prefix + "HInstanceId", this.HInstanceId);
            this.SetParamSimple(map, prefix + "HInstanceAlias", this.HInstanceAlias);
        }
    }
}

