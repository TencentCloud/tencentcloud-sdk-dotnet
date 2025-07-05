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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterSetting : AbstractModel
    {
        
        /// <summary>
        /// 付费方式。
        /// PREPAID 包年包月。
        /// POSTPAID_BY_HOUR 按量计费，默认方式。
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 是否为HA集群。
        /// </summary>
        [JsonProperty("SupportHA")]
        public bool? SupportHA{ get; set; }

        /// <summary>
        /// 集群所使用的安全组，目前仅支持一个。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 实例位置。
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 实例所在VPC。
        /// </summary>
        [JsonProperty("VPCSettings")]
        public VPCSettings VPCSettings{ get; set; }

        /// <summary>
        /// 实例登录配置。
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// 实例标签，示例：["{\"TagKey\":\"test-tag1\",\"TagValue\":\"001\"}","{\"TagKey\":\"test-tag2\",\"TagValue\":\"002\"}"]。
        /// </summary>
        [JsonProperty("TagSpecification")]
        public string[] TagSpecification{ get; set; }

        /// <summary>
        /// 元数据库配置。
        /// </summary>
        [JsonProperty("MetaDB")]
        public MetaDbInfo MetaDB{ get; set; }

        /// <summary>
        /// 实例硬件配置。
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public JobFlowResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// 是否申请公网IP，默认为false。
        /// </summary>
        [JsonProperty("PublicIpAssigned")]
        public bool? PublicIpAssigned{ get; set; }

        /// <summary>
        /// 包年包月配置，只对包年包月集群生效。
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// 集群置放群组。
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// 是否使用cbs加密。
        /// </summary>
        [JsonProperty("CbsEncryptFlag")]
        public bool? CbsEncryptFlag{ get; set; }

        /// <summary>
        /// 是否使用远程登录，默认为false。
        /// </summary>
        [JsonProperty("RemoteTcpDefaultPort")]
        public bool? RemoteTcpDefaultPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "SupportHA", this.SupportHA);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamObj(map, prefix + "VPCSettings.", this.VPCSettings);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamArraySimple(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamObj(map, prefix + "MetaDB.", this.MetaDB);
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
            this.SetParamSimple(map, prefix + "PublicIpAssigned", this.PublicIpAssigned);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamSimple(map, prefix + "DisasterRecoverGroupIds", this.DisasterRecoverGroupIds);
            this.SetParamSimple(map, prefix + "CbsEncryptFlag", this.CbsEncryptFlag);
            this.SetParamSimple(map, prefix + "RemoteTcpDefaultPort", this.RemoteTcpDefaultPort);
        }
    }
}

